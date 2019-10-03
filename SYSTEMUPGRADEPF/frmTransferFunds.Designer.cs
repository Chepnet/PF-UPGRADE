namespace SYSTEMUPGRADEPF
{
    partial class frmTransferFunds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferFunds));
            this.chkFromOther = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMemberNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUseText = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.objListMemberAccounts = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objListMemberAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // chkFromOther
            // 
            this.chkFromOther.AutoSize = true;
            this.chkFromOther.Location = new System.Drawing.Point(37, 80);
            this.chkFromOther.Name = "chkFromOther";
            this.chkFromOther.Size = new System.Drawing.Size(138, 24);
            this.chkFromOther.TabIndex = 0;
            this.chkFromOther.Text = "From Other(s):";
            this.chkFromOther.UseVisualStyleBackColor = true;
            this.chkFromOther.CheckedChanged += new System.EventHandler(this.chkFromOther_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Name:";
            // 
            // txtMemberNo
            // 
            this.txtMemberNo.Location = new System.Drawing.Point(220, 80);
            this.txtMemberNo.Name = "txtMemberNo";
            this.txtMemberNo.Size = new System.Drawing.Size(154, 26);
            this.txtMemberNo.TabIndex = 3;
            this.txtMemberNo.TextChanged += new System.EventHandler(this.txtMemberNo_TextChanged);
            this.txtMemberNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberNo_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(414, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 26);
            this.txtName.TabIndex = 4;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMember.Image")));
            this.btnSearchMember.Location = new System.Drawing.Point(783, 78);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(30, 31);
            this.btnSearchMember.TabIndex = 6;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // btnUseText
            // 
            this.btnUseText.Location = new System.Drawing.Point(43, 124);
            this.btnUseText.Name = "btnUseText";
            this.btnUseText.Size = new System.Drawing.Size(132, 33);
            this.btnUseText.TabIndex = 9;
            this.btnUseText.Text = "Use Text";
            this.btnUseText.UseVisualStyleBackColor = true;
            this.btnUseText.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(200, 127);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Visible = false;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(488, 124);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(105, 32);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Location = new System.Drawing.Point(676, 491);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(137, 35);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.button3_Click);
            // 
            // objListMemberAccounts
            // 
            this.objListMemberAccounts.AllColumns.Add(this.olvColumn1);
            this.objListMemberAccounts.AllColumns.Add(this.olvColumn2);
            this.objListMemberAccounts.AllColumns.Add(this.olvColumn3);
            this.objListMemberAccounts.AllColumns.Add(this.olvColumn4);
            this.objListMemberAccounts.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objListMemberAccounts.CellEditUseWholeCell = false;
            this.objListMemberAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.objListMemberAccounts.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListMemberAccounts.FullRowSelect = true;
            this.objListMemberAccounts.GridLines = true;
            this.objListMemberAccounts.HideSelection = false;
            this.objListMemberAccounts.Location = new System.Drawing.Point(5, 234);
            this.objListMemberAccounts.Name = "objListMemberAccounts";
            this.objListMemberAccounts.ShowGroups = false;
            this.objListMemberAccounts.Size = new System.Drawing.Size(811, 182);
            this.objListMemberAccounts.TabIndex = 13;
            this.objListMemberAccounts.UseCompatibleStateImageBehavior = false;
            this.objListMemberAccounts.View = System.Windows.Forms.View.Details;
            this.objListMemberAccounts.SelectedIndexChanged += new System.EventHandler(this.objListMemberAccounts_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "AccountCode";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Code";
            this.olvColumn1.Width = 82;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ShareTypeDescription";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Share Type";
            this.olvColumn2.Width = 150;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Balance";
            this.olvColumn3.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Balance";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn3.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "TransferAmmount";
            this.olvColumn4.AspectToStringFormat = "";
            this.olvColumn4.Text = "Transfer Amount";
            this.olvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn4.ToolTipText = "Amount to transfer from this account to the other one";
            this.olvColumn4.Width = 120;
            // 
            // frmTransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 538);
            this.Controls.Add(this.objListMemberAccounts);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUseText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMemberNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkFromOther);
            this.Name = "frmTransferFunds";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Funds";
            this.Load += new System.EventHandler(this.frmTransferFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListMemberAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFromOther;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMemberNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUseText;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDone;
        private BrightIdeasSoftware.ObjectListView objListMemberAccounts;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}