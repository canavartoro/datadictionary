using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("731c23d7-e97f-4bc2-a0f9-ac65455a79a0")]
	public class Activity : UyumObjectBase
	{

		public Activity()
		{
		}

		private int _ActivityId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _OperationId = 0;//integer
		private string _ActivityCode = string.Empty;//varchar(25)
		private string _ActivityDesc = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("activity_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("co_id")]
		public int CoId
		{
			get { return _CoId; }
			set { _CoId = value; }
		}

		[Server]
		[DataInt32("branch_id")]
		public int BranchId
		{
			get { return _BranchId; }
			set { _BranchId = value; }
		}

		[Server]
		[DataInt32("operation_id")]
		public int OperationId
		{
			get { return _OperationId; }
			set { _OperationId = value; }
		}

		[Server]
		[DataString("activity_code", Length = 25)]
		public string ActivityCode
		{
			get { return _ActivityCode; }
			set { _ActivityCode = value; }
		}

		[Server]
		[DataString("activity_desc", Length = 50)]
		public string ActivityDesc
		{
			get { return _ActivityDesc; }
			set { _ActivityDesc = value; }
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
	[DataContract(Name = "Activity")]
	public class ActivityInfo
	{

		public ActivityInfo()
		{
		}

		[DataMember(Name = "activity_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "operation_id")]
		public int OperationId { get; set; }

		[DataMember(Name = "activity_code")]
		public string ActivityCode { get; set; }

		[DataMember(Name = "activity_desc")]
		public string ActivityDesc { get; set; }

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
