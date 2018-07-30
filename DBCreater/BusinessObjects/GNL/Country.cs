using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("60c94e96-ac75-4c15-b63a-68b9ac6c3e00")]
	public class Country : UyumObjectBase
	{

		public Country()
		{
		}

		private int _CountryId = 0;//integer
		private string _CountryName = string.Empty;//varchar(50)
		private string _IsoCode = string.Empty;//varchar(50)
		private string _PhoneCode = string.Empty;//varchar(50)
		private string _Barcode = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("country_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("iso_code", Length = 50)]
		public string IsoCode
		{
			get { return _IsoCode; }
			set { _IsoCode = value; }
		}

		[Server]
		[DataString("phone_code", Length = 50)]
		public string PhoneCode
		{
			get { return _PhoneCode; }
			set { _PhoneCode = value; }
		}

		[Server]
		[DataString("barcode", Length = 50)]
		public string Barcode
		{
			get { return _Barcode; }
			set { _Barcode = value; }
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
	[DataContract(Name = "Country")]
	public class CountryInfo
	{

		public CountryInfo()
		{
		}

		[DataMember(Name = "country_id")]
		public int Id { get; set; }

		[DataMember(Name = "iso_code")]
		public string IsoCode { get; set; }

		[DataMember(Name = "phone_code")]
		public string PhoneCode { get; set; }

		[DataMember(Name = "barcode")]
		public string Barcode { get; set; }

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
