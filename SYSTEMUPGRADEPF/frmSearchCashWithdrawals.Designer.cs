namespace SYSTEMUPGRADEPF
{
    partial class frmSearchCashWithdrawals
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
            this.objCashWithdrawalTransactions = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objCashWithdrawalTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // objCashWithdrawalTransactions
            // 
            this.objCashWithdrawalTransactions.AllColumns.Add(this.olvColumn5);
            this.objCashWithdrawalTransactions.AllColumns.Add(this.olvColumn6);
            this.objCashWithdrawalTransactions.AllColumns.Add(this.olvColumn7);
            this.objCashWithdrawalTransactions.AllColumns.Add(this.olvColumn8);
            this.objCashWithdrawalTransactions.AllColumns.Add(this.olvColumn1);
            this.objCashWithdrawalTransactions.CellEditUseWholeCell = false;
            this.objCashWithdrawalTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7,
            this.olvColumn8,
            this.olvColumn1});
            this.objCashWithdrawalTransactions.Cursor = System.Windows.Forms.Cursors.Default;
            this.objCashWithdrawalTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objCashWithdrawalTransactions.FullRowSelect = true;
            this.objCashWithdrawalTransactions.GridLines = true;
            this.objCashWithdrawalTransactions.HideSelection = false;
            this.objCashWithdrawalTransactions.Location = new System.Drawing.Point(0, 0);
            this.objCashWithdrawalTransactions.Name = "objCashWithdrawalTransactions";
            this.objCashWithdrawalTransactions.ShowGroups = false;
            this.objCashWithdrawalTransactions.Size = new System.Drawing.Size(1301, 632);
            this.objCashWithdrawalTransactions.TabIndex = 2;
            this.objCashWithdrawalTransactions.UseAlternatingBackColors = true;
            this.objCashWithdrawalTransactions.UseCompatibleStateImageBehavior = false;
            this.objCashWithdrawalTransactions.View = System.Windows.Forms.View.Details;
            this.objCashWithdrawalTransactions.SelectedIndexChanged += new System.EventHandler(this.objTransactions_SelectedIndexChanged);
            this.objCashWithdrawalTransactions.DoubleClick += new System.EventHandler(this.objCashWithdrawalTransactions_DoubleClick);
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "TransDate";
            this.olvColumn5.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumn5.Text = "Transaction Date";
            this.olvColumn5.Width = 158;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Amount";
            this.olvColumn6.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn6.Text = "Amount";
            this.olvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn6.Width = 137;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "ModeofPayment";
            this.olvColumn7.Text = "Payment Mode";
            this.olvColumn7.Width = 137;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "DocumentNo";
            this.olvColumn8.Text = "Document No.";
            this.olvColumn8.Width = 134;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "BankName";
            this.olvColumn1.Text = "Bank";
            // 
            // frmSearchCashWithdrawals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 632);
            this.Controls.Add(this.objCashWithdrawalTransactions);
            this.Name = "frmSearchCashWithdrawals";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Cash Withdrawals";
            this.Load += new System.EventHandler(this.frmSearchCashWithdrawals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objCashWithdrawalTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objCashWithdrawalTransactions;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
    }
}