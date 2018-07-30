using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("f083005b-c2a7-4166-939d-677413ab292b")]
	[UyumTable("gnld_calendar",Database="public", InsertStoredProcedure="gnld_calendar_i", UpdateStoredProcedure="gnld_calendar_u", DeleteStoredProcedure="gnld_calendar_d", SelectStoredProcedure="gnld_calendar_s")]
	public class CalendarCollection : UyumObjectCollection
	{

		public CalendarCollection()
		{
			base._ItemType = typeof(Calendar);
		}

		public override IUyumObject CreateItem()
		{
			return new Calendar();
		}

		public Calendar this[int index]
		{
			get { return base.innerList[index] as Calendar; }
		}

		public static explicit operator List<CalendarInfo>(CalendarCollection enumarable)
		{
			List<CalendarInfo> list = new List<CalendarInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Calendar uyumObject = enumarable.GetItemFromIndex(i) as Calendar;
					CalendarInfo item = new BusinessObjects.CalendarInfo();
					item.Id = uyumObject.Id;
					item.CalendarTypeId = uyumObject.CalendarTypeId;
					item.Date = uyumObject.Date;
					item.StartTime = uyumObject.StartTime;
					item.EndTime = uyumObject.EndTime;
					item.WorkingMinute = uyumObject.WorkingMinute;
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
