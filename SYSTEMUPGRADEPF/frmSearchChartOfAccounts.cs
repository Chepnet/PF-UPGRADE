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
    public partial class frmSearchChartOfAccounts : Form
    {
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        public int sellInt = 0;
        private bool _postingAccount = false;
        public bool PostingAccount { get { return _postingAccount; } set { _postingAccount = value; } }

        private bool _pickingvalues = false;
        public bool PickingValues { get { return _pickingvalues; } set { _pickingvalues = value; } }

        public frmSearchChartOfAccounts()
        {
            InitializeComponent();
        }

        private void frmSearchChartOfAccounts_Load(object sender, EventArgs e)
        {
            loadChartOfAccount();
            panel1.Visible = this.PickingValues;
        }

        private void loadChartOfAccount()
        {
            ArrayList myList = new ArrayList();
            if (PostingAccount)
            {
                myList = oChartOfAccount.GetPostinhChartOfAccounts();
            }
            else
            {
                myList = oChartOfAccount.GetChartOfAccounts();
            }
            objListChart.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListChart.SelectedObject != null)
                onewChartOfAccount = (Classes.ChartOfAccount)objListChart.SelectedObject;
            if (onewChartOfAccount != null)
                this.sellInt = onewChartOfAccount.GLAccountId;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmChartsOfAccounts frm = new SYSTEMUPGRADEPF.frmChartsOfAccounts();
            frm.ShowDialog();
            loadChartOfAccount();
        }
    }
}
