using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementDictionary.BusinessObjects;
using WarehouseManagementDictionary.Proc;
using WarehouseManagementDictionary.Util;

namespace WarehouseManagementDictionary
{
    public partial class FormDictionary : Form
    {
        public FormDictionary()
        {
            InitializeComponent();
        }

        private void btnschemafile_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Multiselect = false;
            op.Filter = "Excel |*.xls|Tüm dosyalar|*.*";
            op.FilterIndex = 1;
            if (op.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(op.FileName);
                if (fi.Exists && fi.Extension.ToLower() == ".xls")
                {
                    txtschemafile.Text = fi.FullName;
                    SaveSettings();
                }
            }
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            SaveSettings();
            using (ExcelReader excel = new ExcelReader(txtschemafile.Text))
            {
                listViewTables.Items.Clear();
                for (int i = 0; i < excel.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = excel[i].Order.ToString();
                    item.Checked = true;
                    item.SubItems.Add(excel[i].Name.ToString());
                    item.SubItems.Add(excel[i].Description.ToString());
                    item.SubItems.Add(excel[i].Prefix.ToString());
                    listViewTables.Items.Add(item);
                }
            }
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            SaveSettings();

            if (string.IsNullOrEmpty(txtpath.Text))
            {
                MessageBox.Show("Dosya yolu seçin!");
                return;
            }

            CheckDir(Tables.modules);

            using (ExcelReader excel = new ExcelReader())
            {
                TextInfo txtInfo = new CultureInfo("en-us", false).TextInfo;
                for (int i = 0; i < excel.Count; i++)
                {
                    //XPOBaseClassFileWrite();
                    CollectionClassFileWrite(excel[i]);
                    XPOClassFileWrite(excel[i]);
                    ClassFileWrite(excel[i]);
                    XPOClassDesignerFileWrite(excel[i]);
                }
            }

            System.Diagnostics.Process.Start(txtpath.Text);
        }

        private void CheckDir(string[] directories)
        {
            DirectoryInfo d = new DirectoryInfo(txtpath.Text + "\\");
            if (d.Exists) d.Delete(true);

            DirectoryInfo d2 = new DirectoryInfo(txtpath.Text + "\\");
            if (!d2.Exists) d2.Create();

            Thread.Sleep(100);

            foreach (string dir in directories)
            {
                DirectoryInfo dirApp = new DirectoryInfo(txtpath.Text + "\\" + dir);
                if (!dirApp.Exists) dirApp.Create();
            }
        }

