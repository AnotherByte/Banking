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

            oCustomers.Load();

            RefreshListBox();
        }


        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            if (index > -1 && index < oCustomers.Customers.Count)
            {
                CCustomer oCustomer = oCustomers.Customers[index];

                lblAge.Text = oCustomer.Age.ToString();
                txtFirst.Text = oCustomer.FirstName;
                txtLast.Text = oCustomer.LastName;
                txtID.Text = oCustomer.CustomerID;
                txtSSN.Text = oCustomer.SSN;
                dtpBirthDate.Value = oCustomer.BirthDate;

                PopulateDGVs(oCustomer.GetTransactions(TransactionType.Deposit), oCustomer.GetTransactions(TransactionType.Withdrawal));
            }
        }

        private void RefreshListBox()
        {
            lstCustomers.DataSource = null;

            oCustomers.Sort();
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

            dgvDeposits.Columns["TransactionAmmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvWithdrawals.Columns["TransactionAmmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                oCustomers.SaveXML();
                lblStatus.Text = "Saved customers to flat file";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Failed saving flat file : " + ex.Message;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = lstCustomers.SelectedIndex;

            CCustomer oCustomer = oCustomers.Customers[index];

            oCustomer.FirstName = txtFirst.Text;
            oCustomer.LastName = txtLast.Text;
            oCustomer.CustomerID = txtID.Text;
            oCustomer.SSN = txtSSN.Text;
            oCustomer.BirthDate = dtpBirthDate.Value;

            RefreshListBox();
            lblStatus.Text = oCustomer.FullName + " record saved";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            lblAge.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtID.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Today;

            txtFirst.Select();
            txtFirst.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(this, "Are you sure you want to create a new customer? (" + txtLast.Text + ", " + txtFirst.Text + ")", "Add new customer?", MessageBoxButtons.YesNo);
            
            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                oCustomers.Add(new CCustomer(txtID.Text, txtSSN.Text, txtFirst.Text, txtLast.Text, dtpBirthDate.Value));
                lblStatus.Text = "New customer added";
                RefreshListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show(this, "Are you sure you want to delete a customer? (" + txtLast.Text + ", " + txtFirst.Text + ")", "Delete customer?", MessageBoxButtons.YesNo);

            if (dlg == System.Windows.Forms.DialogResult.Yes)
            {
                int index = lstCustomers.SelectedIndex;
                oCustomers.Delete(index);

                lblStatus.Text = "Customer deleted";
                RefreshListBox();
            }
        }
    }
}
