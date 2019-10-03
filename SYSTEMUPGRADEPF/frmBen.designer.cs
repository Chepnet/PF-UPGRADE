namespace SYSTEMUPGRADEPF
{
    partial class frmBen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBen));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRelationShip = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.LBLPercentageValue = new System.Windows.Forms.Label();
            this.TxtPercentageValue = new System.Windows.Forms.TextBox();
            this.txtRelationship = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtDocumentNo = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblMember = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBenCode = new System.Windows.Forms.Label();
            this.txtBenCode = new System.Windows.Forms.TextBox();
            this.lblBenName = new System.Windows.Forms.Label();
            this.txtBenName = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.btnSearchDocumentType = new System.Windows.Forms.Button();
            this.btnSearchRelationship = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStripSeparator2,
            this.cutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(872, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, -32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member No:";
            // 
            // lblRelationShip
            // 
            this.lblRelationShip.AutoSize = true;
            this.lblRelationShip.Location = new System.Drawing.Point(21, 204);
            this.lblRelationShip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelationShip.Name = "lblRelationShip";
            this.lblRelationShip.Size = new System.Drawing.Size(101, 20);
            this.lblRelationShip.TabIndex = 4;
            this.lblRelationShip.Text = "Relationship:";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Location = new System.Drawing.Point(21, 288);
            this.lblDoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(106, 20);
            this.lblDoB.TabIndex = 5;
            this.lblDoB.Text = "Date Of Birth:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(21, 478);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(77, 20);
            this.lblRemarks.TabIndex = 7;
            this.lblRemarks.Text = "Remarks:";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(21, 239);
            this.lblDocumentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(125, 20);
            this.lblDocumentType.TabIndex = 8;
            this.lblDocumentType.Text = "Document Type:";
            // 
            // LBLPercentageValue
            // 
            this.LBLPercentageValue.AutoSize = true;
            this.LBLPercentageValue.Location = new System.Drawing.Point(21, 342);
            this.LBLPercentageValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLPercentageValue.Name = "LBLPercentageValue";
            this.LBLPercentageValue.Size = new System.Drawing.Size(140, 20);
            this.LBLPercentageValue.TabIndex = 9;
            this.LBLPercentageValue.Text = "Percentage Value:";
            // 
            // TxtPercentageValue
            // 
            this.TxtPercentageValue.Location = new System.Drawing.Point(169, 339);
            this.TxtPercentageValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPercentageValue.Name = "TxtPercentageValue";
            this.TxtPercentageValue.Size = new System.Drawing.Size(404, 26);
            this.TxtPercentageValue.TabIndex = 7;
            this.TxtPercentageValue.TextChanged += new System.EventHandler(this.TxtPercentageValue_TextChanged);
            // 
            // txtRelationship
            // 
            this.txtRelationship.Location = new System.Drawing.Point(169, 200);
            this.txtRelationship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRelationship.Name = "txtRelationship";
            this.txtRelationship.ReadOnly = true;
            this.txtRelationship.Size = new System.Drawing.Size(404, 26);
            this.txtRelationship.TabIndex = 13;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(169, 442);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(404, 74);
            this.txtRemarks.TabIndex = 9;
            this.txtRemarks.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtDocumentNo
            // 
            this.txtDocumentNo.Location = new System.Drawing.Point(169, 236);
            this.txtDocumentNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocumentNo.Name = "txtDocumentNo";
            this.txtDocumentNo.ReadOnly = true;
            this.txtDocumentNo.Size = new System.Drawing.Size(404, 26);
            this.txtDocumentNo.TabIndex = 16;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(87, 21);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new System.Drawing.Size(473, 26);
            this.txtMemberId.TabIndex = 18;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(169, 569);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(95, 24);
            this.chkIsActive.TabIndex = 10;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Location = new System.Drawing.Point(8, 24);
            this.lblMember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(71, 20);
            this.lblMember.TabIndex = 20;
            this.lblMember.Text = "Member:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBenCode);
            this.groupBox1.Controls.Add(this.txtBenCode);
            this.groupBox1.Controls.Add(this.lblBenName);
            this.groupBox1.Controls.Add(this.txtBenName);
            this.groupBox1.Controls.Add(this.btnSearchMember);
            this.groupBox1.Controls.Add(this.txtMemberId);
            this.groupBox1.Controls.Add(this.lblMember);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(749, 126);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblBenCode
            // 
            this.lblBenCode.AutoSize = true;
            this.lblBenCode.Location = new System.Drawing.Point(6, 74);
            this.lblBenCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenCode.Name = "lblBenCode";
            this.lblBenCode.Size = new System.Drawing.Size(84, 20);
            this.lblBenCode.TabIndex = 22;
            this.lblBenCode.Text = "Ben Code:";
            // 
            // txtBenCode
            // 
            this.txtBenCode.Location = new System.Drawing.Point(87, 71);
            this.txtBenCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBenCode.Name = "txtBenCode";
            this.txtBenCode.Size = new System.Drawing.Size(130, 26);
            this.txtBenCode.TabIndex = 2;
            // 
            // lblBenName
            // 
            this.lblBenName.AutoSize = true;
            this.lblBenName.Location = new System.Drawing.Point(234, 74);
            this.lblBenName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBenName.Name = "lblBenName";
            this.lblBenName.Size = new System.Drawing.Size(137, 20);
            this.lblBenName.TabIndex = 23;
            this.lblBenName.Text = "Beneficiary Name:";
            // 
            // txtBenName
            // 
            this.txtBenName.Location = new System.Drawing.Point(379, 71);
            this.txtBenName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBenName.Name = "txtBenName";
            this.txtBenName.Size = new System.Drawing.Size(350, 26);
            this.txtBenName.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.CustomFormat = "dd-MMM-yyyy";
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(169, 283);
            this.dtpDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(404, 26);
            this.dtpDateOfBirth.TabIndex = 6;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(169, 393);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(404, 26);
            this.txtMobileNo.TabIndex = 8;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Location = new System.Drawing.Point(21, 396);
            this.lblMobileNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(83, 20);
            this.lblMobileNo.TabIndex = 24;
            this.lblMobileNo.Text = "Mobile No:";
            // 
            // btnSearchDocumentType
            // 
            this.btnSearchDocumentType.FlatAppearance.BorderSize = 0;
            this.btnSearchDocumentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDocumentType.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDocumentType.Image")));
            this.btnSearchDocumentType.Location = new System.Drawing.Point(584, 236);
            this.btnSearchDocumentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchDocumentType.Name = "btnSearchDocumentType";
            this.btnSearchDocumentType.Size = new System.Drawing.Size(48, 35);
            this.btnSearchDocumentType.TabIndex = 5;
            this.btnSearchDocumentType.Text = "...";
            this.btnSearchDocumentType.UseVisualStyleBackColor = true;
            this.btnSearchDocumentType.Click += new System.EventHandler(this.btnSearchDocumentTypeId_Click);
            // 
            // btnSearchRelationship
            // 
            this.btnSearchRelationship.FlatAppearance.BorderSize = 0;
            this.btnSearchRelationship.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRelationship.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRelationship.Image")));
            this.btnSearchRelationship.Location = new System.Drawing.Point(584, 197);
            this.btnSearchRelationship.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchRelationship.Name = "btnSearchRelationship";
            this.btnSearchRelationship.Size = new System.Drawing.Size(48, 35);
            this.btnSearchRelationship.TabIndex = 4;
            this.btnSearchRelationship.Text = "...";
            this.btnSearchRelationship.UseVisualStyleBackColor = true;
            this.btnSearchRelationship.Click += new System.EventHandler(this.btnSearchRelationship_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.FlatAppearance.BorderSize = 0;
            this.btnSearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMember.Image")));
            this.btnSearchMember.Location = new System.Drawing.Point(571, 17);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(48, 35);
            this.btnSearchMember.TabIndex = 1;
            this.btnSearchMember.Text = "...";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMemberId_Click);
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
            // toolStripPrevious
            // 
            this.toolStripPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevious.Image")));
            this.toolStripPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrevious.Name = "toolStripPrevious";
            this.toolStripPrevious.Size = new System.Drawing.Size(28, 28);
            this.toolStripPrevious.Text = "&Previous";
            this.toolStripPrevious.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripNext
            // 
            this.toolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNext.Image")));
            this.toolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNext.Name = "toolStripNext";
            this.toolStripNext.Size = new System.Drawing.Size(28, 28);
            this.toolStripNext.Text = "&Next";
            this.toolStripNext.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.cutToolStripButton.Text = "&Delete";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // frmBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 621);
            this.Controls.Add(this.btnSearchDocumentType);
            this.Controls.Add(this.btnSearchRelationship);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDocumentNo);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtRelationship);
            this.Controls.Add(this.TxtPercentageValue);
            this.Controls.Add(this.LBLPercentageValue);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblRelationShip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiary";
            this.Load += new System.EventHandler(this.frmBen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRelationShip;
        private System.Windows.Forms.Label lblDoB;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label LBLPercentageValue;
        private System.Windows.Forms.TextBox TxtPercentageValue;
        private System.Windows.Forms.TextBox txtRelationship;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtDocumentNo;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.Button btnSearchRelationship;
        private System.Windows.Forms.Button btnSearchDocumentType;
        private System.Windows.Forms.Label lblBenCode;
        private System.Windows.Forms.TextBox txtBenCode;
        private System.Windows.Forms.Label lblBenName;
        private System.Windows.Forms.TextBox txtBenName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}