        //[System.Diagnostics.Conditional("UYUM")]
        private void CollectionClassFileWrite(Tables tbl)
        {
            if (rdbUyum.Checked == false) return;

            string tabs = "";
            using (FileHelper w = new FileHelper(txtpath.Text + "\\" + tbl.ModulName + "\\" + tbl.TableName + "Collection.cs"))
            {

                w.WriteLine("using System;");
                w.WriteLine("using System.Text;");
                w.WriteLine("using Uyum.Net;");
                w.WriteLine("using Uyum.Objects;");
                w.WriteLine("using System.Runtime.InteropServices;");
                w.WriteLine("using System.Collections.Generic;");
                w.WriteLine("");
                w.WriteLine("namespace " + txtnamespace.Text);
                w.WriteLine("{");
                tabs = "\t";
                w.WriteLine(string.Format("{0}[Guid(\"{1}\")]", tabs, Guid.NewGuid().ToString("D")));
                w.WriteLine(string.Concat("\t[UyumTable(\"", tbl.Name, "\",Database=\"" + txtschema.Text + "\", InsertStoredProcedure=\"", tbl.Name, "_i\", UpdateStoredProcedure=\"", tbl.Name, "_u\", DeleteStoredProcedure=\"", tbl.Name, "_d\", SelectStoredProcedure=\"", tbl.Name, "_s\")]"));
                w.WriteLine(string.Format("{0}public class {1}Collection : UyumObjectCollection", tabs, tbl.TableName));
                w.WriteLine(tabs + "{");
                w.WriteLine("");
                tabs = "\t\t";
                w.WriteLine(tabs + "public " + tbl.TableName + "Collection()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\tbase._ItemType = typeof(" + tbl.TableName + ");");
                w.WriteLine(tabs + "}");
                w.WriteLine("");
                w.WriteLine(tabs + "public override IUyumObject CreateItem()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\treturn new " + tbl.TableName + "();");
                w.WriteLine(tabs + "}");
                w.WriteLine("");
                w.WriteLine(tabs + "public " + tbl.TableName + " this[int index]");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\tget { return base.innerList[index] as " + tbl.TableName + "; }");
                w.WriteLine(tabs + "}");
                w.WriteLine("");

                w.WriteLine(tabs + "public static explicit operator List<" + tbl.TableName + "Info>(" + tbl.TableName + "Collection enumarable)");
                //w.WriteLine(tabs + "public static List<" + tbl.TableName + "Info> ToInfoList(UyumObjectCollection enumarable)");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\tList<" + tbl.TableName + "Info> list = new List<" + tbl.TableName + "Info>();");
                w.WriteLine(tabs + "\tif (!object.ReferenceEquals(enumarable, null))");
                w.WriteLine(tabs + "\t{");
                w.WriteLine(tabs + "\t\tfor (int i = 0; i < enumarable.Count; i++)");
                w.WriteLine(tabs + "\t\t{");
                w.WriteLine(tabs + "\t\t\t" + tbl.TableName + " uyumObject = enumarable.GetItemFromIndex(i) as " + tbl.TableName + ";");
                w.WriteLine(tabs + "\t\t\t" + tbl.TableName + "Info item = new BusinessObjects." + tbl.TableName + "Info();");
                for (int i = 0; i < tbl.Columns.Count; i++)
                {
                    if (tbl.Columns[i].IsPrimaryKey)
                    {
                        w.WriteLine(tabs + "\t\t\titem.Id = uyumObject.Id;");
                    }
                    else
                    {
                        w.WriteLine(tabs + "\t\t\titem." + tbl.Columns[i].FieldName + " = uyumObject." + tbl.Columns[i].FieldName + ";");
                    }
                }
                w.WriteLine(tabs + "\t\t\tlist.Add(item);");
                w.WriteLine(tabs + "\t\t}");
                w.WriteLine(tabs + "\t}");
                w.WriteLine(tabs + "\tlist.TrimExcess();");
                w.WriteLine(tabs + "\treturn list;");
                w.WriteLine(tabs + "}");
                w.WriteLine("");
                w.WriteLine("\t}");
                w.WriteLine("}");
            }
        }

        //[System.Diagnostics.Conditional("XPO")]
        private void XPOClassFileWrite(Tables tbl)
        {
            if (rdbXpo.Checked == false) return;

            string tabs = "";
            using (FileHelper w = new FileHelper(txtpath.Text + "\\" + tbl.ModulName + "\\" + tbl.TableName + ".cs"))
            {

                w.WriteLine("using System;");
                w.WriteLine("using System.Linq;");
                w.WriteLine("using System.Text;");
                w.WriteLine("using DevExpress.Xpo;");
                w.WriteLine("using System.Runtime.InteropServices;");
                w.WriteLine("");
                w.WriteLine("");
                w.WriteLine("namespace " + txtnamespace.Text);
                w.WriteLine("{");
                tabs = "\t";
                w.WriteLine(tabs + "[Serializable]");
                w.WriteLine(tabs + "public partial class " + tbl.TableName + " : XPBaseObject");
                w.WriteLine(tabs + "{");
                w.WriteLine("");
                tabs = "\t\t";

                w.WriteLine(tabs + "protected override void OnSaving()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\tbase.OnSaving();");
                w.WriteLine(tabs + "}");
                w.WriteLine("");
                w.WriteLine(tabs + "protected override void OnDeleting()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\tbase.OnDeleting();");
                w.WriteLine(tabs + "}");
                w.WriteLine("");
                w.WriteLine("\t}");
                w.WriteLine("}");
            }
        }

