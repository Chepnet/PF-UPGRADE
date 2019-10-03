namespace SYSTEMUPGRADEPF
{
    partial class frmMembersReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.MembersCrystalReport4 = new SYSTEMUPGRADEPF.Reports.MembersCrystalReport();
            this.MembersCrystalReport1 = new SYSTEMUPGRADEPF.Reports.MembersCrystalReport();
            this.MembersCrystalReport2 = new SYSTEMUPGRADEPF.Reports.MembersCrystalReport();
            this.MembersCrystalReport3 = new SYSTEMUPGRADEPF.Reports.MembersCrystalReport();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.MembersCrystalReport4;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1441, 705);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frmMembersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1441, 705);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frmMembersReport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMembersReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMembersReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Reports.MembersCrystalReport MembersCrystalReport4;
        private Reports.MembersCrystalReport MembersCrystalReport1;
        private Reports.MembersCrystalReport MembersCrystalReport2;
        private Reports.MembersCrystalReport MembersCrystalReport3;
    }
}