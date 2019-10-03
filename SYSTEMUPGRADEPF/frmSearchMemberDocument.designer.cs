namespace SYSTEMUPGRADEPF
{
    partial class frmSearchMemberDocument
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
            this.objListDocuments = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objListDocuments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objListDocuments
            // 
            this.objListDocuments.AllColumns.Add(this.olvColumn1);
            this.objListDocuments.AllColumns.Add(this.olvColumn2);
            this.objListDocuments.AllColumns.Add(this.olvColumn3);
            this.objListDocuments.AllColumns.Add(this.olvColumn4);
            this.objListDocuments.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.objListDocuments.CellEditUseWholeCell = false;
            this.objListDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2,
            this.olvColumn3,
            this.olvColumn4});
            this.objListDocuments.Cursor = System.Windows.Forms.Cursors.Default;
            this.objListDocuments.Dock = System.Windows.Forms.DockStyle.Top;
            this.objListDocuments.FullRowSelect = true;
            this.objListDocuments.GridLines = true;
            this.objListDocuments.HideSelection = false;
            this.objListDocuments.Location = new System.Drawing.Point(0, 0);
            this.objListDocuments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.objListDocuments.Name = "objListDocuments";
            this.objListDocuments.ShowGroups = false;
            this.objListDocuments.Size = new System.Drawing.Size(889, 490);
            this.objListDocuments.TabIndex = 0;
            this.objListDocuments.UseAlternatingBackColors = true;
            this.objListDocuments.UseCompatibleStateImageBehavior = false;
            this.objListDocuments.View = System.Windows.Forms.View.Details;
            this.objListDocuments.SelectedIndexChanged += new System.EventHandler(this.objListDocuments_SelectedIndexChanged);
            this.objListDocuments.DoubleClick += new System.EventHandler(this.objListDocuments_DoubleClick);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "MemberName";
            this.olvColumn1.Text = "Member ";
            this.olvColumn1.Width = 165;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "DocumentTypeDescription";
            this.olvColumn2.Text = "Document Type";
            this.olvColumn2.Width = 156;
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Description";
            this.olvColumn3.Text = "Description";
            this.olvColumn3.Width = 100;
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "IsActive";
            this.olvColumn4.Text = "Is Active";
            this.olvColumn4.Width = 79;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 66);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(747, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Create New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSearchMemberDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.objListDocuments);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSearchMemberDocument";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Member Document";
            this.Load += new System.EventHandler(this.frmSearchMemberDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objListDocuments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView objListDocuments;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
    }
}