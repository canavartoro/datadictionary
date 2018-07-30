using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("a7a8663c-c415-4699-9a48-76706925d9a6")]
	[UyumTable("invd_unit",Database="public", InsertStoredProcedure="invd_unit_i", UpdateStoredProcedure="invd_unit_u", DeleteStoredProcedure="invd_unit_d", SelectStoredProcedure="invd_unit_s")]
	public class UnitCollection : UyumObjectCollection
	{

		public UnitCollection()
		{
			base._ItemType = typeof(Unit);
		}

		public override IUyumObject CreateItem()
		{
			return new Unit();
		}

		public Unit this[int index]
		{
			get { return base.innerList[index] as Unit; }
		}

		public static explicit operator List<UnitInfo>(UnitCollection enumarable)
		{
			List<UnitInfo> list = new List<UnitInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Unit uyumObject = enumarable.GetItemFromIndex(i) as Unit;
					UnitInfo item = new BusinessObjects.UnitInfo();
					item.Id = uyumObject.Id;
					item.UnitCode = uyumObject.UnitCode;
					item.UnitDesc = uyumObject.UnitDesc;
					item.Precision = uyumObject.Precision;
					item.IsoUnitCode = uyumObject.IsoUnitCode;
					item.UnitTypeId = uyumObject.UnitTypeId;
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
