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
    public partial class frmCurrency : Form
    {
        public frmCurrency()
        {
            InitializeComponent();
        }
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency onewCurreny = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccountRealisedGain = null;

        Classes.ChartOfAccount onewChartOfAccountUnRealisedGain = null;
        Classes.ChartOfAccount onewChartOfAccountRealisedLoss = null;
        Classes.ChartOfAccount onewChartOfAccountUnRealisedLoss = null;
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewCurreny = null;
            ClearTexts();
            txtCode.Focus();
        }

        private void ClearTexts()
        {
            onewChartOfAccountRealisedGain = null;
            onewChartOfAccountUnRealisedGain = null;
            onewChartOfAccountRealisedLoss = null;
            onewChartOfAccountUnRealisedLoss = null;
            txtCode.Text = "";
            txtName.Text = "";
            txtSymbol.Text = "";
            txtRealisedGainGL.Text = "";
            txtUnRealisedGainGL.Text = "";
            txtUnRealisedLossGL.Text = "";
            txtRealisedLossGL.Text = "";
            chkIsDefaultCurrency.Checked = false;
            cmbRoundingType.SelectedIndex = 0;
            txtRoundingprecision.Text = "";
        }

        private void btnUnRealisedGainGL_Click(object sender, EventArgs e)
        {

            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountUnRealisedGain = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountUnRealisedGain != null)
            {
                txtUnRealisedGainGL.Text = onewChartOfAccountUnRealisedGain.AccountName;
            }
        }

        private void btnRealisedGainGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountRealisedGain = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountRealisedGain != null)
            {
                txtRealisedGainGL.Text = onewChartOfAccountRealisedGain.AccountName;
            }
        }

        private void btnUnRealisedLossGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountUnRealisedLoss = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountUnRealisedLoss != null)
            {
                txtUnRealisedLossGL.Text = onewChartOfAccountUnRealisedLoss.AccountName;
            }
        }

        private void btnRealisedLossGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountRealisedLoss = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountRealisedLoss != null)
            {
                txtRealisedLossGL.Text = onewChartOfAccountRealisedLoss.AccountName;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "")

            {
                MessageBox.Show("Code is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCode.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")

            {
                MessageBox.Show("Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            if (txtSymbol.Text.Trim() == "")

            {
                MessageBox.Show("Symbol is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSymbol.Focus();
                return;
            }
            if (onewCurreny == null)
                onewCurreny = new Classes.Currency();
            double Rounding = 0;
            bool found = false;
            string err = "";
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocur in myList)
            {
                if (txtName.Text.Trim().ToLower() == ocur.Name.Trim().ToLower())
                {
                    if (onewCurreny.CurrencyId != ocur.CurrencyId)
                    {
                        found = true;
                        break;
                    }
                }
                if (txtCode .Text.Trim().ToLower() == ocur.Code .Trim().ToLower())
                {
                    if (onewCurreny.CurrencyId != ocur.CurrencyId)
                    {
                        found = true;
                        break;
                    }
                }

            }

            if (found)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                txtCode.Focus();
                return;

            }

                      
            else
            {
                onewCurreny.Code = txtCode.Text;
                onewCurreny.Name = txtName.Text;
                onewCurreny.Symbol = txtSymbol.Text;
                onewCurreny.RoundingType = cmbRoundingType.SelectedIndex;
                double.TryParse(txtRoundingprecision.Text, out Rounding);

                onewCurreny.RoundingPrecision = Rounding;
                bool defaultcurrencyexist = false;
                if(chkIsDefaultCurrency.Checked ==true )
                {
                    foreach (Classes.Currency oca in myList)
                    {
                        if (oca.IsDefaultCurrency)
                        {
                            newList.Add(oca);
                            if (newList.Count > 0)
                            {
                                defaultcurrencyexist = true;
                                break;

                            }
                        }
                    }
                    if (defaultcurrencyexist)
                    {

                        DialogResult result = MessageBox.Show("Are you sure you want to change the default currency", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                        if (result == DialogResult.No)
                            return;
                        else
                        {
                            onewCurreny.ResetDefaultCurrency(false, ref err);
                            onewCurreny.IsDefaultCurrency = chkIsDefaultCurrency.Checked;

                        }

                    }
                    else
                    {
                        onewCurreny.IsDefaultCurrency = chkIsDefaultCurrency.Checked;
                    }

                }
               // onewCurreny.IsDefaultCurrency = chkIsDefaultCurrency.Checked;

                if (onewChartOfAccountRealisedGain !=null )
                onewCurreny.RealisedGainGLs = onewChartOfAccountRealisedGain.GLAccountId;
                if(onewChartOfAccountUnRealisedGain !=null)
                onewCurreny.UnRealisedGainGLs = onewChartOfAccountUnRealisedGain.GLAccountId;
                if(onewChartOfAccountRealisedLoss !=null)
                onewCurreny.RealisedLossGLs = onewChartOfAccountRealisedLoss.GLAccountId;
                if(onewChartOfAccountUnRealisedLoss !=null)
                onewCurreny.UnRealisedLossGLs = onewChartOfAccountUnRealisedLoss.GLAccountId;

            }
           
            string error = "";
            onewCurreny.CurrencyId = onewCurreny.AddEditCurrency(false, ref error);
            if (error == "")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewCurreny == null)
            {
                MessageBox.Show("Item to delete is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {

                string error = "";
                onewCurreny.AddEditCurrency(true, ref error);
                if (error == "")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTexts();
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchCurrency frm = new SYSTEMUPGRADEPF.frmSearchCurrency();
            frm.ShowDialog();
            onewCurreny = oCurrency.GetCurrency(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewCurreny != null)
            {
                txtCode.Text = onewCurreny.Code;
                txtName.Text = onewCurreny.Name;
                txtSymbol.Text = onewCurreny.Symbol;
                onewChartOfAccountUnRealisedGain = oChartOfAccount.GetChartOfAccount(onewCurreny.UnRealisedGainGLs);
                txtUnRealisedGainGL.Text = onewChartOfAccountUnRealisedGain.AccountName;

                onewChartOfAccountRealisedGain = oChartOfAccount.GetChartOfAccount(onewCurreny.RealisedGainGLs);
                txtRealisedGainGL.Text = onewChartOfAccountRealisedGain.AccountName;

                onewChartOfAccountRealisedLoss = oChartOfAccount.GetChartOfAccount(onewCurreny.RealisedLossGLs);
                txtRealisedLossGL.Text = onewChartOfAccountRealisedLoss.AccountName;

                onewChartOfAccountUnRealisedLoss = oChartOfAccount.GetChartOfAccount(onewCurreny.UnRealisedLossGLs);
                txtUnRealisedLossGL.Text = onewChartOfAccountUnRealisedLoss.AccountName;
                chkIsDefaultCurrency.Checked = onewCurreny.IsDefaultCurrency;
                cmbRoundingType.SelectedIndex = onewCurreny.RoundingType;
                txtRoundingprecision.Text = onewCurreny.RoundingPrecision.ToString();
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
                myList = oCurrency .GetCurrencies ();

            int counter = 0;

            if (onewCurreny  != null)
            {
                foreach (Classes.Currency  cur in myList)
                {
                    if (cur.CurrencyId  == onewCurreny .CurrencyId )
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


            onewCurreny  = (Classes.Currency )myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void chkIsDefaultCurrency_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}

