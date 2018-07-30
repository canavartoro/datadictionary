using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("3edf59b5-6517-43eb-bed6-f582e1ed01ff")]
	public class WstationUnit : UyumObjectBase
	{

		public WstationUnit()
		{
		}

		private int _WstationUnitId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _WstationId = 0;//integer
		private string _Barcode = string.Empty;//varchar(25)
		private string _WstationUnitCode = string.Empty;//varchar(25)
		private string _WstationUnitDesc = string.Empty;//varchar(50)
		private int _NumberOfEmployee = 0;//integer
		private bool _IsFollowMasterMaterial = false;//bit
		private bool _IsFinishProduction = false;//bit
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("wstation_unit_id", IsIdentity = true)]
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
		[DataInt32("wstation_id")]
		public int WstationId
		{
			get { return _WstationId; }
			set { _WstationId = value; }
		}

		[Server]
		[DataString("Barcode", Length = 25)]
		public string Barcode
		{
			get { return _Barcode; }
			set { _Barcode = value; }
		}

		[Server]
		[DataString("wstation_unit_code", Length = 25)]
		public string WstationUnitCode
		{
			get { return _WstationUnitCode; }
			set { _WstationUnitCode = value; }
		}

		[Server]
		[DataString("wstation_unit_desc", Length = 50)]
		public string WstationUnitDesc
		{
			get { return _WstationUnitDesc; }
			set { _WstationUnitDesc = value; }
		}

		[Server]
		[DataInt32("number_of_employee")]
		public int NumberOfEmployee
		{
			get { return _NumberOfEmployee; }
			set { _NumberOfEmployee = value; }
		}

		[Server]
		[DataBoolean("is_follow_master_material ")]
		public bool IsFollowMasterMaterial
		{
			get { return _IsFollowMasterMaterial; }
			set { _IsFollowMasterMaterial = value; }
		}

		[Server]
		[DataBoolean("is_finish_production")]
		public bool IsFinishProduction
		{
			get { return _IsFinishProduction; }
			set { _IsFinishProduction = value; }
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
	[DataContract(Name = "WstationUnit")]
	public class WstationUnitInfo
	{

		public WstationUnitInfo()
		{
		}

		[DataMember(Name = "wstation_unit_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "wstation_id")]
		public int WstationId { get; set; }

		[DataMember(Name = "Barcode")]
		public string Barcode { get; set; }

		[DataMember(Name = "wstation_unit_code")]
		public string WstationUnitCode { get; set; }

		[DataMember(Name = "wstation_unit_desc")]
		public string WstationUnitDesc { get; set; }

		[DataMember(Name = "number_of_employee")]
		public int NumberOfEmployee { get; set; }

		[DataMember(Name = "is_follow_master_material ")]
		public bool IsFollowMasterMaterial { get; set; }

		[DataMember(Name = "is_finish_production")]
		public bool IsFinishProduction { get; set; }

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
