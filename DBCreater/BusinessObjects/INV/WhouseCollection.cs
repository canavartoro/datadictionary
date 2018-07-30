using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("3e756ae4-5820-4248-8bfa-8daa32ff3d13")]
	[UyumTable("invd_whouse",Database="public", InsertStoredProcedure="invd_whouse_i", UpdateStoredProcedure="invd_whouse_u", DeleteStoredProcedure="invd_whouse_d", SelectStoredProcedure="invd_whouse_s")]
	public class WhouseCollection : UyumObjectCollection
	{

		public WhouseCollection()
		{
			base._ItemType = typeof(Whouse);
		}

		public override IUyumObject CreateItem()
		{
			return new Whouse();
		}

		public Whouse this[int index]
		{
			get { return base.innerList[index] as Whouse; }
		}

		public static explicit operator List<WhouseInfo>(WhouseCollection enumarable)
		{
			List<WhouseInfo> list = new List<WhouseInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Whouse uyumObject = enumarable.GetItemFromIndex(i) as Whouse;
					WhouseInfo item = new BusinessObjects.WhouseInfo();
					item.Id = uyumObject.Id;
					item.WhouseCode = uyumObject.WhouseCode;
					item.WhouseDesc = uyumObject.WhouseDesc;
					item.EntityId = uyumObject.EntityId;
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
