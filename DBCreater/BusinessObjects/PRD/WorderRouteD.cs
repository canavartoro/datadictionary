using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("93c09b2e-2bbe-45b0-a6d1-2d4654058105")]
	public class WorderRouteD : UyumObjectBase
	{

		public WorderRouteD()
		{
		}

		private int _ProductRouteDId = 0;//integer
		private int _WorderMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _WcenterId = 0;//integer
		private int _WstationId = 0;//integer
		private int _OperationId = 0;//integer
		private int _QtyPrm = 0;//integer
		private DateTime _StartDate = DateTime.Now;//datetime
		private DateTime _EndDate = DateTime.Now;//datetime
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("worder_route_d_id", IsIdentity = true)]
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
		[DataInt32("operation_id")]
		public int OperationId
		{
			get { return _OperationId; }
			set { _OperationId = value; }
		}

		[Server]
		[DataInt32("qty_prm")]
		public int QtyPrm
		{
			get { return _QtyPrm; }
			set { _QtyPrm = value; }
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
	[DataContract(Name = "WorderRouteD")]
	public class WorderRouteDInfo
	{

		public WorderRouteDInfo()
		{
		}

		[DataMember(Name = "worder_route_d_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "wcenter_id")]
		public int WcenterId { get; set; }

		[DataMember(Name = "wstation_id")]
		public int WstationId { get; set; }

		[DataMember(Name = "operation_id")]
		public int OperationId { get; set; }

		[DataMember(Name = "qty_prm")]
		public int QtyPrm { get; set; }

		[DataMember(Name = "start_date")]
		public DateTime StartDate { get; set; }

		[DataMember(Name = "end_date")]
		public DateTime EndDate { get; set; }

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
