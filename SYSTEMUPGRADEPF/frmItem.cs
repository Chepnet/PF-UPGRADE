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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }
        Classes.Item oitem = new Classes.Item();
        Classes.Item onewItem = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtItemCode.Text = "";
            txtRate.Text = "";
            cmbItemType.SelectedIndex = 0;
            checkBox1.Checked = true;
            txtTaxCode.Text = "";
            txtItemCode.Text = "";
            txtGlAc.Text = "";
            onewChartOfAccount = null;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text =="")
            {
                MessageBox.Show("Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (txtItemCode .Text == "")
            {
                MessageBox.Show("Item Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtItemCode .Focus();
                return;
            }
            if (txtRate .Text == "")
            {
                MessageBox.Show("Rate is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRate .Focus();
                return;
            }
            double rate = 0;
            int taxcode = 0;
            if (onewItem == null)
                onewItem = new Classes.Item();
            onewItem.ItemType = cmbItemType.SelectedIndex;
            onewItem.ItemName = txtItemName .Text;
            double.TryParse(txtRate.Text, out rate);
            onewItem.Rate = rate;
            int.TryParse(txtTaxCode.Text, out taxcode);
            onewItem.TaxCode = taxcode;
            onewItem.Description = txtDescription.Text;
            onewItem.ItemCode = txtItemCode.Text;
            if(onewChartOfAccount !=null)
            {
                onewItem.GLId = onewChartOfAccount.GLAccountId;
            }
            string error = "";
            onewItem.ItemId = onewItem.AddEditItem(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewItem ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;

            }
            DialogResult result= MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewItem.AddEditItem(true, ref error);
                if(error=="")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

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
                myList = oitem .GetItems ();

            int counter = 0;

            if (onewItem  != null)
            {
                foreach (Classes.Item  ite in myList)
                {
                    if (ite.ItemId  == onewItem .ItemId )
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


            onewItem  = (Classes.Item )myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchItems frm = new SYSTEMUPGRADEPF.frmSearchItems();
            frm.ShowDialog();
            onewItem = oitem.GetItem(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewItem != null)
            {
                txtDescription.Text = onewItem.Description;
                txtItemCode.Text = onewItem.ItemName;
                txtRate.Text = onewItem.Rate.ToString();
                txtTaxCode.Text = onewItem.TaxCode.ToString();
                cmbItemType.SelectedIndex = onewItem.ItemType;

            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new frmSearchChartOfAccounts();
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if(onewChartOfAccount !=null)
            {
                txtGlAc.Text = onewChartOfAccount.AccountName;
            }
        }
    }
}
