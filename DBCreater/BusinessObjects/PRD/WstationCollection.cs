using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("a24ca38e-f9d5-46c9-b576-81709605ae27")]
	[UyumTable("prdd_wstation",Database="public", InsertStoredProcedure="prdd_wstation_i", UpdateStoredProcedure="prdd_wstation_u", DeleteStoredProcedure="prdd_wstation_d", SelectStoredProcedure="prdd_wstation_s")]
	public class WstationCollection : UyumObjectCollection
	{

		public WstationCollection()
		{
			base._ItemType = typeof(Wstation);
		}

		public override IUyumObject CreateItem()
		{
			return new Wstation();
		}

		public Wstation this[int index]
		{
			get { return base.innerList[index] as Wstation; }
		}

		public static explicit operator List<WstationInfo>(WstationCollection enumarable)
		{
			List<WstationInfo> list = new List<WstationInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Wstation uyumObject = enumarable.GetItemFromIndex(i) as Wstation;
					WstationInfo item = new BusinessObjects.WstationInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WstationCode = uyumObject.WstationCode;
					item.WstationDesc = uyumObject.WstationDesc;
					item.IsOutsideWstation = uyumObject.IsOutsideWstation;
					item.SupplierId = uyumObject.SupplierId;
					item.WcenterId = uyumObject.WcenterId;
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
