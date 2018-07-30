using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("c51e6245-9588-4de1-bc31-46607d46e5aa")]
	public class Command : UyumObjectBase
	{

		public Command()
		{
		}

		private int _CmdId = 0;//integer
		private string _CmdName = string.Empty;//nvarchar2(100)
		private int _MenuId = 0;//integer
		private string _CommandLabel = string.Empty;//nvarchar2(200)
		private bool _UnAuthorized = false;//boolean
		private string _CmdUrl = string.Empty;//nvarchar2(500)
		private string _ObjectType = string.Empty;//nvarchar2(500)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("command_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("cmd_name", Length = 100)]
		public string CmdName
		{
			get { return _CmdName; }
			set { _CmdName = value; }
		}

		[Server]
		[DataInt32("menu_id")]
		public int MenuId
		{
			get { return _MenuId; }
			set { _MenuId = value; }
		}

		[Server]
		[DataString("command_label", Length = 200)]
		public string CommandLabel
		{
			get { return _CommandLabel; }
			set { _CommandLabel = value; }
		}

		[Server]
		[DataBoolean("un_authorized")]
		public bool UnAuthorized
		{
			get { return _UnAuthorized; }
			set { _UnAuthorized = value; }
		}

		[Server]
		[DataString("cmd_url", Length = 500)]
		public string CmdUrl
		{
			get { return _CmdUrl; }
			set { _CmdUrl = value; }
		}

		[Server]
		[DataString("object_type", Length = 500)]
		public string ObjectType
		{
			get { return _ObjectType; }
			set { _ObjectType = value; }
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
	[DataContract(Name = "Command")]
	public class CommandInfo
	{

		public CommandInfo()
		{
		}

		[DataMember(Name = "command_id")]
		public int Id { get; set; }

		[DataMember(Name = "cmd_name")]
		public string CmdName { get; set; }

		[DataMember(Name = "menu_id")]
		public int MenuId { get; set; }

		[DataMember(Name = "command_label")]
		public string CommandLabel { get; set; }

		[DataMember(Name = "un_authorized")]
		public bool UnAuthorized { get; set; }

		[DataMember(Name = "cmd_url")]
		public string CmdUrl { get; set; }

		[DataMember(Name = "object_type")]
		public string ObjectType { get; set; }

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
