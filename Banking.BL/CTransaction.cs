using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CTransaction
    {
        #region Properties

        private Guid _mTransactionID;
        public Guid TransactionID
        {
            get { return _mTransactionID; }
            set { _mTransactionID = value; }
        }

        private double _mdTransactionAmmount;
        public double TransactionAmmount
        {
            get { return _mdTransactionAmmount; }
            set { _mdTransactionAmmount = value; }
        }

        private DateTime _mTransactionDate;
        public DateTime TransactionDate
        {
            get { return _mTransactionDate; }
            set { _mTransactionDate = value; }
        }

        private TransactionType _mTransactionType;
        public TransactionType TransactionType
        {
            get { return _mTransactionType; }
            set { _mTransactionType = value; }
        }

        #endregion

        #region Constructor

        public CTransaction()
        {
        }

        public CTransaction(Guid vID, double vdAmmount, DateTime vDate, TransactionType vType)
        {
            _mTransactionID = vID;
            _mdTransactionAmmount = vdAmmount;
            _mTransactionDate = vDate;
            _mTransactionType = vType;
        }

        #endregion

        #region Methods



        #endregion
    }

    public enum TransactionType
    {
        Deposit,
        Withdrawal
    }
}
