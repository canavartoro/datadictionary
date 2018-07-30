using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("6c97b02e-7638-4302-898e-d74a444b0088")]
	[UyumTable("appd_group_user",Database="public", InsertStoredProcedure="appd_group_user_i", UpdateStoredProcedure="appd_group_user_u", DeleteStoredProcedure="appd_group_user_d", SelectStoredProcedure="appd_group_user_s")]
	public class GroupUserCollection : UyumObjectCollection
	{

		public GroupUserCollection()
		{
			base._ItemType = typeof(GroupUser);
		}

		public override IUyumObject CreateItem()
		{
			return new GroupUser();
		}

		public GroupUser this[int index]
		{
			get { return base.innerList[index] as GroupUser; }
		}

		public static explicit operator List<GroupUserInfo>(GroupUserCollection enumarable)
		{
			List<GroupUserInfo> list = new List<GroupUserInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					GroupUser uyumObject = enumarable.GetItemFromIndex(i) as GroupUser;
					GroupUserInfo item = new BusinessObjects.GroupUserInfo();
					item.Id = uyumObject.Id;
					item.GroupId = uyumObject.GroupId;
					item.UsId = uyumObject.UsId;
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
