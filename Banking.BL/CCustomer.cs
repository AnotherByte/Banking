using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CCustomer : CPerson
    {
        private int _miCustomerID;
        public int CustomerID
        {
            get { return _miCustomerID; }
            set { _miCustomerID = value; }
        }


        public double LastDepositAmmount
        {
            get { return _mDepositList[_mDepositList.Count - 1].TransactionAmmount ; }
        }

        public DateTime LastDepositDate
        {
            get { return _mDepositList[_mDepositList.Count - 1].TransactionDate; }
        }


        public double LastWithdrawalAmmount
        {
            get { return _mWithdrawalList[_mWithdrawalList.Count - 1].TransactionAmmount; }
        }

        public DateTime LastWithdrawalDate
        {
            get { return _mWithdrawalList[_mWithdrawalList.Count - 1].TransactionDate; }
        }


        private List<CTransaction> _mDepositList;
        public List<CTransaction> GetDeposits()
        {
            return _mDepositList;
        }

        private List<CTransaction> _mWithdrawalList;
        public List<CTransaction> GetWithdrawals()
        {
            return _mWithdrawalList;
        }


        public CCustomer(int vID, string vSSN, string vFirst, string vLast, DateTime vDOB)
        {
            ID = vID;
            SSN = vSSN;
            FirstName = vFirst;
            LastName = vLast;
            BirthDate = vDOB;

            _mDepositList = new List<CTransaction>();
            _mWithdrawalList = new List<CTransaction>();

        }

        public void AddTransaction(CTransaction oTransaction)
        {
            if (oTransaction.TransactionType == TransactionType.Deposit)
            {
                _mDepositList.Add(oTransaction);
            }
            else
            {
                _mWithdrawalList.Add(oTransaction);
            }
        }

    }
}
