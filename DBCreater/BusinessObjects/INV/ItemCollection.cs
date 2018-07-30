using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("2b1fb6e7-a3d7-4e1b-96e2-7b4c3bb7f441")]
	[UyumTable("invd_item",Database="public", InsertStoredProcedure="invd_item_i", UpdateStoredProcedure="invd_item_u", DeleteStoredProcedure="invd_item_d", SelectStoredProcedure="invd_item_s")]
	public class ItemCollection : UyumObjectCollection
	{

		public ItemCollection()
		{
			base._ItemType = typeof(Item);
		}

		public override IUyumObject CreateItem()
		{
			return new Item();
		}

		public Item this[int index]
		{
			get { return base.innerList[index] as Item; }
		}

		public static explicit operator List<ItemInfo>(ItemCollection enumarable)
		{
			List<ItemInfo> list = new List<ItemInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Item uyumObject = enumarable.GetItemFromIndex(i) as Item;
					ItemInfo item = new BusinessObjects.ItemInfo();
					item.Id = uyumObject.Id;
					item.ItemCode = uyumObject.ItemCode;
					item.ItemName = uyumObject.ItemName;
					item.ItemName2 = uyumObject.ItemName2;
					item.UnitId = uyumObject.UnitId;
					item.PercentageOfApproval = uyumObject.PercentageOfApproval;
					item.PercentageOfDeliveriy = uyumObject.PercentageOfDeliveriy;
					item.AddDate01 = uyumObject.AddDate01;
					item.AddDate02 = uyumObject.AddDate02;
					item.AddDate03 = uyumObject.AddDate03;
					item.AddDate04 = uyumObject.AddDate04;
					item.AddDate05 = uyumObject.AddDate05;
					item.AddDate06 = uyumObject.AddDate06;
					item.AddDate08 = uyumObject.AddDate08;
					item.AddDate09 = uyumObject.AddDate09;
					item.AddDate10 = uyumObject.AddDate10;
					item.AddString01 = uyumObject.AddString01;
					item.AddString02 = uyumObject.AddString02;
					item.AddString03 = uyumObject.AddString03;
					item.AddString04 = uyumObject.AddString04;
					item.AddString05 = uyumObject.AddString05;
					item.AddString06 = uyumObject.AddString06;
					item.AddString07 = uyumObject.AddString07;
					item.AddString08 = uyumObject.AddString08;
					item.AddString09 = uyumObject.AddString09;
					item.AddString10 = uyumObject.AddString10;
					item.AddDec01 = uyumObject.AddDec01;
					item.AddDec02 = uyumObject.AddDec02;
					item.AddDec03 = uyumObject.AddDec03;
					item.AddDec04 = uyumObject.AddDec04;
					item.AddDec05 = uyumObject.AddDec05;
					item.AddDec06 = uyumObject.AddDec06;
					item.AddDec07 = uyumObject.AddDec07;
					item.AddDec08 = uyumObject.AddDec08;
					item.AddDec09 = uyumObject.AddDec09;
					item.AddDec10 = uyumObject.AddDec10;
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
