using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("dd05cf6a-2fbb-45e7-a687-b4bba53a55a6")]
	[UyumTable("prdd_location_break",Database="public", InsertStoredProcedure="prdd_location_break_i", UpdateStoredProcedure="prdd_location_break_u", DeleteStoredProcedure="prdd_location_break_d", SelectStoredProcedure="prdd_location_break_s")]
	public class LocationBreakCollection : UyumObjectCollection
	{

		public LocationBreakCollection()
		{
			base._ItemType = typeof(LocationBreak);
		}

		public override IUyumObject CreateItem()
		{
			return new LocationBreak();
		}

		public LocationBreak this[int index]
		{
			get { return base.innerList[index] as LocationBreak; }
		}

		public static explicit operator List<LocationBreakInfo>(LocationBreakCollection enumarable)
		{
			List<LocationBreakInfo> list = new List<LocationBreakInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					LocationBreak uyumObject = enumarable.GetItemFromIndex(i) as LocationBreak;
					LocationBreakInfo item = new BusinessObjects.LocationBreakInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LocationType = uyumObject.LocationType;
					item.LocationId = uyumObject.LocationId;
					item.Starttime = uyumObject.Starttime;
					item.Endtime = uyumObject.Endtime;
					item.CalendarTypeId = uyumObject.CalendarTypeId;
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
