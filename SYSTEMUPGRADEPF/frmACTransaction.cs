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
    public partial class frmACTransaction : Form
    {
        public frmACTransaction()
        {
            InitializeComponent();
        }

        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency onewCurrency = null;
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;

        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();




        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.MemberShare oMembershare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;
        Classes.MemberShare onewTransferMemberShare = null;
        Classes.ACTransactions oACTrasaction = new Classes.ACTransactions();
        Classes.ACTransactions onewACTransaction = null;
        Classes.ACTransactions onewTransferACTransaction = null;
        public int selInt = 0;
        public int selMemberShareId = 0;

        private double amount = 0;
        private string xmlChargeIds = "";
        private string xmlChargeAmounts = "";
        public double Amount
        {
            get { return amount; }
            set
            {
                amount = value;
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
                if (onewModeOfPayment.IsTransfer)
                {
                    frmTransferFunds frmtrans = new frmTransferFunds();
                    if (onewMember == null)
                    {
                        MessageBox.Show("Member is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberName.Focus();
                        return;
                    }
                    if (onewMemberShare == null)
                    {
                        MessageBox.Show("Member Share  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }
                    if (onewMember != null)
                    {
                        frmtrans.MemberId = onewMember.MemberId;
                    }

                    if (onewMemberShare != null)
                    {
                        frmtrans.MemberShareId = onewMemberShare.MemberShareId;
                    }
                    frmtrans.ShowDialog();
                    //read selected
                    selMemberShareId = frmtrans.SelMemberShareId;
                    txtAmount.Text = frmtrans.TransferAmount.ToString("###,###.00");
                    txtAmount.Enabled = false;


                }
                txtPayMode.Text = onewModeOfPayment.Description;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if (onewBank != null)
            {
                txtBank.Text = onewBank.BankName;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                if (onewChartOfAccount != null)
                    txtDRGL.Text = onewChartOfAccount.AccountName;
            }

        }

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

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListMemberShares.SelectedObject != null)
                onewMemberShare = (Classes.MemberShare)objListMemberShares.SelectedObject;
            if (onewMemberShare != null)
                this.selInt = onewMemberShare.MemberShareId;
            displayTransactions();
        }

        private void getMemberShare()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oMembershare.GetMemberShares();
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewACTransaction = null;
            txtMemberName.Focus();

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

            double amount = 0, exchangerateid = 1,commission = 0;

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
            onewACTransaction.SourceACId = selMemberShareId;
            onewACTransaction.Remarks = txtComment.Text;
            onewACTransaction.DocumentNo = txtDocumentNo.Text;
            //onewACTransaction.IsActive = chkIsActive.Checked;
            onewACTransaction.Description = txtPaidBy.Text;
            onewACTransaction.Amount = amount;
            double.TryParse(txtCommision .Text, out commission );
            onewACTransaction.Commision = commission; 

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
                    onewACTransaction.Amount = exchangedRate(amount, ref exchangerateid);
                    onewACTransaction.ExchangeRates = exchangerateid;
                    onewACTransaction.FCAmount = amount;
                }
            }
            if(commission >onewACTransaction .Amount  )
            {
                MessageBox.Show("Commision should be higher than the Amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return;
            }


            if (selMemberShareId > 0)
            {
                onewMemberShare = oMembershare.GetMemberShare(selMemberShareId);
                if (onewACTransaction.Amount > onewMemberShare.Balance)
                {
                    MessageBox.Show("Cannot transfer more than the account balance", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtAmount.Focus();
                    return;

                }
                onewACTransaction.ACTransactionId = onewACTransaction.transferACTransaction(false, xmlChargeIds ,xmlChargeAmounts ,ref err);

            }



            else
            {
                onewACTransaction.ACTransactionId = onewACTransaction.AddEditACTransactions(false,xmlChargeIds ,xmlChargeAmounts  , ref err);

            }



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



        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewACTransaction == null)
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
                onewACTransaction.AddEditACTransactions(true,xmlChargeIds,xmlChargeAmounts , ref error);
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

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oACTrasaction.GetACTransactions();

            int counter = 0;

            if (onewACTransaction != null)
            {
                foreach (Classes.ACTransactions memshar in myList)
                {
                    if (memshar.ACTransactionId == onewACTransaction.ACTransactionId)
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


            onewACTransaction = (Classes.ACTransactions)myList[counter];
            displayInfo();
            getMemberShare();
            displayTransactions();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchACTrasaction frm = new frmSearchACTrasaction();
            frm.ShowDialog();
            onewACTransaction = oACTrasaction.GetACTransaction(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewACTransaction != null)
            {
                onewMember = oMember.GetMember(onewACTransaction.MemberShareId);
                if (onewMember != null)
                {
                    txtMemberName.Text = onewMember.MemberName;
                    txtCellNo.Text = onewMember.PhoneNumber; ;
                    txtIdNumber.Text = onewMember.IdNumber; ;
                    txtMemberNo.Text = onewMember.MemberNo;
                }
                getMemberShare();
                displayTransactions();
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void objTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displayTransactions()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oACTrasaction.GetACTransactions();
            foreach (Classes.ACTransactions oact in myList)
            {
                if (onewMemberShare != null)
                {
                    if (onewMemberShare.MemberShareId == oact.MemberShareId)
                        newList.Add(oact);

                }
            }
            objTransactions.SetObjects(newList);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void objListMemberShares_DoubleClick(object sender, EventArgs e)
        {
            displayTransactions();
        }

        private void frmACTransaction_Load(object sender, EventArgs e)
        {
            //LoadCurrencies();
            // LoadForeignCurrencies();
            loadCurrencies();
        }

        private void cmbDefaultCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oExchangeRate.GetExchangeRates();

            int item = 0;
            foreach (Classes.ExchangeRate oca in myList)
            {
                item = oca.DefaultCurrencyId;



            }


        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = oCurrency.GetCurrencies();
            int defindex = 0, counter = 0;

            foreach (Classes.Currency ocurr in myList)
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurr.Code, ocurr));
                if (ocurr.IsDefaultCurrency)
                {
                    odefCurrency = ocurr;
                    defindex = counter;
                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defindex;
        }
        private void LoadForeignCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oCurrency.GetCurrencies();

            int defindex = 0, counter = 0;


            foreach (Classes.Currency oca in myList)
            {
                string item = oca.Name;
                if (oca.IsDefaultCurrency)
                {
                    //cmbDefaultCurrency.SelectedText  = oca.Name;
                    //cmbCurrency.SelectedText  = oca.Name ;
                    //defaultCurrencyId = oca.CurrencyId;
                    defindex = counter;
                }
                //cmbDefaultCurrency.Items.Add(item);
                //cmbForeignCurrency.Items.Add(item);
                cmbCurrency.Items.Add(item);
                // int index=cmbCurrency.SelectedText (index )
                counter++;
            }
            cmbCurrency.SelectedIndex = defindex;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList mylist = new ArrayList();
            mylist = oExchangeRate.GetExchangeRates();

            double ratevalue = 0;

            bool rate = false;
            foreach (Classes.ExchangeRate ocha in mylist)
            {
                int val = 0;
                int too = 0;
                if (onewCurrency.CurrencyId == ocha.DefaultCurrencyId)
                {
                    val = ocha.ExchangeRateId;
                }
                else
                {
                    val = 0;
                }
                if (onewCurrency.CurrencyId == ocha.ForeignCurrencyId)
                {
                    too = ocha.ExchangeRateId;
                }
                if (val == too)
                {
                    rate = true;
                    ratevalue = ocha.ExchangeRates;
                    break;
                }

            }
            if (rate)
            {
                //txtExchangeRate.Text = ratevalue.ToString ();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            int defaultexchangerateid = 0;
            int foreignexchangerateid = 0;
            double exchangerateid = 0;
            double exchangedAmount = 0;
            bool rated = false;
            myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate ocha in myList)
            {

                if (ocha.DefaultCurrencyId == onewCurrency.CurrencyId && ocha.ForeignCurrencyId == onewCurrency.CurrencyId)
                {
                    defaultexchangerateid = ocha.ExchangeRateId;
                    foreignexchangerateid = ocha.ExchangeRateId;
                    if (defaultexchangerateid == foreignexchangerateid)
                    {

                        exchangerateid = ocha.ExchangeRates;
                        rated = true;
                        break;
                    }

                }

            }

            if (rated)
            {

                // txtExchangeRate.Text = exchangerateid .ToString();
                double.TryParse(txtAmount.Text, out exchangedAmount);
                // txtExchangeRate .Text = (exchangedAmount * exchangerateid).ToString ();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            //ExchangeRates();
        }

        private double exchangedRate(double amount, ref double rate)
        {

            ArrayList myList = new ArrayList();
            double value = 0;

            myList = oExchangeRate.GetExchangeRates();


            foreach (Classes.ExchangeRate oExcr in myList)
            {
                if ((oExcr.DefaultCurrencyId == odefCurrency.CurrencyId) && (oExcr.ForeignCurrencyId == otrxCurrency.CurrencyId))
                {
                    value = oExcr.ExchangeRates * amount;
                    rate = oExcr.ExchangeRates;
                    break;

                }

            }
            return value;
        }
        //private void ExchangeRates()
        //{

        //    ArrayList myList = new ArrayList();
        //    int SystemdefaultexchangerateId = 0;
        //    int foreignexchangerateid, currencyId = 0;
        //    double exchangerateid = 0;
        //    double exchangedAmount = 0;
        //    bool rated = false;
        //    double fcAmount = 0;
        //    double.TryParse(txtAmount.Text, out fcAmount );
        //                myList = oExchangeRate.GetExchangeRates();
        //    onewCurrency = oCurrency.GetCurrency(cmbCurrency.SelectedIndex + 1);
        //    // onewCurrency = oCurrency.GetCurrency(cmbDefaultCurrency.SelectedIndex + 1);
        //    // onewForeignCurrency = oCurrency.GetCurrency(cmbForeignCurrency.SelectedIndex + 1);

        //    foreach (Classes.ExchangeRate ocha in myList)
        //    {

        //        if (ocha.ForeignCurrencyId == defaultCurrencyId )
        //        {
        //            if (ocha.DefaultCurrencyId == onewCurrency.CurrencyId)
        //            {
        //                SystemdefaultexchangerateId = ocha.ExchangeRateId;
        //                foreignexchangerateid = ocha.ExchangeRateId;
        //                if (SystemdefaultexchangerateId == foreignexchangerateid)
        //                {

        //                    exchangerateid = ocha.ExchangeRates;
        //                    // defaultCurrencyId  = ocha.DefaultCurrencyId;
        //                    currencyId = ocha.DefaultCurrencyId ;
        //                    rated = true;
        //                    break;
        //                }
        //            }


        //        }

        //    }

        //    if (rated)
        //    {

        //        txtDocumentNo.Text = exchangerateid.ToString();

        //        exchangedAmount    = (fcAmount  * exchangerateid);
        //        onewACTransaction.DefaultCurrencyId = defaultCurrencyId ;
        //        onewACTransaction.ForeignCurrencyId = currencyId;
        //        onewACTransaction.ExchangeRates = exchangerateid;
        //        onewACTransaction.Amount  = exchangedAmount ;
        //        onewACTransaction.FCAmount = fcAmount;

        //    }
        //    else
        //    {

        //            if (onewCurrency .CurrencyId ==defaultCurrencyId )
        //            {
        //                exchangerateid = 1;
        //            // DefaultcurrencyId = cmbCurrency .SelectedIndex + 1;
        //           // currencyId = onewCurrency  .CurrencyId ; 
        //        exchangedAmount = (fcAmount * exchangerateid);
        //        onewACTransaction.DefaultCurrencyId = defaultCurrencyId ;
        //            onewACTransaction.ForeignCurrencyId = onewCurrency .CurrencyId ;
        //            onewACTransaction.ExchangeRates = exchangerateid;
        //            onewACTransaction.FCAmount = fcAmount  ;
        //            onewACTransaction.Amount = exchangedAmount ;
        //        }


        //    }
        //}


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cmbForeignCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            otrxCurrency = null;
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;

            object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if (myCurrency != null)
            {
                otrxCurrency = myCurrency;
            }
        }

        private void chkCommision_CheckedChanged(object sender, EventArgs e)
        {
            xmlChargeIds = "";
            xmlChargeAmounts = "";

            if(chkCommision .Checked )
            {
                frmSearchShareTypeCharge frm = new SYSTEMUPGRADEPF.frmSearchShareTypeCharge();
                frm.ShowDialog();
                txtCommision.Text = frm.amount.ToString ();
                xmlChargeIds = frm.xmlChargeIds;
                xmlChargeAmounts = frm.xmlAmounts;
              
            }
        }
    }
}

