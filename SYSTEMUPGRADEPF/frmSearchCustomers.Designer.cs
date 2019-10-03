namespace SYSTEMUPGRADEPF
{
    partial class frmSearchCustomers
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
            this.objListCustomers = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPickingValues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListCustomers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListCustomers
            // 
            this.objListCustomers.AllColumns.Add(this.olvColumn1);
            this.objListCustomers.AllColumns.Add(this.olvColumn2);
            this.objListCustomers.AllColumns.Add(this.olvColumn3);
            this.objListCustomers.AllColumns.Add(this.olvColumn4);
            this.objListCustomers.AllColumns.Add(this.olvColumn5);
            this.objListCustomers.AllColumns.Add(this.olvColumn6);
            this.objListCustomers.CellEditUseWholeCell = false;
            this.objListCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.objListCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.objListCustomers.FullRowSelect = true;
            this.objListCustomers.GridLines = true;
            this.objListCustomers.HideSelection = false;
            this.objListCustomers.Location = new System.Drawing.Point(0, 0);
            this.objListCustomers.Name = "objListCustomers";
            this.objListCustomers.ShowGroups = false;
            this.objListCustomers.Size = new System.Drawing.Size(1243, 508);
            this.objListCustomers.TabIndex = 0;
            this.objListCustomers.UseAlternatingBackColors = true;
            this.objListCustomers.UseCompatibleStateImageBehavior = false;
            this.objListCustomers.View = System.Windows.Forms.View.Details;
            this.objListCustomers.SelectedIndexChanged += new System.EventHandler(this.objListCustomers_SelectedIndexChanged);
            this.objListCustomers.DoubleClick += new System.EventHandler(this.objListCustomers_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "CustomerNo";
            this.olvColumn1.Text = "Customer No";
            this.olvColumn1.Width = 162;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "CustomerName";
            this.olvColumn2.Text = "Customer Name";
            this.olvColumn2.Width = 177;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "MobileNo";
            this.olvColumn3.Text = "Mobile No";
            this.olvColumn3.Width = 157;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "County";
            this.olvColumn4.Text = "County";
            this.olvColumn4.Width = 122;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ContactPersonName";
            this.olvColumn5.Text = " Contact Person Name";
            this.olvColumn5.Width = 209;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Email";
            this.olvColumn6.Text = "Email";
            this.olvColumn6.Width = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPickingValues);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnPickingValues
            // 
            this.btnPickingValues.Location = new System.Drawing.Point(1099, 13);
            this.btnPickingValues.Name = "btnPickingValues";
            this.btnPickingValues.Size = new System.Drawing.Size(144, 34);
            this.btnPickingValues.TabIndex = 0;
            this.btnPickingValues.Text = "Picking Values";
            this.btnPickingValues.UseVisualStyleBackColor = true;
            this.btnPickingValues.Click += new System.EventHandler(this.btnPickingValues_Click);
            // 
            // frmSearchCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListCustomers);
            this.Name = "frmSearchCustomers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Customer";
            this.Load += new System.EventHandler(this.frmSearchCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPickingValues;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
    }
}