namespace SYSTEMUPGRADEPF
{
    partial class frmSearchLoanTypeCollateral
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
            this.objListCollaterals = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListCollaterals)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListCollaterals
            // 
            this.objListCollaterals.AllColumns.Add(this.olvColumn4);
            this.objListCollaterals.AllColumns.Add(this.olvColumn5);
            this.objListCollaterals.AllColumns.Add(this.olvColumn6);
            this.objListCollaterals.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListCollaterals.CellEditUseWholeCell = false;
            this.objListCollaterals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn6});
            this.objListCollaterals.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListCollaterals.FullRowSelect = true;
            this.objListCollaterals.GridLines = true;
            this.objListCollaterals.HideSelection = false;
            this.objListCollaterals.Location = new System.Drawing.Point(0, 0);
            this.objListCollaterals.Name = "objListCollaterals";
            this.objListCollaterals.ShowGroups = false;
            this.objListCollaterals.Size = new System.Drawing.Size(1046, 306);
            this.objListCollaterals.TabIndex = 1;
            this.objListCollaterals.UseCompatibleStateImageBehavior = false;
            this.objListCollaterals.View = System.Windows.Forms.View.Details;
            this.objListCollaterals.SelectedIndexChanged += new System.EventHandler(this.objListCollaterals_SelectedIndexChanged);
            this.objListCollaterals.DoubleClick += new System.EventHandler(this.objListCollaterals_DoubleClick);
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "LoanName";
            this.olvColumn4.Text = " Loan Name";
            this.olvColumn4.Width = 150;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Description";
            this.olvColumn5.Text = "Description";
            this.olvColumn5.Width = 150;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "IsActive";
            this.olvColumn6.Text = "Is Active";
            this.olvColumn6.Width = 115;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Location = new System.Drawing.Point(0, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 40);
            this.panel1.TabIndex = 2;
            // 
            // btnAddNew
            // 
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Location = new System.Drawing.Point(818, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(228, 34);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.Text = "Add New..";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchLoanTypeCollateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListCollaterals);
            this.Name = "frmSearchLoanTypeCollateral";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Search Loan Type Collaterals";
            this.Load += new System.EventHandler(this.frmSearchLoanTypeCollateral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListCollaterals)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListCollaterals;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNew;
    }
}