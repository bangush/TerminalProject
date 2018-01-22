using System.ComponentModel.DataAnnotations;
using FreeLibrary.Entity;

namespace Terminal.Service.Main.Source.BO
{
    public class TerminalBO : BaseBO
    {
        private long _Id;

        public long Id
        {
            set { _Id = value; OnPropertyChanged("Id"); }
            get { return _Id; }
        }

        private string _TerminalNo;

        [Required(AllowEmptyStrings = false)]
        [StringLength(10)]
        public string TerminalNo
        {
            set { _TerminalNo = value; OnPropertyChanged("TerminalNo"); }
            get { return _TerminalNo; }
        }

        private string _Definition;

        [Required(AllowEmptyStrings = false)]
        [StringLength(50)]
        public string Definition
        {
            set { _Definition = value; OnPropertyChanged("Definition"); }
            get { return _Definition; }
        }

        private bool _IsInOut;

        public bool IsInOut
        {
            set { _IsInOut = value; OnPropertyChanged("IsInOut"); }
            get { return _IsInOut; }
        }

        private bool _IsActive;

        public bool IsActive
        {
            set { _IsActive = value; OnPropertyChanged("IsActive"); }
            get { return _IsActive; }
        }

        public override string GetTableName()
        {
            return "Terminal";
        }

        public override string GetIdColumn()
        {
            return "Id";
        }
    }
}
