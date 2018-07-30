using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("2ffe2ba4-7508-40c6-9b5d-62430e6e04ea")]
	public class ItemUnit : UyumObjectBase
	{

		public ItemUnit()
		{
		}

		private int _ItemUnitId = 0;//integer
		private int _LineNo = 0;//integer
		private int _UnitId = 0;//integer
		private int _Unit2Id = 0;//integer
		private decimal _Rate = 0m;//decimal(18,5)
		private decimal _Rate2 = 0m;//decimal(18,5)
		private decimal _Volume = 0m;//decimal(18,5)
		private decimal _Weight = 0m;//decimal(18,5)
		private decimal _Height = 0m;//decimal(18,5)
		private decimal _Depth = 0m;//decimal(18,5)
		private decimal _Width = 0m;//decimal(18,5)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("item_unit_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("line_no")]
		public int LineNo
		{
			get { return _LineNo; }
			set { _LineNo = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		[Server]
		[DataInt32("unit2_id")]
		public int Unit2Id
		{
			get { return _Unit2Id; }
			set { _Unit2Id = value; }
		}

		[Server]
		[DataDecimal("rate", Precision = 18, Scale = 5)]
		public decimal Rate
		{
			get { return _Rate; }
			set { _Rate = value; }
		}

		[Server]
		[DataDecimal("rate2", Precision = 18, Scale = 5)]
		public decimal Rate2
		{
			get { return _Rate2; }
			set { _Rate2 = value; }
		}

		[Server]
		[DataDecimal("volume", Precision = 18, Scale = 5)]
		public decimal Volume
		{
			get { return _Volume; }
			set { _Volume = value; }
		}

		[Server]
		[DataDecimal("weight", Precision = 18, Scale = 5)]
		public decimal Weight
		{
			get { return _Weight; }
			set { _Weight = value; }
		}

		[Server]
		[DataDecimal("height", Precision = 18, Scale = 5)]
		public decimal Height
		{
			get { return _Height; }
			set { _Height = value; }
		}

		[Server]
		[DataDecimal("depth", Precision = 18, Scale = 5)]
		public decimal Depth
		{
			get { return _Depth; }
			set { _Depth = value; }
		}

		[Server]
		[DataDecimal("width", Precision = 18, Scale = 5)]
		public decimal Width
		{
			get { return _Width; }
			set { _Width = value; }
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
	[DataContract(Name = "ItemUnit")]
	public class ItemUnitInfo
	{

		public ItemUnitInfo()
		{
		}

		[DataMember(Name = "item_unit_id")]
		public int Id { get; set; }

		[DataMember(Name = "line_no")]
		public int LineNo { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "unit2_id")]
		public int Unit2Id { get; set; }

		[DataMember(Name = "rate")]
		public decimal Rate { get; set; }

		[DataMember(Name = "rate2")]
		public decimal Rate2 { get; set; }

		[DataMember(Name = "volume")]
		public decimal Volume { get; set; }

		[DataMember(Name = "weight")]
		public decimal Weight { get; set; }

		[DataMember(Name = "height")]
		public decimal Height { get; set; }

		[DataMember(Name = "depth")]
		public decimal Depth { get; set; }

		[DataMember(Name = "width")]
		public decimal Width { get; set; }

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
