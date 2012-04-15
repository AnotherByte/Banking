namespace Banking.UI
{
    partial class frmCustomerInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeposits = new System.Windows.Forms.Label();
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.lblWithdrawals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(23, 38);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(232, 147);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.Location = new System.Drawing.Point(20, 19);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(65, 13);
            this.lblCustomers.TabIndex = 1;
            this.lblCustomers.Text = "Customers";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(291, 38);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "First Name";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(382, 35);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(230, 20);
            this.txtFirst.TabIndex = 3;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(382, 61);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(230, 20);
            this.txtLast.TabIndex = 5;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(291, 64);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name";
            // 
            // txtSSN
            // 
            this.txtSSN.BackColor = System.Drawing.SystemColors.Window;
            this.txtSSN.Location = new System.Drawing.Point(382, 87);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.ReadOnly = true;
            this.txtSSN.Size = new System.Drawing.Size(230, 20);
            this.txtSSN.TabIndex = 7;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(291, 90);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(29, 13);
            this.lblSSN.TabIndex = 6;
            this.lblSSN.Text = "SSN";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(382, 113);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(230, 20);
            this.txtID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(291, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(291, 168);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.Window;
            this.txtAge.Location = new System.Drawing.Point(382, 139);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(230, 20);
            this.txtAge.TabIndex = 13;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(291, 142);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 12;
            this.lblAge.Text = "Age";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(382, 168);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(230, 20);
            this.dtpBirthDate.TabIndex = 14;
            // 
            // lblDeposits
            // 
            this.lblDeposits.AutoSize = true;
            this.lblDeposits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposits.Location = new System.Drawing.Point(20, 238);
            this.lblDeposits.Name = "lblDeposits";
            this.lblDeposits.Size = new System.Drawing.Size(56, 13);
            this.lblDeposits.TabIndex = 15;
            this.lblDeposits.Text = "Deposits";
            // 
            // dgvDeposits
            // 
            this.dgvDeposits.AllowUserToAddRows = false;
            this.dgvDeposits.AllowUserToDeleteRows = false;
            this.dgvDeposits.AllowUserToOrderColumns = true;
            this.dgvDeposits.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeposits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDeposits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDeposits.Location = new System.Drawing.Point(23, 254);
            this.dgvDeposits.MultiSelect = false;
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.ReadOnly = true;
            this.dgvDeposits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposits.ShowEditingIcon = false;
            this.dgvDeposits.Size = new System.Drawing.Size(589, 150);
            this.dgvDeposits.TabIndex = 16;
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.AllowUserToAddRows = false;
            this.dgvWithdrawals.AllowUserToDeleteRows = false;
            this.dgvWithdrawals.AllowUserToOrderColumns = true;
            this.dgvWithdrawals.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            this.dgvWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWithdrawals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWithdrawals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWithdrawals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvWithdrawals.Location = new System.Drawing.Point(23, 444);
            this.dgvWithdrawals.MultiSelect = false;
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.ReadOnly = true;
            this.dgvWithdrawals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWithdrawals.ShowEditingIcon = false;
            this.dgvWithdrawals.Size = new System.Drawing.Size(589, 150);
            this.dgvWithdrawals.TabIndex = 18;
            // 
            // lblWithdrawals
            // 
            this.lblWithdrawals.AutoSize = true;
            this.lblWithdrawals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawals.Location = new System.Drawing.Point(20, 428);
            this.lblWithdrawals.Name = "lblWithdrawals";
            this.lblWithdrawals.Size = new System.Drawing.Size(76, 13);
            this.lblWithdrawals.TabIndex = 17;
            this.lblWithdrawals.Text = "Withdrawals";
            // 
            // frmCustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 611);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.lblWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Controls.Add(this.lblDeposits);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lstCustomers);
            this.Name = "frmCustomerInformation";
            this.Text = "Customer Information";
            this.Load += new System.EventHandler(this.frmCustomerInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblDeposits;
        private System.Windows.Forms.DataGridView dgvDeposits;
        private System.Windows.Forms.DataGridView dgvWithdrawals;
        private System.Windows.Forms.Label lblWithdrawals;
    }
}

