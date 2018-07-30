using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("ef048a66-5762-4007-a273-22f6896a5612")]
	[UyumTable("hrmt_leave",Database="public", InsertStoredProcedure="hrmt_leave_i", UpdateStoredProcedure="hrmt_leave_u", DeleteStoredProcedure="hrmt_leave_d", SelectStoredProcedure="hrmt_leave_s")]
	public class LeaveCollection : UyumObjectCollection
	{

		public LeaveCollection()
		{
			base._ItemType = typeof(Leave);
		}

		public override IUyumObject CreateItem()
		{
			return new Leave();
		}

		public Leave this[int index]
		{
			get { return base.innerList[index] as Leave; }
		}

		public static explicit operator List<LeaveInfo>(LeaveCollection enumarable)
		{
			List<LeaveInfo> list = new List<LeaveInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Leave uyumObject = enumarable.GetItemFromIndex(i) as Leave;
					LeaveInfo item = new BusinessObjects.LeaveInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LeaveTypeId = uyumObject.LeaveTypeId;
					item.Startdate = uyumObject.Startdate;
					item.Enddate = uyumObject.Enddate;
					item.EmployeeId = uyumObject.EmployeeId;
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
