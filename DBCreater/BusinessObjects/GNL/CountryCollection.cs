using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c9adc5bc-9368-4a9b-92f0-e20a18c8d20a")]
	[UyumTable("gnld_country",Database="public", InsertStoredProcedure="gnld_country_i", UpdateStoredProcedure="gnld_country_u", DeleteStoredProcedure="gnld_country_d", SelectStoredProcedure="gnld_country_s")]
	public class CountryCollection : UyumObjectCollection
	{

		public CountryCollection()
		{
			base._ItemType = typeof(Country);
		}

		public override IUyumObject CreateItem()
		{
			return new Country();
		}

		public Country this[int index]
		{
			get { return base.innerList[index] as Country; }
		}

		public static explicit operator List<CountryInfo>(CountryCollection enumarable)
		{
			List<CountryInfo> list = new List<CountryInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Country uyumObject = enumarable.GetItemFromIndex(i) as Country;
					CountryInfo item = new BusinessObjects.CountryInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.IsoCode = uyumObject.IsoCode;
					item.PhoneCode = uyumObject.PhoneCode;
					item.Barcode = uyumObject.Barcode;
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
