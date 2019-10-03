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
    class LoanApplicationCharge
    {

        private int _loanApplicationChargeId = 0;
        private int _loanApplicationId = 0;
        private int _chargeId = 0;
        private double _otherChargeValue = 0;
        private double _actualAmount = 0;
        private int _periodCharge = 0;
        private bool _isPercentage = false;
        private double _lowerLimit = 0;
        private double _upperLimit = 0;
        private bool _isTieredBased = false;
        private bool _isActive = false;
        private string _productName = "";


        public int LoanApplicationChargeId { get { return _loanApplicationChargeId; } set { _loanApplicationChargeId = value; } }
        public int LoanApplicationId { get { return _loanApplicationId; } set { _loanApplicationId = value; } }
        public int ChargeId { get { return _chargeId; } set { _chargeId = value; } }
        public double OtherChargeValue { get { return _otherChargeValue; } set { _otherChargeValue = value; } }
        public double Amount { get { return _actualAmount; } set { _actualAmount = value; } }
        public int PeriodChange { get { return _periodCharge; } set { _periodCharge = value; } }
        public bool RateBased { get { return _isPercentage; } set { _isPercentage = value; } }
        public double LowerLimit { get { return _lowerLimit; } set { _lowerLimit = value; } }
        public double UpperLimit { get { return _upperLimit; } set { _upperLimit = value; } }
        public bool IsTieredBased { get { return _isTieredBased; } set { _isTieredBased = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string ProductName { get { return _productName; } set { _productName = value; } }
        Product oproduct = new Product();

        string err = "";

        public ArrayList GetLoanApplicationCharges()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getAllLoanApplicationCharges");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanApplicationCharge obj = new Classes.LoanApplicationCharge();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationChargeId"].ToString())) obj.LoanApplicationChargeId = int.Parse(rd["LoanApplicationChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeId"].ToString())) obj.ChargeId = int.Parse(rd["ChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["OtherChargeValue"].ToString())) obj.OtherChargeValue = double.Parse(rd["OtherChargeValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ActualAmount"].ToString())) obj.Amount = double.Parse(rd["ActualAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["PeriodCharge"].ToString())) obj.PeriodChange = int.Parse(rd["PeriodCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPercentage"].ToString())) obj.RateBased = bool.Parse(rd["IsPercentage"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTieredBased"].ToString())) obj.IsTieredBased = bool.Parse(rd["IsTieredBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.ChargeId>0)
                    {
                        Product myProduct = oproduct.GetProduct(obj.ChargeId);
                        if (myProduct != null)
                            obj.ProductName = myProduct.Description ;  
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
        public LoanApplicationCharge GetLoanApplicationCharge(int LoanApplicationChargeId)
        {
            LoanApplicationCharge obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getLoanApplicationCharge", "@LoanApplicationChargeId", LoanApplicationChargeId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanApplicationCharge();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationChargeId"].ToString())) obj.LoanApplicationChargeId = int.Parse(rd["LoanApplicationChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeId"].ToString())) obj.ChargeId = int.Parse(rd["ChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["OtherChargeValue"].ToString())) obj.OtherChargeValue = double.Parse(rd["OtherChargeValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ActualAmount"].ToString())) obj.Amount = double.Parse(rd["ActualAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["PeriodCharge"].ToString())) obj.PeriodChange = int.Parse(rd["PeriodCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPercentage"].ToString())) obj.RateBased = bool.Parse(rd["IsPercentage"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTieredBased"].ToString())) obj.IsTieredBased = bool.Parse(rd["IsTieredBased"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.ChargeId > 0)
                    {
                        Product myProduct = oproduct.GetProduct(obj.ChargeId);
                        if (myProduct != null)
                            obj.ProductName = myProduct.Description;
                    }
                }
                try
                {
                    rd.Close();
                }
                catch
                {
                    ;
                }
            }

            return obj;
        }
        public int AddEditLoanAppCharge(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_AddEditLoanApplicationCharges",
            "@LoanApplicationChargeId", this.LoanApplicationChargeId,
"@LoanApplicationId", this.LoanApplicationId ,
"@ChargeId", this.ChargeId ,
"@OtherChargeValue", this.OtherChargeValue,
"@ActualAmount", this.Amount,
"@PeriodCharge", this.PeriodChange,
"@IsPercentage", this.RateBased,
"@LowerLimit", this.LowerLimit,
"@UpperLimit", this.UpperLimit,
"@IsTieredBased", this.IsTieredBased,
"@IsActive", this.IsActive,
            "@MachineName", "USER-PC",
            
            "@CreatedBy", "Admin",
            "@delete", delete);
           if(err=="")
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
