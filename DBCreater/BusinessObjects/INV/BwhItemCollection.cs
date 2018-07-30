using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("84fea69b-41ce-4404-b4ba-94726612ca41")]
	[UyumTable("invd_bwh_item",Database="public", InsertStoredProcedure="invd_bwh_item_i", UpdateStoredProcedure="invd_bwh_item_u", DeleteStoredProcedure="invd_bwh_item_d", SelectStoredProcedure="invd_bwh_item_s")]
	public class BwhItemCollection : UyumObjectCollection
	{

		public BwhItemCollection()
		{
			base._ItemType = typeof(BwhItem);
		}

		public override IUyumObject CreateItem()
		{
			return new BwhItem();
		}

		public BwhItem this[int index]
		{
			get { return base.innerList[index] as BwhItem; }
		}

		public static explicit operator List<BwhItemInfo>(BwhItemCollection enumarable)
		{
			List<BwhItemInfo> list = new List<BwhItemInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BwhItem uyumObject = enumarable.GetItemFromIndex(i) as BwhItem;
					BwhItemInfo item = new BusinessObjects.BwhItemInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.ItemId = uyumObject.ItemId;
					item.WhouseId = uyumObject.WhouseId;
					item.QtyPrm = uyumObject.QtyPrm;
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
