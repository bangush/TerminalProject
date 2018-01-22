using System;
using System.ComponentModel.DataAnnotations;
using FreeLibrary.Entity;

namespace Terminal.Service.Main.Source.BO
{
    public class TerminalDataLog : BaseBO
    {
        private long _Id;

        public long Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
        }

        private string _RequestData;

        public string RequestData
        {
            set { _RequestData = value; OnPropertyChanged("RequestData"); }
            get { return _RequestData; }
        }

        private DateTime _RequestTime;

        public DateTime RequestTime
        {
            set { _RequestTime = value; OnPropertyChanged("RequestTime"); }
            get { return _RequestTime; }
        }

        private string _RequestAddress;

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string RequestAddress
        {
            set { _RequestAddress = value; OnPropertyChanged("RequestAddress"); }
            get { return _RequestAddress; }
        }

        private string _ResponseData;

        public string ResponseData
        {
            set { _ResponseData = value; OnPropertyChanged("ResponseData"); }
            get { return _ResponseData; }
        }

        private DateTime _ResponseTime;

        public DateTime ResponseTime
        {
            set { _ResponseTime = value; OnPropertyChanged("ResponseTime"); }
            get { return _ResponseTime; }
        }

        private string _ResponseAddress;

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string ResponseAddress
        {
            set { _ResponseAddress = value; OnPropertyChanged("ResponseAddress"); }
            get { return _ResponseAddress; }
        }

        private DateTime _CreatedOn;

        public DateTime CreatedOn
        {
            set { _CreatedOn = value; OnPropertyChanged("CreatedOn"); }
            get { return _CreatedOn; }
        }

        public override string GetTableName()
        {
            return "TerminalDataLog";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }
    }
}
