using System;
using System.Runtime.InteropServices;
using Uyum.Objects;

namespace GNL
{
	[Guid("fdece7ef-9ba8-45a1-9bab-b5db5ac7423e")]
	[UyumTable("GNLD_TOWN", Database="Uyumsoft", InsertStoredProcedure="GNL_TOWN_I", UpdateStoredProcedure="GNL_TOWN_U", DeleteStoredProcedure="GNL_TOWN_D", SelectStoredProcedure="GNL_TOWN_S")]
    [UyumJoin(JoinType.LeftOuterJoin, "GNLD_TOWN", "COUNTRY_ID", "GNLD_COUNTRY", "COUNTRY_ID", Order = 0)]
    [UyumJoin(JoinType.LeftOuterJoin, "GNLD_TOWN", "CITY_ID", "GNLD_CITY", "CITY_ID", Order = 1)]
    [UyumJoin(JoinType.LeftOuterJoin, "GNLD_COUNTRY", "COUNTRY_GRP_ID", "GNLD_COUNTRY_GROUP", "COUNTRY_GRP_ID", Order = 2)]
	public class TownCollection : UyumObjectCollection
	{
		public TownCollection()
		{
			base._ItemType = typeof(Town);
		}

		public override IUyumObject CreateItem()
		{
			return new Town();
		}

		public Town this[int index]
		{
			get { return base.innerList[index] as Town; }
		}
	}
}