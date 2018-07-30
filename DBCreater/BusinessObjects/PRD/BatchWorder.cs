using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("4dd8027f-8d4b-4c6e-ae09-b29cebbd9d07")]
	public class BatchWorder : UyumObjectBase
	{

		public BatchWorder()
		{
		}

		private int _BatchWorderId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _BatchWorderNo = 0;//integer
		private int _ItemId = 0;//integer
		private int _OperationId = 0;//integer
		private int _OperationNo = 0;//integer
		private int _WcenterId = 0;//integer
		private int _WstationId = 0;//integer
		private bool _IsOutside = false;//bit
		private bool _IsDemonte = false;//bit
		private decimal _QtyPrm = 0m;//decimal(18,5)
		private decimal _QtyPrmMan = 0m;//decimal(18,5)
		private DateTime _StartDate = DateTime.Now;//date
		private DateTime _EndDate = DateTime.Now;//date
		private bool _IsClosed = false;//bit
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("batch_worder_id", IsIdentity = true)]
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
		[DataInt32("batch_worder_no")]
		public int BatchWorderNo
		{
			get { return _BatchWorderNo; }
			set { _BatchWorderNo = value; }
		}

		[Server]
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
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
		[DataInt32("wcenter_id")]
		public int WcenterId
		{
			get { return _WcenterId; }
			set { _WcenterId = value; }
		}

		[Server]
		[DataInt32("wstation_id")]
		public int WstationId
		{
			get { return _WstationId; }
			set { _WstationId = value; }
		}

		[Server]
		[DataBoolean("is_outside")]
		public bool IsOutside
		{
			get { return _IsOutside; }
			set { _IsOutside = value; }
		}

		[Server]
		[DataBoolean("is_demonte")]
		public bool IsDemonte
		{
			get { return _IsDemonte; }
			set { _IsDemonte = value; }
		}

		[Server]
		[DataDecimal("qty_prm", Precision = 18, Scale = 5)]
		public decimal QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
		}

		[Server]
		[DataDecimal("qty_prm_man", Precision = 18, Scale = 5)]
		public decimal QtyPrmMan
		{
			get { return _QtyPrmMan; }
			set { _QtyPrmMan = value; }
		}

		[Server]
		[DataTime("start_date")]
		public DateTime StartDate
		{
			get { return _StartDate; }
			set { _StartDate = value; }
		}

		[Server]
		[DataTime("end_date")]
		public DateTime EndDate
		{
			get { return _EndDate; }
			set { _EndDate = value; }
		}

		[Server]
		[DataBoolean("?s_closed")]
		public bool IsClosed
		{
			get { return _IsClosed; }
			set { _IsClosed = value; }
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
	[DataContract(Name = "BatchWorder")]
	public class BatchWorderInfo
	{

		public BatchWorderInfo()
		{
		}

		[DataMember(Name = "batch_worder_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "batch_worder_no")]
		public int BatchWorderNo { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "operation_id")]
		public int OperationId { get; set; }

		[DataMember(Name = "operation_no")]
		public int OperationNo { get; set; }

		[DataMember(Name = "wcenter_id")]
		public int WcenterId { get; set; }

		[DataMember(Name = "wstation_id")]
		public int WstationId { get; set; }

		[DataMember(Name = "is_outside")]
		public bool IsOutside { get; set; }

		[DataMember(Name = "is_demonte")]
		public bool IsDemonte { get; set; }

		[DataMember(Name = "qty_prm")]
		public decimal QtyPrm { get; set; }

		[DataMember(Name = "qty_prm_man")]
		public decimal QtyPrmMan { get; set; }

		[DataMember(Name = "start_date")]
		public DateTime StartDate { get; set; }

		[DataMember(Name = "end_date")]
		public DateTime EndDate { get; set; }

		[DataMember(Name = "?s_closed")]
		public bool IsClosed { get; set; }

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
