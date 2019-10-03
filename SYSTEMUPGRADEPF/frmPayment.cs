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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        Classes.Customer oCustomer = new Classes.Customer();
        Classes.Customer onewCustomer = null;
        Classes.Invoice oInvoices = new Classes.Invoice();
        Classes.Invoice onewInvoices = null;
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBAnk = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeofPayment = null;
        Classes.Payment oPayment = new Classes.Payment();
        Classes.Payment onewPayment = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency otrxCurrency = null;
        Classes.Currency odefcurrency = null;
        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangerate = null;
        public int selInt = 0;

        public string xmlItems = "";
        public string xmlItemDescriptions = "";
        public string xmlRates = "";
        public string xmlAmounts = "";
        public string xmlVATs = "";

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchCustomers frm = new SYSTEMUPGRADEPF.frmSearchCustomers();
            frm.ShowDialog();
            onewCustomer = oCustomer.GetCustomer(frm.selInt);
            if(onewCustomer !=null)
            {
                txtcustomer.Text = onewCustomer.CustomerName;
                LoadCustomerInvoices();
            }

        }
        private void LoadCustomerInvoices()
        {
            ArrayList myList = oInvoices.GetInvoices();
            ArrayList newList = new ArrayList();
            foreach(Classes.Invoice inv in myList )
            {
                if(inv.CustomerId ==onewCustomer.CustomerId )
                {
                    newList.Add(inv);
                }
            }
            objList.SetObjects(newList );
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.ShowDialog();
            onewBAnk = oBank.GetBank(frm.selInt);
            if(onewBAnk !=null)
            {
                txtBank.Text = onewBAnk.BankName ;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBAnk.GLId);
                if(onewChartOfAccount !=null)
                {
                    txtDRGL.Text = onewChartOfAccount.AccountName;
                }
            }
        }

        private void btnPayMode_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.ShowDialog();
            onewModeofPayment = oModeOfPayment.GetModeOfPayment(frm.selInt);
            if(onewModeofPayment !=null)
            {
                txtPayMode.Text = onewModeofPayment.Description;
            }
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList .SelectedObject !=null)
            {
                onewInvoices  = (Classes.Invoice )objList.SelectedObject;
                if(onewInvoices !=null)
                this.selInt = onewInvoices.InvoiceId;
                
            }
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            onewModeofPayment = oModeOfPayment.GetModeOfPayment(onewInvoices.PayMode);
            if(onewModeofPayment !=null)
            {
                txtPayMode.Text = onewModeofPayment.Description;
            }
           
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            loadCurrencies();

        }
        private double exchangeRates(double amount, ref double rate)
        {
            double value = 0,Rate=0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate oxchrate in myList )
            {
                if(oxchrate.DefaultCurrencyId ==odefcurrency.CurrencyId &&oxchrate.ForeignCurrencyId ==otrxCurrency .CurrencyId )
                {
                    rate = oxchrate.ExchangeRates;
                    value = rate * amount;
                    break;
                }
            }
            return value;

        }
        private void loadCurrencies()
        {
            int defindex = 0, counter = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocuren in myList )
            {
                cmbCurrencypay.Items.Add(new Classes.ItemData.itemData(ocuren.Code, ocuren));
                if(ocuren.IsDefaultCurrency )
                {
                    odefcurrency = ocuren;
                     defindex=counter ;
                }
                counter++;
            }
            cmbCurrencypay.SelectedIndex = defindex;

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewInvoices = null;
            txtcustomer.Focus();
            onewPayment = null;
            txtAmountPaid.Text = "";
            txtBank.Text = "";
            txtComment.Text = "";
            txtPaidBy.Text = "";
            txtPayMode.Text = "";
            onewPayment = null;
            txtDRGL.Text = "";
            txtDocumentNo.Text = "";
            dtPTransDate.Value = DateTime.Now;
           
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           
            if(onewCustomer ==null)
            {
                MessageBox.Show("Customer  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtcustomer.Focus();
                return;
            }
            if(txtAmountPaid.Text .Trim ()=="")
            {
                MessageBox.Show("Amount  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmountPaid.Focus();
                return;
            }
            double amount = 0,exchangerate=1;
            if(onewPayment  ==null)
                onewPayment  = new Classes.Payment  ();
            if (onewInvoices != null)
                onewPayment.InvoiceId = onewInvoices.InvoiceId;
                if(onewCustomer !=null)
                onewPayment .CustomerId = onewCustomer.CustomerId;
                double.TryParse(txtAmountPaid.Text, out amount);
                onewPayment.Description   = txtPaidBy.Text;
                onewPayment.DocumentNo   = txtDocumentNo.Text;
            if (onewBAnk != null)
            onewPayment.TransDate  = dtPTransDate.Value;
            onewPayment.DefaultCurrencyId = odefcurrency.CurrencyId;
            onewPayment.ForeignCurrencyId = odefcurrency.CurrencyId;
            onewPayment.ExchangeRateId   = exchangerate;
            onewPayment.FCAmount = amount;
            onewPayment.AmountPaid   = amount ;
            if (odefcurrency.CurrencyId != otrxCurrency.CurrencyId)
            {
                onewPayment.DefaultCurrencyId = odefcurrency.CurrencyId;
                onewPayment.ForeignCurrencyId = otrxCurrency.CurrencyId;
                onewPayment.AmountPaid   = exchangeRates(amount, ref exchangerate);
                onewPayment.ExchangeRateId   = exchangerate;
                onewPayment.FCAmount = amount;

            }
            string err = "";
            onewPayment.PaymentId  = onewPayment.AddEditPayment(false, ref err);
            if (err=="")
                {
                    MessageBox.Show("Process suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }

        private void cmbCurrencypay_SelectedIndexChanged(object sender, EventArgs e)
        {
            otrxCurrency = null;
            if (cmbCurrencypay.Items.Count <= 0) return;
            if (cmbCurrencypay.SelectedIndex < 0) return;

            object obj = ((Classes.ItemData.itemData)(cmbCurrencypay .SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if (myCurrency != null)
            {
                otrxCurrency = myCurrency;
            }
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oPayment .GetPayments ();

            int counter = 0;

            if (onewPayment  != null)
            {
                foreach (Classes.Payment  pay in myList)
                {
                    if (pay.PaymentId  == onewPayment .PaymentId )
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


            onewPayment  = (Classes.Payment )myList[counter];
            displayInfo();
        }
        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchPayment frm = new SYSTEMUPGRADEPF.frmSearchPayment();
            frm.ShowDialog();
            onewPayment = oPayment.GetPayment(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewPayment != null)
            {
                onewCustomer = oCustomer.GetCustomer(onewPayment.CustomerId);
                if (onewCustomer != null)
                {
                    txtcustomer.Text = onewCustomer.CustomerName;

                }

                txtDocumentNo.Text = onewPayment.DocumentNo;
                dtPTransDate.Value = onewPayment.TransDate;
                txtPaidBy.Text = onewPayment.Description;
                LoadCustomerInvoices();
            }
        }
    }
}
