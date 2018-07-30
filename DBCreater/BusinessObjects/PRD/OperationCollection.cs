using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("1cc357ce-b696-4233-8bd2-460f54d59f4b")]
	[UyumTable("prdd_operation",Database="public", InsertStoredProcedure="prdd_operation_i", UpdateStoredProcedure="prdd_operation_u", DeleteStoredProcedure="prdd_operation_d", SelectStoredProcedure="prdd_operation_s")]
	public class OperationCollection : UyumObjectCollection
	{

		public OperationCollection()
		{
			base._ItemType = typeof(Operation);
		}

		public override IUyumObject CreateItem()
		{
			return new Operation();
		}

		public Operation this[int index]
		{
			get { return base.innerList[index] as Operation; }
		}

		public static explicit operator List<OperationInfo>(OperationCollection enumarable)
		{
			List<OperationInfo> list = new List<OperationInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Operation uyumObject = enumarable.GetItemFromIndex(i) as Operation;
					OperationInfo item = new BusinessObjects.OperationInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.OperationCode = uyumObject.OperationCode;
					item.OperationDesc = uyumObject.OperationDesc;
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
