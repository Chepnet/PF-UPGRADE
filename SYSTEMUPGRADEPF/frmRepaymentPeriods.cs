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
    public partial class frmRepaymentPeriods : Form
    {
        Classes.RepaymentPeriod oRepaymentPeriod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepaymentPeriod = null;
        public frmRepaymentPeriods()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewRepaymentPeriod = null;
            ClearText();
            txtName.Focus();
        }
        private void ClearText()
        {
            txtName.Text = "";
            comboBox1.SelectedIndex  = -1;
            
            chkIsActive.Checked = true;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchRepaymentPeriod frm = new frmSearchRepaymentPeriod();
            frm.ShowDialog();
            onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewRepaymentPeriod != null)
            {
               
                txtName.Text = onewRepaymentPeriod.Name.ToString();
                comboBox1 .SelectedItem  = onewRepaymentPeriod.PeriodReference.ToString();
                TxtFrequency.Text = onewRepaymentPeriod.FrequencyRange.ToString();
                chkIsActive.Checked = onewRepaymentPeriod .IsActive;

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("Description Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }

            if (comboBox1.SelectedIndex  ==-1)
            {
                MessageBox.Show("Reference Period is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               comboBox1.Focus();
                return;
            }

            if (onewRepaymentPeriod == null)
                onewRepaymentPeriod = new Classes.RepaymentPeriod();

            onewRepaymentPeriod.Name = txtName.Text;
            onewRepaymentPeriod.FrequencyRange = int.Parse(TxtFrequency.Text.ToString());
            onewRepaymentPeriod.PeriodReference = comboBox1 .SelectedItem .ToString ();
            onewRepaymentPeriod.IsActive = chkIsActive.Checked;

            string error = "";

            onewRepaymentPeriod.RepaymentPeriodId = onewRepaymentPeriod.AddEditRepaymentPeriod(false, ref error);

            if (error == "")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewRepaymentPeriod == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewRepaymentPeriod.AddEditRepaymentPeriod(true, ref error);

            if (error == "")
            {
                ClearText();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewRepaymentPeriod = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oRepaymentPeriod.GetRepaymentPeriods();

            int counter = 0;

            if (onewRepaymentPeriod != null)
            {
                foreach (Classes.RepaymentPeriod orepay in myList)
                {
                    if (orepay.RepaymentPeriodId == onewRepaymentPeriod.RepaymentPeriodId)
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

            if (movingNext)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;


            onewRepaymentPeriod = (Classes.RepaymentPeriod)myList[counter];
            displayInfo();
        }
    }
}
