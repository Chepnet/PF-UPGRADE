namespace SYSTEMUPGRADEPF
{
    partial class frmMemberShares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberShares));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.txtMemberNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChkIsActive = new System.Windows.Forms.CheckBox();
            this.chkExemptMobileCharges = new System.Windows.Forms.CheckBox();
            this.chkHideBalanceReceipt = new System.Windows.Forms.CheckBox();
            this.txtMinBalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDefaultAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSharetype = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pcbphoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.txtMemberName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCellNo);
            this.groupBox1.Controls.Add(this.txtIdNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblCellNo);
            this.groupBox1.Controls.Add(this.txtMemberNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(932, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMember.Image")));
            this.btnSearchMember.Location = new System.Drawing.Point(888, 49);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(30, 31);
            this.btnSearchMember.TabIndex = 4;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(553, 51);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.ReadOnly = true;
            this.txtMemberName.Size = new System.Drawing.Size(336, 26);
            this.txtMemberName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Member Name:";
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(370, 51);
            this.txtCellNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(136, 26);
            this.txtCellNo.TabIndex = 2;
            this.txtCellNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCellNo_KeyDown);
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(173, 51);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(147, 26);
            this.txtIdNumber.TabIndex = 1;
            this.txtIdNumber.TextChanged += new System.EventHandler(this.txtIdNumber_TextChanged);
            this.txtIdNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdNumber_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "ID No:";
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Location = new System.Drawing.Point(403, 22);
            this.lblCellNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(63, 20);
            this.lblCellNo.TabIndex = 4;
            this.lblCellNo.Text = "Cell No:";
            // 
            // txtMemberNo
            // 
            this.txtMemberNo.Location = new System.Drawing.Point(13, 51);
            this.txtMemberNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberNo.Name = "txtMemberNo";
            this.txtMemberNo.Size = new System.Drawing.Size(129, 26);
            this.txtMemberNo.TabIndex = 0;
            this.txtMemberNo.TextChanged += new System.EventHandler(this.txtMemberNo_TextChanged);
            this.txtMemberNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberNo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member No:";
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
            this.toolStripSeparator2,
            this.cutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1184, 31);
            this.toolStrip1.TabIndex = 2;
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
            this.toolStripPrevious.Text = "Previous";
            this.toolStripPrevious.Click += new System.EventHandler(this.toolStripPrevious_Click);
            // 
            // toolStripNext
            // 
            this.toolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNext.Image")));
            this.toolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNext.Name = "toolStripNext";
            this.toolStripNext.Size = new System.Drawing.Size(28, 28);
            this.toolStripNext.Text = "Next";
            this.toolStripNext.Click += new System.EventHandler(this.toolStripNext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.cutToolStripButton.Text = "Delete";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChkIsActive);
            this.groupBox2.Controls.Add(this.chkExemptMobileCharges);
            this.groupBox2.Controls.Add(this.chkHideBalanceReceipt);
            this.groupBox2.Controls.Add(this.txtMinBalance);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtDefaultAmount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAccountCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSharetype);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 184);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(916, 162);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Share Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ChkIsActive
            // 
            this.ChkIsActive.AutoSize = true;
            this.ChkIsActive.Checked = true;
            this.ChkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkIsActive.Location = new System.Drawing.Point(660, 26);
            this.ChkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkIsActive.Name = "ChkIsActive";
            this.ChkIsActive.Size = new System.Drawing.Size(95, 24);
            this.ChkIsActive.TabIndex = 12;
            this.ChkIsActive.Text = "Is Active";
            this.ChkIsActive.UseVisualStyleBackColor = true;
            // 
            // chkExemptMobileCharges
            // 
            this.chkExemptMobileCharges.AutoSize = true;
            this.chkExemptMobileCharges.Location = new System.Drawing.Point(374, 115);
            this.chkExemptMobileCharges.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkExemptMobileCharges.Name = "chkExemptMobileCharges";
            this.chkExemptMobileCharges.Size = new System.Drawing.Size(203, 24);
            this.chkExemptMobileCharges.TabIndex = 11;
            this.chkExemptMobileCharges.Text = "Exempt Mobile Charges";
            this.chkExemptMobileCharges.UseVisualStyleBackColor = true;
            // 
            // chkHideBalanceReceipt
            // 
            this.chkHideBalanceReceipt.AutoSize = true;
            this.chkHideBalanceReceipt.Location = new System.Drawing.Point(374, 32);
            this.chkHideBalanceReceipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHideBalanceReceipt.Name = "chkHideBalanceReceipt";
            this.chkHideBalanceReceipt.Size = new System.Drawing.Size(211, 24);
            this.chkHideBalanceReceipt.TabIndex = 9;
            this.chkHideBalanceReceipt.Text = "Hide Balance on Receipt";
            this.chkHideBalanceReceipt.UseVisualStyleBackColor = true;
            // 
            // txtMinBalance
            // 
            this.txtMinBalance.Location = new System.Drawing.Point(478, 69);
            this.txtMinBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinBalance.Name = "txtMinBalance";
            this.txtMinBalance.Size = new System.Drawing.Size(148, 26);
            this.txtMinBalance.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Min Balance:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(294, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDefaultAmount
            // 
            this.txtDefaultAmount.Location = new System.Drawing.Point(135, 67);
            this.txtDefaultAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDefaultAmount.Name = "txtDefaultAmount";
            this.txtDefaultAmount.Size = new System.Drawing.Size(148, 26);
            this.txtDefaultAmount.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Def Amount:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(130, 112);
            this.txtAccountCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(148, 26);
            this.txtAccountCode.TabIndex = 8;
            this.txtAccountCode.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Account Code:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtSharetype
            // 
            this.txtSharetype.Location = new System.Drawing.Point(134, 28);
            this.txtSharetype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSharetype.Name = "txtSharetype";
            this.txtSharetype.Size = new System.Drawing.Size(148, 26);
            this.txtSharetype.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Share Type:";
            // 
            // pcbphoto
            // 
            this.pcbphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbphoto.Location = new System.Drawing.Point(958, 56);
            this.pcbphoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbphoto.Name = "pcbphoto";
            this.pcbphoto.Size = new System.Drawing.Size(197, 164);
            this.pcbphoto.TabIndex = 4;
            this.pcbphoto.TabStop = false;
            this.pcbphoto.WaitOnLoad = true;
            // 
            // frmMemberShares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 359);
            this.Controls.Add(this.pcbphoto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMemberShares";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Shares";
            this.Load += new System.EventHandler(this.frmMemberShares_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblCellNo;
        private System.Windows.Forms.TextBox txtMemberNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDefaultAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSharetype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pcbphoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ChkIsActive;
        private System.Windows.Forms.CheckBox chkExemptMobileCharges;
        private System.Windows.Forms.CheckBox chkHideBalanceReceipt;
        private System.Windows.Forms.TextBox txtMinBalance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Label label9;
    }
}