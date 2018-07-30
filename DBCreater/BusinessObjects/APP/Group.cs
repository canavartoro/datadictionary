using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("0f5249f5-bb12-4d23-8cac-7eedaf79e66e")]
	public class Group : UyumObjectBase
	{

		public Group()
		{
		}

		private int _GroupId = 0;//integer
		private string _GroupName = string.Empty;//nvarchar(100)
		private string _GroupCode = string.Empty;//nvarchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("group_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("group_name", Length = 100)]
		public string GroupName
		{
			get { return _GroupName; }
			set { _GroupName = value; }
		}

		[Server]
		[DataString("group_code", Length = 50)]
		public string GroupCode
		{
			get { return _GroupCode; }
			set { _GroupCode = value; }
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
	[DataContract(Name = "Group")]
	public class GroupInfo
	{

		public GroupInfo()
		{
		}

		[DataMember(Name = "group_id")]
		public int Id { get; set; }

		[DataMember(Name = "group_name")]
		public string GroupName { get; set; }

		[DataMember(Name = "group_code")]
		public string GroupCode { get; set; }

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
