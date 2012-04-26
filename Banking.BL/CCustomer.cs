using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CCustomer : CPerson
    {
        #region Properties

        private string _mCustomerID;
        public string CustomerID
        {
            get { return _mCustomerID; }
            set { _mCustomerID = value; }
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

        #endregion

        #region Constructors

        public CCustomer()
        {
            _mTransactionList = new List<CTransaction>();
        }

        public CCustomer(string vID, string vSSN, string vFirst, string vLast, DateTime vDOB)
        {
            ID = Guid.NewGuid();
            CustomerID = vID;
            SSN = vSSN;
            FirstName = vFirst;
            LastName = vLast;
            BirthDate = vDOB;

            _mTransactionList = new List<CTransaction>();

        }

        #endregion

        #region Methods

        public void AddTransaction(CTransaction oTransaction)
        {
            _mTransactionList.Add(oTransaction);
        }

        public List<CTransaction> GetTransactions(TransactionType oType)
        {
            return SeperateTransactions(oType);
        }


        public CTransaction LastTransaction(TransactionType oTransType)
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

            foreach (CTransaction oTrans in _mTransactionList)
            {
                oSepTrans.Add(oTrans);
            }

            oSepTrans.RemoveAll(item => item.TransactionType != oTransactionType);
            return oSepTrans;
        }

        #endregion

    }
}
