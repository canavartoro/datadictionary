using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("34ee2c75-03f8-4976-acff-6a72fdcff5de")]
	public class OrderM : UyumObjectBase
	{

		public OrderM()
		{
		}

		private int _OrderMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _EntityId = 0;//integer
		private int _SalesPersonId = 0;//integer
		private int _DocTraId = 0;//integer
		private DateTime _DocDate = DateTime.Now;//date
		private int _DocNo = 0;//integer
		private int _PurcahseSales = 0;//integer
		private DateTime _DueDate = DateTime.Now;//date
		private DateTime _DeliveryDate = DateTime.Now;//date
		private DateTime _ShippingDate = DateTime.Now;//date
		private string _Note1 = string.Empty;//varchar(50)
		private string _Note2 = string.Empty;//varchar(50)
		private int _ErpOrderMId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("order_m_id", IsIdentity = true)]
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
		[DataInt32("entity_id")]
		public int EntityId
		{
			get { return _EntityId; }
			set { _EntityId = value; }
		}

		[Server]
		[DataInt32("sales_person_id")]
		public int SalesPersonId
		{
			get { return _SalesPersonId; }
			set { _SalesPersonId = value; }
		}

		[Server]
		[DataInt32("doc_tra_id")]
		public int DocTraId
		{
			get { return _DocTraId; }
			set { _DocTraId = value; }
		}

		[Server]
		[DataTime("doc_date")]
		public DateTime DocDate
		{
			get { return _DocDate; }
			set { _DocDate = value; }
		}

		[Server]
		[DataInt32("doc_no")]
		public int DocNo
		{
			get { return _DocNo; }
			set { _DocNo = value; }
		}

		[Server]
		[DataInt32("purcahse_sales")]
		public int PurcahseSales
		{
			get { return _PurcahseSales; }
			set { _PurcahseSales = value; }
		}

		[Server]
		[DataTime("due_date")]
		public DateTime DueDate
		{
			get { return _DueDate; }
			set { _DueDate = value; }
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
		[DataString("note1", Length = 50)]
		public string Note1
		{
			get { return _Note1; }
			set { _Note1 = value; }
		}

		[Server]
		[DataString("note2", Length = 50)]
		public string Note2
		{
			get { return _Note2; }
			set { _Note2 = value; }
		}

		[Server]
		[DataInt32("erp_order_m_id")]
		public int ErpOrderMId
		{
			get { return _ErpOrderMId; }
			set { _ErpOrderMId = value; }
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
	[DataContract(Name = "OrderM")]
	public class OrderMInfo
	{

		public OrderMInfo()
		{
		}

		[DataMember(Name = "order_m_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "entity_id")]
		public int EntityId { get; set; }

		[DataMember(Name = "sales_person_id")]
		public int SalesPersonId { get; set; }

		[DataMember(Name = "doc_tra_id")]
		public int DocTraId { get; set; }

		[DataMember(Name = "doc_date")]
		public DateTime DocDate { get; set; }

		[DataMember(Name = "doc_no")]
		public int DocNo { get; set; }

		[DataMember(Name = "purcahse_sales")]
		public int PurcahseSales { get; set; }

		[DataMember(Name = "due_date")]
		public DateTime DueDate { get; set; }

		[DataMember(Name = "delivery_date")]
		public DateTime DeliveryDate { get; set; }

		[DataMember(Name = "shipping_date")]
		public DateTime ShippingDate { get; set; }

		[DataMember(Name = "note1")]
		public string Note1 { get; set; }

		[DataMember(Name = "note2")]
		public string Note2 { get; set; }

		[DataMember(Name = "erp_order_m_id")]
		public int ErpOrderMId { get; set; }

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
