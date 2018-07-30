using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("045caea6-1c02-430f-9473-b25e91134597")]
	public class TaxOffice : UyumObjectBase
	{

		public TaxOffice()
		{
		}

		private int _TaxOfficeId = 0;//integer
		private string _TaxOfficeCode = string.Empty;//varchar(50)
		private string _TaxOfficeDesc = string.Empty;//varchar(100)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("tax_office_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("tax_office_desc", Length = 100)]
		public string TaxOfficeDesc
		{
			get { return _TaxOfficeDesc; }
			set { _TaxOfficeDesc = value; }
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
	[DataContract(Name = "TaxOffice")]
	public class TaxOfficeInfo
	{

		public TaxOfficeInfo()
		{
		}

		[DataMember(Name = "tax_office_id")]
		public int Id { get; set; }

		[DataMember(Name = "tax_office_desc")]
		public string TaxOfficeDesc { get; set; }

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
