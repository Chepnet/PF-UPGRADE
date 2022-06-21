namespace SYSTEMUPGRADEPF
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.objList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cmbCurrencypay = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPaidBy = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.txtPayMode = new System.Windows.Forms.TextBox();
            this.txtDRGL = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dtPTransDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnPayMode = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.toolStripPrevious,
            this.toolStripNext,
            this.toolStripSeparator,
            this.cutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1112, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripPrevious
            // 
            this.toolStripPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevious.Image")));
            this.toolStripPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrevious.Name = "toolStripPrevious";
            this.toolStripPrevious.Size = new System.Drawing.Size(28, 28);
            this.toolStripPrevious.Text = "&Previous";
            // 
            // toolStripNext
            // 
            this.toolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNext.Image")));
            this.toolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNext.Name = "toolStripNext";
            this.toolStripNext.Size = new System.Drawing.Size(28, 28);
            this.toolStripNext.Text = "&Next";
            this.toolStripNext.Click += new System.EventHandler(this.toolStripNext_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(28, 28);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Received From:";
            // 
            // txtcustomer
            // 
            this.txtcustomer.Location = new System.Drawing.Point(159, 86);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(414, 26);
            this.txtcustomer.TabIndex = 3;
            // 
            // objList
            // 
            this.objList.AllColumns.Add(this.olvColumn1);
            this.objList.AllColumns.Add(this.olvColumn2);
            this.objList.AllColumns.Add(this.olvColumn4);
            this.objList.AllColumns.Add(this.olvColumn3);
            this.objList.CellEditUseWholeCell = false;
            this.objList.CheckBoxes = true;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn4,
            this.olvColumn3});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.HideSelection = false;
            this.objList.Location = new System.Drawing.Point(39, 148);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(897, 176);
            this.objList.TabIndex = 5;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.DoubleClick += new System.EventHandler(this.objList_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "InvoiceNo";
            this.olvColumn1.Text = "Invoice No";
            this.olvColumn1.Width = 244;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Total";
            this.olvColumn2.AspectToStringFormat = "{0:###.###.00}";
            this.olvColumn2.Text = "Total";
            this.olvColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn2.Width = 158;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "ModeOfPayment";
            this.olvColumn4.Text = "Pay Mode";
            this.olvColumn4.Width = 98;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "InvoiceBalance";
            this.olvColumn3.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn3.Text = "Balance";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn3.Width = 126;
            // 
            // cmbCurrencypay
            // 
            this.cmbCurrencypay.FormattingEnabled = true;
            this.cmbCurrencypay.Location = new System.Drawing.Point(166, 452);
            this.cmbCurrencypay.Name = "cmbCurrencypay";
            this.cmbCurrencypay.Size = new System.Drawing.Size(197, 28);
            this.cmbCurrencypay.TabIndex = 69;
            this.cmbCurrencypay.SelectedIndexChanged += new System.EventHandler(this.cmbCurrencypay_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(22, 454);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 20);
            this.label22.TabIndex = 68;
            this.label22.Text = "Currency:";
            // 
            // txtPaidBy
            // 
            this.txtPaidBy.Location = new System.Drawing.Point(537, 457);
            this.txtPaidBy.Name = "txtPaidBy";
            this.txtPaidBy.Size = new System.Drawing.Size(227, 26);
            this.txtPaidBy.TabIndex = 61;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(537, 497);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(227, 52);
            this.txtComment.TabIndex = 62;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(166, 406);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(197, 26);
            this.txtAmountPaid.TabIndex = 53;
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(166, 546);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.Size = new System.Drawing.Size(208, 26);
            this.txtDocumentNo.TabIndex = 56;
            // 
            // txtPayMode
            // 
            this.txtPayMode.Enabled = false;
            this.txtPayMode.Location = new System.Drawing.Point(166, 500);
            this.txtPayMode.Name = "txtPayMode";
            this.txtPayMode.Size = new System.Drawing.Size(208, 26);
            this.txtPayMode.TabIndex = 54;
            // 
            // txtDRGL
            // 
            this.txtDRGL.Enabled = false;
            this.txtDRGL.Location = new System.Drawing.Point(537, 414);
            this.txtDRGL.Name = "txtDRGL";
            this.txtDRGL.Size = new System.Drawing.Size(227, 26);
            this.txtDRGL.TabIndex = 59;
            // 
            // txtBank
            // 
            this.txtBank.Enabled = false;
            this.txtBank.Location = new System.Drawing.Point(537, 364);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(227, 26);
            this.txtBank.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 460);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 67;
            this.label8.Text = "Paid By:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(440, 500);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(86, 20);
            this.lblComment.TabIndex = 66;
            this.lblComment.Text = "Comment :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Document No:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 501);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Pay Mode:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(440, 414);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 20);
            this.label16.TabIndex = 63;
            this.label16.Text = "DR GL:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(440, 367);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 20);
            this.label17.TabIndex = 60;
            this.label17.Text = "Bank:";
            // 
            // dtPTransDate
            // 
            this.dtPTransDate.CustomFormat = "dd-MMM-yyyy";
            this.dtPTransDate.Enabled = false;
            this.dtPTransDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPTransDate.Location = new System.Drawing.Point(166, 360);
            this.dtPTransDate.Name = "dtPTransDate";
            this.dtPTransDate.Size = new System.Drawing.Size(197, 26);
            this.dtPTransDate.TabIndex = 51;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 20);
            this.label18.TabIndex = 49;
            this.label18.Text = "Amount:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(22, 360);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 20);
            this.label20.TabIndex = 48;
            this.label20.Text = "Transaction Date:";
            // 
            // btnBank
            // 
            this.btnBank.FlatAppearance.BorderSize = 0;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Image = ((System.Drawing.Image)(resources.GetObject("btnBank.Image")));
            this.btnBank.Location = new System.Drawing.Point(801, 367);
            this.btnBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(30, 31);
            this.btnBank.TabIndex = 58;
            this.btnBank.Text = "...";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnPayMode
            // 
            this.btnPayMode.FlatAppearance.BorderSize = 0;
            this.btnPayMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayMode.Image = ((System.Drawing.Image)(resources.GetObject("btnPayMode.Image")));
            this.btnPayMode.Location = new System.Drawing.Point(381, 498);
            this.btnPayMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayMode.Name = "btnPayMode";
            this.btnPayMode.Size = new System.Drawing.Size(30, 31);
            this.btnPayMode.TabIndex = 55;
            this.btnPayMode.Text = "...";
            this.btnPayMode.UseVisualStyleBackColor = true;
            this.btnPayMode.Click += new System.EventHandler(this.btnPayMode_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMember.Image")));
            this.btnSearchMember.Location = new System.Drawing.Point(580, 81);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(30, 31);
            this.btnSearchMember.TabIndex = 4;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 610);
            this.Controls.Add(this.cmbCurrencypay);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtPaidBy);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.txtPayMode);
            this.Controls.Add(this.txtDRGL);
            this.Controls.Add(this.txtBank);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBank);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnPayMode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtPTransDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.objList);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Button btnSearchMember;
        private BrightIdeasSoftware.ObjectListView objList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.ComboBox cmbCurrencypay;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPaidBy;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.TextBox txtPayMode;
        private System.Windows.Forms.TextBox txtDRGL;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Button btnPayMode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtPTransDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
    }
}