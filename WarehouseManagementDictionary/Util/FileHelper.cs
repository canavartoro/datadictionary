using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementDictionary.Util
{
    internal class FileHelper : IDisposable
    {
        string fileName = "";
        FileStream stream = null;
        StreamWriter writer = null;

        public FileHelper()
        {
        }

        public FileHelper(string fullname)
        {
            stream = new FileStream(fullname, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
        }

        public void Write(string data)
        {
            if (stream == null) return;

            if (writer == null)
            {
                writer = new StreamWriter(stream, Encoding.GetEncoding("windows-1253"));
                writer.AutoFlush = true;
            }

            writer.Write(data);
        }

        public void WriteLine(string data)
        {
            if (stream == null) return;

            if (writer == null)
            {
                writer = new StreamWriter(stream, Encoding.GetEncoding("windows-1253"));
                writer.AutoFlush = true;
            }

            writer.WriteLine(data);
        }

        public string[] ResourceNames()
        {
            string[] resNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            if (resNames != null && resNames.Length > 0)
            {
                foreach (string strName in resNames)
                {
                    if (!string.IsNullOrEmpty(strName))
                    {
                        System.Diagnostics.Trace.WriteLine("--------------------------------------->>>");
                        System.Diagnostics.Trace.WriteLine(strName);
                        System.Diagnostics.Trace.WriteLine("--------------------------------------->>>");
                    }
                }
            }
            return resNames;
        }

        public static string GetResourceInfo(string resourceName)
        {
            string data = "";
            try
            {
                using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)))
                {
                    data = reader.ReadToEnd();
                    reader.Close();

                    System.Diagnostics.Trace.WriteLine("--------------------------------------->>>");
                    System.Diagnostics.Trace.WriteLine(resourceName);
                    System.Diagnostics.Trace.WriteLine(data);
                    System.Diagnostics.Trace.WriteLine("--------------------------------------->>>");
                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Trace.WriteLine(exc.StackTrace);
            }
            return data;
        }

        #region IDisposable
        ~FileHelper()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;

        private void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                if (writer != null)
                {
                    writer.Close();
                    writer.Dispose();
                }
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                }

                writer = null;
                stream = null;
            }

            disposed = true;
        }
        #endregion
    }
}
