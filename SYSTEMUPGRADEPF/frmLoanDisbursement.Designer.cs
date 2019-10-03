namespace SYSTEMUPGRADEPF
{
    partial class frmLoanDisbursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanDisbursement));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.txtModeOfPayment = new System.Windows.Forms.TextBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDRGL = new System.Windows.Forms.TextBox();
            this.dtpTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpValueDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoanType = new System.Windows.Forms.Button();
            this.btnModeOfPayment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Document No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bank:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "DR GL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Paid By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter Comments:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(402, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mode Of Payment:";
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(544, 100);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(178, 26);
            this.txtDocumentNo.TabIndex = 4;
            // 
            // txtModeOfPayment
            // 
            this.txtModeOfPayment.Enabled = false;
            this.txtModeOfPayment.Location = new System.Drawing.Point(544, 54);
            this.txtModeOfPayment.Name = "txtModeOfPayment";
            this.txtModeOfPayment.Size = new System.Drawing.Size(178, 26);
            this.txtModeOfPayment.TabIndex = 2;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(170, 189);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(178, 26);
            this.txtPaid.TabIndex = 5;
            // 
            // txtBank
            // 
            this.txtBank.Enabled = false;
            this.txtBank.Location = new System.Drawing.Point(544, 146);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(178, 26);
            this.txtBank.TabIndex = 6;
            this.txtBank.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(864, 98);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(240, 59);
            this.txtDescription.TabIndex = 9;
            // 
            // txtDRGL
            // 
            this.txtDRGL.Enabled = false;
            this.txtDRGL.Location = new System.Drawing.Point(544, 192);
            this.txtDRGL.Name = "txtDRGL";
            this.txtDRGL.Size = new System.Drawing.Size(178, 26);
            this.txtDRGL.TabIndex = 8;
            this.txtDRGL.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dtpTransactionDate
            // 
            this.dtpTransactionDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTransactionDate.Location = new System.Drawing.Point(170, 60);
            this.dtpTransactionDate.Name = "dtpTransactionDate";
            this.dtpTransactionDate.Size = new System.Drawing.Size(178, 26);
            this.dtpTransactionDate.TabIndex = 0;
            // 
            // dtpValueDate
            // 
            this.dtpValueDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpValueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValueDate.Location = new System.Drawing.Point(170, 105);
            this.dtpValueDate.Name = "dtpValueDate";
            this.dtpValueDate.Size = new System.Drawing.Size(178, 26);
            this.dtpValueDate.TabIndex = 1;
            // 
            // btnLoanType
            // 
            this.btnLoanType.FlatAppearance.BorderSize = 0;
            this.btnLoanType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoanType.Image = ((System.Drawing.Image)(resources.GetObject("btnLoanType.Image")));
            this.btnLoanType.Location = new System.Drawing.Point(729, 143);
            this.btnLoanType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoanType.Name = "btnLoanType";
            this.btnLoanType.Size = new System.Drawing.Size(36, 31);
            this.btnLoanType.TabIndex = 7;
            this.btnLoanType.Text = "...";
            this.btnLoanType.UseVisualStyleBackColor = true;
            this.btnLoanType.Click += new System.EventHandler(this.btnLoanType_Click);
            // 
            // btnModeOfPayment
            // 
            this.btnModeOfPayment.FlatAppearance.BorderSize = 0;
            this.btnModeOfPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModeOfPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnModeOfPayment.Image")));
            this.btnModeOfPayment.Location = new System.Drawing.Point(729, 55);
            this.btnModeOfPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModeOfPayment.Name = "btnModeOfPayment";
            this.btnModeOfPayment.Size = new System.Drawing.Size(36, 31);
            this.btnModeOfPayment.TabIndex = 3;
            this.btnModeOfPayment.Text = "...";
            this.btnModeOfPayment.UseVisualStyleBackColor = true;
            this.btnModeOfPayment.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(947, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Currency:";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.Enabled = false;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(170, 146);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(178, 28);
            this.cmbCurrency.TabIndex = 12;
            this.cmbCurrency.SelectedIndexChanged += new System.EventHandler(this.cmbCurrency_SelectedIndexChanged);
            // 
            // frmLoanDisbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 264);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModeOfPayment);
            this.Controls.Add(this.btnLoanType);
            this.Controls.Add(this.dtpValueDate);
            this.Controls.Add(this.dtpTransactionDate);
            this.Controls.Add(this.txtModeOfPayment);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDRGL);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLoanDisbursement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Disbursement";
            this.Load += new System.EventHandler(this.frmLoanDisbursement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.TextBox txtModeOfPayment;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDRGL;
        private System.Windows.Forms.DateTimePicker dtpTransactionDate;
        private System.Windows.Forms.DateTimePicker dtpValueDate;
        private System.Windows.Forms.Button btnLoanType;
        private System.Windows.Forms.Button btnModeOfPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCurrency;
    }
}