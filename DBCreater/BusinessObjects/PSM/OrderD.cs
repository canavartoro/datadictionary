using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("96b3d6db-b447-431f-8442-5d270d094476")]
	public class OrderD : UyumObjectBase
	{

		public OrderD()
		{
		}

		private int _OrderMId = 0;//integer
		private int _OrderDId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _LineType = 0;//integer
		private int _DcardId = 0;//integer
		private int _ItemId = 0;//integer
		private int _UnitId = 0;//integer
		private decimal _Qty = 0m;//number(18,5)
		private decimal _QtyPrm = 0m;//number(18,5)
		private string _Note1 = string.Empty;//varchar(50)
		private decimal _ShippingQty = 0m;//number(18,5)
		private bool _OrderStatus = false;//bit
		private DateTime _DeliveryDate = DateTime.Now;//date
		private DateTime _ShippingDate = DateTime.Now;//date
		private int _WorderMId = 0;//integer
		private int _ErpOrderMId = 0;//integer
		private int _ErpOrderDId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("order_d_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("order_d_id")]
		public int OrderDId
		{
			get { return _OrderDId; }
			set { _OrderDId = value; }
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
		[DataInt32("line_type")]
		public int LineType
		{
			get { return _LineType; }
			set { _LineType = value; }
		}

		[Server]
		[DataInt32("dcard_id")]
		public int DcardId
		{
			get { return _DcardId; }
			set { _DcardId = value; }
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
		[DataDecimal("qty", Precision = 18, Scale = 5)]
		public decimal Qty
		{
			get { return _Qty; }
			set { _Qty = value; }
		}

		[Server]
		[DataDecimal("qty_prm", Precision = 18, Scale = 5)]
		public decimal QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
		}

		[Server]
		[DataString("note1", Length = 50)]
		public string Note1
		{
			get { return _Note1; }
			set { _Note1 = value; }
		}

		[Server]
		[DataDecimal("shipping_qty", Precision = 18, Scale = 5)]
		public decimal ShippingQty
		{
			get { return _ShippingQty; }
			set { _ShippingQty = value; }
		}

		[Server]
		[DataBoolean("order_status")]
		public bool OrderStatus
		{
			get { return _OrderStatus; }
			set { _OrderStatus = value; }
		}

		[Server]
		[DataTime("delivery_date")]
		public DateTime DeliveryDate
		{
			get { return _DeliveryDate; }
			set { _DeliveryDate = value; }
		}

		[Server]
		[DataTime("shipping_date")]
		public DateTime ShippingDate
		{
			get { return _ShippingDate; }
			set { _ShippingDate = value; }
		}

		[Server]
		[DataInt32("worder_m_id")]
		public int WorderMId
		{
			get { return _WorderMId; }
			set { _WorderMId = value; }
		}

		[Server]
		[DataInt32("erp_order_m_id")]
		public int ErpOrderMId
		{
			get { return _ErpOrderMId; }
			set { _ErpOrderMId = value; }
		}

		[Server]
		[DataInt32("erp_order_d_id")]
		public int ErpOrderDId
		{
			get { return _ErpOrderDId; }
			set { _ErpOrderDId = value; }
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
	[DataContract(Name = "OrderD")]
	public class OrderDInfo
	{

		public OrderDInfo()
		{
		}

		[DataMember(Name = "order_d_id")]
		public int Id { get; set; }

		[DataMember(Name = "order_d_id")]
		public int OrderDId { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "line_type")]
		public int LineType { get; set; }

		[DataMember(Name = "dcard_id")]
		public int DcardId { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "qty")]
		public decimal Qty { get; set; }

		[DataMember(Name = "qty_prm")]
		public decimal QtyPrm { get; set; }

		[DataMember(Name = "note1")]
		public string Note1 { get; set; }

		[DataMember(Name = "shipping_qty")]
		public decimal ShippingQty { get; set; }

		[DataMember(Name = "order_status")]
		public bool OrderStatus { get; set; }

		[DataMember(Name = "delivery_date")]
		public DateTime DeliveryDate { get; set; }

		[DataMember(Name = "shipping_date")]
		public DateTime ShippingDate { get; set; }

		[DataMember(Name = "worder_m_id")]
		public int WorderMId { get; set; }

		[DataMember(Name = "erp_order_m_id")]
		public int ErpOrderMId { get; set; }

		[DataMember(Name = "erp_order_d_id")]
		public int ErpOrderDId { get; set; }

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
