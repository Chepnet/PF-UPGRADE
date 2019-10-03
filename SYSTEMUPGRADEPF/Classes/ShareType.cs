using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class ShareType
    {
        private int _shareTypeId = 0;
        private int _productId = 0;
        private string _shareTypeCode = "";
        private string _description = "";
        private double _minDeposit = 0;
        private bool _hasMaxAmount = false;
        private double _maxAmount = 0;
        private double _withHoldingTax = 0;
        private bool _canEarnDividends = false;
        private double _dividendRate = 0;
        private bool _canBeWithDrawn = false;
        private double _withdrawalLimit = 0;
        private bool _isCallDeposit = false;
        private int _productOnMaturity = 0;
        private bool _canBeTransferred = false;
        private bool _canquaranteeLoan = false;
        private int _paymentFrequency = 0;
        private bool _earnsInterest = false;
        private int _shareGL = 0;
        private int _taxGL = 0;
        private int _interestExpenseGL = 0;
        private int _interestPayableGL = 0;
        private int _overdraftGL = 0;
        private bool _chargeDefaulters = false;
        private bool _allowMultipleAccounts = false;
        private bool _denyBackDatedEntities = false;
        private int _maxBackDatedDays = 0;
        private bool _trackArrears = false;
        private int _dailyRateSpecification = 0;
        private double _fixedDepositInterestRate = 0;
        private int _accrualFrequency = 0;
        private bool _isPrimaryInterfaceAcc = false;
        private bool _isActive = false;
        private bool _canBeOverdrawn = false;

        private string _productDescription = "";
        

        public int ShareTypeId { get { return _shareTypeId; } set { _shareTypeId = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string ShareTypeCode { get { return _shareTypeCode; } set { _shareTypeCode = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public double MinDeposit { get { return _minDeposit; } set { _minDeposit = value; } }
        public bool HasMaxAmount { get { return _hasMaxAmount; } set { _hasMaxAmount = value; } }
        public double MaxAmount { get { return _maxAmount; } set { _maxAmount = value; } }
        public double WithHoldingTax { get { return _withHoldingTax; } set { _withHoldingTax = value; } }
        public bool CanEarnDividends { get { return _canEarnDividends; } set { _canEarnDividends = value; } }
        public double DividendRate { get { return _dividendRate; } set { _dividendRate = value; } }
        public bool CanBeWithDrawn { get { return _canBeWithDrawn; } set { _canBeWithDrawn = value; } }
        public double WithdrawalLimit { get { return _withdrawalLimit; } set { _withdrawalLimit = value; } }
      
        public bool IsCallDeposit { get { return _isCallDeposit; } set { _isCallDeposit = value; } }
        public int ProductOnMaturity { get { return _productOnMaturity; } set { _productOnMaturity = value; } }
        public bool CanBeTransferred { get { return _canBeTransferred; } set { _canBeTransferred = value; } }
        public bool CanQuaranteeLoan { get { return _canquaranteeLoan; } set { _canquaranteeLoan = value; } }
        public int PaymentFrequency { get { return _paymentFrequency; } set { _paymentFrequency = value; } }
        public bool EarnsInterest { get { return _earnsInterest; } set { _earnsInterest = value; } }
        public int ShareGL { get { return _shareGL; } set { _shareGL = value; } }
        public int TaxGL { get { return _taxGL; } set { _taxGL = value; } }
        public int InterestExpenseGL { get { return _interestExpenseGL; } set { _interestExpenseGL = value; } }
        public int InterestPayableGL { get { return _interestPayableGL; } set { _interestPayableGL = value; } }
        public int OverdraftGL { get { return _overdraftGL; } set { _overdraftGL = value; } }
        public bool ChargeDefaulters { get { return _chargeDefaulters; } set { _chargeDefaulters = value; } }
        public bool AllowMultipleAccounts { get { return _allowMultipleAccounts; } set { _allowMultipleAccounts = value; } }
        public bool DenyBackDatedEntities { get { return _denyBackDatedEntities; } set { _denyBackDatedEntities = value; } }
        public int MaxBackDatedDays { get { return _maxBackDatedDays; } set { _maxBackDatedDays = value; } }
        public bool TrackArrears { get { return _trackArrears; } set { _trackArrears = value; } }
        public int DailyRateSpecification { get { return _dailyRateSpecification; } set { _dailyRateSpecification = value; } }
        public double  FixedDepositInterestRate { get { return _fixedDepositInterestRate; } set { _fixedDepositInterestRate = value; } }
        public int AccrualFrequency { get { return _accrualFrequency; } set { _accrualFrequency = value; } }
        public bool IsPrimaryInterfaceAcc { get { return _isPrimaryInterfaceAcc; } set { _isPrimaryInterfaceAcc = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public bool CanBeOverDrawn { get { return _canBeOverdrawn; } set { _canBeOverdrawn = value; } }

        public string ProductDescription { get { return _productDescription; } set { _productDescription = value; } }

        Product oProduct = new Product();

        string err = "";
        public ArrayList GetShareTypes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllShareTypes");
            if(err=="")
            {
                while(rd.Read())
                {
                    ShareType obj = new Classes.ShareType();
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeCode"].ToString())) obj.ShareTypeCode = rd["ShareTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["MinDeposit"].ToString())) obj.MinDeposit = double.Parse(rd["MinDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasMaxAmount"].ToString())) obj.HasMaxAmount = bool.Parse(rd["HasMaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTax"].ToString())) obj.WithHoldingTax = float.Parse(rd["WithHoldingTax"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanEarnDividends"].ToString())) obj.CanEarnDividends = bool.Parse(rd["CanEarnDividends"].ToString());
                    if (!String.IsNullOrEmpty(rd["DividendRate"].ToString())) obj.DividendRate = float.Parse(rd["DividendRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeWithDrawn"].ToString())) obj.CanBeWithDrawn = bool.Parse(rd["CanBeWithDrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalLimit"].ToString())) obj.WithdrawalLimit = double.Parse(rd["WithdrawalLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsCallDeposit"].ToString())) obj.IsCallDeposit = bool.Parse(rd["IsCallDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductOnMaturity"].ToString())) obj.ProductOnMaturity = int.Parse(rd["ProductOnMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeTransferred"].ToString())) obj.CanBeTransferred = bool.Parse(rd["CanBeTransferred"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeOverdrawn"].ToString())) obj.CanBeOverDrawn = bool.Parse(rd["CanBeOverdrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanQuaranteeLoan"].ToString())) obj.CanQuaranteeLoan = bool.Parse(rd["CanQuaranteeLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymentFrequency"].ToString())) obj.PaymentFrequency = int.Parse(rd["PaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["EarnsInterest"].ToString())) obj.EarnsInterest = bool.Parse(rd["EarnsInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareGL"].ToString())) obj.ShareGL = int.Parse(rd["ShareGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxGL"].ToString())) obj.TaxGL = int.Parse(rd["TaxGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestExpenseGL"].ToString())) obj.InterestExpenseGL = int.Parse(rd["InterestExpenseGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayableGL"].ToString())) obj.InterestPayableGL = int.Parse(rd["InterestPayableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["OverdraftGL"].ToString())) obj.OverdraftGL = int.Parse(rd["OverdraftGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeDefaulters"].ToString())) obj.ChargeDefaulters = bool.Parse(rd["ChargeDefaulters"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowMultipleAccounts"].ToString())) obj.AllowMultipleAccounts = bool.Parse(rd["AllowMultipleAccounts"].ToString());
                    if (!String.IsNullOrEmpty(rd["DenyBackDatedEntities"].ToString())) obj.DenyBackDatedEntities = bool.Parse(rd["DenyBackDatedEntities"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxBackDatedDays"].ToString())) obj.MaxBackDatedDays = int.Parse(rd["MaxBackDatedDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["TrackArrears"].ToString())) obj.TrackArrears = bool.Parse(rd["TrackArrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositInterestRate"].ToString())) obj.FixedDepositInterestRate = float.Parse(rd["FixedDepositInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccrualFrequency"].ToString())) obj.AccrualFrequency = int.Parse(rd["AccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPrimaryInterfaceAcc"].ToString())) obj.IsPrimaryInterfaceAcc = bool.Parse(rd["IsPrimaryInterfaceAcc"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.ProductId >0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if(myProduct !=null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }

                    }

                    myList.Add(obj);


                }
                try { rd.Read(); }
                catch {; }
            }
            return myList;


        }
        public ArrayList GetOnlyFixedDepositShareTypes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getShareTypeFixedDeposits");
            if (err == "")
            {
                while (rd.Read())
                {
                    ShareType obj = new Classes.ShareType();
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeCode"].ToString())) obj.ShareTypeCode = rd["ShareTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["MinDeposit"].ToString())) obj.MinDeposit = double.Parse(rd["MinDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasMaxAmount"].ToString())) obj.HasMaxAmount = bool.Parse(rd["HasMaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTax"].ToString())) obj.WithHoldingTax = float.Parse(rd["WithHoldingTax"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanEarnDividends"].ToString())) obj.CanEarnDividends = bool.Parse(rd["CanEarnDividends"].ToString());
                    if (!String.IsNullOrEmpty(rd["DividendRate"].ToString())) obj.DividendRate = float.Parse(rd["DividendRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeWithDrawn"].ToString())) obj.CanBeWithDrawn = bool.Parse(rd["CanBeWithDrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalLimit"].ToString())) obj.WithdrawalLimit = double.Parse(rd["WithdrawalLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsCallDeposit"].ToString())) obj.IsCallDeposit = bool.Parse(rd["IsCallDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductOnMaturity"].ToString())) obj.ProductOnMaturity = int.Parse(rd["ProductOnMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeTransferred"].ToString())) obj.CanBeTransferred = bool.Parse(rd["CanBeTransferred"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeOverdrawn"].ToString())) obj.CanBeOverDrawn  = bool.Parse(rd["CanBeOverdrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanQuaranteeLoan"].ToString())) obj.CanQuaranteeLoan = bool.Parse(rd["CanQuaranteeLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymentFrequency"].ToString())) obj.PaymentFrequency = int.Parse(rd["PaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["EarnsInterest"].ToString())) obj.EarnsInterest = bool.Parse(rd["EarnsInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareGL"].ToString())) obj.ShareGL = int.Parse(rd["ShareGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxGL"].ToString())) obj.TaxGL = int.Parse(rd["TaxGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestExpenseGL"].ToString())) obj.InterestExpenseGL = int.Parse(rd["InterestExpenseGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayableGL"].ToString())) obj.InterestPayableGL = int.Parse(rd["InterestPayableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["OverdraftGL"].ToString())) obj.OverdraftGL = int.Parse(rd["OverdraftGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeDefaulters"].ToString())) obj.ChargeDefaulters = bool.Parse(rd["ChargeDefaulters"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowMultipleAccounts"].ToString())) obj.AllowMultipleAccounts = bool.Parse(rd["AllowMultipleAccounts"].ToString());
                    if (!String.IsNullOrEmpty(rd["DenyBackDatedEntities"].ToString())) obj.DenyBackDatedEntities = bool.Parse(rd["DenyBackDatedEntities"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxBackDatedDays"].ToString())) obj.MaxBackDatedDays = int.Parse(rd["MaxBackDatedDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["TrackArrears"].ToString())) obj.TrackArrears = bool.Parse(rd["TrackArrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositInterestRate"].ToString())) obj.FixedDepositInterestRate = float.Parse(rd["FixedDepositInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccrualFrequency"].ToString())) obj.AccrualFrequency = int.Parse(rd["AccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPrimaryInterfaceAcc"].ToString())) obj.IsPrimaryInterfaceAcc = bool.Parse(rd["IsPrimaryInterfaceAcc"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());


                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }

                    }

                    myList.Add(obj);


                }
                try { rd.Read(); }
                catch {; }
            }
            return myList;


        }

        public ArrayList GetFixedDepositShareTypes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getShareTypeFixedDeposits");
            if (err == "")
            {
                while (rd.Read())
                {
                    ShareType obj = new Classes.ShareType();
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeCode"].ToString())) obj.ShareTypeCode = rd["ShareTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["MinDeposit"].ToString())) obj.MinDeposit = double.Parse(rd["MinDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasMaxAmount"].ToString())) obj.HasMaxAmount = bool.Parse(rd["HasMaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTax"].ToString())) obj.WithHoldingTax = float.Parse(rd["WithHoldingTax"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanEarnDividends"].ToString())) obj.CanEarnDividends = bool.Parse(rd["CanEarnDividends"].ToString());
                    if (!String.IsNullOrEmpty(rd["DividendRate"].ToString())) obj.DividendRate = float.Parse(rd["DividendRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeWithDrawn"].ToString())) obj.CanBeWithDrawn = bool.Parse(rd["CanBeWithDrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalLimit"].ToString())) obj.WithdrawalLimit = double.Parse(rd["WithdrawalLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsCallDeposit"].ToString())) obj.IsCallDeposit = bool.Parse(rd["IsCallDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductOnMaturity"].ToString())) obj.ProductOnMaturity = int.Parse(rd["ProductOnMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeTransferred"].ToString())) obj.CanBeTransferred = bool.Parse(rd["CanBeTransferred"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeOverdrawn"].ToString())) obj.CanBeOverDrawn = bool.Parse(rd["CanBeOverdrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanQuaranteeLoan"].ToString())) obj.CanQuaranteeLoan = bool.Parse(rd["CanQuaranteeLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymentFrequency"].ToString())) obj.PaymentFrequency = int.Parse(rd["PaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["EarnsInterest"].ToString())) obj.EarnsInterest = bool.Parse(rd["EarnsInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareGL"].ToString())) obj.ShareGL = int.Parse(rd["ShareGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxGL"].ToString())) obj.TaxGL = int.Parse(rd["TaxGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestExpenseGL"].ToString())) obj.InterestExpenseGL = int.Parse(rd["InterestExpenseGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayableGL"].ToString())) obj.InterestPayableGL = int.Parse(rd["InterestPayableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["OverdraftGL"].ToString())) obj.OverdraftGL = int.Parse(rd["OverdraftGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeDefaulters"].ToString())) obj.ChargeDefaulters = bool.Parse(rd["ChargeDefaulters"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowMultipleAccounts"].ToString())) obj.AllowMultipleAccounts = bool.Parse(rd["AllowMultipleAccounts"].ToString());
                    if (!String.IsNullOrEmpty(rd["DenyBackDatedEntities"].ToString())) obj.DenyBackDatedEntities = bool.Parse(rd["DenyBackDatedEntities"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxBackDatedDays"].ToString())) obj.MaxBackDatedDays = int.Parse(rd["MaxBackDatedDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["TrackArrears"].ToString())) obj.TrackArrears = bool.Parse(rd["TrackArrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositInterestRate"].ToString())) obj.FixedDepositInterestRate = float.Parse(rd["FixedDepositInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccrualFrequency"].ToString())) obj.AccrualFrequency = int.Parse(rd["AccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPrimaryInterfaceAcc"].ToString())) obj.IsPrimaryInterfaceAcc = bool.Parse(rd["IsPrimaryInterfaceAcc"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }

                    }

                    myList.Add(obj);


                }
                try { rd.Read(); }
                catch {; }
            }
            return myList;


        }
        public ArrayList GetSavingsShareType()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getShareTypeSavings");
            if (err == "")
            {
                while (rd.Read())
                {
                    ShareType obj = new Classes.ShareType();
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeCode"].ToString())) obj.ShareTypeCode = rd["ShareTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["MinDeposit"].ToString())) obj.MinDeposit = double.Parse(rd["MinDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasMaxAmount"].ToString())) obj.HasMaxAmount = bool.Parse(rd["HasMaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTax"].ToString())) obj.WithHoldingTax = float.Parse(rd["WithHoldingTax"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanEarnDividends"].ToString())) obj.CanEarnDividends = bool.Parse(rd["CanEarnDividends"].ToString());
                    if (!String.IsNullOrEmpty(rd["DividendRate"].ToString())) obj.DividendRate = float.Parse(rd["DividendRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeWithDrawn"].ToString())) obj.CanBeWithDrawn = bool.Parse(rd["CanBeWithDrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalLimit"].ToString())) obj.WithdrawalLimit = double.Parse(rd["WithdrawalLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsCallDeposit"].ToString())) obj.IsCallDeposit = bool.Parse(rd["IsCallDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductOnMaturity"].ToString())) obj.ProductOnMaturity = int.Parse(rd["ProductOnMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeTransferred"].ToString())) obj.CanBeTransferred = bool.Parse(rd["CanBeTransferred"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeOverdrawn"].ToString())) obj.CanBeOverDrawn = bool.Parse(rd["CanBeOverdrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanQuaranteeLoan"].ToString())) obj.CanQuaranteeLoan = bool.Parse(rd["CanQuaranteeLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymentFrequency"].ToString())) obj.PaymentFrequency = int.Parse(rd["PaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["EarnsInterest"].ToString())) obj.EarnsInterest = bool.Parse(rd["EarnsInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareGL"].ToString())) obj.ShareGL = int.Parse(rd["ShareGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxGL"].ToString())) obj.TaxGL = int.Parse(rd["TaxGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestExpenseGL"].ToString())) obj.InterestExpenseGL = int.Parse(rd["InterestExpenseGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayableGL"].ToString())) obj.InterestPayableGL = int.Parse(rd["InterestPayableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["OverdraftGL"].ToString())) obj.OverdraftGL = int.Parse(rd["OverdraftGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeDefaulters"].ToString())) obj.ChargeDefaulters = bool.Parse(rd["ChargeDefaulters"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowMultipleAccounts"].ToString())) obj.AllowMultipleAccounts = bool.Parse(rd["AllowMultipleAccounts"].ToString());
                    if (!String.IsNullOrEmpty(rd["DenyBackDatedEntities"].ToString())) obj.DenyBackDatedEntities = bool.Parse(rd["DenyBackDatedEntities"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxBackDatedDays"].ToString())) obj.MaxBackDatedDays = int.Parse(rd["MaxBackDatedDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["TrackArrears"].ToString())) obj.TrackArrears = bool.Parse(rd["TrackArrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositInterestRate"].ToString())) obj.FixedDepositInterestRate = float.Parse(rd["FixedDepositInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccrualFrequency"].ToString())) obj.AccrualFrequency = int.Parse(rd["AccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPrimaryInterfaceAcc"].ToString())) obj.IsPrimaryInterfaceAcc = bool.Parse(rd["IsPrimaryInterfaceAcc"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }

                    }

                    myList.Add(obj);


                }
                try { rd.Read(); }
                catch {; }
            }
            return myList;


        }

        public ShareType  GetShareType(int ShareTypeId)
        {
            ShareType obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getShareType", "@ShareTypeId", ShareTypeId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.ShareType();
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeCode"].ToString())) obj.ShareTypeCode = rd["ShareTypeCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["MinDeposit"].ToString())) obj.MinDeposit = double.Parse(rd["MinDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasMaxAmount"].ToString())) obj.HasMaxAmount = bool.Parse(rd["HasMaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxAmount"].ToString())) obj.MaxAmount = double.Parse(rd["MaxAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTax"].ToString())) obj.WithHoldingTax = double.Parse(rd["WithHoldingTax"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanEarnDividends"].ToString())) obj.CanEarnDividends = bool.Parse(rd["CanEarnDividends"].ToString());
                    if (!String.IsNullOrEmpty(rd["DividendRate"].ToString())) obj.DividendRate = double.Parse(rd["DividendRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeWithDrawn"].ToString())) obj.CanBeWithDrawn = bool.Parse(rd["CanBeWithDrawn"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalLimit"].ToString())) obj.WithdrawalLimit = double.Parse(rd["WithdrawalLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsCallDeposit"].ToString())) obj.IsCallDeposit = bool.Parse(rd["IsCallDeposit"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductOnMaturity"].ToString())) obj.ProductOnMaturity = int.Parse(rd["ProductOnMaturity"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanBeTransferred"].ToString())) obj.CanBeTransferred = bool.Parse(rd["CanBeTransferred"].ToString());
                    if (!String.IsNullOrEmpty(rd["CanQuaranteeLoan"].ToString())) obj.CanQuaranteeLoan = bool.Parse(rd["CanQuaranteeLoan"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymentFrequency"].ToString())) obj.PaymentFrequency = int.Parse(rd["PaymentFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["EarnsInterest"].ToString())) obj.EarnsInterest = bool.Parse(rd["EarnsInterest"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareGL"].ToString())) obj.ShareGL = int.Parse(rd["ShareGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxGL"].ToString())) obj.TaxGL = int.Parse(rd["TaxGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestExpenseGL"].ToString())) obj.InterestExpenseGL = int.Parse(rd["InterestExpenseGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestPayableGL"].ToString())) obj.InterestPayableGL = int.Parse(rd["InterestPayableGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["OverdraftGL"].ToString())) obj.OverdraftGL = int.Parse(rd["OverdraftGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeDefaulters"].ToString())) obj.ChargeDefaulters = bool.Parse(rd["ChargeDefaulters"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowMultipleAccounts"].ToString())) obj.AllowMultipleAccounts = bool.Parse(rd["AllowMultipleAccounts"].ToString());
                    if (!String.IsNullOrEmpty(rd["DenyBackDatedEntities"].ToString())) obj.DenyBackDatedEntities = bool.Parse(rd["DenyBackDatedEntities"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaxBackDatedDays"].ToString())) obj.MaxBackDatedDays = int.Parse(rd["MaxBackDatedDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["TrackArrears"].ToString())) obj.TrackArrears = bool.Parse(rd["TrackArrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["DailyRateSpecification"].ToString())) obj.DailyRateSpecification = int.Parse(rd["DailyRateSpecification"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositInterestRate"].ToString())) obj.FixedDepositInterestRate = double.Parse(rd["FixedDepositInterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccrualFrequency"].ToString())) obj.AccrualFrequency = int.Parse(rd["AccrualFrequency"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPrimaryInterfaceAcc"].ToString())) obj.IsPrimaryInterfaceAcc = bool.Parse(rd["IsPrimaryInterfaceAcc"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }

                    }

                }
                try { rd.Read(); }
                catch {; }
            }
            return obj;


        }
        public int AddEdit(bool delete ,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditShareType", "@ShareTypeId", this.ShareTypeId,
            "@ProductId", this.ProductId,
            "@ShareTypeCode", this.ShareTypeCode,
            "@Description", this.Description,
            "@MinDeposit", this.MinDeposit,
            "@HasMaxAmount", this.HasMaxAmount,
            "@MaxAmount", this.MaxAmount,
            "@WithHoldingTax", this.WithHoldingTax,
            "@CanEarnDividends", this.CanEarnDividends,
            "@DividendRate", this.DividendRate,
            "@CanBeWithDrawn", this.CanBeWithDrawn,
            "@WithdrawalLimit", this.WithdrawalLimit,
            "@IsCallDeposit", this.IsCallDeposit,
            "@ProductOnMaturity", this.ProductOnMaturity,
            "@CanBeTransferred", this.CanBeTransferred,
            "@CanQuaranteeLoan", this.CanQuaranteeLoan,
            "@PaymentFrequency", this.PaymentFrequency,
            "@EarnsInterest", this.EarnsInterest,
            "@ShareGL", this.ShareGL,
            "@TaxGL", this.TaxGL,
            "@InterestExpenseGL", this.InterestExpenseGL,
            "@InterestPayableGL", this.InterestPayableGL,
            "@OverdraftGL", this.OverdraftGL,
            "@ChargeDefaulters", this.ChargeDefaulters,
            "@AllowMultipleAccounts", this.AllowMultipleAccounts,
            "@DenyBackDatedEntities", this.DenyBackDatedEntities,
            "@MaxBackDatedDays", this.MaxBackDatedDays,
            "@TrackArrears", this.TrackArrears,
            "@DailyRateSpecification", this.DailyRateSpecification,
            "@FixedDepositInterestRate", this.FixedDepositInterestRate,
            "@AccrualFrequency", this.AccrualFrequency,
            "@IsPrimaryInterfaceAcc", this.IsPrimaryInterfaceAcc,
            "@CanBeOverdrawn", this.CanBeOverDrawn,
            "@MachineName", "USER-PC",
            "@IsActive", this.IsActive,
            "@delete", delete,
            "@CreatedBy", "Admin"
);
            if(err=="")
            {if(rd.Read ())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            err = error;
            return id;
        }

    }
}
