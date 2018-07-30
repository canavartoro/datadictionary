using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("4fb5995b-8da8-48b4-8d92-6bdc3c698eac")]
	[UyumTable("prdd_empleyee_activity",Database="public", InsertStoredProcedure="prdd_empleyee_activity_i", UpdateStoredProcedure="prdd_empleyee_activity_u", DeleteStoredProcedure="prdd_empleyee_activity_d", SelectStoredProcedure="prdd_empleyee_activity_s")]
	public class EmpleyeeActivityCollection : UyumObjectCollection
	{

		public EmpleyeeActivityCollection()
		{
			base._ItemType = typeof(EmpleyeeActivity);
		}

		public override IUyumObject CreateItem()
		{
			return new EmpleyeeActivity();
		}

		public EmpleyeeActivity this[int index]
		{
			get { return base.innerList[index] as EmpleyeeActivity; }
		}

		public static explicit operator List<EmpleyeeActivityInfo>(EmpleyeeActivityCollection enumarable)
		{
			List<EmpleyeeActivityInfo> list = new List<EmpleyeeActivityInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					EmpleyeeActivity uyumObject = enumarable.GetItemFromIndex(i) as EmpleyeeActivity;
					EmpleyeeActivityInfo item = new BusinessObjects.EmpleyeeActivityInfo();
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
