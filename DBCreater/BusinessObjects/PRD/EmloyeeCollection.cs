using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("9cde1bdc-ed0f-4814-b42b-5b53cb8e34dd")]
	[UyumTable("prdd_emloyee",Database="public", InsertStoredProcedure="prdd_emloyee_i", UpdateStoredProcedure="prdd_emloyee_u", DeleteStoredProcedure="prdd_emloyee_d", SelectStoredProcedure="prdd_emloyee_s")]
	public class EmloyeeCollection : UyumObjectCollection
	{

		public EmloyeeCollection()
		{
			base._ItemType = typeof(Emloyee);
		}

		public override IUyumObject CreateItem()
		{
			return new Emloyee();
		}

		public Emloyee this[int index]
		{
			get { return base.innerList[index] as Emloyee; }
		}

		public static explicit operator List<EmloyeeInfo>(EmloyeeCollection enumarable)
		{
			List<EmloyeeInfo> list = new List<EmloyeeInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Emloyee uyumObject = enumarable.GetItemFromIndex(i) as Emloyee;
					EmloyeeInfo item = new BusinessObjects.EmloyeeInfo();
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
