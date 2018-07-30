using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("57c8f4ba-a2c3-4d7b-9759-abce64466fc5")]
	[UyumTable("hrmd_leave_type",Database="public", InsertStoredProcedure="hrmd_leave_type_i", UpdateStoredProcedure="hrmd_leave_type_u", DeleteStoredProcedure="hrmd_leave_type_d", SelectStoredProcedure="hrmd_leave_type_s")]
	public class LeaveTypeCollection : UyumObjectCollection
	{

		public LeaveTypeCollection()
		{
			base._ItemType = typeof(LeaveType);
		}

		public override IUyumObject CreateItem()
		{
			return new LeaveType();
		}

		public LeaveType this[int index]
		{
			get { return base.innerList[index] as LeaveType; }
		}

		public static explicit operator List<LeaveTypeInfo>(LeaveTypeCollection enumarable)
		{
			List<LeaveTypeInfo> list = new List<LeaveTypeInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					LeaveType uyumObject = enumarable.GetItemFromIndex(i) as LeaveType;
					LeaveTypeInfo item = new BusinessObjects.LeaveTypeInfo();
					item.Id = uyumObject.Id;
					item.LeaveTypeCode = uyumObject.LeaveTypeCode;
					item.LeaveTypeDesc = uyumObject.LeaveTypeDesc;
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
