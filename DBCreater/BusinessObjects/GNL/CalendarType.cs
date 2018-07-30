using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;


namespace WHM.Module.BusinessObjects
{
	[Guid("f97d0359-37c9-4ece-b88b-07b02bce2d52")]
	public class CalendarType : UyumObjectBase
	{

		public CalendarType()
		{
		}

		private int _CalendarTypeId = 0;//integer
		private int _CalendarTypeCode = 0;//integer
		private int _CalendarTypeDesc = 0;//integer
		private int _CreateUserId = 0;//integer
		private DateTime _CreateDate = DateTime.Now;//timestamp
		private int _UpdateUserId = 0;//integer
		private DateTime _UpdateDate = DateTime.Now;//timestamp

		[Server]
		[DataInt32("calendar_type_id", IsIdentity = true)]
		[UyumPrimaryKey(0)]
		public override int Id
		{
			get { return base.Id; }
			set { base.Id = value; }
		}

		[Server]
		[DataInt32("calendar_type_code")]
		public int CalendarTypeCode
		{
			get { return _CalendarTypeCode; }
			set { _CalendarTypeCode = value; }
		}

		[Server]
		[DataInt32("calendar_type_desc")]
		public int CalendarTypeDesc
		{
			get { return _CalendarTypeDesc; }
			set { _CalendarTypeDesc = value; }
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
	[DataContract(Name = "CalendarType")]
	public class CalendarTypeInfo
	{

		public CalendarTypeInfo()
		{
		}

		[DataMember(Name = "calendar_type_id")]
		public int Id { get; set; }

		[DataMember(Name = "calendar_type_code")]
		public int CalendarTypeCode { get; set; }

		[DataMember(Name = "calendar_type_desc")]
		public int CalendarTypeDesc { get; set; }

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
