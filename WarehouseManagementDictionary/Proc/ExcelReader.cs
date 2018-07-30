using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementDictionary.BusinessObjects;

namespace WarehouseManagementDictionary.Proc
{
    public class ExcelReader : IList<Tables>, ICollection<Tables>, IEnumerable<Tables>, IDisposable
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        string fileExtension = "";
        string Import_FileName = "";
        private List<Tables> innerList = null;
        private List<string> excelTables = null;

        public ExcelReader(string filename)
        {
            innerList = new List<Tables>();
            this.Import_FileName = filename;
            FileInfo fi = new FileInfo(filename);
            if (fi.Exists)
            {
                fileExtension = fi.Extension.ToLower();
                Connect();
            }
            else
            {
                throw new FileNotFoundException(filename);
            }
        }

        public ExcelReader()
        {
            innerList = new List<Tables>();
            this.Import_FileName = "";
            TablesInner();
        }

        private void Connect()
        {

            if (conn == null)
            {
                conn = new OleDbConnection();
                if (fileExtension == ".xls")
                    conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 8.0;HDR=YES;'";
                if (fileExtension == ".xlsx")
                    conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Import_FileName + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;'";
            }

            if (conn.State != ConnectionState.Open)
                conn.Open();

            ExcelSheets();

            comm = conn.CreateCommand();
            Tables();
        }

