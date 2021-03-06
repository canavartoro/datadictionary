using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ORSMESEntegrasyonu.Util
{
    public class TextWriterTraceListener : TraceListener
    {
        private readonly StreamWriter Writer;

        public TextWriterTraceListener()
        {
            try
            {
                string dir = Utility.AppPath + "\\Trace\\";
                //System.Windows.Forms.MessageBox.Show(dir);
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                string trace = dir + DateTime.Now.ToString("ddMMyy") + ".txt";
                Writer = new StreamWriter(trace, false, Encoding.GetEncoding("windows-1254"));

                Writer.AutoFlush = true;
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata dosyasİ açİlamAd:" + exc.Message);
            }
        }


        ~TextWriterTraceListener()
        {
            try
            {
                if (Writer != null)
                    Writer.Close();
            }
            catch
            {
                ;
            }
        }


        public override void Write(string message)
        {
            try
            {
                Writer.Write("-> " + DateTime.Now.ToString() + "\t" + message);
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata dosyasİna yazİlamAd:" + exc.Message);
            }
        }

        public override void WriteLine(string message)
        {
            try
            {
                Writer.WriteLine("-> " + DateTime.Now.ToString() + "\t" + message);
            }
            catch (Exception exc)
            {
                Utility.Hata("Hata kaydedilemedi:" + exc.Message);
            }
        }
    }
}