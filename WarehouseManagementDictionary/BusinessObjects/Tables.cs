using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WarehouseManagementDictionary.BusinessObjects
{
    [Persistent("TABLES")]
    [OptimisticLocking(false), DeferredDeletion(false)]
    [DebuggerDisplay("Isim = {Name}, Description = {Description}")]
    public class Tables : XPObject
    {
        public static string[] modules = new string[] { "APP", "GNL", "INV", "PRD", "TET", "SRV", "SPC", "SFT", "SCM",
            "SCH", "SBM", "QLT", "PSM", "PRM", "PRD", "PPY", "PMG", "MRS", "MRP", "MRC","MOB","MNT","MMS","MAR","MAN",
            "LMS","INZ","INT","HSM","HRM","HMS","GLB","FTM","FLM","FIN","DST","DNT","DFC","DEM","CSH","CRM","COM",
            "CMS","BSK","BGT","BBM","B2C","B2B","AST","ARM","ABT" };

        public Tables() { }
        public Tables(Session session) : base(session) { }

        [Size(300)]
        [Persistent("ORDER")]
        public int Order { get; set; }

        [Size(300)]
        [Persistent("NAME")]
        public string Name { get; set; }

        [NonPersistent]
        public string ShortName
        {
            get
            {
                string shortname = Name;
                if (!string.IsNullOrEmpty(Name))
                {
                    if (Name.IndexOf("_") != -1)
                    {
                        shortname = Name.Substring(Name.IndexOf("_") + 1);
                    }
                }
                return shortname;
            }
        }

        [Persistent("DESCRIPTION")]
        [Size(SizeAttribute.Unlimited)]
        public string Description { get; set; }


        [Persistent("PREFIX")]
        [Size(10)]
        public string Prefix { get; set; }

        [XmlIgnore(), Association("Table-Column")]
        public XPCollection<Fields> Columns
        {
            get { return GetCollection<Fields>("Columns"); }
        }

        [Persistent("TABLE_NAME")]
        [Size(10)]
        public string TableName { get; set; }


        [Persistent("MODUL_NAME")]
        [Size(10)]
        public string ModulName { get; set; }

        [Persistent("TABLE_TYPE")]
        [Size(10)]
        public string TableType { get; set; }

    }
}
