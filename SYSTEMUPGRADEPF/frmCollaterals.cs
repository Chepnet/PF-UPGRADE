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
    public partial class frmCollaterals : Form
    {
        Classes.Collateral oCollateral = new Classes.Collateral();
        Classes.Collateral onewCollateral = null;
        public frmCollaterals()
        {
            InitializeComponent();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtDescription .Focus();
            onewCollateral = null;
            ClearText();
        }

        private void ClearText()
        {
            txtPercentageForcedValue.Text = "";
            txtDescription .Text = "";
            chkIsActive.Checked = true;
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmSearchCollaterals frm = new frmSearchCollaterals();
            frm.ShowDialog();
            onewCollateral = oCollateral.GetCollateral(frm.selInt);
            displayInfo();
        }
        private void displayInfo()
        {
            if (onewCollateral != null)

            {
                txtPercentageForcedValue.Text = onewCollateral.PercentageForcedValue .ToString ();
                txtDescription.Text = onewCollateral.Description;
                chkIsActive.Checked = onewCollateral.IsActive;
                ChkHasexpiry.Checked = onewCollateral.HasExpiry;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (txtPercentageForcedValue.Text.Trim() == "")
            {
                MessageBox.Show("Collateral Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPercentageForcedValue.Focus();
                return;
            }

            if (onewCollateral == null)
                onewCollateral = new Classes.Collateral();
            double percentagevalue = 0;
            double.TryParse(txtPercentageForcedValue.Text, out percentagevalue);
            if(percentagevalue <0 && percentagevalue >100)
            {
                MessageBox.Show("You are outside the range", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPercentageForcedValue.Focus();
                return;
            }
            else
            {
                onewCollateral.PercentageForcedValue = percentagevalue;
            }
            
            onewCollateral.Description = txtDescription.Text ;
            onewCollateral.IsActive = chkIsActive.Checked;
            onewCollateral.HasExpiry = ChkHasexpiry.Checked;

            string error = "";

            onewCollateral.CollateralId = onewCollateral.AddEditCollaterals(false, ref error);

            if (error == "")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (onewCollateral == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewCollateral.AddEditCollaterals(false, ref error);

            if (error == "")
            {
                ClearText();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewCollateral = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oCollateral.GetCollaterals();

            int counter = 0;

            if (onewCollateral != null)
            {
                foreach (Classes.Collateral oColla in myList)
                {
                    if (oColla.CollateralId == onewCollateral.CollateralId)
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


            onewCollateral = (Classes.Collateral)myList[counter];
            displayInfo();
        }

        private void frmCollaterals_Load(object sender, EventArgs e)
        {

        }
    }
}
