using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("5e932a69-037b-457a-8aed-3ceb47d8ff21")]
	public class BranchItem : UyumObjectBase
	{

		public BranchItem()
		{
		}

		private int _BranchItemId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private int _ItemId = 0;//integer
		private decimal _PercentageOfApproval = 0m;//number(18,2)
		private decimal _PercentageOfDeliveriy = 0m;//number(18,2)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("branch_item_id", IsIdentity = true)]
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
		[DataInt32("item_id")]
		public int ItemId
		{
			get { return _ItemId; }
			set { _ItemId = value; }
		}

		[Server]
		[DataDecimal("percentage_of_approval", Precision = 18, Scale = 2)]
		public decimal PercentageOfApproval
		{
			get { return _PercentageOfApproval; }
			set { _PercentageOfApproval = value; }
		}

		[Server]
		[DataDecimal("percentage_of_deliveriy", Precision = 18, Scale = 2)]
		public decimal PercentageOfDeliveriy
		{
			get { return _PercentageOfDeliveriy; }
			set { _PercentageOfDeliveriy = value; }
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
	[DataContract(Name = "BranchItem")]
	public class BranchItemInfo
	{

		public BranchItemInfo()
		{
		}

		[DataMember(Name = "branch_item_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "item_id")]
		public int ItemId { get; set; }

		[DataMember(Name = "percentage_of_approval")]
		public decimal PercentageOfApproval { get; set; }

		[DataMember(Name = "percentage_of_deliveriy")]
		public decimal PercentageOfDeliveriy { get; set; }

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
