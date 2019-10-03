using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class FixedDeposit
    {
        private int _fixedDepositId = 0;
        private int _memberId = 0;
        private int _ShareTypeId = 0;
        private DateTime _bookingDate = DateTime.Today;
        private double _amount = 0;
        private int _noOfDays = 0;
        private double _interestRate = 0;
        private DateTime _closeOn = DateTime.Today;
        private string _closedBy = "";
        private int _actionOnClosure = 0;
        private DateTime _maturityDate = DateTime.Today;
        private int _maturityAC = 0;
        private double _withHoldingTaxRate = 0;
        private int _branchId = 0;
        private int _dimensionSetId = 0;
        private string _remarks = "";
        private bool _matureAtEveryEndOfMonth = false;
        private bool _isActive = false;
        private string _membername = "";
        private string _shareTypename = "";
        private string _productname = "";

        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private double _fCAmount = 0;




        public int FixedDepositId { get { return _fixedDepositId; } set { _fixedDepositId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int ShareTypeId { get { return _ShareTypeId; } set { _ShareTypeId = value; } }
        public DateTime BookingDate { get { return _bookingDate; } set { _bookingDate = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public int NoOfDays { get { return _noOfDays; } set { _noOfDays = value; } }
        public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        public DateTime CloseOn { get { return _closeOn; } set { _closeOn = value; } }
        public string ClosedBy { get { return _closedBy; } set { _closedBy = value; } }
        public int ActionOnClosure { get { return _actionOnClosure; } set { _actionOnClosure = value; } }
        public DateTime MaturityDate { get { return _maturityDate; } set { _maturityDate = value; } }
        public int MaturityAC { get { return _maturityAC; } set { _maturityAC = value; } }
        public double WithHoldingTaxRate { get { return _withHoldingTaxRate; } set { _withHoldingTaxRate = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public int DimensionSetId { get { return _dimensionSetId; } set { _dimensionSetId = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public bool MatureAtEveryEndOfMonth { get { return _matureAtEveryEndOfMonth; } set { _matureAtEveryEndOfMonth = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }


        public string MemberName { get { return _membername ; } set { _membername = value; } }
        public string ShareTypeName { get { return _shareTypename; } set { _shareTypename = value; } }
        public string ProductName { get { return _productname; } set { _productname = value; } }

        Member oMember = new Member();
        ShareType oShareType = new ShareType ();
        Product  oproduct = new Product ();


        string err = "";
        public ArrayList GetFixedDeposits()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllFixedDeposits");
            if(err=="")
            {
                while(rd.Read())
                {
                    FixedDeposit obj = new Classes.FixedDeposit();
                    if (!String.IsNullOrEmpty(rd["FixedDepositId"].ToString())) obj.FixedDepositId = int.Parse(rd["FixedDepositId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BookingDate"].ToString())) obj.BookingDate = DateTime.Parse(rd["BookingDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["NoOfDays"].ToString())) obj.NoOfDays = int.Parse(rd["NoOfDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CloseOn"].ToString())) obj.CloseOn = DateTime.Parse(rd["CloseOn"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClosedBy"].ToString())) obj.ClosedBy = rd["ClosedBy"].ToString();
                    if (!String.IsNullOrEmpty(rd["ActionOnClosure"].ToString())) obj.ActionOnClosure = int.Parse(rd["ActionOnClosure"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityDate"].ToString())) obj.MaturityDate = DateTime.Parse(rd["MaturityDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityAC"].ToString())) obj.MaturityAC = int.Parse(rd["MaturityAC"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTaxRate"].ToString())) obj.WithHoldingTaxRate = double.Parse(rd["WithHoldingTaxRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionSetId"].ToString())) obj.DimensionSetId = int.Parse(rd["DimensionSetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["MatureAtEveryEndOfMonth"].ToString())) obj.MatureAtEveryEndOfMonth = bool.Parse(rd["MatureAtEveryEndOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.MemberId >0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if(myMember !=null)
                        {
                            obj.MemberName = myMember.MemberName;
                        }
                    }
                    if (obj.ShareTypeId  > 0)
                    {
                        ShareType   myShareType = oShareType  .GetShareType  (obj.ShareTypeId );
                        if (myShareType   != null)
                        {
                            obj.ShareTypeName   = myShareType  .Description  ;
                        }
                    }
                    if (obj.MaturityAC  > 0)
                    {
                       Product   myProduct =oproduct  .GetProduct  (obj.MaturityAC);
                        if (myProduct   != null)
                        {
                            obj.ProductName   = myProduct  .Description  ;
                        }
                    }
                    myList.Add(obj);
                

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
            return myList;
        }

        public FixedDeposit  GetFixedDeposit(int FixedDepositId)
        {
            FixedDeposit obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getFixedDeposit", "@FixedDepositId",FixedDepositId );
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.FixedDeposit();
                    if (!String.IsNullOrEmpty(rd["FixedDepositId"].ToString())) obj.FixedDepositId = int.Parse(rd["FixedDepositId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BookingDate"].ToString())) obj.BookingDate = DateTime.Parse(rd["BookingDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["NoOfDays"].ToString())) obj.NoOfDays = int.Parse(rd["NoOfDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["CloseOn"].ToString())) obj.CloseOn = DateTime.Parse(rd["CloseOn"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClosedBy"].ToString())) obj.ClosedBy = rd["ClosedBy"].ToString();
                    if (!String.IsNullOrEmpty(rd["ActionOnClosure"].ToString())) obj.ActionOnClosure = int.Parse(rd["ActionOnClosure"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityDate"].ToString())) obj.MaturityDate = DateTime.Parse(rd["MaturityDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityAC"].ToString())) obj.MaturityAC = int.Parse(rd["MaturityAC"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTaxRate"].ToString())) obj.WithHoldingTaxRate = double.Parse(rd["WithHoldingTaxRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionSetId"].ToString())) obj.DimensionSetId = int.Parse(rd["DimensionSetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["MatureAtEveryEndOfMonth"].ToString())) obj.MatureAtEveryEndOfMonth = bool.Parse(rd["MatureAtEveryEndOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                        {
                            obj.MemberName = myMember.MemberName;
                        }
                    }
                    if (obj.ShareTypeId > 0)
                    {
                        ShareType myShareType = oShareType.GetShareType(obj.ShareTypeId);
                        if (myShareType != null)
                        {
                            obj.ShareTypeName = myShareType.Description;
                        }
                    }
                    if (obj.MaturityAC > 0)
                    {
                        Product myProduct = oproduct.GetProduct(obj.MaturityAC);
                        if (myProduct != null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
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
        public int AddEditFixedDeposit(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditFixedDeposit", "@FixedDepositId", this.FixedDepositId,
                    "@MemberId", this.MemberId,
                    "@ShareTypeId", this.ShareTypeId,
                    "@BookingDate", this.BookingDate.ToString("yyyyMMdd"),
                    "@Amount", this.Amount,
                    "@NoOfDays", this.NoOfDays,
                    "@InterestRate", this.InterestRate,
                    "@CloseOn", DateTime.Now ,
                    "@ClosedBy", "Admin",
                    "@ActionOnClosure", this.ActionOnClosure,
                    "@MaturityDate", this.MaturityDate.ToString("yyyyMMdd"),
                    "@MaturityAC", this.MaturityAC,
                    "@WithHoldingTaxRate", this.WithHoldingTaxRate,
                    "@BranchId","1",
                    "@DimensionSetId", "1",
                    "@Remarks", this.Remarks,
                    "@MatureAtEveryEndOfMonth", this.MatureAtEveryEndOfMonth,
                    "@DefaultCurrencyId", this.DefaultCurrencyId,
                    "@ForeignCurrencyId", this.ForeignCurrencyId,
                    "@ExchangeRate", this.ExchangeRate,
                    "@FCAmount", this.FCAmount,
                    "@IsActive", this.IsActive,
                    "@CreatedBy", "Admin",
                    "@MachineName", "User-PC",
                    "@delete", delete);
            if(err=="")
            {
                if(rd.Read ())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            err = error;
            return id;
        }
        public int EditFixedDeposit(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_EditFixedDeposit", "@FixedDepositId", this.FixedDepositId);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            err = error;
            return id;
        }
    }
}
