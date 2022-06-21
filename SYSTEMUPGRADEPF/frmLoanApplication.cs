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
using Microsoft.VisualBasic;


namespace SYSTEMUPGRADEPF
{
    public partial class frmLoanApplication : Form
    {
        Classes.LoanApplication oLoanApplication = new Classes.LoanApplication();
        Classes.LoanApplication onewLoanApplication = null;

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency otxrcurrency = null;
        Classes.Currency odefCurrency = null;
        private int _loandisbursementId = 0;
        public int LoanDisbursementId
        {
            get { return _loandisbursementId; }
            set { _loandisbursementId = value; }
        }
        frmLoanDisbursement frm = new frmLoanDisbursement();
        private bool _save = false;
        public bool Updating
        {
            get { return _save; }
            set { _save = value; }
        }
        private bool loadingexistingcurrency = false;







        Classes.Loan oLoan = new Classes.Loan();
        Classes.Loan onewLoan = null;

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        private bool saving = false;

        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;

        Classes.LoanType oLoantype = new Classes.LoanType();
        Classes.LoanType onewLoanType = null;

        Classes.RepaymentPeriod oRepaymentPeriod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepaymentPeriod = null;

        Classes.LoanPurpose oLoanPurpose = new Classes.LoanPurpose();
        Classes.LoanPurpose onewLoanPurpose = null;

        Classes.LoanGuarantor oLoanGuarantor = new Classes.LoanGuarantor();
        Classes.LoanGuarantor onewLoanGuarantor = null;

        Classes.MemberShare oMemberShare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;
        Classes.LoanApplicationCollateral oLoanApplicationCollateral = new Classes.LoanApplicationCollateral();
        Classes.LoanApplicationCollateral onewLoanApplicationCollateral = null;

        Classes.LoanTypeCollateral oLoanTypeCollateral = new Classes.LoanTypeCollateral();
        Classes.LoanTypeCollateral onewLoanTypeCollateral = null;

        Classes.LoanCollateralImage oLoanCollateralImages = new Classes.LoanCollateralImage();
        Classes.LoanCollateralImage onewLoanCollateralImages = null;

        Classes.LoanApplicationCharge oLoanApplicationCharge = new Classes.LoanApplicationCharge();
        Classes.LoanApplicationCharge onewLoanApplicationCharge = null;
        Classes.OtherCharge oOtherCharge = new Classes.OtherCharge();
        Classes.OtherCharge onewOtherCharge = null;
        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangeRate = null;

        private bool Saving = false;
        private bool saved = false;

        public int selInt;

