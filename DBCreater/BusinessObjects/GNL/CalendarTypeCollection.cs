using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("92087987-70aa-473a-88dc-eff8dc2e49a8")]
	[UyumTable("gnld_calendar_type",Database="public", InsertStoredProcedure="gnld_calendar_type_i", UpdateStoredProcedure="gnld_calendar_type_u", DeleteStoredProcedure="gnld_calendar_type_d", SelectStoredProcedure="gnld_calendar_type_s")]
	public class CalendarTypeCollection : UyumObjectCollection
	{

		public CalendarTypeCollection()
		{
			base._ItemType = typeof(CalendarType);
		}

		public override IUyumObject CreateItem()
		{
			return new CalendarType();
		}

		public CalendarType this[int index]
		{
			get { return base.innerList[index] as CalendarType; }
		}

		public static explicit operator List<CalendarTypeInfo>(CalendarTypeCollection enumarable)
		{
			List<CalendarTypeInfo> list = new List<CalendarTypeInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					CalendarType uyumObject = enumarable.GetItemFromIndex(i) as CalendarType;
					CalendarTypeInfo item = new BusinessObjects.CalendarTypeInfo();
					item.Id = uyumObject.Id;
					item.CalendarTypeCode = uyumObject.CalendarTypeCode;
					item.CalendarTypeDesc = uyumObject.CalendarTypeDesc;
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
