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
using System.Xml;

namespace SYSTEMUPGRADEPF
{
    public partial class frmCashWithdrawal : Form
    {
        public frmCashWithdrawal()
        {
            InitializeComponent();
        }
        private string xmlChargeIds = "";
        private string xmlChargeAmounts = "";
        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.MemberShare oMemberShare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;
        Classes.ModeOfPayment oModeofPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment = null;

        Classes.CashWithdrawals oCashWithdrawal = new Classes.CashWithdrawals();
        Classes.CashWithdrawals onewCashWithdrawal = null;
        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;
        Classes.ACTransactions oACTransaction = new Classes.ACTransactions();
        Classes.ACTransactions onewACTransaction = null;

        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;

        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangeRtae = null;
        public int selInt = 0;


        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new SYSTEMUPGRADEPF.frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember = oMember.GetMember(frm.selInt);
            if (onewMember != null)
            {
                txtMemberName.Text = onewMember.MemberName;
                txtMemberNo.Text = onewMember.MemberNo;
                txtCellNo.Text = onewMember.PhoneNumber;
                txtIdNumber.Text = onewMember.IdNumber;
            }
            getMemberShare();
        }
        private void getMemberShare()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oMemberShare.GetMemberShares();
            foreach (Classes.MemberShare omesha in myList)
            {
                if (onewMember != null)
                {


                    if (onewMember.MemberId == omesha.MemberId)
                    {
                        newList.Add(omesha);
                    }
                }
            }
            objListMemberShares.SetObjects(newList);
        }
        private void displayTransactions()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oACTransaction .GetACTransactions  ();
            foreach (Classes.ACTransactions   oact in myList)
            {
                if (onewMemberShare != null)
                {
                    if (onewMemberShare.MemberShareId == oact.MemberShareId)
                        newList.Add(oact);

                }
            }
            objTransactions.SetObjects(newList);
        }
        private void ClearText()
        {
            onewMember = null;
            onewMemberShare = null;

            txtMemberName.Text = "";
            txtCellNo.Text = "";
            txtIdNumber.Text = "";
            txtMemberNo.Text = "";
            ClearTransaction();
            objListMemberShares.Items.Clear();
            objTransactions.Items.Clear();


        }
        private void objListMemberShares_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListMemberShares.SelectedObject != null)
                onewMemberShare = (Classes.MemberShare)objListMemberShares.SelectedObject;
            bool CanBeWithdrawn = false;
            if (onewMemberShare != null)
            {
                
                onewShareType = oShareType.GetShareType(onewMemberShare.ShareTypeId);
                {
                    if(onewShareType.CanBeWithDrawn )
                    {
                        CanBeWithdrawn = true;
                        
                    }
                }
            }
            if(CanBeWithdrawn )
            {
                this.selInt = onewMemberShare.MemberShareId;
                displayTransactions();
            }
            else
            {
                MessageBox.Show("Share Type cannot be withdrawn", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
                
        }
        private void ClearTransaction()
        {
            txtAmount.Text = "";
            txtPayMode.Text = "";
            txtDRGL.Text = "";
            txtDocumentNo.Text = "";
            txtComment.Text = "";
            dtPTransDate.Value = DateTime.Now;
            dtPValueDate.Value = DateTime.Now;
            txtBank.Text = "";
            txtPaidBy.Text = "";
            onewBank = null;
            onewChartOfAccount = null;
            onewModeOfPayment = null;
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewACTransaction  = null;
            txtMemberName.Focus();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchACTrasaction  frm = new SYSTEMUPGRADEPF.frmSearchACTrasaction  ();
            frm.ShowDialog();
            onewACTransaction  = oACTransaction .GetACTransaction  (frm.selInt);
            displayInfo();
        }
        private void displayInfo()
        {
            if (onewACTransaction  != null)
            {
                onewMember = oMember.GetMember(onewACTransaction .MemberShareId);
                if (onewMember != null)
                {
                    txtMemberName.Text = onewMember.MemberName;
                    txtCellNo.Text = onewMember.PhoneNumber; ;
                    txtIdNumber.Text = onewMember.IdNumber; ;
                    txtMemberNo.Text = onewMember.MemberNo;
                }

                

                getMemberShare();
               // displayTransactions();
            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oCashWithdrawal.GetCashWithdrawals ();

            int counter = 0;

            if (onewCashWithdrawal != null)
            {
                foreach (Classes.CashWithdrawals  memshar in myList)
                {
                    if (memshar.CashWithdrawalId  == onewCashWithdrawal.CashWithdrawalId )
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (movingNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }

            if (movingNext)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;


            onewCashWithdrawal = (Classes.CashWithdrawals )myList[counter];
            displayInfo();
            getMemberShare();
            displayTransactions();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewCashWithdrawal == null)
            {
                MessageBox.Show("Item to Delete is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewCashWithdrawal.AddEditCashWithdrawal (true, ref error);
                if (error == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();

                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewMemberShare == null)
            {
                MessageBox.Show("Member Account is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberName.Focus();
                return;
            }
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Amount is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return;
            }
            if (txtDocumentNo.Text.Trim() == "")
            {
                MessageBox.Show("Document No is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentNo.Focus();
                return;
            }
            if (txtBank.Text.Trim() == "")
            {
                MessageBox.Show("Bank is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBank.Focus();
                return;
            }
            if (txtPayMode.Text.Trim() == "")
            {
                MessageBox.Show("Mode Of Payment is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPayMode.Focus();
                return;
            }
            if (odefCurrency == null)
            {
                MessageBox.Show("Default currency is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCurrency.Focus();
                return;
            }
            string err = "";

            if (otrxCurrency == null)
            {
                MessageBox.Show("Transacting currency is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbCurrency.Focus();
                return;
            }

            double amount = 0, exchangerateid = 1, commission = 0;

            if (onewACTransaction == null)
                onewACTransaction = new Classes.ACTransactions();
            if (onewMemberShare != null)
                onewACTransaction.MemberShareId = onewMemberShare.MemberShareId;
            onewACTransaction.TransDate = dtPTransDate.Value;
            onewACTransaction.ValueDate = dtPValueDate.Value;

            double.TryParse(txtAmount.Text, out amount);

            if (onewBank != null)
                onewACTransaction.BankId = onewBank.BankId;
            if (onewModeOfPayment != null)
                onewACTransaction.ModeOfPaymentId = onewModeOfPayment.ModeOfPaymentId;
            //onewACTransaction.SourceACId = selMemberShareId;
            onewACTransaction.Remarks = txtComment.Text;
            onewACTransaction.DocumentNo = txtDocumentNo.Text;
            //onewACTransaction.IsActive = chkIsActive.Checked;
            onewACTransaction.Description = txtPaidBy.Text;
            onewACTransaction.Amount = amount;
            //double.TryParse(txtCommision.Text, out commission);
            //onewACTransaction.Commision = commission;

            onewACTransaction.DefaultCurrencyId = odefCurrency.CurrencyId;
            onewACTransaction.ForeignCurrencyId = odefCurrency.CurrencyId;
            onewACTransaction.Amount = amount;
            onewACTransaction.ExchangeRates = exchangerateid;
            onewACTransaction.FCAmount = amount;



            //ExchangeRates();
            if (otrxCurrency != null)
            {
                if (otrxCurrency.CurrencyId != odefCurrency.CurrencyId)
                {
                    //work out the exchange rate value
                    //exchangedAmount = (fcAmount * exchangerateid);
                    onewACTransaction.DefaultCurrencyId = odefCurrency.CurrencyId;
                    onewACTransaction.ForeignCurrencyId = otrxCurrency.CurrencyId;
                    onewACTransaction.Amount = ExchangeRateId(amount, ref exchangerateid);
                    onewACTransaction.ExchangeRates = exchangerateid;
                    onewACTransaction.FCAmount = amount;
                }
            }
          


          
           
                onewACTransaction.ACTransactionId = onewACTransaction.AddEditACTransactions(false, xmlChargeIds, xmlChargeAmounts, ref err);

           



            if (err == "")
            {
                displayTransactions();
                getMemberShare();
                ClearTransaction();
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewACTransaction = null;

            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnPayMode_Click(object sender, EventArgs e)
        {

            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewModeOfPayment = oModeofPayment.GetModeOfPayment(frm.selInt);
            if (onewModeOfPayment != null)
            {
                if(onewModeOfPayment .IsTransfer )
                {
                    MessageBox.Show("Transfer is not allowed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPayMode.Focus();
                    return;
                }
                else
                {
                    txtPayMode.Text = onewModeOfPayment.Description;
                }
                

            }
        }
        private double ExchangeRateId(double amount,ref double rate)
        {
            double val = 0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate excrat in myList )
            {
                if((odefCurrency.CurrencyId ==excrat.DefaultCurrencyId )&&(otrxCurrency.CurrencyId ==excrat.ForeignCurrencyId ))
                {
                    rate = excrat.ExchangeRates;
                    val = amount * excrat.ExchangeRates;
                }
            }
            return val;

        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if (onewBank != null)
            {
                txtBank.Text = onewBank.BankName;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.BankId);
                if (onewChartOfAccount != null)
                    txtDRGL.Text = onewChartOfAccount.AccountName;
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            //txtAmount.Text = "-" + txtAmount.Text;
        }

        private void objTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void objListMemberShares_DoubleClick(object sender, EventArgs e)
        {
            displayTransactions();
        }

        private void frmCashWithdrawal_Load(object sender, EventArgs e)
        {
            cmbCurrency.Items.Clear();
            int counter = 0, defindex = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocurncy in myList)
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurncy.Code, ocurncy));
                if(ocurncy.IsDefaultCurrency)
                {
                    odefCurrency = ocurncy;
                    defindex = counter;
                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defindex;
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;
            object obj = (( Classes.ItemData.itemData ) (cmbCurrency.SelectedItem  ))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if(myCurrency !=null)
            {
                otrxCurrency = myCurrency;
            }

        }
    }
}
