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
            CCustomer oCustomer = new CCustomer(1, "555-66-7788", "Bob", "Smith", Date);

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
            oTrans = new CTransaction(4, 546, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(5, 765, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(6, 1234, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust1
            Add(oCustomer);
            oCustomer = null;



            // CCust2
            Date = new DateTime(1990, 6, 20);
            oCustomer = new CCustomer(2, "222-33-4455", "Stan", "Cleveland", Date);

            // CCust2 transactions
            oTrans = new CTransaction(7, 765, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(8, 654, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(9, 432, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(10, 765, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(11, 234, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(12, 845, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust2
            Add(oCustomer);
            oCustomer = null;


            // CCust3
            Date = new DateTime(2000, 10, 30);
            oCustomer = new CCustomer(3, "555-66-2233", "Sam", "Banks", Date);

            // CCust3 transactions
            oTrans = new CTransaction(13, 987, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(14, 654, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(15, 234, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(16, 435, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(17, 231, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(18, 154, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust3
            Add(oCustomer);
            oCustomer = null;
        }
    }
}
