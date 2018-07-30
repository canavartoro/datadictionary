using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("ff27a60f-4c1b-46f1-9774-216af40ca524")]
	public class BreakReason : UyumObjectBase
	{

		public BreakReason()
		{
		}

		private int _BreakReasonId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _BreakReasonCode = string.Empty;//varchar(25)
		private string _BreakReasonDesc = string.Empty;//varchar(50)
		private int _BreakReasonType = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("break_reason_id", IsIdentity = true)]
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
		[DataString("break_reason_code", Length = 25)]
		public string BreakReasonCode
		{
			get { return _BreakReasonCode; }
			set { _BreakReasonCode = value; }
		}

		[Server]
		[DataString("break_reason_desc", Length = 50)]
		public string BreakReasonDesc
		{
			get { return _BreakReasonDesc; }
			set { _BreakReasonDesc = value; }
		}

		[Server]
		[DataInt32("break_reason_type")]
		public int BreakReasonType
		{
			get { return _BreakReasonType; }
			set { _BreakReasonType = value; }
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
	[DataContract(Name = "BreakReason")]
	public class BreakReasonInfo
	{

		public BreakReasonInfo()
		{
		}

		[DataMember(Name = "break_reason_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "break_reason_code")]
		public string BreakReasonCode { get; set; }

		[DataMember(Name = "break_reason_desc")]
		public string BreakReasonDesc { get; set; }

		[DataMember(Name = "break_reason_type")]
		public int BreakReasonType { get; set; }

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
