namespace SYSTEMUPGRADEPF
{
    partial class frmSearchChartOfAccounts
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
            this.objListChart = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListChart
            // 
            this.objListChart.AllColumns.Add(this.olvColumn1);
            this.objListChart.AllColumns.Add(this.olvColumn2);
            this.objListChart.AllColumns.Add(this.olvColumn3);
            this.objListChart.AllColumns.Add(this.olvColumn4);
            this.objListChart.AllColumns.Add(this.olvColumn5);
            this.objListChart.AllColumns.Add(this.olvColumn6);
            this.objListChart.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListChart.CellEditUseWholeCell = false;
            this.objListChart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.objListChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.objListChart.FullRowSelect = true;
            this.objListChart.GridLines = true;
            this.objListChart.HideSelection = false;
            this.objListChart.Location = new System.Drawing.Point(0, 0);
            this.objListChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListChart.MultiSelect = false;
            this.objListChart.Name = "objListChart";
            this.objListChart.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.objListChart.ShowGroups = false;
            this.objListChart.Size = new System.Drawing.Size(1299, 615);
            this.objListChart.TabIndex = 0;
            this.objListChart.UseAlternatingBackColors = true;
            this.objListChart.UseCompatibleStateImageBehavior = false;
            this.objListChart.View = System.Windows.Forms.View.Details;
            this.objListChart.SelectedIndexChanged += new System.EventHandler(this.objectListView1_SelectedIndexChanged);
            this.objListChart.DoubleClick += new System.EventHandler(this.objectListView1_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "AccountName";
            this.olvColumn1.Text = "Account Name";
            this.olvColumn1.Width = 130;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "AccountCode";
            this.olvColumn2.Text = "Account Code";
            this.olvColumn2.Width = 120;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "AccountType";
            this.olvColumn3.Text = "Account Type";
            this.olvColumn3.Width = 120;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "AccountCategory";
            this.olvColumn4.Text = "Is Active";
            this.olvColumn4.Width = 125;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "AllowDirectPosting";
            this.olvColumn5.Text = "Direct Posting";
            this.olvColumn5.Width = 120;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "SearchName";
            this.olvColumn6.Text = "Search Name";
            this.olvColumn6.Width = 120;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 623);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(1019, 14);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(184, 38);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // frmSearchChartOfAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1299, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListChart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchChartOfAccounts";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Chart Of Accounts";
            this.Load += new System.EventHandler(this.frmSearchChartOfAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListChart;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
    }
}