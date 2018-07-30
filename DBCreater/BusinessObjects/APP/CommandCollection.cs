using System;
using System.Text;
using Uyum.Net;
using Uyum.Objects;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace WHM.Module.BusinessObjects
{
	[Guid("3590cbf0-69da-4252-84be-db51fcc023bf")]
	[UyumTable("appd_command",Database="public", InsertStoredProcedure="appd_command_i", UpdateStoredProcedure="appd_command_u", DeleteStoredProcedure="appd_command_d", SelectStoredProcedure="appd_command_s")]
	public class CommandCollection : UyumObjectCollection
	{

		public CommandCollection()
		{
			base._ItemType = typeof(Command);
		}

		public override IUyumObject CreateItem()
		{
			return new Command();
		}

		public Command this[int index]
		{
			get { return base.innerList[index] as Command; }
		}

		public static explicit operator List<CommandInfo>(CommandCollection enumarable)
		{
			List<CommandInfo> list = new List<CommandInfo>();
			if (!object.ReferenceEquals(enumarable, null))
			{
				for (int i = 0; i < enumarable.Count; i++)
				{
					Command uyumObject = enumarable.GetItemFromIndex(i) as Command;
					CommandInfo item = new BusinessObjects.CommandInfo();
					item.Id = uyumObject.Id;
					item.CmdName = uyumObject.CmdName;
					item.MenuId = uyumObject.MenuId;
					item.CommandLabel = uyumObject.CommandLabel;
					item.UnAuthorized = uyumObject.UnAuthorized;
					item.CmdUrl = uyumObject.CmdUrl;
					item.ObjectType = uyumObject.ObjectType;
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
