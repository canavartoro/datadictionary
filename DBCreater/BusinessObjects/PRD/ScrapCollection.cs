using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("8330c64a-d41e-4084-9460-a0428724a668")]
	[UyumTable("prdt_scrap",Database="public", InsertStoredProcedure="prdt_scrap_i", UpdateStoredProcedure="prdt_scrap_u", DeleteStoredProcedure="prdt_scrap_d", SelectStoredProcedure="prdt_scrap_s")]
	public class ScrapCollection : UyumObjectCollection
	{

		public ScrapCollection()
		{
			base._ItemType = typeof(Scrap);
		}

		public override IUyumObject CreateItem()
		{
			return new Scrap();
		}

		public Scrap this[int index]
		{
			get { return base.innerList[index] as Scrap; }
		}

		public static explicit operator List<ScrapInfo>(ScrapCollection enumarable)
		{
			List<ScrapInfo> list = new List<ScrapInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Scrap uyumObject = enumarable.GetItemFromIndex(i) as Scrap;
					ScrapInfo item = new BusinessObjects.ScrapInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
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
