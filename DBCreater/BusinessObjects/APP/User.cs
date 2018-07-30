using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("d658ba7b-67db-4363-9b6e-82ab607d5502")]
	public class User : UyumObjectBase
	{

		public User()
		{
		}

		private int _UsId = 0;//integer
		private string _UsName = string.Empty;//varchar(25)
		private string _UsSurname = string.Empty;//varchar(25)
		private string _UsUsername = string.Empty;//varchar(25)
		private string _Email = string.Empty;//varchar(100)
		private string _UsPassword = string.Empty;//varchar(25)
		private string _Note1 = string.Empty;//varchar(100)
		private int _LangId = 0;//integer
		private string _CitizenshipNo = string.Empty;//varchar(50)
		private bool _UsEnabled = false;//bit
		private string _MobileTel = string.Empty;//varchar(20)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("user_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("us_name", Length = 25)]
		public string UsName
		{
			get { return _UsName; }
			set { _UsName = value; }
		}

		[Server]
		[DataString("us_surname", Length = 25)]
		public string UsSurname
		{
			get { return _UsSurname; }
			set { _UsSurname = value; }
		}

		[Server]
		[DataString("us_username", Length = 25)]
		public string UsUsername
		{
			get { return _UsUsername; }
			set { _UsUsername = value; }
		}

		[Server]
		[DataString("email", Length = 100)]
		public string Email
		{
			get { return _Email; }
			set { _Email = value; }
		}

		[Server]
		[DataString("us_password", Length = 25)]
		public string UsPassword
		{
			get { return _UsPassword; }
			set { _UsPassword = value; }
		}

		[Server]
		[DataString("note1", Length = 100)]
		public string Note1
		{
			get { return _Note1; }
			set { _Note1 = value; }
		}

		[Server]
		[DataInt32("lang_id")]
		public int LangId
		{
			get { return _LangId; }
			set { _LangId = value; }
		}

		[Server]
		[DataString("citizenship_no", Length = 50)]
		public string CitizenshipNo
		{
			get { return _CitizenshipNo; }
			set { _CitizenshipNo = value; }
		}

		[Server]
		[DataBoolean("us_enabled")]
		public bool UsEnabled
		{
			get { return _UsEnabled; }
			set { _UsEnabled = value; }
		}

		[Server]
		[DataString("mobile_tel", Length = 20)]
		public string MobileTel
		{
			get { return _MobileTel; }
			set { _MobileTel = value; }
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
	[DataContract(Name = "User")]
	public class UserInfo
	{

		public UserInfo()
		{
		}

		[DataMember(Name = "user_id")]
		public int Id { get; set; }

		[DataMember(Name = "us_name")]
		public string UsName { get; set; }

		[DataMember(Name = "us_surname")]
		public string UsSurname { get; set; }

		[DataMember(Name = "us_username")]
		public string UsUsername { get; set; }

		[DataMember(Name = "email")]
		public string Email { get; set; }

		[DataMember(Name = "us_password")]
		public string UsPassword { get; set; }

		[DataMember(Name = "note1")]
		public string Note1 { get; set; }

		[DataMember(Name = "lang_id")]
		public int LangId { get; set; }

		[DataMember(Name = "citizenship_no")]
		public string CitizenshipNo { get; set; }

		[DataMember(Name = "us_enabled")]
		public bool UsEnabled { get; set; }

		[DataMember(Name = "mobile_tel")]
		public string MobileTel { get; set; }

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
