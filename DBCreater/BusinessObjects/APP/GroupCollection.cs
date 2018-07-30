using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("3fdc7147-4090-4d38-a978-708a5f32d01a")]
	[UyumTable("appd_group",Database="public", InsertStoredProcedure="appd_group_i", UpdateStoredProcedure="appd_group_u", DeleteStoredProcedure="appd_group_d", SelectStoredProcedure="appd_group_s")]
	public class GroupCollection : UyumObjectCollection
	{

		public GroupCollection()
		{
			base._ItemType = typeof(Group);
		}

		public override IUyumObject CreateItem()
		{
			return new Group();
		}

		public Group this[int index]
		{
			get { return base.innerList[index] as Group; }
		}

		public static explicit operator List<GroupInfo>(GroupCollection enumarable)
		{
			List<GroupInfo> list = new List<GroupInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Group uyumObject = enumarable.GetItemFromIndex(i) as Group;
					GroupInfo item = new BusinessObjects.GroupInfo();
					item.Id = uyumObject.Id;
					item.GroupName = uyumObject.GroupName;
					item.GroupCode = uyumObject.GroupCode;
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
