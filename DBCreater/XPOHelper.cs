using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyum.Data;

namespace DBCreater
{
    static class XPOHelper
    {
        //[System.Diagnostics.Conditional("XPO")]
        public static void XPOStart()
        {
            try
            {
                //string conString = PostgreSqlConnectionProvider.GetConnectionString("192.168.2.19", 5432, "whm", "whm123", "WHM");
                string conString = PostgreSqlConnectionProvider.GetConnectionString("192.168.1.84", 5432, "postgres", "1", "ors_test");
                DevExpress.Xpo.Metadata.XPDictionary dictionary = new DevExpress.Xpo.Metadata.ReflectionDictionary();
                XpoDefault.DataLayer = XpoDefault.GetDataLayer(conString, AutoCreateOption.DatabaseAndSchema);
                DevExpress.Xpo.XpoDefault.Session = new DevExpress.Xpo.Session(XpoDefault.DataLayer);
                DevExpress.Xpo.Session.DefaultSession.UpdateSchema();
                //DevExpress.Xpo.Helpers.SessionStateStack.SuppressCrossThreadFailuresDetection = true;
                //DevExpress.Xpo.Session.DefaultSession.UpdateSchema();

                //IDataStore store = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.SchemaAlreadyExists);
                //var layer = new ThreadSafeDataLayer(dictionary, store);

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
