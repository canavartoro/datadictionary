using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("885212a3-6d9c-4c71-ae71-b98ebc557e9a")]
	[UyumTable("prdd_product_route_d",Database="public", InsertStoredProcedure="prdd_product_route_d_i", UpdateStoredProcedure="prdd_product_route_d_u", DeleteStoredProcedure="prdd_product_route_d_d", SelectStoredProcedure="prdd_product_route_d_s")]
	public class ProductRouteDCollection : UyumObjectCollection
	{

		public ProductRouteDCollection()
		{
			base._ItemType = typeof(ProductRouteD);
		}

		public override IUyumObject CreateItem()
		{
			return new ProductRouteD();
		}

		public ProductRouteD this[int index]
		{
			get { return base.innerList[index] as ProductRouteD; }
		}

		public static explicit operator List<ProductRouteDInfo>(ProductRouteDCollection enumarable)
		{
			List<ProductRouteDInfo> list = new List<ProductRouteDInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					ProductRouteD uyumObject = enumarable.GetItemFromIndex(i) as ProductRouteD;
					ProductRouteDInfo item = new BusinessObjects.ProductRouteDInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.LineNo = uyumObject.LineNo;
					item.OperationId = uyumObject.OperationId;
					item.OperationNo = uyumObject.OperationNo;
					item.WcenterId = uyumObject.WcenterId;
					item.WstationId = uyumObject.WstationId;
					item.IsOutside = uyumObject.IsOutside;
					item.IsDemonte = uyumObject.IsDemonte;
					item.Qty = uyumObject.Qty;
					item.Duration = uyumObject.Duration;
					item.OpenClose = uyumObject.OpenClose;
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
