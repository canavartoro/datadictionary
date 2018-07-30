using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("0e081e68-e0e8-431c-b4d2-c655627403b2")]
	public class WorderBomD : UyumObjectBase
	{

		public WorderBomD()
		{
		}

		private int _WorderBomId = 0;//integer
		private int _WorderMId = 0;//integer
		private int _BomMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _LineNo = 0;//integer
		private int _LineType = 0;//integer
		private int _ItemId = 0;//integer
		private int _ItemBomMId = 0;//integer
		private int _UnitId = 0;//integer
		private decimal _Qty = 0m;//decimal(18,5)
		private int _OperationId = 0;//integer
		private int _OperationNo = 0;//integer
		private bool _IsByproduct = false;//bit
		private bool _IsMasterMaterial = false;//bit
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("worder_bom_d_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("worder_m_id")]
		public int WorderMId
		{
			get { return _WorderMId; }
			set { _WorderMId = value; }
		}

		[Server]
		[DataInt32("bom_m_id")]
		public int BomMId
		{
			get { return _BomMId; }
			set { _BomMId = value; }
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
		[DataInt32("line_no")]
		public int LineNo
		{
			get { return _LineNo; }
			set { _LineNo = value; }
		}

		[Server]
		[DataInt32("line_type")]
		public int LineType
		{
			get { return _LineType; }
			set { _LineType = value; }
		}

		[Server]
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
		}

		[Server]
		[DataInt32("item_bom_m_id")]
		public int ItemBomMId
		{
			get { return _ItemBomMId; }
			set { _ItemBomMId = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		[Server]
		[DataDecimal("qty", Precision = 18, Scale = 5)]
		public decimal Qty
		{
			get { return _Qty; }
			set { _Qty = value; }
		}

		[Server]
		[DataInt32("operation_id")]
		public int OperationId
		{
			get { return _OperationId; }
			set { _OperationId = value; }
		}

		[Server]
		[DataInt32("operation_no")]
		public int OperationNo
		{
			get { return _OperationNo; }
			set { _OperationNo = value; }
		}

		[Server]
		[DataBoolean("is_byproduct")]
		public bool IsByproduct
		{
			get { return _IsByproduct; }
			set { _IsByproduct = value; }
		}

		[Server]
		[DataBoolean("is_master_material")]
		public bool IsMasterMaterial
		{
			get { return _IsMasterMaterial; }
			set { _IsMasterMaterial = value; }
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
	[DataContract(Name = "WorderBomD")]
	public class WorderBomDInfo
	{

		public WorderBomDInfo()
		{
		}

		[DataMember(Name = "worder_bom_d_id")]
		public int Id { get; set; }

		[DataMember(Name = "worder_m_id")]
		public int WorderMId { get; set; }

		[DataMember(Name = "bom_m_id")]
		public int BomMId { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "line_no")]
		public int LineNo { get; set; }

		[DataMember(Name = "line_type")]
		public int LineType { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "item_bom_m_id")]
		public int ItemBomMId { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "qty")]
		public decimal Qty { get; set; }

		[DataMember(Name = "operation_id")]
		public int OperationId { get; set; }

		[DataMember(Name = "operation_no")]
		public int OperationNo { get; set; }

		[DataMember(Name = "is_byproduct")]
		public bool IsByproduct { get; set; }

		[DataMember(Name = "is_master_material")]
		public bool IsMasterMaterial { get; set; }

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
