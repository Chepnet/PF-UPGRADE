namespace SYSTEMUPGRADEPF
{
    partial class frmSearchShareTypeCharge
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
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objList
            // 
            this.objList.AllColumns.Add(this.olvColumn1);
            this.objList.AllColumns.Add(this.olvColumn2);
            this.objList.AllColumns.Add(this.olvColumn5);
            this.objList.AllColumns.Add(this.olvColumn3);
            this.objList.AllColumns.Add(this.olvColumn4);
            this.objList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objList.CellEditUseWholeCell = false;
            this.objList.CheckBoxes = true;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn5,
            this.olvColumn3,
            this.olvColumn4});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.Dock = System.Windows.Forms.DockStyle.Top;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.Location = new System.Drawing.Point(0, 0);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(1133, 473);
            this.objList.TabIndex = 0;
            this.objList.UseAlternatingBackColors = true;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            this.objList.DoubleClick += new System.EventHandler(this.objList_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "AccountName";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "GL A/C";
            this.olvColumn1.Width = 225;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "ShareTypeDescription";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "Share Type";
            this.olvColumn2.Width = 235;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "ProductDescription";
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "Product";
            this.olvColumn5.Width = 96;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Amount";
            this.olvColumn3.AspectToStringFormat = "{0:###,###.00}";
            this.olvColumn3.Text = "Amount";
            this.olvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.olvColumn3.Width = 101;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "ChargeTypeName";
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = " Charge Type ";
            this.olvColumn4.Width = 129;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(958, 15);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(163, 37);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 64);
            this.panel1.TabIndex = 2;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(13, 15);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(101, 24);
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "Check All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchShareTypeCharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objList);
            this.Name = "frmSearchShareTypeCharge";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Share Charge";
            this.Load += new System.EventHandler(this.frmSearchShareCharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button button1;
    }
}