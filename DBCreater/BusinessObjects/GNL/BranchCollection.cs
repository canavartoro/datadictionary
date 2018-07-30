using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("f4d439e0-b09b-4496-8f90-82af6e6ff510")]
	[UyumTable("gnld_branch",Database="public", InsertStoredProcedure="gnld_branch_i", UpdateStoredProcedure="gnld_branch_u", DeleteStoredProcedure="gnld_branch_d", SelectStoredProcedure="gnld_branch_s")]
	public class BranchCollection : UyumObjectCollection
	{

		public BranchCollection()
		{
			base._ItemType = typeof(Branch);
		}

		public override IUyumObject CreateItem()
		{
			return new Branch();
		}

		public Branch this[int index]
		{
			get { return base.innerList[index] as Branch; }
		}

		public static explicit operator List<BranchInfo>(BranchCollection enumarable)
		{
			List<BranchInfo> list = new List<BranchInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Branch uyumObject = enumarable.GetItemFromIndex(i) as Branch;
					BranchInfo item = new BusinessObjects.BranchInfo();
					item.Id = uyumObject.Id;
					item.BranchCode = uyumObject.BranchCode;
					item.BranchDesc = uyumObject.BranchDesc;
					item.BranchShortDesc = uyumObject.BranchShortDesc;
					item.CoId = uyumObject.CoId;
					item.TownId = uyumObject.TownId;
					item.CityId = uyumObject.CityId;
					item.CountryId = uyumObject.CountryId;
					item.Address1 = uyumObject.Address1;
					item.Address2 = uyumObject.Address2;
					item.Address3 = uyumObject.Address3;
					item.Taxno = uyumObject.Taxno;
					item.TaxOfficeId = uyumObject.TaxOfficeId;
					item.Email = uyumObject.Email;
					item.Fax = uyumObject.Fax;
					item.Tel = uyumObject.Tel;
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
