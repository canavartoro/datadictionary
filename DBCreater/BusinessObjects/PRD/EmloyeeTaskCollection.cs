using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("5219630d-b7c6-4341-8261-da2261e02376")]
	[UyumTable("prdd_emloyee_task",Database="public", InsertStoredProcedure="prdd_emloyee_task_i", UpdateStoredProcedure="prdd_emloyee_task_u", DeleteStoredProcedure="prdd_emloyee_task_d", SelectStoredProcedure="prdd_emloyee_task_s")]
	public class EmloyeeTaskCollection : UyumObjectCollection
	{

		public EmloyeeTaskCollection()
		{
			base._ItemType = typeof(EmloyeeTask);
		}

		public override IUyumObject CreateItem()
		{
			return new EmloyeeTask();
		}

		public EmloyeeTask this[int index]
		{
			get { return base.innerList[index] as EmloyeeTask; }
		}

		public static explicit operator List<EmloyeeTaskInfo>(EmloyeeTaskCollection enumarable)
		{
			List<EmloyeeTaskInfo> list = new List<EmloyeeTaskInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					EmloyeeTask uyumObject = enumarable.GetItemFromIndex(i) as EmloyeeTask;
					EmloyeeTaskInfo item = new BusinessObjects.EmloyeeTaskInfo();
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
