using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementDictionary.BusinessObjects
{
    [Persistent("ADDRESS")]
    [OptimisticLocking(false), DeferredDeletion(false)]
    [DebuggerDisplay("Isim = {Isim}, Adres = {Adres}")]
    public class MailAdres : XPObject
    {
        public MailAdres() { }
        public MailAdres(Session session) : base(session) { }

        [Size(300)]
        [Persistent("NAME")]
        public string Isim { get; set; }

        [Persistent("ADDRESS")]
        [Size(SizeAttribute.Unlimited)]
        public string Adres { get; set; }

        [Persistent("STATUS")]
        public bool Gonderilsin { get; set; }

    }
}