        private void Tables()
        {
            comm.Parameters.Clear();
            comm.CommandText = "SELECT * FROM [Tablo Listesi$]";
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int order = 1, orderClm = 1;
            string modul, type, tablename;
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    orderClm = 1;
                    string name = dt.Rows[i][1].ToString();
                    if (!string.IsNullOrEmpty(name))
                    {
                        modul = name.Substring(0, 3).ToUpper(CultureInfo.CreateSpecificCulture("en-US"));
                        if (BusinessObjects.Tables.modules.Contains(modul) && name.IndexOf("_") != -1)
                        {
                            type = name.Substring(3, 1);
                            tablename = Utility.TextInfo.ToTitleCase(name.Substring(5, name.Length - 5)).Replace('_', ' ').Replace(" ", String.Empty);
                        }
                        else
                        {
                            modul = "";
                            type = "";
                            tablename = Utility.TextInfo.ToTitleCase(name).Replace('_', ' ').Replace(" ", String.Empty);
                        }

                        Tables tbl = XpoDefault.Session.FindObject<Tables>(CriteriaOperator.Parse("Name = ?", name));
                        if (tbl == null)
                        {
                            tbl = new BusinessObjects.Tables(XpoDefault.Session);
                        }

                        try
                        {
                            if (excelTables.Contains(name))
                            {
                                comm.CommandText = string.Format("SELECT * FROM [{0}$]", name);
                                OleDbDataAdapter adapterColm = new OleDbDataAdapter(comm);
                                DataTable dtClm = new DataTable();
                                adapterColm.Fill(dtClm);
                                if (dtClm != null && dtClm.Rows.Count > 0)
                                {
                                    for (int l = 0; l < dtClm.Rows.Count; l++)
                                    {
                                        string nameClm = dtClm.Rows[l][1].ToString();
                                        if (!string.IsNullOrEmpty(nameClm))
                                        {
                                            Fields clm = XpoDefault.Session.FindObject<Fields>(CriteriaOperator.Parse("Name = ? And Table = ?", nameClm, tbl));
                                            if (clm == null)
                                            {
                                                clm = new BusinessObjects.Fields(XpoDefault.Session);
                                            }
                                            clm.Table = tbl;
                                            clm.Order = orderClm;
                                            clm.Name = dtClm.Rows[l][1].ToString();
                                            clm.FieldName = Utility.TextInfo.ToTitleCase(clm.Name).Replace('_', ' ').Replace(" ", String.Empty);
                                            clm.ColumnDataType = dtClm.Rows[l][2].ToString().ToLower();
                                            clm.ColumnCScrapType = Fields.ToCScrap(dtClm.Rows[l][2].ToString().ToLower());
                                            clm.ColumnCScrapDefaultValue = Fields.CScrapDefaultValue(dtClm.Rows[l][2].ToString().ToLower());
                                            clm.Description = dtClm.Rows[l][3].ToString();
                                            clm.IsPrimaryKey = dtClm.Rows[l][4].ToString() != "";
                                            clm.IsRequired = dtClm.Rows[l][5].ToString() != "";
                                            tbl.Columns.Add(clm); orderClm++;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                        }

                        tbl.Order = order;
                        tbl.Name = dt.Rows[i][1].ToString();
                        tbl.ModulName = modul;
                        tbl.TableType = type;
                        tbl.TableName = tablename;
                        tbl.Description = dt.Rows[i][2].ToString();
                        tbl.Prefix = dt.Rows[i][3].ToString();
                        if (XpoDefault.Session.IsNewObject(tbl))
                        {

                            BusinessObjects.Fields clmcreateuser = new BusinessObjects.Fields(XpoDefault.Session);
                            clmcreateuser.Table = tbl;
                            clmcreateuser.Order = orderClm;
                            clmcreateuser.Name = "create_user_id";
                            clmcreateuser.FieldName = Utility.TextInfo.ToTitleCase("create_user_id").Replace('_', ' ').Replace(" ", String.Empty);
                            clmcreateuser.ColumnDataType = "integer";
                            clmcreateuser.ColumnCScrapType = Fields.ToCScrap("integer");
                            clmcreateuser.ColumnCScrapDefaultValue = Fields.CScrapDefaultValue("integer");
                            clmcreateuser.Description = "";
                            clmcreateuser.IsPrimaryKey = false;
                            clmcreateuser.IsRequired = false;
                            tbl.Columns.Add(clmcreateuser); orderClm++;

                            BusinessObjects.Fields clmcreatedate = new BusinessObjects.Fields(XpoDefault.Session);
                            clmcreatedate.Table = tbl;
                            clmcreatedate.Order = orderClm;
                            clmcreatedate.Name = "create_date";
                            clmcreatedate.FieldName = Utility.TextInfo.ToTitleCase("create_date").Replace('_', ' ').Replace(" ", String.Empty);
                            clmcreatedate.ColumnDataType = "timestamp";
                            clmcreatedate.ColumnCScrapType = Fields.ToCScrap("timestamp");
                            clmcreatedate.ColumnCScrapDefaultValue = Fields.CScrapDefaultValue("timestamp");
                            clmcreatedate.Description = "";
                            clmcreatedate.IsPrimaryKey = false;
                            clmcreatedate.IsRequired = false;
                            tbl.Columns.Add(clmcreatedate); orderClm++;

                            BusinessObjects.Fields clmupdateuser = new BusinessObjects.Fields(XpoDefault.Session);
                            clmupdateuser.Table = tbl;
                            clmupdateuser.Order = orderClm;
                            clmupdateuser.Name = "update_user_id";
                            clmupdateuser.FieldName = Utility.TextInfo.ToTitleCase("update_user_id").Replace('_', ' ').Replace(" ", String.Empty);
                            clmupdateuser.ColumnDataType = "integer";
                            clmupdateuser.ColumnCScrapType = Fields.ToCScrap("integer");
                            clmupdateuser.ColumnCScrapDefaultValue = Fields.CScrapDefaultValue("integer");
                            clmupdateuser.Description = "";
                            clmupdateuser.IsPrimaryKey = false;
                            clmupdateuser.IsRequired = false;
                            tbl.Columns.Add(clmupdateuser); orderClm++;

                            BusinessObjects.Fields clmupdatedate = new BusinessObjects.Fields(XpoDefault.Session);
                            clmupdatedate.Table = tbl;
                            clmupdatedate.Order = orderClm;
                            clmupdatedate.Name = "update_date";
                            clmupdatedate.FieldName = Utility.TextInfo.ToTitleCase("update_date").Replace('_', ' ').Replace(" ", String.Empty);
                            clmupdatedate.ColumnDataType = "timestamp";
                            clmupdatedate.ColumnCScrapType = Fields.ToCScrap("timestamp");
                            clmupdatedate.ColumnCScrapDefaultValue = Fields.CScrapDefaultValue("timestamp");
                            clmupdatedate.Description = "";
                            clmupdatedate.IsPrimaryKey = false;
                            clmupdatedate.IsRequired = false;
                            tbl.Columns.Add(clmupdatedate); orderClm++;

                            tbl.Save();
                        }
                        this.innerList.Add(tbl); order++;
                    }
                    else
                        break;
                }
                this.innerList.TrimExcess();
            }
        }

        private void TablesInner()
        {
            this.innerList = new XPCollection<BusinessObjects.Tables>(XpoDefault.Session, CriteriaOperator.Parse(""), new SortProperty[] { new SortProperty() { PropertyName = "Order", Direction = DevExpress.Xpo.DB.SortingDirection.Ascending, Property = "Order" } }).ToList();
        }

        public bool Exec(string commandText, IDataParameter[] parameters)
        {
            Connect();

            Utility.WriteTrace(commandText);

            comm.Parameters.Clear();
            comm.CommandText = commandText;
            if (parameters != null)
            {
                for (int loop = 0; loop < parameters.Length; loop++)
                {
                    comm.Parameters.Add(parameters[loop]);
                }
            }
            return comm.ExecuteNonQuery() > 0;
        }

        public IDataReader ExecReader(string commandText, IDataParameter[] parameters)
        {
            Connect();

            Utility.WriteTrace(commandText);

            comm.Parameters.Clear();
            comm.CommandText = commandText;
            if (parameters != null)
            {
                for (int loop = 0; loop < parameters.Length; loop++)
                {
                    comm.Parameters.Add(parameters[loop]);
                }
            }
            return comm.ExecuteReader();
        }

        public object ExecuteScalar(string commandText, IDataParameter[] parameters)
        {
            Connect();

            Utility.WriteTrace(commandText);

            comm.Parameters.Clear();
            comm.CommandText = commandText;
            if (parameters != null)
            {
                for (int loop = 0; loop < parameters.Length; loop++)
                {
                    comm.Parameters.Add(parameters[loop]);
                }
            }
            return comm.ExecuteScalar();
        }

        #region IDisposable
        ~ExcelReader()
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
                if (comm != null)
                {
                    comm.Dispose();
                }
                if (conn != null)
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                    conn.Dispose();
                }
                conn = null;
                comm = null;
            }

            disposed = true;
        }
        #endregion

        public int IndexOf(Tables item)
        {
            return innerList.IndexOf(item);
        }

        public void Insert(int index, Tables item)
        {
            innerList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            innerList.RemoveAt(index);
        }

        public Tables this[int index]
        {
            get
            {
                return innerList[index];
            }
            set
            {
                innerList[index] = value;
            }
        }

        public void Add(Tables item)
        {
            innerList.Add(item);
        }

        public void Clear()
        {
            innerList.Clear();
        }

        public bool Contains(Tables item)
        {
            return innerList.Contains(item);
        }

        public void CopyTo(Tables[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return innerList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(Tables item)
        {
            return innerList.Remove(item);
        }

        public IEnumerator<Tables> GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return innerList.GetEnumerator();
        }

        private void ExcelSheets()
        {
            DataTable excelSheets = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            if (excelSheets != null && excelSheets.Rows.Count > 0)
            {
                excelTables = new List<string>();
                for (int i = 0; i < excelSheets.Rows.Count; i++)
                {
                    excelTables.Add(excelSheets.Rows[i]["TABLE_NAME"].ToString().Replace("$", ""));
                }
                excelTables.TrimExcess();
            }
        }
    }
}
