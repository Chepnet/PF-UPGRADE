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
    public partial class frmSearchAssetRegister : Form
    {
        public frmSearchAssetRegister()
        {
            InitializeComponent();
        }
        Classes.AssetRegister oAssetRegister = new Classes.AssetRegister();
        Classes.AssetRegister onewAssetRegister = null;
        public int selInt = 0;

        private void frmSearchAssetRegister_Load(object sender, EventArgs e)
        {
            objList.Items.Clear();
            loadAssetRegisters();

        }

        private void loadAssetRegisters()
        {
            ArrayList myList = oAssetRegister.GetAssetRegisters();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewAssetRegister = (Classes.AssetRegister)objList.SelectedObject;
            if (onewAssetRegister != null)
                this.selInt = onewAssetRegister.AssetId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
