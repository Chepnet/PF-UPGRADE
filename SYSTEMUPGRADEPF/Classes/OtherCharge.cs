using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class OtherCharge
    {
        private int _chargeId = 0;
        private int _productId = 0;
        private int _loanTypeId = 0;
        private int _chargeGLAccountId = 0;
        private int _periodChange = 0;
        private double _amount = 0;
        private bool _rateBased = false;
        private bool _hasLimit = false;
        private double _lowerLimit = 0;
        private double _upperLimit = 0;
        private bool _isFormula = false;
        private string _formula = "";
        private bool _isTopUpCharge = false;
        private bool _isTieredBased = false;
        private bool _calculationIncludesBothInterestAndPrincipal = false;
        private bool _isActive = false;
        private string _accountName = "";
        private string _loantypeName = "";
        private string _productName = "";
        // private int _loanApplication


        private string _product = "";

        public int ChargeId { get { return _chargeId; } set { _chargeId = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public int LoanTypeId { get { return _loanTypeId; } set { _loanTypeId = value; } }
        public int ChargeGLAccountId { get { return _chargeGLAccountId; } set { _chargeGLAccountId = value; } }
        public int PeriodChange { get { return _periodChange; } set { _periodChange = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public bool RateBased { get { return _rateBased; } set { _rateBased = value; } }
        public bool HasLimit { get { return _hasLimit; } set { _hasLimit = value; } }
        public double LowerLimit { get { return _lowerLimit; } set { _lowerLimit = value; } }
        public double UpperLimit { get { return _upperLimit; } set { _upperLimit = value; } }
        public bool IsFormula { get { return _isFormula; } set { _isFormula = value; } }
        public string Formula { get { return _formula; } set { _formula = value; } }
        public bool IsTopUpCharge { get { return _isTopUpCharge; } set { _isTopUpCharge = value; } }
        public bool IsTieredBased { get { return _isTieredBased; } set { _isTieredBased = value; } }
        public bool CalculationIncludesBothInterestAndPrincipal { get { return _calculationIncludesBothInterestAndPrincipal; } set { _calculationIncludesBothInterestAndPrincipal = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string ProductName { get { return _productName; } set { _productName = value; } }
        public string AccounttName { get { return _accountName ; } set { _accountName  = value; } }
        public string LoanTypeName { get { return _loantypeName; } set { _loantypeName = value; } }

        ChartOfAccount oChartOfAccount = new ChartOfAccount();
        Product oProduct = new Product();
        LoanType oLoanType = new LoanType();


        string err = "";
        public ArrayList GetOtherCharges()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllOtherCharges");
            if(err=="")
            {
                while(rd.Read())
                {
                    OtherCharge obj = new Classes.OtherCharge();
                    if (!String.IsNullOrEmpty(rd["ChargeId"].ToString())) obj.ChargeId = int.Parse(rd["ChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeGLAccountId"].ToString())) obj.ChargeGLAccountId = int.Parse(rd["ChargeGLAccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PeriodChange"].ToString())) obj.PeriodChange = int.Parse(rd["PeriodChange"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["RateBased"].ToString())) obj.RateBased = bool.Parse(rd["RateBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasLimit"].ToString())) obj.HasLimit = bool.Parse(rd["HasLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsFormula"].ToString())) obj.IsFormula = bool.Parse(rd["IsFormula"].ToString());
                    if (!String.IsNullOrEmpty(rd["Formula"].ToString())) obj.Formula = rd["Formula"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsTopUpCharge"].ToString())) obj.IsTopUpCharge = bool.Parse(rd["IsTopUpCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTieredBased"].ToString())) obj.IsTieredBased = bool.Parse(rd["IsTieredBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["CalculationIncludesBothInterestAndPrincipal"].ToString())) obj.CalculationIncludesBothInterestAndPrincipal = bool.Parse(rd["CalculationIncludesBothInterestAndPrincipal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                   if(obj.ProductId >0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                            obj.ProductName = myProduct.Description;
                    }
                    if (obj.ChargeGLAccountId > 0)
                    {
                        ChartOfAccount  myChartOfAccount = oChartOfAccount .GetChartOfAccount (obj.ChargeGLAccountId);
                        if (myChartOfAccount != null)
                            obj.AccounttName  = myChartOfAccount.AccountName ;
                    }
                    if(obj.LoanTypeId >0)
                    {
                        LoanType myLoanType = oLoanType.GetLoanType(obj.LoanTypeId);
                        if(myLoanType !=null)
                        {
                            obj.LoanTypeName = myLoanType.LoanTypeName;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }

        public OtherCharge  GetOtherCharge(int OtherChargeId)
        {
            OtherCharge obj = null;
           Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getOtherCharge", "@ChargeId", OtherChargeId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.OtherCharge();
                    if (!String.IsNullOrEmpty(rd["ChargeId"].ToString())) obj.ChargeId = int.Parse(rd["ChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeGLAccountId"].ToString())) obj.ChargeGLAccountId = int.Parse(rd["ChargeGLAccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PeriodChange"].ToString())) obj.PeriodChange = int.Parse(rd["PeriodChange"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["RateBased"].ToString())) obj.RateBased = bool.Parse(rd["RateBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["HasLimit"].ToString())) obj.HasLimit = bool.Parse(rd["HasLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsFormula"].ToString())) obj.IsFormula = bool.Parse(rd["IsFormula"].ToString());
                    if (!String.IsNullOrEmpty(rd["Formula"].ToString())) obj.Formula = rd["Formula"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsTopUpCharge"].ToString())) obj.IsTopUpCharge = bool.Parse(rd["IsTopUpCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTieredBased"].ToString())) obj.IsTieredBased = bool.Parse(rd["IsTieredBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["CalculationIncludesBothInterestAndPrincipal"].ToString())) obj.CalculationIncludesBothInterestAndPrincipal = bool.Parse(rd["CalculationIncludesBothInterestAndPrincipal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                            obj.ProductName = myProduct.Description;
                    }
                    if (obj.ChargeGLAccountId > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.ChargeGLAccountId);
                        if (myChartOfAccount != null)
                            obj.AccounttName = myChartOfAccount.AccountName;
                    }

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditCharge(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditOtherCharge",
                "@ChargeId", this.ChargeId,
                "@ProductId", this.ProductId,
                "@LoanTypeId", this.LoanTypeId,
                "@ChargeGLAccountId", this.ChargeGLAccountId,
                "@PeriodChange", this.PeriodChange,
                "@Amount", this.Amount,
                 "@RateBased", this.RateBased,
                "@HasLimit", this.HasLimit,
                "@LowerLimit", this.LowerLimit,
                 "@UpperLimit", this.UpperLimit,
                "@IsFormula", this.IsFormula,
                "@Formula", this.Formula,
                "@IsTopUpCharge", this.IsTopUpCharge,
                "@IsTieredBased", this.IsTieredBased,
                "@CalculationIncludesBothInterestAndPrincipal", this.CalculationIncludesBothInterestAndPrincipal,
                "@MachineName", "USER-PC",
                "@IsActive", this.IsActive,
                "@CreatedBy", "Admin",
                "@delete", delete);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());

                }
                try { rd.Close(); }
                catch {; }
            }
            error = err;
            return id;
            
        }
    }
}
