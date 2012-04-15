using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Banking.BL;

namespace Banking.UI
{
    public partial class frmCustomerInformation : Form
    {
        private CCustomers oCustomers;

        public frmCustomerInformation()
        {
            InitializeComponent();
        }

        private void frmCustomerInformation_Load(object sender, EventArgs e)
        {
            oCustomers = new CCustomers();
            oCustomers.Populate();
            PopulateListBox();
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            if (index > -1 && index < oCustomers.Customers.Count)
            {
                CCustomer oCustomer = oCustomers.Customers[index];

                txtAge.Text = oCustomer.Age.ToString();
                txtFirst.Text = oCustomer.FirstName;
                txtLast.Text = oCustomer.LastName;
                txtID.Text = oCustomer.ID.ToString();
                txtSSN.Text = oCustomer.SSN;
                dtpBirthDate.Value = oCustomer.BirthDate;

                PopulateDGVs(oCustomer.Deposits, oCustomer.Withdrawals);

                //lblDeposits.Text = string.Format("{0} - {1}", oCustomer.LastDepositDate, oCustomer.LastDepositAmmount);
                //lblWithdrawals.Text = string.Format("{0} - {1}", oCustomer.LastWithdrawalDate, oCustomer.LastWithdrawalAmmount);
            }
        }


        private void PopulateListBox()
        {
            lstCustomers.DataSource = null;

            lstCustomers.DataSource = oCustomers.Customers;
            lstCustomers.DisplayMember = "FullName";
        }

        private void PopulateDGVs(List<CTransaction> Deposits, List<CTransaction> Withdrawals)
        {
            dgvDeposits.DataSource = null;
            dgvWithdrawals.DataSource = null;


            dgvDeposits.DataSource = Deposits;
            dgvWithdrawals.DataSource = Withdrawals;

            dgvDeposits.Columns["TransactionType"].Visible = false;
            dgvWithdrawals.Columns["TransactionType"].Visible = false;

            dgvDeposits.Columns["TransactionAmmount"].DefaultCellStyle.Format = "c";
            dgvWithdrawals.Columns["TransactionAmmount"].DefaultCellStyle.Format = "c";
        }
    }
}
