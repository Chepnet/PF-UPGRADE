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
   
    public partial class frmSearchShareTypes : Form
    {
        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;

        public int selInt = 0;
        private bool  _fixedDeposit = false;
        public bool FixedDeposit
        {
            get { return _fixedDeposit; }
            set { _fixedDeposit = value; }
        }
        private bool _savingProducts = false;
        public bool SavingProducts
        {
            get { return _savingProducts; }
            set { _savingProducts = value; }
        }

        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        public frmSearchShareTypes()
        {
            InitializeComponent();
        }
        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;

        private void frmSearchShareTypes_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            loadShareTypes();

        }

        private void loadShareTypes()
        {
            ArrayList myList = new ArrayList();
            if (FixedDeposit)
            {
                myList = oShareType.GetFixedDepositShareTypes ();

            }
            else if (SavingProducts)
            {
                myList = oShareType.GetSavingsShareType();
            }
            else
            {
                myList = oShareType.GetShareTypes();

            }
            objectListView1.SetObjects(myList);
        }

        private void frmSearchShareTypes_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
                onewShareType = (Classes.ShareType)objectListView1.SelectedObject;
            if (onewShareType != null)
                this.selInt = onewShareType.ShareTypeId;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmShareType frm = new SYSTEMUPGRADEPF.frmShareType();
            frm.ShowDialog();
            loadShareTypes();
        }
    }
}
