using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class User : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private string _FirstName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string FirstName
		{
			set { _FirstName = value; OnPropertyChanged("FirstName"); }
			get { return _FirstName; }
		}

		private char _LastName;
		public char LastName
		{
			set { _LastName = value; OnPropertyChanged("LastName"); }
			get { return _LastName; }
		}

		private string _UserName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(20)]
		public string UserName
		{
			set { _UserName = value; OnPropertyChanged("UserName"); }
			get { return _UserName; }
		}

		private string _Password;
		[Required(AllowEmptyStrings = false)]
		[StringLength(100)]
		public string Password
		{
			set { _Password = value; OnPropertyChanged("Password"); }
			get { return _Password; }
		}

		private string _Salt;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string Salt
		{
			set { _Salt = value; OnPropertyChanged("Salt"); }
			get { return _Salt; }
		}

		private int _UserTypeCode;
		public int UserTypeCode
		{
			set { _UserTypeCode = value; OnPropertyChanged("UserTypeCode"); }
			get { return _UserTypeCode; }
		}

		private DateTime _CreatedOn;
		public DateTime CreatedOn
		{
			set { _CreatedOn = value; OnPropertyChanged("CreatedOn"); }
			get { return _CreatedOn; }
		}

		private int? _CreatedBy;
		public int? CreatedBy
		{
			set { _CreatedBy = value; OnPropertyChanged("CreatedBy"); }
			get { return _CreatedBy; }
		}

		private bool _IsActive;
		public bool IsActive
		{
			set { _IsActive = value; OnPropertyChanged("IsActive"); }
			get { return _IsActive; }
		}

		public override string GetTableName()
		{
			return "User";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}