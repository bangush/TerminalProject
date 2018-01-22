using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class LogDetail : BaseBO
	{
		private long _Id;
		public long Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private long _LogId;
		public long LogId
		{
			set { _LogId = value; OnPropertyChanged("LogId"); }
			get { return _LogId; }
		}

		private string _ColumnName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string ColumnName
		{
			set { _ColumnName = value; OnPropertyChanged("ColumnName"); }
			get { return _ColumnName; }
		}

		private string _OldValue;
		public string OldValue
		{
			set { _OldValue = value; OnPropertyChanged("OldValue"); }
			get { return _OldValue; }
		}

		private string _NewValue;
		public string NewValue
		{
			set { _NewValue = value; OnPropertyChanged("NewValue"); }
			get { return _NewValue; }
		}

		public override string GetTableName()
		{
			return "LogDetail";
		}

		public override string GetIdColumn()
		{
			return "";
		}

	}
}