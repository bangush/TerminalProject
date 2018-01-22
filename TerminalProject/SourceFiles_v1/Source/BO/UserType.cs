using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class UserType : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private int _UserTypeCode;
		public int UserTypeCode
		{
			set { _UserTypeCode = value; OnPropertyChanged("UserTypeCode"); }
			get { return _UserTypeCode; }
		}

		private string _UserTypeName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string UserTypeName
		{
			set { _UserTypeName = value; OnPropertyChanged("UserTypeName"); }
			get { return _UserTypeName; }
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
			return "UserType";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}