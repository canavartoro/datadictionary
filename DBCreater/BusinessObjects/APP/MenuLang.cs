using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("dfc49d96-0a73-4918-84c4-6b2566dbb4d1")]
	public class MenuLang : UyumObjectBase
	{

		public MenuLang()
		{
		}

		private int _MenuLangId = 0;//integer
		private int _MenuId = 0;//integer
		private int _LangId = 0;//integer
		private string _MenuName = string.Empty;//nvarchar(100)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("menu_lang_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("menu_id")]
		public int MenuId
		{
			get { return _MenuId; }
			set { _MenuId = value; }
		}

		[Server]
		[DataInt32("lang_id")]
		public int LangId
		{
			get { return _LangId; }
			set { _LangId = value; }
		}

		[Server]
		[DataString("menu_name", Length = 100)]
		public string MenuName
		{
			get { return _MenuName; }
			set { _MenuName = value; }
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
	[DataContract(Name = "MenuLang")]
	public class MenuLangInfo
	{

		public MenuLangInfo()
		{
		}

		[DataMember(Name = "menu_lang_id")]
		public int Id { get; set; }

		[DataMember(Name = "menu_id")]
		public int MenuId { get; set; }

		[DataMember(Name = "lang_id")]
		public int LangId { get; set; }

		[DataMember(Name = "menu_name")]
		public string MenuName { get; set; }

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
