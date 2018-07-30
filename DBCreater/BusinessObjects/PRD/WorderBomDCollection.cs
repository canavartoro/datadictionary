using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("e6e6d7fc-a04b-4fd3-896f-ce33c9cfe2f6")]
	[UyumTable("prdd_worder_bom_d",Database="public", InsertStoredProcedure="prdd_worder_bom_d_i", UpdateStoredProcedure="prdd_worder_bom_d_u", DeleteStoredProcedure="prdd_worder_bom_d_d", SelectStoredProcedure="prdd_worder_bom_d_s")]
	public class WorderBomDCollection : UyumObjectCollection
	{

		public WorderBomDCollection()
		{
			base._ItemType = typeof(WorderBomD);
		}

		public override IUyumObject CreateItem()
		{
			return new WorderBomD();
		}

		public WorderBomD this[int index]
		{
			get { return base.innerList[index] as WorderBomD; }
		}

		public static explicit operator List<WorderBomDInfo>(WorderBomDCollection enumarable)
		{
			List<WorderBomDInfo> list = new List<WorderBomDInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WorderBomD uyumObject = enumarable.GetItemFromIndex(i) as WorderBomD;
					WorderBomDInfo item = new BusinessObjects.WorderBomDInfo();
					item.Id = uyumObject.Id;
					item.WorderMId = uyumObject.WorderMId;
					item.BomMId = uyumObject.BomMId;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LineNo = uyumObject.LineNo;
					item.LineType = uyumObject.LineType;
					item.ItemId = uyumObject.ItemId;
					item.ItemBomMId = uyumObject.ItemBomMId;
					item.UnitId = uyumObject.UnitId;
					item.Qty = uyumObject.Qty;
					item.OperationId = uyumObject.OperationId;
					item.OperationNo = uyumObject.OperationNo;
					item.IsByproduct = uyumObject.IsByproduct;
					item.IsMasterMaterial = uyumObject.IsMasterMaterial;
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
