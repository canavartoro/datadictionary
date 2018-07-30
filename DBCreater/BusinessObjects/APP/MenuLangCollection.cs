using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("52192ef9-3358-4a8f-b2d1-99722d6b6973")]
	[UyumTable("appd_menu_lang",Database="public", InsertStoredProcedure="appd_menu_lang_i", UpdateStoredProcedure="appd_menu_lang_u", DeleteStoredProcedure="appd_menu_lang_d", SelectStoredProcedure="appd_menu_lang_s")]
	public class MenuLangCollection : UyumObjectCollection
	{

		public MenuLangCollection()
		{
			base._ItemType = typeof(MenuLang);
		}

		public override IUyumObject CreateItem()
		{
			return new MenuLang();
		}

		public MenuLang this[int index]
		{
			get { return base.innerList[index] as MenuLang; }
		}

		public static explicit operator List<MenuLangInfo>(MenuLangCollection enumarable)
		{
			List<MenuLangInfo> list = new List<MenuLangInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					MenuLang uyumObject = enumarable.GetItemFromIndex(i) as MenuLang;
					MenuLangInfo item = new BusinessObjects.MenuLangInfo();
					item.Id = uyumObject.Id;
					item.MenuId = uyumObject.MenuId;
					item.LangId = uyumObject.LangId;
					item.MenuName = uyumObject.MenuName;
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
