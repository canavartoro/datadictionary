using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("f7a4c381-fe5c-441b-90ea-233f44c06b1d")]
	public class Menu : UyumObjectBase
	{

		public Menu()
		{
		}

		private int _MenuId = 0;//integer
		private int _CmdId = 0;//integer
		private int _ParentId = 0;//integer
		private bool _IsLeaf = false;//boolean
		private bool _IsPassive = false;//boolean
		private int _Rank = 0;//integer
		private int _DeviceType = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("menu_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("cmd_id")]
		public int CmdId
		{
			get { return _CmdId; }
			set { _CmdId = value; }
		}

		[Server]
		[DataInt32("parent_id")]
		public int ParentId
		{
			get { return _ParentId; }
			set { _ParentId = value; }
		}

		[Server]
		[DataBoolean("is_leaf")]
		public bool IsLeaf
		{
			get { return _IsLeaf; }
			set { _IsLeaf = value; }
		}

		[Server]
		[DataBoolean("is_passive")]
		public bool IsPassive
		{
			get { return _IsPassive; }
			set { _IsPassive = value; }
		}

		[Server]
		[DataInt32("rank")]
		public int Rank
		{
			get { return _Rank; }
			set { _Rank = value; }
		}

		[Server]
		[DataInt32("device_type")]
		public int DeviceType
		{
			get { return _DeviceType; }
			set { _DeviceType = value; }
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
	[DataContract(Name = "Menu")]
	public class MenuInfo
	{

		public MenuInfo()
		{
		}

		[DataMember(Name = "menu_id")]
		public int Id { get; set; }

		[DataMember(Name = "cmd_id")]
		public int CmdId { get; set; }

		[DataMember(Name = "parent_id")]
		public int ParentId { get; set; }

		[DataMember(Name = "is_leaf")]
		public bool IsLeaf { get; set; }

		[DataMember(Name = "is_passive")]
		public bool IsPassive { get; set; }

		[DataMember(Name = "rank")]
		public int Rank { get; set; }

		[DataMember(Name = "device_type")]
		public int DeviceType { get; set; }

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
