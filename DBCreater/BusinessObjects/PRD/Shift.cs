using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("53143885-441d-4a37-8cfa-d378950dd316")]
	public class Shift : UyumObjectBase
	{

		public Shift()
		{
		}

		private int _ShiftId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _ShiftCode = string.Empty;//varchar(25)
		private string _ShiftDesc = string.Empty;//varchar(50)
		private DateTime _Starttime = DateTime.Now;//time
		private DateTime _Endtime = DateTime.Now;//time
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("shift_id", IsIdentity = true)]
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
		[DataString("shift_code", Length = 25)]
		public string ShiftCode
		{
			get { return _ShiftCode; }
			set { _ShiftCode = value; }
		}

		[Server]
		[DataString("shift_desc", Length = 50)]
		public string ShiftDesc
		{
			get { return _ShiftDesc; }
			set { _ShiftDesc = value; }
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
	[DataContract(Name = "Shift")]
	public class ShiftInfo
	{

		public ShiftInfo()
		{
		}

		[DataMember(Name = "shift_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "shift_code")]
		public string ShiftCode { get; set; }

		[DataMember(Name = "shift_desc")]
		public string ShiftDesc { get; set; }

		[DataMember(Name = "starttime")]
		public DateTime Starttime { get; set; }

		[DataMember(Name = "endtime")]
		public DateTime Endtime { get; set; }

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
