using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("5aacfeb5-2c31-4873-acd7-a13b115fa2f9")]
	[UyumTable("prdd_batch_worder",Database="public", InsertStoredProcedure="prdd_batch_worder_i", UpdateStoredProcedure="prdd_batch_worder_u", DeleteStoredProcedure="prdd_batch_worder_d", SelectStoredProcedure="prdd_batch_worder_s")]
	public class BatchWorderCollection : UyumObjectCollection
	{

		public BatchWorderCollection()
		{
			base._ItemType = typeof(BatchWorder);
		}

		public override IUyumObject CreateItem()
		{
			return new BatchWorder();
		}

		public BatchWorder this[int index]
		{
			get { return base.innerList[index] as BatchWorder; }
		}

		public static explicit operator List<BatchWorderInfo>(BatchWorderCollection enumarable)
		{
			List<BatchWorderInfo> list = new List<BatchWorderInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BatchWorder uyumObject = enumarable.GetItemFromIndex(i) as BatchWorder;
					BatchWorderInfo item = new BusinessObjects.BatchWorderInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.BatchWorderNo = uyumObject.BatchWorderNo;
					item.ItemId = uyumObject.ItemId;
					item.OperationId = uyumObject.OperationId;
					item.OperationNo = uyumObject.OperationNo;
					item.WcenterId = uyumObject.WcenterId;
					item.WstationId = uyumObject.WstationId;
					item.IsOutside = uyumObject.IsOutside;
					item.IsDemonte = uyumObject.IsDemonte;
					item.QtyPrm = uyumObject.QtyPrm;
					item.QtyPrmMan = uyumObject.QtyPrmMan;
					item.StartDate = uyumObject.StartDate;
					item.EndDate = uyumObject.EndDate;
					item.IsClosed = uyumObject.IsClosed;
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
