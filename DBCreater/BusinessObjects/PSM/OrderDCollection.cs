using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("7edf05c9-a4c3-4efe-b38e-ff177c65d604")]
	[UyumTable("psmt_order_d",Database="public", InsertStoredProcedure="psmt_order_d_i", UpdateStoredProcedure="psmt_order_d_u", DeleteStoredProcedure="psmt_order_d_d", SelectStoredProcedure="psmt_order_d_s")]
	public class OrderDCollection : UyumObjectCollection
	{

		public OrderDCollection()
		{
			base._ItemType = typeof(OrderD);
		}

		public override IUyumObject CreateItem()
		{
			return new OrderD();
		}

		public OrderD this[int index]
		{
			get { return base.innerList[index] as OrderD; }
		}

		public static explicit operator List<OrderDInfo>(OrderDCollection enumarable)
		{
			List<OrderDInfo> list = new List<OrderDInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					OrderD uyumObject = enumarable.GetItemFromIndex(i) as OrderD;
					OrderDInfo item = new BusinessObjects.OrderDInfo();
					item.Id = uyumObject.Id;
					item.OrderDId = uyumObject.OrderDId;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LineType = uyumObject.LineType;
					item.DcardId = uyumObject.DcardId;
					item.ItemId = uyumObject.ItemId;
					item.UnitId = uyumObject.UnitId;
					item.Qty = uyumObject.Qty;
					item.QtyPrm = uyumObject.QtyPrm;
					item.Note1 = uyumObject.Note1;
					item.ShippingQty = uyumObject.ShippingQty;
					item.OrderStatus = uyumObject.OrderStatus;
					item.DeliveryDate = uyumObject.DeliveryDate;
					item.ShippingDate = uyumObject.ShippingDate;
					item.WorderMId = uyumObject.WorderMId;
					item.ErpOrderMId = uyumObject.ErpOrderMId;
					item.ErpOrderDId = uyumObject.ErpOrderDId;
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
