using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("ba4dc59a-4714-4d90-b93e-93325d73bcf5")]
	public class Leave : UyumObjectBase
	{

		public Leave()
		{
		}

		private int _LeaveId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _LeaveTypeId = 0;//integer
		private DateTime _Startdate = DateTime.Now;//datetime
		private DateTime _Enddate = DateTime.Now;//datetime
		private int _EmployeeId = 0;//integer
		private int _IsWholeDay = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("leave_id", IsIdentity = true)]
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
		[DataInt32("leave_type_id")]
		public int LeaveTypeId
		{
			get { return _LeaveTypeId; }
			set { _LeaveTypeId = value; }
		}

		[Server]
		[DataTime("startdate")]
		public DateTime Startdate
		{
			get { return _Startdate; }
			set { _Startdate = value; }
		}

		[Server]
		[DataTime("enddate")]
		public DateTime Enddate
		{
			get { return _Enddate; }
			set { _Enddate = value; }
		}

		[Server]
		[DataInt32("employee_id")]
		public int EmployeeId
		{
			get { return _EmployeeId; }
			set { _EmployeeId = value; }
		}

		[Server]
		[DataInt32("is_whole_day")]
		public int IsWholeDay
		{
			get { return _IsWholeDay; }
			set { _IsWholeDay = value; }
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
	[DataContract(Name = "Leave")]
	public class LeaveInfo
	{

		public LeaveInfo()
		{
		}

		[DataMember(Name = "leave_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "leave_type_id")]
		public int LeaveTypeId { get; set; }

		[DataMember(Name = "startdate")]
		public DateTime Startdate { get; set; }

		[DataMember(Name = "enddate")]
		public DateTime Enddate { get; set; }

		[DataMember(Name = "employee_id")]
		public int EmployeeId { get; set; }

		[DataMember(Name = "is_whole_day")]
		public int IsWholeDay { get; set; }

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
