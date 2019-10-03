namespace SYSTEMUPGRADEPF
{
    partial class frmSearchFixedDeposit
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
            this.objListFixedDeposit = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListFixedDeposit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListFixedDeposit
            // 
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn1);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn2);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn3);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn4);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn5);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn6);
            this.objListFixedDeposit.AllColumns.Add(this.olvColumn7);
            this.objListFixedDeposit.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListFixedDeposit.CellEditUseWholeCell = false;
            this.objListFixedDeposit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6,
            this.olvColumn7});
            this.objListFixedDeposit.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListFixedDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.objListFixedDeposit.FullRowSelect = true;
            this.objListFixedDeposit.GridLines = true;
            this.objListFixedDeposit.HideSelection = false;
            this.objListFixedDeposit.Location = new System.Drawing.Point(0, 0);
            this.objListFixedDeposit.Name = "objListFixedDeposit";
            this.objListFixedDeposit.ShowGroups = false;
            this.objListFixedDeposit.Size = new System.Drawing.Size(1269, 568);
            this.objListFixedDeposit.TabIndex = 0;
            this.objListFixedDeposit.UseAlternatingBackColors = true;
            this.objListFixedDeposit.UseCompatibleStateImageBehavior = false;
            this.objListFixedDeposit.View = System.Windows.Forms.View.Details;
            this.objListFixedDeposit.SelectedIndexChanged += new System.EventHandler(this.objListFixedDeposit_SelectedIndexChanged);
            this.objListFixedDeposit.DoubleClick += new System.EventHandler(this.objListFixedDeposit_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MemberName";
            this.olvColumn1.Text = "Member";
            this.olvColumn1.Width = 105;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ProductName";
            this.olvColumn2.Text = "Product";
            this.olvColumn2.Width = 110;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "BookingDate";
            this.olvColumn3.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumn3.Text = "Booking Date";
            this.olvColumn3.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Amount";
            this.olvColumn4.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn4.Text = "Amount";
            this.olvColumn4.Width = 100;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "NoOfDays";
            this.olvColumn5.Text = "No Of Days";
            this.olvColumn5.Width = 100;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "MaturityDate";
            this.olvColumn6.AspectToStringFormat = "{0:dd-MMM-yyyy}";
            this.olvColumn6.Text = " Maturity Date";
            this.olvColumn6.Width = 100;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "ProductName";
            this.olvColumn7.Text = "Maturity A/c";
            this.olvColumn7.Width = 100;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 574);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(1088, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(178, 40);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // frmSearchFixedDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListFixedDeposit);
            this.Name = "frmSearchFixedDeposit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Fixed Deposit";
            this.Load += new System.EventHandler(this.frmSearchFixedDeposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListFixedDeposit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListFixedDeposit;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
    }
}