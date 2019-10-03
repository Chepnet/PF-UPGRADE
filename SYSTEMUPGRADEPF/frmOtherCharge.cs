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
    public partial class frmOtherCharge : Form
    {
        public frmOtherCharge()
        {
            InitializeComponent();
        }
        Classes.OtherCharge oOtherCharge = new Classes.OtherCharge();
        Classes.OtherCharge onewOtherCharge = null;
        Classes.LoanType oLoanType = new Classes.LoanType();
        Classes.LoanType onewLoanType = null;

        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        private int _loanproductId = 0;
        public int LoanProductId { get { return _loanproductId; } set { _loanproductId = value; } }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void btnChargeGl_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccount != null)
                txtChargeGl.Text = onewChartOfAccount.AccountName;
        }

        private void btnProductId_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new SYSTEMUPGRADEPF.frmSearchProduct();
            frm.PickingValues = true;
            frm.IsChargeProduct = true;
            frm.ShowDialog();
            onewProduct = oProduct.GetProduct(frm.selInt);
            if (onewProduct != null)
                txtCharge.Text = onewProduct.Description;
           
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtCharge.Focus();
            ClearTexts();
        }

        private void ClearTexts()
        {
            onewOtherCharge = null;

            txtAmount.Text = "";
            txtCharge.Text = "";
            txtChargeGl.Text = "";
            txtPeriodToChange.Text = "";
            chkFormula.Checked = true;
            chkIsTieredBased.Checked = true;
            chkIsTopUpCharge.Checked = true;
            chkRateBased.Checked = true;
            chkHasLimit.Checked = true;
            chkCalculationIncludsPrinciaplsandinterest.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtCharge .Text.Trim()=="")
            {
                MessageBox.Show("Charge Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCharge.Focus();
                return;
            }
            if (txtChargeGl .Text.Trim() == "")
            {
                MessageBox.Show("Charge GL Account  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCharge.Focus();
                return;
            }
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("Amount  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAmount.Focus();
                return;
            }
            double amount = 0;
            double lowerlimit = 0;
            double upperlimit = 0;
            int periodtocharge = 0;
            if (onewOtherCharge == null)
                onewOtherCharge = new Classes.OtherCharge();
            if (onewProduct != null)
                onewOtherCharge.ProductId = onewProduct.ProductId;
            if (onewChartOfAccount != null)
                onewOtherCharge.ChargeGLAccountId = onewChartOfAccount.GLAccountId;
            double.TryParse(txtAmount.Text, out amount);
            onewOtherCharge.Amount = amount;
            onewOtherCharge.IsFormula = chkFormula.Checked;
            onewOtherCharge.Formula = txtFormula.Text;
            double.TryParse(txtLowerLimit.Text, out lowerlimit);
            onewOtherCharge.LowerLimit = lowerlimit ;
            double.TryParse(txtUpperLimit.Text, out upperlimit);
            onewOtherCharge.UpperLimit = upperlimit ;
            if(onewLoanType !=null)
            onewOtherCharge.LoanTypeId = onewLoanType.ProductId  ;
            onewOtherCharge.IsTieredBased = chkIsTieredBased.Checked;
            onewOtherCharge.IsTopUpCharge = chkIsTopUpCharge.Checked;
            onewOtherCharge.CalculationIncludesBothInterestAndPrincipal = chkCalculationIncludsPrinciaplsandinterest.Checked;
            onewOtherCharge.HasLimit = chkHasLimit.Checked;
            onewOtherCharge.RateBased = chkRateBased.Checked;
            int.TryParse(txtPeriodToChange.Text, out periodtocharge);
            onewOtherCharge.PeriodChange = periodtocharge ;
           if(chkHasLimit .Checked )
            {
                if(onewOtherCharge.Amount <onewOtherCharge.LowerLimit )
                {
                    MessageBox.Show("Amount is below the lower limit required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAmount.Focus();
                    return;
                }
                if (onewOtherCharge.Amount > onewOtherCharge.UpperLimit )
                {
                    MessageBox.Show("Amount is Above the Upper limit required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAmount.Focus();
                    return;
                }
            }
            string err = "";
            onewOtherCharge.ChargeId = onewOtherCharge.AddEditCharge(false, ref err);
            if(err=="")
            {
                MessageBox.Show("Process suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTexts();
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchOtherCharges frm = new frmSearchOtherCharges();
            frm.ShowDialog();
            onewOtherCharge = oOtherCharge.GetOtherCharge(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewOtherCharge != null)
            {
                txtAmount.Text = onewOtherCharge.Amount.ToString("###,###.00");

                onewProduct = oProduct.GetProduct(onewOtherCharge.ProductId);
                if (onewProduct != null)
                    txtCharge.Text = onewProduct.Description;

                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewOtherCharge.ChargeGLAccountId);
                if (onewChartOfAccount != null)
                    txtChargeGl.Text = onewChartOfAccount.AccountName;

                chkCalculationIncludsPrinciaplsandinterest.Checked = onewOtherCharge.CalculationIncludesBothInterestAndPrincipal;
                chkFormula.Checked = onewOtherCharge.IsFormula;
                chkHasLimit.Checked = onewOtherCharge.HasLimit;
                chkIsTieredBased.Checked = onewOtherCharge.IsTieredBased;
                chkIsTopUpCharge.Checked = onewOtherCharge.IsTopUpCharge;
                chkRateBased.Checked = onewOtherCharge.RateBased;
                txtPeriodToChange.Text = onewOtherCharge.PeriodChange.ToString();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewOtherCharge ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2 );
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewOtherCharge.AddEditCharge(true, ref err);
                if(err=="")
                {
                    MessageBox.Show("Process suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oOtherCharge .GetOtherCharges ();

            int counter = 0;

            if (onewOtherCharge  != null)
            {
                foreach (Classes.OtherCharge ocha in myList)
                {
                    if (ocha .ChargeId  == onewOtherCharge .ChargeId )
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


            onewOtherCharge  = (Classes.OtherCharge )myList[counter];
            displayInfo();
        }

        private void toolStripBtnNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void frmOtherCharge_Load(object sender, EventArgs e)
        {
            frmLoanTypes frm = new SYSTEMUPGRADEPF.frmLoanTypes();
            onewLoanType = oLoanType.GetLoanType(LoanProductId);
           
            if (this.LoanProductId  != 0)
            {
                txtLoanType.Text = onewLoanType  .LoanTypeName;
            }
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
