using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("44c24ddc-a2f9-43e0-bca2-5af3e518cc85")]
	public class ProductRouteM : UyumObjectBase
	{

		public ProductRouteM()
		{
		}

		private int _ProductRouteMId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _BomMId = 0;//integer
		private int _ItemId = 0;//integer
		private string _Description = string.Empty;//varchar(100)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("product_route_m_id", IsIdentity = true)]
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
		[DataInt32("bom_m_id")]
		public int BomMId
		{
			get { return _BomMId; }
			set { _BomMId = value; }
		}

		[Server]
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
		}

		[Server]
		[DataString("description", Length = 100)]
		public string Description
		{
			get { return _Description; }
			set { _Description = value; }
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
	[DataContract(Name = "ProductRouteM")]
	public class ProductRouteMInfo
	{

		public ProductRouteMInfo()
		{
		}

		[DataMember(Name = "product_route_m_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "bom_m_id")]
		public int BomMId { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "description")]
		public string Description { get; set; }

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
