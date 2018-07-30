using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("fdd04900-dc98-46d4-9617-32363d2afeca")]
	[UyumTable("prdd_worder_order_rel",Database="public", InsertStoredProcedure="prdd_worder_order_rel_i", UpdateStoredProcedure="prdd_worder_order_rel_u", DeleteStoredProcedure="prdd_worder_order_rel_d", SelectStoredProcedure="prdd_worder_order_rel_s")]
	public class WorderOrderRelCollection : UyumObjectCollection
	{

		public WorderOrderRelCollection()
		{
			base._ItemType = typeof(WorderOrderRel);
		}

		public override IUyumObject CreateItem()
		{
			return new WorderOrderRel();
		}

		public WorderOrderRel this[int index]
		{
			get { return base.innerList[index] as WorderOrderRel; }
		}

		public static explicit operator List<WorderOrderRelInfo>(WorderOrderRelCollection enumarable)
		{
			List<WorderOrderRelInfo> list = new List<WorderOrderRelInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WorderOrderRel uyumObject = enumarable.GetItemFromIndex(i) as WorderOrderRel;
					WorderOrderRelInfo item = new BusinessObjects.WorderOrderRelInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.OrderMId = uyumObject.OrderMId;
					item.OrderDId = uyumObject.OrderDId;
					item.QtyPrm = uyumObject.QtyPrm;
					item.Qty = uyumObject.Qty;
					item.UnitId = uyumObject.UnitId;
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
