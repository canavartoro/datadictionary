using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("6eae5c5f-c071-4ac5-ab20-dcfbb3c2d776")]
	[UyumTable("prdd_wstation_unit_group",Database="public", InsertStoredProcedure="prdd_wstation_unit_group_i", UpdateStoredProcedure="prdd_wstation_unit_group_u", DeleteStoredProcedure="prdd_wstation_unit_group_d", SelectStoredProcedure="prdd_wstation_unit_group_s")]
	public class WstationUnitGroupCollection : UyumObjectCollection
	{

		public WstationUnitGroupCollection()
		{
			base._ItemType = typeof(WstationUnitGroup);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationUnitGroup();
		}

		public WstationUnitGroup this[int index]
		{
			get { return base.innerList[index] as WstationUnitGroup; }
		}

		public static explicit operator List<WstationUnitGroupInfo>(WstationUnitGroupCollection enumarable)
		{
			List<WstationUnitGroupInfo> list = new List<WstationUnitGroupInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationUnitGroup uyumObject = enumarable.GetItemFromIndex(i) as WstationUnitGroup;
					WstationUnitGroupInfo item = new BusinessObjects.WstationUnitGroupInfo();
					item.Id = uyumObject.Id;
					item.BranchId = uyumObject.BranchId;
					item.CoId = uyumObject.CoId;
					item.WstationUnitGroupCode = uyumObject.WstationUnitGroupCode;
					item.WstationUnitGroupName = uyumObject.WstationUnitGroupName;
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
