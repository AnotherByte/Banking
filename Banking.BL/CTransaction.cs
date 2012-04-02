using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CTransaction
    {
        private int _miTransactionID;
        public int TransactionID
        {
            get { return _miTransactionID; }
            //set { _miTransactionID = value; }
        }

        private double _mdTransactionAmmount;
        public double TransactionAmmount
        {
            get { return _mdTransactionAmmount; }
            //set { _mdTransactionAmmount = value; }
        }

        private DateTime _mTransactionDate;
        public DateTime TransactionDate
        {
            get { return _mTransactionDate; }
            //set { _mTransactionDate = value; }
        }

        private TransactionType _mTransactionType;
        public TransactionType TransactionType
        {
            get { return _mTransactionType; }
            //set { _mTransactionType = value; }
        }


        public CTransaction()
        {
        }

        public CTransaction(int viID, double vdAmmount, DateTime vDate, TransactionType vType)
        {
            _miTransactionID = viID;
            _mdTransactionAmmount = vdAmmount;
            _mTransactionDate = vDate;
            _mTransactionType = vType;
        }
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
}
