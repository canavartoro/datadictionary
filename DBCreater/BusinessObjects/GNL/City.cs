using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("5636465f-fded-445e-b5f8-2f0fa5f855b0")]
	public class City : UyumObjectBase
	{

		public City()
		{
		}

		private int _CityId = 0;//integer
		private string _CityName = string.Empty;//varchar(50)
		private int _CountryId = 0;//integer
		private string _LcencePlate = string.Empty;//varchar(25)
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("city_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("city_name", Length = 50)]
		public string CityName
		{
			get { return _CityName; }
			set { _CityName = value; }
		}

		[Server]
		[DataInt32("country_id")]
		public int CountryId
		{
			get { return _CountryId; }
			set { _CountryId = value; }
		}

		[Server]
		[DataString("lcence_plate", Length = 25)]
		public string LcencePlate
		{
			get { return _LcencePlate; }
			set { _LcencePlate = value; }
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
	[DataContract(Name = "City")]
	public class CityInfo
	{

		public CityInfo()
		{
		}

		[DataMember(Name = "city_id")]
		public int Id { get; set; }

		[DataMember(Name = "city_name")]
		public string CityName { get; set; }

		[DataMember(Name = "country_id")]
		public int CountryId { get; set; }

		[DataMember(Name = "lcence_plate")]
		public string LcencePlate { get; set; }

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
