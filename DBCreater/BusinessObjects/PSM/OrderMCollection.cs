using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("bacb330e-83f0-4ffc-b4fa-dd91711a471d")]
	[UyumTable("psmt_order_m",Database="public", InsertStoredProcedure="psmt_order_m_i", UpdateStoredProcedure="psmt_order_m_u", DeleteStoredProcedure="psmt_order_m_d", SelectStoredProcedure="psmt_order_m_s")]
	public class OrderMCollection : UyumObjectCollection
	{

		public OrderMCollection()
		{
			base._ItemType = typeof(OrderM);
		}

		public override IUyumObject CreateItem()
		{
			return new OrderM();
		}

		public OrderM this[int index]
		{
			get { return base.innerList[index] as OrderM; }
		}

		public static explicit operator List<OrderMInfo>(OrderMCollection enumarable)
		{
			List<OrderMInfo> list = new List<OrderMInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					OrderM uyumObject = enumarable.GetItemFromIndex(i) as OrderM;
					OrderMInfo item = new BusinessObjects.OrderMInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.EntityId = uyumObject.EntityId;
					item.SalesPersonId = uyumObject.SalesPersonId;
					item.DocTraId = uyumObject.DocTraId;
					item.DocDate = uyumObject.DocDate;
					item.DocNo = uyumObject.DocNo;
					item.PurcahseSales = uyumObject.PurcahseSales;
					item.DueDate = uyumObject.DueDate;
					item.DeliveryDate = uyumObject.DeliveryDate;
					item.ShippingDate = uyumObject.ShippingDate;
					item.Note1 = uyumObject.Note1;
					item.Note2 = uyumObject.Note2;
					item.ErpOrderMId = uyumObject.ErpOrderMId;
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
