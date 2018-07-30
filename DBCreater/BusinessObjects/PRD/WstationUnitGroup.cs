using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("44810327-d8b2-419c-b5f0-cb3a9c94c0df")]
	public class WstationUnitGroup : UyumObjectBase
	{

		public WstationUnitGroup()
		{
		}

		private int _WstationUnitGroupId = 0;//integer
		private int _BranchId = 0;//integer
		private int _CoId = 0;//integer
		private string _WstationUnitGroupCode = string.Empty;//varchar(25)
		private string _WstationUnitGroupName = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("wstation_unit_group_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("branch_id")]
		public int BranchId
		{
			get { return _BranchId; }
			set { _BranchId = value; }
		}

		[Server]
		[DataInt32("co_id")]
		public int CoId
		{
			get { return _CoId; }
			set { _CoId = value; }
		}

		[Server]
		[DataString("wstation_unit_group_code", Length = 25)]
		public string WstationUnitGroupCode
		{
			get { return _WstationUnitGroupCode; }
			set { _WstationUnitGroupCode = value; }
		}

		[Server]
		[DataString("wstation_unit_group_name", Length = 50)]
		public string WstationUnitGroupName
		{
			get { return _WstationUnitGroupName; }
			set { _WstationUnitGroupName = value; }
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
	[DataContract(Name = "WstationUnitGroup")]
	public class WstationUnitGroupInfo
	{

		public WstationUnitGroupInfo()
		{
		}

		[DataMember(Name = "wstation_unit_group_id")]
		public int Id { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "wstation_unit_group_code")]
		public string WstationUnitGroupCode { get; set; }

		[DataMember(Name = "wstation_unit_group_name")]
		public string WstationUnitGroupName { get; set; }

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
