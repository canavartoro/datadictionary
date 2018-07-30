using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("eb02968f-db13-42a5-a716-2890204b1a45")]
	public class Branch : UyumObjectBase
	{

		public Branch()
		{
		}

		private int _BranchId = 0;//integer
		private string _BranchCode = string.Empty;//varchar(25)
		private string _BranchDesc = string.Empty;//varchar(100)
		private string _BranchShortDesc = string.Empty;//varchar(100)
		private int _CoId = 0;//integer
		private int _TownId = 0;//integer
		private int _CityId = 0;//integer
		private int _CountryId = 0;//integer
		private string _Address1 = string.Empty;//varchar(100)
		private string _Address2 = string.Empty;//varchar(100)
		private string _Address3 = string.Empty;//varchar(100)
		private string _Taxno = string.Empty;//varchar(25)
		private int _TaxOfficeId = 0;//integer
		private string _Email = string.Empty;//varchar(25)
		private string _Fax = string.Empty;//varchar(20)
		private string _Tel = string.Empty;//varchar(20)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("branch_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("branch_code", Length = 25)]
		public string BranchCode
		{
			get { return _BranchCode; }
			set { _BranchCode = value; }
		}

		[Server]
		[DataString("branch_desc", Length = 100)]
		public string BranchDesc
		{
			get { return _BranchDesc; }
			set { _BranchDesc = value; }
		}

		[Server]
		[DataString("branch_short_desc", Length = 100)]
		public string BranchShortDesc
		{
			get { return _BranchShortDesc; }
			set { _BranchShortDesc = value; }
		}

		[Server]
		[DataInt32("co_id")]
		public int CoId
		{
			get { return _CoId; }
			set { _CoId = value; }
		}

		[Server]
		[DataInt32("town_id")]
		public int TownId
		{
			get { return _TownId; }
			set { _TownId = value; }
		}

		[Server]
		[DataInt32("city_id")]
		public int CityId
		{
			get { return _CityId; }
			set { _CityId = value; }
		}

		[Server]
		[DataInt32("country_id")]
		public int CountryId
		{
			get { return _CountryId; }
			set { _CountryId = value; }
		}

		[Server]
		[DataString("address1", Length = 100)]
		public string Address1
		{
			get { return _Address1; }
			set { _Address1 = value; }
		}

		[Server]
		[DataString("address2", Length = 100)]
		public string Address2
		{
			get { return _Address2; }
			set { _Address2 = value; }
		}

		[Server]
		[DataString("address3", Length = 100)]
		public string Address3
		{
			get { return _Address3; }
			set { _Address3 = value; }
		}

		[Server]
		[DataString("taxno", Length = 25)]
		public string Taxno
		{
			get { return _Taxno; }
			set { _Taxno = value; }
		}

		[Server]
		[DataInt32("tax_office_id")]
		public int TaxOfficeId
		{
			get { return _TaxOfficeId; }
			set { _TaxOfficeId = value; }
		}

		[Server]
		[DataString("email", Length = 25)]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		[Server]
		[DataString("fax", Length = 20)]
		public string Fax
		{
			get { return _Fax; }
			set { _Fax = value; }
		}

		[Server]
		[DataString("tel", Length = 20)]
		public string Tel
		{
			get { return _Tel; }
			set { _Tel = value; }
		}

		[Server]
		[DataInt32("create_user_id")]
		public int CreateUserId
		{
			get { return _CreateUserId; }
			set { _CreateUserId = value; }
		}

		[Server]
		[DataTime("create_date")]
		public DateTime CreateDate
		{
			get { return _CreateDate; }
			set { _CreateDate = value; }
		}

		[Server]
		[DataInt32("update_user_id")]
		public int UpdateUserId
		{
			get { return _UpdateUserId; }
			set { _UpdateUserId = value; }
		}

		[Server]
		[DataTime("update_date")]
		public DateTime UpdateDate
		{
			get { return _UpdateDate; }
			set { _UpdateDate = value; }
		}


	}
	[DataContract(Name = "Branch")]
	public class BranchInfo
	{

		public BranchInfo()
		{
		}

		[DataMember(Name = "branch_id")]
		public int Id { get; set; }

		[DataMember(Name = "branch_code")]
		public string BranchCode { get; set; }

		[DataMember(Name = "branch_desc")]
		public string BranchDesc { get; set; }

		[DataMember(Name = "branch_short_desc")]
		public string BranchShortDesc { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "town_id")]
		public int TownId { get; set; }

		[DataMember(Name = "city_id")]
		public int CityId { get; set; }

		[DataMember(Name = "country_id")]
		public int CountryId { get; set; }

		[DataMember(Name = "address1")]
		public string Address1 { get; set; }

		[DataMember(Name = "address2")]
		public string Address2 { get; set; }

		[DataMember(Name = "address3")]
		public string Address3 { get; set; }

		[DataMember(Name = "taxno")]
		public string Taxno { get; set; }

		[DataMember(Name = "tax_office_id")]
		public int TaxOfficeId { get; set; }

		[DataMember(Name = "email")]
		public string Email { get; set; }

		[DataMember(Name = "fax")]
		public string Fax { get; set; }

		[DataMember(Name = "tel")]
		public string Tel { get; set; }

		[DataMember(Name = "create_user_id")]
		public int CreateUserId { get; set; }

		[DataMember(Name = "create_date")]
		public DateTime CreateDate { get; set; }

		[DataMember(Name = "update_user_id")]
		public int UpdateUserId { get; set; }

		[DataMember(Name = "update_date")]
		public DateTime UpdateDate { get; set; }

	}
}
