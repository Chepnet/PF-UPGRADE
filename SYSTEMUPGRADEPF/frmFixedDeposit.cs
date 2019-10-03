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
    public partial class frmFixedDeposit : Form
    {
        public frmFixedDeposit()
        {
            InitializeComponent();
        }
        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;

        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewexchangerate = null;

        Classes.Member omember = new Classes.Member();
        Classes.Member onewmember = null;

        Classes.ShareType osharetype = new Classes.ShareType();
        Classes.ShareType onewsharetype = null;

        Classes.Product oproduct = new Classes.Product();
        Classes.Product onewproduct = null;

        Classes.FixedDeposit ofixeddeposit = new Classes.FixedDeposit();
        Classes.FixedDeposit onewFixedDeposit = null;

        Classes.FixedDepositPayment oFixedDepositPayment = new Classes.FixedDepositPayment();
        Classes.FixedDepositPayment onewFixedDepositPayment = null;

        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;

        Classes.MemberShare oMembershare = new Classes.MemberShare();
        Classes.MemberShare onewMembershare = null;

        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;

        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;
        private int SelMemberShareId = 0;
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new SYSTEMUPGRADEPF.frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewmember = omember.GetMember(frm.selInt);
            if (onewmember != null)
            {
                txtMemberName.Text = onewmember.MemberName;
                txtCellNo.Text = onewmember.PhoneNumber;
                txtIdNumber.Text = onewmember.IdNumber;
                txtMemberNo.Text = onewmember.MemberNo;

                onewMemberDocument = oMemberDocument.GetMemberDocument(onewmember.MemberId);
                if (onewMemberDocument != null)
                {
                    ptbphoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
                }

            }
        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = omember.GetMembers();
                foreach (Classes.Member ome in myList)
                {
                    if (txtIdNumber.Text.Trim().ToLower() == ome.IdNumber.Trim().ToLower())
                    {
                        txtCellNo.Text = ome.PhoneNumber;
                        txtMemberName.Text = ome.MemberName;
                        txtMemberNo.Text = ome.MemberNo;
                        found = true;


                    }
                }
                if (!found)
                {

                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdNumber.Focus();
                }
            }
        }

        private void txtMemberNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = omember.GetMembers();
                foreach (Classes.Member ome in myList)
                {
                    if (txtMemberNo.Text.Trim().ToLower() == ome.MemberNo.Trim().ToLower())
                    {
                        txtCellNo.Text = ome.PhoneNumber;
                        txtMemberName.Text = ome.MemberName;
                        txtIdNumber.Text = ome.IdNumber;
                        found = true;


                    }
                }
                if (!found)
                {

                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberNo.Focus();
                }
            }
        }

        private void txtMemberNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCellNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = omember.GetMembers();
                foreach (Classes.Member ome in myList)
                {
                    if (txtCellNo.Text.Trim().ToLower() == ome.PhoneNumber.Trim().ToLower())
                    {
                        txtMemberNo.Text = ome.MemberNo;
                        txtMemberName.Text = ome.MemberName;
                        txtIdNumber.Text = ome.IdNumber;
                        found = true;


                    }
                }
                if (!found)
                {

                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCellNo.Focus();
                }
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            frmSearchShareTypes frm = new frmSearchShareTypes();
            frm.PickingValues = true;
            frm.FixedDeposit  = true;
            frm.ShowDialog();
            onewsharetype = osharetype.GetShareType(frm.selInt);
            if (onewsharetype != null)
            {
                txtShareType.Text = onewsharetype.Description;
                txtWithHoldTax.Text = onewsharetype.WithHoldingTax.ToString();
                txtInterestRate.Text = onewsharetype.FixedDepositInterestRate.ToString();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new SYSTEMUPGRADEPF.frmSearchProduct();
            frm.SavingsProduct = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewproduct = oproduct.GetProduct(frm.selInt);
            if (onewproduct != null)
            {
                txtMaturityGl.Text = onewproduct.Description;
            }


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearTexts();

        }

        private void ClearTexts()
        {
            onewmember = null;
            onewsharetype = null;
            onewproduct = null;
            txtMemberName.Text = "";
            txtMemberNo.Text = "";
            txtCellNo.Text = "";
            txtIdNumber.Text = "";
            txtShareType.Text = "";
            txtAmount.Text = "";
            dTPbBookingDate.Value = DateTime.Now;
            //dTPCloseDate.Value = DateTime.Now;
            dTPMaturityDate.Value = DateTime.Now;
            txtMaturityGl.Text = "";
            //txtClosedBy.Text = "";
            txtInterestRate.Text = "";
            txtWithHoldTax.Text = "";
            txtRemarks.Text = "";
            txtNoOfDays.Text = "";
            chkIsActive.Checked = true;
            chkMturityAtEvryEndOfMonth.Checked = false;
            cmbActionOnClosure.SelectedIndex = -1;
            ptbphoto.Image = null;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchFixedDeposit frm = new frmSearchFixedDeposit();
            frm.ShowDialog();
            onewFixedDeposit = ofixeddeposit.GetFixedDeposit(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewFixedDeposit != null)
            {

                txtAmount.Text = onewFixedDeposit.Amount.ToString("###,###.00");
                //txtBranch.Text = onewFixedDeposit.BranchId.ToString();
                //txtClosedBy.Text = onewFixedDeposit.ClosedBy;
                dTPbBookingDate.Value = onewFixedDeposit.BookingDate;
                //dTPCloseDate.Value = onewFixedDeposit.CloseOn;
                dTPMaturityDate.Value = onewFixedDeposit.MaturityDate;
                chkIsActive.Checked = onewFixedDeposit.IsActive;
                chkMturityAtEvryEndOfMonth.Checked = onewFixedDeposit.MatureAtEveryEndOfMonth;
                txtInterestRate.Text = onewFixedDeposit.InterestRate.ToString();
                txtWithHoldTax.Text = onewFixedDeposit.WithHoldingTaxRate.ToString();
                cmbActionOnClosure.SelectedIndex = onewFixedDeposit.ActionOnClosure;
                txtRemarks.Text = onewFixedDeposit.Remarks;
                txtNoOfDays.Text = onewFixedDeposit.NoOfDays.ToString();
                onewsharetype = osharetype.GetShareType(onewFixedDeposit.ShareTypeId);
                if (onewsharetype != null)
                {
                    txtShareType.Text = onewsharetype.Description;
                }
                onewproduct = oproduct.GetProduct(onewFixedDeposit.MaturityAC);
                if (onewproduct != null)
                {
                    txtMaturityGl.Text = onewproduct.Description;
                }
                onewmember = omember.GetMember(onewFixedDeposit.MemberId);
                if (onewmember != null)
                {
                    txtMemberName.Text = onewmember.MemberName;
                    txtMemberNo.Text = onewmember.MemberNo;
                    txtCellNo.Text = onewmember.PhoneNumber;
                    txtIdNumber.Text = onewmember.IdNumber;
                }
                if (onewFixedDeposit.IsActive)
                {
                    btnCloseFD.Enabled = true;
                }
                else
                {
                    btnCloseFD.Enabled = false;
                }
                displayTransactions ();
                for (int i = 0; i < cmbCurrency.Items.Count; i++)
                {
                    object obj = ((Classes.ItemData.itemData)(cmbCurrency.Items[i]))._itemData;
                    Classes.Currency myCurrency = (Classes.Currency)obj;
                    if (myCurrency != null)
                    {
                        if (myCurrency.CurrencyId == onewFixedDeposit .ForeignCurrencyId)
                        {
                            cmbCurrency.SelectedIndex = i;

                            break;
                        }
                    }
                }
                loadFixedDepositCurrencies();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtMemberNo.Text.Trim() == "")
            {
                MessageBox.Show("Member is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberNo.Focus();
                return;
            }
            if (txtShareType.Text.Trim() == "")
            {
                MessageBox.Show("Fixed Deposit is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtShareType.Focus();
                return;
            }
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Amount to fix  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return;
            }
            if (txtNoOfDays.Text.Trim() == "")
            {
                MessageBox.Show("No. of Days  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNoOfDays.Focus();
                return;
            }
            if (txtMaturityGl.Text.Trim() == "")
            {
                MessageBox.Show("Maturity Account  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaturityGl.Focus();
                return;
            }
            if (cmbActionOnClosure.SelectedIndex == -1)
            {
                MessageBox.Show("Action on Closure  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbActionOnClosure.Focus();
                return;
            }
            int NoOfDays=0, branchid = 0;
            
            double amount=0, interestrate=0, withholdingtaxrate = 0,exchangerateid=1;
            if (onewFixedDeposit == null)
                onewFixedDeposit = new Classes.FixedDeposit();
            if (onewmember != null)
            {
                onewFixedDeposit.MemberId = onewmember.MemberId;
            }
            if (onewsharetype != null)
            {
                onewFixedDeposit.ShareTypeId = onewsharetype.ShareTypeId;
            }
            onewFixedDeposit.BookingDate = dTPbBookingDate.Value;
            double.TryParse(txtAmount.Text, out amount);
            int.TryParse(txtNoOfDays.Text, out NoOfDays);
            onewFixedDeposit.NoOfDays = NoOfDays;
            double.TryParse(txtInterestRate.Text, out interestrate);
            onewFixedDeposit.InterestRate = interestrate;
            onewFixedDeposit.ActionOnClosure = cmbActionOnClosure.SelectedIndex;
            onewFixedDeposit.MaturityDate = dTPMaturityDate.Value;
            if (onewproduct != null)
                onewFixedDeposit.MaturityAC = onewproduct.ProductId;
            double.TryParse(txtWithHoldTax.Text, out withholdingtaxrate);
            onewFixedDeposit.WithHoldingTaxRate = withholdingtaxrate;
            onewFixedDeposit.Remarks = txtRemarks.Text;
            onewFixedDeposit.MatureAtEveryEndOfMonth = chkMturityAtEvryEndOfMonth.Checked;
            onewFixedDeposit.IsActive = chkIsActive.Checked;
            onewFixedDeposit.DefaultCurrencyId = odefCurrency.CurrencyId;
            onewFixedDeposit.ForeignCurrencyId = odefCurrency.CurrencyId;
            onewFixedDeposit.ExchangeRate = exchangerateid;
            onewFixedDeposit.Amount = amount ;
            onewFixedDeposit.FCAmount = amount;
            if (odefCurrency.CurrencyId !=otrxCurrency.CurrencyId)
            {
                onewFixedDeposit.DefaultCurrencyId = odefCurrency.CurrencyId;
                onewFixedDeposit.ForeignCurrencyId = otrxCurrency .CurrencyId;
                onewFixedDeposit.Amount = ExchangeRateId(amount, ref exchangerateid);
                onewFixedDeposit.ExchangeRate = exchangerateid;
                onewFixedDeposit.FCAmount = amount;
            }
            string error = "";
            onewFixedDeposit.FixedDepositId = onewFixedDeposit.AddEditFixedDeposit(false, ref error);
            if (error == "")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadFixedDepositCurrencies();
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private double ExchangeRateId(double amount,ref double rate)
        {
            double val = 0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate oexrate in myList )
            {
                if((odefCurrency.CurrencyId ==oexrate.DefaultCurrencyId) &&(otrxCurrency.CurrencyId ==oexrate.ForeignCurrencyId) )
                {
                    rate = oexrate.ExchangeRates;
                    val = amount * oexrate.ExchangeRates;
                }
            }
            return val;

        }
        private void txtNoOfDays_TextChanged(object sender, EventArgs e)
        {
            int noofdays = 0;
            int.TryParse(txtNoOfDays.Text, out noofdays);
            DateTime date1 = dTPbBookingDate.Value;
            dTPMaturityDate.Value = date1.AddDays(noofdays);

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewFixedDeposit == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewFixedDeposit.AddEditFixedDeposit(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTexts();
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            MoveToRecord(false);
        }
        public void MoveToRecord(bool MoveToNext)
        {
            int counter = 0;
            ArrayList myList = ofixeddeposit.GetFixedDeposits();
            ArrayList newLst = new ArrayList();
            if (onewFixedDeposit != null)
            {


                foreach (Classes.FixedDeposit ofix in myList)
                {
                    if (onewFixedDeposit.FixedDepositId == ofix.FixedDepositId)
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (MoveToNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }

            if (MoveToNext)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;


            onewFixedDeposit = (Classes.FixedDeposit)myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            MoveToRecord(true);
        }

        private void btnCloseFD_Click(object sender, EventArgs e)
        {

            if (onewFixedDeposit != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;
                else
                {


                    string error = "";
                    onewFixedDeposit.EditFixedDeposit(false, ref error);
                    if (error == "")
                    {
                        MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnCloseFD.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (onewFixedDeposit == null)
            {
                MessageBox.Show("Fixed Deposit to pay is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        public void ClearPaymentTexts()
        {
            dtPTransDate.Value = DateTime.Now;
            dtPValueDate.Value = DateTime.Now;
            txtAmountPaid.Text = "";
            onewModeOfPayment = null;
            onewBank = null;
            txtPayMode.Text = "";
            txtDocumentNo.Text = "";
            txtBank.Text = "";
            txtPaidBy.Text = "";
            txtComment.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (onewFixedDeposit == null)
            {
                MessageBox.Show("Fixed Deposit booking is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberName.Focus();
                return;

            }
            if (txtAmountPaid.Text.Trim() == "")
            {
                MessageBox.Show("Amount to pay  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmountPaid.Focus();
                return;
            }
            if (txtDocumentNo.Text.Trim() == "")
            {
                MessageBox.Show("Document No is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentNo.Focus();
                return;
            }
            if (onewBank == null)
            {
                MessageBox.Show("Bank is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBank.Focus();
                return;
            }
            if (onewModeOfPayment == null)
            {
                MessageBox.Show("Mode Of Payment is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPayMode.Focus();
                return;
            }
            double amountpaid = 0,exchangerateid=0;
            if (onewFixedDepositPayment == null)
                onewFixedDepositPayment = new Classes.FixedDepositPayment();

            if (onewFixedDeposit != null)
            {
                onewsharetype = osharetype.GetShareType(onewFixedDeposit.ShareTypeId);
                if (onewsharetype != null)
                {
                    onewFixedDepositPayment.ShareTypeId = onewsharetype.ShareTypeId;
                }
                onewmember = omember.GetMember(onewFixedDeposit.MemberId);
                if (onewmember != null)
                {
                    onewFixedDepositPayment.MemberId = onewmember.MemberId;
                }

                onewFixedDepositPayment.FixedDepositId = onewFixedDeposit.FixedDepositId;
                onewFixedDepositPayment.BookingDate = onewFixedDeposit.BookingDate;
                onewFixedDepositPayment.Amount = onewFixedDeposit.Amount;
                onewFixedDepositPayment.NoOfDays = onewFixedDeposit.NoOfDays;
                onewFixedDepositPayment.InterestRate = onewFixedDeposit.InterestRate;
                onewFixedDepositPayment.WithHoldingTaxRate = onewFixedDeposit.WithHoldingTaxRate;
                onewFixedDepositPayment.ActionOnClosure = onewFixedDeposit.ActionOnClosure;
                onewFixedDepositPayment.MaturityDate = onewFixedDeposit.MaturityDate;
                onewproduct = oproduct.GetProduct(onewFixedDeposit.MaturityAC);
                if (onewproduct != null)
                {
                    onewFixedDepositPayment.MaturityAC = onewproduct.ProductId;
                }

                onewFixedDepositPayment.Remarks = onewFixedDeposit.Remarks;
                onewFixedDepositPayment.IsActive = onewFixedDeposit.IsActive;
                onewFixedDepositPayment.MatureAtEveryEndOfMonth = onewFixedDeposit.MatureAtEveryEndOfMonth;

            }
            onewFixedDepositPayment.TransactionDate = dtPTransDate.Value;
            onewFixedDepositPayment.ValueDate = dtPValueDate.Value;
            double.TryParse(txtAmountPaid.Text, out amountpaid);
            ////onewFixedDepositPayment.AmountPaid = amountpaid;
            if (onewBank != null)
            {
                onewFixedDepositPayment.BankId = onewBank.BankId;

            }
            if (onewModeOfPayment != null)
            {
                onewFixedDepositPayment.PaymodeId = onewModeOfPayment.ModeOfPaymentId;
            }
            onewFixedDepositPayment.DocumentNo = txtDocumentNo.Text;
            onewFixedDepositPayment.MemberShareId = this.SelMemberShareId;
            onewFixedDepositPayment.Description = txtPaidBy.Text;
            onewFixedDepositPayment.Comment = txtComment.Text;
            onewFixedDepositPayment .DefaultCurrencyId = onewFixedDeposit .DefaultCurrencyId ;
            onewFixedDepositPayment .ForeignCurrencyId = onewFixedDeposit.ForeignCurrencyId ;
            onewFixedDepositPayment .ExchangeRate = onewFixedDeposit.ExchangeRate ;
            onewFixedDepositPayment .Amount =amountpaid  ;
            onewFixedDepositPayment .FCAmount = amountpaid ;
            if (odefCurrency.CurrencyId != otrxCurrency.CurrencyId)
            {
                onewFixedDepositPayment .DefaultCurrencyId = odefCurrency.CurrencyId;
                onewFixedDepositPayment .ForeignCurrencyId = otrxCurrency.CurrencyId;
                onewFixedDepositPayment .Amount = ExchangeRateId(amountpaid , ref exchangerateid);
                onewFixedDepositPayment.ExchangeRate = exchangerateid;
                onewFixedDepositPayment.FCAmount = amountpaid ;
            }
            string error = "";
            if(SelMemberShareId >0)
            {
                onewFixedDepositPayment.FixedDepositPaymentId = onewFixedDepositPayment.transaferFixedDepositPayment(false, ref error);
            }
            else
            {
                onewFixedDepositPayment.FixedDepositPaymentId = onewFixedDepositPayment.AddEditFixedDepositPayment(false, ref error);
            }
            
            if (error == "")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPaymentTexts();
                dtPTransDate.Focus();
                onewFixedDepositPayment = null;
              displayTransactions  ();

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
    

        private void btnPayMode_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewModeOfPayment = oModeOfPayment.GetModeOfPayment(frm.selInt);
            if (onewModeOfPayment != null)
            {
                if(onewModeOfPayment .IsTransfer)
                {
                    frmTransferFunds frmtrans = new frmTransferFunds();
                    frmtrans.MemberId = onewmember.MemberId;
                  
                    
                    frmtrans.ShowDialog();
                    SelMemberShareId = frmtrans.SelMemberShareId;
                    txtAmountPaid.Text = frmtrans.TransferAmount.ToString("###,###.00");
                }
                txtPayMode.Text = onewModeOfPayment.Description;
                txtPayMode.Enabled = false;

            }
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if (onewBank != null)
            {

                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId );
                if (onewChartOfAccount != null)
                {
                    txtDRGL.Text = onewChartOfAccount.AccountName;
                }

                txtBank.Text = onewBank.BankName;
            }
        }

        private void frmFixedDeposit_Load(object sender, EventArgs e)
        {
            cmbCurrency.Items.Clear();
            int counter = 0, defindex = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocurcy in myList )
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurcy.Code, ocurcy));
                if(ocurcy.IsDefaultCurrency )
                {
                    odefCurrency = ocurcy;
                    defindex = counter;

                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defindex;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            if (onewFixedDeposit == null)
            {
                MessageBox.Show("Fixed Deposit is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            

        }

        private void loadFixedDepositCurrencies()
        {
            if (onewFixedDeposit != null)
            {
                cmbCurrencypay.Items.Clear();
                int counter = 0, defindex = 0;
                ArrayList myList = oCurrency.GetCurrencies();
                foreach (Classes.Currency ocurcy in myList)
                {
                    cmbCurrencypay.Items.Add(new Classes.ItemData.itemData(ocurcy.Code, ocurcy));
                    if (ocurcy.CurrencyId == onewFixedDeposit.ForeignCurrencyId)
                    {
                        otrxCurrency = ocurcy;
                        defindex = counter;

                    }
                    counter++;
                }
                cmbCurrencypay.SelectedIndex = defindex;
                cmbCurrencypay.Enabled = false;

            }
        }

        private void objListTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

      private  void displayTransactions()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oFixedDepositPayment .GetFixedDepositPayments ();
            foreach (Classes.FixedDepositPayment  oact in myList)
            {
                if (onewFixedDeposit  != null)
                {
                    if (onewFixedDeposit.FixedDepositId  == oact.FixedDepositId )
                        newList.Add(oact);

                }
            }
            objList  .SetObjects(newList);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;
            object obj = (( Classes.ItemData.itemData )(cmbCurrency.SelectedItem))._itemData ;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if(myCurrency !=null)
            {
                otrxCurrency = myCurrency;
            }
        }
    }

}
