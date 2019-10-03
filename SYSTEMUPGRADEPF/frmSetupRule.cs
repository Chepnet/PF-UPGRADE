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
    public partial class frmSetupRule : Form
    {
        Classes.SetupRule oSetupRule = new Classes.SetupRule();
        Classes.SetupRule onewSetupRule = null;

        Classes.CompulsoryField oCompulsoryField = new Classes.CompulsoryField();

        public frmSetupRule()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewSetupRule = null;
           
            txtFieldCode.Focus();
        }
        public void ClearText()
        {
            txtFieldCode.Clear();
            txtFieldName.Clear();
            chkIsActive.Checked = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtFieldName.Text.Trim()=="")
            {
                MessageBox.Show("Field Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFieldName.Focus();
                return;
            }
            if (txtFieldCode.Text.Trim() == "")
            {
                MessageBox.Show("Field Code is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtFieldCode.Focus();
                return;
            }
            if (onewSetupRule == null)
                onewSetupRule = new Classes.SetupRule();
            onewSetupRule.FieldCode = txtFieldCode.Text;
            onewSetupRule.FieldName = txtFieldName.Text;
            onewSetupRule.IsActive = chkIsActive.Checked;
            string error = "";

            onewSetupRule.FieldId = onewSetupRule.AddEditSetupRule(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchSetupRule frm = new frmSearchSetupRule();
            frm.ShowDialog();
            onewSetupRule = oSetupRule.GetSetupRule(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewSetupRule != null)
            {
                txtFieldCode.Text = onewSetupRule.FieldCode;
                txtFieldName.Text = onewSetupRule.FieldName;
                chkIsActive.Checked = onewSetupRule.IsActive;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewSetupRule ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selcted item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
           

            string error = "";
            onewSetupRule.AddEditSetupRule(true, ref error);
            if(error =="")
            {
                MessageBox.Show("Process succedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                onewSetupRule = null;
            }
            else
            {
                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                myList = oSetupRule .GetSetupRules ();

            int counter = 0;

            if (onewSetupRule  != null)
            {
                foreach (Classes.SetupRule  osetup in myList)
                {
                    if (osetup.FieldId  == onewSetupRule .FieldId )
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


            onewSetupRule  = (Classes.SetupRule )myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
    }
}
