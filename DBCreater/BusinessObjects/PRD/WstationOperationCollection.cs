using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("1c8f2147-850e-4c75-9908-6cb31c0f1de1")]
	[UyumTable("prdd_wstation_operation",Database="public", InsertStoredProcedure="prdd_wstation_operation_i", UpdateStoredProcedure="prdd_wstation_operation_u", DeleteStoredProcedure="prdd_wstation_operation_d", SelectStoredProcedure="prdd_wstation_operation_s")]
	public class WstationOperationCollection : UyumObjectCollection
	{

		public WstationOperationCollection()
		{
			base._ItemType = typeof(WstationOperation);
		}

		public override IUyumObject CreateItem()
		{
			return new WstationOperation();
		}

		public WstationOperation this[int index]
		{
			get { return base.innerList[index] as WstationOperation; }
		}

		public static explicit operator List<WstationOperationInfo>(WstationOperationCollection enumarable)
		{
			List<WstationOperationInfo> list = new List<WstationOperationInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					WstationOperation uyumObject = enumarable.GetItemFromIndex(i) as WstationOperation;
					WstationOperationInfo item = new BusinessObjects.WstationOperationInfo();
					item.Id = uyumObject.Id;
					item.OperationId = uyumObject.OperationId;
					item.WstationId = uyumObject.WstationId;
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
