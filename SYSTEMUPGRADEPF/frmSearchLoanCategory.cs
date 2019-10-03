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
    public partial class frmSearchLoanCategory : Form
    {
        public frmSearchLoanCategory()
        {
            InitializeComponent();
        }
        Classes.LoanCategory oLoanCategory = new Classes.LoanCategory();
        Classes.LoanCategory onewCategory = null;
        private bool _pickingValues = false;
        public bool PickingValues { get { return _pickingValues; } set { _pickingValues = value; } }
        public int selInt = 0;
        private void frmSearchLoanCategory_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            loadloanCategory();
        }

        private void loadloanCategory()
        {
            ArrayList myList = new ArrayList();
            myList = oLoanCategory.GetLoanCategories();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCategory = (Classes.LoanCategory)objList.SelectedObject;
            if (onewCategory != null)
                this.selInt = onewCategory.LoanCategoryId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmLoanCategory frm = new SYSTEMUPGRADEPF.frmLoanCategory();
            frm.ShowDialog();
            loadloanCategory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
