using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("f08b0a10-8ef7-40eb-bc93-b6f2d6d852fa")]
	[UyumTable("prdd_worder_route_d",Database="public", InsertStoredProcedure="prdd_worder_route_d_i", UpdateStoredProcedure="prdd_worder_route_d_u", DeleteStoredProcedure="prdd_worder_route_d_d", SelectStoredProcedure="prdd_worder_route_d_s")]
	public class WorderRouteDCollection : UyumObjectCollection
	{

		public WorderRouteDCollection()
		{
			base._ItemType = typeof(WorderRouteD);
		}

		public override IUyumObject CreateItem()
		{
			return new WorderRouteD();
		}

		public WorderRouteD this[int index]
		{
			get { return base.innerList[index] as WorderRouteD; }
		}

		public static explicit operator List<WorderRouteDInfo>(WorderRouteDCollection enumarable)
		{
			List<WorderRouteDInfo> list = new List<WorderRouteDInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WorderRouteD uyumObject = enumarable.GetItemFromIndex(i) as WorderRouteD;
					WorderRouteDInfo item = new BusinessObjects.WorderRouteDInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WcenterId = uyumObject.WcenterId;
					item.WstationId = uyumObject.WstationId;
					item.OperationId = uyumObject.OperationId;
					item.QtyPrm = uyumObject.QtyPrm;
					item.StartDate = uyumObject.StartDate;
					item.EndDate = uyumObject.EndDate;
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
