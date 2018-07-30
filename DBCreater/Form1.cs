using DevExpress.Xpo.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Uyum.Data;
using WHM.Module.BusinessObjects;

namespace DBCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestYaz();
            TestOku();
        }
        private void TestOku()
        {
            //= PostgreSqlConnectionProvider.GetConnectionString("192.168.2.19", 5432, "whm", "whm123", "WHM");
            DataComponent data = new DataComponent();
            data.DatabaseType = DatabaseTypes.PostgreSQL;
            //data.DataSource = "192.168.2.19";
            data.ConnectionString = "Server=192.168.2.19;User Id=whm;Password=whm123;Database=WHM;Port=5432";
            //data.Database = "WHM";
            //data.Username = "whm";
            //data.Password = "whm123";
            data.Open();

            MenuCollection mnuCol = new MenuCollection();
            mnuCol.Load(data);
            if (mnuCol.Count > 0)
            {
                foreach (var mnu in mnuCol)
                {
                    Console.WriteLine(mnu.Id);
                }
            }

            //data.GetDataTable();
        }
        private void TestYaz()
        {
            //WHM.Module.BusinessObjects.Menu m = DevExpress.Xpo.XpoDefault.Session.FindObject<WHM.Module.BusinessObjects.Menu>(DevExpress.Data.Filtering.CriteriaOperator.Parse("CmdId = ?", 1));
            //if (m == null)
            //{
            //    m = new WHM.Module.BusinessObjects.Menu(DevExpress.Xpo.XpoDefault.Session);
            //}
            //m.CmdId = 1;
            //m.CreateUserId = 1;
            //m.Save();
        }
    }
}
