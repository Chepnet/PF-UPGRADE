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
    public partial class frmSearchLoans : Form
    {
        public frmSearchLoans()
        {
            InitializeComponent();
        }
        Classes.Loan oLoan = new Classes.Loan();
        Classes.Loan onewLoan = null;
        public int selInt = 0;

        private void frmSearchLoans_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oLoan.GetLoans();
            objListLoans.SetObjects(myList);
        }

        private void objListLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objListLoans.SelectedObject !=null)
            {
                onewLoan = (Classes.Loan)objListLoans.SelectedObject;
                if(onewLoan !=null)
                {
                    this.selInt = onewLoan.LoanId;
                }
            }
        }

        private void objListLoans_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
