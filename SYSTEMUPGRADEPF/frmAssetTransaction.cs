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
    public partial class frmAssetTransaction : Form
    {
        public frmAssetTransaction()
        {
            InitializeComponent();
        }

        Classes.ModeOfPayment omodeofPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewmodeofpayment = null;
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.AssetRegister oAssetRegister = new Classes.AssetRegister();
        Classes.AssetRegister onewAssetRegister = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;
        Classes.AssetTransaction oAssetTransaction = new Classes.AssetTransaction();
        Classes.AssetTransaction onewAssetTransaction = null;
        private void btnAsset_Click(object sender, EventArgs e)
        {
            frmSearchAssetRegister frm = new SYSTEMUPGRADEPF.frmSearchAssetRegister();
            frm.ShowDialog();
            onewAssetRegister = oAssetRegister.GetAssetRegister(frm.selInt);
            if(onewAssetRegister !=null)
            {
                txtAsset.Text = onewAssetRegister.Name;
            }
        }

        private void btnPayMode_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.ShowDialog();
            onewmodeofpayment = omodeofPayment.GetModeOfPayment(frm.selInt);
            if(onewmodeofpayment !=null)
            {
                TXTModeofpayment.Text = onewmodeofpayment.Description;

            }
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if(onewBank !=null)
            {
                txtBank.Text = onewBank.BankName;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                if(onewChartOfAccount !=null)
                {
                    txtbankGl.Text = onewChartOfAccount.AccountName;
                }
            }
        }

        private void frmAssetTransaction_Load(object sender, EventArgs e)
        {
            loadCurrencies();
        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            int defIndex = 0, counter = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocurr in myList )
            {
                cmbCurrency.Items.Add(new Classes.ItemData .itemData  (ocurr.Code, ocurr));
                if(ocurr.IsDefaultCurrency )
                {
                    defIndex = counter;
                    odefCurrency = ocurr;
                }
                counter++;

            }
            cmbCurrency.SelectedIndex = defIndex;
            
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;
            object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if (myCurrency != null)
            {
                otrxCurrency = myCurrency;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            txtAsset.Focus();
            clearTexts();

        }

        private void clearTexts()
        {
            txtDocumentNo.Text = "";
            txtAssetGL.Text = "";
            txtAmount.Text = "";
            txtBank.Text = "";
            txtDocumentNo.Text = "";
            TXTModeofpayment.Text = "";
            txtAsset.Text = "";
            onewmodeofpayment = null;
            onewChartOfAccount = null;
            onewAssetTransaction = null;
            onewBank = null;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            double exchangerate = 1, amount = 0;
            if (onewAssetTransaction == null)
            {
                onewAssetTransaction = new Classes.AssetTransaction();
                onewAssetTransaction.AssetId = onewAssetRegister.AssetId;
                if (onewBank != null)
                    onewAssetTransaction.BankId = onewBank.BankId;
                onewAssetTransaction.DocumentNo = txtDocumentNo.Text;
                onewAssetTransaction.DefaultCurrencyId = odefCurrency.CurrencyId;
                onewAssetTransaction.ForeignCurrencyId = odefCurrency.CurrencyId;
                onewAssetTransaction.ExchangeRate = exchangerate;
                double.TryParse(txtAmount.Text, out amount);
                onewAssetTransaction.FCAmount = amount;
                onewAssetTransaction.Amount = amount;
                if (onewmodeofpayment != null)
                    onewAssetTransaction.ModeOfPaymentId = onewmodeofpayment.ModeOfPaymentId;
                onewAssetTransaction.TransDate = dateTimePicker1.Value;
                string error = "";
                onewAssetTransaction.AssetTransactionId = onewAssetTransaction.AddEditAssetTransaction(false, ref error);
                if (error == "")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewAssetTransaction ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewAssetTransaction.AddEditAssetTransaction(true, ref error);
                if(error=="")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearTexts();

                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oAssetTransaction .GetAssetTransactions ();

            int counter = 0;

            if (onewAssetTransaction  != null)
            {
                foreach (Classes.AssetTransaction  asttrans in myList)
                {
                    if (asttrans.AssetTransactionId  == onewAssetTransaction .AssetTransactionId)
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


            onewAssetTransaction  = (Classes.AssetTransaction )myList[counter];
            displayInfo();
           
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchAssetTransaction frm = new frmSearchAssetTransaction();
            frm.ShowDialog();
            onewAssetTransaction = oAssetTransaction.GetAssetTransaction(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewAssetTransaction != null)
            {

                txtAmount.Text = onewAssetTransaction.Amount.ToString();
                onewAssetRegister = oAssetRegister.GetAssetRegister(onewAssetTransaction.AssetId);
                if (onewAssetRegister != null)
                {
                    txtAsset.Text = onewAssetRegister.Name;
                }
                onewBank = oBank.GetBank(onewAssetTransaction.BankId);
                {
                    if (onewBank != null)
                    {
                        txtBank.Text = onewBank.BankName;
                        onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                        if (onewChartOfAccount != null)
                        {
                            txtbankGl.Text = onewChartOfAccount.AccountName;
                        }
                    }
                }
                onewmodeofpayment = omodeofPayment.GetModeOfPayment(onewAssetTransaction.ModeOfPaymentId);
                if (onewmodeofpayment != null)
                {
                    TXTModeofpayment.Text = onewmodeofpayment.Description;
                }


                dateTimePicker1.Value = onewAssetTransaction.TransDate;
                txtDocumentNo.Text = onewAssetTransaction.DocumentNo;

            }
        }
    }
}
