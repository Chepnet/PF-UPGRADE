namespace SYSTEMUPGRADEPF
{
    partial class frmStartAndEndOfDay
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
            this.dtpWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoans = new System.Windows.Forms.Button();
            this.btnStartOfDay = new System.Windows.Forms.Button();
            this.btnEndOfDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpWorkingDate
            // 
            this.dtpWorkingDate.Location = new System.Drawing.Point(227, 58);
            this.dtpWorkingDate.Name = "dtpWorkingDate";
            this.dtpWorkingDate.Size = new System.Drawing.Size(367, 26);
            this.dtpWorkingDate.TabIndex = 0;
            // 
            // btnLoans
            // 
            this.btnLoans.Location = new System.Drawing.Point(133, 131);
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(129, 36);
            this.btnLoans.TabIndex = 1;
            this.btnLoans.Text = "Loans";
            this.btnLoans.UseVisualStyleBackColor = true;
            // 
            // btnStartOfDay
            // 
            this.btnStartOfDay.Location = new System.Drawing.Point(292, 131);
            this.btnStartOfDay.Name = "btnStartOfDay";
            this.btnStartOfDay.Size = new System.Drawing.Size(124, 37);
            this.btnStartOfDay.TabIndex = 3;
            this.btnStartOfDay.Text = "Start Of Date";
            this.btnStartOfDay.UseVisualStyleBackColor = true;
            this.btnStartOfDay.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEndOfDate
            // 
            this.btnEndOfDate.Location = new System.Drawing.Point(456, 131);
            this.btnEndOfDate.Name = "btnEndOfDate";
            this.btnEndOfDate.Size = new System.Drawing.Size(138, 37);
            this.btnEndOfDate.TabIndex = 4;
            this.btnEndOfDate.Text = "End Of Date";
            this.btnEndOfDate.UseVisualStyleBackColor = true;
            this.btnEndOfDate.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Working Date:";
            // 
            // frmStartAndEndOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEndOfDate);
            this.Controls.Add(this.btnStartOfDay);
            this.Controls.Add(this.btnLoans);
            this.Controls.Add(this.dtpWorkingDate);
            this.MaximizeBox = false;
            this.Name = "frmStartAndEndOfDay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start And End Of Day";
            this.Load += new System.EventHandler(this.frmStartAndEndOfDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWorkingDate;
        private System.Windows.Forms.Button btnLoans;
        private System.Windows.Forms.Button btnStartOfDay;
        private System.Windows.Forms.Button btnEndOfDate;
        private System.Windows.Forms.Label label1;
    }
}