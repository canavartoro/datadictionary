using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("98d5900d-52d3-4580-bf81-f1f75754dd0e")]
	[UyumTable("invd_unit_type",Database="public", InsertStoredProcedure="invd_unit_type_i", UpdateStoredProcedure="invd_unit_type_u", DeleteStoredProcedure="invd_unit_type_d", SelectStoredProcedure="invd_unit_type_s")]
	public class UnitTypeCollection : UyumObjectCollection
	{

		public UnitTypeCollection()
		{
			base._ItemType = typeof(UnitType);
		}

		public override IUyumObject CreateItem()
		{
			return new UnitType();
		}

		public UnitType this[int index]
		{
			get { return base.innerList[index] as UnitType; }
		}

		public static explicit operator List<UnitTypeInfo>(UnitTypeCollection enumarable)
		{
			List<UnitTypeInfo> list = new List<UnitTypeInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					UnitType uyumObject = enumarable.GetItemFromIndex(i) as UnitType;
					UnitTypeInfo item = new BusinessObjects.UnitTypeInfo();
					item.Id = uyumObject.Id;
					item.UnitTypeCode = uyumObject.UnitTypeCode;
					item.UnitTypeDesc = uyumObject.UnitTypeDesc;
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
