using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("87706c27-4e5f-4751-8c77-56bb95fb177e")]
	[UyumTable("invd_branch_item",Database="public", InsertStoredProcedure="invd_branch_item_i", UpdateStoredProcedure="invd_branch_item_u", DeleteStoredProcedure="invd_branch_item_d", SelectStoredProcedure="invd_branch_item_s")]
	public class BranchItemCollection : UyumObjectCollection
	{

		public BranchItemCollection()
		{
			base._ItemType = typeof(BranchItem);
		}

		public override IUyumObject CreateItem()
		{
			return new BranchItem();
		}

		public BranchItem this[int index]
		{
			get { return base.innerList[index] as BranchItem; }
		}

		public static explicit operator List<BranchItemInfo>(BranchItemCollection enumarable)
		{
			List<BranchItemInfo> list = new List<BranchItemInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BranchItem uyumObject = enumarable.GetItemFromIndex(i) as BranchItem;
					BranchItemInfo item = new BusinessObjects.BranchItemInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.ItemId = uyumObject.ItemId;
					item.PercentageOfApproval = uyumObject.PercentageOfApproval;
					item.PercentageOfDeliveriy = uyumObject.PercentageOfDeliveriy;
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
