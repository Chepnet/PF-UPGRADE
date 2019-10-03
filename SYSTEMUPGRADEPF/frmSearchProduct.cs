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
    public partial class frmSearchProduct : Form
    {
        public frmSearchProduct()
        {
            InitializeComponent();
        }
        private bool _pickingValues = false;
        public bool PickingValues { get { return _pickingValues; } set { _pickingValues = value; } }

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        private bool _loanproduct = false;
        public bool LoanProduct { get { return _loanproduct; }set { _loanproduct = value; } }
        private bool _isChargeproduct = false;
        public bool IsChargeProduct { get { return _isChargeproduct; } set { _isChargeproduct = value; } }
        private bool _isGuaranteeLoanproduct = false;
        public bool IsGuaranteeLoanProduct { get { return _isGuaranteeLoanproduct; } set { _isGuaranteeLoanproduct = value; } }
        private bool _isFixedDepositproduct = false;
        public bool IsFixedDepositProduct { get { return _isFixedDepositproduct; } set { _isFixedDepositproduct = value; } }
        private bool _savingsproduct = false;
        public bool SavingsProduct { get { return _savingsproduct; } set { _savingsproduct = value; } }


        public int selInt = 0;
        private void frmSearchProduct_Load(object sender, EventArgs e)
        {
            LoadValues();

        }

        private void LoadValues()
        {
            panel1.Visible = PickingValues;
            ArrayList myList = new ArrayList();
           
            if (LoanProduct)
            {
                myList = oProduct.GetLoanProducts();
            }

            else if (IsChargeProduct)
            {
                myList = oProduct.GetChargeProducts();

            }
            else if (IsGuaranteeLoanProduct)
            {
                myList = oProduct.GetGuaranteeLoanProducts();
            }
            else if (IsFixedDepositProduct)
            {
                myList = oProduct.GetFixedDepositProducts();
            }
            else if (SavingsProduct)
            {
                myList = oProduct.GetSavingsProducts();
            }
            else
            {
                myList = oProduct.GetProducts();
            }
            objectListView1.SetObjects(myList);

        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
                onewProduct = (Classes.Product)objectListView1.SelectedObject;
            if(onewProduct!=null)
            {
                this.selInt = onewProduct.ProductId;
            }
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmProduct frm = new SYSTEMUPGRADEPF.frmProduct();
            frm.ShowDialog();
            LoadValues();
            
        }
    }
}
