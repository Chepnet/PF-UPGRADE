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
    public partial class frmAssetRegistration : Form
    {
        public frmAssetRegistration()
        {
            InitializeComponent();
        }
        Classes.AssetRegister oAssetRegister = new Classes.AssetRegister();
        Classes.AssetRegister onewAssetRegister = null;
        Classes.AssetCategory oAssetCategory = new Classes.AssetCategory();
        Classes.AssetCategory onewAssetCategory = null;

        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = new Classes.Bank();

        Classes.ChartOfAccount oChartofAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartofAccount = null;
        Classes.AssetSubCategory oAssetSubCategory = new Classes.AssetSubCategory();
        Classes.AssetSubCategory onewAssetSubCategory = null;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewAssetRegister = null;
            txtCategory.Focus();
            ClearTexts();

        }

        private void ClearTexts()
        {
            txtCategory.Text = "";
            txtSubcategory.Text = "";
            txtCreditOfficer.Text = "";
            txtName.Text = "";
            txtRemarks.Text = "";
            txtSerialNo.Text = "";
            txtYears.Text = "";
            cmbdepreciationmethod.SelectedIndex = -1;
            dtpDepEndDate.Value = DateTime.Now;
            dtpDepStart.Value = DateTime.Now;
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text .Trim () =="")
            {
                MessageBox.Show("Asset Category is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
                return;
            }
            if (txtSubcategory .Text.Trim() == "")
            {
                MessageBox.Show("Asset Sub Category is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSubcategory .Focus();
                return;
            }
            if (txtName .Text.Trim() == "")
            {
                MessageBox.Show("Asset Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName .Focus();
                return;
            }
            if (txtSerialNo .Text.Trim() == "")
            {
                MessageBox.Show("Asset Serial No is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSerialNo .Focus();
                return;
            }
            if (txtCreditOfficer .Text.Trim() == "")
            {
                MessageBox.Show("Credit Officer is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCreditOfficer .Focus();
                return;
            }
            double years = 0;
            if (onewAssetRegister == null)
                onewAssetRegister = new Classes.AssetRegister();
            if(onewAssetCategory !=null)
            onewAssetRegister.CategoryId = onewAssetCategory .CategoryId ;
            if(onewAssetSubCategory !=null)
            onewAssetRegister.SubCategoryId = onewAssetSubCategory.AssetSubCategoryId ;
            onewAssetRegister.Name = txtName.Text;
            onewAssetRegister.Remarks = txtRemarks.Text;
            onewAssetRegister.SerialNo = txtSerialNo.Text;
            double.TryParse(txtYears.Text, out years);
            onewAssetRegister.Years = years;
            onewAssetRegister.CreditOfficer = int.Parse(txtCreditOfficer.Text);
            onewAssetRegister.DepEndDate = dtpDepEndDate.Value;
            onewAssetRegister.DepStartDate = dtpDepStart.Value;
            onewAssetRegister.DepreciationMethod = cmbdepreciationmethod.SelectedIndex;
            if(onewBank !=null)
            onewAssetRegister.GLAccountId = onewBank.BankId;

            string error = "";
            onewAssetRegister.AssetId = onewAssetRegister.AddEditAssetRegister(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewAssetRegister ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            }
            DialogResult result= MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewAssetRegister.AddEditAssetRegister(true, ref error);
                if(error=="")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTexts();
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
                myList = oAssetRegister .GetAssetRegisters ();

            int counter = 0;

            if (onewAssetRegister  != null)
            {
                foreach (Classes.AssetRegister  asreg in myList)
                {
                    if (asreg.AssetId  == onewAssetRegister .AssetId )
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


            onewAssetRegister  = (Classes.AssetRegister )myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchAssetRegister frm = new frmSearchAssetRegister();
            frm.ShowDialog();
            onewAssetRegister = oAssetRegister.GetAssetRegister(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewAssetRegister != null)
            {
                onewAssetCategory = oAssetCategory.GetAllAssetCategory(onewAssetRegister.CategoryId);
                if(onewAssetCategory !=null)
                txtCategory.Text = onewAssetCategory.CategoryName ;
                txtSubcategory.Text = onewAssetRegister.SubCategoryId.ToString();
                txtYears.Text = onewAssetRegister.Years.ToString();
                txtSerialNo.Text = onewAssetRegister.SerialNo;
                txtRemarks.Text = onewAssetRegister.Remarks;
                txtCreditOfficer.Text = onewAssetRegister.CreditOfficer.ToString();
                cmbdepreciationmethod.SelectedIndex = onewAssetRegister.DepreciationMethod;
                dtpDepStart.Value = onewAssetRegister.DepStartDate;
                dtpDepEndDate.Value = onewAssetRegister.DepEndDate;
                txtName.Text = onewAssetRegister.Name;

            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if(onewBank !=null)
            {
                txtBank.Text = onewBank.AccountName;
                onewChartofAccount = oChartofAccount.GetChartOfAccount(onewBank.GLId);
                if(onewChartofAccount !=null)
                {
                    txtGL.Text = onewChartofAccount.AccountName;
                }
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmSearchAssetCategory frm = new SYSTEMUPGRADEPF.frmSearchAssetCategory();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewAssetCategory = oAssetCategory.GetAllAssetCategory(frm.selInt);
            if (onewAssetCategory != null)
                txtCategory.Text = onewAssetCategory.CategoryName;
        }

        private void btnSubcategory_Click(object sender, EventArgs e)
        {
            frmSearchAssetSubCategory frm = new frmSearchAssetSubCategory();
            frm.ShowDialog();
            onewAssetSubCategory = oAssetSubCategory.GetAssetSubCategory(frm.selInt);
            if (onewAssetSubCategory != null)
                txtSubcategory.Text = onewAssetSubCategory.SubCategoryName;
        }
    }
}
