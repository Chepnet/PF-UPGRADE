using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanType
    {
        private int _productId = 0;
        private string _loanTypeCode = "";
        private string _loanTypeName = "";
        private int _maxPeriod = 0;
        private int _repaymentFrequency = 0;
        private double _monthlyInterestRate = 0;
        private int _dailyRateSpecification = 0;
        private bool _penaltyIsRate = false;
        private double _penaltyValue = 0;
        private int _penaltyCalculationOption = 0;
        private int _penaltyPostingMethod = 0;
        private int _penaltyAccrualFrequency = 0;
        private int _thresholdDays = 0;
        private double _penaltyMinAmount = 0;
        private bool _applyPenaltyAfterMaturity = false;
        private int _penaltyFrequencyCalculation = 0;
        private bool _consinderInduplum = false;
        private bool _adjustableInterestRate = false;
        private bool _chargeFutureInterest = false;
        private bool _allowZeroRating = false;
        private bool _continueChargingInterestOnMaturedLoans = false;
        private int _interestPostingMethod = 0;
        private int _interestPostingFrequency = 0;
        private int _dailyInterestRateOptions = 0;
        private int _interestPayMethod = 0;
        private int _collateral = 0;
        private double _incomeFactor = 0;
        private double _shareFactor = 0;
        private int _loanFactor = 0;
        private int _minGuarantors = 0;
        private int _maxGuarantors = 0;
        private double _minShares = 0;
        private double _minAmount = 0;
        private double _maxAmount = 0;
        private int _interestCalculationFormula = 0;
        private int _loanCategoriesId = 0;
        private bool _roundingPerProductAndInterestRate = false;
        private bool _tieLoanToCreditOfficer = false;
        private bool _defaultEffectDateToTheBeginningOfNextMonth = false;
        private int _loanGlCode = 0;
        private int _interestGlCode = 0;
        private int _penaltyGlCode = 0;
        private int _writeOffGlCode = 0;
        private int _interestReceivableGL = 0;
        private int _penaltyReceivableGl = 0;
        private int _gracePeriod = 0;
        private string _remarks = "";
        private bool _chargeInterestDuringGracePeriod = false;
        private bool _isActive = false;
        private bool _changeInterestIfClearingLoan = false;
        private bool _memberCanGuaranteeOwnLoan = false;
        private bool _mustBeFullySecured = false;
        private bool _allowUseOfZeroOrLessFreeShares = false;
        private bool _allowPartialDisbursement = false;
        private double _principalRoundingNearest = 0;
        private int _principalRoundingValue = 0;
        private double _interestRoundingNearest = 0;
        private int _interestRoundingValue = 0;
        private string _paymentname = "";
        private string _productdescription = "";
        private string _loanGLCodeAc = "";
        private string _interestGLcodeAc = "";
        private string _penaltyGLcodeAc = "";
        private string _writtoofGLcodeAc = "";
        private string _interestreceivableG = "";
        private string _penaltyGlcodeAc = "";
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string LoanTypeCode { get { return _loanTypeCode; } set { _loanTypeCode = value; } }
        public string LoanTypeName { get { return _loanTypeName; } set { _loanTypeName = value; } }
        public int MaxPeriod { get { return _maxPeriod; } set { _maxPeriod = value; } }
        public int RepaymentFrequency { get { return _repaymentFrequency; } set { _repaymentFrequency = value; } }
        public double MonthlyInterestRate { get { return _monthlyInterestRate; } set { _monthlyInterestRate = value; } }
        public int DailyRateSpecification { get { return _dailyRateSpecification; } set { _dailyRateSpecification = value; } }
        public bool PenaltyIsRate { get { return _penaltyIsRate; } set { _penaltyIsRate = value; } }
        public double PenaltyValue { get { return _penaltyValue; } set { _penaltyValue = value; } }
        public int PenaltyCalculationOption { get { return _penaltyCalculationOption; } set { _penaltyCalculationOption = value; } }
        public int PenaltyPostingMethod { get { return _penaltyPostingMethod; } set { _penaltyPostingMethod = value; } }
        public int PenaltyAccrualFrequency { get { return _penaltyAccrualFrequency; } set { _penaltyAccrualFrequency = value; } }
        public int ThresholdDays { get { return _thresholdDays; } set { _thresholdDays = value; } }
        public double PenaltyMinAmount { get { return _penaltyMinAmount; } set { _penaltyMinAmount = value; } }
        public bool ApplyPenaltyAfterMaturity { get { return _applyPenaltyAfterMaturity; } set { _applyPenaltyAfterMaturity = value; } }
        public int PenaltyFrequencyCalculation { get { return _penaltyFrequencyCalculation; } set { _penaltyFrequencyCalculation = value; } }
        public bool ConsinderInduplum { get { return _consinderInduplum; } set { _consinderInduplum = value; } }
        public bool AdjustableInterestRate { get { return _adjustableInterestRate; } set { _adjustableInterestRate = value; } }
        public bool ChargeFutureInterest { get { return _chargeFutureInterest; } set { _chargeFutureInterest = value; } }
        public bool AllowZeroRating { get { return _allowZeroRating; } set { _allowZeroRating = value; } }
        public bool ContinueChargingInterestOnMaturedLoans { get { return _continueChargingInterestOnMaturedLoans; } set { _continueChargingInterestOnMaturedLoans = value; } }
        public int InterestPostingMethod { get { return _interestPostingMethod; } set { _interestPostingMethod = value; } }
        public int InterestPostingFrequency { get { return _interestPostingFrequency; } set { _interestPostingFrequency = value; } }
        public int DailyInterestRateOptions { get { return _dailyInterestRateOptions; } set { _dailyInterestRateOptions = value; } }
        public int InterestPayMethod { get { return _interestPayMethod; } set { _interestPayMethod = value; } }
        public int Collateral { get { return _collateral; } set { _collateral = value; } }
        public double IncomeFactor { get { return _incomeFactor; } set { _incomeFactor = value; } }
        public double ShareFactor { get { return _shareFactor; } set { _shareFactor = value; } }
        public int LoanFactor { get { return _loanFactor; } set { _loanFactor = value; } }
        public int MinGuarantors { get { return _minGuarantors; } set { _minGuarantors = value; } }
        public int MaxGuarantors { get { return _maxGuarantors; } set { _maxGuarantors = value; } }
        public double MinShares { get { return _minShares; } set { _minShares = value; } }
        public double MinAmount { get { return _minAmount; } set { _minAmount = value; } }
        public double MaxAmount { get { return _maxAmount; } set { _maxAmount = value; } }
        public int InterestCalculationFormula { get { return _interestCalculationFormula; } set { _interestCalculationFormula = value; } }
        public int LoanCategoriesId { get { return _loanCategoriesId; } set { _loanCategoriesId = value; } }
        public bool RoundingPerProductAndInterestRate { get { return _roundingPerProductAndInterestRate; } set { _roundingPerProductAndInterestRate = value; } }
        public bool TieLoanToCreditOfficer { get { return _tieLoanToCreditOfficer; } set { _tieLoanToCreditOfficer = value; } }
        public bool DefaultEffectDateToTheBeginningOfNextMonth { get { return _defaultEffectDateToTheBeginningOfNextMonth; } set { _defaultEffectDateToTheBeginningOfNextMonth = value; } }
        public int LoanGlCode { get { return _loanGlCode; } set { _loanGlCode = value; } }
        public int InterestGlCode { get { return _interestGlCode; } set { _interestGlCode = value; } }
        public int PenaltyGlCode { get { return _penaltyGlCode; } set { _penaltyGlCode = value; } }
        public int WriteOffGlCode { get { return _writeOffGlCode; } set { _writeOffGlCode = value; } }
        public int InterestReceivableGL { get { return _interestReceivableGL; } set { _interestReceivableGL = value; } }
        public int PenaltyReceivableGl { get { return _penaltyReceivableGl; } set { _penaltyReceivableGl = value; } }
        public int GracePeriod { get { return _gracePeriod; } set { _gracePeriod = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public bool ChargeInterestDuringGracePeriod { get { return _chargeInterestDuringGracePeriod; } set { _chargeInterestDuringGracePeriod = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public bool ChangeInterestIfClearingLoan { get { return _changeInterestIfClearingLoan; } set { _changeInterestIfClearingLoan = value; } }
        public bool MemberCanGuaranteeOwnLoan { get { return _memberCanGuaranteeOwnLoan; } set { _memberCanGuaranteeOwnLoan = value; } }
        public bool MustBeFullySecured { get { return _mustBeFullySecured; } set { _mustBeFullySecured = value; } }
        public bool AllowUseOfZeroOrLessFreeShares { get { return _allowUseOfZeroOrLessFreeShares; } set { _allowUseOfZeroOrLessFreeShares = value; } }
        public bool AllowPartialDisbursement { get { return _allowPartialDisbursement; } set { _allowPartialDisbursement = value; } }
        public double PrincipalRoundingNearest { get { return _principalRoundingNearest; } set { _principalRoundingNearest = value; } }
        public int PrincipalRoundingValue { get { return _principalRoundingValue; } set { _principalRoundingValue = value; } }
        public double InterestRoundingNearest { get { return _interestRoundingNearest; } set { _interestRoundingNearest = value; } }
        public int InterestRoundingValue { get { return _interestRoundingValue; } set { _interestRoundingValue = value; } }

        public string PaymentName { get { return _paymentname ; } set { _paymentname = value; } }
        public string ProductDescription { get { return _productdescription ; } set { _productdescription = value; } }
        public string LoanGlCodeAc { get { return _loanGLCodeAc ; } set { _loanGLCodeAc = value; } }
        public string InterestGLCodeAC { get { return _interestGLcodeAc ; } set { _interestGLcodeAc = value; } }
        public string PenaltyGlCodeAc { get { return _penaltyGlcodeAc ; } set { _penaltyGlcodeAc = value; } }
        public string WrittOfGlCodeAc { get { return _writtoofGLcodeAc  ; } set { _writtoofGLcodeAc = value; } }
        public string InterestReceivableGlAc { get { return _interestreceivableG ; } set { _interestreceivableG = value; } }
        Product oProduct = new Product();

        RepaymentPeriod oRepaymentPeriod = new RepaymentPeriod();
        ChartOfAccount oChartOfAccount = new ChartOfAccount();

        public string DailyRateSpecificationTypeName
        {
            get
            {
                string name = "";
                switch (this.DailyRateSpecification )
                {
                    case 0:
                        name = "No Of Days.";
                        break;
                    case 1:
                        name = "Use 30 Days.";
                        break;
                    case 2:
                        name = "Annual Rate / 360.";
                        break;
                    case 3:
                        name = "Annual Rate / 365.";
                        break;
                    
                    case 4:
                        name = "Annual Rate / 366.";
                        break;

                }
                


                return name;
            }
        }
        public string InterestPayMethodName
        {
            get
            {
                string name = "";
                switch (this.InterestPayMethod )
                {
                    case 0:
                        name = "Fixed/Flat";
                        break;
                    case 1:
                        name = "Reducing Balance";
                        break;
                    case 2:
                        name = "Reducing Balance Constant";
                        break;
                    case 3:
                        name = "Amortised";
                        break;

                    

                }



                return name;
            }
        }

        public string PostingMethodName
        {
            get
            {
                string name = "";
                switch (this.InterestPostingMethod )
                {
                    case 0:
                        name = "Cash Basis";
                        break;
                    case 1:
                        name = "Interest Accrual";
                        break;
                    case 2:
                        name = "Accrual to Books";
                        break;
                }

                return name;
            }
        }

        public string CalculationFormulaName
        {
            get
            {
                string name = "";
                switch (this.InterestCalculationFormula )
                {
                    case 0:
                        name = "(PRT/100)";
                        break;
                    case 1:
                        name = "P(T+1)R)/200";
                        break;
                    case 2:
                        name = "P(T+R+2)/200";
                        break;
                }

                return name;
            }
        }

        public string PostingFrequencyName
        {
            get
            {
                string name = "";
                switch (this.InterestPostingFrequency )
                {
                    case 0:
                        name = "Calculating on Anniversary";
                        break;
                    case 1:
                        name = "Calculate Daily";
                        break;
                    case 2:
                        name = "End Of Month";
                        break;
                }

                return name;
            }
        }


        public string CalculationOptionName
        {
            get
            {
                string name = "";
                switch (this.InterestCalculationFormula)
                {
                    case 0:
                        name = "Principal Balance";
                        break;
                    case 1:
                        name = "Principal+Interest Arreas";
                        break;
                    case 2:
                        name = "Principal Arreas";
                        break;
                    case 3:
                        name = "Principal+Interest+penaltyArreas.";
                        break;
                }

                return name;
            }
        }

        public string PenaltiesPostingMethodName
        {
            get
            {
                string name = "";
                switch (this.PenaltyPostingMethod  )
                {
                    case 0:
                        name = " Cash Basis";
                        break;
                    case 1:
                        name = "Load to Principal";
                        break;
                   
                }

                return name;
            }
        }
        public string FrequencyCalcualtionName
        {
            get
            {
                string name = "";
                switch (this.PenaltyFrequencyCalculation  )
                {
                    case 0:
                        name = "  No of Days in a Month";
                        break;
                    case 1:
                        name = "Use 30 Days";
                        break;
                    case 2:
                        name = " Annual Rate / 365 Days";
                        break;
                    case 3:
                        name = " Annual Rate / 366 Days";
                        break;
                    case 4:
                        name = " Annual Rate / 360 Days";
                        break;
                }

                return name;
            }
        }

        string err = "";
        public ArrayList GetLoanTypes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllLoanTypes");
            if (err == "")
            {
                while (rd.Read())
                {

                    LoanType obj = new Classes.LoanType();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeCode"].ToString())) obj.LoanTypeCode = rd["LoanTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["LoanTypeName"].ToString())) obj.LoanTypeName = rd["LoanTypeName"].ToString();
                    if (!String.IsNullOrEmpty(rd["MaxPeriod"].ToString())) obj.MaxPeriod = int.Parse(rd["MaxPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentFrequency"].ToString())) obj.RepaymentFrequency = int.Parse(rd["RepaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["MonthlyInterestRate"].ToString())) obj.MonthlyInterestRate = double.Parse(rd["MonthlyInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyIsRate"].ToString())) obj.PenaltyIsRate = bool.Parse(rd["PenaltyIsRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyValue"].ToString())) obj.PenaltyValue = double.Parse(rd["PenaltyValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyCalculationOption"].ToString())) obj.PenaltyCalculationOption = int.Parse(rd["PenaltyCalculationOption"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyPostingMethod"].ToString())) obj.PenaltyPostingMethod = int.Parse(rd["PenaltyPostingMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyAccrualFrequency"].ToString())) obj.PenaltyAccrualFrequency = int.Parse(rd["PenaltyAccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["ThresholdDays"].ToString())) obj.ThresholdDays = int.Parse(rd["ThresholdDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyMinAmount"].ToString())) obj.PenaltyMinAmount = double.Parse(rd["PenaltyMinAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ApplyPenaltyAfterMaturity"].ToString())) obj.ApplyPenaltyAfterMaturity = bool.Parse(rd["ApplyPenaltyAfterMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyFrequencyCalculation"].ToString())) obj.PenaltyFrequencyCalculation = int.Parse(rd["PenaltyFrequencyCalculation"].ToString());
                    if (!String.IsNullOrEmpty(rd["ConsinderInduplum"].ToString())) obj.ConsinderInduplum = bool.Parse(rd["ConsinderInduplum"].ToString());
                    if (!String.IsNullOrEmpty(rd["AdjustableInterestRate"].ToString())) obj.AdjustableInterestRate = bool.Parse(rd["AdjustableInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeFutureInterest"].ToString())) obj.ChargeFutureInterest = bool.Parse(rd["ChargeFutureInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowZeroRating"].ToString())) obj.AllowZeroRating = bool.Parse(rd["AllowZeroRating"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContinueChargingInterestOnMaturedLoans"].ToString())) obj.ContinueChargingInterestOnMaturedLoans = bool.Parse(rd["ContinueChargingInterestOnMaturedLoans"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPostingMethod"].ToString())) obj.InterestPostingMethod = int.Parse(rd["InterestPostingMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPostingFrequency"].ToString())) obj.InterestPostingFrequency = int.Parse(rd["InterestPostingFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyInterestRateOptions"].ToString())) obj.DailyInterestRateOptions = int.Parse(rd["DailyInterestRateOptions"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayMethod"].ToString())) obj.InterestPayMethod = int.Parse(rd["InterestPayMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["Collateral"].ToString())) obj.Collateral = int.Parse(rd["Collateral"].ToString());
                    if (!String.IsNullOrEmpty(rd["IncomeFactor"].ToString())) obj.IncomeFactor = double.Parse(rd["IncomeFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareFactor"].ToString())) obj.ShareFactor = double.Parse(rd["ShareFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanFactor"].ToString())) obj.LoanFactor = int.Parse(rd["LoanFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinGuarantors"].ToString())) obj.MinGuarantors = int.Parse(rd["MinGuarantors"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxGuarantors"].ToString())) obj.MaxGuarantors = int.Parse(rd["MaxGuarantors"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinShares"].ToString())) obj.MinShares = double.Parse(rd["MinShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinAmount"].ToString())) obj.MinAmount = double.Parse(rd["MinAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestCalculationFormula"].ToString())) obj.InterestCalculationFormula = int.Parse(rd["InterestCalculationFormula"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCategoriesId"].ToString())) obj.LoanCategoriesId = int.Parse(rd["LoanCategoriesId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingPerProductAndInterestRate"].ToString())) obj.RoundingPerProductAndInterestRate = bool.Parse(rd["RoundingPerProductAndInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["TieLoanToCreditOfficer"].ToString())) obj.TieLoanToCreditOfficer = bool.Parse(rd["TieLoanToCreditOfficer"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultEffectDateToTheBeginningOfNextMonth"].ToString())) obj.DefaultEffectDateToTheBeginningOfNextMonth = bool.Parse(rd["DefaultEffectDateToTheBeginningOfNextMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanGlCode"].ToString())) obj.LoanGlCode = int.Parse(rd["LoanGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestGlCode"].ToString())) obj.InterestGlCode = int.Parse(rd["InterestGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyGlCode"].ToString())) obj.PenaltyGlCode = int.Parse(rd["PenaltyGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["WriteOffGlCode"].ToString())) obj.WriteOffGlCode = int.Parse(rd["WriteOffGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestReceivableGL"].ToString())) obj.InterestReceivableGL = int.Parse(rd["InterestReceivableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyReceivableGl"].ToString())) obj.PenaltyReceivableGl = int.Parse(rd["PenaltyReceivableGl"].ToString());
                    if (!String.IsNullOrEmpty(rd["GracePeriod"].ToString())) obj.GracePeriod = int.Parse(rd["GracePeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["ChargeInterestDuringGracePeriod"].ToString())) obj.ChargeInterestDuringGracePeriod = bool.Parse(rd["ChargeInterestDuringGracePeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChangeInterestIfClearingLoan"].ToString())) obj.ChangeInterestIfClearingLoan = bool.Parse(rd["ChangeInterestIfClearingLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberCanGuaranteeOwnLoan"].ToString())) obj.MemberCanGuaranteeOwnLoan = bool.Parse(rd["MemberCanGuaranteeOwnLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["MustBeFullySecured"].ToString())) obj.MustBeFullySecured = bool.Parse(rd["MustBeFullySecured"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowUseOfZeroOrLessFreeShares"].ToString())) obj.AllowUseOfZeroOrLessFreeShares = bool.Parse(rd["AllowUseOfZeroOrLessFreeShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowPartialDisbursement"].ToString())) obj.AllowPartialDisbursement = bool.Parse(rd["AllowPartialDisbursement"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalRoundingNearest"].ToString())) obj.PrincipalRoundingNearest = double.Parse(rd["PrincipalRoundingNearest"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalRoundingValue"].ToString())) obj.PrincipalRoundingValue = int.Parse(rd["PrincipalRoundingValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRoundingNearest"].ToString())) obj.InterestRoundingNearest = double.Parse(rd["InterestRoundingNearest"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRoundingValue"].ToString())) obj.InterestRoundingValue = int.Parse(rd["InterestRoundingValue"].ToString());

                    if (obj.RepaymentFrequency >0)
                    {
                        RepaymentPeriod myPeriod = oRepaymentPeriod.GetRepaymentPeriod(obj.RepaymentFrequency);
                        if(myPeriod !=null)
                        {
                            obj.PaymentName  = myPeriod.Name;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }
                    }
                    if (obj.LoanGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.LoanGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.LoanGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.InterestGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.InterestGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.InterestGLCodeAC  = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.PenaltyGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.PenaltyGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.PenaltyGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.WriteOffGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.WriteOffGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.WrittOfGlCodeAc  = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.InterestReceivableGL > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.InterestReceivableGL);
                        if (myChartOfAccount != null)
                        {
                            obj.InterestReceivableGlAc  = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.PenaltyGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.PenaltyGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.PenaltyGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }



                    myList.Add(obj);
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return myList;
        }

        public LoanType GetLoanType(int LoanTypeId)
        {
            LoanType obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getLoanType", "@ProductId", LoanTypeId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanType();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeCode"].ToString())) obj.LoanTypeCode = rd["LoanTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["LoanTypeName"].ToString())) obj.LoanTypeName = rd["LoanTypeName"].ToString();
                    if (!String.IsNullOrEmpty(rd["MaxPeriod"].ToString())) obj.MaxPeriod = int.Parse(rd["MaxPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentFrequency"].ToString())) obj.RepaymentFrequency = int.Parse(rd["RepaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["MonthlyInterestRate"].ToString())) obj.MonthlyInterestRate = double.Parse(rd["MonthlyInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyIsRate"].ToString())) obj.PenaltyIsRate = bool.Parse(rd["PenaltyIsRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyValue"].ToString())) obj.PenaltyValue = double.Parse(rd["PenaltyValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyCalculationOption"].ToString())) obj.PenaltyCalculationOption = int.Parse(rd["PenaltyCalculationOption"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyPostingMethod"].ToString())) obj.PenaltyPostingMethod = int.Parse(rd["PenaltyPostingMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyAccrualFrequency"].ToString())) obj.PenaltyAccrualFrequency = int.Parse(rd["PenaltyAccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["ThresholdDays"].ToString())) obj.ThresholdDays = int.Parse(rd["ThresholdDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyMinAmount"].ToString())) obj.PenaltyMinAmount = double.Parse(rd["PenaltyMinAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ApplyPenaltyAfterMaturity"].ToString())) obj.ApplyPenaltyAfterMaturity = bool.Parse(rd["ApplyPenaltyAfterMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyFrequencyCalculation"].ToString())) obj.PenaltyFrequencyCalculation = int.Parse(rd["PenaltyFrequencyCalculation"].ToString());
                    if (!String.IsNullOrEmpty(rd["ConsinderInduplum"].ToString())) obj.ConsinderInduplum = bool.Parse(rd["ConsinderInduplum"].ToString());
                    if (!String.IsNullOrEmpty(rd["AdjustableInterestRate"].ToString())) obj.AdjustableInterestRate = bool.Parse(rd["AdjustableInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeFutureInterest"].ToString())) obj.ChargeFutureInterest = bool.Parse(rd["ChargeFutureInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowZeroRating"].ToString())) obj.AllowZeroRating = bool.Parse(rd["AllowZeroRating"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContinueChargingInterestOnMaturedLoans"].ToString())) obj.ContinueChargingInterestOnMaturedLoans = bool.Parse(rd["ContinueChargingInterestOnMaturedLoans"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPostingMethod"].ToString())) obj.InterestPostingMethod = int.Parse(rd["InterestPostingMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPostingFrequency"].ToString())) obj.InterestPostingFrequency = int.Parse(rd["InterestPostingFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyInterestRateOptions"].ToString())) obj.DailyInterestRateOptions = int.Parse(rd["DailyInterestRateOptions"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayMethod"].ToString())) obj.InterestPayMethod = int.Parse(rd["InterestPayMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["Collateral"].ToString())) obj.Collateral = int.Parse(rd["Collateral"].ToString());
                    if (!String.IsNullOrEmpty(rd["IncomeFactor"].ToString())) obj.IncomeFactor = double.Parse(rd["IncomeFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareFactor"].ToString())) obj.ShareFactor = double.Parse(rd["ShareFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanFactor"].ToString())) obj.LoanFactor = int.Parse(rd["LoanFactor"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinGuarantors"].ToString())) obj.MinGuarantors = int.Parse(rd["MinGuarantors"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxGuarantors"].ToString())) obj.MaxGuarantors = int.Parse(rd["MaxGuarantors"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinShares"].ToString())) obj.MinShares = double.Parse(rd["MinShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinAmount"].ToString())) obj.MinAmount = double.Parse(rd["MinAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestCalculationFormula"].ToString())) obj.InterestCalculationFormula = int.Parse(rd["InterestCalculationFormula"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCategoriesId"].ToString())) obj.LoanCategoriesId = int.Parse(rd["LoanCategoriesId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingPerProductAndInterestRate"].ToString())) obj.RoundingPerProductAndInterestRate = bool.Parse(rd["RoundingPerProductAndInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["TieLoanToCreditOfficer"].ToString())) obj.TieLoanToCreditOfficer = bool.Parse(rd["TieLoanToCreditOfficer"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultEffectDateToTheBeginningOfNextMonth"].ToString())) obj.DefaultEffectDateToTheBeginningOfNextMonth = bool.Parse(rd["DefaultEffectDateToTheBeginningOfNextMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanGlCode"].ToString())) obj.LoanGlCode = int.Parse(rd["LoanGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestGlCode"].ToString())) obj.InterestGlCode = int.Parse(rd["InterestGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyGlCode"].ToString())) obj.PenaltyGlCode = int.Parse(rd["PenaltyGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["WriteOffGlCode"].ToString())) obj.WriteOffGlCode = int.Parse(rd["WriteOffGlCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestReceivableGL"].ToString())) obj.InterestReceivableGL = int.Parse(rd["InterestReceivableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyReceivableGl"].ToString())) obj.PenaltyReceivableGl = int.Parse(rd["PenaltyReceivableGl"].ToString());
                    if (!String.IsNullOrEmpty(rd["GracePeriod"].ToString())) obj.GracePeriod = int.Parse(rd["GracePeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["ChargeInterestDuringGracePeriod"].ToString())) obj.ChargeInterestDuringGracePeriod = bool.Parse(rd["ChargeInterestDuringGracePeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChangeInterestIfClearingLoan"].ToString())) obj.ChangeInterestIfClearingLoan = bool.Parse(rd["ChangeInterestIfClearingLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberCanGuaranteeOwnLoan"].ToString())) obj.MemberCanGuaranteeOwnLoan = bool.Parse(rd["MemberCanGuaranteeOwnLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["MustBeFullySecured"].ToString())) obj.MustBeFullySecured = bool.Parse(rd["MustBeFullySecured"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowUseOfZeroOrLessFreeShares"].ToString())) obj.AllowUseOfZeroOrLessFreeShares = bool.Parse(rd["AllowUseOfZeroOrLessFreeShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowPartialDisbursement"].ToString())) obj.AllowPartialDisbursement = bool.Parse(rd["AllowPartialDisbursement"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalRoundingNearest"].ToString())) obj.PrincipalRoundingNearest = double.Parse(rd["PrincipalRoundingNearest"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalRoundingValue"].ToString())) obj.PrincipalRoundingValue = int.Parse(rd["PrincipalRoundingValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRoundingNearest"].ToString())) obj.InterestRoundingNearest = double.Parse(rd["InterestRoundingNearest"].ToString());
                  
                    if (obj.RepaymentFrequency > 0)
                    {
                        RepaymentPeriod myPeriod = oRepaymentPeriod.GetRepaymentPeriod(obj.RepaymentFrequency);
                        if (myPeriod != null)
                        {
                            obj.PaymentName  = myPeriod.Name;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }
                    }
                    if (obj.LoanGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.LoanGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.LoanGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.InterestGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.InterestGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.InterestGLCodeAC  = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.PenaltyGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.PenaltyGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.PenaltyGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.WriteOffGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.WriteOffGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.WrittOfGlCodeAc   = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.InterestReceivableGL > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.InterestReceivableGL);
                        if (myChartOfAccount != null)
                        {
                            obj.InterestReceivableGlAc  = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.PenaltyGlCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.PenaltyGlCode);
                        if (myChartOfAccount != null)
                        {
                            obj.PenaltyGlCodeAc = myChartOfAccount.AccountName;
                        }
                    }
                   

                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;
        }
       

        public int AddEditLoanType(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditLoanType",
                    //"@LoanTypeId", this.LoanTypeId ,
                    "@ProductId", this.ProductId,
                    "@LoanTypeCode", this.LoanTypeCode,
                    "@LoanTypeName", this.LoanTypeName,
                    "@MaxPeriod", this.MaxPeriod,
                    "@RepaymentFrequency", this.RepaymentFrequency,
                    "@MonthlyInterestRate", this.MonthlyInterestRate,
                    "@DailyRateSpecification", this.DailyRateSpecification,
                    "@PenaltyIsRate", this.PenaltyIsRate,
                    "@PenaltyValue", this.PenaltyValue,
                    "@PenaltyBalanceCalculationOption", this.PenaltyCalculationOption ,
                    "@PenaltyPostingMethod", this.PenaltyPostingMethod,
                    "@PenaltyAccrualFrequency", this.PenaltyAccrualFrequency ,
                    "@ThresholdDays", this.ThresholdDays,
                    "@PenaltyMinLoanBalance", this.PenaltyMinAmount ,
                    "@ApplyPenaltyAfterMaturity", this.ApplyPenaltyAfterMaturity,
                    "@PenaltyFrequencyCalculationOption", this.PenaltyFrequencyCalculation ,
                    "@ConsinderInduplum", this.ConsinderInduplum,
                    "@AdjustableInterestRate", this.AdjustableInterestRate,
                    "@ChargeFutureInterest", this.ChargeFutureInterest,
                    "@AllowZeroRating", this.AllowZeroRating,
                    "@ContinueChargingInterestOnMaturedLoans", this.ContinueChargingInterestOnMaturedLoans,
                     "@InterestPostingMethod", this.InterestPostingMethod,
                    "@InterestPostingFrequency", this.InterestPostingFrequency,
                    "@DailyInterestRateOptions", this.DailyInterestRateOptions,
                    "@InterestPayMethod", this.InterestPayMethod,
                    "@Collateral", this.Collateral,
                    "@IncomeFactor", this.IncomeFactor,
                    "@ShareFactor", this.ShareFactor,
                    "@LoanFactor", this.LoanFactor,
                    "@MinGuarantors", this.MinGuarantors,
                    "@MaxGuarantors", this.MaxGuarantors,
                    "@MinShares", this.MinShares,
                    "@MinAmount", this.MinAmount,
                    "@MaxAmount", this.MaxAmount,
                    "@InterestCalculationFormula", this.InterestCalculationFormula,
                    "@LoanCategoriesId", this.LoanCategoriesId,
                    "@RoundingPerProductAndInterestRate", this.RoundingPerProductAndInterestRate,
                    "@TieLoanToCreditOfficer", this.TieLoanToCreditOfficer,
                    "@DefaultEffectDateToTheBeginningOfNextMonth", this.DefaultEffectDateToTheBeginningOfNextMonth,
                    "@LoanGlCode", this.LoanGlCode,
                    "@InterestGlCode", this.InterestGlCode,
                    "@PenaltyGlCode", this.PenaltyGlCode,
                    "@WriteOffGlCode", this.WriteOffGlCode,
                    "@InterestReceivableGL", this.InterestReceivableGL,
                    "@PenaltyReceivableGl", this.PenaltyReceivableGl,
                    "@GracePeriod", this.GracePeriod,
                    "@Remarks", this.Remarks,
                    "@MemberCanGuaranteeOwnLoan", this.MemberCanGuaranteeOwnLoan,
                    "@MustBeFullySecured", this.MustBeFullySecured,
                    "@AllowUseOfZeroOrLessFreeShares", this.AllowUseOfZeroOrLessFreeShares,
                    "@ChangeInterestDuringGracePeriod", this.ChargeInterestDuringGracePeriod,
                    "@IsActive", this.IsActive,
                    "@ChangeInterestIfClearingLoan", this.ChangeInterestIfClearingLoan,
                    "@AllowPartialDisbursement", this.AllowPartialDisbursement,
                    "@PrincipalRoundingNearest",this.PrincipalRoundingNearest ,
                    "@PrincipalRoundingValue ",this.PrincipalRoundingValue ,
                    "@InterestRoundingNearest",this.InterestRoundingNearest ,
                    "@InterestRoundingValue",this.InterestRoundingValue,
                    "@MachineName", "USER-PC",
                    "@CreatedBy", "ADMIN",
                    "@delete", delete);
            if (err == "")
            {
                try
                {
                    if (rd.Read())
                    {
                        id = int.Parse(rd["Id"].ToString());
                    }
                    try { rd.Close(); } catch {; }
                }
                catch (SqlException ex) when (ex.Number ==547)
                {

                }
                
            }
            error = err;

            return id;
        }
    }

    }
