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
            get { return LastTransaction(TransactionType.Deposit).TransactionAmmount; }
        }


        public DateTime LastDepositDate
        {
            get { return LastTransaction(TransactionType.Deposit).TransactionDate; }
        }


        public double LastWithdrawalAmmount
        {
            get { return LastTransaction(TransactionType.Withdrawal).TransactionAmmount; }
        }

        public DateTime LastWithdrawalDate
        {
            get { return LastTransaction(TransactionType.Withdrawal).TransactionDate; }
        }


        private List<CTransaction> _mTransactionList;
        public List<CTransaction> Transactions
        {
            get { return _mTransactionList; }
        }

        public List<CTransaction> Deposits
        {
            get { return SeperateTransactions(TransactionType.Deposit); }
        }

        public List<CTransaction> Withdrawals
        {
            get { return SeperateTransactions(TransactionType.Withdrawal); }
        }


        public CCustomer(int vID, string vSSN, string vFirst, string vLast, DateTime vDOB)
        {
            ID = Guid.NewGuid();
            CustomerID = vID;
            SSN = vSSN;
            FirstName = vFirst;
            LastName = vLast;
            BirthDate = vDOB;

            _mTransactionList = new List<CTransaction>();

        }

        public void AddTransaction(CTransaction oTransaction)
        {
            _mTransactionList.Add(oTransaction);
        }


        private CTransaction LastTransaction(TransactionType oTransType)
        {
            CTransaction oLastTrans = new CTransaction();
            DateTime oLastDate = new DateTime();

            foreach (CTransaction oTrans in _mTransactionList)
            {
                if (oTrans.TransactionType == oTransType)
                {
                    if (oTrans.TransactionDate > oLastDate)
                    {
                        oLastDate = oTrans.TransactionDate;
                        oLastTrans = oTrans;
                    }
                }
            }

            return oLastTrans;
        }

        private List<CTransaction> SeperateTransactions(TransactionType oTransactionType)
        {
            List<CTransaction> oSepTrans = new List<CTransaction>();

            foreach (CTransaction oTrans in Transactions)
            {
                oSepTrans.Add(oTrans);
            }

            oSepTrans.RemoveAll(item => item.TransactionType != oTransactionType);
            return oSepTrans;
        }

    }
}
