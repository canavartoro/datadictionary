using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("57511311-386f-498c-926d-a39d4436673a")]
	[UyumTable("prdd_wcenter_group",Database="public", InsertStoredProcedure="prdd_wcenter_group_i", UpdateStoredProcedure="prdd_wcenter_group_u", DeleteStoredProcedure="prdd_wcenter_group_d", SelectStoredProcedure="prdd_wcenter_group_s")]
	public class WcenterGroupCollection : UyumObjectCollection
	{

		public WcenterGroupCollection()
		{
			base._ItemType = typeof(WcenterGroup);
		}

		public override IUyumObject CreateItem()
		{
			return new WcenterGroup();
		}

		public WcenterGroup this[int index]
		{
			get { return base.innerList[index] as WcenterGroup; }
		}

		public static explicit operator List<WcenterGroupInfo>(WcenterGroupCollection enumarable)
		{
			List<WcenterGroupInfo> list = new List<WcenterGroupInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WcenterGroup uyumObject = enumarable.GetItemFromIndex(i) as WcenterGroup;
					WcenterGroupInfo item = new BusinessObjects.WcenterGroupInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WcenterGroupCode = uyumObject.WcenterGroupCode;
					item.WcenterGroupDesc = uyumObject.WcenterGroupDesc;
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
