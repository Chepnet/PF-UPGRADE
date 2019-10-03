namespace SYSTEMUPGRADEPF
{
    partial class frmSearchKin
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
            this.objListKin = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListKin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListKin
            // 
            this.objListKin.AllColumns.Add(this.olvColumn1);
            this.objListKin.AllColumns.Add(this.olvColumn3);
            this.objListKin.AllColumns.Add(this.olvColumn5);
            this.objListKin.AllColumns.Add(this.olvColumn9);
            this.objListKin.AllColumns.Add(this.olvColumn8);
            this.objListKin.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListKin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objListKin.CellEditUseWholeCell = false;
            this.objListKin.CheckBoxes = true;
            this.objListKin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn5,
            this.olvColumn9,
            this.olvColumn8});
            this.objListKin.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListKin.FullRowSelect = true;
            this.objListKin.GridLines = true;
            this.objListKin.HideSelection = false;
            this.objListKin.Location = new System.Drawing.Point(0, 0);
            this.objListKin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListKin.Name = "objListKin";
            this.objListKin.SelectedBackColor = System.Drawing.SystemColors.Highlight;
            this.objListKin.ShowGroups = false;
            this.objListKin.Size = new System.Drawing.Size(1037, 539);
            this.objListKin.TabIndex = 0;
            this.objListKin.UseAlternatingBackColors = true;
            this.objListKin.UseCompatibleStateImageBehavior = false;
            this.objListKin.View = System.Windows.Forms.View.Details;
            this.objListKin.SelectedIndexChanged += new System.EventHandler(this.objListKin_SelectedIndexChanged);
            this.objListKin.DoubleClick += new System.EventHandler(this.objListKin_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MemberName";
            this.olvColumn1.Text = "Member";
            this.olvColumn1.Width = 180;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "KinName";
            this.olvColumn3.Text = "Kin Name";
            this.olvColumn3.Width = 110;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "MobileNumber";
            this.olvColumn5.Text = "Mobile No";
            this.olvColumn5.Width = 80;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "RelationshipName";
            this.olvColumn9.DisplayIndex = 4;
            this.olvColumn9.Text = "Relationship";
            this.olvColumn9.Width = 100;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Description";
            this.olvColumn8.DisplayIndex = 3;
            this.olvColumn8.Text = "Document Type";
            this.olvColumn8.Width = 133;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 62);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(879, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchKin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListKin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchKin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Kin";
            this.Load += new System.EventHandler(this.frmSearchKin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListKin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListKin;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}