        //[System.Diagnostics.Conditional("UYUM")]
        private void ClassFileWrite(Tables tbl)
        {
            if (rdbUyum.Checked == false) return;

            string tabs = "";
            using (FileHelper w = new FileHelper(txtpath.Text + "\\" + tbl.ModulName + "\\" + tbl.TableName + ".cs"))
            {

                w.WriteLine("using System;");
                w.WriteLine("using System.Text;");
                w.WriteLine("using Uyum.Net;");
                w.WriteLine("using Uyum.Objects;");
                w.WriteLine("using System.Runtime.Serialization;");
                w.WriteLine("using System.Runtime.InteropServices;");
                w.WriteLine("");
                w.WriteLine("");
                w.WriteLine("namespace " + txtnamespace.Text);
                w.WriteLine("{");
                tabs = "\t";
                w.WriteLine(string.Format("{0}[Guid(\"{1}\")]", tabs, Guid.NewGuid().ToString("D")));
                w.WriteLine(string.Format("{0}public class {1} : UyumObjectBase", tabs, tbl.TableName));
                w.WriteLine(tabs + "{");
                w.WriteLine("");

                tabs = "\t\t";

                w.WriteLine(tabs + "public " + tbl.TableName + "()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "}");
                w.WriteLine("");

                for (int i = 0; i < tbl.Columns.Count; i++)
                {
                    w.WriteLine(tabs + "private " + tbl.Columns[i].ColumnCScrapType + " _" + tbl.Columns[i].FieldName + " = " + tbl.Columns[i].ColumnCScrapDefaultValue + ";//" + tbl.Columns[i].ColumnDataType);
                }

                w.WriteLine("");

                for (int i = 0; i < tbl.Columns.Count; i++)
                {

                    w.WriteLine(tabs + "[Server]");
                    if (tbl.Columns[i].IsPrimaryKey)
                    {
                        w.WriteLine(tabs + "[DataInt32(\"" + tbl.ShortName + "_id\", IsIdentity = true)]");
                        w.WriteLine(tabs + "[UyumPrimaryKey(0)]");
                        w.WriteLine(tabs + "public override int Id");
                        w.WriteLine(tabs + "{");
                        w.WriteLine(tabs + "\tget { return base.Id; }");
                        w.WriteLine(tabs + "\tset { base.Id = value; }");
                        w.WriteLine(tabs + "}");
                    }
                    else
                    {
                        w.WriteLine(tabs + tbl.Columns[i].AttributeString());
                        w.WriteLine(tabs + "public " + tbl.Columns[i].ColumnCScrapType + " " + tbl.Columns[i].FieldName);
                        w.WriteLine(tabs + "{");
                        w.WriteLine(tabs + "\tget { return _" + tbl.Columns[i].FieldName + "; }");
                        w.WriteLine(tabs + "\tset { _" + tbl.Columns[i].FieldName + " = value; }");
                        w.WriteLine(tabs + "}");
                    }

                    w.WriteLine("");
                }

                w.WriteLine("");

                w.WriteLine(tabs + "public static implicit operator " + tbl.TableName + "Info(" + tbl.TableName + " item)");
                //w.WriteLine(tabs + "public static List<" + tbl.TableName + "Info> ToInfoList(UyumObjectCollection enumarable)");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "\t" + tbl.TableName + "Info info = new " + tbl.TableName + "Info();");
                w.WriteLine(tabs + "\tif (!object.ReferenceEquals(item, null))");
                w.WriteLine(tabs + "\t{");
                for (int i = 0; i < tbl.Columns.Count; i++)
                {
                    if (tbl.Columns[i].IsPrimaryKey)
                    {
                        w.WriteLine(tabs + "\t\t\tinfo.Id = item.Id;");
                    }
                    else
                    {
                        w.WriteLine(tabs + "\t\t\tinfo." + tbl.Columns[i].FieldName + " = item." + tbl.Columns[i].FieldName + ";");
                    }
                }
                w.WriteLine(tabs + "\t}");
                w.WriteLine(tabs + "\treturn info;");
                w.WriteLine(tabs + "}");
                w.WriteLine("");

                w.WriteLine("");
                w.WriteLine("\t}");


                w.WriteLine("\t[DataContract(Name = \"" + tbl.TableName + "\")]");
                w.WriteLine("\tpublic class " + tbl.TableName + "Info");
                w.WriteLine("\t{");
                w.WriteLine("");
                w.WriteLine(tabs + "public " + tbl.TableName + "Info()");
                w.WriteLine(tabs + "{");
                w.WriteLine(tabs + "}");
                w.WriteLine("");

                for (int i = 0; i < tbl.Columns.Count; i++)
                {

                    if (tbl.Columns[i].IsPrimaryKey)
                    {
                        w.WriteLine(tabs + "[DataMember(Name = \"" + tbl.ShortName + "_id\")]");
                        w.WriteLine(tabs + "public int Id { get; set; }");
                    }
                    else
                    {
                        w.WriteLine(tabs + "[DataMember(Name = \"" + tbl.Columns[i].Name + "\")]");
                        w.WriteLine(tabs + "public " + tbl.Columns[i].ColumnCScrapType + " " + tbl.Columns[i].FieldName + " { get; set; }");
                    }

                    w.WriteLine("");
                }

                w.WriteLine("\t}");
                w.WriteLine("}");
            }
        }

