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
    public partial class frmsearchLoanApplications : Form
    {
        Classes.LoanApplication oLoanApplication = new Classes.LoanApplication();
        Classes.LoanApplication onewLoanApplication = null;

        public int selInt;
        public frmsearchLoanApplications()
        {
            InitializeComponent();
        }

        private void frmsearchLoanApplications_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oLoanApplication.GetUnDisbursedLoanApplications ();
            objectListView1.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
                onewLoanApplication = (Classes.LoanApplication)objectListView1.SelectedObject;
            if (onewLoanApplication != null)
                this.selInt = onewLoanApplication.LoanApplicationId;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
