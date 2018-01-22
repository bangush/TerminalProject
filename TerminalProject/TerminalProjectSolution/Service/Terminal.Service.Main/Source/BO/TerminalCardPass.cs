using FreeLibrary.Core;
using FreeLibrary.Entity;
using System;
using Terminal.Service.Main.Source.DL;

namespace Terminal.Service.Main.Source.BO
{
	public class TerminalCardPass : BaseBO
	{
		private int _Id;
		public int Id
		{
			set { _Id = value; OnPropertyChanged("Id"); }
			get { return _Id; }
		}

		private string _CardNo;
		public string CardNo
		{
			set { _CardNo = value; OnPropertyChanged("CardNo"); }
			get { return _CardNo; }
		}

		private string _TerminalNo;
		public string TerminalNo
		{
			set { _TerminalNo = value; OnPropertyChanged("TerminalNo"); }
			get { return _TerminalNo; }
		}

		private DateTime _RequestTime;
		public DateTime RequestTime
		{
			set { _RequestTime = value; OnPropertyChanged("RequestTime"); }
			get { return _RequestTime; }
		}

		public override string GetTableName()
		{
			return "TerminalCardPass";
		}

		public override string GetIdColumn()
		{
			return "Id";
		}

	}
}