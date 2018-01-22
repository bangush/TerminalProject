using System;
using System.ComponentModel.DataAnnotations;
using FreeLibrary.Entity;

namespace Terminal.Service.Main.Source.BO
{
    public class Card : BaseBO
    {
        private long _Id;

        public long Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
        }

        private string _CardNo;

        [Required(AllowEmptyStrings = false)]
        [StringLength(8)]
        public string CardNo
        {
            set { _CardNo = value; OnPropertyChanged("CardNo"); }
            get { return _CardNo; }
        }

        private string _CardNoDec;

        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string CardNoDec
        {
            set { _CardNoDec = value; OnPropertyChanged("CardNoDec"); }
            get { return _CardNoDec; }
        }

        private string _PersonelId;

        [Required(AllowEmptyStrings = false)]
        [StringLength(20)]
        public string PersonelId
        {
            set { _PersonelId = value; OnPropertyChanged("PersonelId"); }
            get { return _PersonelId; }
        }

        private string _PersonFirstName;

        public string PersonFirstName
        {
            set { _PersonFirstName = value; OnPropertyChanged("PersonFirstName"); }
            get { return _PersonFirstName; }
        }

        private string _PersonLastName;

        public string PersonLastName
        {
            set { _PersonLastName = value; OnPropertyChanged("PersonLastName"); }
            get { return _PersonLastName; }
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
            return "Card";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }
    }
}
