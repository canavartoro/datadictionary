using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("0447a45a-239b-430c-be09-e4c0d43894cc")]
	[UyumTable("prdd_bom_d",Database="public", InsertStoredProcedure="prdd_bom_d_i", UpdateStoredProcedure="prdd_bom_d_u", DeleteStoredProcedure="prdd_bom_d_d", SelectStoredProcedure="prdd_bom_d_s")]
	public class BomDCollection : UyumObjectCollection
	{

		public BomDCollection()
		{
			base._ItemType = typeof(BomD);
		}

		public override IUyumObject CreateItem()
		{
			return new BomD();
		}

		public BomD this[int index]
		{
			get { return base.innerList[index] as BomD; }
		}

		public static explicit operator List<BomDInfo>(BomDCollection enumarable)
		{
			List<BomDInfo> list = new List<BomDInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BomD uyumObject = enumarable.GetItemFromIndex(i) as BomD;
					BomDInfo item = new BusinessObjects.BomDInfo();
					item.Id = uyumObject.Id;
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
					item.ErpBomMId = uyumObject.ErpBomMId;
					item.ErpBomDId = uyumObject.ErpBomDId;
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
