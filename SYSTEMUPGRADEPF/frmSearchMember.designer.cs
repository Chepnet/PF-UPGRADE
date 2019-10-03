namespace SYSTEMUPGRADEPF
{
    partial class frmSearchMember
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
            this.objListMember = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnMemberNo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIdNo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnMemberName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRegDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnClientClassification = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStationName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListMember)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListMember
            // 
            this.objListMember.AllColumns.Add(this.olvColumnMemberNo);
            this.objListMember.AllColumns.Add(this.olvColumnIdNo);
            this.objListMember.AllColumns.Add(this.olvColumnMemberName);
            this.objListMember.AllColumns.Add(this.olvColumnRegDate);
            this.objListMember.AllColumns.Add(this.olvColumnPhoneNumber);
            this.objListMember.AllColumns.Add(this.olvColumn9);
            this.objListMember.AllColumns.Add(this.olvColumnClientClassification);
            this.objListMember.AllColumns.Add(this.olvColumnStationName);
            this.objListMember.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objListMember.CellEditUseWholeCell = false;
            this.objListMember.CheckBoxes = true;
            this.objListMember.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnMemberNo,
            this.olvColumnIdNo,
            this.olvColumnMemberName,
            this.olvColumnRegDate,
            this.olvColumnPhoneNumber,
            this.olvColumn9,
            this.olvColumnClientClassification,
            this.olvColumnStationName});
            this.objListMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListMember.FullRowSelect = true;
            this.objListMember.GridLines = true;
            this.objListMember.HideSelection = false;
            this.objListMember.Location = new System.Drawing.Point(0, 0);
            this.objListMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListMember.Name = "objListMember";
            this.objListMember.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.objListMember.ShowGroups = false;
            this.objListMember.Size = new System.Drawing.Size(1172, 584);
            this.objListMember.TabIndex = 0;
            this.objListMember.UseAlternatingBackColors = true;
            this.objListMember.UseCompatibleStateImageBehavior = false;
            this.objListMember.View = System.Windows.Forms.View.Details;
            this.objListMember.SelectedIndexChanged += new System.EventHandler(this.objListMember_SelectedIndexChanged);
            this.objListMember.DoubleClick += new System.EventHandler(this.objListMembers_DoubleClick);
            // 
            // olvColumnMemberNo
            // 
            this.olvColumnMemberNo.AspectName = "MemberNo";
            this.olvColumnMemberNo.Text = "Member No";
            this.olvColumnMemberNo.Width = 80;
            // 
            // olvColumnIdNo
            // 
            this.olvColumnIdNo.AspectName = "IdNumber";
            this.olvColumnIdNo.Text = "Id Number";
            this.olvColumnIdNo.Width = 80;
            // 
            // olvColumnMemberName
            // 
            this.olvColumnMemberName.AspectName = "MemberName";
            this.olvColumnMemberName.Text = "Member Name";
            this.olvColumnMemberName.Width = 160;
            // 
            // olvColumnRegDate
            // 
            this.olvColumnRegDate.AspectName = "RegDate";
            this.olvColumnRegDate.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumnRegDate.Text = "Reg Date";
            this.olvColumnRegDate.Width = 105;
            // 
            // olvColumnPhoneNumber
            // 
            this.olvColumnPhoneNumber.AspectName = "PhoneNumber";
            this.olvColumnPhoneNumber.Text = "Phone Number";
            this.olvColumnPhoneNumber.Width = 129;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "IsActive";
            this.olvColumn9.Text = "Is Active";
            // 
            // olvColumnClientClassification
            // 
            this.olvColumnClientClassification.AspectName = "ClientClassificationName";
            this.olvColumnClientClassification.Text = "Client Classification";
            this.olvColumnClientClassification.Width = 100;
            // 
            // olvColumnStationName
            // 
            this.olvColumnStationName.AspectName = "StationName";
            this.olvColumnStationName.Text = "Station";
            this.olvColumnStationName.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(983, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 51);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Create New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSearchMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1172, 646);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListMember);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchMember";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Member";
            this.Load += new System.EventHandler(this.frmSearchMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListMember)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListMember;
        private BrightIdeasSoftware.OLVColumn olvColumnIdNo;
        private BrightIdeasSoftware.OLVColumn olvColumnMemberName;
        private BrightIdeasSoftware.OLVColumn olvColumnRegDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPhoneNumber;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumnClientClassification;
        private BrightIdeasSoftware.OLVColumn olvColumnStationName;
        private BrightIdeasSoftware.OLVColumn olvColumnMemberNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
    }
}