        //[System.Diagnostics.Conditional("XPO")]
        private void XPOClassDesignerFileWrite(Tables tbl)
        {
            if (rdbXpo.Checked == false) return;

            string tabs = "";
            using (FileHelper w = new FileHelper(txtpath.Text + "\\" + tbl.ModulName + "\\" + tbl.TableName + ".Designer.cs"))
            {

                w.WriteLine("using System;");
                w.WriteLine("using System.Text;");
                w.WriteLine("using System.Linq;");
                w.WriteLine("using DevExpress.Xpo;");
                w.WriteLine("using System.ComponentModel;");
                w.WriteLine("using System.Xml.Serialization;");
                w.WriteLine("using System.Collections.Generic;");
                w.WriteLine("using System.Runtime.InteropServices;");
                w.WriteLine("");
                w.WriteLine("namespace " + txtnamespace.Text);
                w.WriteLine("{");
                tabs = "\t";
                w.WriteLine(tabs + "[DeferredDeletion(false)]");
                w.WriteLine(tabs + "[OptimisticLocking(false)]");
                w.WriteLine(tabs + "[Persistent(\"" + tbl.Name + "\")]");
                w.WriteLine(tabs + "public partial class " + tbl.TableName);
                w.WriteLine(tabs + "{");
                w.WriteLine("");
                tabs = "\t\t";
                w.WriteLine(tabs + "public " + tbl.TableName + "() { }");
                w.WriteLine(tabs + "");
                w.WriteLine(tabs + "public " + tbl.TableName + "(Session session) : base(session) { }");
                w.WriteLine(tabs + "");


                for (int i = 0; i < tbl.Columns.Count; i++)
                {
                    w.WriteLine(tabs + "private " + Fields.ToCScrap(tbl.Columns[i].ColumnDataType) + " f" + tbl.Columns[i].FieldName + " = " + Fields.CScrapDefaultValue(tbl.Columns[i].ColumnDataType) + ";");
                    w.WriteLine(tabs + tbl.Columns[i].ToColumnXPOLenght());
                    if (tbl.Columns[i].IsPrimaryKey)
                    {
                        w.WriteLine(tabs + "[Key(AutoGenerate = true)]");
                    }
                    w.WriteLine(tabs + "[Persistent(\"" + tbl.Columns[i].Name + "\")]");
                    if (tbl.Columns[i].ColumnCScrapType == "bool")
                    {
                        w.WriteLine(tabs + "[DbType(\"int2 DEFAULT 0\")]");
                        w.WriteLine(tabs + "[ValueConverter(typeof(WarehouseManagementDictionary.BoolConverter))]");
                    }
                    w.WriteLine(tabs + "public " + tbl.Columns[i].ColumnCScrapType + " " + tbl.Columns[i].FieldName);
                    w.WriteLine(tabs + "{");
                    w.WriteLine(tabs + "\tget { return f" + tbl.Columns[i].FieldName + "; }");
                    w.WriteLine(tabs + "\tset { SetPropertyValue<" + tbl.Columns[i].ColumnCScrapType + ">(\"" + tbl.Columns[i].FieldName + "\", ref f" + tbl.Columns[i].FieldName + ", value); }");
                    w.WriteLine(tabs + "}");
                    w.WriteLine("");
                }

                w.WriteLine("");
                w.WriteLine("\t}");
                w.WriteLine("}");
            }
        }

