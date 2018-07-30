using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementDictionary.BusinessObjects;

namespace WarehouseManagementDictionary
{
    public partial class FormDataDictionary : Form
    {
        public FormDataDictionary()
        {
            InitializeComponent();
        }

        #region Grid Kolon Ayar
        private void GridView1_ColumnWidthChanged(object sender, DevExpress.XtraGrid.Views.Base.ColumnEventArgs e)
        {
            SaveLayout();
        }

        private void GridView1_ColumnPositionChanged(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void GridView1_ColumnChanged(object sender, EventArgs e)
        {
            SaveLayout();
        }

        private void gridView1_ShowCustomizationForm(object sender, EventArgs e)
        {
            if (gridView1.CustomizationForm != null)
            {
                gridView1.CustomizationForm.FormClosing += CustomizationForm_FormClosing;
            }
        }

        private void CustomizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLayout();
        }

        private void SaveLayout()
        {
            try
            {
                gridView1.SaveLayoutToXml(Application.StartupPath + "\\fieldview.xml");
            }
            catch (Exception exc)
            {
                Trace.WriteLine(exc.Message);
                Trace.WriteLine(exc.StackTrace);
            }
        }
        #endregion

        private void FormDataDictionary_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.Listeners.Add(new TextTraceListener(richTextBox1));
            gridControl1.DataSource = new XPCollection<Fields>(XpoDefault.Session, CriteriaOperator.Parse("Oid = -1"), new SortProperty[] { new SortProperty() { Property = "Order", PropertyName = "Order" } });
            if (File.Exists(Application.StartupPath + "\\fieldview.xml"))
            {
                gridView1.RestoreLayoutFromXml(Application.StartupPath + "\\fieldview.xml");
            }
            gridView1.ColumnChanged += GridView1_ColumnChanged;
            gridView1.ColumnPositionChanged += GridView1_ColumnPositionChanged;
            gridView1.ColumnWidthChanged += GridView1_ColumnWidthChanged;
            gridView1.ShowCustomizationForm += gridView1_ShowCustomizationForm;

            var modules = (from q in new XPQuery<Tables>(XpoDefault.Session)
                           group q by q.ModulName into grp
                           select grp.Key).ToList();
            foreach (string m in modules)
            {
                TreeNode node = new TreeNode();
                node.Text = m;

                var tbl = new XPCollection<Tables>(XpoDefault.Session, CriteriaOperator.Parse("ModulName = ?", m), null);
                foreach (var t in tbl)
                {
                    TreeNode tn = new TreeNode();
                    tn.Text = t.TableName;
                    tn.Tag = t;
                    node.Nodes.Add(tn);
                }

                treeTablo.Nodes.Add(node);
            }

        }

        private void treeTablo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                Tables tbl = e.Node.Tag as Tables;
                if (tbl != null)
                {
                    propertyGrid1.SelectedObject = tbl;
                    gridControl1.DataSource = new XPCollection<Fields>(XpoDefault.Session, CriteriaOperator.Parse("Table = ?", tbl), new SortProperty[] { new SortProperty() { Property = "Order", PropertyName = "Order" } });
                }
            }
        }
    }
}
