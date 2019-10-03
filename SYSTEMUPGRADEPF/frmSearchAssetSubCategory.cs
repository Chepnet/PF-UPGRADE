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
    public partial class frmSearchAssetSubCategory : Form
    {
        public frmSearchAssetSubCategory()
        {
            InitializeComponent();
        }
        Classes.AssetSubCategory oAssetSubCategory = new Classes.AssetSubCategory();
        Classes.AssetSubCategory onewAssetSubcategory = null;
        public int selInt = 0;

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAssetSubCategory frm = new SYSTEMUPGRADEPF.frmAssetSubCategory();
            frm.ShowDialog();
            loadAssetSubCategories();
        }

        private void frmSearchAssetSubCategory_Load(object sender, EventArgs e)
        {
            loadAssetSubCategories();
        }

        private void loadAssetSubCategories()
        {
            ArrayList myList = new ArrayList();
            myList = oAssetSubCategory.GetAssetSubCategories();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewAssetSubcategory = (Classes.AssetSubCategory)objList.SelectedObject;
            if (onewAssetSubcategory != null)
                this.selInt = onewAssetSubcategory.AssetSubCategoryId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
