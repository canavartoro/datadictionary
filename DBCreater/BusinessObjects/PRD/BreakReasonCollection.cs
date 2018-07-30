using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("4fd4ac39-24ad-4b58-a3e5-af9b84004df4")]
	[UyumTable("prdd_break_reason",Database="public", InsertStoredProcedure="prdd_break_reason_i", UpdateStoredProcedure="prdd_break_reason_u", DeleteStoredProcedure="prdd_break_reason_d", SelectStoredProcedure="prdd_break_reason_s")]
	public class BreakReasonCollection : UyumObjectCollection
	{

		public BreakReasonCollection()
		{
			base._ItemType = typeof(BreakReason);
		}

		public override IUyumObject CreateItem()
		{
			return new BreakReason();
		}

		public BreakReason this[int index]
		{
			get { return base.innerList[index] as BreakReason; }
		}

		public static explicit operator List<BreakReasonInfo>(BreakReasonCollection enumarable)
		{
			List<BreakReasonInfo> list = new List<BreakReasonInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BreakReason uyumObject = enumarable.GetItemFromIndex(i) as BreakReason;
					BreakReasonInfo item = new BusinessObjects.BreakReasonInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.BreakReasonCode = uyumObject.BreakReasonCode;
					item.BreakReasonDesc = uyumObject.BreakReasonDesc;
					item.BreakReasonType = uyumObject.BreakReasonType;
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
