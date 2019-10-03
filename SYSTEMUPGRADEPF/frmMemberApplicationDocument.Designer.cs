namespace SYSTEMUPGRADEPF
{
    partial class frmMemberApplicationDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberApplicationDocument));
            this.btnSearchDocumentTypeid = new System.Windows.Forms.Button();
            this.btnSearchMemberApplicationId = new System.Windows.Forms.Button();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            this.txtDocumentType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtMemberApplicationId = new System.Windows.Forms.TextBox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.lblMemberApplication = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchDocumentTypeid
            // 
            this.btnSearchDocumentTypeid.FlatAppearance.BorderSize = 0;
            this.btnSearchDocumentTypeid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDocumentTypeid.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDocumentTypeid.Image")));
            this.btnSearchDocumentTypeid.Location = new System.Drawing.Point(592, 117);
            this.btnSearchDocumentTypeid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchDocumentTypeid.Name = "btnSearchDocumentTypeid";
            this.btnSearchDocumentTypeid.Size = new System.Drawing.Size(50, 35);
            this.btnSearchDocumentTypeid.TabIndex = 3;
            this.btnSearchDocumentTypeid.Text = "...";
            this.btnSearchDocumentTypeid.UseVisualStyleBackColor = true;
            this.btnSearchDocumentTypeid.Click += new System.EventHandler(this.btnSearchDocumentTypeid_Click);
            // 
            // btnSearchMemberApplicationId
            // 
            this.btnSearchMemberApplicationId.FlatAppearance.BorderSize = 0;
            this.btnSearchMemberApplicationId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchMemberApplicationId.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchMemberApplicationId.Image")));
            this.btnSearchMemberApplicationId.Location = new System.Drawing.Point(592, 69);
            this.btnSearchMemberApplicationId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchMemberApplicationId.Name = "btnSearchMemberApplicationId";
            this.btnSearchMemberApplicationId.Size = new System.Drawing.Size(50, 35);
            this.btnSearchMemberApplicationId.TabIndex = 1;
            this.btnSearchMemberApplicationId.UseVisualStyleBackColor = true;
            this.btnSearchMemberApplicationId.Click += new System.EventHandler(this.btnSearchMemberApplicationId_Click);
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPhoto.Location = new System.Drawing.Point(177, 204);
            this.ptbPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(194, 124);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPhoto.TabIndex = 21;
            this.ptbPhoto.TabStop = false;
            this.ptbPhoto.Click += new System.EventHandler(this.ptbPhoto_Click);
            // 
            // txtDocumentType
            // 
            this.txtDocumentType.Location = new System.Drawing.Point(177, 119);
            this.txtDocumentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocumentType.Name = "txtDocumentType";
            this.txtDocumentType.ReadOnly = true;
            this.txtDocumentType.Size = new System.Drawing.Size(420, 26);
            this.txtDocumentType.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(177, 168);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 26);
            this.txtDescription.TabIndex = 4;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(177, 350);
            this.chkIsActive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(95, 24);
            this.chkIsActive.TabIndex = 18;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtMemberApplicationId
            // 
            this.txtMemberApplicationId.Location = new System.Drawing.Point(177, 73);
            this.txtMemberApplicationId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMemberApplicationId.Name = "txtMemberApplicationId";
            this.txtMemberApplicationId.ReadOnly = true;
            this.txtMemberApplicationId.Size = new System.Drawing.Size(420, 26);
            this.txtMemberApplicationId.TabIndex = 0;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Location = new System.Drawing.Point(14, 239);
            this.lblPhoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(55, 20);
            this.lblPhoto.TabIndex = 16;
            this.lblPhoto.Text = "Photo:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(16, 171);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Description:";
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(14, 124);
            this.lblDocumentType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(125, 20);
            this.lblDocumentType.TabIndex = 14;
            this.lblDocumentType.Text = "Document Type:";
            // 
            // lblMemberApplication
            // 
            this.lblMemberApplication.AutoSize = true;
            this.lblMemberApplication.Location = new System.Drawing.Point(16, 76);
            this.lblMemberApplication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemberApplication.Name = "lblMemberApplication";
            this.lblMemberApplication.Size = new System.Drawing.Size(153, 20);
            this.lblMemberApplication.TabIndex = 13;
            this.lblMemberApplication.Text = "Member Application:";
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
            this.DeleteToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(672, 31);
            this.toolStrip1.TabIndex = 12;
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
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.DeleteToolStripButton.Text = "&Delete";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // frmMemberApplicationDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 412);
            this.Controls.Add(this.btnSearchDocumentTypeid);
            this.Controls.Add(this.btnSearchMemberApplicationId);
            this.Controls.Add(this.ptbPhoto);
            this.Controls.Add(this.txtDocumentType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtMemberApplicationId);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDocumentType);
            this.Controls.Add(this.lblMemberApplication);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "frmMemberApplicationDocument";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Application Document";
            this.Load += new System.EventHandler(this.frmMemberApplicationDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDocumentTypeid;
        private System.Windows.Forms.Button btnSearchMemberApplicationId;
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.TextBox txtDocumentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtMemberApplicationId;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.Label lblMemberApplication;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton DeleteToolStripButton;
    }
}