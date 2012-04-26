using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Banking.DL;

namespace Banking.BL
{
    public class CCustomers
    {
        #region Properties

        private List<CCustomer> _mCustomers;
        public List<CCustomer> Customers
        {
            get { return _mCustomers; }
        }

        // hardcode = 1, flat file = 2, db = 3
        private int _StorageMethod;

        #endregion

        #region Constructors

        public CCustomers(int iStorageMethod)
        {
            _mCustomers = new List<CCustomer>();
            _StorageMethod = iStorageMethod;
        }

        #endregion

        #region Methods

        public void Add(CCustomer oCustomer)
        {
            _mCustomers.Add(oCustomer);
        }

        public void Delete(int vIndex)
        {
            _mCustomers.RemoveAt(vIndex);
        }

        public void Sort()
        {
            _mCustomers.Sort((x, y) => string.Compare(x.FullName, y.FullName));
        }

        // save, uses _StorageMethod to pick which save to use
        public void Save()
        {
            switch (_StorageMethod)
            {
                case 1:
                    // hardcode
                    // no saving
                    break;
                case 2:
                    // flat file
                    SaveXML();
                    break;
                case 3:
                    // database
                    // SaveDB();
                    break;
            }
        }

        // load, uses _StorageMethod to pick which load to use
        public void Load()
        {
            switch (_StorageMethod)
            {
                case 1:
                    // hardcode
                    Populate();
                    break;
                case 2:
                    // flat file
                    LoadXML();
                    break;
                case 3:
                    // database
                    // LoadDB();
                    break;
            }
        }


        // 'loads' sample data, hardcoded
        private void Populate()
        {
            // CCust1
            DateTime Date = new DateTime(1980, 5, 6);
            CCustomer oCustomer = new CCustomer("1", "555-66-7788", "Bob", "Smith", Date);

            // CCust1 transactions
            CTransaction oTrans = new CTransaction(Guid.NewGuid(), 100, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 567, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 345, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;
            oTrans = new CTransaction(Guid.NewGuid(), 546, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 765, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 1234, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust1
            Add(oCustomer);
            oCustomer = null;



            // CCust2
            Date = new DateTime(1990, 6, 20);
            oCustomer = new CCustomer("2", "222-33-4455", "Stan", "Cleveland", Date);

            // CCust2 transactions
            oTrans = new CTransaction(Guid.NewGuid(), 765, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 654, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 432, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 765, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 234, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 845, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust2
            Add(oCustomer);
            oCustomer = null;


            // CCust3
            Date = new DateTime(2000, 10, 30);
            oCustomer = new CCustomer("3", "555-66-2233", "Sam", "Banks", Date);

            // CCust3 transactions
            oTrans = new CTransaction(Guid.NewGuid(), 987, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 654, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 234, DateTime.Today, TransactionType.Deposit);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 435, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 231, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            oTrans = new CTransaction(Guid.NewGuid(), 154, DateTime.Today, TransactionType.Withdrawal);
            oCustomer.AddTransaction(oTrans);
            oTrans = null;

            // add CCust3
            Add(oCustomer);
            oCustomer = null;
        }

        // saves to flat file
        private void SaveXML()
        {
            try
            {
                if (_mCustomers.Count < 1)
                {
                    throw new Exception("Must have at least one customer");
                }
                CFile oFile = new CFile(Properties.Settings.Default.FileName);
                oFile.Serialize(typeof(List<CCustomer>), _mCustomers.ToList());
                oFile = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // loads from flat file
        private void LoadXML()
        {
            try
            {
                CFile oFile = new CFile(Properties.Settings.Default.FileName);
                _mCustomers = (List<CCustomer>)oFile.DeSerialize(typeof(List<CCustomer>));
                oFile = null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
