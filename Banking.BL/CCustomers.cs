using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking.BL
{
    public class CCustomers
    {
        private List<CCustomer> _mCustomers;
        public List<CCustomer> Customers
        {
            get { return _mCustomers; }
        }

        public CCustomers()
        {
            _mCustomers = new List<CCustomer>();
        }

        public void Add(CCustomer oCustomer)
        {
            _mCustomers.Add(oCustomer);
        }

        public void Populate()
        {
            // CCust1
            DateTime Date = new DateTime(1980, 5, 6);
            CCustomer oCustomer = new CCustomer(123, "5556667788", "Bob", "Smith", Date);

            // CCust1 transactions
            CTransaction oTrans = new CTransaction(1, 100, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(2, 567, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(3, 345, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(4, 213, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust1
            Add(oCustomer);
            oCustomer = null;



            // CCust2
            Date = new DateTime(1990, 6, 20);
            oCustomer = new CCustomer(456, "2223334455", "Stan", "Cleveland", Date);

            // CCust2 transactions
            oTrans = new CTransaction(5, 765, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(6, 654, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(7, 432, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(8, 987, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust2
            Add(oCustomer);
            oCustomer = null;


            // CCust3
            Date = new DateTime(2000, 10, 30);
            oCustomer = new CCustomer(789, "5556662233", "Sam", "Banks", Date);

            // CCust3 transactions
            oTrans = new CTransaction(9, 987, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(10, 435, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(11, 231, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(12, 154, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust3
            Add(oCustomer);
            oCustomer = null;
        }
    }
}
