using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarehouseManagementDictionary
{
    public class TextTraceListener : System.Diagnostics.TraceListener
    {
        RichTextBox _richTextBox;
        private static bool outputGoster = true;
        public static bool OutputGoster
        {
            get { return outputGoster; }
            set { outputGoster = value; }
        }

        public TextTraceListener(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        delegate void SetLabelCallback(string str);
        public void SetThreadText(string str)
        {
            try
            {
                if (!object.ReferenceEquals(_richTextBox, null))
                {
                    if (_richTextBox.InvokeRequired)
                    {
                        SetLabelCallback d = new SetLabelCallback(SetThreadText);
                        _richTextBox.Invoke(d, new object[] { str });
                    }
                    else
                    {
                        if (_richTextBox.Lines.Count() > 600)
                            _richTextBox.Text = str;
                        else
                        {
                            _richTextBox.AppendText(str);
                            _richTextBox.ScrollToCaret();
                        }
                        Application.DoEvents();
                    }
                }
            }
            catch
            {
                ;
            }
        }

        public override void Write(string message)
        {
            if (outputGoster)
            {
                SetThreadText(message);
            }
        }

        public override void WriteLine(string message)
        {
            if (outputGoster)
            {
                SetThreadText(message + "\r");
            }
        }        
    }
}
