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
    public partial class frmAssetCategory : Form
    {
        public frmAssetCategory()
        {
            InitializeComponent();
        }
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.ChartOfAccount onewDepreciationChartOfAccount = null;
        Classes.AssetCategory oAssetCategory = new Classes.AssetCategory();
        Classes.AssetCategory onewAssetCategory = null;
        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if(onewChartOfAccount !=null)
            {
                txtOriginalcostGL.Text = onewChartOfAccount.AccountName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewDepreciationChartOfAccount  = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewDepreciationChartOfAccount  != null)
            {
                txtAnnualDepreciationGL .Text = onewDepreciationChartOfAccount .AccountName;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            clearTexts();

        }

        private void clearTexts()
        {
            onewChartOfAccount = null;
            onewDepreciationChartOfAccount = null;
            onewAssetCategory = null;
            txtName.Text = "";
            txtOriginalcostGL.Text = "";
            txtDepreciationPercentage.Text = "";
            txtRemarks.Text = "";
            txtAnnualDepreciationGL.Text = "";
            txtAssetPrefix.Text = "";
            cmbDepreciationMethod.SelectedIndex = 0;
            txtrounding.Text = "";
            txtrounding.Text = "";
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim () =="")
            {
                MessageBox.Show("Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            if (txtAssetPrefix .Text.Trim() == "")
            {
                MessageBox.Show("Prefix is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAssetPrefix .Focus();
                return;
            }
            if (onewAssetCategory == null)
                onewAssetCategory = new Classes.AssetCategory();
            onewAssetCategory.CategoryName = txtName.Text;
            onewAssetCategory.CategoryPrefix = txtAssetPrefix.Text;
            onewAssetCategory.DepreciationMethodId = cmbDepreciationMethod.SelectedIndex;
            onewAssetCategory.Remarks = txtRemarks.Text;
            onewAssetCategory.Rounding = int.Parse (txtrounding.Text);
            onewAssetCategory.DepreciationPercentage = int.Parse(txtDepreciationPercentage.Text);
            onewAssetCategory.OriginalCostGLId = onewChartOfAccount.GLAccountId;
            onewAssetCategory.AnnualDepreciationGLId = onewDepreciationChartOfAccount.GLAccountId;
            string error = "";
            onewAssetCategory.CategoryId = onewAssetCategory.AddEditAssetCategory(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewAssetCategory ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result= MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewAssetCategory.AddEditAssetCategory(true, ref error);
                if(error =="")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    clearTexts();
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oAssetCategory .GetAllAssetCategories ();

            int counter = 0;

            if (onewAssetCategory != null)
            {
                foreach (Classes.AssetCategory  ascate in myList)
                {
                    if (ascate.CategoryId == onewAssetCategory .CategoryId )
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


            onewAssetCategory  = (Classes.AssetCategory )myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchAssetCategory frm = new frmSearchAssetCategory();
            frm.ShowDialog();
            onewAssetCategory = oAssetCategory.GetAllAssetCategory(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewAssetCategory != null)
            {
                txtName.Text = onewAssetCategory.CategoryName;
                txtRemarks.Text = onewAssetCategory.Remarks;
                txtAssetPrefix.Text = onewAssetCategory.CategoryPrefix;
                onewDepreciationChartOfAccount = oChartOfAccount.GetChartOfAccount(onewAssetCategory.AnnualDepreciationGLId);
                if(onewDepreciationChartOfAccount !=null)
                txtAnnualDepreciationGL.Text = onewDepreciationChartOfAccount .AccountName ;
                onewChartOfAccount  = oChartOfAccount.GetChartOfAccount(onewAssetCategory.OriginalCostGLId );
                if (onewChartOfAccount != null)
                    txtOriginalcostGL.Text = onewChartOfAccount.AccountName; 
                txtrounding.Text = onewAssetCategory.Rounding.ToString();
                txtDepreciationPercentage.Text = onewAssetCategory.DepreciationPercentage.ToString();
                cmbDepreciationMethod.SelectedIndex = onewAssetCategory.DepreciationMethodId;
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
    }
}
