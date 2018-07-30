using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("1792676c-f061-4fb6-bcc8-b950cbd71aa6")]
	public class UnitType : UyumObjectBase
	{

		public UnitType()
		{
		}

		private int _UnitTypeId = 0;//integer
		private string _UnitTypeCode = string.Empty;//varchar(25)
		private string _UnitTypeDesc = string.Empty;//varchar(50)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("unit_type_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("unit_type_code", Length = 25)]
		public string UnitTypeCode
		{
			get { return _UnitTypeCode; }
			set { _UnitTypeCode = value; }
		}

		[Server]
		[DataString("unit_type_desc", Length = 50)]
		public string UnitTypeDesc
		{
			get { return _UnitTypeDesc; }
			set { _UnitTypeDesc = value; }
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
	[DataContract(Name = "UnitType")]
	public class UnitTypeInfo
	{

		public UnitTypeInfo()
		{
		}

		[DataMember(Name = "unit_type_id")]
		public int Id { get; set; }

		[DataMember(Name = "unit_type_code")]
		public string UnitTypeCode { get; set; }

		[DataMember(Name = "unit_type_desc")]
		public string UnitTypeDesc { get; set; }

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
