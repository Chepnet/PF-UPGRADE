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
    public partial class frmLoanDisbursement : Form
    {
        public frmLoanDisbursement()
        {
            InitializeComponent();
        }
        public string Description
        {
            get { return txtDescription.Text; }
        }
        public string DocumentNo
        {
            get { return txtDocumentNo .Text; }
        }
        public string PaidBy
        {
            get { return txtPaid .Text; }
        }
        public int  ModeOfPaymentId
        {
           

            get {
                int id = 0;
                if (onewModeofPayment != null)
                    id = onewModeofPayment.ModeOfPaymentId;
                return id ;
            }
        }
        public int BankId
        {
            get
            {
                int id = 0;
                if(onewBank!=null)
                    id= onewBank.BankId;
                return id;
            }
        }
        public DateTime   TransactionDate
        {
            get { return dtpTransactionDate .Value ; }
        }
        public DateTime ValueDate
        {
            get { return dtpValueDate .Value; }
        }
       
        private double _amount = 0;
        private int _transactingcurrencyId = 0;
        public double  Amount
        {
            get { return _amount ; }
            set {  _amount=value; }
        }
        public int TransactingCurrencyId
        {
            get { return  _transactingcurrencyId    ; }
            set { _transactingcurrencyId = value; }
           
        }
        public int selMemberShareId = 0;
        public int MemberId = 0;
        
        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeofPayment = null;

        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.ChartOfAccount oChartofaaccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;

        Classes.Loan oLoan = new Classes.Loan();
        Classes.Loan onewLoan = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;

        private void btnBank_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnPayMode_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoanDisbursement_Load(object sender, EventArgs e)
        {
            dtpTransactionDate.Value = MDIUpgrade.Workingdate;
              
                loadCurrencies();
            

        }
      
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = oCurrency.GetCurrencies();
            int defindex = 0, counter = 0;
            foreach (Classes.Currency ocurx in myList )
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurx.Code, ocurx));
                if(ocurx.CurrencyId ==TransactingCurrencyId    )
                {
                    defindex = counter;
                    odefCurrency = ocurx;
                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defindex  ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new frmSearchModeOfPayment();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewModeofPayment = oModeOfPayment.GetModeOfPayment(frm.selInt);
            if(onewModeofPayment !=null)
            {
                if(onewModeofPayment.IsTransfer )
                {
                    frmTransferFunds frmtrans = new frmTransferFunds();
                    frmtrans.MemberId = MemberId;
                    frmtrans.ShowDialog();
                    selMemberShareId = frmtrans.SelMemberShareId;
                    Amount = frmtrans.TransferAmount;
                }
                txtModeOfPayment.Text = onewModeofPayment.Description;
            }
            
        }

        private void btnLoanType_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if (onewBank != null)
            {
                txtBank.Text = onewBank.BankName;
                onewChartOfAccount = oChartofaaccount.GetChartOfAccount(onewBank.GLId);
                if(onewChartOfAccount !=null)
                {
                    txtDRGL.Text = onewChartOfAccount.AccountName;
                }
            }

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLoanApplication frm = new frmLoanApplication();
            this.Hide();
           
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            //otrxCurrency = null;
            //if (cmbCurrency.Items.Count <= 0) return;
            //if (cmbCurrency.SelectedIndex < 0) return;
            //object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            //Classes.Currency myCurrency = (Classes.Currency)obj;
            //if(myCurrency !=null)
            //{
            //    otrxCurrency = myCurrency;
            //}
        }
    }
}
