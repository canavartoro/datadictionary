using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("7f28e72b-1765-49fd-bf80-b14286b70109")]
	[UyumTable("gnld_company",Database="public", InsertStoredProcedure="gnld_company_i", UpdateStoredProcedure="gnld_company_u", DeleteStoredProcedure="gnld_company_d", SelectStoredProcedure="gnld_company_s")]
	public class CompanyCollection : UyumObjectCollection
	{

		public CompanyCollection()
		{
			base._ItemType = typeof(Company);
		}

		public override IUyumObject CreateItem()
		{
			return new Company();
		}

		public Company this[int index]
		{
			get { return base.innerList[index] as Company; }
		}

		public static explicit operator List<CompanyInfo>(CompanyCollection enumarable)
		{
			List<CompanyInfo> list = new List<CompanyInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Company uyumObject = enumarable.GetItemFromIndex(i) as Company;
					CompanyInfo item = new BusinessObjects.CompanyInfo();
					item.Id = uyumObject.Id;
					item.CoCode = uyumObject.CoCode;
					item.CoDesc = uyumObject.CoDesc;
					item.CoShortDesc = uyumObject.CoShortDesc;
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
