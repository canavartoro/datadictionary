using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("c73cfe37-583f-4fc7-9623-0c1a91a22475")]
	public class Unit : UyumObjectBase
	{

		public Unit()
		{
		}

		private int _UnitId = 0;//integer
		private string _UnitCode = string.Empty;//varchar(25)
		private string _UnitDesc = string.Empty;//varchar(50)
		private int _Precision = 0;//integer
		private string _IsoUnitCode = string.Empty;//varchar(25)
		private int _UnitTypeId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("unit_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("unit_code", Length = 25)]
		public string UnitCode
		{
			get { return _UnitCode; }
			set { _UnitCode = value; }
		}

		[Server]
		[DataString("unit_desc", Length = 50)]
		public string UnitDesc
		{
			get { return _UnitDesc; }
			set { _UnitDesc = value; }
		}

		[Server]
		[DataInt32("Precision")]
		public int Precision
		{
			get { return _Precision; }
			set { _Precision = value; }
		}

		[Server]
		[DataString("iso_unit_code", Length = 25)]
		public string IsoUnitCode
		{
			get { return _IsoUnitCode; }
			set { _IsoUnitCode = value; }
		}

		[Server]
		[DataInt32("unit_type_id")]
		public int UnitTypeId
		{
			get { return _UnitTypeId; }
			set { _UnitTypeId = value; }
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
	[DataContract(Name = "Unit")]
	public class UnitInfo
	{

		public UnitInfo()
		{
		}

		[DataMember(Name = "unit_id")]
		public int Id { get; set; }

		[DataMember(Name = "unit_code")]
		public string UnitCode { get; set; }

		[DataMember(Name = "unit_desc")]
		public string UnitDesc { get; set; }

		[DataMember(Name = "Precision")]
		public int Precision { get; set; }

		[DataMember(Name = "iso_unit_code")]
		public string IsoUnitCode { get; set; }

		[DataMember(Name = "unit_type_id")]
		public int UnitTypeId { get; set; }

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
