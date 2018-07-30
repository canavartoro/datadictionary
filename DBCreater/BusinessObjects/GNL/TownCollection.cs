using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("b7920ff9-12d7-4a7b-a74b-d70fc731e14b")]
	[UyumTable("gnld_town",Database="public", InsertStoredProcedure="gnld_town_i", UpdateStoredProcedure="gnld_town_u", DeleteStoredProcedure="gnld_town_d", SelectStoredProcedure="gnld_town_s")]
	public class TownCollection : UyumObjectCollection
	{

		public TownCollection()
		{
			base._ItemType = typeof(Town);
		}

		public override IUyumObject CreateItem()
		{
			return new Town();
		}

		public Town this[int index]
		{
			get { return base.innerList[index] as Town; }
		}

		public static explicit operator List<TownInfo>(TownCollection enumarable)
		{
			List<TownInfo> list = new List<TownInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Town uyumObject = enumarable.GetItemFromIndex(i) as Town;
					TownInfo item = new BusinessObjects.TownInfo();
					item.Id = uyumObject.Id;
					item.TownName = uyumObject.TownName;
					item.CityId = uyumObject.CityId;
					item.CountryId = uyumObject.CountryId;
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
