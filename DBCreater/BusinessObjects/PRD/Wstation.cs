using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("2bd44bb2-41c3-446b-8038-68149ed80976")]
	public class Wstation : UyumObjectBase
	{

		public Wstation()
		{
		}

		private int _WstationId = 0;//integer
		private int _CoId = 0;//integer
		private int _BranchId = 0;//integer
		private string _WstationCode = string.Empty;//varchar(25)
		private string _WstationDesc = string.Empty;//varchar(50)
		private bool _IsOutsideWstation = false;//bit
		private int _SupplierId = 0;//integer
		private int _WcenterId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("wstation_id", IsIdentity = true)]
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
		[DataString("wstation_code", Length = 25)]
		public string WstationCode
		{
			get { return _WstationCode; }
			set { _WstationCode = value; }
		}

		[Server]
		[DataString("wstation_desc", Length = 50)]
		public string WstationDesc
		{
			get { return _WstationDesc; }
			set { _WstationDesc = value; }
		}

		[Server]
		[DataBoolean("is_outside_wstation")]
		public bool IsOutsideWstation
		{
			get { return _IsOutsideWstation; }
			set { _IsOutsideWstation = value; }
		}

		[Server]
		[DataInt32("supplier_id")]
		public int SupplierId
		{
			get { return _SupplierId; }
			set { _SupplierId = value; }
		}

		[Server]
		[DataInt32("wcenter_id")]
		public int WcenterId
		{
			get { return _WcenterId; }
			set { _WcenterId = value; }
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
	[DataContract(Name = "Wstation")]
	public class WstationInfo
	{

		public WstationInfo()
		{
		}

		[DataMember(Name = "wstation_id")]
		public int Id { get; set; }

		[DataMember(Name = "co_id")]
		public int CoId { get; set; }

		[DataMember(Name = "branch_id")]
		public int BranchId { get; set; }

		[DataMember(Name = "wstation_code")]
		public string WstationCode { get; set; }

		[DataMember(Name = "wstation_desc")]
		public string WstationDesc { get; set; }

		[DataMember(Name = "is_outside_wstation")]
		public bool IsOutsideWstation { get; set; }

		[DataMember(Name = "supplier_id")]
		public int SupplierId { get; set; }

		[DataMember(Name = "wcenter_id")]
		public int WcenterId { get; set; }

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
