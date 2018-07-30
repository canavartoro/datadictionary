using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("c497cc3f-68a8-44df-b65e-aecaff260230")]
	public class Permission : UyumObjectBase
	{

		public Permission()
		{
		}

		private int _PermissionId = 0;//integer
		private int _GroupId = 0;//integer
		private int _CmdId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("permission_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("group_id")]
		public int GroupId
		{
			get { return _GroupId; }
			set { _GroupId = value; }
		}

		[Server]
		[DataInt32("cmd_id")]
		public int CmdId
		{
			get { return _CmdId; }
			set { _CmdId = value; }
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
	[DataContract(Name = "Permission")]
	public class PermissionInfo
	{

		public PermissionInfo()
		{
		}

		[DataMember(Name = "permission_id")]
		public int Id { get; set; }

		[DataMember(Name = "group_id")]
		public int GroupId { get; set; }

		[DataMember(Name = "cmd_id")]
		public int CmdId { get; set; }

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