        //[System.Diagnostics.Conditional("XPO")]
        private void XPOBaseClassFileWrite()
        {
            string path = txtpath.Text + "\\" + "\\BusinessObjects\\";
            using (FileHelper w = new FileHelper(path + "IKartTablo.cs"))
            {
                w.Write(FileHelper.GetResourceInfo("WarehouseManagementDictionary.Template.IKartTablo.txt").Replace("#namespace#", txtnamespace.Text));
            }

            using (FileHelper w = new FileHelper(path + "KartTablo.cs"))
            {
                w.Write(FileHelper.GetResourceInfo("WarehouseManagementDictionary.Template.KartTablo.txt").Replace("#namespace#", txtnamespace.Text));
            }

            using (FileHelper w = new FileHelper(path + "IHareketTablo.cs"))
            {
                w.Write(FileHelper.GetResourceInfo("WarehouseManagementDictionary.Template.IHareketTablo.txt").Replace("#namespace#", txtnamespace.Text));
            }

            using (FileHelper w = new FileHelper(path + "HareketTablo.cs"))
            {
                w.Write(FileHelper.GetResourceInfo("WarehouseManagementDictionary.Template.HareketTablo.txt").Replace("#namespace#", txtnamespace.Text));
            }

        }

        private void FormDictionary_Load(object sender, EventArgs e)
        {
            txtpath.Text = Ayarlar.Path;
            txtschemafile.Text = Ayarlar.ExcelPath;
            txtnamespace.Text = Ayarlar.NameSpace;
            txtschema.Text = Ayarlar.Schema;
            rdbUyum.Checked = Ayarlar.UyumClass;
            rdbXpo.Checked = !Ayarlar.UyumClass;

            using (ExcelReader excel = new ExcelReader())
            {
                listViewTables.Items.Clear();
                for (int i = 0; i < excel.Count; i++)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = excel[i].Order.ToString();
                    item.Checked = true;
                    item.SubItems.Add(excel[i].Name.ToString());
                    item.SubItems.Add(excel[i].Description.ToString());
                    item.SubItems.Add(excel[i].Prefix.ToString());
                    listViewTables.Items.Add(item);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "Dosyaların kaydedileceği klasörü seçin";
            if (!string.IsNullOrEmpty(txtpath.Text) && File.Exists(txtpath.Text)) fd.SelectedPath = txtpath.Text;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtpath.Text = fd.SelectedPath;
                SaveSettings();
            }
        }

        private void SaveSettings()
        {
            Ayarlar.Path = txtpath.Text;
            Ayarlar.ExcelPath = txtschemafile.Text;
            Ayarlar.NameSpace = txtnamespace.Text;
            Ayarlar.Schema = txtschema.Text;
            Ayarlar.UyumClass = rdbUyum.Checked;
        }
    }
}
