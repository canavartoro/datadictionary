using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("a4ea7051-e9cb-4cec-9656-4bf4ea3d21c8")]
	public class Whouse : UyumObjectBase
	{

		public Whouse()
		{
		}

		private int _WhouseId = 0;//integer
		private string _WhouseCode = string.Empty;//varchar(25)
		private string _WhouseDesc = string.Empty;//varchar(50)
		private int _EntityId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("whouse_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("whouse_code", Length = 25)]
		public string WhouseCode
		{
			get { return _WhouseCode; }
			set { _WhouseCode = value; }
		}

		[Server]
		[DataString("whouse_desc", Length = 50)]
		public string WhouseDesc
		{
			get { return _WhouseDesc; }
			set { _WhouseDesc = value; }
		}

		[Server]
		[DataInt32("entity_id")]
		public int EntityId
		{
			get { return _EntityId; }
			set { _EntityId = value; }
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
	[DataContract(Name = "Whouse")]
	public class WhouseInfo
	{

		public WhouseInfo()
		{
		}

		[DataMember(Name = "whouse_id")]
		public int Id { get; set; }

		[DataMember(Name = "whouse_code")]
		public string WhouseCode { get; set; }

		[DataMember(Name = "whouse_desc")]
		public string WhouseDesc { get; set; }

		[DataMember(Name = "entity_id")]
		public int EntityId { get; set; }

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
