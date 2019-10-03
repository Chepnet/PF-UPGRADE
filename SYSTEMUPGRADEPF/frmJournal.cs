using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SYSTEMUPGRADEPF
{
    public partial class frmJournal : Form
    {

        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.Journal oJournal = new Classes.Journal();
        Classes.Journal onewJournal = null;
        public frmJournal()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtNarration.Text = txtDescription.Text;
            txtDescription2.Text = txtDescription.Text;

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                btnMember.Visible = true;
                chkGoToLoanAccount.Checked = false;
            }
        }

        private void chkGoToLoanAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGoToLoanAccount .Checked == true)
            {
                btnMember.Visible = false;
                checkBox1 .Checked  = false;
            }
        }

        private void btnSearchEmployer_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new frmSearchChartOfAccounts();
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccount != null)
                txtGlAccount.Text = onewChartOfAccount.AccountName;

           
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            int serial,GlAccount = 0;
            double amount = 0;
            if (onewJournal == null)
                onewJournal = new Classes.Journal();
            int.TryParse(txtSerialId.Text, out serial);
            onewJournal.SerialId = serial;
            onewJournal.SourceDescription = txtDescription.Text;
            onewJournal.ReferenceNumber = txtRefNo.Text;
            double.TryParse(txtAmount.Text, out amount);
            onewJournal.Amount = amount ;
            int.TryParse(txtGlAccount.Text, out GlAccount);
            onewJournal.GLId = GlAccount ;
            string err = "";
            onewJournal.TransId = onewJournal.AddEditTransaction(false, ref err);
            if(err=="")
            {
                MessageBox.Show("Process sucedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }
    }
}
