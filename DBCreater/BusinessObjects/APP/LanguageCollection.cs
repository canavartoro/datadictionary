using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("7f65cb64-51e7-480a-a11c-a759f018ff85")]
	[UyumTable("appd_language",Database="public", InsertStoredProcedure="appd_language_i", UpdateStoredProcedure="appd_language_u", DeleteStoredProcedure="appd_language_d", SelectStoredProcedure="appd_language_s")]
	public class LanguageCollection : UyumObjectCollection
	{

		public LanguageCollection()
		{
			base._ItemType = typeof(Language);
		}

		public override IUyumObject CreateItem()
		{
			return new Language();
		}

		public Language this[int index]
		{
			get { return base.innerList[index] as Language; }
		}

		public static explicit operator List<LanguageInfo>(LanguageCollection enumarable)
		{
			List<LanguageInfo> list = new List<LanguageInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Language uyumObject = enumarable.GetItemFromIndex(i) as Language;
					LanguageInfo item = new BusinessObjects.LanguageInfo();
					item.Id = uyumObject.Id;
					item.LanguageCode = uyumObject.LanguageCode;
					item.LanguageName = uyumObject.LanguageName;
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
