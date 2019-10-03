namespace SYSTEMUPGRADEPF
{
    partial class frmSearchBen
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
            this.objListBen = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objListBen)).BeginInit();
            this.SuspendLayout();
            // 
            // objListBen
            // 
            this.objListBen.AllColumns.Add(this.olvColumn1);
            this.objListBen.AllColumns.Add(this.olvColumn3);
            this.objListBen.AllColumns.Add(this.olvColumn4);
            this.objListBen.AllColumns.Add(this.olvColumn9);
            this.objListBen.AllColumns.Add(this.olvColumn6);
            this.objListBen.AllColumns.Add(this.olvColumn2);
            this.objListBen.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListBen.CellEditUseWholeCell = false;
            this.objListBen.CheckBoxes = true;
            this.objListBen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn9,
            this.olvColumn6,
            this.olvColumn2});
            this.objListBen.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListBen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objListBen.FullRowSelect = true;
            this.objListBen.GridLines = true;
            this.objListBen.HideSelection = false;
            this.objListBen.Location = new System.Drawing.Point(0, 0);
            this.objListBen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListBen.Name = "objListBen";
            this.objListBen.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.objListBen.ShowGroups = false;
            this.objListBen.Size = new System.Drawing.Size(1089, 686);
            this.objListBen.TabIndex = 0;
            this.objListBen.UseAlternatingBackColors = true;
            this.objListBen.UseCompatibleStateImageBehavior = false;
            this.objListBen.View = System.Windows.Forms.View.Details;
            this.objListBen.SelectedIndexChanged += new System.EventHandler(this.objListBen_SelectedIndexChanged);
            this.objListBen.DoubleClick += new System.EventHandler(this.objListBen_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MemberName";
            this.olvColumn1.Text = "Member";
            this.olvColumn1.Width = 180;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "BenName";
            this.olvColumn3.Text = "Ben Name";
            this.olvColumn3.Width = 130;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "RelationshipName";
            this.olvColumn4.Text = "Relationship";
            this.olvColumn4.Width = 80;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "Description";
            this.olvColumn9.Text = "Document Type";
            this.olvColumn9.Width = 100;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "MobileNumber";
            this.olvColumn6.Text = "Mobile No";
            this.olvColumn6.Width = 100;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "PercentageValue";
            this.olvColumn2.Text = "Percentage(%)";
            this.olvColumn2.Width = 128;
            // 
            // frmSearchBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 686);
            this.Controls.Add(this.objListBen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchBen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Ben";
            this.Load += new System.EventHandler(this.frmSearchBen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListBen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListBen;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}