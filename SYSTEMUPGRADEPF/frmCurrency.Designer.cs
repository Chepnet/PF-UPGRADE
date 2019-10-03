namespace SYSTEMUPGRADEPF
{
    partial class frmCurrency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrency));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrevious = new System.Windows.Forms.ToolStripButton();
            this.toolStripNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.chkIsDefaultCurrency = new System.Windows.Forms.CheckBox();
            this.cmbRoundingType = new System.Windows.Forms.ComboBox();
            this.txtRoundingprecision = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.txtUnRealisedGainGL = new System.Windows.Forms.TextBox();
            this.txtRealisedLossGL = new System.Windows.Forms.TextBox();
            this.txtRealisedGainGL = new System.Windows.Forms.TextBox();
            this.txtUnRealisedLossGL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUnRealisedLossGL = new System.Windows.Forms.Button();
            this.btnRealisedLossGL = new System.Windows.Forms.Button();
            this.btnRealisedGainGL = new System.Windows.Forms.Button();
            this.btnUnRealisedGainGL = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.toolStripPrevious,
            this.toolStripNext,
            this.toolStripSeparator2,
            this.cutToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(841, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.newToolStripButton.Text = "&New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripPrevious
            // 
            this.toolStripPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPrevious.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrevious.Image")));
            this.toolStripPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPrevious.Name = "toolStripPrevious";
            this.toolStripPrevious.Size = new System.Drawing.Size(28, 28);
            this.toolStripPrevious.Text = "Previous";
            this.toolStripPrevious.Click += new System.EventHandler(this.toolStripPrevious_Click);
            // 
            // toolStripNext
            // 
            this.toolStripNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNext.Image")));
            this.toolStripNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNext.Name = "toolStripNext";
            this.toolStripNext.Size = new System.Drawing.Size(28, 28);
            this.toolStripNext.Text = "Next";
            this.toolStripNext.Click += new System.EventHandler(this.toolStripNext_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.cutToolStripButton.Text = "Delete";
            this.cutToolStripButton.Click += new System.EventHandler(this.cutToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Symbol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Un Realised Gain GL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Realised Loss GL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rounding Precision:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Rounding Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Realised Gain GL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Un Realised Loss GL: ";
            // 
            // chkIsDefaultCurrency
            // 
            this.chkIsDefaultCurrency.AutoSize = true;
            this.chkIsDefaultCurrency.Location = new System.Drawing.Point(614, 137);
            this.chkIsDefaultCurrency.Name = "chkIsDefaultCurrency";
            this.chkIsDefaultCurrency.Size = new System.Drawing.Size(171, 24);
            this.chkIsDefaultCurrency.TabIndex = 6;
            this.chkIsDefaultCurrency.Text = "Is Default Currency";
            this.chkIsDefaultCurrency.UseVisualStyleBackColor = true;
            this.chkIsDefaultCurrency.CheckedChanged += new System.EventHandler(this.chkIsDefaultCurrency_CheckedChanged);
            // 
            // cmbRoundingType
            // 
            this.cmbRoundingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoundingType.FormattingEnabled = true;
            this.cmbRoundingType.Items.AddRange(new object[] {
            "Normal",
            "Up",
            "Down"});
            this.cmbRoundingType.Location = new System.Drawing.Point(435, 135);
            this.cmbRoundingType.Name = "cmbRoundingType";
            this.cmbRoundingType.Size = new System.Drawing.Size(121, 28);
            this.cmbRoundingType.TabIndex = 5;
            // 
            // txtRoundingprecision
            // 
            this.txtRoundingprecision.Location = new System.Drawing.Point(183, 137);
            this.txtRoundingprecision.Name = "txtRoundingprecision";
            this.txtRoundingprecision.Size = new System.Drawing.Size(100, 26);
            this.txtRoundingprecision.TabIndex = 4;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(105, 77);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(155, 26);
            this.txtCode.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(355, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 26);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(614, 77);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(145, 26);
            this.txtSymbol.TabIndex = 3;
            // 
            // txtUnRealisedGainGL
            // 
            this.txtUnRealisedGainGL.Location = new System.Drawing.Point(167, 44);
            this.txtUnRealisedGainGL.Name = "txtUnRealisedGainGL";
            this.txtUnRealisedGainGL.Size = new System.Drawing.Size(155, 26);
            this.txtUnRealisedGainGL.TabIndex = 7;
            // 
            // txtRealisedLossGL
            // 
            this.txtRealisedLossGL.Location = new System.Drawing.Point(561, 41);
            this.txtRealisedLossGL.Name = "txtRealisedLossGL";
            this.txtRealisedLossGL.Size = new System.Drawing.Size(155, 26);
            this.txtRealisedLossGL.TabIndex = 11;
            // 
            // txtRealisedGainGL
            // 
            this.txtRealisedGainGL.Location = new System.Drawing.Point(167, 84);
            this.txtRealisedGainGL.Name = "txtRealisedGainGL";
            this.txtRealisedGainGL.Size = new System.Drawing.Size(155, 26);
            this.txtRealisedGainGL.TabIndex = 9;
            // 
            // txtUnRealisedLossGL
            // 
            this.txtUnRealisedLossGL.Location = new System.Drawing.Point(561, 87);
            this.txtUnRealisedLossGL.Name = "txtUnRealisedLossGL";
            this.txtUnRealisedLossGL.Size = new System.Drawing.Size(155, 26);
            this.txtUnRealisedLossGL.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUnRealisedLossGL);
            this.groupBox1.Controls.Add(this.btnRealisedLossGL);
            this.groupBox1.Controls.Add(this.btnRealisedGainGL);
            this.groupBox1.Controls.Add(this.btnUnRealisedGainGL);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUnRealisedLossGL);
            this.groupBox1.Controls.Add(this.txtUnRealisedGainGL);
            this.groupBox1.Controls.Add(this.txtRealisedLossGL);
            this.groupBox1.Controls.Add(this.txtRealisedGainGL);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(30, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency GLs";
            // 
            // btnUnRealisedLossGL
            // 
            this.btnUnRealisedLossGL.FlatAppearance.BorderSize = 0;
            this.btnUnRealisedLossGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnRealisedLossGL.Image = ((System.Drawing.Image)(resources.GetObject("btnUnRealisedLossGL.Image")));
            this.btnUnRealisedLossGL.Location = new System.Drawing.Point(722, 87);
            this.btnUnRealisedLossGL.Name = "btnUnRealisedLossGL";
            this.btnUnRealisedLossGL.Size = new System.Drawing.Size(33, 28);
            this.btnUnRealisedLossGL.TabIndex = 14;
            this.btnUnRealisedLossGL.Text = "...";
            this.btnUnRealisedLossGL.UseVisualStyleBackColor = true;
            this.btnUnRealisedLossGL.Click += new System.EventHandler(this.btnUnRealisedLossGL_Click);
            // 
            // btnRealisedLossGL
            // 
            this.btnRealisedLossGL.FlatAppearance.BorderSize = 0;
            this.btnRealisedLossGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealisedLossGL.Image = ((System.Drawing.Image)(resources.GetObject("btnRealisedLossGL.Image")));
            this.btnRealisedLossGL.Location = new System.Drawing.Point(722, 40);
            this.btnRealisedLossGL.Name = "btnRealisedLossGL";
            this.btnRealisedLossGL.Size = new System.Drawing.Size(33, 28);
            this.btnRealisedLossGL.TabIndex = 12;
            this.btnRealisedLossGL.Text = "...";
            this.btnRealisedLossGL.UseVisualStyleBackColor = true;
            this.btnRealisedLossGL.Click += new System.EventHandler(this.btnRealisedLossGL_Click);
            // 
            // btnRealisedGainGL
            // 
            this.btnRealisedGainGL.FlatAppearance.BorderSize = 0;
            this.btnRealisedGainGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealisedGainGL.Image = ((System.Drawing.Image)(resources.GetObject("btnRealisedGainGL.Image")));
            this.btnRealisedGainGL.Location = new System.Drawing.Point(328, 79);
            this.btnRealisedGainGL.Name = "btnRealisedGainGL";
            this.btnRealisedGainGL.Size = new System.Drawing.Size(33, 28);
            this.btnRealisedGainGL.TabIndex = 10;
            this.btnRealisedGainGL.Text = "...";
            this.btnRealisedGainGL.UseVisualStyleBackColor = true;
            this.btnRealisedGainGL.Click += new System.EventHandler(this.btnRealisedGainGL_Click);
            // 
            // btnUnRealisedGainGL
            // 
            this.btnUnRealisedGainGL.FlatAppearance.BorderSize = 0;
            this.btnUnRealisedGainGL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnRealisedGainGL.Image = ((System.Drawing.Image)(resources.GetObject("btnUnRealisedGainGL.Image")));
            this.btnUnRealisedGainGL.Location = new System.Drawing.Point(328, 44);
            this.btnUnRealisedGainGL.Name = "btnUnRealisedGainGL";
            this.btnUnRealisedGainGL.Size = new System.Drawing.Size(33, 28);
            this.btnUnRealisedGainGL.TabIndex = 8;
            this.btnUnRealisedGainGL.Text = "...";
            this.btnUnRealisedGainGL.UseVisualStyleBackColor = true;
            this.btnUnRealisedGainGL.Click += new System.EventHandler(this.btnUnRealisedGainGL_Click);
            // 
            // frmCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtRoundingprecision);
            this.Controls.Add(this.cmbRoundingType);
            this.Controls.Add(this.chkIsDefaultCurrency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCurrency";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripPrevious;
        private System.Windows.Forms.ToolStripButton toolStripNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkIsDefaultCurrency;
        private System.Windows.Forms.ComboBox cmbRoundingType;
        private System.Windows.Forms.TextBox txtRoundingprecision;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.TextBox txtUnRealisedGainGL;
        private System.Windows.Forms.TextBox txtRealisedLossGL;
        private System.Windows.Forms.TextBox txtRealisedGainGL;
        private System.Windows.Forms.TextBox txtUnRealisedLossGL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUnRealisedLossGL;
        private System.Windows.Forms.Button btnRealisedLossGL;
        private System.Windows.Forms.Button btnRealisedGainGL;
        private System.Windows.Forms.Button btnUnRealisedGainGL;
    }
}