namespace SYSTEMUPGRADEPF
{
    partial class frmSearchLoans
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
            this.objListLoans = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objListLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // objListLoans
            // 
            this.objListLoans.AllColumns.Add(this.olvColumn1);
            this.objListLoans.AllColumns.Add(this.olvColumn2);
            this.objListLoans.AllColumns.Add(this.olvColumn3);
            this.objListLoans.AllColumns.Add(this.olvColumn4);
            this.objListLoans.AllColumns.Add(this.olvColumn5);
            this.objListLoans.AllColumns.Add(this.olvColumn6);
            this.objListLoans.CellEditUseWholeCell = false;
            this.objListLoans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.objListLoans.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListLoans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objListLoans.FullRowSelect = true;
            this.objListLoans.GridLines = true;
            this.objListLoans.HideSelection = false;
            this.objListLoans.Location = new System.Drawing.Point(0, 0);
            this.objListLoans.Name = "objListLoans";
            this.objListLoans.ShowGroups = false;
            this.objListLoans.Size = new System.Drawing.Size(1231, 550);
            this.objListLoans.TabIndex = 0;
            this.objListLoans.UseAlternatingBackColors = true;
            this.objListLoans.UseCompatibleStateImageBehavior = false;
            this.objListLoans.View = System.Windows.Forms.View.Details;
            this.objListLoans.SelectedIndexChanged += new System.EventHandler(this.objListLoans_SelectedIndexChanged);
            this.objListLoans.DoubleClick += new System.EventHandler(this.objListLoans_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MemberName";
            this.olvColumn1.Text = "Member";
            this.olvColumn1.Width = 182;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "LoanTypeDescription";
            this.olvColumn2.Text = "Loan Type";
            this.olvColumn2.Width = 191;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "LoanPurposeDescription";
            this.olvColumn3.Text = "Loan Purpose";
            this.olvColumn3.Width = 158;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "LoanAmount";
            this.olvColumn4.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn4.Text = " Loan Amount";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.Width = 129;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "RepaymentPeriod";
            this.olvColumn5.Text = "RepaymentPeriod";
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "LoanEffectDate";
            this.olvColumn6.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumn6.Text = "Loan Effect Date";
            this.olvColumn6.Width = 189;
            // 
            // frmSearchLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 550);
            this.Controls.Add(this.objListLoans);
            this.Name = "frmSearchLoans";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Loans";
            this.Load += new System.EventHandler(this.frmSearchLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListLoans)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListLoans;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}