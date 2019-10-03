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
    public partial class frmLoanCategory : Form
    {
        public frmLoanCategory()
        {
            InitializeComponent();
        }
        Classes.LoanCategory oLoanCategory = new Classes.LoanCategory();
        Classes.LoanCategory onewLoanCategory = null;
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewLoanCategory = null;
            txtDescription.Focus();
            ClearText();
        }

        private void ClearText()
        {
            txtDescription.Text = "";
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Trim()=="")
            {
                MessageBox.Show("Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (onewLoanCategory == null)
                onewLoanCategory = new Classes.LoanCategory();
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oLoanCategory.GetLoanCategories();
            foreach (Classes.LoanCategory olocatry in myList )
            {
                if(txtDescription.Text .Trim ().ToLower ()==olocatry.Description .Trim ().ToLower ())
                {
                    if(onewLoanCategory .LoanCategoryId !=olocatry .LoanCategoryId)
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
                onewLoanCategory.Description = txtDescription.Text;
                onewLoanCategory.IsActive = chkIsActive.Checked;

            }

            string error = "";
            onewLoanCategory.LoanCategoryId = onewLoanCategory.AddEditLoanCategory(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process sucedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescription.Focus();
              
            }
            else
            {
                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchLoanCategory frm = new SYSTEMUPGRADEPF.frmSearchLoanCategory();
            frm.ShowDialog();
            onewLoanCategory = oLoanCategory.GetLoanCategory(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewLoanCategory != null)
            {
                txtDescription.Text = onewLoanCategory.Description;
                chkIsActive.Checked = onewLoanCategory.IsActive;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewLoanCategory ==null)
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
                onewLoanCategory.AddEditLoanCategory(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process sucedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescription.Focus();
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
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oLoanCategory .GetLoanCategories ();

            int counter = 0;

            if (onewLoanCategory  != null)
            {
                foreach (Classes.LoanCategory  oloncat in myList)
                {
                    if (oloncat .LoanCategoryId  == onewLoanCategory .LoanCategoryId )
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


            onewLoanCategory  = (Classes.LoanCategory )myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
    }
}
