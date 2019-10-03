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
    public partial class frmShareType : Form
    {
        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        Classes.Product onewSavingsProduct = null;

        Classes.RepaymentPeriod oRepaymentPeriod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepaymentPeriod = null;

        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccountTaxGL = null;
        Classes.ChartOfAccount onewChartOfAccountShareGL = null;
        Classes.ChartOfAccount onewChartOfAccountInterestPayableGL = null;
        Classes.ChartOfAccount onewChartOfAccountInterestExpenseGL = null;
        Classes.ChartOfAccount onewChartOfAccountOverdraftGL = null;

        Classes.ShareTypeCharge oShareTypeCharges = new Classes.ShareTypeCharge();
        Classes.ShareTypeCharge onewShareTypeCharges = null;



        
        public frmShareType()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCanbeWithdrawn .Checked )
            {
                lblWithdrawnLimit.Enabled = true;
                txtWithDrawalLimit.Focus();
                txtWithDrawalLimit.Enabled = true;
            }
            else
            {
                lblWithdrawnLimit.Enabled = false;
                txtWithDrawalLimit.Enabled = false ;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHasMaxAmount.Checked ==true)
            {
                txtMaxDeposit.Enabled = true;
                lblMaxDeposit.Enabled = true;
                txtMaxDeposit.Focus();
            }
            else
            {
                txtMaxDeposit.Enabled = false;
                lblMaxDeposit.Enabled = false;

            }

        }

        private void btnsearchInterestPayableGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountInterestPayableGL = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountInterestPayableGL != null)
                txtPayableIntGl.Text = onewChartOfAccountInterestPayableGL.AccountName;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewShareType = null;
            objList.Items.Clear();
            ClearText();
        }
        private void ClearText()
        {
            txtShareTypeCode.Text = "";
            txtDescription.Text = "";
            txtMaxDeposit.Text = "";
            txtMinDeposit.Text = "";
            txtInterestExpGL.Text = "";
            txtInterestRate.Text = "";
            txtPayableIntGl.Text = "";
            txtPaymentFrequency.Text = "";
            txtProductOnMaturity.Text = "";
            txtProductType.Text = "";
            txtShareGL.Text = "";
            txtTaxGL.Text = "";
            txtWithholdingTax.Text = "";
            txtOverDraftGL.Text = "";
            chkCanGuaranteeLoan .Checked  = false ;
            txtBackdatedDays.Text = "";
            txtWithDrawalLimit.Text = "";
            cmbDailyRateSpecification.SelectedIndex = 0;
            cmbAccrualFrequency.SelectedIndex = 0;
            chkIsActive.Checked = false;
            chkAllowMultipleAccounts.Checked = false;
            chkCanbeOverdrawn.Checked = false;
            chkIsCallDeposit.Checked = false;
            chkIsFixedDeposit.Checked = false;
            chkCanbeTransferred.Checked = false;
            chkCanbeWithdrawn.Checked = false;
            chkChargeDefaulters.Checked = false;
            chkEarnInterest.Checked = false;
            chkCanEarnDividends.Checked = false;
            chkDenyBackdatesEntities.Checked = false;
            chkTrackingArreas.Checked = false;
            chkHasMaxAmount.Checked = false;
            chkIsPrimaryAccount.Checked = false;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchShareTypes frm = new frmSearchShareTypes();
            frm.ShowDialog();
            onewShareType = oShareType.GetShareType(frm.selInt);
            displayInfo();
        }
        private void displayInfo()
        {
            if (onewShareType != null)
            {
                txtShareTypeCode.Text = onewShareType.ShareTypeCode;
                txtDescription.Text = onewShareType.Description;
                txtMaxDeposit.Text = onewShareType.MaxAmount.ToString("###,###.00");
                txtMinDeposit.Text = onewShareType.MinDeposit.ToString("###,###.00");
                onewChartOfAccountInterestExpenseGL = oChartOfAccount.GetChartOfAccount(onewShareType.InterestExpenseGL);
                if (onewChartOfAccountInterestExpenseGL != null)
                    txtInterestExpGL.Text = onewChartOfAccountInterestExpenseGL.AccountName;
                txtInterestRate.Text = onewShareType.FixedDepositInterestRate.ToString();
                onewChartOfAccountInterestPayableGL = oChartOfAccount.GetChartOfAccount(onewShareType.InterestPayableGL);
                if (onewChartOfAccountInterestPayableGL != null)
                    txtPayableIntGl.Text = onewChartOfAccountInterestPayableGL.AccountName;
                onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(onewShareType.PaymentFrequency);
                if (onewRepaymentPeriod != null)
                    txtPaymentFrequency.Text = onewRepaymentPeriod.PeriodReference;
                txtProductOnMaturity.Text = onewShareType.ProductOnMaturity.ToString();
                onewProduct = oProduct.GetProduct(onewShareType.ProductId);
                if (onewProduct != null)
                    txtProductType.Text = onewProduct.Description;
                onewChartOfAccountOverdraftGL = oChartOfAccount.GetChartOfAccount(onewShareType.OverdraftGL);
                if (onewChartOfAccountOverdraftGL != null)
                    txtOverDraftGL.Text = onewChartOfAccountOverdraftGL.AccountName;
                onewChartOfAccountShareGL = oChartOfAccount.GetChartOfAccount(onewShareType.ShareGL);
                if (onewChartOfAccountShareGL != null)
                    txtShareGL.Text = onewChartOfAccountShareGL.AccountName;
                txtWithholdingTax.Text = onewShareType.WithHoldingTax.ToString("###,###.00");
                onewChartOfAccountTaxGL = oChartOfAccount.GetChartOfAccount(onewShareType.TaxGL);
                if (onewChartOfAccountTaxGL != null)
                    txtTaxGL.Text = onewChartOfAccountTaxGL.AccountName;
                chkCanGuaranteeLoan .Checked = onewShareType.CanQuaranteeLoan ;
                txtBackdatedDays.Text = onewShareType.MaxBackDatedDays.ToString();
                txtDividendRate.Text = onewShareType.DividendRate.ToString();
                txtWithDrawalLimit.Text = onewShareType.WithdrawalLimit.ToString("###,###.00");
                cmbDailyRateSpecification.SelectedIndex = onewShareType.DailyRateSpecification;
                cmbAccrualFrequency.SelectedIndex = onewShareType.AccrualFrequency;
                chkIsActive.Checked = onewShareType.IsActive;
                chkAllowMultipleAccounts.Checked = onewShareType.AllowMultipleAccounts;
                chkCanbeTransferred.Checked = onewShareType.CanBeTransferred;
                chkCanbeWithdrawn.Checked = onewShareType.CanBeWithDrawn;
                chkChargeDefaulters.Checked = onewShareType.ChargeDefaulters;
                chkEarnInterest.Checked = onewShareType.EarnsInterest;
                chkDenyBackdatesEntities.Checked = onewShareType.DenyBackDatedEntities;
                chkIsCallDeposit.Checked = onewShareType.IsCallDeposit;
                chkIsPrimaryAccount.Checked = onewShareType.IsPrimaryInterfaceAcc;
                chkTrackingArreas.Checked = onewShareType.TrackArrears;
                LoadShareTypeCharges();
            }
        }
       

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSearchProductType_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new frmSearchProduct();
            frm.IsFixedDepositProduct  = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewProduct = oProduct.GetProduct(frm.selInt);
            if (onewProduct != null)
            {
                txtProductType .Text = onewProduct.Description;
                txtDescription.Text = txtProductType.Text;
            }
        }

        private void btnSearchPaymentFrequency_Click(object sender, EventArgs e)
        {
            frmSearchRepaymentPeriod frm = new frmSearchRepaymentPeriod();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(frm.selInt);
            if (onewRepaymentPeriod != null)
            {
                txtPaymentFrequency.Text = onewRepaymentPeriod.Name;
            }
        }

        private void btnSearchTaxGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountTaxGL = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountTaxGL != null)
                txtTaxGL.Text = onewChartOfAccountTaxGL.AccountName;
        }

        private void btnSearchShareGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountShareGL = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountShareGL != null)
                txtShareGL.Text = onewChartOfAccountShareGL.AccountName;
        }

        private void btnSearchOverdraftGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountOverdraftGL = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountOverdraftGL != null)
                txtOverDraftGL.Text = onewChartOfAccountOverdraftGL.AccountName;
        }

        private void btnInterestExpenseGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountInterestExpenseGL = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountInterestExpenseGL != null)
                txtInterestExpGL.Text = onewChartOfAccountInterestExpenseGL.AccountName;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Description is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (txtShareTypeCode.Text.Trim() == "")
            {
                MessageBox.Show("Code is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtShareTypeCode.Focus();
                return;
            }
            if(chkHasMaxAmount .Checked ==true)
            {
                if(txtMaxDeposit.Text .Trim ()=="")
                {

                
                MessageBox.Show("Maximum balance is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 txtMaxDeposit.Focus();
                return;
                }

            }
            if (chkIsFixedDeposit .Checked == true)
            {
                if(onewSavingsProduct ==null)
                {

                
                MessageBox.Show("Product on Maturity is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                txtProductOnMaturity .Focus();
                return;
                }

            }
            double Interestrate = 0;
            double minDeposit = 0;
            double witholdingtax = 0;
            int productonMaturity = 0;
            int GuaranteeLoan = 0;
            double maxdeposit = 0;
            int Withdrawallimit = 0;
            int BackdatedDays = 0;
            int Dividendrates = 0;


            if (onewShareType == null)
                onewShareType = new Classes.ShareType();
            onewShareType.ShareTypeCode = txtShareTypeCode.Text;
            onewShareType.Description = txtDescription.Text;
            double.TryParse(txtInterestRate.Text, out Interestrate);
            onewShareType.FixedDepositInterestRate =  Interestrate ;
            onewShareType.DailyRateSpecification = cmbDailyRateSpecification.SelectedIndex;
            if(onewRepaymentPeriod !=null)
            onewShareType.PaymentFrequency = onewRepaymentPeriod.RepaymentPeriodId ;
            onewShareType.AccrualFrequency = cmbAccrualFrequency.SelectedIndex;
            if (onewProduct != null)
                onewShareType.ProductId = onewProduct.ProductId; ;
            double.TryParse(txtMinDeposit.Text, out minDeposit);
            onewShareType.MinDeposit = minDeposit ;
            onewShareType.HasMaxAmount = chkHasMaxAmount.Checked;
            double.TryParse(txtWithholdingTax.Text, out witholdingtax);
                   onewShareType.WithHoldingTax = witholdingtax ;
            int.TryParse(txtProductOnMaturity.Text, out productonMaturity);
            if(onewSavingsProduct !=null)
            onewShareType.ProductOnMaturity =onewSavingsProduct .ProductId ;
            onewShareType.CanQuaranteeLoan = chkCanGuaranteeLoan .Checked  ;
            onewShareType.CanBeTransferred = chkCanbeTransferred.Checked;
            onewShareType.CanBeWithDrawn = chkCanbeWithdrawn.Checked;
            onewShareType.CanBeOverDrawn = chkCanbeOverdrawn.Checked;
            onewShareType.CanEarnDividends = chkCanEarnDividends.Checked;
            double.TryParse(txtMaxDeposit.Text,out maxdeposit );
            onewShareType.MaxAmount = maxdeposit;
            
            if(onewChartOfAccountOverdraftGL !=null)
            onewShareType.OverdraftGL = onewChartOfAccountOverdraftGL .GLAccountId ;
            onewShareType.IsPrimaryInterfaceAcc = chkIsPrimaryAccount.Checked;
            int.TryParse(txtBackdatedDays.Text, out BackdatedDays);
            onewShareType.MaxBackDatedDays = BackdatedDays ;
            onewShareType.IsCallDeposit = chkIsCallDeposit.Checked;
            if (onewChartOfAccountInterestExpenseGL != null)
                onewShareType.InterestExpenseGL = onewChartOfAccountInterestExpenseGL.GLAccountId; 
            if(onewChartOfAccountInterestPayableGL !=null)
            onewShareType.InterestPayableGL = onewChartOfAccountInterestPayableGL .GLAccountId;
            onewShareType.IsActive = chkIsActive.Checked;
            onewShareType.EarnsInterest = chkEarnInterest.Checked;
            int.TryParse(txtDividendRate.Text, out Dividendrates);
            onewShareType.DividendRate = Dividendrates; 
            if(onewChartOfAccountTaxGL !=null)
            onewShareType.TaxGL = onewChartOfAccountTaxGL.GLAccountId ;
            if(onewChartOfAccountShareGL !=null)
            onewShareType.ShareGL = onewChartOfAccountShareGL .GLAccountId ;
            onewShareType.DenyBackDatedEntities = chkDenyBackdatesEntities.Checked;
            onewShareType.ChargeDefaulters = chkChargeDefaulters.Checked;
            onewShareType.AllowMultipleAccounts = chkAllowMultipleAccounts.Checked;
            int.TryParse(txtWithDrawalLimit.Text, out Withdrawallimit);
            onewShareType.WithdrawalLimit = Withdrawallimit ;
            onewShareType.TrackArrears = chkTrackingArreas.Checked;

            string err = "";
            onewShareType.ShareTypeId = onewShareType.AddEdit(false, ref err);
            if(err=="")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
            
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oShareType.GetShareTypes();

            int counter = 0;

            if (onewShareType != null)
            {
                foreach (Classes.ShareType oshare in myList)
                {
                    if (oshare.ShareTypeId == onewShareType.ShareTypeId)
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


            onewShareType = (Classes.ShareType)myList[counter];
            displayInfo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewShareType == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewShareType.AddEdit(false, ref error);

            if (error == "")
            {
                ClearText();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewShareType = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(onewShareType ==null)
            {
                MessageBox.Show("Share Type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                frmShareTypeCharge frm = new SYSTEMUPGRADEPF.frmShareTypeCharge();
                frm.ShareTypeId = onewShareType.ShareTypeId;
                frm.ShowDialog();
                LoadShareTypeCharges();
            }
            
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadShareTypeCharges();
        }

        private void LoadShareTypeCharges()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oShareTypeCharges.GetShareTypeCharges();
            foreach (Classes.ShareTypeCharge oshacha in myList )
                if(onewShareType.ShareTypeId ==oshacha.ShareTypeId )
                {
                    newList.Add(oshacha);
                }
            objList.SetObjects(newList);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            LoadShareTypeCharges();
        }

        private void frmShareType_Load(object sender, EventArgs e)
        {
            cmbDailyRateSpecification.SelectedIndex = 0;
            cmbAccrualFrequency.SelectedIndex = 0;
        }

        private void btnProductOnMaturity_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new SYSTEMUPGRADEPF.frmSearchProduct();
            frm.PickingValues = true;
            frm.SavingsProduct = true;
               frm.ShowDialog();
            onewSavingsProduct = oProduct.GetProduct(frm.selInt);
            if (onewSavingsProduct != null)
                txtProductOnMaturity.Text = onewSavingsProduct.Description;
        }

        private void chkCanEarnDividends_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCanEarnDividends .Checked )
            {
                txtDividendRate.Enabled = true;
                lblDividends.Enabled = true;
                txtDividendRate.Focus();
            }
            else
            {
                txtDividendRate.Enabled = false ;
                lblDividends.Enabled = false ;
            }
        }

        private void chkDenyBackdatesEntities_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDenyBackdatesEntities.Checked  )
            {
                lblMaxBackDate.Enabled = false;
                txtBackdatedDays.Enabled = false;
                txtBackdatedDays.Focus();
            }
            else
            {
                lblMaxBackDate.Enabled = true;
                txtBackdatedDays.Enabled = true;
            }
        }
    }
            
}
