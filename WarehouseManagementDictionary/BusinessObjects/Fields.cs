using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WarehouseManagementDictionary.BusinessObjects
{
    [Persistent("FIELDS")]
    [OptimisticLocking(false), DeferredDeletion(false)]
    [DebuggerDisplay("Isim = {Isim}, Adres = {Adres}")]
    public class Fields : XPObject
    {
        public Fields() { }
        public Fields(Session session) : base(session) { }

        [XmlIgnore(), Association("Table-Column")]
        public Tables Table { get; set; }

        [Size(300)]
        [Persistent("ORDER")]
        public int Order { get; set; }

        [Size(300)]
        [Persistent("NAME")]
        public string Name { get; set; }

        [Size(300)]
        [Persistent("COLUMN_NAME")]
        public string FieldName { get; set; }

        [Size(300)]
        [Persistent("DATATYPE")]
        public string ColumnDataType { get; set; }

        [Size(300)]
        [Persistent("SCRAP_DATATYPE")]
        public string ColumnCScrapType { get; set; }

        [Size(300)]
        [Persistent("SCRAP_DEFAULT")]
        public string ColumnCScrapDefaultValue { get; set; }

        [Persistent("DESCRIPTION")]
        [Size(SizeAttribute.Unlimited)]
        public string Description { get; set; }


        [Persistent("ISPRIMARYKEY")]
        public bool IsPrimaryKey { get; set; }//, IsIdentity = true


        [NonPersistent]
        public string IsPrimaryKeyString //, IsIdentity = true
        {
            get
            {
                return IsPrimaryKey ? ", IsIdentity = true" : "";
            }
        }


        [Persistent("ISREQUIRED")]
        public bool IsRequired { get; set; }

        [Browsable(false)]
        public static string ToCScrap(string datatype)
        {
            if (string.IsNullOrEmpty(datatype)) return "string";
            if (datatype.IndexOf("integer") != -1) return "int";
            if (datatype.IndexOf("varchar") != -1) return "string";
            if (datatype.IndexOf("bit") != -1) return "bool";
            if (datatype.IndexOf("boolean") != -1) return "bool";
            //if (datatype.IndexOf("bit") != -1) return "int";
            //if (datatype.IndexOf("boolean") != -1) return "int";
            if (datatype.IndexOf("nvarchar") != -1) return "string";
            if (datatype.IndexOf("bigint") != -1) return "int";
            if (datatype.IndexOf("timestamp") != -1) return "DateTime";
            if (datatype.IndexOf("date") != -1) return "DateTime";
            if (datatype.IndexOf("time") != -1) return "DateTime";
            if (datatype.IndexOf("number") != -1) return "decimal";
            if (datatype.IndexOf("decimal") != -1) return "decimal";
            return "";
        }

        [Browsable(false)]
        public static string CScrapDefaultValue(string datatype)
        {
            if (string.IsNullOrEmpty(datatype)) return "\"\"";
            if (datatype.IndexOf("integer") != -1) return "0";
            if (datatype.IndexOf("varchar") != -1) return "string.Empty";
            if (datatype.IndexOf("bit") != -1) return "false";
            if (datatype.IndexOf("bool") != -1) return "false";
            if (datatype.IndexOf("boolean") != -1) return "false";
            if (datatype.IndexOf("nvarchar") != -1) return "string.Empty";
            if (datatype.IndexOf("bigint") != -1) return "0";
            if (datatype.IndexOf("timestamp") != -1) return "DateTime.Now";
            if (datatype.IndexOf("date") != -1) return "DateTime.Now";
            if (datatype.IndexOf("time") != -1) return "DateTime.Now";
            if (datatype.IndexOf("number") != -1) return "0m";
            if (datatype.IndexOf("decimal") != -1) return "0m";
            return "";
        }

        [Browsable(false)]
        private string ToUyumType()
        {
            if (string.IsNullOrEmpty(ColumnDataType)) return "DataString";
            if (ColumnDataType.IndexOf("integer") != -1) return "DataInt32";
            if (ColumnDataType.IndexOf("varchar") != -1) return "DataString";
            if (ColumnDataType.IndexOf("bit") != -1) return "DataBoolean";
            if (ColumnDataType.IndexOf("boolean") != -1) return "DataBoolean";
            if (ColumnDataType.IndexOf("nvarchar") != -1) return "DataString";
            if (ColumnDataType.IndexOf("bigint") != -1) return "DataInt32";
            if (ColumnDataType.IndexOf("timestamp") != -1) return "DataTime";
            if (ColumnDataType.IndexOf("date") != -1) return "DataTime";
            if (ColumnDataType.IndexOf("time") != -1) return "DataTime";
            if (ColumnDataType.IndexOf("number") != -1) return "DataDecimal";
            if (ColumnDataType.IndexOf("decimal") != -1) return "DataDecimal";
            return "";
        }

        [Browsable(false)]
        public string ToColumnLenght()
        {
            if (string.IsNullOrEmpty(ColumnDataType)) return "";//return ", Length = 15";
            if (ColumnDataType.IndexOf("(") != -1 && ColumnDataType.IndexOf(")") != -1)
            {
                int l1 = ColumnDataType.IndexOf("(") + 1;
                int l2 = ColumnDataType.IndexOf(")");
                string lenght = ColumnDataType.Substring(l1, l2 - l1);
                if (ColumnDataType.IndexOf("varchar") != -1)
                {
                    int len = 0;
                    if (int.TryParse(lenght, out len))
                    {
                        return ", Length = " + len;
                    }
                }
                else if (ColumnDataType.IndexOf("number") != -1 || ColumnDataType.IndexOf("decimal") != -1)
                {
                    int len = 0;
                    string[] lens = lenght.Split(',');
                    if (lens != null && lens.Length > 1)
                    {
                        return ", Precision = " + lens[0] + ", Scale = " + lens[1];
                    }
                }

            }
            return "";
        }

        [Browsable(false)]
        public string ToColumnXPOLenght()
        {
            if (string.IsNullOrEmpty(ColumnDataType)) return "";
            if (ColumnDataType.IndexOf("(") != -1 && ColumnDataType.IndexOf(")") != -1)
            {
                int l1 = ColumnDataType.IndexOf("(") + 1;
                int l2 = ColumnDataType.IndexOf(")");
                string lenght = ColumnDataType.Substring(l1, l2 - l1);
                if (ColumnDataType.IndexOf("varchar") != -1)
                {
                    int len = 0;
                    if (int.TryParse(lenght, out len))
                    {
                        return "[Size(" + len + ")]";
                    }
                }
                //else if (ColumnDataType.IndexOf("number") != -1 || ColumnDataType.IndexOf("decimal") != -1)
                //{
                //    int len = 0;
                //    string[] lens = lenght.Split(',');
                //    if (lens != null && lens.Length > 1)
                //    {
                //        return ", Precision = " + lens[0] + ", Scale = " + lens[1];
                //    }

                //}
            }
            return "";
        }

        [Browsable(false)]
        public string AttributeString()
        {
            StringBuilder str = new StringBuilder();
            str.Append("[")
            .Append(ToUyumType()).Append("(\"").Append(this.Name).Append("\"")
            .Append(ToColumnLenght())
            .Append(")]");
            return str.ToString();

        }

    }
}
