using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("0f024704-7b7b-4ee0-80d8-02618ce746cd")]
	public class GroupUser : UyumObjectBase
	{

		public GroupUser()
		{
		}

		private int _GroupUserId = 0;//integer
		private int _GroupId = 0;//integer
		private int _UsId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("group_user_id", IsIdentity = true)]
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
		[DataInt32("us_id")]
		public int UsId
		{
			get { return _UsId; }
			set { _UsId = value; }
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
	[DataContract(Name = "GroupUser")]
	public class GroupUserInfo
	{

		public GroupUserInfo()
		{
		}

		[DataMember(Name = "group_user_id")]
		public int Id { get; set; }

		[DataMember(Name = "group_id")]
		public int GroupId { get; set; }

		[DataMember(Name = "us_id")]
		public int UsId { get; set; }

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
