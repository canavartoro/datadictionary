using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("63f666cb-4e5c-4804-8e78-c968c65e9f88")]
	[UyumTable("prdd_scrap_group",Database="public", InsertStoredProcedure="prdd_scrap_group_i", UpdateStoredProcedure="prdd_scrap_group_u", DeleteStoredProcedure="prdd_scrap_group_d", SelectStoredProcedure="prdd_scrap_group_s")]
	public class ScrapGroupCollection : UyumObjectCollection
	{

		public ScrapGroupCollection()
		{
			base._ItemType = typeof(ScrapGroup);
		}

		public override IUyumObject CreateItem()
		{
			return new ScrapGroup();
		}

		public ScrapGroup this[int index]
		{
			get { return base.innerList[index] as ScrapGroup; }
		}

		public static explicit operator List<ScrapGroupInfo>(ScrapGroupCollection enumarable)
		{
			List<ScrapGroupInfo> list = new List<ScrapGroupInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					ScrapGroup uyumObject = enumarable.GetItemFromIndex(i) as ScrapGroup;
					ScrapGroupInfo item = new BusinessObjects.ScrapGroupInfo();
					item.Id = uyumObject.Id;
					item.Id = uyumObject.Id;
					item.ScrapGroupDesc = uyumObject.ScrapGroupDesc;
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
