using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("f08ab649-65a2-4207-9b33-0d23681a796b")]
	public class ScrapReason : UyumObjectBase
	{

		public ScrapReason()
		{
		}

		private int _ScrapReasonId = 0;//integer
		private string _ScrapReasonCode = string.Empty;//varchar(25)
		private string _ScrapReasonDesc = string.Empty;//varchar(50)
		private int _ScrapGroupId = 0;//integer
		private bool _IsMasterMaterial = false;//bit
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("scrap_reason_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("scrap_reason_desc", Length = 50)]
		public string ScrapReasonDesc
		{
			get { return _ScrapReasonDesc; }
			set { _ScrapReasonDesc = value; }
		}

		[Server]
		[DataInt32("scrap_group_id")]
		public int ScrapGroupId
		{
			get { return _ScrapGroupId; }
			set { _ScrapGroupId = value; }
		}

		[Server]
		[DataBoolean("is_master_material")]
		public bool IsMasterMaterial
		{
			get { return _IsMasterMaterial; }
			set { _IsMasterMaterial = value; }
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
	[DataContract(Name = "ScrapReason")]
	public class ScrapReasonInfo
	{

		public ScrapReasonInfo()
		{
		}

		[DataMember(Name = "scrap_reason_id")]
		public int Id { get; set; }

		[DataMember(Name = "scrap_reason_desc")]
		public string ScrapReasonDesc { get; set; }

		[DataMember(Name = "scrap_group_id")]
		public int ScrapGroupId { get; set; }

		[DataMember(Name = "is_master_material")]
		public bool IsMasterMaterial { get; set; }

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
