using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c1caeab1-9da3-4cc2-8264-99743f723b18")]
	[UyumTable("prdd_emp_timetable",Database="public", InsertStoredProcedure="prdd_emp_timetable_i", UpdateStoredProcedure="prdd_emp_timetable_u", DeleteStoredProcedure="prdd_emp_timetable_d", SelectStoredProcedure="prdd_emp_timetable_s")]
	public class EmpTimetableCollection : UyumObjectCollection
	{

		public EmpTimetableCollection()
		{
			base._ItemType = typeof(EmpTimetable);
		}

		public override IUyumObject CreateItem()
		{
			return new EmpTimetable();
		}

		public EmpTimetable this[int index]
		{
			get { return base.innerList[index] as EmpTimetable; }
		}

		public static explicit operator List<EmpTimetableInfo>(EmpTimetableCollection enumarable)
		{
			List<EmpTimetableInfo> list = new List<EmpTimetableInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					EmpTimetable uyumObject = enumarable.GetItemFromIndex(i) as EmpTimetable;
					EmpTimetableInfo item = new BusinessObjects.EmpTimetableInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.EmployeeId = uyumObject.EmployeeId;
					item.Startdate = uyumObject.Startdate;
					item.Enddate = uyumObject.Enddate;
					item.LocationType = uyumObject.LocationType;
					item.LocationId = uyumObject.LocationId;
					item.Starttime = uyumObject.Starttime;
					item.Endtime = uyumObject.Endtime;
					item.IsWholeDay = uyumObject.IsWholeDay;
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
