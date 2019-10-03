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
    public partial class frmExchangeRate : Form
    {
        public frmExchangeRate()
        {
            InitializeComponent();
        }
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency onewDefaultCurrency = null;
        Classes.Currency onewForeignCurrency = null;

        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangeRates = null;

       private  int defindex = 0;


        private void btnSearchEmployer_Click(object sender, EventArgs e)
        {
            frmSearchCurrency frm = new SYSTEMUPGRADEPF.frmSearchCurrency();
            frm.ShowDialog();
            onewDefaultCurrency = oCurrency.GetCurrency(frm.selInt);
            if (onewDefaultCurrency != null)
            {
                txtDefaultCurrency .Text = onewDefaultCurrency.Name;
            }

        }

        private void btnForeignCurrency_Click(object sender, EventArgs e)
        {
            frmSearchCurrency frm = new SYSTEMUPGRADEPF.frmSearchCurrency();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewForeignCurrency = oCurrency.GetCurrency(frm.selInt);
            if (onewForeignCurrency != null)
            {
                txtForeignexchange .Text = onewForeignCurrency.Name;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewExchangeRates = null;
            txtForeignexchange .Focus();
            ClearTexts();

        }

        private void ClearTexts()
        {
           // txtDefaultCurrency.Text = "";
            txtForeignexchange.Text = "";
            txtexchangerate.Text = "";
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDefaultCurrency.Text.Trim() == "")
            {
                MessageBox.Show("Default Currency is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDefaultCurrency.Focus();
                return;
            }
            if (txtForeignexchange.Text.Trim() == "")
            {
                MessageBox.Show("Foreign Currency is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtForeignexchange.Focus();
                return;
            }
            if (txtexchangerate.Text.Trim() == "")
            {
                MessageBox.Show("Exchange Rate is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtexchangerate.Focus();
                return;
            }

            if (onewExchangeRates == null)
                onewExchangeRates = new Classes.ExchangeRate();
            double ExchangeRate = 0;
            onewExchangeRates.DefaultCurrencyId = defindex ;

            if (onewForeignCurrency != null)
                onewExchangeRates.ForeignCurrencyId = onewForeignCurrency.CurrencyId;
            double.TryParse(txtexchangerate.Text, out ExchangeRate);

            onewExchangeRates.ExchangeRates = ExchangeRate;
            string error = "";
            onewExchangeRates.ExchangeRateId = onewExchangeRates.AddEditExchangeRate(false, ref error);
            if (error == "")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTexts();

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewExchangeRates == null)
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
                onewExchangeRates.AddEditExchangeRate(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTexts();

                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                myList = oExchangeRate.GetExchangeRates();

            int counter = 0;

            if (onewExchangeRates != null)
            {
                foreach (Classes.ExchangeRate Ex in myList)
                {
                    if (Ex.ExchangeRateId == onewExchangeRates.ExchangeRateId)
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


            onewExchangeRates = (Classes.ExchangeRate)myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchExchangeRates frm = new frmSearchExchangeRates();
            frm.ShowDialog();
            onewExchangeRates = oExchangeRate.GetExchangeRate(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewExchangeRates != null)
            {
                onewDefaultCurrency = oCurrency.GetCurrency(onewExchangeRates.DefaultCurrencyId);
                if (onewDefaultCurrency != null)
                {
                    txtDefaultCurrency.Text = onewDefaultCurrency.Name;
                }

                onewForeignCurrency = oCurrency.GetCurrency(onewExchangeRates.ForeignCurrencyId);
                if (onewForeignCurrency != null)
                {
                    txtForeignexchange.Text = onewForeignCurrency.Name;
                }
                txtexchangerate.Text = onewExchangeRates.ExchangeRates.ToString();
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void frmExchangeRate_Load(object sender, EventArgs e)
        {
            ArrayList myList = oCurrency.GetCurrencies();
            
           // string currencyname = "";

            foreach (Classes.Currency ocurr in myList)
            {
               
                if (ocurr.IsDefaultCurrency)
                {
                    defindex = ocurr.CurrencyId;
                    txtDefaultCurrency.Text = ocurr.Name;
                }
                
            }
            
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
