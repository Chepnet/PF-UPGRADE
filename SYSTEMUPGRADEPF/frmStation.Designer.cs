namespace SYSTEMUPGRADEPF
{
    partial class frmStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStation));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblStationCode = new System.Windows.Forms.Label();
            this.lblStationName = new System.Windows.Forms.Label();
            this.lblStationAddress = new System.Windows.Forms.Label();
            this.txtStationCode = new System.Windows.Forms.TextBox();
            this.txtStationName = new System.Windows.Forms.TextBox();
            this.txtStationAddress = new System.Windows.Forms.TextBox();
            this.btnSearchEmployer = new System.Windows.Forms.Button();
            this.txtEmployerId = new System.Windows.Forms.TextBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator2,
            this.toolStripPrevious,
            this.toolStripNext,
            this.toolStripSeparator1,
            this.deleteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 31);
            this.toolStrip1.TabIndex = 0;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripPrevious
            // 
            this.toolStripPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevious.Image")));
            this.toolStripPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrevious.Name = "toolStripPrevious";
            this.toolStripPrevious.Size = new System.Drawing.Size(28, 28);
            this.toolStripPrevious.Text = "&Previous";
            this.toolStripPrevious.Click += new System.EventHandler(this.toolStripPrevious_Click);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolStripButton.Image = global::SYSTEMUPGRADEPF.Properties.Resources.delete_16x;
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.deleteToolStripButton.Text = "&Delete";
            this.deleteToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // lblStationCode
            // 
            this.lblStationCode.AutoSize = true;
            this.lblStationCode.Location = new System.Drawing.Point(20, 131);
            this.lblStationCode.Name = "lblStationCode";
            this.lblStationCode.Size = new System.Drawing.Size(110, 20);
            this.lblStationCode.TabIndex = 1;
            this.lblStationCode.Text = " Station Code:";
            // 
            // lblStationName
            // 
            this.lblStationName.AutoSize = true;
            this.lblStationName.Location = new System.Drawing.Point(20, 198);
            this.lblStationName.Name = "lblStationName";
            this.lblStationName.Size = new System.Drawing.Size(114, 20);
            this.lblStationName.TabIndex = 2;
            this.lblStationName.Text = " Station Name:";
            // 
            // lblStationAddress
            // 
            this.lblStationAddress.AutoSize = true;
            this.lblStationAddress.Location = new System.Drawing.Point(20, 265);
            this.lblStationAddress.Name = "lblStationAddress";
            this.lblStationAddress.Size = new System.Drawing.Size(131, 20);
            this.lblStationAddress.TabIndex = 5;
            this.lblStationAddress.Text = " Station Address:";
            // 
            // txtStationCode
            // 
            this.txtStationCode.Location = new System.Drawing.Point(162, 128);
            this.txtStationCode.Name = "txtStationCode";
            this.txtStationCode.Size = new System.Drawing.Size(370, 26);
            this.txtStationCode.TabIndex = 2;
            this.txtStationCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStationCode_KeyDown);
            // 
            // txtStationName
            // 
            this.txtStationName.Location = new System.Drawing.Point(162, 195);
            this.txtStationName.Name = "txtStationName";
            this.txtStationName.Size = new System.Drawing.Size(370, 26);
            this.txtStationName.TabIndex = 3;
            this.txtStationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStationName_KeyDown);
            // 
            // txtStationAddress
            // 
            this.txtStationAddress.Location = new System.Drawing.Point(162, 262);
            this.txtStationAddress.Name = "txtStationAddress";
            this.txtStationAddress.Size = new System.Drawing.Size(370, 26);
            this.txtStationAddress.TabIndex = 4;
            // 
            // btnSearchEmployer
            // 
            this.btnSearchEmployer.AutoSize = true;
            this.btnSearchEmployer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearchEmployer.FlatAppearance.BorderSize = 0;
            this.btnSearchEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchEmployer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchEmployer.Image")));
            this.btnSearchEmployer.Location = new System.Drawing.Point(548, 56);
            this.btnSearchEmployer.Name = "btnSearchEmployer";
            this.btnSearchEmployer.Size = new System.Drawing.Size(43, 37);
            this.btnSearchEmployer.TabIndex = 1;
            this.btnSearchEmployer.UseVisualStyleBackColor = true;
            this.btnSearchEmployer.Click += new System.EventHandler(this.btnSearchEmployer_Click);
            // 
            // txtEmployerId
            // 
            this.txtEmployerId.Location = new System.Drawing.Point(162, 61);
            this.txtEmployerId.Name = "txtEmployerId";
            this.txtEmployerId.ReadOnly = true;
            this.txtEmployerId.Size = new System.Drawing.Size(370, 26);
            this.txtEmployerId.TabIndex = 0;
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.Location = new System.Drawing.Point(20, 64);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(83, 20);
            this.lblEmployer.TabIndex = 50;
            this.lblEmployer.Text = " Employer:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(162, 313);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(95, 24);
            this.chkIsActive.TabIndex = 5;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            this.chkIsActive.CheckedChanged += new System.EventHandler(this.chkIsActive_CheckedChanged);
            // 
            // frmStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(648, 367);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.btnSearchEmployer);
            this.Controls.Add(this.txtEmployerId);
            this.Controls.Add(this.lblEmployer);
            this.Controls.Add(this.txtStationAddress);
            this.Controls.Add(this.txtStationName);
            this.Controls.Add(this.txtStationCode);
            this.Controls.Add(this.lblStationAddress);
            this.Controls.Add(this.lblStationName);
            this.Controls.Add(this.lblStationCode);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmStation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Station";
            this.Load += new System.EventHandler(this.frmStation_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteToolStripButton;
        private System.Windows.Forms.Label lblStationCode;
        private System.Windows.Forms.Label lblStationName;
        private System.Windows.Forms.Label lblStationAddress;
        private System.Windows.Forms.TextBox txtStationCode;
        private System.Windows.Forms.TextBox txtStationName;
        private System.Windows.Forms.TextBox txtStationAddress;
        private System.Windows.Forms.Button btnSearchEmployer;
        private System.Windows.Forms.TextBox txtEmployerId;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}