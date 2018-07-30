using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("52e5abfe-210f-472d-beca-0a45b09c356f")]
	public class EmpTimetable : UyumObjectBase
	{

		public EmpTimetable()
		{
		}

		private int _EmpTimetableId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _EmployeeId = 0;//integer
		private DateTime _Startdate = DateTime.Now;//date
		private DateTime _Enddate = DateTime.Now;//date
		private int _LocationType = 0;//integer
		private int _LocationId = 0;//integer
		private DateTime _Starttime = DateTime.Now;//time
		private DateTime _Endtime = DateTime.Now;//time 
		private int _IsWholeDay = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("emp_timetable_id", IsIdentity = true)]
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
		[DataInt32("employee_id")]
		public int EmployeeId
		{
			get { return _EmployeeId; }
			set { _EmployeeId = value; }
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
		[DataInt32("location_type")]
		public int LocationType
		{
			get { return _LocationType; }
			set { _LocationType = value; }
		}

		[Server]
		[DataInt32("location_id")]
		public int LocationId
		{
			get { return _LocationId; }
			set { _LocationId = value; }
		}

		[Server]
		[DataTime("starttime")]
		public DateTime Starttime
		{
			get { return _Starttime; }
			set { _Starttime = value; }
		}

		[Server]
		[DataTime("endtime")]
		public DateTime Endtime
		{
			get { return _Endtime; }
			set { _Endtime = value; }
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
	[DataContract(Name = "EmpTimetable")]
	public class EmpTimetableInfo
	{

		public EmpTimetableInfo()
		{
		}

		[DataMember(Name = "emp_timetable_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "employee_id")]
		public int EmployeeId { get; set; }

		[DataMember(Name = "startdate")]
		public DateTime Startdate { get; set; }

		[DataMember(Name = "enddate")]
		public DateTime Enddate { get; set; }

		[DataMember(Name = "location_type")]
		public int LocationType { get; set; }

		[DataMember(Name = "location_id")]
		public int LocationId { get; set; }

		[DataMember(Name = "starttime")]
		public DateTime Starttime { get; set; }

		[DataMember(Name = "endtime")]
		public DateTime Endtime { get; set; }

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
