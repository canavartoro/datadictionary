using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("78c0ae13-c93b-426f-8c9c-0984cf988854")]
	public class Wcenter : UyumObjectBase
	{

		public Wcenter()
		{
		}

		private int _WcenterId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _WcenterCode = string.Empty;//varchar(25)
		private string _WcenterDesc = string.Empty;//varchar(50)
		private bool _IsOutsideWcenter = false;//bit
		private int _WcenterGroupId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("wcenter_id", IsIdentity = true)]
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
		[DataString("wcenter_code", Length = 25)]
		public string WcenterCode
		{
			get { return _WcenterCode; }
			set { _WcenterCode = value; }
		}

		[Server]
		[DataString("wcenter_desc", Length = 50)]
		public string WcenterDesc
		{
			get { return _WcenterDesc; }
			set { _WcenterDesc = value; }
		}

		[Server]
		[DataBoolean("is_outside_wcenter")]
		public bool IsOutsideWcenter
		{
			get { return _IsOutsideWcenter; }
			set { _IsOutsideWcenter = value; }
		}

		[Server]
		[DataInt32("wcenter_group_id")]
		public int WcenterGroupId
		{
			get { return _WcenterGroupId; }
			set { _WcenterGroupId = value; }
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
	[DataContract(Name = "Wcenter")]
	public class WcenterInfo
	{

		public WcenterInfo()
		{
		}

		[DataMember(Name = "wcenter_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "wcenter_code")]
		public string WcenterCode { get; set; }

		[DataMember(Name = "wcenter_desc")]
		public string WcenterDesc { get; set; }

		[DataMember(Name = "is_outside_wcenter")]
		public bool IsOutsideWcenter { get; set; }

		[DataMember(Name = "wcenter_group_id")]
		public int WcenterGroupId { get; set; }

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
