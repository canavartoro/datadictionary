using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("7c87324e-e9b9-4f30-8cb3-e8aa1cc083f9")]
	[UyumTable("prdd_wcenter",Database="public", InsertStoredProcedure="prdd_wcenter_i", UpdateStoredProcedure="prdd_wcenter_u", DeleteStoredProcedure="prdd_wcenter_d", SelectStoredProcedure="prdd_wcenter_s")]
	public class WcenterCollection : UyumObjectCollection
	{

		public WcenterCollection()
		{
			base._ItemType = typeof(Wcenter);
		}

		public override IUyumObject CreateItem()
		{
			return new Wcenter();
		}

		public Wcenter this[int index]
		{
			get { return base.innerList[index] as Wcenter; }
		}

		public static explicit operator List<WcenterInfo>(WcenterCollection enumarable)
		{
			List<WcenterInfo> list = new List<WcenterInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Wcenter uyumObject = enumarable.GetItemFromIndex(i) as Wcenter;
					WcenterInfo item = new BusinessObjects.WcenterInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WcenterCode = uyumObject.WcenterCode;
					item.WcenterDesc = uyumObject.WcenterDesc;
					item.IsOutsideWcenter = uyumObject.IsOutsideWcenter;
					item.WcenterGroupId = uyumObject.WcenterGroupId;
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
