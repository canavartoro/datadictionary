using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c6af50a1-4eb5-46c4-8924-4cb2248f9687")]
	[UyumTable("prdd_worder_m",Database="public", InsertStoredProcedure="prdd_worder_m_i", UpdateStoredProcedure="prdd_worder_m_u", DeleteStoredProcedure="prdd_worder_m_d", SelectStoredProcedure="prdd_worder_m_s")]
	public class WorderMCollection : UyumObjectCollection
	{

		public WorderMCollection()
		{
			base._ItemType = typeof(WorderM);
		}

		public override IUyumObject CreateItem()
		{
			return new WorderM();
		}

		public WorderM this[int index]
		{
			get { return base.innerList[index] as WorderM; }
		}

		public static explicit operator List<WorderMInfo>(WorderMCollection enumarable)
		{
			List<WorderMInfo> list = new List<WorderMInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WorderM uyumObject = enumarable.GetItemFromIndex(i) as WorderM;
					WorderMInfo item = new BusinessObjects.WorderMInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WorderNo = uyumObject.WorderNo;
					item.ItemId = uyumObject.ItemId;
					item.UnitId = uyumObject.UnitId;
					item.Qty = uyumObject.Qty;
					item.QtyPrm = uyumObject.QtyPrm;
					item.BomMId = uyumObject.BomMId;
					item.ProductRouteMId = uyumObject.ProductRouteMId;
					item.IsClosed = uyumObject.IsClosed;
					item.ErpWorderMId = uyumObject.ErpWorderMId;
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
