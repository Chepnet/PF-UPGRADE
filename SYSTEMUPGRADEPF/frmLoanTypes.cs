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
    public partial class frmLoanTypes : Form
    {
        Classes.LoanType oLoanType = new Classes.LoanType();
        Classes.LoanType onewLoanType = null;
        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        public int selInt = 0;

        Classes.RepaymentPeriod oRepaymentPeriod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepaymentPeriod = null;

        Classes.LoanCategory oLoanCategory = new Classes.LoanCategory();
        Classes.LoanCategory onewLoanCategory = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        //Classes.ChartOfAccount onewChartOfAccount = null;
        Classes.ChartOfAccount onewChartOfAccountGLcode = null;
        Classes.ChartOfAccount onewChartOfAccountPenaltyGl = null;
        Classes.ChartOfAccount onewChartOfAccountInterest = null;
        Classes.ChartOfAccount onewChartOfAccountWriteOff = null;
        Classes.ChartOfAccount onewChartOfAccountInterestReceivable = null;
        Classes.ChartOfAccount onewChartOfAccountInterestPenaltyReceivable = null;
        Classes.OtherCharge oOtherCharge = new Classes.OtherCharge();
        Classes.OtherCharge onewCharge = new Classes.OtherCharge();
        Classes.Collateral oCollateral = new Classes.Collateral();
        Classes.Collateral onewCollateral = null;

        Classes.LoanTypeCollateral oLoanTypeCollateral = new Classes.LoanTypeCollateral();
        Classes.LoanTypeCollateral onewLoanTypeCollateral = null;

        public frmLoanTypes()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnsearchstationNo_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;

            int vertScrollBarWidth = (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = senderComboBox.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            senderComboBox.DropDownWidth = width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmOtherCharge frm = new SYSTEMUPGRADEPF.frmOtherCharge();

            frm.LoanProductId = onewLoanType.ProductId ;
            frm.ShowDialog();

            LoadOtherCharges();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchLoanTypes frm = new frmSearchLoanTypes();
            frm.ShowDialog();
            onewLoanType = oLoanType.GetLoanType(frm.selInt);
            displayInfo();

        }
        private void displayInfo()
        {
            if (onewLoanType != null)
            {
                txtRefCode.Text = onewLoanType.LoanTypeCode.ToString();
                txtDescription.Text = onewLoanType.LoanTypeName.ToString();
                CmbDailyspecification.SelectedIndex = onewLoanType.DailyRateSpecification;
                txtmaxPeriod.Text = onewLoanType.MaxPeriod.ToString();
                txtMonthlyIntRate.Text = onewLoanType.MonthlyInterestRate.ToString();
                cmbPayMethod.SelectedIndex = onewLoanType.InterestPayMethod;
                cmbCalculationFormula.SelectedIndex = onewLoanType.InterestCalculationFormula;
                cmbpostingmethod.SelectedIndex = onewLoanType.InterestPostingMethod;
                cmbpostingfrequency.SelectedIndex = onewLoanType.InterestPostingFrequency;
                cmbcalcuationoption.SelectedIndex = onewLoanType.PenaltyCalculationOption;
                cmbfrequencycalculation.SelectedIndex = onewLoanType.PenaltyFrequencyCalculation ;
                cmbpostingpenality.SelectedIndex = onewLoanType.PenaltyPostingMethod;
                txtpenaltyValue.Text = onewLoanType.PenaltyValue.ToString("###,###.00");
                txtthresholdDays.Text = onewLoanType.ThresholdDays.ToString();
                txtMinpenaltyAmount.Text = onewLoanType.PenaltyMinAmount .ToString("###,###.00");
                chkpenaltyisRate.Checked = onewLoanType.PenaltyIsRate;
                chkApplyOnMaturity.Checked = onewLoanType.ApplyPenaltyAfterMaturity;
                chkAllowZeroRating.Checked = onewLoanType.AllowPartialDisbursement;
                chkChargefutureinterest.Checked = onewLoanType.ChargeFutureInterest;
                chkTieToCrediter.Checked = onewLoanType.TieLoanToCreditOfficer;
                chkcontinueChargingInterest.Checked = onewLoanType.ContinueChargingInterestOnMaturedLoans;
                chkdefaulteffectdate.Checked = onewLoanType.DefaultEffectDateToTheBeginningOfNextMonth;
                chkAdjustableinterestRate.Checked = onewLoanType.AdjustableInterestRate;
                chkConsiderInduplumRule.Checked = onewLoanType.ConsinderInduplum;
                txtincomefactor.Text = onewLoanType.IncomeFactor.ToString();
                txtloanfactor.Text = onewLoanType.LoanFactor.ToString();
                txtsharefactor.Text = onewLoanType.ShareFactor.ToString();
                txtminguarator.Text = onewLoanType.MinGuarantors.ToString();
                txtmaxguarators.Text = onewLoanType.MaxGuarantors.ToString();
                txtminshare.Text = onewLoanType.MinShares.ToString("###,###.00");
                txtminAmount.Text = onewLoanType.MinAmount.ToString("###,###.00");
                txtmaxAmount.Text = onewLoanType.MaxAmount.ToString("###,###.00");
                txtroundinginterest.Text = onewLoanType.InterestRoundingNearest.ToString();
                txtroundingprincipal.Text = onewLoanType.PrincipalRoundingNearest.ToString();
                cmbRoundInterest.SelectedIndex = onewLoanType.InterestRoundingValue;
                cmbRoundPrinciapal.SelectedIndex = onewLoanType.PrincipalRoundingValue;
                cmbAccrualFrequency.SelectedIndex = onewLoanType.PenaltyAccrualFrequency;

                onewLoanCategory = oLoanCategory.GetLoanCategory(onewLoanType.LoanCategoriesId);
                if (onewLoanCategory != null)
                {

                    txtloancategory.Text = onewLoanCategory.Description;
                }
                txtgraceperiod.Text = onewLoanType.GracePeriod.ToString();

                onewChartOfAccountGLcode = oChartOfAccount.GetChartOfAccount(onewLoanType.LoanGlCode);
                if (onewChartOfAccountGLcode != null)
                {
                    txtloanGL.Text = onewChartOfAccountGLcode.AccountName;
                }
                onewChartOfAccountInterest = oChartOfAccount.GetChartOfAccount(onewLoanType.InterestGlCode);
                if (onewChartOfAccountInterest != null)
                {
                    txtInterestGL.Text = onewChartOfAccountInterest.AccountName;
                }
                onewChartOfAccountPenaltyGl = oChartOfAccount.GetChartOfAccount(onewLoanType.PenaltyGlCode);
                if (onewChartOfAccountPenaltyGl != null)
                {
                    txtPenaltyGL.Text = onewChartOfAccountPenaltyGl.AccountName;
                }
                onewChartOfAccountWriteOff = oChartOfAccount.GetChartOfAccount(onewLoanType.WriteOffGlCode);
                if (onewChartOfAccountWriteOff != null)
                {
                    txtWriteOffGL.Text = onewChartOfAccountWriteOff.AccountName;
                }
                onewChartOfAccountInterestReceivable = oChartOfAccount.GetChartOfAccount(onewLoanType.InterestReceivableGL);
                if (onewChartOfAccountInterestReceivable != null)
                {
                    txtIntReceivableGL.Text = onewChartOfAccountInterestReceivable.AccountName;
                }
                onewChartOfAccountInterestPenaltyReceivable = oChartOfAccount.GetChartOfAccount(onewLoanType.PenaltyReceivableGl);
                if (onewChartOfAccountInterestPenaltyReceivable != null)
                {
                    txtPenaltyReceivableGL.Text = onewChartOfAccountInterestPenaltyReceivable.AccountName;
                }

                chkIsActive.Checked = onewLoanType.IsActive;
                onewProduct = oProduct.GetProduct(onewLoanType.ProductId);
                if (onewProduct != null)
                    txtProduct.Text = onewProduct.Description;
                // txtroundinginterest.Text = onewLoanType..ToString();
                // txtroundingprincipal.Text = onewLoanType.MaxPeriod.ToString();
                onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(onewLoanType.RepaymentFrequency);
                if (onewRepaymentPeriod != null)
                {
                    txtRepaymentFrequency.Text = onewRepaymentPeriod.PeriodReference;
                }
                LoadOtherCharges();
                LoadLoanTypeCollaterals();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewLoanType = null;
            ClearTexts();
            txtRefCode.Focus();
            objList.Items.Clear();
            objListCollaterals.Items.Clear();
            onewProduct = null;


        }
        private void ClearTexts()
        {
            onewChartOfAccountGLcode = null;
            onewChartOfAccountInterest = null;
            onewChartOfAccountInterestPenaltyReceivable = null;
            onewChartOfAccountInterestReceivable = null;
            onewChartOfAccountPenaltyGl = null;
            onewChartOfAccountWriteOff = null;

            onewProduct = null;
            onewRepaymentPeriod = null;
            onewLoanCategory = null;
            txtRefCode.Text = "";
            txtDescription.Clear();
            CmbDailyspecification.SelectedIndex = 0;
            txtmaxPeriod.Text = "";
            txtRepaymentFrequency.Text = "";
            txtMonthlyIntRate.Text = "";
            cmbPayMethod.SelectedIndex = 0;
            cmbCalculationFormula.SelectedIndex = 0;
            cmbAccrualFrequency.SelectedIndex = 0;
            cmbpostingmethod.SelectedIndex = 0;
            cmbpostingfrequency.SelectedIndex = 0;
            cmbcalcuationoption.SelectedIndex = 0;
            cmbfrequencycalculation.SelectedIndex = 0;
            cmbRoundPrinciapal.SelectedIndex = 0;
            cmbRoundInterest.SelectedIndex = 0;
            cmbpostingpenality.SelectedIndex = 0;
            txtpenaltyValue.Text = "";
            txtthresholdDays.Text = "";
            txtMinpenaltyAmount.Text = "";
            chkpenaltyisRate.Checked = false;
            chkApplyOnMaturity.Checked = false;
            chkAllowZeroRating.Checked = false;
            chkChargefutureinterest.Checked = false;
            chkTieToCrediter.Checked = false;
            chkcontinueChargingInterest.Checked = false;
            chkdefaulteffectdate.Checked = false;
            chkAdjustableinterestRate.Checked = false;
            chkConsiderInduplumRule.Checked = false;
            txtincomefactor.Text = "";
            txtloanfactor.Text = "";
            txtsharefactor.Text = "";
            txtminguarator.Text = "";
            txtmaxguarators.Text = "";
            txtminshare.Text = "";
            txtminAmount.Text = "";
            txtmaxAmount.Text = "";
            txtloancategory.Text = "";
            txtgraceperiod.Text = "";
            txtInterestGL.Text = "";
            txtloanGL.Text = "";
            txtPenaltyGL.Text = "";
            txtWriteOffGL.Text = "";
            txtIntReceivableGL.Text = "";
            txtPenaltyReceivableGL.Text = "";
            chkIsActive.Checked = false;
            txtroundinginterest.Text = "";
            txtroundingprincipal.Text = "";

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewLoanType == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewLoanType.AddEditLoanType(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewLoanType = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtRefCode.Text.Trim() == "")
            {
                MessageBox.Show("Loan Code is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRefCode.Focus();
                return;
            }

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Loan Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (txtMonthlyIntRate .Text.Trim() == "")
            {
                MessageBox.Show("Interest Rate is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMonthlyIntRate .Focus();
                return;
            }

            if (txtRepaymentFrequency .Text.Trim() == "")
            {
                MessageBox.Show("Repayment frequency is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRepaymentFrequency .Focus();
                return;
            }
            if (txtmaxPeriod .Text.Trim() == "")
            {
                MessageBox.Show("Maximum period is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtmaxPeriod .Focus();
                return;
            }

            if (txtProduct .Text.Trim() == "")
            {
                MessageBox.Show("Product is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtProduct .Focus();
                return;
            }

            double monthlyintrate = 0;
            int thresholddays = 0;
            double minpenalty = 0;
            int minquarantor = 0;
            int maxguarantor = 0;
            int minshare = 0;

            int GracePeriod = 0;
            int maxperiod = 0;
            double penaltyvalue = 0;
            double minAmount = 0;
            double maxAmount = 0;
            double incomefactor = 0;
            double sharefactor = 0;
            double principalRoundingnearest = 0;
            
            double interestroundingnearest = 0;

            int loanFactor = 0;
            if (onewLoanType == null)
                onewLoanType = new Classes.LoanType();
            bool found = false;
            ArrayList myList = oLoanType.GetLoanTypes();
            foreach (Classes.LoanType oloty in myList)
            {
                if (txtDescription.Text.Trim().ToLower() == oloty.LoanTypeName.Trim().ToLower())
                {
                    if (onewLoanType.ProductId  != oloty.ProductId )
                    {
                        found = true;
                        break;

                    }
                }
            }
            if (found)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else
            {


                onewLoanType.LoanTypeCode = txtRefCode.Text;
                onewLoanType.LoanTypeName = txtDescription.Text;
                double.TryParse(txtroundingprincipal.Text, out principalRoundingnearest);
                onewLoanType.PrincipalRoundingNearest = principalRoundingnearest;
                double.TryParse(txtroundinginterest.Text, out interestroundingnearest);
                onewLoanType.InterestRoundingNearest = interestroundingnearest;
                onewLoanType.PrincipalRoundingValue = cmbRoundPrinciapal.SelectedIndex;
                onewLoanType.InterestRoundingValue = cmbRoundInterest.SelectedIndex;
                int.TryParse(txtmaxPeriod.Text, out maxperiod);
                onewLoanType.MaxPeriod = maxperiod;

                double.TryParse(txtMonthlyIntRate.Text, out monthlyintrate);
                onewLoanType.MonthlyInterestRate = monthlyintrate;
                onewLoanType.DailyRateSpecification = CmbDailyspecification.SelectedIndex;
                onewLoanType.PenaltyIsRate = chkpenaltyisRate.Checked;
                double.TryParse(txtpenaltyValue.Text, out penaltyvalue);
                onewLoanType.PenaltyValue = penaltyvalue;
                if (onewRepaymentPeriod != null)
                    onewLoanType.RepaymentFrequency = onewRepaymentPeriod.RepaymentPeriodId;
                onewLoanType.PenaltyCalculationOption  = cmbcalcuationoption.SelectedIndex;
                onewLoanType.PenaltyPostingMethod = cmbpostingpenality.SelectedIndex;
                int.TryParse(txtthresholdDays.Text, out thresholddays);
                onewLoanType.ThresholdDays = thresholddays;
                double.TryParse(txtMinpenaltyAmount.Text, out minpenalty);
                onewLoanType.PenaltyMinAmount  = minpenalty;
                onewLoanType.ApplyPenaltyAfterMaturity = chkApplyOnMaturity.Checked;
                onewLoanType.PenaltyFrequencyCalculation  = cmbfrequencycalculation.SelectedIndex;
                onewLoanType.ConsinderInduplum = chkConsiderInduplumRule.Checked;
                onewLoanType.AdjustableInterestRate = chkAdjustableinterestRate.Checked;
                onewLoanType.ChargeFutureInterest = chkChargefutureinterest.Checked;
                onewLoanType.AllowZeroRating = chkAllowZeroRating.Checked;
                onewLoanType.InterestPostingMethod = cmbpostingmethod.SelectedIndex;
                onewLoanType.InterestPostingFrequency = cmbpostingfrequency.SelectedIndex;
                onewLoanType.DailyInterestRateOptions = CmbDailyspecification.SelectedIndex;
                onewLoanType.InterestPayMethod = cmbPayMethod.SelectedIndex;
                double.TryParse(txtincomefactor.Text, out incomefactor);
                onewLoanType.IncomeFactor = incomefactor;
                double.TryParse(txtsharefactor.Text, out sharefactor);
                onewLoanType.ShareFactor = sharefactor;
                int.TryParse(txtloanfactor.Text, out loanFactor);
                onewLoanType.LoanFactor = loanFactor;
                int.TryParse(txtminguarator.Text, out minquarantor);
                onewLoanType.MinGuarantors = minquarantor;
                int.TryParse(txtmaxguarators.Text, out maxguarantor);
                onewLoanType.MaxGuarantors = maxguarantor;
                int.TryParse(txtminshare.Text, out minshare);
                onewLoanType.MinShares = minshare;
                double.TryParse(txtminAmount.Text, out minAmount);
                onewLoanType.MinAmount = minAmount;
                double.TryParse(txtmaxAmount.Text, out maxAmount);
                onewLoanType.MaxAmount = maxAmount;
                onewLoanType.InterestCalculationFormula = cmbCalculationFormula.SelectedIndex;
                onewLoanType.PenaltyAccrualFrequency = cmbAccrualFrequency.SelectedIndex;
                if (onewLoanCategory != null)
                    onewLoanType.LoanCategoriesId = onewLoanCategory.LoanCategoryId;

                onewLoanType.TieLoanToCreditOfficer = chkTieToCrediter.Checked;
                onewLoanType.DefaultEffectDateToTheBeginningOfNextMonth = chkdefaulteffectdate.Checked;
                if (onewChartOfAccountGLcode != null)
                {

                    onewLoanType.LoanGlCode = onewChartOfAccountGLcode.GLAccountId;

                }

                if (onewChartOfAccountInterest != null)
                {
                    onewLoanType.InterestGlCode = onewChartOfAccountInterest.GLAccountId;

                }
                if (onewChartOfAccountPenaltyGl != null)
                {
                    onewLoanType.PenaltyGlCode = onewChartOfAccountPenaltyGl.GLAccountId;

                }
                if (onewChartOfAccountWriteOff != null)
                {

                    onewLoanType.WriteOffGlCode = onewChartOfAccountWriteOff.GLAccountId;


                }
                if (onewChartOfAccountInterestReceivable != null)
                {
                    onewLoanType.InterestReceivableGL = onewChartOfAccountInterestReceivable.GLAccountId;


                }
                if (onewChartOfAccountInterestPenaltyReceivable != null)
                {
                    onewLoanType.PenaltyReceivableGl = onewChartOfAccountInterestPenaltyReceivable.GLAccountId;
                }

                int.TryParse(txtgraceperiod.Text, out GracePeriod);
                onewLoanType.GracePeriod = GracePeriod;
                onewLoanType.Remarks = txtremarks.Text;
                if (onewProduct != null)
                    onewLoanType.ProductId = onewProduct.ProductId;
                onewLoanType.IsActive = chkIsActive.Checked;
                onewLoanType.MemberCanGuaranteeOwnLoan = chkMemberCanGuarenteeOwnLoan.Checked;
                onewLoanType.MustBeFullySecured = chkMustBeFullySecured.Checked;
            }

            string error = "";

            onewLoanType.ProductId  = onewLoanType.AddEditLoanType(false, ref error);

            if (error == "")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmLoanTypes_Load(object sender, EventArgs e)
        {

            CmbDailyspecification.SelectedIndex = 0;
            cmbPayMethod.SelectedIndex = 0;
            cmbCalculationFormula.SelectedIndex = 0;
            cmbpostingmethod.SelectedIndex = 0;
            cmbpostingfrequency.SelectedIndex = 0;
            cmbcalcuationoption.SelectedIndex = 0;
            cmbfrequencycalculation.SelectedIndex = 0;
            cmbpostingpenality.SelectedIndex = 0;
            cmbRoundInterest.SelectedIndex = 0;
            cmbRoundPrinciapal.SelectedIndex = 0;
            cmbRoundInterest.SelectedIndex = 0;
            cmbRoundPrinciapal.SelectedIndex = 0;
            cmbAccrualFrequency.SelectedIndex = 0;
            cmbpostingmethod.DropDownWidth = DropDownWidth(cmbpostingmethod);
            cmbCalculationFormula.DropDownWidth = DropDownWidth(cmbCalculationFormula);
            cmbcalcuationoption.DropDownWidth = DropDownWidth(cmbcalcuationoption);
            CmbDailyspecification.DropDownWidth = DropDownWidth(CmbDailyspecification);
            cmbfrequencycalculation.DropDownWidth = DropDownWidth(cmbfrequencycalculation);
            cmbPayMethod.DropDownWidth = DropDownWidth(cmbPayMethod);
            cmbpostingfrequency.DropDownWidth = DropDownWidth(cmbfrequencycalculation);
            cmbpostingpenality.DropDownWidth = DropDownWidth(cmbpostingpenality);
            cmbAccrualFrequency.DropDownWidth = DropDownWidth(cmbAccrualFrequency);
        }

        private void btnSearchLoanCategory_Click(object sender, EventArgs e)
        {
            frmSearchLoanCategory frm = new frmSearchLoanCategory();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewLoanCategory = oLoanCategory.GetLoanCategory(frm.selInt);
            if (onewLoanCategory != null)
            {
                txtloancategory.Text = onewLoanCategory.Description;
            }

        }

        private void btnSearchLoanGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccountGLcode = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountGLcode != null)
                txtloanGL.Text = onewChartOfAccountGLcode.AccountName;

        }

        private void btbSearchInterestGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccountInterest = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountInterest != null)
                txtInterestGL.Text = onewChartOfAccountInterest.AccountName;

        }

        private void btnSearchPenaltyGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccountPenaltyGl = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountPenaltyGl != null)
                txtPenaltyGL.Text = onewChartOfAccountPenaltyGl.AccountName;

        }

        private void btnSearchWriteOffGl_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccountWriteOff = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountWriteOff != null)
                txtWriteOffGL.Text = onewChartOfAccountWriteOff.AccountName;

        }

        private void btnSearchIntReceivableGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccountInterestReceivable = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountInterestReceivable != null)
                txtIntReceivableGL.Text = onewChartOfAccountInterestReceivable.AccountName;

        }

        private void btnPnReceivableGL_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccountInterestPenaltyReceivable = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccountInterestPenaltyReceivable != null)
                txtPenaltyReceivableGL.Text = onewChartOfAccountInterestPenaltyReceivable.AccountName;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oLoanType.GetLoanTypes();

            int counter = 0;

            if (onewLoanType != null)
            {
                foreach (Classes.LoanType olotype in myList)
                {
                    if (olotype.ProductId == onewLoanType.ProductId)
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


            onewLoanType = (Classes.LoanType)myList[counter];
            displayInfo();
        }

        private void toolStripBtnNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            Label label1 = new Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        private void cmbpostingmethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new frmSearchProduct();
            frm.PickingValues = true;
            frm.IsChargeProduct = false;
            frm.LoanProduct = true;
            frm.ShowDialog();
            onewProduct = oProduct.GetProduct(frm.selInt);
            if (onewProduct != null)
            {
                txtProduct.Text = onewProduct.Description;
                if(txtDescription .Text .Trim ()=="")
                {
                    txtDescription.Text = txtProduct.Text;
                }
            }


        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {
           
        }

        private void LoadOtherCharges()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            objList.Items.Clear();
            myList = oOtherCharge.GetOtherCharges();
            foreach (Classes.OtherCharge otha in myList)
            {
                if (onewLoanType.ProductId  == otha.LoanTypeId)
                {
                    newList.Add(otha);

                }
            }
            objList.SetObjects(newList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCharge = (Classes.OtherCharge)objList.SelectedObject;
            if (onewCharge != null)
                this.selInt = onewCharge.ChargeId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            frmOtherCharge frm = new SYSTEMUPGRADEPF.frmOtherCharge();
            frm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmSearchRepaymentPeriod frm = new frmSearchRepaymentPeriod();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(frm.selInt);
            if (onewRepaymentPeriod != null)
            {
                txtRepaymentFrequency.Text = onewRepaymentPeriod.PeriodReference;
                txtmaxPeriod.Focus();
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmOtherCharge frm = new frmOtherCharge();
            frm.LoanProductId = onewLoanType.ProductId ;
            frm.ShowDialog();
            LoadOtherCharges();
        }

        private void txtroundingprincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void LoadLoanTypeCollaterals()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oLoanTypeCollateral.GetLTCollaterals();
            foreach (Classes.LoanTypeCollateral olocol in myList)
            {
                if (onewLoanType.ProductId  == olocol.LoanTypeId)
                {
                    newList.Add(olocol);
                }
            }
            objListCollaterals.SetObjects(newList);
        }

        private void btnNewCollaterals_Click(object sender, EventArgs e)
        {
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSearchCollaterals frm = new frmSearchCollaterals();
            frm.PickingValues = true;
            frm.ShowDialog();

            onewCollateral = oCollateral.GetCollateral(frm.selInt);
            if (onewLoanType != null)
            {
                if (onewCollateral != null)
                {
                    if (onewLoanTypeCollateral == null)
                        onewLoanTypeCollateral = new Classes.LoanTypeCollateral();
                    onewLoanTypeCollateral.CollateralId = onewCollateral.CollateralId;
                    onewLoanTypeCollateral.LoanTypeId = onewLoanType.ProductId ;
                    onewLoanTypeCollateral.IsActive = onewCollateral .IsActive ;
                    string err = "";
                    onewLoanTypeCollateral.LoanTypeCollateralId = onewLoanTypeCollateral.AddEditLTCollaterals(false, ref err);
                    if (err == "")
                    {
                        MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        onewCollateral = null;
                    }
                    else
                    {
                        MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            LoadLoanTypeCollaterals();
            onewLoanTypeCollateral = null;

            //if (onewLoanType != null)
            //{
            //    if (onewLoanTypeCollateral == null)
            //    {
            //        onewLoanTypeCollateral = new Classes.LoanTypeCollateral();
            //        if (onewCollateral != null)
            //            onewLoanTypeCollateral.CollateralId = onewCollateral.CollateralId;
            //        onewLoanTypeCollateral.LoanTypeId = onewLoanType.LoanTypeId;
            //        onewLoanTypeCollateral.IsActive = checkBox1.Checked;
            //        string err = "";
            //        onewLoanTypeCollateral.LoanTypeCollateralId = onewLoanTypeCollateral.AddEditLTCollaterals(false, ref err);
            //        if (err == "")
            //        {
            //            MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            onewCollateral = null;
            //        }
            //        else
            //        {
            //            MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //    }
            //LoadLoanCollaterals();
            //    }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type is Required ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                frmSearchCollaterals frm = new SYSTEMUPGRADEPF.frmSearchCollaterals();
                frm.ShowDialog();
               // onewCollateral = oCollateral.GetCollateral(frm.selInt);
               // if (onewCollateral != null)
                    //txtCollateral.Text = onewCollateral.Description;
            }
        }

        private void objListCollaterals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListCollaterals.SelectedObject != null)
                onewLoanTypeCollateral = (Classes.LoanTypeCollateral)objListCollaterals.SelectedObject;
            if (onewLoanTypeCollateral != null)
                this.selInt = onewLoanTypeCollateral.LoanTypeCollateralId;
           //xtCollateral.Text = onewLoanTypeCollateral.Description;

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void objListCollaterals_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onewCharge  == null)
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
                onewCharge .AddEditCharge (true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   LoadOtherCharges  ();
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cmsOtherCharge_Opening(object sender, CancelEventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (onewLoanTypeCollateral  == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selectedc item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewLoanTypeCollateral .AddEditLTCollaterals (true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoanTypeCollaterals ();
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
