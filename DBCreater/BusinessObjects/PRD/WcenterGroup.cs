using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("e20ee12f-b805-462d-be83-18f654ea0797")]
	public class WcenterGroup : UyumObjectBase
	{

		public WcenterGroup()
		{
		}

		private int _WcenterGroupId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _WcenterGroupCode = string.Empty;//varchar(25)
		private string _WcenterGroupDesc = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("wcenter_group_id", IsIdentity = true)]
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
		[DataString("wcenter_group_code", Length = 25)]
		public string WcenterGroupCode
		{
			get { return _WcenterGroupCode; }
			set { _WcenterGroupCode = value; }
		}

		[Server]
		[DataString("wcenter_group_desc", Length = 50)]
		public string WcenterGroupDesc
		{
			get { return _WcenterGroupDesc; }
			set { _WcenterGroupDesc = value; }
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
	[DataContract(Name = "WcenterGroup")]
	public class WcenterGroupInfo
	{

		public WcenterGroupInfo()
		{
		}

		[DataMember(Name = "wcenter_group_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "wcenter_group_code")]
		public string WcenterGroupCode { get; set; }

		[DataMember(Name = "wcenter_group_desc")]
		public string WcenterGroupDesc { get; set; }

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
