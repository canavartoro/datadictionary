﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo.Metadata;

namespace WarehouseManagementDictionary
{
    public class BoolConverter : DevExpress.Xpo.Metadata.ValueConverter
    {
        public override object ConvertFromStorageType(object value)
        {
            if (object.ReferenceEquals(value, null)) return false;

            return Convert.ToInt32(value) == 1;
        }

        public override object ConvertToStorageType(object value)
        {
            if (object.ReferenceEquals(value, null)) return 0;
            return Convert.ToBoolean(value) ? 1 : 0;
        }

        public override Type StorageType
        {
            get { return typeof(int); }
        }
    }
}
