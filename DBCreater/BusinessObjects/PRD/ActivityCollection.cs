using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("ce8c51e5-c631-439a-a209-cc4a3966ac03")]
	[UyumTable("prdd_activity",Database="public", InsertStoredProcedure="prdd_activity_i", UpdateStoredProcedure="prdd_activity_u", DeleteStoredProcedure="prdd_activity_d", SelectStoredProcedure="prdd_activity_s")]
	public class ActivityCollection : UyumObjectCollection
	{

		public ActivityCollection()
		{
			base._ItemType = typeof(Activity);
		}

		public override IUyumObject CreateItem()
		{
			return new Activity();
		}

		public Activity this[int index]
		{
			get { return base.innerList[index] as Activity; }
		}

		public static explicit operator List<ActivityInfo>(ActivityCollection enumarable)
		{
			List<ActivityInfo> list = new List<ActivityInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Activity uyumObject = enumarable.GetItemFromIndex(i) as Activity;
					ActivityInfo item = new BusinessObjects.ActivityInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.OperationId = uyumObject.OperationId;
					item.ActivityCode = uyumObject.ActivityCode;
					item.ActivityDesc = uyumObject.ActivityDesc;
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
