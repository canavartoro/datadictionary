using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("8cd15d11-342e-4d5e-b5b3-0fd330cca0cd")]
	public class Town : UyumObjectBase
	{

		public Town()
		{
		}

		private int _TownId = 0;//integer
		private string _TownName = string.Empty;//varchar(50)
		private int _CityId = 0;//integer
		private int _CountryId = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("town_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataString("town_name", Length = 50)]
		public string TownName
		{
			get { return _TownName; }
			set { _TownName = value; }
		}

		[Server]
		[DataInt32("city_id")]
		public int CityId
		{
			get { return _CityId; }
			set { _CityId = value; }
		}

		[Server]
		[DataInt32("country_id")]
		public int CountryId
		{
			get { return _CountryId; }
			set { _CountryId = value; }
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
	[DataContract(Name = "Town")]
	public class TownInfo
	{

		public TownInfo()
		{
		}

		[DataMember(Name = "town_id")]
		public int Id { get; set; }

		[DataMember(Name = "town_name")]
		public string TownName { get; set; }

		[DataMember(Name = "city_id")]
		public int CityId { get; set; }

		[DataMember(Name = "country_id")]
		public int CountryId { get; set; }

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
