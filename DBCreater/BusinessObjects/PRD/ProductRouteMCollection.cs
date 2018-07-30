using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("abafa974-30c3-414a-91ab-9fbbaef6b883")]
	[UyumTable("prdd_product_route_m",Database="public", InsertStoredProcedure="prdd_product_route_m_i", UpdateStoredProcedure="prdd_product_route_m_u", DeleteStoredProcedure="prdd_product_route_m_d", SelectStoredProcedure="prdd_product_route_m_s")]
	public class ProductRouteMCollection : UyumObjectCollection
	{

		public ProductRouteMCollection()
		{
			base._ItemType = typeof(ProductRouteM);
		}

		public override IUyumObject CreateItem()
		{
			return new ProductRouteM();
		}

		public ProductRouteM this[int index]
		{
			get { return base.innerList[index] as ProductRouteM; }
		}

		public static explicit operator List<ProductRouteMInfo>(ProductRouteMCollection enumarable)
		{
			List<ProductRouteMInfo> list = new List<ProductRouteMInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					ProductRouteM uyumObject = enumarable.GetItemFromIndex(i) as ProductRouteM;
					ProductRouteMInfo item = new BusinessObjects.ProductRouteMInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.BomMId = uyumObject.BomMId;
					item.ItemId = uyumObject.ItemId;
					item.Description = uyumObject.Description;
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
