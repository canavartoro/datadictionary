using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("31b2e65c-7c09-4441-8c5a-fe1fd0461e6b")]
	[UyumTable("prdd_wcenter_operation",Database="public", InsertStoredProcedure="prdd_wcenter_operation_i", UpdateStoredProcedure="prdd_wcenter_operation_u", DeleteStoredProcedure="prdd_wcenter_operation_d", SelectStoredProcedure="prdd_wcenter_operation_s")]
	public class WcenterOperationCollection : UyumObjectCollection
	{

		public WcenterOperationCollection()
		{
			base._ItemType = typeof(WcenterOperation);
		}

		public override IUyumObject CreateItem()
		{
			return new WcenterOperation();
		}

		public WcenterOperation this[int index]
		{
			get { return base.innerList[index] as WcenterOperation; }
		}

		public static explicit operator List<WcenterOperationInfo>(WcenterOperationCollection enumarable)
		{
			List<WcenterOperationInfo> list = new List<WcenterOperationInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WcenterOperation uyumObject = enumarable.GetItemFromIndex(i) as WcenterOperation;
					WcenterOperationInfo item = new BusinessObjects.WcenterOperationInfo();
					item.Id = uyumObject.Id;
					item.OperationId = uyumObject.OperationId;
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
