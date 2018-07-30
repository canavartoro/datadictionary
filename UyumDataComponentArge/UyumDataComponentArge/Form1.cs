using GNL;
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

namespace UyumDataComponentArge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataComponent data = new DataComponent();
            data.DatabaseType = DatabaseTypes.Oracle;
            data.DataSource = "uyum_test";
            data.Username = "uyumsoft";
            data.Password = "uyumsoft";
            data.Open();


            TownCollection townCol = new TownCollection();
            townCol.Load(data);

            dataGridView1.DataSource = townCol;
            //data.GetDataTable();
        }
    }
}
