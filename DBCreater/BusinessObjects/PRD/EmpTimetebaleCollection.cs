using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("402dcc87-dff0-4f9c-9647-2cc3fddfc8d2")]
	[UyumTable("prdt_emp_timetebale",Database="public", InsertStoredProcedure="prdt_emp_timetebale_i", UpdateStoredProcedure="prdt_emp_timetebale_u", DeleteStoredProcedure="prdt_emp_timetebale_d", SelectStoredProcedure="prdt_emp_timetebale_s")]
	public class EmpTimetebaleCollection : UyumObjectCollection
	{

		public EmpTimetebaleCollection()
		{
			base._ItemType = typeof(EmpTimetebale);
		}

		public override IUyumObject CreateItem()
		{
			return new EmpTimetebale();
		}

		public EmpTimetebale this[int index]
		{
			get { return base.innerList[index] as EmpTimetebale; }
		}

		public static explicit operator List<EmpTimetebaleInfo>(EmpTimetebaleCollection enumarable)
		{
			List<EmpTimetebaleInfo> list = new List<EmpTimetebaleInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					EmpTimetebale uyumObject = enumarable.GetItemFromIndex(i) as EmpTimetebale;
					EmpTimetebaleInfo item = new BusinessObjects.EmpTimetebaleInfo();
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
