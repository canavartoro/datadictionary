using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("dcae145f-d4ec-4ee8-8d98-b89092eed6b4")]
	[UyumTable("appd_menu",Database="public", InsertStoredProcedure="appd_menu_i", UpdateStoredProcedure="appd_menu_u", DeleteStoredProcedure="appd_menu_d", SelectStoredProcedure="appd_menu_s")]
	public class MenuCollection : UyumObjectCollection
	{

		public MenuCollection()
		{
			base._ItemType = typeof(Menu);
		}

		public override IUyumObject CreateItem()
		{
			return new Menu();
		}

		public Menu this[int index]
		{
			get { return base.innerList[index] as Menu; }
		}

		public static explicit operator List<MenuInfo>(MenuCollection enumarable)
		{
			List<MenuInfo> list = new List<MenuInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Menu uyumObject = enumarable.GetItemFromIndex(i) as Menu;
					MenuInfo item = new BusinessObjects.MenuInfo();
					item.Id = uyumObject.Id;
					item.CmdId = uyumObject.CmdId;
					item.ParentId = uyumObject.ParentId;
					item.IsLeaf = uyumObject.IsLeaf;
					item.IsPassive = uyumObject.IsPassive;
					item.Rank = uyumObject.Rank;
					item.DeviceType = uyumObject.DeviceType;
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
