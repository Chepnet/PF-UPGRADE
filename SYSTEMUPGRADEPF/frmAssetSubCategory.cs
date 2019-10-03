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
    public partial class frmAssetSubCategory : Form
    {
        public frmAssetSubCategory()
        {
            InitializeComponent();
        }
        Classes.AssetSubCategory oAssetSubCategory = new Classes.AssetSubCategory();
        Classes.AssetSubCategory onewAssetSubCategory = null;
        Classes.AssetCategory oAssetCategory = new Classes.AssetCategory();
        Classes.AssetCategory onewAssetcategory = null;

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            clearTexts();

        }

        private void clearTexts()
        {
            txtCategory.Text = "";
            txtsubcategory.Text = "";
            txtRemarks.Text = "";
            onewAssetcategory = null;
            onewAssetSubCategory = null;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtCategory.Text .Trim ()=="")
            {
                MessageBox.Show("Category is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategory.Focus();
                return;
            }
            if (txtsubcategory  .Text.Trim() == "")
            {
                MessageBox.Show("Sub Category is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtsubcategory .Focus();
                return;
            }
            if (onewAssetSubCategory == null)
                onewAssetSubCategory = new Classes.AssetSubCategory();
            onewAssetSubCategory.CategoryId = onewAssetcategory.CategoryId;
            onewAssetSubCategory.SubCategoryName = txtsubcategory.Text;
            onewAssetSubCategory.Remarks = txtRemarks.Text;
            string error = "";
            onewAssetSubCategory.AssetSubCategoryId = onewAssetSubCategory.AddEditAssetSubCategory(false, ref error);
            if(error=="")
            {
                MessageBox.Show(" Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewAssetSubCategory ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show(" Are you sure you want to delete the selected item", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewAssetSubCategory.AddEditAssetSubCategory(true, ref error);
                if (error == "")
                {
                    MessageBox.Show(" Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTexts();
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                myList = oAssetSubCategory .GetAssetSubCategories ();

            int counter = 0;

            if (onewAssetSubCategory  != null)
            {
                foreach (Classes.AssetSubCategory  assetsubcate in myList)
                {
                    if (assetsubcate.AssetSubCategoryId  == onewAssetSubCategory .AssetSubCategoryId  )
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


            onewAssetSubCategory  = (Classes.AssetSubCategory )myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchAssetSubCategory frm = new SYSTEMUPGRADEPF.frmSearchAssetSubCategory();
            frm.ShowDialog();
            onewAssetSubCategory = oAssetSubCategory.GetAssetSubCategory(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewAssetSubCategory != null)
            {
                onewAssetcategory = oAssetCategory.GetAllAssetCategory(onewAssetSubCategory.CategoryId);
                if (onewAssetcategory != null)
                {
                    txtCategory.Text = onewAssetcategory.CategoryName;
                }
                txtRemarks.Text = onewAssetSubCategory.Remarks;
                txtsubcategory.Text = onewAssetSubCategory.SubCategoryName;

            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmSearchAssetCategory frm = new SYSTEMUPGRADEPF.frmSearchAssetCategory();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewAssetcategory = oAssetCategory.GetAllAssetCategory(frm.selInt);
            if (onewAssetcategory != null)
                txtCategory.Text = onewAssetcategory.CategoryName;
        }
    }
}
