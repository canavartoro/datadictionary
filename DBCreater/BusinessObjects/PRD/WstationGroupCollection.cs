using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("0e580372-c5ea-471c-a97e-f34b135eab8a")]
	[UyumTable("prdd_wstation_group ",Database="public", InsertStoredProcedure="prdd_wstation_group _i", UpdateStoredProcedure="prdd_wstation_group _u", DeleteStoredProcedure="prdd_wstation_group _d", SelectStoredProcedure="prdd_wstation_group _s")]
	public class WstationGroupCollection : UyumObjectCollection
	{

		public WstationGroupCollection()
		{
			base._ItemType = typeof(WstationGroup);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationGroup();
		}

		public WstationGroup this[int index]
		{
			get { return base.innerList[index] as WstationGroup; }
		}

		public static explicit operator List<WstationGroupInfo>(WstationGroupCollection enumarable)
		{
			List<WstationGroupInfo> list = new List<WstationGroupInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationGroup uyumObject = enumarable.GetItemFromIndex(i) as WstationGroup;
					WstationGroupInfo item = new BusinessObjects.WstationGroupInfo();
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
