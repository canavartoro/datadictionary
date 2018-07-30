using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("6c6d0ae2-6d15-4fdc-aab0-86fcbb5f5aad")]
	[UyumTable("prdt_emp_break_timetable",Database="public", InsertStoredProcedure="prdt_emp_break_timetable_i", UpdateStoredProcedure="prdt_emp_break_timetable_u", DeleteStoredProcedure="prdt_emp_break_timetable_d", SelectStoredProcedure="prdt_emp_break_timetable_s")]
	public class EmpBreakTimetableCollection : UyumObjectCollection
	{

		public EmpBreakTimetableCollection()
		{
			base._ItemType = typeof(EmpBreakTimetable);
		}

		public override IUyumObject CreateItem()
		{
			return new EmpBreakTimetable();
		}

		public EmpBreakTimetable this[int index]
		{
			get { return base.innerList[index] as EmpBreakTimetable; }
		}

		public static explicit operator List<EmpBreakTimetableInfo>(EmpBreakTimetableCollection enumarable)
		{
			List<EmpBreakTimetableInfo> list = new List<EmpBreakTimetableInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					EmpBreakTimetable uyumObject = enumarable.GetItemFromIndex(i) as EmpBreakTimetable;
					EmpBreakTimetableInfo item = new BusinessObjects.EmpBreakTimetableInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.EmployeeId = uyumObject.EmployeeId;
					item.Date = uyumObject.Date;
					item.LocationType = uyumObject.LocationType;
					item.LocationId = uyumObject.LocationId;
					item.InputOutput = uyumObject.InputOutput;
					item.InputTimetableId = uyumObject.InputTimetableId;
					item.BreakReasonId = uyumObject.BreakReasonId;
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
