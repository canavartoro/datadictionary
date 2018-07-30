using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c90ccdd8-89be-4492-b605-e66fc08e3b5f")]
	[UyumTable("prdd_scrap_reason",Database="public", InsertStoredProcedure="prdd_scrap_reason_i", UpdateStoredProcedure="prdd_scrap_reason_u", DeleteStoredProcedure="prdd_scrap_reason_d", SelectStoredProcedure="prdd_scrap_reason_s")]
	public class ScrapReasonCollection : UyumObjectCollection
	{

		public ScrapReasonCollection()
		{
			base._ItemType = typeof(ScrapReason);
		}

		public override IUyumObject CreateItem()
		{
			return new ScrapReason();
		}

		public ScrapReason this[int index]
		{
			get { return base.innerList[index] as ScrapReason; }
		}

		public static explicit operator List<ScrapReasonInfo>(ScrapReasonCollection enumarable)
		{
			List<ScrapReasonInfo> list = new List<ScrapReasonInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					ScrapReason uyumObject = enumarable.GetItemFromIndex(i) as ScrapReason;
					ScrapReasonInfo item = new BusinessObjects.ScrapReasonInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.ScrapReasonDesc = uyumObject.ScrapReasonDesc;
					item.ScrapGroupId = uyumObject.ScrapGroupId;
					item.IsMasterMaterial = uyumObject.IsMasterMaterial;
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
