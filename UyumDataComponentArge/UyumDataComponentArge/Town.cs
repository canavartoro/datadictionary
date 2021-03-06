using System;
using System.Runtime.InteropServices;
using Uyum.Net;
using Uyum.Objects;

namespace GNL
{
    [Guid("6d510caa-ce82-4c88-b00c-5400fb2d7e45")]
    public class Town : UyumObjectBase
    {
        private DateTime _CreateTime = DateTime.Now;
        private DateTime _UpdateTime = DateTime.Now;
        private int _CreateUserId = 0;
        private int _UpdateUserId = 0;
        private string _TownName = string.Empty;
        private int _CityId = 0;
        private string _CityName = string.Empty;
        private int _CountryId = 0;
        private string _CountryName = string.Empty;
        private int _CountryGrpId = 0;
        private string _CountryGrpDesc = string.Empty;
        private string _Longitude = string.Empty; //Boylam
        private string _Latitude = string.Empty;  // enlem
        private bool _Ispassive = false;

        public Town()
        {
            LicencePlate = "";
        }

        [DataInt32("TOWN_ID", IsIdentity = true)]
        [Server]
        [UyumPrimaryKey(0)]
        public override int Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        [DataTime("CREATE_TIME")]
        [Server]
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set { _CreateTime = value; }
        }

        [DataTime("UPDATE_TIME")]
        [Server]
        public DateTime UpdateTime
        {
            get { return _UpdateTime; }
            set { _UpdateTime = value; }
        }

        [DataInt32("CREATE_USER_ID")]
        [Server]
        public int CreateUserId
        {
            get { return _CreateUserId; }
            set { _CreateUserId = value; }
        }

        [DataInt32("UPDATE_USER_ID")]
        [Server]
        public int UpdateUserId
        {
            get { return _UpdateUserId; }
            set { _UpdateUserId = value; }
        }

        [DataString("LATITUDE", Length = 15, AllowNull = true)]
        [Server]
        [TitleCaption("Enlem")]
        public string Latitude
        {
            get { return _Latitude; }
            set { _Latitude = value; }
        }

        [DataString("LONGITUDE", Length = 15, AllowNull = true)]
        [Server]
        [TitleCaption("Boylam")]
        public string Longitude
        {
            get { return _Longitude; }
            set { _Longitude = value; }
        }

        [DataString("TOWN_NAME", Length = 40), TitleCaption("İlçe")]
        [Server]
        [UyumIndex(Name = "UN_GNLD_TOWN", IsUnique = true)]
        public string TownName
        {
            get { return _TownName; }
            set { _TownName = value; }
        }

        [DataInt32("CITY_ID")]
        [Server]
        [UyumIndex(Name = "UN_GNLD_TOWN", IsUnique = true)]
        public int CityId
        {
            get { return _CityId; }
            set { _CityId = value; }
        }

        [DataString("CITY_NAME", Flags = ColumnFlags.None, TableAlias = "GNLD_CITY"), TitleCaption("İl")]
        [Server]
        public string CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        [DataString("LICENCE_PLATE", Flags = ColumnFlags.None, TableAlias = "GNLD_CITY"), TitleCaption("Plaka Kodu")]
        public string LicencePlate { get; set; }


        [DataInt32("COUNTRY_ID")]
        [Server]
        [UyumIndex(Name = "UN_GNLD_TOWN", IsUnique = true)]
        public int CountryId
        {
            get { return _CountryId; }
            set { _CountryId = value; }
        }

        [DataString("COUNTRY_NAME", Flags = ColumnFlags.None, TableAlias = "GNLD_COUNTRY", IsMultilingual = true), TitleCaption("Ülke")]
        [Server]
        public string CountryName
        {
            get { return _CountryName; }
            set { _CountryName = value; }
        }

        [DataInt32("COUNTRY_GRP_ID", AllowInInsert = false, AllowInUpdate = false, AllowInSelect = false, TableAlias = "GNLD_COUNTRY_GROUP", Alias = "COUNTRY_GRP_ID")]
        [Server]
        [TitleCaption("Ülke Grup Id")]
        public int CountryGrpId
        {
            get { return _CountryGrpId; }
            set { _CountryGrpId = value; }
        }

        [DataString("DESCRIPTION", AllowInInsert = false, AllowInUpdate = false, AllowInSelect = false, TableAlias = "GNLD_COUNTRY_GROUP", Alias = "COUNTRY_GRP_DESC")]
        [Server]
        [TitleCaption("Ülke Grup Açıklaması")]
        public string CountryGrpDesc
        {
            get { return _CountryGrpDesc; }
            set { _CountryGrpDesc = value; }
        }

        [DataBoolean("ISPASSIVE", AllowNull = true, DefaultValue = false)]
        [Server]
        [TitleCaption("Pasif")]
        public bool Ispassive
        {
            get { return _Ispassive; }
            set { _Ispassive = value; }
        }

    }
}
