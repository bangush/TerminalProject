using System;
using FreeLibrary.Entity;

namespace Terminal.Service.Main.Source.BO
{
    public class TerminalPass : BaseBO
    {
        private long _Id;

        public long Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
        }

        private long _TerminalId;

        public long TerminalId
        {
            set { _TerminalId = value; OnPropertyChanged("TerminalId"); }
            get { return _TerminalId; }
        }

        private long _CardId;

        public long CardId
        {
            set { _CardId = value; OnPropertyChanged("CardId"); }
            get { return _CardId; }
        }

        private DateTime _PassTime;

        public DateTime PassTime
        {
            set { _PassTime = value; OnPropertyChanged("PassTime"); }
            get { return _PassTime; }
        }

        private bool _IsActive;

        public bool IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "TerminalPass";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }
    }
}
