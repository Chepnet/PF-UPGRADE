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
    public partial class frmSearchLoanTypes : Form
    {
       
        public frmSearchLoanTypes()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        //ArrayList mylist = new ArrayList();
        private bool  _pickingValues = false;

        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }

        Classes.LoanType oLoanType = new Classes.LoanType();
        Classes.LoanType onewLoanType = null;
        


        private void frmSearchLoanTypes_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            loadLoanTypes();
        }

        private void loadLoanTypes()
        {
            ArrayList myList = new ArrayList();
            myList = oLoanType.GetLoanTypes();
            objList.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewLoanType = (Classes.LoanType)objList.SelectedObject;
            if (onewLoanType != null)
                this.selInt = onewLoanType.ProductId  ;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmLoanTypes frm = new SYSTEMUPGRADEPF.frmLoanTypes();
            frm.ShowDialog();
            loadLoanTypes();
            
        }
    }
}
