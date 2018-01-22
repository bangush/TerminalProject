using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class UserRole : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		private int _RoleId;
		public int RoleId
		{
			set { _RoleId = value; OnPropertyChanged("RoleId"); }
			get { return _RoleId; }
		}

		private DateTime _CreatedOn;
		public DateTime CreatedOn
		{
			set { _CreatedOn = value; OnPropertyChanged("CreatedOn"); }
			get { return _CreatedOn; }
		}

		private bool _IsActive;
		public bool IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "UserRole";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}