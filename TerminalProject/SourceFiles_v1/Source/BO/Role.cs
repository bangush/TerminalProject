using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class Role : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private string _RoleName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string RoleName
		{
			set { _RoleName = value; OnPropertyChanged("RoleName"); }
			get { return _RoleName; }
		}

		private DateTime _CreatedOn;
		public DateTime CreatedOn
		{
			set { _CreatedOn = value; OnPropertyChanged("CreatedOn"); }
			get { return _CreatedOn; }
		}

		private int _CreatedBy;
		public int CreatedBy
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
			return "Role";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}