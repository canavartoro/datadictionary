using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("65ddaa67-8908-4242-bf03-4d573905073f")]
	public class LeaveType : UyumObjectBase
	{

		public LeaveType()
		{
		}

		private int _LeaveTypeId = 0;//integer
		private string _LeaveTypeCode = string.Empty;//varchar(25)
		private string _LeaveTypeDesc = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("leave_type_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("leave_type_code", Length = 25)]
		public string LeaveTypeCode
		{
			get { return _LeaveTypeCode; }
			set { _LeaveTypeCode = value; }
		}

		[Server]
		[DataString("leave_type_desc", Length = 50)]
		public string LeaveTypeDesc
		{
			get { return _LeaveTypeDesc; }
			set { _LeaveTypeDesc = value; }
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
	[DataContract(Name = "LeaveType")]
	public class LeaveTypeInfo
	{

		public LeaveTypeInfo()
		{
		}

		[DataMember(Name = "leave_type_id")]
		public int Id { get; set; }

		[DataMember(Name = "leave_type_code")]
		public string LeaveTypeCode { get; set; }

		[DataMember(Name = "leave_type_desc")]
		public string LeaveTypeDesc { get; set; }

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
