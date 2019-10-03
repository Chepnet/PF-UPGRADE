namespace SYSTEMUPGRADEPF
{
    partial class frmSearchLoanCollateralImages
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
            this.objListImages = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListImages)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListImages
            // 
            this.objListImages.AllColumns.Add(this.olvColumn1);
            this.objListImages.AllColumns.Add(this.olvColumn2);
            this.objListImages.AllColumns.Add(this.olvColumn3);
            this.objListImages.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListImages.CellEditUseWholeCell = false;
            this.objListImages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3});
            this.objListImages.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListImages.FullRowSelect = true;
            this.objListImages.GridLines = true;
            this.objListImages.HideSelection = false;
            this.objListImages.Location = new System.Drawing.Point(0, 5);
            this.objListImages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListImages.MultiSelect = false;
            this.objListImages.Name = "objListImages";
            this.objListImages.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.objListImages.ShowGroups = false;
            this.objListImages.Size = new System.Drawing.Size(642, 479);
            this.objListImages.TabIndex = 0;
            this.objListImages.UseAlternatingBackColors = true;
            this.objListImages.UseCompatibleStateImageBehavior = false;
            this.objListImages.View = System.Windows.Forms.View.Details;
            this.objListImages.SelectedIndexChanged += new System.EventHandler(this.objListImages_SelectedIndexChanged);
            this.objListImages.DoubleClick += new System.EventHandler(this.objListImages_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "CollateralName";
            this.olvColumn1.Text = "Collateral Name";
            this.olvColumn1.Width = 162;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Description";
            this.olvColumn2.Text = "Description";
            this.olvColumn2.Width = 100;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "IsActive";
            this.olvColumn3.Text = "Is Active";
            this.olvColumn3.Width = 80;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 71);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchLoanCollateralImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 565);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListImages);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchLoanCollateralImages";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Loan Collateral Images";
            this.Load += new System.EventHandler(this.frmSearchLoanCollateralImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListImages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListImages;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}