using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("f8dc1944-1c1f-42e2-a7a3-b7246bbec06b")]
	[UyumTable("prdd_wstation_unit",Database="public", InsertStoredProcedure="prdd_wstation_unit_i", UpdateStoredProcedure="prdd_wstation_unit_u", DeleteStoredProcedure="prdd_wstation_unit_d", SelectStoredProcedure="prdd_wstation_unit_s")]
	public class WstationUnitCollection : UyumObjectCollection
	{

		public WstationUnitCollection()
		{
			base._ItemType = typeof(WstationUnit);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationUnit();
		}

		public WstationUnit this[int index]
		{
			get { return base.innerList[index] as WstationUnit; }
		}

		public static explicit operator List<WstationUnitInfo>(WstationUnitCollection enumarable)
		{
			List<WstationUnitInfo> list = new List<WstationUnitInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationUnit uyumObject = enumarable.GetItemFromIndex(i) as WstationUnit;
					WstationUnitInfo item = new BusinessObjects.WstationUnitInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WstationId = uyumObject.WstationId;
					item.Barcode = uyumObject.Barcode;
					item.WstationUnitCode = uyumObject.WstationUnitCode;
					item.WstationUnitDesc = uyumObject.WstationUnitDesc;
					item.NumberOfEmployee = uyumObject.NumberOfEmployee;
					item.IsFollowMasterMaterial = uyumObject.IsFollowMasterMaterial;
					item.IsFinishProduction = uyumObject.IsFinishProduction;
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
