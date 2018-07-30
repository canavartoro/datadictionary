using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("ee3e2549-fe06-403e-a13d-4a10c9a048d2")]
	public class BomM : UyumObjectBase
	{

		public BomM()
		{
		}

		private int _BomMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _ItemId = 0;//integer
		private bool _IsDefault = false;//bit
		private string _AlternatifNo = string.Empty;//varchar(30)
		private int _UnitId = 0;//integer
		private int _ErpBomMId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("bom_m_id", IsIdentity = true)]
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
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
		}

		[Server]
		[DataBoolean("is_default")]
		public bool IsDefault
		{
			get { return _IsDefault; }
			set { _IsDefault = value; }
		}

		[Server]
		[DataString("alternatif_no", Length = 30)]
		public string AlternatifNo
		{
			get { return _AlternatifNo; }
			set { _AlternatifNo = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		[Server]
		[DataInt32("erp_bom_m_id")]
		public int ErpBomMId
		{
			get { return _ErpBomMId; }
			set { _ErpBomMId = value; }
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
	[DataContract(Name = "BomM")]
	public class BomMInfo
	{

		public BomMInfo()
		{
		}

		[DataMember(Name = "bom_m_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "is_default")]
		public bool IsDefault { get; set; }

		[DataMember(Name = "alternatif_no")]
		public string AlternatifNo { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "erp_bom_m_id")]
		public int ErpBomMId { get; set; }

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
