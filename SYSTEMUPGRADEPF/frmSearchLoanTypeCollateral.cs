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
    public partial class frmSearchLoanTypeCollateral : Form
    {
        public frmSearchLoanTypeCollateral()
        {
            InitializeComponent();
        }
        private int _loadtypeid = 0;
        public int LoanTypeCollateralId { get { return _loadtypeid; }set { _loadtypeid = value; } }
        private bool _pickingValues = false;
        public bool PickingValues { get { return _pickingValues; } set { _pickingValues = value; } }

        Classes.LoanTypeCollateral oLoanTypeCollateral = new Classes.LoanTypeCollateral();
        Classes.LoanTypeCollateral onewLoanTypeCollateral = null;
        public int selInt = 0;

        private void frmSearchLoanTypeCollateral_Load(object sender, EventArgs e)
        {
            LoadLoanCollaterals();
            panel1.Visible = this.PickingValues;
        }

        private void LoadLoanCollaterals()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oLoanTypeCollateral.GetLTCollaterals();
            foreach (Classes.LoanTypeCollateral olocol in myList)
            {
                if (LoanTypeCollateralId  == olocol.LoanTypeId)
                {
                    newList.Add(olocol);
                }
            }
            objListCollaterals.SetObjects(newList);
        }

        private void objListCollaterals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListCollaterals.SelectedObject != null)
            
                onewLoanTypeCollateral = (Classes.LoanTypeCollateral)objListCollaterals.SelectedObject;
            if (onewLoanTypeCollateral != null)
                this.selInt = onewLoanTypeCollateral.LoanTypeCollateralId;
        }

        private void objListCollaterals_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoanTypes frm = new frmLoanTypes();
            frm.ShowDialog();  
        }
    }
}
