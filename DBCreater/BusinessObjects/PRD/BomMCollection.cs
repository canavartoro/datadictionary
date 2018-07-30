using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("c4ff6dde-e967-4341-9398-6f1fddebe0b2")]
	[UyumTable("prdd_bom_m",Database="public", InsertStoredProcedure="prdd_bom_m_i", UpdateStoredProcedure="prdd_bom_m_u", DeleteStoredProcedure="prdd_bom_m_d", SelectStoredProcedure="prdd_bom_m_s")]
	public class BomMCollection : UyumObjectCollection
	{

		public BomMCollection()
		{
			base._ItemType = typeof(BomM);
		}

		public override IUyumObject CreateItem()
		{
			return new BomM();
		}

		public BomM this[int index]
		{
			get { return base.innerList[index] as BomM; }
		}

		public static explicit operator List<BomMInfo>(BomMCollection enumarable)
		{
			List<BomMInfo> list = new List<BomMInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BomM uyumObject = enumarable.GetItemFromIndex(i) as BomM;
					BomMInfo item = new BusinessObjects.BomMInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.ItemId = uyumObject.ItemId;
					item.IsDefault = uyumObject.IsDefault;
					item.AlternatifNo = uyumObject.AlternatifNo;
					item.UnitId = uyumObject.UnitId;
					item.ErpBomMId = uyumObject.ErpBomMId;
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
