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
using BrightIdeasSoftware;

namespace SYSTEMUPGRADEPF
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.Customer oCustomer = new Classes.Customer();
        Classes.Customer onewCustomer = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment = null;
        Classes.Item oitem = new Classes.Item();
        Classes.Item onewItem = null;
        Classes.Invoice oInvoice = new Classes.Invoice();
        Classes.Invoice onewInvoice = null;

        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;
        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangeRate = null;
        private double subtotal = 0,total=0,VATAmount=0;
        public string xmlItems = "";
        public string xmlItemDescriptions = "";
        public string xmlRates = "";
        public string xmlAmounts = "";
        public string xmlVATs = "";
       

        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchBank  frm = new SYSTEMUPGRADEPF.frmSearchBank ();
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if(onewBank !=null)
            {
                txtBank.Text = onewBank.BankName;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                if(onewChartOfAccount !=null)
                {
                    txtGLAccount.Text = onewChartOfAccount.AccountName;
                }

            }
        }

        private void txtInvoiceTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomers frm = new SYSTEMUPGRADEPF.frmSearchCustomers();
            frm.ShowDialog();
            onewCustomer = oCustomer.GetCustomer(frm.selInt);
            if(onewCustomer !=null)
            {
                txtCustomer.Text = onewCustomer.CustomerName;
                txtAddress.Text = onewCustomer.Address;
                loadItemrequired();
            }

        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void btnpaymode_Click(object sender, EventArgs e)
        {
            frmSearchModeOfPayment frm = new SYSTEMUPGRADEPF.frmSearchModeOfPayment();
            frm.ShowDialog();
            onewModeOfPayment = oModeOfPayment.GetModeOfPayment(frm.selInt);
            if(onewModeOfPayment !=null)
            {
                txtPaymode.Text = onewModeOfPayment.Description;
            }
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = MDIUpgrade.Workingdate;
            //loadItemrequired();
            loadCurrencies();

        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            int defIndex = 0, counter = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocurr in myList )
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurr.Code, ocurr));
                if(ocurr.IsDefaultCurrency )
                {
                    odefCurrency = ocurr;
                    defIndex = counter;
                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defIndex;
        }
        private void loadItemrequired()
        {

            ArrayList myList = new ArrayList();
            myList=oitem.GetItems();
            objList.SetObjects(myList);
            SavingXml();


        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void objList_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private double exchangeRates(double amount, ref double rate)
        {
            double value = 0, Rate = 0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate oxchrate in myList)
            {
                if (oxchrate.DefaultCurrencyId == odefCurrency .CurrencyId && oxchrate.ForeignCurrencyId == otrxCurrency.CurrencyId)
                {
                    rate = oxchrate.ExchangeRates;
                    value = rate * amount;
                    break;
                }
            }
            return value;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            double amount = 0, exchangerateid = 0;
            if (onewInvoice == null)
                onewInvoice = new Classes.Invoice();
           
            if(onewCustomer !=null)
            onewInvoice.CustomerId = onewCustomer.CustomerId;
            onewInvoice.InvoiceDate = dateTimePicker1.Value;
            onewInvoice.InvoiceTo  = txtInvoiceTo.Text;
            onewInvoice.InvoiceNo = txtInvoiceNo.Text;
            if(onewModeOfPayment !=null)
            onewInvoice.PayMode = onewModeOfPayment.ModeOfPaymentId;
            onewInvoice.Terms = txtTerms .Text;
            onewInvoice.Total =total ;
            onewInvoice.Subtotal  = subtotal ;
            onewInvoice.VATTotal = VATAmount ;
            if(onewBank !=null)
            onewInvoice.BankId = onewBank.BankId;
            if(odefCurrency !=null)
            onewInvoice.DefaultCurrencyId = odefCurrency.CurrencyId;
            if(otrxCurrency !=null)
            onewInvoice.ForeignCurrencyId = otrxCurrency.CurrencyId;
            onewInvoice.FCAmount = total;
            onewInvoice.ExchangeRate = exchangerateid;

            
            string err = "";
            onewInvoice.InvoiceId = onewInvoice.AddEditInvoice(false, xmlItems, xmlItemDescriptions, xmlRates, xmlAmounts, xmlVATs, ref err);
            if(err=="")
            {
                MessageBox.Show("Process suscceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void SavingXml()
        {
            int totalCount = 0;
            totalCount = objList.Items.Count;

            string[] valuesItems = new string[totalCount];
            string[] valuesItemDescriptions = new string[totalCount];
            string[] valuesRates = new string[totalCount];
            string[] valuesAmounts = new string[totalCount];
            string[] valuesVAT = new string[totalCount];

            int cntr = 0;

            


            for (int i = 0; i < objList.Items.Count; i++)
            {

                Classes.Item  oitem = (Classes.Item)objList.GetModelObject(i);


                valuesItems[cntr] = oitem .ItemName ;
                valuesItemDescriptions[cntr] = oitem.Description ;
                valuesRates[cntr] = oitem.Rate .ToString ();
                valuesAmounts[cntr] = oitem.Rate .ToString ();
                valuesVAT[cntr] = oitem.TaxCode  .ToString();


               
                subtotal   = subtotal  + oitem.Rate;
                VATAmount = VATAmount + oitem.TaxCode;
                
                total = (subtotal + VATAmount);
                cntr++;


               
                
                


            }
            xmlItems = GlobalVariable.BuildXmlString("ItemName", valuesItems);
            xmlItemDescriptions = GlobalVariable.BuildXmlString("Description", valuesItemDescriptions);
            xmlRates = GlobalVariable.BuildXmlString("Amounts", valuesRates);
            xmlAmounts = GlobalVariable.BuildXmlString("Rate", valuesAmounts);
            xmlVATs = GlobalVariable.BuildXmlString("VATRate", valuesVAT);
            txtSubtotal.Text = subtotal.ToString ();
            txtTotal.Text = total.ToString();
            txtVAT.Text = VATAmount.ToString();


        }
      

        private void objList_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Column != this.olvColumn1)
                return;
            else
            {
                ArrayList myList = oitem.GetItems();
                ComboBox cb = new ComboBox();
                cb.Bounds = e.CellBounds;
                cb.DropDownStyle = ComboBoxStyle.DropDown ;
                foreach (Classes.Item oit in myList )
                {
                    string itemtoload = oit.ItemName ;
                    cb.Items.Add(itemtoload);
                }
                cb.SelectedIndex = 0;
                e.Control = cb;
            }

        }

        private void objList_CellEditFinished(object sender, CellEditEventArgs e)
        {
            
        }

        private void objList_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
        }

        private void objList_ItemsAdding(object sender, ItemsAddingEventArgs e)
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtCustomer.Focus();
            clearTexts();

        }

        private void clearTexts()
        {
            onewInvoice = null;
            txtCustomer.Text = "";
            onewCustomer = null;
            onewExchangeRate = null;
            onewChartOfAccount = null;
            onewModeOfPayment = null;
            txtAddress.Text = "";
            txtBank.Text = "";
            txtGLAccount.Text = "";
            txtInvoiceNo.Text = "";
            txtInvoiceTo.Text = "";
            txtPaymode.Text = "";
            txtTerms.Text = "";
            cmbCurrency.SelectedIndex = odefCurrency.CurrencyId;
            dateTimePicker1.Value = DateTime.Now;
            txtAddress.Text = "";
            onewBank = null;
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oInvoice.GetInvoices ();

            int counter = 0;

            if (onewInvoice  != null)
            {
                foreach (Classes.Invoice invo in myList)
                {
                    if (invo.InvoiceId  == onewInvoice.InvoiceId )
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


            onewInvoice  = (Classes.Invoice)myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewInvoice ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result= MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewInvoice.AddEditInvoice(true, xmlItems, xmlItemDescriptions, xmlAmounts, xmlRates, xmlVATs , ref  err);
                if(err=="")
                {
                    MessageBox.Show("Process suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchInvoices frm = new SYSTEMUPGRADEPF.frmSearchInvoices();
            frm.ShowDialog();
            onewInvoice = oInvoice.GetInvoice(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewInvoice != null)
            {
                onewCustomer = oCustomer.GetCustomer(onewInvoice.CustomerId);
                if (onewCustomer != null)
                {
                    txtCustomer.Text = onewCustomer.CustomerName;
                    txtAddress.Text = onewCustomer.Address;
                }
                onewBank = oBank.GetBank(onewInvoice.BankId);
                if (onewBank != null)
                {
                    txtBank.Text = onewBank.BankName;
                    onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                    if (onewChartOfAccount != null)
                    {
                        txtGLAccount.Text = onewChartOfAccount.AccountName;
                    }
                }

                txtInvoiceNo.Text = onewInvoice.InvoiceNo;
                onewModeOfPayment = oModeOfPayment.GetModeOfPayment(onewInvoice.PayMode);
                if (onewModeOfPayment != null)
                {
                    txtPaymode.Text = onewModeOfPayment.Description;
                }

                txtInvoiceTo.Text = onewInvoice.InvoiceTo;
                dateTimePicker1.Value = onewInvoice.InvoiceDate;
                txtTerms.Text = onewInvoice.Terms;

                loadItemrequired();
                for (int i = 0; i < cmbCurrency.Items.Count; i++)
                {
                    object obj = ((Classes.ItemData.itemData)(cmbCurrency.Items[i]))._itemData;
                    Classes.Currency myCurrency = (Classes.Currency)obj;
                    if (myCurrency != null)
                    {
                        if (myCurrency.CurrencyId == onewInvoice.ForeignCurrencyId)
                        {
                            cmbCurrency.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void objList_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            
        }

        private void objList_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
