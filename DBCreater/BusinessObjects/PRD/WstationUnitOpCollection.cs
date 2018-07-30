using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("0eb1cfbe-c73d-4904-a58d-8ba6fbab3831")]
	[UyumTable("prdd_wstation_unit_op",Database="public", InsertStoredProcedure="prdd_wstation_unit_op_i", UpdateStoredProcedure="prdd_wstation_unit_op_u", DeleteStoredProcedure="prdd_wstation_unit_op_d", SelectStoredProcedure="prdd_wstation_unit_op_s")]
	public class WstationUnitOpCollection : UyumObjectCollection
	{

		public WstationUnitOpCollection()
		{
			base._ItemType = typeof(WstationUnitOp);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationUnitOp();
		}

		public WstationUnitOp this[int index]
		{
			get { return base.innerList[index] as WstationUnitOp; }
		}

		public static explicit operator List<WstationUnitOpInfo>(WstationUnitOpCollection enumarable)
		{
			List<WstationUnitOpInfo> list = new List<WstationUnitOpInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationUnitOp uyumObject = enumarable.GetItemFromIndex(i) as WstationUnitOp;
					WstationUnitOpInfo item = new BusinessObjects.WstationUnitOpInfo();
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
