using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("fd928bfa-f812-4968-bc9c-2e2ebb905b85")]
	public class WorderOrderRel : UyumObjectBase
	{

		public WorderOrderRel()
		{
		}

		private int _WorderOrderRelId = 0;//integer
		private int _WorderMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _OrderMId = 0;//integer
		private int _OrderDId = 0;//integer
		private int _QtyPrm = 0;//integer
		private int _Qty = 0;//integer
		private int _UnitId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("worder_order_rel_id", IsIdentity = true)]
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
		[DataInt32("order_m_id")]
		public int OrderMId
		{
			get { return _OrderMId; }
			set { _OrderMId = value; }
		}

		[Server]
		[DataInt32("order_d_id")]
		public int OrderDId
		{
			get { return _OrderDId; }
			set { _OrderDId = value; }
		}

		[Server]
		[DataInt32("qty_prm")]
		public int QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
		}

		[Server]
		[DataInt32("qty")]
		public int Qty
		{
			get { return _Qty; }
			set { _Qty = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
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
	[DataContract(Name = "WorderOrderRel")]
	public class WorderOrderRelInfo
	{

		public WorderOrderRelInfo()
		{
		}

		[DataMember(Name = "worder_order_rel_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "order_m_id")]
		public int OrderMId { get; set; }

		[DataMember(Name = "order_d_id")]
		public int OrderDId { get; set; }

		[DataMember(Name = "qty_prm")]
		public int QtyPrm { get; set; }

		[DataMember(Name = "qty")]
		public int Qty { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

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
