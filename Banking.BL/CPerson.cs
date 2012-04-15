using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CPerson
    {
        private Guid _miID;
        public Guid ID
        {
            get { return _miID; }
            set { _miID = value; }
        }

        private string _msSSN;
        public string SSN
        {
            get { return _msSSN; }
            set { _msSSN = value; }
        }

        private string _msFirstName;
        public string FirstName
        {
            get { return _msFirstName; }
            set { _msFirstName = value; }
        }

        private string _msLastName;
        public string LastName
        {
            get { return _msLastName; }
            set { _msLastName = value; }
        }

        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        private DateTime _mBirthDate;
        public DateTime BirthDate
        {
            get { return _mBirthDate; }
            set { _mBirthDate = value; }
        }

        public int Age
        {
            get { return DateTime.Today.Year - _mBirthDate.Year; }
        }
    }
}
