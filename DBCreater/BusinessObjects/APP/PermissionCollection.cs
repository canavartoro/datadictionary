using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("0c29fca5-d84f-40fc-8466-1add09b3e6ff")]
	[UyumTable("appd_permission",Database="public", InsertStoredProcedure="appd_permission_i", UpdateStoredProcedure="appd_permission_u", DeleteStoredProcedure="appd_permission_d", SelectStoredProcedure="appd_permission_s")]
	public class PermissionCollection : UyumObjectCollection
	{

		public PermissionCollection()
		{
			base._ItemType = typeof(Permission);
		}

		public override IUyumObject CreateItem()
		{
			return new Permission();
		}

		public Permission this[int index]
		{
			get { return base.innerList[index] as Permission; }
		}

		public static explicit operator List<PermissionInfo>(PermissionCollection enumarable)
		{
			List<PermissionInfo> list = new List<PermissionInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Permission uyumObject = enumarable.GetItemFromIndex(i) as Permission;
					PermissionInfo item = new BusinessObjects.PermissionInfo();
					item.Id = uyumObject.Id;
					item.GroupId = uyumObject.GroupId;
					item.CmdId = uyumObject.CmdId;
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
