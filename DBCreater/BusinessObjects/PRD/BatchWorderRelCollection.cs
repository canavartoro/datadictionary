using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("7e850f51-81a1-4c5b-9b29-00d8a234913e")]
	[UyumTable("prdd_batch_worder_rel",Database="public", InsertStoredProcedure="prdd_batch_worder_rel_i", UpdateStoredProcedure="prdd_batch_worder_rel_u", DeleteStoredProcedure="prdd_batch_worder_rel_d", SelectStoredProcedure="prdd_batch_worder_rel_s")]
	public class BatchWorderRelCollection : UyumObjectCollection
	{

		public BatchWorderRelCollection()
		{
			base._ItemType = typeof(BatchWorderRel);
		}

		public override IUyumObject CreateItem()
		{
			return new BatchWorderRel();
		}

		public BatchWorderRel this[int index]
		{
			get { return base.innerList[index] as BatchWorderRel; }
		}

		public static explicit operator List<BatchWorderRelInfo>(BatchWorderRelCollection enumarable)
		{
			List<BatchWorderRelInfo> list = new List<BatchWorderRelInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BatchWorderRel uyumObject = enumarable.GetItemFromIndex(i) as BatchWorderRel;
					BatchWorderRelInfo item = new BusinessObjects.BatchWorderRelInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WorderMId = uyumObject.WorderMId;
					item.OperationId = uyumObject.OperationId;
					item.OperationNo = uyumObject.OperationNo;
					item.QtyPrm = uyumObject.QtyPrm;
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
