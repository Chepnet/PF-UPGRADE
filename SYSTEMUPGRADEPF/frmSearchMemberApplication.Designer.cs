namespace SYSTEMUPGRADEPF
{
    partial class frmSearchMemberApplication
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
            this.olvColumnMemberName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIdNo = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnRegDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnEmployer = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnStation = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnClientclassifaction = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnIsActive = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.objList = new BrightIdeasSoftware.ObjectListView();
            ((System.ComponentModel.ISupportInitialize)(this.objList)).BeginInit();
            this.SuspendLayout();
            // 
            // olvColumnMemberName
            // 
            this.olvColumnMemberName.AspectName = "MemberName";
            this.olvColumnMemberName.Text = "Member";
            this.olvColumnMemberName.Width = 150;
            // 
            // olvColumnIdNo
            // 
            this.olvColumnIdNo.AspectName = "IdNumber";
            this.olvColumnIdNo.Text = "Id Number";
            this.olvColumnIdNo.Width = 80;
            // 
            // olvColumnRegDate
            // 
            this.olvColumnRegDate.AspectName = "RegDate";
            this.olvColumnRegDate.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumnRegDate.Text = "Registration Date";
            this.olvColumnRegDate.Width = 100;
            // 
            // olvColumnPhone
            // 
            this.olvColumnPhone.AspectName = "PhoneNo";
            this.olvColumnPhone.Text = "Phone Number";
            this.olvColumnPhone.Width = 100;
            // 
            // olvColumnEmployer
            // 
            this.olvColumnEmployer.AspectName = "EmployerName";
            this.olvColumnEmployer.Text = "Employer";
            this.olvColumnEmployer.Width = 80;
            // 
            // olvColumnStation
            // 
            this.olvColumnStation.AspectName = "StationName";
            this.olvColumnStation.Text = "Station";
            this.olvColumnStation.Width = 80;
            // 
            // olvColumnClientclassifaction
            // 
            this.olvColumnClientclassifaction.AspectName = "ClientClassificationName";
            this.olvColumnClientclassifaction.Text = "Client Classification";
            this.olvColumnClientclassifaction.Width = 125;
            // 
            // olvColumnIsActive
            // 
            this.olvColumnIsActive.AspectName = "IsActive";
            this.olvColumnIsActive.Text = "Is Active";
            // 
            // objList
            // 
            this.objList.AllColumns.Add(this.olvColumnMemberName);
            this.objList.AllColumns.Add(this.olvColumnIdNo);
            this.objList.AllColumns.Add(this.olvColumnRegDate);
            this.objList.AllColumns.Add(this.olvColumnPhone);
            this.objList.AllColumns.Add(this.olvColumnEmployer);
            this.objList.AllColumns.Add(this.olvColumnStation);
            this.objList.AllColumns.Add(this.olvColumnClientclassifaction);
            this.objList.AllColumns.Add(this.olvColumnIsActive);
            this.objList.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objList.CellEditUseWholeCell = false;
            this.objList.CheckBoxes = true;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnMemberName,
            this.olvColumnIdNo,
            this.olvColumnRegDate,
            this.olvColumnPhone,
            this.olvColumnEmployer,
            this.olvColumnStation,
            this.olvColumnClientclassifaction,
            this.olvColumnIsActive});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.HideSelection = false;
            this.objList.Location = new System.Drawing.Point(0, 0);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(1240, 708);
            this.objList.TabIndex = 0;
            this.objList.UseAlternatingBackColors = true;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.DoubleClick += new System.EventHandler(this.objList_DoubleClick);
            // 
            // frmSearchMemberApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 708);
            this.Controls.Add(this.objList);
            this.Name = "frmSearchMemberApplication";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Member Application";
            this.Load += new System.EventHandler(this.frmSearchMemberApplication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.OLVColumn olvColumnMemberName;
        private BrightIdeasSoftware.OLVColumn olvColumnIdNo;
        private BrightIdeasSoftware.OLVColumn olvColumnRegDate;
        private BrightIdeasSoftware.OLVColumn olvColumnPhone;
        private BrightIdeasSoftware.OLVColumn olvColumnEmployer;
        private BrightIdeasSoftware.OLVColumn olvColumnStation;
        private BrightIdeasSoftware.OLVColumn olvColumnClientclassifaction;
        private BrightIdeasSoftware.OLVColumn olvColumnIsActive;
        private BrightIdeasSoftware.ObjectListView objList;
    }
}