using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class Log : BaseBO
	{
		private long _Id;
		public long Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private string _TableName;
		[Required(AllowEmptyStrings = false)]
		[StringLength(50)]
		public string TableName
		{
			set { _TableName = value; OnPropertyChanged("TableName"); }
			get { return _TableName; }
		}

		private long _RecordId;
		public long RecordId
		{
			set { _RecordId = value; OnPropertyChanged("RecordId"); }
			get { return _RecordId; }
		}

		private int _LogTypeCode;
		public int LogTypeCode
		{
			set { _LogTypeCode = value; OnPropertyChanged("LogTypeCode"); }
			get { return _LogTypeCode; }
		}

		private DateTime _LogTime;
		public DateTime LogTime
		{
			set { _LogTime = value; OnPropertyChanged("LogTime"); }
			get { return _LogTime; }
		}

		private int _UserId;
		public int UserId
		{
			set { _UserId = value; OnPropertyChanged("UserId"); }
			get { return _UserId; }
		}

		public override string GetTableName()
		{
			return "Log";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}