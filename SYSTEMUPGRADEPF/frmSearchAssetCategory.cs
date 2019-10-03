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
    public partial class frmSearchAssetCategory : Form
    {
        public frmSearchAssetCategory()
        {
            InitializeComponent();
        }
        Classes.AssetCategory oAssetCategory = new Classes.AssetCategory();
        Classes.AssetCategory onewAssetCategory = null;
        public int selInt = 0;
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmAssetCategory frm = new SYSTEMUPGRADEPF.frmAssetCategory();
            frm.ShowDialog();
            loadAssetCategories();

        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewAssetCategory = (Classes.AssetCategory)objList.SelectedObject;
            if (onewAssetCategory != null)
                this.selInt = onewAssetCategory.CategoryId;
        }

        private void frmSearchAssetCategory_Load(object sender, EventArgs e)
        {
            loadAssetCategories();
            panel1.Visible = this.PickingValues;
        }

        private void loadAssetCategories()
        {
            ArrayList myList = oAssetCategory.GetAllAssetCategories();
            objList.SetObjects(myList);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
