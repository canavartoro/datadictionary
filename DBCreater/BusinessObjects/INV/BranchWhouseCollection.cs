using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("d65f6b6f-2db8-4e90-a33d-7447074a41d1")]
	[UyumTable("invd_branch_whouse",Database="public", InsertStoredProcedure="invd_branch_whouse_i", UpdateStoredProcedure="invd_branch_whouse_u", DeleteStoredProcedure="invd_branch_whouse_d", SelectStoredProcedure="invd_branch_whouse_s")]
	public class BranchWhouseCollection : UyumObjectCollection
	{

		public BranchWhouseCollection()
		{
			base._ItemType = typeof(BranchWhouse);
		}

		public override IUyumObject CreateItem()
		{
			return new BranchWhouse();
		}

		public BranchWhouse this[int index]
		{
			get { return base.innerList[index] as BranchWhouse; }
		}

		public static explicit operator List<BranchWhouseInfo>(BranchWhouseCollection enumarable)
		{
			List<BranchWhouseInfo> list = new List<BranchWhouseInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					BranchWhouse uyumObject = enumarable.GetItemFromIndex(i) as BranchWhouse;
					BranchWhouseInfo item = new BusinessObjects.BranchWhouseInfo();
					item.Id = uyumObject.Id;
					item.CoId = uyumObject.CoId;
					item.BranchId = uyumObject.BranchId;
					item.WhouseId = uyumObject.WhouseId;
					item.EntityId = uyumObject.EntityId;
					item.CreateUserId = uyumObject.CreateUserId;
					item.CreateDate = uyumObject.CreateDate;
					item.UpdateUserId = uyumObject.UpdateUserId;
					item.UpdateDate = uyumObject.UpdateDate;
					list.Add(item);
				}
			}
			list.TrimExcess();
			return list;
		}

	}
}
