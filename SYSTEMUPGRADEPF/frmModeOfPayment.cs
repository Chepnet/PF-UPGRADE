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
    public partial class frmModeOfPayment : Form
    {
        Classes.ModeOfPayment omodeofpayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment = null;



        public frmModeOfPayment()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewModeOfPayment = null;
            txtDescription.Focus();
            ClearText();

        }

        private void ClearText()
        {
            chkAllowBackDatedTransactions.Checked = false;
            chkIsActive.Checked = true;
            chkIsInHouseClearing.Checked = false;
            chkIsLinkedToUser.Checked = false;
            txtDescription.Text = "";
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (onewModeOfPayment == null)
                onewModeOfPayment = new Classes.ModeOfPayment();
            bool exist = false;
            ArrayList myList = omodeofpayment.GetModeOfPayments();
            foreach (Classes.ModeOfPayment omodpay in myList )
            {
                if(txtDescription.Text .Trim ().ToLower ()==omodpay.Description .Trim ().ToLower ())
                {
                    if(onewModeOfPayment.ModeOfPaymentId !=omodpay.ModeOfPaymentId )
                    {
                        exist = true;
                        break;
                    }
                }

            }
            if(exist)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;

            }
            else
            {
                onewModeOfPayment.Description = txtDescription.Text;
                onewModeOfPayment.IsActive = chkIsActive.Checked;
                onewModeOfPayment.IsInHouseClearing = chkIsInHouseClearing.Checked;
                onewModeOfPayment.IsLinkedToUser = chkIsLinkedToUser.Checked;
                onewModeOfPayment.IsTransfer = chkIsTransfer.Checked;
            }

           
            
            string err = "";
            onewModeOfPayment.ModeOfPaymentId = onewModeOfPayment.AddEditModeOfPayment(false, ref err);
            if (err == "")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.ShowDialog();
            onewModeOfPayment = omodeofpayment.GetModeOfPayment(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewModeOfPayment != null)
            {
                txtDescription.Text = onewModeOfPayment.Description;
                chkIsActive.Checked = onewModeOfPayment.IsActive;
                chkIsInHouseClearing.Checked = onewModeOfPayment.IsInHouseClearing;
                chkIsLinkedToUser.Checked = onewModeOfPayment.IsLinkedToUser;
                chkIsTransfer.Checked = onewModeOfPayment.IsTransfer;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewModeOfPayment == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewModeOfPayment.ModeOfPaymentId = onewModeOfPayment.AddEditModeOfPayment(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();

                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            MoveRecord(false);
        }
        private void MoveRecord(bool MoveNext)
        {
            ArrayList myList = new ArrayList();
            if (myList.Count == 0)
                myList = omodeofpayment.GetModeOfPayments();
            int counter = 0;
            if (onewModeOfPayment != null)
            {
                foreach (Classes.ModeOfPayment omodpay in myList)
                {
                    if (omodpay.ModeOfPaymentId == onewModeOfPayment.ModeOfPaymentId)
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (MoveNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }
                if (MoveNext)
                {
                    counter = counter + 1;
                }
                else
                {
                    counter = counter - 1;
                }
                if (counter == -1) counter = 0;
                if (counter >= myList.Count) counter = myList.Count - 1;
                onewModeOfPayment  = (Classes.ModeOfPayment )myList[counter];
                displayInfo();

            }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            MoveRecord(true);
        }

        private void frmModeOfPayment_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}