        public frmLoanApplication()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewLoanType = null;
            onewMember = null;
            onewLoanApplication = null;
            onewLoan = null;
            ClearText();
            objList.Items.Clear();
            objListCharges.Items.Clear();
            objListLoanApplicationCollateral.Items.Clear();
            cmbLoanStatus.SelectedIndex = 1;
            loadCurrencies();
        }
        private void ClearText()
        {
            txtCellNo.Text = "";
            txtIdNumber.Text = "";
            txtInterestRate.Text = "";
            txtLoanAmount.Text = "";
            txtLoanCode.Text = "";
            txtLoanPurpose.Text = "";
            txtLoanType.Text = "";
            txtManualRefNo.Text = "";
            txtMaxAmount.Text = "";
            txtMemberName.Text = "";
            txtMemberNo.Text = "";
            TxtMinAmount.Text = "";
            TxtRepaymentAmnt.Text = "";
            txtRepaymentPeriod.Text = "";
            cmbLoanStatus.SelectedIndex = -1;
            //chkIsActive.Checked = false;


        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Member Account  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delet the selected Item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewLoanApplication.AddEditLoanApp(true, ref error);
                if (error == "")
                {
                    MessageBox.Show("process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

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
                if (onewMember.IsActive == true)
                {
                    txtMemberName.Text = onewMember.MemberName;
                    txtIdNumber.Text = onewMember.IdNumber;
                    txtCellNo.Text = onewMember.PhoneNumber;
                    txtMemberNo.Text = onewMember.MemberNo;
                    onewMemberDocument = oMemberDocument.GetMemberDocument(onewMember.MemberId);
                    if (onewMemberDocument != null)
                    {
                        ptbphoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
                    }
                }

            }
        }

        private void txtMemberNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList)
                {
                    if (txtCellNo.Text == omem.PhoneNumber)
                    {
                        txtIdNumber.Text = omem.IdNumber;
                        txtMemberName.Text = omem.MemberName;
                        txtMemberNo.Text = omem.MemberNo;
                        memberFound = true;

                    }
                }
                if (!memberFound)
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCellNo.Focus();
                    return;
                }
            }
        }

        private void txtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList)
                {
                    if (txtIdNumber.Text.Trim().ToLower() == omem.IdNumber)
                    {
                        txtCellNo.Text = omem.PhoneNumber;
                        txtMemberName.Text = omem.MemberName;
                        txtMemberNo.Text = omem.MemberNo;
                        memberFound = true;

                    }
                }
                if (!memberFound)
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdNumber.Focus();
                    return;
                }
            }
        }

        private void txtCellNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList)
                {
                    if (txtCellNo.Text == omem.PhoneNumber)
                    {
                        txtIdNumber.Text = omem.IdNumber;
                        txtMemberName.Text = omem.MemberName;
                        txtMemberNo.Text = omem.MemberNo;
                        memberFound = true;

                    }
                }
                if (!memberFound)
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCellNo.Focus();
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchLoanTypes frm = new frmSearchLoanTypes();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewLoanType = oLoantype.GetLoanType(frm.selInt);
            if (onewLoanType != null)
            {
                if (onewLoanType.IsActive == true)
                {

                    txtLoanType.Text = onewLoanType.LoanTypeName;
                    TxtMinAmount.Text = onewLoanType.MinAmount.ToString("###,###.00");
                    txtMaxAmount.Text = onewLoanType.MaxAmount.ToString("###,###.00");
                    txtInterestRate.Text = onewLoanType.MonthlyInterestRate.ToString();
                    txtRepaymentPeriod.Text = onewLoanType.MaxPeriod.ToString();

                    DateTime date = dtpAppDate.Value;
                    if (onewLoanType.DefaultEffectDateToTheBeginningOfNextMonth == true)
                    {

                        var firstDayOfMonth = new DateTime(date.AddMonths(1).Year, date.AddMonths(1).Month, 1);
                        dtpEffectDate.Value = firstDayOfMonth;
                    }
                    else
                    {


                        onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(onewLoanType.RepaymentFrequency);

                        if (onewRepaymentPeriod != null)
                        {
                            string name = onewRepaymentPeriod.Name;
                            string reference = onewRepaymentPeriod.PeriodReference;
                            int range = onewRepaymentPeriod.FrequencyRange;
                            /*  if (reference == "Years")
                              {
                                  DateTime date3 = date.AddYears(range*(onewLoanType.GracePeriod));
                                  dtpEffectDate.Value = date3;
                              }
                              if (reference == "Months")
                              {
                                  DateTime date3 = date.AddMonths(range*onewLoanType.GracePeriod);
                                  dtpEffectDate.Value = date3;
                              }
                              if (reference == "Weeks")
                              {
                                  DateTime date3 = date.AddDays(7 * (range*onewLoanType.GracePeriod));
                                  dtpEffectDate.Value = date3;
                              }
                              if (reference == "Days")
                              {
                                  DateTime date3 = date.AddDays(range*onewLoanType.GracePeriod);
                                  dtpEffectDate.Value = date3;
                              }*/

                            switch (reference)
                            {
                                case "Years":
                                    dtpEffectDate.Value = date.AddYears(range * (onewLoanType.GracePeriod));
                                    break;
                                case "Months":
                                    dtpEffectDate.Value = date.AddMonths(range * (onewLoanType.GracePeriod));
                                    break;
                                case "Weeks":
                                    dtpEffectDate.Value = date.AddDays(7 * range * (onewLoanType.GracePeriod));
                                    break;
                                default:
                                    dtpEffectDate.Value = date.AddDays(range * (onewLoanType.GracePeriod));
                                    break;


                            }

                        }
                    }
                    if (onewLoanType.AdjustableInterestRate == true)
                    {
                        txtInterestRate.ReadOnly = false;
                    }
                    else
                    {
                        txtInterestRate.ReadOnly = true;
                    }

                }
                else
                {
                    MessageBox.Show("Selected Item is InActive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoanType.Focus();
                    return;
                }
            }

            LoadLoanTypeCharges();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmsearchLoanApplications frm = new frmsearchLoanApplications();
            frm.ShowDialog();
            onewLoanApplication = oLoanApplication.GetLoanApplication(frm.selInt);
            displayInfo();

        }

        public void displayInfo()
        {
            if (onewLoanApplication != null)
            {
                //loadingexistingcurrency   = true ;
                //loadCurrencies();
                onewMember = oMember.GetMember(onewLoanApplication.MemberId);
                if (onewMember != null)
                {
                    txtIdNumber.Text = onewMember.IdNumber;
                    txtCellNo.Text = onewMember.PhoneNumber;
                    txtMemberNo.Text = onewMember.MemberNo;
                    txtMemberName.Text = onewMember.MemberName;
                    onewMemberDocument = oMemberDocument.GetMemberDocument(onewMember.MemberId);
                    if (onewMemberDocument != null)
                    {
                        ptbphoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
                    }
                }
                txtInterestRate.Text = onewLoanApplication.InterestRate.ToString();
                txtLoanAmount.Text = onewLoanApplication.LoanAmount.ToString("###,###.00");
                txtLoanCode.Text = onewLoanApplication.LoanCode.ToString();

                onewLoanPurpose = oLoanPurpose.GetLoanPurpose(onewLoanApplication.LoanPurposeId);
                if (onewLoanPurpose != null)
                {
                    txtLoanPurpose.Text = onewLoanPurpose.Description;
                }

                onewLoanType = oLoantype.GetLoanType(onewLoanApplication.LoanTypeId);
                if (onewLoanType != null)
                {
                    txtLoanType.Text = onewLoanType.LoanTypeName;
                    TxtMinAmount.Text = onewLoanType.MinAmount.ToString("###,###.00");
                    txtMaxAmount.Text = onewLoanType.MaxAmount.ToString("###,###.00");
                    txtRepaymentPeriod.Text = onewLoanType.MaxPeriod.ToString();
                }
                txtManualRefNo.Text = onewLoanApplication.ManualRefNo;
                TxtRepaymentAmnt.Text = onewLoanApplication.LoanRepaymentAmount.ToString("###,###.00");

                cmbLoanStatus.SelectedIndex = onewLoanApplication.LoanStatusId;
                {
                    if (onewLoanApplication.LoanStatusId == 0)
                    {
                        btnDisburse.Enabled = false;
                        btnApprove.Enabled = true;
                        btnrejected.Enabled = false;

                    }

                    else if (onewLoanApplication.LoanStatusId == 2)
                    {
                        btnDisburse.Enabled = true;
                        btnrejected.Enabled = false;
                        btnApprove.Enabled = false;
                    }
                    else if (onewLoanApplication.LoanStatusId == 3)
                    {
                        btnrejected.Enabled = false;
                        btnApprove.Enabled = false;
                        btnDisburse.Enabled = false;
                    }
                    else
                    {
                        btnDisburse.Enabled = false;
                        btnrejected.Enabled = true;
                        btnApprove.Enabled = true;

                    }
                }

                dtpAppDate.Text = onewLoanApplication.ApplicationDate.ToString();
                dtpEffectDate.Text = onewLoanApplication.LoanEffectDate.ToString();

                //  cmbCurrency.SelectedIndex = onewLoanApplication.ForeignCurrencyId-1;
                LoadLoanGuarantor();
                LoadLoanApplicationCollaterals();
                frmSearchProduct frm = new frmSearchProduct();
                frm.IsChargeProduct = true;
                {
                    LoadLoanApplicationCharge();
                }

                for (int i = 0; i < cmbCurrency.Items.Count; i++)
                {
                    object obj = ((Classes.ItemData.itemData)(cmbCurrency.Items[i]))._itemData;
                    Classes.Currency myCurrency = (Classes.Currency)obj;
                    if (myCurrency != null)
                    {
                        if (myCurrency.CurrencyId == onewLoanApplication.ForeignCurrencyId)
                        {
                            cmbCurrency.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void SaveLoanApplication()
        {


            if (onewMember == null)
            {
                MessageBox.Show("Member Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberName.Focus();
                return;
            }
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanType.Focus();
                return;
            }
            if (txtLoanAmount.Text.Trim() == "")
            {
                MessageBox.Show("Loan Amount Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanAmount.Focus();
                return;
            }

            double amountL, repay, interest = 0;
            int status = 0;
            ;
            if (onewLoanApplication == null)
                onewLoanApplication = new Classes.LoanApplication();

            if (onewMember != null)
                onewLoanApplication.MemberId = onewMember.MemberId;

            if (onewLoanPurpose != null)
                onewLoanApplication.LoanPurposeId = onewLoanPurpose.LoanPurposeId;
            if (onewRepaymentPeriod != null)
                onewLoanApplication.RepaymentPeriod = onewRepaymentPeriod.RepaymentPeriodId;

            double.TryParse(txtInterestRate.Text, out interest);
            onewLoanApplication.InterestRate = interest;
            double.TryParse(txtLoanAmount.Text, out amountL);
            {

                if (onewLoanType != null)
                {
                    if (amountL < onewLoanType.MinAmount)
                    {
                        MessageBox.Show("Loan Application Is below the minimum amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoanAmount.Focus();
                        return;
                    }

                    if (amountL > onewLoanType.MaxAmount)
                    {
                        MessageBox.Show("Loan Application Is above the Maximum amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoanAmount.Focus();
                        return;
                    }
                    if (objList.GetItemCount() < onewLoanType.MinGuarantors)
                    {
                        MessageBox.Show("You are below the minimum guarantors", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberShare.Focus();
                        return;


                    }
                    if (objList.GetItemCount() > onewLoanType.MaxGuarantors)
                    {
                        MessageBox.Show("You are above the maximum guarantors", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberShare.Focus();
                        return;

                    }

                }
                onewLoanApplication.LoanAmount = amountL;
            }

            double.TryParse(TxtRepaymentAmnt.Text, out repay);
            onewLoanApplication.LoanRepaymentAmount = repay;
            onewLoanApplication.ApplicationDate = dtpAppDate.Value;
            onewLoanApplication.LoanEffectDate = dtpAppDate.Value;
            onewLoanApplication.LoanCode = txtLoanCode.Text;
            //.IsActive = chkIsActive.Checked;
            onewLoanApplication.ManualRefNo = txtManualRefNo.Text;


            onewLoanApplication.LoanStatusId = cmbLoanStatus.SelectedIndex;

            string error = "";
            if (CheckLoanFactor())
                return;
            else
            {
                onewLoanApplication.LoanApplicationId = onewLoanApplication.AddEditLoanApp(false, ref error);
                if (error == "")
                {
                    if (!Saving)
                    {

                        // SaveOtherCharges();
                        MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }
        private bool fullySecured()
        {


            double guaranteedamount = 0;
            double collateralvalues = 0;
            double securedvalue = 0;
            double totalguaranteeamount = 0;
            double totalcollateralvalues = 0;
            bool NotFullysecured = false;
            for (int i = 0; i < objList.Items.Count; i++)
            {

                Classes.LoanGuarantor oloanGuarantor = (Classes.LoanGuarantor)objList.GetModelObject(i);
                Classes.LoanApplicationCollateral olac = new Classes.LoanApplicationCollateral();
                guaranteedamount = oloanGuarantor.GuaranteedAmount;

                totalguaranteeamount = totalguaranteeamount + guaranteedamount;

            }
            for (int i = 0; i < objListLoanApplicationCollateral.Items.Count; i++)
            {

                Classes.LoanApplicationCollateral oloanCollateral = (Classes.LoanApplicationCollateral)objListLoanApplicationCollateral.GetModelObject(i);
                collateralvalues = oloanCollateral.ForcedValue;
                totalcollateralvalues = totalcollateralvalues + collateralvalues;



            }
            securedvalue = totalguaranteeamount + totalcollateralvalues;
            onewLoanType = oLoantype.GetLoanType(onewLoanApplication.LoanTypeId);
            if (onewLoanType != null)
            {
                if (!Updating)
                {


                    if (onewLoanType.MustBeFullySecured)
                    {
                        if (securedvalue < onewLoanApplication.LoanAmount)
                        {
                            NotFullysecured = true;
                            MessageBox.Show("Loan must be fully secured", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //return;
                        }
                    }
                }

            }
            return NotFullysecured;
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //saving = true;
            SaveLoanApplications();

        }

        private void SaveLoanApplications()
        {
            if (onewMember == null)
            {
                MessageBox.Show("Member Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberName.Focus();
                return;
            }
            if (onewLoanType == null)
            {
                MessageBox.Show("Loan Type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanType.Focus();
                return;
            }
            if (onewLoanPurpose == null)
            {
                MessageBox.Show("Loan Purpose Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanPurpose.Focus();
                return;
            }
            if (txtLoanAmount.Text.Trim() == "")
            {
                MessageBox.Show("Loan Amount Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanAmount.Focus();
                return;
            }


            double amountL, repay, interest = 0;
            double exchangerateid = 1;
            if (onewLoanApplication == null)
                onewLoanApplication = new Classes.LoanApplication();

            if (onewMember != null)
                onewLoanApplication.MemberId = onewMember.MemberId;


            if (onewLoanPurpose != null)
                onewLoanApplication.LoanPurposeId = onewLoanPurpose.LoanPurposeId;
            if (onewRepaymentPeriod != null)
            {
                onewLoanApplication.RepaymentPeriod = onewRepaymentPeriod.RepaymentPeriodId;
            }
                

            double.TryParse(txtInterestRate.Text, out interest);
            onewLoanApplication.InterestRate = interest;
            if (onewLoanType != null)
            {
                onewLoanApplication.LoanTypeId = onewLoanType.ProductId;
            }

            double.TryParse(txtLoanAmount.Text, out amountL);
            onewLoanApplication.DefaultCurrencyId = odefCurrency.CurrencyId;
            onewLoanApplication.ForeignCurrencyId = odefCurrency.CurrencyId;
            onewLoanApplication.FCAmount = amountL;

            onewLoanApplication.LoanAmount = amountL;
            onewLoanApplication.ExchangeRate = exchangerateid;
            if (odefCurrency.CurrencyId != otxrcurrency.CurrencyId)
            {
                onewLoanApplication.DefaultCurrencyId = odefCurrency.CurrencyId;
                onewLoanApplication.ForeignCurrencyId = otxrcurrency.CurrencyId;
                onewLoanApplication.FCAmount = amountL;
                onewLoanApplication.LoanAmount = exchangerate(amountL, ref exchangerateid);
                onewLoanApplication.ExchangeRate = exchangerateid;
            }


            if (!Updating)
            {


                if (onewLoanType != null)
                {
                    if (onewLoanApplication.LoanAmount < onewLoanType.MinAmount)
                    {
                        MessageBox.Show("Loan Application Is below the minimum amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoanAmount.Focus();
                        return;
                    }

                    if (onewLoanApplication.LoanAmount > onewLoanType.MaxAmount)
                    {
                        MessageBox.Show("Loan Application Is above the Maximum amount", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtLoanAmount.Focus();
                        return;
                    }


                }
                if (onewLoanApplication.LoanAmount <= 0)
                {
                    MessageBox.Show("Loan Amount cannot be zero or less", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoanAmount.Focus();
                    return;
                }
            }
            //else
            //{
            //    onewLoanApplication.LoanAmount = amountL;
            //}



            double.TryParse(TxtRepaymentAmnt.Text, out repay);
            if (!Updating)
            {

                if (repay <= 0)
                {
                    MessageBox.Show("Repayment amount cannot be Zero or Less", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoanAmount.Focus();
                    return;

                }
                else
                {
                    onewLoanApplication.LoanRepaymentAmount = repay;
                }
            }


            onewLoanApplication.ApplicationDate = dtpAppDate.Value;
            onewLoanApplication.LoanEffectDate = dtpEffectDate .Value;
            onewLoanApplication.LoanCode = txtLoanCode.Text;
            // onewLoanApplication.IsActive = chkIsActive.Checked;
            onewLoanApplication.ManualRefNo = txtManualRefNo.Text;


            onewLoanApplication.LoanStatusId = cmbLoanStatus.SelectedIndex;

            string error = "";

            if (CheckLoanFactor())
                return;
            else
            {
                onewLoanApplication.LoanApplicationId = onewLoanApplication.AddEditLoanApp(false, ref error);
                if (!Updating)
                {
                    {
                        if (fullySecured())
                            return;
                    }

                    if (objList.GetItemCount() < onewLoanType.MinGuarantors)
                    {
                        MessageBox.Show("You are below the minimum guarantors", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberShare.Focus();
                        return;


                    }
                    if (objList.GetItemCount() > onewLoanType.MaxGuarantors)
                    {
                        MessageBox.Show("You are above the maximum guarantors", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMemberShare.Focus();
                        return;

                    }
                }


                if (error == "")
                {
                    saved = true;
                    if (!Updating)
                    {


                        SaveOtherCharges();
                        MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSearchRepaymentPeriod frm = new SYSTEMUPGRADEPF.frmSearchRepaymentPeriod();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewRepaymentPeriod = oRepaymentPeriod.GetRepaymentPeriod(frm.selInt);
            if (onewRepaymentPeriod != null)
            {
                if (onewRepaymentPeriod.IsActive == true)
                {
                    txtRepaymentPeriod.Text = onewRepaymentPeriod.PeriodReference;
                }
                else
                {
                    MessageBox.Show("Selected Item is Inactive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtRepaymentPeriod.Focus();
                    return;

                }
            }
        }
        private double exchangerate(double amount, ref double rate)
        {
            double value = 0;
            ArrayList myList = oExchangeRate.GetExchangeRates();
            foreach (Classes.ExchangeRate oexchrate in myList)
            {
                if ((odefCurrency.CurrencyId == oexchrate.DefaultCurrencyId) && (otxrcurrency.CurrencyId == oexchrate.ForeignCurrencyId))
                {
                    value = oexchrate.ExchangeRates * amount;
                    rate = oexchrate.ExchangeRates;
                    break;
                }
            }
            return value;
        }
        private bool CheckLoanFactor()
        {

            bool alreadyhasloan = false;
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            ArrayList memList = new ArrayList();
            myList = oLoanApplication.GetLoanApplications();
            foreach (Classes.LoanApplication oloap in myList)
                if (onewMember.MemberId == oloap.MemberId)
                {
                    newList.Add(oloap);

                }
            foreach (Classes.LoanApplication olom in newList)
            {
                if (onewLoanApplication.LoanTypeId == olom.LoanTypeId)
                {
                    memList.Add(olom);
                    if (memList.Count >= onewLoanType.LoanFactor)
                    {
                        if (saving)
                        {


                            alreadyhasloan = true;
                            break;
                        }

                    }
                }
            }



            if (alreadyhasloan)
            {
                MessageBox.Show("Has reached the maximum number of loan", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLoanType.Focus();
                // return;
            }
            return alreadyhasloan;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            frmSearchLoanPurpose frm = new SYSTEMUPGRADEPF.frmSearchLoanPurpose();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewLoanPurpose = oLoanPurpose.GetLoanPurpose(frm.selInt);
            if (onewLoanPurpose != null)
            {
                if (onewLoanPurpose.IsActive == true)
                {
                    txtLoanPurpose.Text = onewLoanPurpose.Description;
                }
                else
                {
                    MessageBox.Show("Selected Item is Inactive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtLoanPurpose.Focus();
                    return;
                }
            }

        }

        private void frmLoanApplication_Load(object sender, EventArgs e)
        {
            dtpAppDate.Value = MDIUpgrade.Workingdate;
            cmbLoanStatus.SelectedIndex = 1;
            loadCurrencies();

        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            ArrayList myList = oCurrency.GetCurrencies();
            int defindex = 0, counter = 0;
            foreach (Classes.Currency ocurren in myList)
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurren.Code, ocurren));
                if (ocurren.IsDefaultCurrency)
                {
                    odefCurrency = ocurren;
                    defindex = counter;
                }

                counter++;
            }
            cmbCurrency.SelectedIndex = defindex;
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oLoanApplication.GetUnDisbursedLoanApplications();

            int counter = 0;

            if (onewLoanApplication != null)
            {
                foreach (Classes.LoanApplication oloanapp in myList)
                {
                    if (oloanapp.LoanApplicationId == onewLoanApplication.LoanApplicationId)
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


            onewLoanApplication = (Classes.LoanApplication)myList[counter];
            displayInfo();
        }


        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewMemberShare == null)
            {
                MessageBox.Show("Member Shares Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtGuaranteedAmount.Text.Trim() == "")
            {
                MessageBox.Show("Guaranteed Amount  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGuaranteedAmount.Focus();
                return;
            }
            double totalshares = 0;
            double freeshares = 0;
            if (onewLoanGuarantor == null)
                onewLoanGuarantor = new Classes.LoanGuarantor();
            bool found = false;
            ArrayList myList = oLoanGuarantor.GetLoanGuarantors();
            ArrayList newList = new ArrayList();
            foreach (Classes.LoanGuarantor oloagua in myList)
            {
                if (onewLoanApplication.LoanApplicationId == oloagua.LoanApplicationId)
                {
                    newList.Add(oloagua);
                }
            }

            foreach (Classes.LoanGuarantor olonmem in newList)
            {
                if (txtMemberShare.Text.Trim().ToLower() == olonmem.MemberName.Trim().ToLower())
                {

                    if (onewLoanGuarantor.LoanGuarantorId != olonmem.LoanGuarantorId)
                    {
                        found = true;
                        break;
                    }
                }
            }



            if (found)
            {
                MessageBox.Show("Member has already guarantee", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberShare.Focus();
                return;
            }
            else
            {


                if (onewLoanApplication != null)
                {
                    onewLoanGuarantor.LoanApplicationId = onewLoanApplication.LoanApplicationId;
                    onewLoanGuarantor.LoanAmount = onewLoanApplication.LoanAmount;
                }

                if (onewMemberShare != null)
                {
                    onewLoanGuarantor.MemberShareId = onewMemberShare.MemberShareId;
                    onewLoanGuarantor.GuarantorName = onewMemberShare.MemberName;
                }
                double.TryParse(txtTotalShares.Text, out totalshares);
                onewLoanGuarantor.TotalShares = totalshares;
                double.TryParse(txtFreeShares.Text, out freeshares);
                onewLoanGuarantor.FreeShares = freeshares;
                onewLoanGuarantor.GuaranteedAmount = int.Parse(txtGuaranteedAmount.Text);
                // onewLoanGuarantor.IsActive = chkIsActive.Checked;
            }

            string error = "";
            onewLoanGuarantor.LoanGuarantorId = onewLoanGuarantor.AddEditLoanGuarantor(false, ref error);
            if (error == "")
            {

                // txtGuaranteedAmount.Text = "";
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoanGuarantor();
                onewLoanGuarantor = null;


            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            ClearloanGuarantor();

        }

        private void ClearloanGuarantor()
        {
            onewMemberShare = null;
            txtMemberShare.Text = "";
            txtGuaranteedAmount.Text = "";
            txtFreeShares.Text = "";
            txtTotalShares.Text = "";
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            onewLoanGuarantor = null;
            if (objList.SelectedObject != null)
                onewLoanGuarantor = (Classes.LoanGuarantor)objList.SelectedObject;
            if (onewLoanGuarantor != null)
            {
                txtMemberShare.Text = onewLoanGuarantor.MemberName;
                txtGuaranteedAmount.Text = onewLoanGuarantor.GuaranteedAmount.ToString();
                txtFreeShares.Text = onewLoanGuarantor.FreeShares.ToString();
                txtTotalShares.Text = onewLoanGuarantor.TotalShares.ToString();
            }
        }

        private void LoadLoanGuarantor()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();

            myList = oLoanGuarantor.GetLoanGuarantors();
            foreach (Classes.LoanGuarantor omemsha in myList)
            {
                if (onewLoanApplication.LoanApplicationId == omemsha.LoanApplicationId)
                {
                    newList.Add(omemsha);
                }
            }
            objList.SetObjects(newList);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            onewMemberShare = null;
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSearchMemberShares frm = new SYSTEMUPGRADEPF.frmSearchMemberShares();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMemberShare = oMemberShare.GetMemberShare(frm.selInt);
            if (onewMemberShare != null)
            {
                if (onewMemberShare.IsActive == true)
                {
                    onewLoanType = oLoantype.GetLoanType(onewLoanApplication.LoanTypeId);
                    if (!onewLoanType.MemberCanGuaranteeOwnLoan)
                    {
                        if (onewLoanApplication.MemberId == onewMemberShare.MemberId)
                        {
                            MessageBox.Show("Member Cannot Guarantee Own Loan", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtMemberShare.Focus();
                            return;
                        }
                    }
                    else
                    {
                        txtMemberShare.Text = onewMemberShare.MemberName;
                        txtTotalShares.Text = onewMemberShare.Balance.ToString();
                    }
                }
            }


            else
            {
                MessageBox.Show("Selected Item is Inactive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberShare.Focus();
                return;
            }


        }


        private void button6_Click(object sender, EventArgs e)
        {
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSearchLoanTypeCollateral frm = new frmSearchLoanTypeCollateral();


            frm.PickingValues = true;
            frm.LoanTypeCollateralId = onewLoanApplication.LoanTypeId;
            frm.ShowDialog();
            onewLoanTypeCollateral = oLoanTypeCollateral.GetLTCollateral(frm.selInt);
            if (onewLoanTypeCollateral != null)
            {
                if (onewLoanTypeCollateral.IsActive == true)
                {

                    txtCollateralName.Text = onewLoanTypeCollateral.Description;
                    txtOwner.Text = txtMemberName.Text;
                }
                else
                {
                    MessageBox.Show("Selected Item is InActive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                // onewLoanApplicationCollateral.LoanTypeCollateralId = onewLoanTypeCollateral.LoanTypeCollateralId;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            saveToLoanApplicationCollaterals();
            //if(ptbImage.Image !=null )
            //{ 
            //saveLoanApplicationCollateralDocument();
            //}
        }



        private void saveToLoanApplicationCollaterals()
        {
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double collateralValue = 0;
            double FixedValue = 0;
            if (onewLoanApplicationCollateral == null)
                onewLoanApplicationCollateral = new Classes.LoanApplicationCollateral();
            if (onewLoanApplication != null)
                onewLoanApplicationCollateral.LoanApplicationId = onewLoanApplication.LoanApplicationId;
            if (onewLoanTypeCollateral != null)
            {
                onewLoanApplicationCollateral.CollateralName = onewLoanTypeCollateral.Description;
                onewLoanApplicationCollateral.LoanTypeCollateralId = onewLoanTypeCollateral.LoanTypeCollateralId;
            }

            onewLoanApplicationCollateral.CollateralRemarks = txtComments.Text;
            double.TryParse(txtCollateralValue.Text, out collateralValue);
            onewLoanApplicationCollateral.CollateralValue = collateralValue;
            double.TryParse(txtForcedValue.Text, out FixedValue);
            onewLoanApplicationCollateral.ForcedValue = FixedValue;
            onewLoanApplicationCollateral.ExpiryDate = dtpAppDate.Value;

            onewLoanApplicationCollateral.OwnerDocument = txtCollateralDocument.Text;
            onewLoanApplicationCollateral.OwnerName = txtOwner.Text;
            string err = "";
            onewLoanApplicationCollateral.LoanApplicationCollateralId = onewLoanApplicationCollateral.AddEditLoanApplicationCollateral(false, ref err);
            if (err == "")
            {

                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLoanApplicationCollaterals();
                onewLoanApplicationCollateral = null;

            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // LoadLoanApplicationCollaterals();
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListLoanApplicationCollateral.SelectedObject != null)
                onewLoanApplicationCollateral = (Classes.LoanApplicationCollateral)objListLoanApplicationCollateral.SelectedObject;
            if (onewLoanApplicationCollateral != null)
                this.selInt = onewLoanApplicationCollateral.LoanApplicationCollateralId;
        }

        private void LoadLoanApplicationCollaterals()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            myList = oLoanApplicationCollateral.GetLoanApplicationCollaterals();
            foreach (Classes.LoanApplicationCollateral oloappcol in myList)
            {
                if (onewLoanApplication.LoanApplicationId == oloappcol.LoanApplicationId)
                {
                    newList.Add(oloappcol);
                }
            }
            objListLoanApplicationCollateral.SetObjects(newList);

        }

        private void txtCollateralValue_TextChanged(object sender, EventArgs e)
        {
            txtForcedValue.Text = txtCollateralValue.Text;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            onewLoanCollateralImages = oLoanCollateralImages.GetLoanCollateralImage(onewLoanApplicationCollateral.LoanApplicationCollateralId);
            if (onewLoanCollateralImages != null)
                ptbCollateralimage.Image = onewLoanCollateralImages.getLoanCollateralPhoto(onewLoanApplicationCollateral.LoanApplicationCollateralId);





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog1.FileName;
                    //ptbImage .Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // int id = onewLoanApplicationCollateral.LoanApplicationCollateralId;
            //saveLoanApplicationCollateralDocument();
        }

        private void btnAddNewImage_Click(object sender, EventArgs e)
        {
            if (onewLoanApplicationCollateral == null)
            {
                MessageBox.Show("Loan Application Collateral is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmLoanApplicationCollateralImages frm = new frmLoanApplicationCollateralImages();
            frm.LoanCollateralImageId = onewLoanApplicationCollateral.LoanApplicationCollateralId;
            frm.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void objListCharges_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListCharges.SelectedObject != null)
                onewLoanApplicationCharge = (Classes.LoanApplicationCharge)objListCharges.SelectedObject;

        }
        private void SaveOtherCharges()
        {
            if (onewLoanApplication == null)
                return;

            if (onewLoanApplication != null)
            {
                string err = "";
                for (int i = 0; i < objListCharges.Items.Count; i++)
                {
                    Classes.OtherCharge oCharge = (Classes.OtherCharge)objListCharges.GetModelObject(i);
                    Classes.LoanApplicationCharge olac = new Classes.LoanApplicationCharge();
                    olac.Amount = oCharge.Amount;
                    olac.ChargeId = oCharge.ChargeId;
                    olac.IsActive = true;
                    olac.RateBased = oCharge.RateBased;
                    olac.IsTieredBased = oCharge.IsTieredBased;
                    olac.LoanApplicationId = onewLoanApplication.LoanApplicationId;
                    olac.LowerLimit = oCharge.LowerLimit;
                    olac.PeriodChange = oCharge.PeriodChange;
                    olac.UpperLimit = oCharge.UpperLimit;
                    olac.LoanApplicationChargeId = olac.AddEditLoanAppCharge(false, ref err);


                }
            }


        }
        private bool IsOtherCharge()
        {
            bool othercharge = false;
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            // myList = oLoanApplicationCharge.GetLoanApplicationCharges();
            // newList = oOtherCharge.GetOtherCharges();

            {
                othercharge = true;

            }
            if (othercharge)

            {
                myList = oOtherCharge.GetOtherCharges();
                foreach (Classes.OtherCharge ocha in myList)
                {
                    if (onewLoanType != null)
                    {


                        if (onewLoanType.ProductId == ocha.LoanTypeId)
                        {
                            newList.Add(ocha);
                        }
                    }
                }
            }
            else
            {
                myList = oLoanApplicationCharge.GetLoanApplicationCharges();
                foreach (Classes.LoanApplicationCharge ola in myList)
                {
                    if (onewLoanApplication != null)
                    {
                        if (onewLoanApplication.LoanApplicationId == ola.LoanApplicationId)
                        {
                            newList.Add(ola);
                        }
                    }
                }

            }
            objListCharges.SetObjects(newList);


            return othercharge;

        }
        private void LoadLoanTypeCharges()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();

            myList = oOtherCharge.GetOtherCharges();
            foreach (Classes.OtherCharge ocha in myList)
            {
                if (onewLoanType != null)
                {


                    if (onewLoanType.ProductId == ocha.LoanTypeId)
                    {
                        newList.Add(ocha);
                    }
                }
            }
            objListCharges.SetObjects(newList);
        }
        private void LoadLoanApplicationCharge()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();

            myList = oLoanApplicationCharge.GetLoanApplicationCharges();
            foreach (Classes.LoanApplicationCharge ola in myList)
            {
                if (onewLoanApplication != null)
                {
                    if (onewLoanApplication.LoanApplicationId == ola.LoanApplicationId)
                    {
                        newList.Add(ola);
                    }
                }
            }
            objListCharges.SetObjects(newList);
        }

        private void objListCharges_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        { }











        private void txtGuaranteedAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (onewLoanGuarantor != null)
            {
                //prompt for deletion
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected item", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.No)
                    return;
                else
                {
                    //  in some cases we might have to check for more options

                    string err = "";
                    onewLoanGuarantor.AddEditLoanGuarantor(true, ref err);
                    LoadLoanGuarantor();
                    onewLoanGuarantor = null;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (onewLoanTypeCollateral == null)
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
                onewLoanApplicationCollateral.AddEditLoanApplicationCollateral(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoanApplicationCollaterals();
                    onewLoanApplicationCharge = null;
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (onewLoanApplicationCharge == null)
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
                onewLoanApplicationCharge.AddEditLoanAppCharge(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoanApplicationCharge();
                    onewLoanApplicationCharge = null;
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void txtLoanAmount_TextChanged(object sender, EventArgs e)
        {
            //TxtRepaymentAmnt.Text = (txtLoanAmount.Text) / (txtRepaymentPeriod.Text);
            double repayment = 0;
            double loanamount = 0;
            int period = 0;
            // double.TryParse(TxtRepaymentAmnt.Text, out repayment);
            double.TryParse(txtLoanAmount.Text, out loanamount);
            int.TryParse(txtRepaymentPeriod.Text, out period);
            repayment = loanamount / period;
            TxtRepaymentAmnt.Text = repayment.ToString("###,###.00");

        }

        private void txtForcedValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (onewLoanApplication != null)
            {
                cmbLoanStatus.SelectedIndex = 0;
                SaveLoanApplications();
                btnrejected.Enabled = false;
                btnDisburse.Enabled = false;
                btnApprove.Enabled = true;
            }
            else
            {
                cmbLoanStatus.SelectedIndex = onewLoanApplication.LoanStatusId;
            }
        }
        public void DisburseLoan()
        {

            if (onewLoan == null)
                onewLoan = new Classes.Loan();
            if (onewLoanApplication != null)
            {

                onewLoan.LoanApplicationId = onewLoanApplication.LoanApplicationId;
                onewLoan.LoanAmount = onewLoanApplication.LoanAmount;
                onewLoan.LoanCode = onewLoanApplication.LoanCode;
                onewLoan.LoanPurposeId = onewLoanApplication.LoanPurposeId;
                onewLoan.LoanRepaymentAmount = onewLoanApplication.LoanRepaymentAmount;
                onewLoan.LoanStatusId = onewLoanApplication.LoanStatusId;
                onewLoan.LoanTypeId = onewLoanApplication.LoanTypeId;
                onewLoan.ManualRefNo = onewLoanApplication.ManualRefNo;
                onewLoan.MemberId = onewLoanApplication.MemberId;
                onewLoan.RepaymentPeriod = onewLoanApplication.RepaymentPeriod;
                onewLoan.LoanEffectDate = onewLoanApplication.LoanEffectDate;
                onewLoan.IsActive = onewLoanApplication.IsActive;
                onewLoan.InterestRate = onewLoanApplication.InterestRate;
                onewLoan.CreditOfficerId = onewLoanApplication.CreditOfficerId;
                onewLoan.BranchId = onewLoanApplication.BranchId;
                onewLoan.DonorId = onewLoanApplication.DonorId;
                onewLoan.ApplicationDate = onewLoanApplication.ApplicationDate;
            }
            frmLoanDisbursement frm = new SYSTEMUPGRADEPF.frmLoanDisbursement();
            onewLoan.Description = frm.Description;
            onewLoan.PaidByName = frm.PaidBy;
            onewLoan.DocumentNo = frm.DocumentNo;
            onewLoan.DebitGL = frm.BankId;
            onewLoan.ModeOfPaymentId = frm.ModeOfPaymentId;
            onewLoan.ValueDate = frm.ValueDate;
            onewLoan.TransactionDate = frm.TransactionDate;
            string error = "";
            if (frm.selMemberShareId > 0)
            {
                onewLoan.LoanId = onewLoan.transferLoan(false, ref error);
            }
            else
            {
                onewLoan.LoanId = onewLoan.transferLoan(false, ref error);
            }



            if (error == "")
            {
                MessageBox.Show("Process Suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {

            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application Is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewLoanApplication != null)
            {
                if (onewLoanApplication.LoanStatusId == 2)
                {
                    cmbLoanStatus.SelectedIndex = 3;
                    Updating = true;
                    SaveLoanApplications();

                    SaveDisbursedLoans();

                    btnApprove.Enabled = false;
                    btnrejected.Enabled = false;
                    btnDisburse.Enabled = false;
                    ClearText();


                }
                loadCurrencies();

            }
            else
            {
                MessageBox.Show("Only Approved Loans can be Disbursed", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                cmbLoanStatus.SelectedIndex = onewLoanApplication.LoanStatusId;
                btnApprove.Enabled = true;
                btnrejected.Enabled = true;

            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application Is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewLoanApplication == null)
            {
                MessageBox.Show("Loan Application Is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewLoanApplication != null)
            {
                cmbLoanStatus.SelectedIndex = 2;

                SaveLoanApplications();
                if (saved)
                {
                    btnDisburse.Enabled = true;
                    btnrejected.Enabled = true;
                    btnApprove.Enabled = false;
                }
                else
                {
                    btnDisburse.Enabled = false;
                    btnrejected.Enabled = true;
                    btnApprove.Enabled = true;
                }



            }
            else
            {
                cmbLoanStatus.SelectedIndex = onewLoanApplication.LoanStatusId;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            SaveDisbursedLoans();
        }

        private void SaveDisbursedLoans()
        {
            frmLoanDisbursement frm = new SYSTEMUPGRADEPF.frmLoanDisbursement();

            double amount = 0, exchangerateid = 0;
            if (onewLoan == null)
                onewLoan = new Classes.Loan();
            if (onewLoanApplication != null)
            {

                frm.Amount = onewLoanApplication.LoanAmount;
                frm.TransactingCurrencyId = onewLoanApplication.ForeignCurrencyId;
                frm.MemberId = onewLoanApplication.MemberId;
                frm.ShowDialog();
                onewLoan.LoanApplicationId = onewLoanApplication.LoanApplicationId;
                onewLoan.LoanAmount = frm.Amount;
                onewLoan.LoanCode = onewLoanApplication.LoanCode;
                onewLoan.LoanPurposeId = onewLoanApplication.LoanPurposeId;
                onewLoan.LoanRepaymentAmount = onewLoanApplication.LoanRepaymentAmount;
                onewLoan.LoanStatusId = cmbLoanStatus.SelectedIndex;
                onewLoan.LoanTypeId = onewLoanApplication.LoanTypeId;
                onewProduct = oProduct.GetProduct(onewLoanApplication.LoanTypeId);
                if (onewProduct != null)
                    onewLoan.ProductId = onewProduct.ProductId;
                onewLoan.ManualRefNo = onewLoanApplication.ManualRefNo;
                onewLoan.MemberId = onewLoanApplication.MemberId;
                onewLoan.RepaymentPeriod = onewLoanApplication.RepaymentPeriod;
                onewLoan.LoanEffectDate = onewLoanApplication.LoanEffectDate;
                onewLoan.IsActive = onewLoanApplication.IsActive;
                onewLoan.InterestRate = onewLoanApplication.InterestRate;
                onewLoan.CreditOfficerId = onewLoanApplication.CreditOfficerId;
                onewLoan.BranchId = onewLoanApplication.BranchId;
                onewLoan.DonorId = onewLoanApplication.DonorId;
                onewLoan.ApplicationDate = onewLoanApplication.ApplicationDate;
                onewLoan.DefaultCurrencyId = onewLoanApplication.DefaultCurrencyId;
                onewLoan.ForeignCurrencyId = onewLoanApplication.ForeignCurrencyId; ;
                onewLoan.FCAmount = onewLoanApplication.FCAmount;
                onewLoan.LoanAmount = frm.Amount;
                onewLoan.ExchangeRate = onewLoanApplication.ExchangeRate;

            }

            //frm.Show();
            onewLoan.Description = frm.Description;
            onewLoan.PaidByName = frm.PaidBy;
            onewLoan.DocumentNo = frm.DocumentNo;
            onewLoan.DebitGL = frm.BankId;
            onewLoan.ModeOfPaymentId = frm.ModeOfPaymentId;
            onewLoan.ValueDate = frm.ValueDate;
            onewLoan.TransactionDate = frm.TransactionDate;

            onewLoan.MemberShareId = frm.selMemberShareId;
            onewLoan.SourceId = frm.selMemberShareId;

            if(onewRepaymentPeriod.PeriodReference == "Days")
            {
            onewLoan.NextDueDate = frm.TransactionDate.AddDays(onewRepaymentPeriod.FrequencyRange*onewLoanType.GracePeriod );
            }
            else if  (onewRepaymentPeriod.PeriodReference == "Months")
            {
                onewLoan.NextDueDate = frm.TransactionDate .AddMonths(onewRepaymentPeriod.FrequencyRange * onewLoanType.GracePeriod);
            }
            else if (onewRepaymentPeriod.PeriodReference == "Weeks")
            {
                onewLoan.NextDueDate = frm.TransactionDate .AddDays(onewRepaymentPeriod.FrequencyRange*7 * onewLoanType.GracePeriod);
            }
            else if (onewRepaymentPeriod.PeriodReference == "Year")
            {
                onewLoan.NextDueDate = frm.TransactionDate .AddYears(onewRepaymentPeriod.FrequencyRange * onewLoanType.GracePeriod);
            }
            onewLoan.LoanEffectDate = onewLoan.NextDueDate;





            onewLoan.CurrentPrincipalBalance = (onewLoan.PrincipalBalance) + (onewLoan.LoanAmount);





            string error = "";
            if (frm.selMemberShareId > 0)
            {
                onewLoan.LoanId = onewLoan.transferLoan(false, ref error);

                
            }
            else
            {
                onewLoan.LoanId = onewLoan.AddEditLoan   (false, ref error);
               
            }
            if (error == "")
            {

                MessageBox.Show("Process Suceded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            otxrcurrency = null;
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;
            object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if (myCurrency != null)
            {
                otxrcurrency = myCurrency;


            }

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            // saveInterest(l);
        }

       

        private void button1_Click_4(object sender, EventArgs e)
        {
            double IntAmount = 0, rate = 0, monthCount = 1, repayPeriod = 0, origAmount = 0, monthlyRepayment = 0;

            double.TryParse(txtLoanAmount.Text, out origAmount);
            double.TryParse(txtInterestRate.Text, out rate);
            double.TryParse(txtRepaymentPeriod.Text, out repayPeriod);
            double.TryParse(TxtRepaymentAmnt.Text, out monthCount);



            IntAmount = Math.Abs(Financial.IPmt(rate / 36500, repayPeriod, monthCount, origAmount));
            monthlyRepayment = Math.Abs(Financial.PPmt(rate / 36500, repayPeriod, monthCount, origAmount));
        }
    }
}
