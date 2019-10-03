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
    public partial class frmSearchCashWithdrawals : Form
    {
        public frmSearchCashWithdrawals()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        Classes.CashWithdrawals oCashWithdrawal = new Classes.CashWithdrawals();
        Classes.CashWithdrawals onewCashWithdrawal = new Classes.CashWithdrawals();
        private void frmSearchCashWithdrawals_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oCashWithdrawal.GetCashWithdrawals ();
            objCashWithdrawalTransactions.SetObjects(myList);
        }

        private void objTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objCashWithdrawalTransactions.SelectedObject != null)
                onewCashWithdrawal  = (Classes.CashWithdrawals )objCashWithdrawalTransactions.SelectedObject;
            if (onewCashWithdrawal  != null)
                this.selInt = onewCashWithdrawal .CashWithdrawalId ;
        }

        private void objCashWithdrawalTransactions_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
