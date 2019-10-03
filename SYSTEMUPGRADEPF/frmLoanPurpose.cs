using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMUPGRADEPF
{
    public partial class frmLoanPurpose : Form
    {
        Classes.LoanPurpose oLoanPurpose = new Classes.LoanPurpose();
        Classes.LoanPurpose onewLoanPurpose = null;

        public int selInt;
        public frmLoanPurpose()
        {
            InitializeComponent();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        public void ClearText()
        {
            txtDescription.Text = "";
            chkIsactive.Checked = false;
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewLoanPurpose == null)
            {
                MessageBox.Show("Member Account  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delet the selected Item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewLoanPurpose.AddEditLoanPurpose(true, ref error);
                if (error == "")
                {
                    MessageBox.Show("process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchLoanPurpose frm = new frmSearchLoanPurpose();
            frm.ShowDialog();
            onewLoanPurpose = oLoanPurpose.GetLoanPurpose(frm.selInt);
            displayInfo();
        }
        public void displayInfo()
        {
            if(onewLoanPurpose!=null)
            { 
            txtDescription.Text = onewLoanPurpose.Description;
            chkIsactive.Checked = onewLoanPurpose.IsActive;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Description Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }

            if (onewLoanPurpose == null)
                onewLoanPurpose = new Classes.LoanPurpose();
            onewLoanPurpose.Description = txtDescription.Text;
            onewLoanPurpose.IsActive = chkIsactive.Checked;

            string error = "";
            onewLoanPurpose.LoanPurposeId = onewLoanPurpose.AddEditLoanPurpose(false, ref error);
            if (error == "")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oLoanPurpose.GetLoanPurposes();

            int counter = 0;

            if (onewLoanPurpose != null)
            {
                foreach (Classes.LoanPurpose oshare in myList)
                {
                    if (oshare.LoanPurposeId == onewLoanPurpose.LoanPurposeId)
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (movingNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }
        }

        private void frmLoanPurpose_Load(object sender, EventArgs e)
        {

        }
    }
}