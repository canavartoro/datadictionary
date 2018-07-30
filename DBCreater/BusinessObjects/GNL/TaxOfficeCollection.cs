using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c26f6ab5-0e47-4542-85e6-a2cf59e1fc4b")]
	[UyumTable("gnld_tax_office",Database="public", InsertStoredProcedure="gnld_tax_office_i", UpdateStoredProcedure="gnld_tax_office_u", DeleteStoredProcedure="gnld_tax_office_d", SelectStoredProcedure="gnld_tax_office_s")]
	public class TaxOfficeCollection : UyumObjectCollection
	{

		public TaxOfficeCollection()
		{
			base._ItemType = typeof(TaxOffice);
		}

		public override IUyumObject CreateItem()
		{
			return new TaxOffice();
		}

		public TaxOffice this[int index]
		{
			get { return base.innerList[index] as TaxOffice; }
		}

		public static explicit operator List<TaxOfficeInfo>(TaxOfficeCollection enumarable)
		{
			List<TaxOfficeInfo> list = new List<TaxOfficeInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					TaxOffice uyumObject = enumarable.GetItemFromIndex(i) as TaxOffice;
					TaxOfficeInfo item = new BusinessObjects.TaxOfficeInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.TaxOfficeDesc = uyumObject.TaxOfficeDesc;
					item.CreateUserId = uyumObject.CreateUserId;
					item.CreateDate = uyumObject.CreateDate;
					item.UpdateUserId = uyumObject.UpdateUserId;
					item.UpdateDate = uyumObject.UpdateDate;
					list.Add(item);
				}
			}
			list.TrimExcess();
			return list;
		}

	}
}
