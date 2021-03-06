namespace SYSTEMUPGRADEPF
{
    partial class frmSearchOtherCharges
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
            this.objList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objList)).BeginInit();
            this.SuspendLayout();
            // 
            // objList
            // 
            this.objList.AllColumns.Add(this.olvColumn2);
            this.objList.AllColumns.Add(this.olvColumn4);
            this.objList.AllColumns.Add(this.olvColumn1);
            this.objList.AllColumns.Add(this.olvColumn3);
            this.objList.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objList.CellEditUseWholeCell = false;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn2,
            this.olvColumn4,
            this.olvColumn1,
            this.olvColumn3});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.HideSelection = false;
            this.objList.Location = new System.Drawing.Point(0, 0);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(971, 418);
            this.objList.TabIndex = 0;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.DoubleClick += new System.EventHandler(this.objList_DoubleClick);
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ProductName";
            this.olvColumn2.Text = "Product";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "LoanTypeName";
            this.olvColumn4.DisplayIndex = 3;
            this.olvColumn4.Text = "Loan Type ";
            this.olvColumn4.Width = 123;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "AccounttName";
            this.olvColumn1.DisplayIndex = 1;
            this.olvColumn1.Text = "Account Name";
            this.olvColumn1.Width = 120;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Amount";
            this.olvColumn3.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn3.DisplayIndex = 2;
            this.olvColumn3.Text = "Amount";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn3.Width = 100;
            // 
            // frmSearchOtherCharges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 418);
            this.Controls.Add(this.objList);
            this.Name = "frmSearchOtherCharges";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Other Charges";
            this.Load += new System.EventHandler(this.frmSearchOtherCharges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
    }
}