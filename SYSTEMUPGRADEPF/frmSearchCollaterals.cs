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
    public partial class frmSearchCollaterals : Form
    {
        public frmSearchCollaterals()
        {
            InitializeComponent();
        }
        private bool _pickingValues = false;
        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }

        Classes.Collateral oCollateral = new Classes.Collateral();
        Classes.Collateral onewCollateral = null;

        public int selInt = 0;
        private void frmSearchCollaterals_Load(object sender, EventArgs e)
        {
            loadCollaterals();
            panel1.Visible = this.PickingValues;
        }

        private void loadCollaterals()
        {
            ArrayList myList = new ArrayList();
            myList = oCollateral.GetCollaterals();
            objList.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCollateral = (Classes.Collateral)objList.SelectedObject;
            if (onewCollateral != null)
                this.selInt = onewCollateral.CollateralId;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmCollaterals frm = new SYSTEMUPGRADEPF.frmCollaterals();
            
            frm.ShowDialog();
            loadCollaterals();
            
        }
    }
}
