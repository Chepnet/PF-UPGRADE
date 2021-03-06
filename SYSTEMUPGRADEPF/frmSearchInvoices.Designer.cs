namespace SYSTEMUPGRADEPF
{
    partial class frmSearchInvoices
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
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.objList)).BeginInit();
            this.SuspendLayout();
            // 
            // objList
            // 
            this.objList.AllColumns.Add(this.olvColumn1);
            this.objList.AllColumns.Add(this.olvColumn2);
            this.objList.AllColumns.Add(this.olvColumn3);
            this.objList.AllColumns.Add(this.olvColumn4);
            this.objList.AllColumns.Add(this.olvColumn5);
            this.objList.CellEditUseWholeCell = false;
            this.objList.CheckBoxes = true;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.HideSelection = false;
            this.objList.Location = new System.Drawing.Point(0, 0);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(1155, 628);
            this.objList.TabIndex = 6;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.DoubleClick += new System.EventHandler(this.objList_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "CustomerName";
            this.olvColumn1.Text = "Customer Name";
            this.olvColumn1.Width = 244;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "InvoiceNo";
            this.olvColumn2.AspectToStringFormat = "";
            this.olvColumn2.Text = "Invoice No";
            this.olvColumn2.Width = 158;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "ModeOfPayment";
            this.olvColumn4.Text = "Pay Mode";
            this.olvColumn4.Width = 98;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "InvoiceTo";
            this.olvColumn3.AspectToStringFormat = "";
            this.olvColumn3.DisplayIndex = 3;
            this.olvColumn3.Text = "Invoice To";
            this.olvColumn3.Width = 126;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Total";
            this.olvColumn5.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn5.Text = "Amount";
            this.olvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn5.Width = 105;
            // 
            // frmSearchInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 628);
            this.Controls.Add(this.objList);
            this.MaximizeBox = false;
            this.Name = "frmSearchInvoices";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search    Invoices";
            this.Load += new System.EventHandler(this.frmSearchInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
    }
}