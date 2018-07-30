using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("176bd487-35ba-41ab-90dd-3daec86c6996")]
	[UyumTable("invd_item_unit",Database="public", InsertStoredProcedure="invd_item_unit_i", UpdateStoredProcedure="invd_item_unit_u", DeleteStoredProcedure="invd_item_unit_d", SelectStoredProcedure="invd_item_unit_s")]
	public class ItemUnitCollection : UyumObjectCollection
	{

		public ItemUnitCollection()
		{
			base._ItemType = typeof(ItemUnit);
		}

		public override IUyumObject CreateItem()
		{
			return new ItemUnit();
		}

		public ItemUnit this[int index]
		{
			get { return base.innerList[index] as ItemUnit; }
		}

		public static explicit operator List<ItemUnitInfo>(ItemUnitCollection enumarable)
		{
			List<ItemUnitInfo> list = new List<ItemUnitInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					ItemUnit uyumObject = enumarable.GetItemFromIndex(i) as ItemUnit;
					ItemUnitInfo item = new BusinessObjects.ItemUnitInfo();
					item.Id = uyumObject.Id;
					item.LineNo = uyumObject.LineNo;
					item.UnitId = uyumObject.UnitId;
					item.Unit2Id = uyumObject.Unit2Id;
					item.Rate = uyumObject.Rate;
					item.Rate2 = uyumObject.Rate2;
					item.Volume = uyumObject.Volume;
					item.Weight = uyumObject.Weight;
					item.Height = uyumObject.Height;
					item.Depth = uyumObject.Depth;
					item.Width = uyumObject.Width;
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
