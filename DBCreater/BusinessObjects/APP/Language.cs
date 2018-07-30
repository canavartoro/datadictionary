using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("ab07d637-7b70-4cfa-8c3a-9770afc46372")]
	public class Language : UyumObjectBase
	{

		public Language()
		{
		}

		private int _LanguageId = 0;//integer
		private string _LanguageCode = string.Empty;//nvarchar(5)
		private string _LanguageName = string.Empty;//nvarchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("language_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("language_code", Length = 5)]
		public string LanguageCode
		{
			get { return _LanguageCode; }
			set { _LanguageCode = value; }
		}

		[Server]
		[DataString("language_name", Length = 50)]
		public string LanguageName
		{
			get { return _LanguageName; }
			set { _LanguageName = value; }
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
	[DataContract(Name = "Language")]
	public class LanguageInfo
	{

		public LanguageInfo()
		{
		}

		[DataMember(Name = "language_id")]
		public int Id { get; set; }

		[DataMember(Name = "language_code")]
		public string LanguageCode { get; set; }

		[DataMember(Name = "language_name")]
		public string LanguageName { get; set; }

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
