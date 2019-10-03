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
using SYSTEMUPGRADEPF.Classes;

namespace SYSTEMUPGRADEPF
{
    public partial class frmLoanRepayment : Form
    {
        public frmLoanRepayment()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        Classes.MemberShare oMembershare = new MemberShare();
        Classes.MemberShare onewMembershare = null;
        Classes.LoanApplication oLoanApplication = new Classes.LoanApplication();
        Classes.LoanApplication  onewLoanApplication = null;
       Classes. LoanTransaction oLoanTransaction = new LoanTransaction();
      Classes.  LoanTransaction onewLoanTransaction = null;
        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        Classes.LoanType oLoanType = new Classes.LoanType();
        Classes.LoanType onewLoanType = null;

        Classes.Currency oCurrency = new Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;


        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        Classes.Loan oLoan = new Classes.Loan();
        Classes.Loan onewLoan = null;
        Classes.ModeOfPayment oModeofPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeofpayment = null;

        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBANK = null;

        Classes.ChartOfAccount oChartOfAccounts = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccounts = null;

        Classes.ExchangeRate oExchangeRate = new ExchangeRate();
        Classes.ExchangeRate onewExchangeRate = null;
        private int SelMemberShareId = 0;
        private bool loadingselectedcurrencies = false;
        public bool LoadingSelectedCurrencies
        {
            get { return loadingselectedcurrencies; }
            set { loadingselectedcurrencies = value; }
        }
        
      

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember   frm = new SYSTEMUPGRADEPF.frmSearchMember ();
            frm.ShowDialog();
            onewMember   = oMember  .GetMember  (frm.selInt);
            if(onewMember   !=null)
            {
              
                
                    txtCellNo.Text = onewMember.PhoneNumber;
                    txtMemberName.Text = onewMember.MemberName;
                    txtMemberNo.Text = onewMember.MemberNo;
                    txtIdNumber.Text = onewMember.IdNumber;
                    
               
                GetAllMemberLoans();
            }
        }

