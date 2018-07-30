using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("e5e5a779-95be-4a2d-bc2d-454d4eccc86c")]
	[UyumTable("prdd_location_timetable",Database="public", InsertStoredProcedure="prdd_location_timetable_i", UpdateStoredProcedure="prdd_location_timetable_u", DeleteStoredProcedure="prdd_location_timetable_d", SelectStoredProcedure="prdd_location_timetable_s")]
	public class LocationTimetableCollection : UyumObjectCollection
	{

		public LocationTimetableCollection()
		{
			base._ItemType = typeof(LocationTimetable);
		}

		public override IUyumObject CreateItem()
		{
			return new LocationTimetable();
		}

		public LocationTimetable this[int index]
		{
			get { return base.innerList[index] as LocationTimetable; }
		}

		public static explicit operator List<LocationTimetableInfo>(LocationTimetableCollection enumarable)
		{
			List<LocationTimetableInfo> list = new List<LocationTimetableInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					LocationTimetable uyumObject = enumarable.GetItemFromIndex(i) as LocationTimetable;
					LocationTimetableInfo item = new BusinessObjects.LocationTimetableInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LocationType = uyumObject.LocationType;
					item.LocationId = uyumObject.LocationId;
					item.Startdate = uyumObject.Startdate;
					item.Enddate = uyumObject.Enddate;
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
