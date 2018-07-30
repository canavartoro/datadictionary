using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("03955541-907e-4af2-a66b-54f8e85fd2b7")]
	[UyumTable("prdd_shift",Database="public", InsertStoredProcedure="prdd_shift_i", UpdateStoredProcedure="prdd_shift_u", DeleteStoredProcedure="prdd_shift_d", SelectStoredProcedure="prdd_shift_s")]
	public class ShiftCollection : UyumObjectCollection
	{

		public ShiftCollection()
		{
			base._ItemType = typeof(Shift);
		}

		public override IUyumObject CreateItem()
		{
			return new Shift();
		}

		public Shift this[int index]
		{
			get { return base.innerList[index] as Shift; }
		}

		public static explicit operator List<ShiftInfo>(ShiftCollection enumarable)
		{
			List<ShiftInfo> list = new List<ShiftInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Shift uyumObject = enumarable.GetItemFromIndex(i) as Shift;
					ShiftInfo item = new BusinessObjects.ShiftInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.ShiftCode = uyumObject.ShiftCode;
					item.ShiftDesc = uyumObject.ShiftDesc;
					item.Starttime = uyumObject.Starttime;
					item.Endtime = uyumObject.Endtime;
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
