using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("4479269f-0587-41f3-b1be-27d90f1823f3")]
	public class Calendar : UyumObjectBase
	{

		public Calendar()
		{
		}

		private int _CalendarId = 0;//integer
		private int _CalendarTypeId = 0;//integer
		private DateTime _Date = DateTime.Now;//date
		private DateTime _StartTime = DateTime.Now;//time
		private DateTime _EndTime = DateTime.Now;//time
		private int _WorkingMinute = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("calendar_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("calendar_type_id")]
		public int CalendarTypeId
		{
			get { return _CalendarTypeId; }
			set { _CalendarTypeId = value; }
		}

		[Server]
		[DataTime("date")]
		public DateTime Date
		{
			get { return _Date; }
			set { _Date = value; }
		}

		[Server]
		[DataTime("start_time")]
		public DateTime StartTime
		{
			get { return _StartTime; }
			set { _StartTime = value; }
		}

		[Server]
		[DataTime("end_time")]
		public DateTime EndTime
		{
			get { return _EndTime; }
			set { _EndTime = value; }
		}

		[Server]
		[DataInt32("working_minute")]
		public int WorkingMinute
		{
			get { return _WorkingMinute; }
			set { _WorkingMinute = value; }
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
	[DataContract(Name = "Calendar")]
	public class CalendarInfo
	{

		public CalendarInfo()
		{
		}

		[DataMember(Name = "calendar_id")]
		public int Id { get; set; }

		[DataMember(Name = "calendar_type_id")]
		public int CalendarTypeId { get; set; }

		[DataMember(Name = "date")]
		public DateTime Date { get; set; }

		[DataMember(Name = "start_time")]
		public DateTime StartTime { get; set; }

		[DataMember(Name = "end_time")]
		public DateTime EndTime { get; set; }

		[DataMember(Name = "working_minute")]
		public int WorkingMinute { get; set; }

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
