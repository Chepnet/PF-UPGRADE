namespace SYSTEMUPGRADEPF
{
    partial class frmAssetRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssetRegistration));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbdepreciationmethod = new System.Windows.Forms.ComboBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.dtpDepEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDepStart = new System.Windows.Forms.DateTimePicker();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtGL = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtCreditOfficer = new System.Windows.Forms.TextBox();
            this.txtSerialNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSubcategory = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnSubcategory = new System.Windows.Forms.Button();
            this.btnBank = new System.Windows.Forms.Button();
            this.btnCreditOfficer = new System.Windows.Forms.Button();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1072, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbdepreciationmethod);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.dtpDepEndDate);
            this.panel1.Controls.Add(this.dtpDepStart);
            this.panel1.Controls.Add(this.txtYears);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(474, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 531);
            this.panel1.TabIndex = 66;
            // 
            // cmbdepreciationmethod
            // 
            this.cmbdepreciationmethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdepreciationmethod.FormattingEnabled = true;
            this.cmbdepreciationmethod.Items.AddRange(new object[] {
            "Straight Line",
            "Reducing Balance"});
            this.cmbdepreciationmethod.Location = new System.Drawing.Point(205, 35);
            this.cmbdepreciationmethod.Name = "cmbdepreciationmethod";
            this.cmbdepreciationmethod.Size = new System.Drawing.Size(239, 28);
            this.cmbdepreciationmethod.TabIndex = 72;
            this.cmbdepreciationmethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(205, 284);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(239, 118);
            this.txtRemarks.TabIndex = 71;
            // 
            // dtpDepEndDate
            // 
            this.dtpDepEndDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpDepEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepEndDate.Location = new System.Drawing.Point(205, 219);
            this.dtpDepEndDate.Name = "dtpDepEndDate";
            this.dtpDepEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtpDepEndDate.TabIndex = 70;
            // 
            // dtpDepStart
            // 
            this.dtpDepStart.CustomFormat = "dd-MMM-yyyy";
            this.dtpDepStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepStart.Location = new System.Drawing.Point(205, 95);
            this.dtpDepStart.Name = "dtpDepStart";
            this.dtpDepStart.Size = new System.Drawing.Size(200, 26);
            this.dtpDepStart.TabIndex = 69;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(205, 159);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(169, 26);
            this.txtYears.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Remarks:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 66;
            this.label8.Text = "Depreciation Method:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Years:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 64;
            this.label6.Text = "Dep.End date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Dep.Start Date:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkIsActive);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnSubcategory);
            this.panel2.Controls.Add(this.btnBank);
            this.panel2.Controls.Add(this.txtGL);
            this.panel2.Controls.Add(this.txtBank);
            this.panel2.Controls.Add(this.btnCreditOfficer);
            this.panel2.Controls.Add(this.txtCreditOfficer);
            this.panel2.Controls.Add(this.txtSerialNo);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtSubcategory);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCategory);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 531);
            this.panel2.TabIndex = 67;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(144, 336);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(95, 24);
            this.chkIsActive.TabIndex = 79;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtGL
            // 
            this.txtGL.Location = new System.Drawing.Point(144, 423);
            this.txtGL.Name = "txtGL";
            this.txtGL.Size = new System.Drawing.Size(236, 26);
            this.txtGL.TabIndex = 75;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(144, 372);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(236, 26);
            this.txtBank.TabIndex = 75;
            // 
            // txtCreditOfficer
            // 
            this.txtCreditOfficer.Location = new System.Drawing.Point(144, 283);
            this.txtCreditOfficer.Name = "txtCreditOfficer";
            this.txtCreditOfficer.Size = new System.Drawing.Size(236, 26);
            this.txtCreditOfficer.TabIndex = 75;
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Location = new System.Drawing.Point(144, 231);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(236, 26);
            this.txtSerialNo.TabIndex = 73;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 166);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 26);
            this.txtName.TabIndex = 74;
            // 
            // txtSubcategory
            // 
            this.txtSubcategory.Location = new System.Drawing.Point(144, 97);
            this.txtSubcategory.Name = "txtSubcategory";
            this.txtSubcategory.Size = new System.Drawing.Size(236, 26);
            this.txtSubcategory.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 427);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 69;
            this.label12.Text = "GL:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Bank:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(144, 35);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(236, 26);
            this.txtCategory.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 20);
            this.label10.TabIndex = 69;
            this.label10.Text = "Credit Officer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Serial No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Sub Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 66;
            this.label1.Text = "Category:";
            // 
            // btnCategory
            // 
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.Location = new System.Drawing.Point(402, 33);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(30, 31);
            this.btnCategory.TabIndex = 78;
            this.btnCategory.Text = "...";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnSubcategory
            // 
            this.btnSubcategory.FlatAppearance.BorderSize = 0;
            this.btnSubcategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubcategory.Image = ((System.Drawing.Image)(resources.GetObject("btnSubcategory.Image")));
            this.btnSubcategory.Location = new System.Drawing.Point(402, 94);
            this.btnSubcategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubcategory.Name = "btnSubcategory";
            this.btnSubcategory.Size = new System.Drawing.Size(30, 31);
            this.btnSubcategory.TabIndex = 77;
            this.btnSubcategory.Text = "...";
            this.btnSubcategory.UseVisualStyleBackColor = true;
            this.btnSubcategory.Click += new System.EventHandler(this.btnSubcategory_Click);
            // 
            // btnBank
            // 
            this.btnBank.FlatAppearance.BorderSize = 0;
            this.btnBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBank.Image = ((System.Drawing.Image)(resources.GetObject("btnBank.Image")));
            this.btnBank.Location = new System.Drawing.Point(402, 371);
            this.btnBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBank.Name = "btnBank";
            this.btnBank.Size = new System.Drawing.Size(30, 31);
            this.btnBank.TabIndex = 76;
            this.btnBank.Text = "...";
            this.btnBank.UseVisualStyleBackColor = true;
            this.btnBank.Click += new System.EventHandler(this.btnBank_Click);
            // 
            // btnCreditOfficer
            // 
            this.btnCreditOfficer.FlatAppearance.BorderSize = 0;
            this.btnCreditOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditOfficer.Image = ((System.Drawing.Image)(resources.GetObject("btnCreditOfficer.Image")));
            this.btnCreditOfficer.Location = new System.Drawing.Point(402, 282);
            this.btnCreditOfficer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreditOfficer.Name = "btnCreditOfficer";
            this.btnCreditOfficer.Size = new System.Drawing.Size(30, 31);
            this.btnCreditOfficer.TabIndex = 76;
            this.btnCreditOfficer.Text = "...";
            this.btnCreditOfficer.UseVisualStyleBackColor = true;
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
            // frmAssetRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmAssetRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asset  Registration";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbdepreciationmethod;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.DateTimePicker dtpDepEndDate;
        private System.Windows.Forms.DateTimePicker dtpDepStart;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnSubcategory;
        private System.Windows.Forms.Button btnCreditOfficer;
        private System.Windows.Forms.TextBox txtCreditOfficer;
        private System.Windows.Forms.TextBox txtSerialNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSubcategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.Button btnBank;
        private System.Windows.Forms.TextBox txtGL;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}