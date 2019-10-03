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
    public partial class frmSearchLoanPurpose : Form
    {
        Classes.LoanPurpose oLoanPurpose = new Classes.LoanPurpose();
        Classes.LoanPurpose onewLoanPurpose = null;
        private bool _pickingvalues = false;
        public bool PickingValues { get { return _pickingvalues; } set { _pickingvalues = value; } }

        public int selInt;
        public frmSearchLoanPurpose()
        {
            InitializeComponent();
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewLoanPurpose = (Classes.LoanPurpose)objList.SelectedObject;
            if (onewLoanPurpose != null)
                this.selInt = onewLoanPurpose.LoanPurposeId;
        }

        private void frmSearchLoanPurpose_Load(object sender, EventArgs e)
        {
            LoadLoanPurposes();

        }

        private void LoadLoanPurposes()
        {
            ArrayList myList = new ArrayList();
            myList = oLoanPurpose.GetLoanPurposes();
            objList.SetObjects(myList);
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoanPurpose frm = new frmLoanPurpose();

            frm.ShowDialog();
            LoadLoanPurposes();
            
        }
    }
}
