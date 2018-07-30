using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("2503fd44-7f4f-4fa7-b25a-e30f0bd46d7e")]
	[UyumTable("gnld_city",Database="public", InsertStoredProcedure="gnld_city_i", UpdateStoredProcedure="gnld_city_u", DeleteStoredProcedure="gnld_city_d", SelectStoredProcedure="gnld_city_s")]
	public class CityCollection : UyumObjectCollection
	{

		public CityCollection()
		{
			base._ItemType = typeof(City);
		}

		public override IUyumObject CreateItem()
		{
			return new City();
		}

		public City this[int index]
		{
			get { return base.innerList[index] as City; }
		}

		public static explicit operator List<CityInfo>(CityCollection enumarable)
		{
			List<CityInfo> list = new List<CityInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					City uyumObject = enumarable.GetItemFromIndex(i) as City;
					CityInfo item = new BusinessObjects.CityInfo();
					item.Id = uyumObject.Id;
					item.CityName = uyumObject.CityName;
					item.CountryId = uyumObject.CountryId;
					item.LcencePlate = uyumObject.LcencePlate;
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
