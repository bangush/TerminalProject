using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class LogType : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private int _LogTypeCode;
		public int LogTypeCode
		{
			set { _LogTypeCode = value; OnPropertyChanged("LogTypeCode"); }
			get { return _LogTypeCode; }
		}

		private string _LogTypeName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(20)]
		public string LogTypeName
		{
			set { _LogTypeName = value; OnPropertyChanged("LogTypeName"); }
			get { return _LogTypeName; }
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
			return "LogType";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}