        private void objListLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListLoans.SelectedObject != null)
            {
                onewLoan = (Classes.Loan)objListLoans.SelectedObject;
                if (onewLoan != null)
                {
                    this.selInt = onewLoan.LoanId;
                    
                }
            }
        }
        private void GetAllMemberLoans()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oLoan.GetLoans();
            foreach (Classes.Loan olo in myList )
            {
                if(onewMember.MemberId ==olo.MemberId )
                {
                    newList.Add(olo);
                }
            }
            objListLoans.SetObjects(newList);
        }

        private void frmLoanRepayment_Load(object sender, EventArgs e)
        {
            loadCurrencies();
        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = oCurrency.GetCurrencies();
            int defindex=0, counter = 0;
            foreach (Classes.Currency ocurr in myList )
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurr.Code, ocurr));

            if(ocurr.IsDefaultCurrency )
                {
                    odefCurrency=ocurr ;
                    defindex = counter;
                }
                counter++;
            }
            if(!LoadingSelectedCurrencies)
            {
                cmbCurrency.SelectedIndex = defindex;
            }
                
           
            
        }
        private void ClearText()
        {
            onewLoanTransaction = null;
            txtAmount.Text = "";
            txtDescription.Text = "";
            txtPaid.Text = "";
            dtpTransactionDate.Value = DateTime.Now;
            dtpValueDate.Value = DateTime.Now;
            onewBANK = null;
            txtBank.Text = "";
            onewModeofpayment = null;
            txtModeOfPayment.Text = "";
            txtDocumentNo.Text = "";
            onewChartOfAccounts = null;
            txtDRGL.Text = "";
            loadCurrencies();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onewLoan == null)
            {
                MessageBox.Show("Loan to Repay is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (objListLoans.SelectedObject == null)
            {
                MessageBox.Show("Loan to Repay is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            if(txtModeOfPayment .Text .Trim ()=="")
            {
                MessageBox.Show("Mode of payment is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtModeOfPayment.Focus();
                return;
            }
            if (txtBank .Text.Trim() == "")
            {
                MessageBox.Show("Bank is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBank .Focus();
                return;
            }
            if (txtPaid .Text.Trim() == "")
            {
                MessageBox.Show("Paid By is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPaid .Focus();
                return;
            }
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Amount is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return;
            }
            double amount = 0,exchangerateid=1 ;
            if (onewLoanTransaction == null)
                onewLoanTransaction = new LoanTransaction();
            if(onewLoan != null)
            {
                onewLoanTransaction.LoanId = onewLoan.LoanId;
                onewLoanType = oLoanType.GetLoanType(onewLoan.LoanTypeId);
                if(onewLoanType !=null)
                {
                    onewProduct = oProduct.GetProduct(onewLoanType.ProductId);
                    if(onewProduct !=null)
                    {
                        onewLoanTransaction.ProductId = onewProduct.ProductId;
                    }
                }
                
            }
           
            if (onewModeofpayment != null)
                onewLoanTransaction.ModeOfPaymentId = onewModeofpayment.ModeOfPaymentId;
            if(onewBANK !=null)
            {
                onewLoanTransaction.DebitGL = onewBANK.BankId;

            }
            
            onewLoanTransaction.PaidByName = txtPaid.Text;
            double .TryParse(txtAmount.Text, out amount);
            
                if(onewLoan.PrincipalBalance -amount <0)
                {
                    MessageBox.Show("Should not overpay", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAmount.Focus();
                    return;
                }
                else
                {
                    onewLoanTransaction.Principal = -amount;
                }
            
            
            
            onewLoanTransaction.Description = txtDescription.Text;
            onewLoanTransaction.TransactionDate = dtpTransactionDate.Value;
            onewLoanTransaction.ValueDate = dtpValueDate.Value;
            onewLoanTransaction.DefaultCurrencyId = odefCurrency.CurrencyId;
            onewLoanTransaction.ForeignCurrencyId = odefCurrency .CurrencyId;
            onewLoanTransaction.FCAmount = -amount;
            onewLoanTransaction.Principal  = -amount  ;
            onewLoanTransaction.ExchangeRate = 1;
            onewLoanTransaction.PrincipalBalanceValue = (onewLoan .PrincipalBalance ) - amount;
            if (odefCurrency .CurrencyId !=otrxCurrency.CurrencyId )
            {
                onewLoanTransaction.DefaultCurrencyId = odefCurrency.CurrencyId;
                onewLoanTransaction.ForeignCurrencyId = otrxCurrency .CurrencyId;
                onewLoanTransaction.FCAmount = -amount ;
                onewLoanTransaction.Principal  = -(ExchangedRate(amount, ref exchangerateid));
                onewLoanTransaction.ExchangeRate = exchangerateid ;
                onewLoanTransaction.PrincipalBalanceValue  =onewLoanTransaction.LoanPrincipalBalance +(-(ExchangedRate(amount, ref exchangerateid)));
            }
            if(SelMemberShareId >0)
            onewLoanTransaction.MemberShareId = SelMemberShareId ;
            string error = "";
            if(SelMemberShareId > 0)
            {
                onewLoanTransaction.TransactionId = onewLoanTransaction.transferLoanTransaction (false, ref error);
            }
            else
            {
                onewLoanTransaction.TransactionId = onewLoanTransaction.AddEditLoanTransaction(false, ref error);

            }
            
            if(error=="")
            {
                MessageBox.Show("Process suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoanRepayment();
                ClearText();
            }
            else
            {
                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }




        }
        private double ExchangedRate(double amount,ref double  rate)

        {
            double value=0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate oextr in myList )
            {
                if(odefCurrency.CurrencyId ==oextr.DefaultCurrencyId &&otrxCurrency.CurrencyId ==oextr.ForeignCurrencyId )
                {
                    rate  = oextr.ExchangeRates;
                    value = oextr.ExchangeRates  * amount;

                }
            }
            return value ;
        }
        private void btnModeOfPayment_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewModeofpayment = oModeofPayment.GetModeOfPayment(frm.selInt);
            if(onewModeofpayment !=null)
            {
                if(onewModeofpayment.IsTransfer)
                {
                    if(onewMember == null)
                    {
                        MessageBox.Show("Member is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberName.Focus();
                        return;
                    }
                    frmTransferFunds frmtrans = new frmTransferFunds();
                    frmtrans.MemberId = onewMember.MemberId;
                    frmtrans .ShowDialog();
                    SelMemberShareId  = frmtrans.SelMemberShareId ;
                    txtAmount.Text = frmtrans.TransferAmount.ToString("###,###.00");
                    txtAmount.Enabled = false;
                }
                txtModeOfPayment.Text = onewModeofpayment.Description;
                
            }
        }

        private void btnLoanType_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBANK = oBank.GetBank(frm.selInt);
            if(onewBANK !=null)
            {
                txtBank.Text = onewBANK.BankName;
                onewChartOfAccounts = oChartOfAccounts.GetChartOfAccount(onewBANK.GLId);
                if(onewChartOfAccounts !=null)
                {
                    txtDRGL.Text = onewChartOfAccounts.AccountName;
                }
            }
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objListLoanTransactions .SelectedObject !=null)
            {
                
                onewLoanTransaction = (Classes.LoanTransaction)objListLoanTransactions.SelectedObject;
                if(onewLoanTransaction !=null )
                {
                    double  num = 0;
                    if(onewLoanTransaction.FCAmount <0)
                    {
                        num = (onewLoanTransaction.FCAmount) * -1;
                        txtAmount .Text = num.ToString ();
                   
                   
                    this.selInt = onewLoanTransaction.TransactionId;
                   // txtAmount.Text = num .ToString ();
                    onewBANK = oBank.GetBank(onewLoanTransaction.DebitGL);
                    if(onewBANK !=null)
                    {
                        txtBank.Text = onewBANK.BankName;
                        onewChartOfAccounts = oChartOfAccounts.GetChartOfAccount(onewBANK.GLId);
                        if(onewChartOfAccounts !=null)
                        {
                            txtDRGL.Text = onewChartOfAccounts.AccountName;
                        }

                    }
                    txtDocumentNo.Text = onewLoanTransaction.DocumentNo;
                    txtDescription.Text = onewLoanTransaction.Description;
                    onewModeofpayment = oModeofPayment.GetModeOfPayment(onewLoanTransaction.ModeOfPaymentId);
                    if(onewModeofpayment != null)
                    {
                        txtModeOfPayment.Text = onewModeofpayment.Description;
                    }
                    dtpTransactionDate.Value = onewLoanTransaction.TransactionDate;
                    dtpValueDate.Value = onewLoanTransaction.ValueDate;
                    txtPaid.Text = onewLoanTransaction.PaidByName;
                    txtDescription.Text = onewLoanTransaction.Description;
                   
                    otrxCurrency = oCurrency.GetCurrency(onewLoanTransaction.ForeignCurrencyId);
                    if(otrxCurrency != null)
                    {
                        LoadingSelectedCurrencies = true;
                        cmbCurrency.SelectedIndex   = otrxCurrency.CurrencyId-1   ;
                        loadCurrencies();
                    }

                    }
                }
            }
            
        }
        private void LoadLoanRepayment()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();

            myList = oLoanTransaction.GetLoanTransactions();
            foreach (Classes .LoanTransaction olotrans in myList )
            {
                if(onewLoan !=null)
                {
                    if(onewLoan.LoanId ==olotrans .LoanId )
                    {
                        newList.Add(olotrans);
                    }
                }
            }
            objListLoanTransactions.SetObjects(newList);
        }

        private void objListLoans_DoubleClick(object sender, EventArgs e)
        {
            LoadLoanRepayment();
        }

        private void txtMemberNo_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            otrxCurrency = null;
            if (cmbCurrency.Items.Count <= 0) return;//return if there is no item in the combobox
            if (cmbCurrency.SelectedIndex < 0) return;//return if there is no item selected in the combobox
            object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if(myCurrency !=null)
            {
                otrxCurrency = myCurrency;
            }
        }
    }
}
