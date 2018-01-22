using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class EventLog : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private string _Addres;
		public string Addres
		{
			set { _Addres = value; OnPropertyChanged("Addres"); }
			get { return _Addres; }
		}

		private int _Code;
		public int Code
		{
			set { _Code = value; OnPropertyChanged("Code"); }
			get { return _Code; }
		}

		private string _ClassName;
		public string ClassName
		{
			set { _ClassName = value; OnPropertyChanged("ClassName"); }
			get { return _ClassName; }
		}

		private string _MethodName;
		public string MethodName
		{
			set { _MethodName = value; OnPropertyChanged("MethodName"); }
			get { return _MethodName; }
		}

		private string _Message;
		public string Message
		{
			set { _Message = value; OnPropertyChanged("Message"); }
			get { return _Message; }
		}

		private string _StackTrace;
		public string StackTrace
		{
			set { _StackTrace = value; OnPropertyChanged("StackTrace"); }
			get { return _StackTrace; }
		}

		private string _MachineName;
		public string MachineName
		{
			set { _MachineName = value; OnPropertyChanged("MachineName"); }
			get { return _MachineName; }
		}

		private string _InnerMessage;
		public string InnerMessage
		{
			set { _InnerMessage = value; OnPropertyChanged("InnerMessage"); }
			get { return _InnerMessage; }
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

		public override string GetTableName()
		{
			return "EventLog";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}