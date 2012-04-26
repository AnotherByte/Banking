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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lblAgeDisplay = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblDeposits = new System.Windows.Forms.Label();
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.lblWithdrawals = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.lblFirst.Location = new System.Drawing.Point(309, 38);
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
            this.lblLast.Location = new System.Drawing.Point(308, 64);
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
            this.txtSSN.Size = new System.Drawing.Size(230, 20);
            this.txtSSN.TabIndex = 7;
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(337, 90);
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
            this.txtID.Size = new System.Drawing.Size(230, 20);
            this.txtID.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(348, 116);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(312, 168);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 10;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblAgeDisplay
            // 
            this.lblAgeDisplay.AutoSize = true;
            this.lblAgeDisplay.Location = new System.Drawing.Point(340, 142);
            this.lblAgeDisplay.Name = "lblAgeDisplay";
            this.lblAgeDisplay.Size = new System.Drawing.Size(26, 13);
            this.lblAgeDisplay.TabIndex = 12;
            this.lblAgeDisplay.Text = "Age";
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
            this.lblDeposits.Location = new System.Drawing.Point(20, 267);
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver;
            this.dgvDeposits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeposits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeposits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDeposits.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvDeposits.Location = new System.Drawing.Point(23, 283);
            this.dgvDeposits.MultiSelect = false;
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.ReadOnly = true;
            this.dgvDeposits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeposits.ShowEditingIcon = false;
            this.dgvDeposits.Size = new System.Drawing.Size(589, 128);
            this.dgvDeposits.TabIndex = 16;
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.AllowUserToAddRows = false;
            this.dgvWithdrawals.AllowUserToDeleteRows = false;
            this.dgvWithdrawals.AllowUserToOrderColumns = true;
            this.dgvWithdrawals.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            this.dgvWithdrawals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWithdrawals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWithdrawals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvWithdrawals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvWithdrawals.Location = new System.Drawing.Point(23, 440);
            this.dgvWithdrawals.MultiSelect = false;
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.ReadOnly = true;
            this.dgvWithdrawals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWithdrawals.ShowEditingIcon = false;
            this.dgvWithdrawals.Size = new System.Drawing.Size(589, 128);
            this.dgvWithdrawals.TabIndex = 18;
            // 
            // lblWithdrawals
            // 
            this.lblWithdrawals.AutoSize = true;
            this.lblWithdrawals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawals.Location = new System.Drawing.Point(20, 424);
            this.lblWithdrawals.Name = "lblWithdrawals";
            this.lblWithdrawals.Size = new System.Drawing.Size(76, 13);
            this.lblWithdrawals.TabIndex = 17;
            this.lblWithdrawals.Text = "Withdrawals";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(618, 17);
            this.lblStatus.Spring = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(270, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(23, 204);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(92, 41);
            this.btnWrite.TabIndex = 21;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(359, 204);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 41);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(448, 204);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 41);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(537, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblAge
            // 
            this.lblAge.BackColor = System.Drawing.SystemColors.Window;
            this.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAge.Location = new System.Drawing.Point(382, 138);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(230, 20);
            this.lblAge.TabIndex = 25;
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCustomerInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 600);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.lblWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Controls.Add(this.lblDeposits);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblAgeDisplay);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblAgeDisplay;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblDeposits;
        private System.Windows.Forms.DataGridView dgvDeposits;
        private System.Windows.Forms.DataGridView dgvWithdrawals;
        private System.Windows.Forms.Label lblWithdrawals;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblAge;
    }
}

