namespace SYSTEMUPGRADEPF
{
    partial class frmGroupedOption
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
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn7 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn9 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
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
            this.objList.AllColumns.Add(this.olvColumn7);
            this.objList.AllColumns.Add(this.olvColumn6);
            this.objList.AllColumns.Add(this.olvColumn8);
            this.objList.AllColumns.Add(this.olvColumn9);
            this.objList.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objList.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.objList.CellEditUseWholeCell = false;
            this.objList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5,
            this.olvColumn7,
            this.olvColumn6,
            this.olvColumn8,
            this.olvColumn9});
            this.objList.Cursor = System.Windows.Forms.Cursors.Default;
            this.objList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objList.FullRowSelect = true;
            this.objList.GridLines = true;
            this.objList.HideSelection = false;
            this.objList.Location = new System.Drawing.Point(0, 0);
            this.objList.Name = "objList";
            this.objList.ShowGroups = false;
            this.objList.Size = new System.Drawing.Size(1778, 674);
            this.objList.TabIndex = 0;
            this.objList.UseAlternatingBackColors = true;
            this.objList.UseCompatibleStateImageBehavior = false;
            this.objList.View = System.Windows.Forms.View.Details;
            this.objList.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.objList_CellEditFinishing);
            this.objList.SelectedIndexChanged += new System.EventHandler(this.objList_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "GroupOption";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Text = "Group Option";
            this.olvColumn1.Width = 128;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "SubOption";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Text = "SubOption";
            this.olvColumn2.Width = 137;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "OptionCode";
            this.olvColumn3.IsEditable = false;
            this.olvColumn3.Text = "Option Code";
            this.olvColumn3.Width = 130;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "OptionName";
            this.olvColumn4.IsEditable = false;
            this.olvColumn4.Text = "Option Name";
            this.olvColumn4.Width = 163;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "IsBoolean";
            this.olvColumn5.IsEditable = false;
            this.olvColumn5.Text = "True/False";
            this.olvColumn5.Width = 99;
            // 
            // olvColumn7
            // 
            this.olvColumn7.AspectName = "BooleanValue";
            this.olvColumn7.Text = "True/False Value";
            this.olvColumn7.Width = 136;
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "IsNumber";
            this.olvColumn6.IsEditable = false;
            this.olvColumn6.Text = "Numeric?";
            this.olvColumn6.Width = 154;
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "TextValue";
            this.olvColumn8.Text = "Text Value";
            this.olvColumn8.Width = 151;
            // 
            // olvColumn9
            // 
            this.olvColumn9.AspectName = "NumberValue";
            this.olvColumn9.Text = "Number Value";
            this.olvColumn9.Width = 152;
            // 
            // frmGroupedOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1778, 674);
            this.Controls.Add(this.objList);
            this.MaximizeBox = false;
            this.Name = "frmGroupedOption";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grouped Option";
            this.Load += new System.EventHandler(this.frmGroupedOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn7;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private BrightIdeasSoftware.OLVColumn olvColumn9;
    }
}