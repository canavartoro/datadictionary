using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("9b0b9a9c-3222-47c1-9a0b-1a5d8b463d49")]
	public class BatchWorderRel : UyumObjectBase
	{

		public BatchWorderRel()
		{
		}

		private int _BatchWorderRelId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _WorderMId = 0;//integer
		private int _OperationId = 0;//integer
		private int _OperationNo = 0;//integer
		private decimal _QtyPrm = 0m;//decimal(18,5)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("batch_worder_rel_id", IsIdentity = true)]
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
		[DataInt32("worder_m_id")]
		public int WorderMId
		{
			get { return _WorderMId; }
			set { _WorderMId = value; }
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
		[DataDecimal("qty_prm", Precision = 18, Scale = 5)]
		public decimal QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
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
	[DataContract(Name = "BatchWorderRel")]
	public class BatchWorderRelInfo
	{

		public BatchWorderRelInfo()
		{
		}

		[DataMember(Name = "batch_worder_rel_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "worder_m_id")]
		public int WorderMId { get; set; }

		[DataMember(Name = "operation_id")]
		public int OperationId { get; set; }

		[DataMember(Name = "operation_no")]
		public int OperationNo { get; set; }

		[DataMember(Name = "qty_prm")]
		public decimal QtyPrm { get; set; }

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
