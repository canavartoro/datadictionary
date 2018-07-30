using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("47b00a70-90a8-4dfd-9605-518969867b78")]
	public class ProductRouteD : UyumObjectBase
	{

		public ProductRouteD()
		{
		}

		private int _ProductRouteDId = 0;//integer
		private int _ProductRouteMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _LineNo = 0;//integer
		private int _OperationId = 0;//integer
		private int _OperationNo = 0;//integer
		private int _WcenterId = 0;//integer
		private int _WstationId = 0;//integer
		private bool _IsOutside = false;//bit
		private bool _IsDemonte = false;//bit
		private decimal _Qty = 0m;//decimal(18,5)
		private int _Duration = 0;//integer
		private string _OpenClose = string.Empty;//nvarchar(10)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("product_route_d_id", IsIdentity = true)]
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
		[DataInt32("line_no")]
		public int LineNo
		{
			get { return _LineNo; }
			set { _LineNo = value; }
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
		[DataDecimal("qty", Precision = 18, Scale = 5)]
		public decimal Qty
		{
			get { return _Qty; }
			set { _Qty = value; }
		}

		[Server]
		[DataInt32("duration")]
		public int Duration
		{
			get { return _Duration; }
			set { _Duration = value; }
		}

		[Server]
		[DataString("open_close", Length = 10)]
		public string OpenClose
		{
			get { return _OpenClose; }
			set { _OpenClose = value; }
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
	[DataContract(Name = "ProductRouteD")]
	public class ProductRouteDInfo
	{

		public ProductRouteDInfo()
		{
		}

		[DataMember(Name = "product_route_d_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "line_no")]
		public int LineNo { get; set; }

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

		[DataMember(Name = "qty")]
		public decimal Qty { get; set; }

		[DataMember(Name = "duration")]
		public int Duration { get; set; }

		[DataMember(Name = "open_close")]
		public string OpenClose { get; set; }

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
