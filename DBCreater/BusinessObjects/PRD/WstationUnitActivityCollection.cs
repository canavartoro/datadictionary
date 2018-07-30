using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("93e95746-582f-46b0-9fdf-4210d64e617d")]
	[UyumTable("prdd_wstation_unit_activity",Database="public", InsertStoredProcedure="prdd_wstation_unit_activity_i", UpdateStoredProcedure="prdd_wstation_unit_activity_u", DeleteStoredProcedure="prdd_wstation_unit_activity_d", SelectStoredProcedure="prdd_wstation_unit_activity_s")]
	public class WstationUnitActivityCollection : UyumObjectCollection
	{

		public WstationUnitActivityCollection()
		{
			base._ItemType = typeof(WstationUnitActivity);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationUnitActivity();
		}

		public WstationUnitActivity this[int index]
		{
			get { return base.innerList[index] as WstationUnitActivity; }
		}

		public static explicit operator List<WstationUnitActivityInfo>(WstationUnitActivityCollection enumarable)
		{
			List<WstationUnitActivityInfo> list = new List<WstationUnitActivityInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationUnitActivity uyumObject = enumarable.GetItemFromIndex(i) as WstationUnitActivity;
					WstationUnitActivityInfo item = new BusinessObjects.WstationUnitActivityInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WstationId = uyumObject.WstationId;
					item.ActivityId = uyumObject.ActivityId;
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
