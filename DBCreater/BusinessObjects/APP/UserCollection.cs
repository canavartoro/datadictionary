using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("6363469c-7c40-4c6d-b4ad-a2c2c6e0117d")]
	[UyumTable("appd_user",Database="public", InsertStoredProcedure="appd_user_i", UpdateStoredProcedure="appd_user_u", DeleteStoredProcedure="appd_user_d", SelectStoredProcedure="appd_user_s")]
	public class UserCollection : UyumObjectCollection
	{

		public UserCollection()
		{
			base._ItemType = typeof(User);
		}

		public override IUyumObject CreateItem()
		{
			return new User();
		}

		public User this[int index]
		{
			get { return base.innerList[index] as User; }
		}

		public static explicit operator List<UserInfo>(UserCollection enumarable)
		{
			List<UserInfo> list = new List<UserInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					User uyumObject = enumarable.GetItemFromIndex(i) as User;
					UserInfo item = new BusinessObjects.UserInfo();
					item.Id = uyumObject.Id;
					item.UsName = uyumObject.UsName;
					item.UsSurname = uyumObject.UsSurname;
					item.UsUsername = uyumObject.UsUsername;
					item.Email = uyumObject.Email;
					item.UsPassword = uyumObject.UsPassword;
					item.Note1 = uyumObject.Note1;
					item.LangId = uyumObject.LangId;
					item.CitizenshipNo = uyumObject.CitizenshipNo;
					item.UsEnabled = uyumObject.UsEnabled;
					item.MobileTel = uyumObject.MobileTel;
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
