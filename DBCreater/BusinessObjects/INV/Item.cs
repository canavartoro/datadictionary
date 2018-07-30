using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("77dfe6fa-7db1-4923-9ca3-d45a5ff1e9b6")]
	public class Item : UyumObjectBase
	{

		public Item()
		{
		}

		private int _ItemId = 0;//integer
		private string _ItemCode = string.Empty;//varchar(25)
		private string _ItemName = string.Empty;//varchar(50)
		private string _ItemName2 = string.Empty;//varchar(50)
		private int _UnitId = 0;//integer
		private decimal _PercentageOfApproval = 0m;//number(18,5)
		private decimal _PercentageOfDeliveriy = 0m;//number(18,5)
		private DateTime _AddDate01 = DateTime.Now;//date
		private DateTime _AddDate02 = DateTime.Now;//date
		private DateTime _AddDate03 = DateTime.Now;//date
		private DateTime _AddDate04 = DateTime.Now;//date
		private DateTime _AddDate05 = DateTime.Now;//date
		private DateTime _AddDate06 = DateTime.Now;//date
		private DateTime _AddDate08 = DateTime.Now;//date
		private DateTime _AddDate09 = DateTime.Now;//date
		private DateTime _AddDate10 = DateTime.Now;//date
		private string _AddString01 = string.Empty;//varchar(50)
		private string _AddString02 = string.Empty;//varchar(50)
		private string _AddString03 = string.Empty;//varchar(50)
		private string _AddString04 = string.Empty;//varchar(50)
		private string _AddString05 = string.Empty;//varchar(50)
		private string _AddString06 = string.Empty;//varchar(50)
		private string _AddString07 = string.Empty;//varchar(50)
		private string _AddString08 = string.Empty;//varchar(50)
		private string _AddString09 = string.Empty;//varchar(50)
		private string _AddString10 = string.Empty;//varchar(50)
		private decimal _AddDec01 = 0m;//number(18,5)
		private decimal _AddDec02 = 0m;//number(18,5)
		private decimal _AddDec03 = 0m;//number(18,5)
		private decimal _AddDec04 = 0m;//number(18,5)
		private decimal _AddDec05 = 0m;//number(18,5)
		private decimal _AddDec06 = 0m;//number(18,5)
		private decimal _AddDec07 = 0m;//number(18,5)
		private decimal _AddDec08 = 0m;//number(18,5)
		private decimal _AddDec09 = 0m;//number(18,5)
		private decimal _AddDec10 = 0m;//number(18,5)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("item_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("item_code", Length = 25)]
		public string ItemCode
		{
			get { return _ItemCode; }
			set { _ItemCode = value; }
		}

		[Server]
		[DataString("item_name", Length = 50)]
		public string ItemName
		{
			get { return _ItemName; }
			set { _ItemName = value; }
		}

		[Server]
		[DataString("item_name2", Length = 50)]
		public string ItemName2
		{
			get { return _ItemName2; }
			set { _ItemName2 = value; }
		}

		[Server]
		[DataInt32("unit_id")]
		public int UnitId
		{
			get { return _UnitId; }
			set { _UnitId = value; }
		}

		[Server]
		[DataDecimal("percentage_of_approval", Precision = 18, Scale = 5)]
		public decimal PercentageOfApproval
		{
			get { return _PercentageOfApproval; }
			set { _PercentageOfApproval = value; }
		}

		[Server]
		[DataDecimal("percentage_of_deliveriy", Precision = 18, Scale = 5)]
		public decimal PercentageOfDeliveriy
		{
			get { return _PercentageOfDeliveriy; }
			set { _PercentageOfDeliveriy = value; }
		}

		[Server]
		[DataTime("add_date01")]
		public DateTime AddDate01
		{
			get { return _AddDate01; }
			set { _AddDate01 = value; }
		}

		[Server]
		[DataTime("add_date02")]
		public DateTime AddDate02
		{
			get { return _AddDate02; }
			set { _AddDate02 = value; }
		}

		[Server]
		[DataTime("add_date03")]
		public DateTime AddDate03
		{
			get { return _AddDate03; }
			set { _AddDate03 = value; }
		}

		[Server]
		[DataTime("add_date04")]
		public DateTime AddDate04
		{
			get { return _AddDate04; }
			set { _AddDate04 = value; }
		}

		[Server]
		[DataTime("add_date05")]
		public DateTime AddDate05
		{
			get { return _AddDate05; }
			set { _AddDate05 = value; }
		}

		[Server]
		[DataTime("add_date06")]
		public DateTime AddDate06
		{
			get { return _AddDate06; }
			set { _AddDate06 = value; }
		}

		[Server]
		[DataTime("add_date08")]
		public DateTime AddDate08
		{
			get { return _AddDate08; }
			set { _AddDate08 = value; }
		}

		[Server]
		[DataTime("add_date09")]
		public DateTime AddDate09
		{
			get { return _AddDate09; }
			set { _AddDate09 = value; }
		}

		[Server]
		[DataTime("add_date10")]
		public DateTime AddDate10
		{
			get { return _AddDate10; }
			set { _AddDate10 = value; }
		}

		[Server]
		[DataString("add_string01", Length = 50)]
		public string AddString01
		{
			get { return _AddString01; }
			set { _AddString01 = value; }
		}

		[Server]
		[DataString("add_string02", Length = 50)]
		public string AddString02
		{
			get { return _AddString02; }
			set { _AddString02 = value; }
		}

		[Server]
		[DataString("add_string03", Length = 50)]
		public string AddString03
		{
			get { return _AddString03; }
			set { _AddString03 = value; }
		}

		[Server]
		[DataString("add_string04", Length = 50)]
		public string AddString04
		{
			get { return _AddString04; }
			set { _AddString04 = value; }
		}

		[Server]
		[DataString("add_string05", Length = 50)]
		public string AddString05
		{
			get { return _AddString05; }
			set { _AddString05 = value; }
		}

		[Server]
		[DataString("add_string06", Length = 50)]
		public string AddString06
		{
			get { return _AddString06; }
			set { _AddString06 = value; }
		}

		[Server]
		[DataString("add_string07", Length = 50)]
		public string AddString07
		{
			get { return _AddString07; }
			set { _AddString07 = value; }
		}

		[Server]
		[DataString("add_string08", Length = 50)]
		public string AddString08
		{
			get { return _AddString08; }
			set { _AddString08 = value; }
		}

		[Server]
		[DataString("add_string09", Length = 50)]
		public string AddString09
		{
			get { return _AddString09; }
			set { _AddString09 = value; }
		}

		[Server]
		[DataString("add_string10", Length = 50)]
		public string AddString10
		{
			get { return _AddString10; }
			set { _AddString10 = value; }
		}

		[Server]
		[DataDecimal("add_dec01", Precision = 18, Scale = 5)]
		public decimal AddDec01
		{
			get { return _AddDec01; }
			set { _AddDec01 = value; }
		}

		[Server]
		[DataDecimal("add_dec02", Precision = 18, Scale = 5)]
		public decimal AddDec02
		{
			get { return _AddDec02; }
			set { _AddDec02 = value; }
		}

		[Server]
		[DataDecimal("add_dec03", Precision = 18, Scale = 5)]
		public decimal AddDec03
		{
			get { return _AddDec03; }
			set { _AddDec03 = value; }
		}

		[Server]
		[DataDecimal("add_dec04", Precision = 18, Scale = 5)]
		public decimal AddDec04
		{
			get { return _AddDec04; }
			set { _AddDec04 = value; }
		}

		[Server]
		[DataDecimal("add_dec05", Precision = 18, Scale = 5)]
		public decimal AddDec05
		{
			get { return _AddDec05; }
			set { _AddDec05 = value; }
		}

		[Server]
		[DataDecimal("add_dec06", Precision = 18, Scale = 5)]
		public decimal AddDec06
		{
			get { return _AddDec06; }
			set { _AddDec06 = value; }
		}

		[Server]
		[DataDecimal("add_dec07", Precision = 18, Scale = 5)]
		public decimal AddDec07
		{
			get { return _AddDec07; }
			set { _AddDec07 = value; }
		}

		[Server]
		[DataDecimal("add_dec08", Precision = 18, Scale = 5)]
		public decimal AddDec08
		{
			get { return _AddDec08; }
			set { _AddDec08 = value; }
		}

		[Server]
		[DataDecimal("add_dec09", Precision = 18, Scale = 5)]
		public decimal AddDec09
		{
			get { return _AddDec09; }
			set { _AddDec09 = value; }
		}

		[Server]
		[DataDecimal("add_dec10", Precision = 18, Scale = 5)]
		public decimal AddDec10
		{
			get { return _AddDec10; }
			set { _AddDec10 = value; }
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
	[DataContract(Name = "Item")]
	public class ItemInfo
	{

		public ItemInfo()
		{
		}

		[DataMember(Name = "item_id")]
		public int Id { get; set; }

		[DataMember(Name = "item_code")]
		public string ItemCode { get; set; }

		[DataMember(Name = "item_name")]
		public string ItemName { get; set; }

		[DataMember(Name = "item_name2")]
		public string ItemName2 { get; set; }

		[DataMember(Name = "unit_id")]
		public int UnitId { get; set; }

		[DataMember(Name = "percentage_of_approval")]
		public decimal PercentageOfApproval { get; set; }

		[DataMember(Name = "percentage_of_deliveriy")]
		public decimal PercentageOfDeliveriy { get; set; }

		[DataMember(Name = "add_date01")]
		public DateTime AddDate01 { get; set; }

		[DataMember(Name = "add_date02")]
		public DateTime AddDate02 { get; set; }

		[DataMember(Name = "add_date03")]
		public DateTime AddDate03 { get; set; }

		[DataMember(Name = "add_date04")]
		public DateTime AddDate04 { get; set; }

		[DataMember(Name = "add_date05")]
		public DateTime AddDate05 { get; set; }

		[DataMember(Name = "add_date06")]
		public DateTime AddDate06 { get; set; }

		[DataMember(Name = "add_date08")]
		public DateTime AddDate08 { get; set; }

		[DataMember(Name = "add_date09")]
		public DateTime AddDate09 { get; set; }

		[DataMember(Name = "add_date10")]
		public DateTime AddDate10 { get; set; }

		[DataMember(Name = "add_string01")]
		public string AddString01 { get; set; }

		[DataMember(Name = "add_string02")]
		public string AddString02 { get; set; }

		[DataMember(Name = "add_string03")]
		public string AddString03 { get; set; }

		[DataMember(Name = "add_string04")]
		public string AddString04 { get; set; }

		[DataMember(Name = "add_string05")]
		public string AddString05 { get; set; }

		[DataMember(Name = "add_string06")]
		public string AddString06 { get; set; }

		[DataMember(Name = "add_string07")]
		public string AddString07 { get; set; }

		[DataMember(Name = "add_string08")]
		public string AddString08 { get; set; }

		[DataMember(Name = "add_string09")]
		public string AddString09 { get; set; }

		[DataMember(Name = "add_string10")]
		public string AddString10 { get; set; }

		[DataMember(Name = "add_dec01")]
		public decimal AddDec01 { get; set; }

		[DataMember(Name = "add_dec02")]
		public decimal AddDec02 { get; set; }

		[DataMember(Name = "add_dec03")]
		public decimal AddDec03 { get; set; }

		[DataMember(Name = "add_dec04")]
		public decimal AddDec04 { get; set; }

		[DataMember(Name = "add_dec05")]
		public decimal AddDec05 { get; set; }

		[DataMember(Name = "add_dec06")]
		public decimal AddDec06 { get; set; }

		[DataMember(Name = "add_dec07")]
		public decimal AddDec07 { get; set; }

		[DataMember(Name = "add_dec08")]
		public decimal AddDec08 { get; set; }

		[DataMember(Name = "add_dec09")]
		public decimal AddDec09 { get; set; }

		[DataMember(Name = "add_dec10")]
		public decimal AddDec10 { get; set; }

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
