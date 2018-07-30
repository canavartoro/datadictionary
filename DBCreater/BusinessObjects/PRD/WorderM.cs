using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("c589e06a-77aa-4127-9e8f-db2d814e11dd")]
	public class WorderM : UyumObjectBase
	{

		public WorderM()
		{
		}

		private int _WorderMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _WorderNo = "";//
		private int _ItemId = 0;//integer
		private int _UnitId = 0;//integer
		private int _Qty = 0;//integer
		private decimal _QtyPrm = 0m;//number(15,5)
		private int _BomMId = 0;//integer
		private int _ProductRouteMId = 0;//integer
		private bool _IsClosed = false;//bit
		private int _ErpWorderMId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("worder_m_id", IsIdentity = true)]
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
		[DataString("worder_no")]
		public string WorderNo
		{
			get { return _WorderNo; }
			set { _WorderNo = value; }
		}

		[Server]
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		[Server]
		[DataInt32("qty")]
		public int Qty
		{
			get { return _Qty; }
			set { _Qty = value; }
		}

		[Server]
		[DataDecimal("qty_prm", Precision = 15, Scale = 5)]
		public decimal QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
		}

		[Server]
		[DataInt32("bom_m_id")]
		public int BomMId
		{
			get { return _BomMId; }
			set { _BomMId = value; }
		}

		[Server]
		[DataInt32("product_route_m_id")]
		public int ProductRouteMId
		{
			get { return _ProductRouteMId; }
			set { _ProductRouteMId = value; }
		}

		[Server]
		[DataBoolean("is_closed")]
		public bool IsClosed
		{
			get { return _IsClosed; }
			set { _IsClosed = value; }
		}

		[Server]
		[DataInt32("erp_worder_m_id")]
		public int ErpWorderMId
		{
			get { return _ErpWorderMId; }
			set { _ErpWorderMId = value; }
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
	[DataContract(Name = "WorderM")]
	public class WorderMInfo
	{

		public WorderMInfo()
		{
		}

		[DataMember(Name = "worder_m_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "worder_no")]
		public string WorderNo { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "qty")]
		public int Qty { get; set; }

		[DataMember(Name = "qty_prm")]
		public decimal QtyPrm { get; set; }

		[DataMember(Name = "bom_m_id")]
		public int BomMId { get; set; }

		[DataMember(Name = "product_route_m_id")]
		public int ProductRouteMId { get; set; }

		[DataMember(Name = "is_closed")]
		public bool IsClosed { get; set; }

		[DataMember(Name = "erp_worder_m_id")]
		public int ErpWorderMId { get; set; }

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
