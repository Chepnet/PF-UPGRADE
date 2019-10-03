using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class FixedDepositPayment
    {

        private int _fixedDepositPaymentId = 0;
        private int _fixedDepositId = 0;
        private int _memberId = 0;
        private int _shareTypeId = 0;
        private DateTime _bookingDate = DateTime.Today;
        private double _amount = 0;
        private int _noOfDays = 0;
        private double _interestRate = 0;
        private int _actionOnClosure = 0;
        private DateTime _maturityDate = DateTime.Today;
        private int _maturityAC = 0;
        private double _withHoldingTaxRate = 0;
        private int _branchId = 0;
        private int _dimensionSetId = 0;
        private string _remarks = "";
        private bool _matureAtEveryEndOfMonth = false;
        private DateTime _transactionDate = DateTime.Today;
        private DateTime _valueDate = DateTime.Today;
        private int _paymodeId = 0;
        private string _documentNo = "";
        private int _bankId = 0;
        private string _description = "";
        private string _comment = "";
        private double _amountPaid = 0;
        private bool _isActive = false;

        private string _bankName = "";
        private string _modeofPayment = "";
        private string _productname = "";

        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private double _fCAmount = 0;

        private int _aCTransactionId = 0;
        private int _memberShareId = 0;
       
        private int _serialId = 0;
        
        private int _sourceACId = 0;
       
        private bool _isReversal = false;
        private bool _isReversed = false;
        private int _reversalId = 0;
        private bool _isFeeTransaction = false;

     





        public int FixedDepositPaymentId { get { return _fixedDepositPaymentId; } set { _fixedDepositPaymentId = value; } }
        public int FixedDepositId { get { return _fixedDepositId; } set { _fixedDepositId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int ShareTypeId { get { return _shareTypeId; } set { _shareTypeId = value; } }
        public DateTime BookingDate { get { return _bookingDate; } set { _bookingDate = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public int NoOfDays { get { return _noOfDays; } set { _noOfDays = value; } }
        public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        public int ActionOnClosure { get { return _actionOnClosure; } set { _actionOnClosure = value; } }
        public DateTime MaturityDate { get { return _maturityDate; } set { _maturityDate = value; } }
        public int MaturityAC { get { return _maturityAC; } set { _maturityAC = value; } }
        public double WithHoldingTaxRate { get { return _withHoldingTaxRate; } set { _withHoldingTaxRate = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public int DimensionSetId { get { return _dimensionSetId; } set { _dimensionSetId = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public bool MatureAtEveryEndOfMonth { get { return _matureAtEveryEndOfMonth; } set { _matureAtEveryEndOfMonth = value; } }
        public DateTime TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        public DateTime ValueDate { get { return _valueDate; } set { _valueDate = value; } }
        public int PaymodeId { get { return _paymodeId; } set { _paymodeId = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
        public int BankId { get { return _bankId; } set { _bankId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Comment { get { return _comment; } set { _comment = value; } }
        public double AmountPaid { get { return _amountPaid; } set { _amountPaid = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string ModeOfPayment { get { return _modeofPayment; } set { _modeofPayment = value; } }
        public string BankName { get { return _bankName; } set { _bankName = value; } }
        public string ProductName { get { return _productname; } set { _productname = value; } }

        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }

        public int ACTransactionId { get { return _aCTransactionId; } set { _aCTransactionId = value; } }
        public int MemberShareId { get { return _memberShareId; } set { _memberShareId = value; } }
     
        public int SerialId { get { return _serialId; } set { _serialId = value; } }
      
        public int SourceACId { get { return _sourceACId; } set { _sourceACId = value; } }
             public bool IsReversal { get { return _isReversal; } set { _isReversal = value; } }
        public bool IsReversed { get { return _isReversed; } set { _isReversed = value; } }
        public int ReversalId { get { return _reversalId; } set { _reversalId = value; } }
      
        public bool IsFeeTransaction { get { return _isFeeTransaction; } set { _isFeeTransaction = value; } }
      

        ModeOfPayment oModeOfPayment = new ModeOfPayment();
        Product oProduct = new Product();
        Bank oBank = new Bank();
        string err = "";
        public ArrayList GetFixedDepositPayments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllFixedDepositPayment");
             if (err=="")
                 {
                while(rd.Read () )
                {
                    FixedDepositPayment obj = new Classes.FixedDepositPayment();
                    if (!String.IsNullOrEmpty(rd["FixedDepositPaymentId"].ToString())) obj.FixedDepositPaymentId = int.Parse(rd["FixedDepositPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositId"].ToString())) obj.FixedDepositId = int.Parse(rd["FixedDepositId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BookingDate"].ToString())) obj.BookingDate = DateTime.Parse(rd["BookingDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["NoOfDays"].ToString())) obj.NoOfDays = int.Parse(rd["NoOfDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                   if (!String.IsNullOrEmpty(rd["ActionOnClosure"].ToString())) obj.ActionOnClosure = int.Parse(rd["ActionOnClosure"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityDate"].ToString())) obj.MaturityDate = DateTime.Parse(rd["MaturityDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityAC"].ToString())) obj.MaturityAC = int.Parse(rd["MaturityAC"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTaxRate"].ToString())) obj.WithHoldingTaxRate = double.Parse(rd["WithHoldingTaxRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionSetId"].ToString())) obj.DimensionSetId = int.Parse(rd["DimensionSetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["MatureAtEveryEndOfMonth"].ToString())) obj.MatureAtEveryEndOfMonth = bool.Parse(rd["MatureAtEveryEndOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymodeId"].ToString())) obj.PaymodeId = int.Parse(rd["PaymodeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["Comment"].ToString())) obj.Comment = rd["Comment"].ToString();
                    if (!String.IsNullOrEmpty(rd["AmountPaid"].ToString())) obj.AmountPaid = double.Parse(rd["AmountPaid"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.PaymodeId >0)
                    {
                        ModeOfPayment myModeOfPayment = oModeOfPayment.GetModeOfPayment(obj.PaymodeId);
                        if(myModeOfPayment !=null)
                        {
                            obj.ModeOfPayment = myModeOfPayment.Description;
                        }
                    }
                    if(obj.MaturityAC >0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.MaturityAC);
                        if(myProduct !=null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
                    }
                    if(obj.BankId >0)
                    {
                        Bank myBank = oBank.GetBank(obj.BankId);
                        if(myBank !=null)
                        {
                            obj.BankName = myBank.BankName;
                        }
                    }
                    myList.Add(obj);
                }
               try { rd.Close(); }
                catch {; }

            }
            return myList;
        }

        public FixedDepositPayment  GetFixedDepositPayment(int FixedDepositPaymentId)
        {
            FixedDepositPayment obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getFixedDepositPayment", "@FixedDepositPaymentId", FixedDepositPaymentId );
            if (err == "")
            {
                if (rd.Read())
                {
                   obj  = new Classes.FixedDepositPayment();
                    if (!String.IsNullOrEmpty(rd["FixedDepositPaymentId"].ToString())) obj.FixedDepositPaymentId = int.Parse(rd["FixedDepositPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FixedDepositId"].ToString())) obj.FixedDepositId = int.Parse(rd["FixedDepositId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BookingDate"].ToString())) obj.BookingDate = DateTime.Parse(rd["BookingDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["NoOfDays"].ToString())) obj.NoOfDays = int.Parse(rd["NoOfDays"].ToString());
                    if (!String.IsNullOrEmpty(rd["ActionOnClosure"].ToString())) obj.ActionOnClosure = int.Parse(rd["ActionOnClosure"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityDate"].ToString())) obj.MaturityDate = DateTime.Parse(rd["MaturityDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaturityAC"].ToString())) obj.MaturityAC = int.Parse(rd["MaturityAC"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithHoldingTaxRate"].ToString())) obj.WithHoldingTaxRate = double.Parse(rd["WithHoldingTaxRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionSetId"].ToString())) obj.DimensionSetId = int.Parse(rd["DimensionSetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["MatureAtEveryEndOfMonth"].ToString())) obj.MatureAtEveryEndOfMonth = bool.Parse(rd["MatureAtEveryEndOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaymodeId"].ToString())) obj.PaymodeId = int.Parse(rd["PaymodeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["Comment"].ToString())) obj.Comment = rd["Comment"].ToString();
                    if (!String.IsNullOrEmpty(rd["AmountPaid"].ToString())) obj.AmountPaid = double.Parse(rd["AmountPaid"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.PaymodeId > 0)
                    {
                        ModeOfPayment myModeOfPayment = oModeOfPayment.GetModeOfPayment(obj.PaymodeId);
                        if (myModeOfPayment != null)
                        {
                            obj.ModeOfPayment = myModeOfPayment.Description;
                        }
                    }
                    if (obj.MaturityAC > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.MaturityAC);
                        if (myProduct != null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
                    }
                    if (obj.BankId > 0)
                    {
                        Bank myBank = oBank.GetBank(obj.BankId);
                        if (myBank != null)
                        {
                            obj.BankName = myBank.BankName;
                        }
                    }
                }
                try { rd.Close(); }
                catch {; }

            }
            return obj;
        }
        public int AddEditFixedDepositPayment(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditFixedDepositPayment", "@FixedDepositPaymentId", this.FixedDepositPaymentId,
                            "@FixedDepositId", this.FixedDepositId,
                            "@MemberId", this.MemberId,
                            "@ShareTypeId", this.ShareTypeId,
                            "@BookingDate", this.BookingDate.ToString("yyyyMMdd"),
                            "@Amount", this.Amount,
                            "@NoOfDays", this.NoOfDays,
                            "@InterestRate", this.InterestRate,
                            "@CreatedBy", "Admin",
                            "@ActionOnClosure", this.ActionOnClosure,
                            "@MaturityDate", this.MaturityDate.ToString("yyyyMMdd"),
                            "@MaturityAC", this.MaturityAC,
                            "@WithHoldingTaxRate", this.WithHoldingTaxRate,
                            "@BranchId", this.BranchId,
                            "@DimensionSetId", this.DimensionSetId,
                            "@Remarks", this.Remarks,
                            "@MatureAtEveryEndOfMonth", this.MatureAtEveryEndOfMonth,
                            "@TransactionDate", this.TransactionDate.ToString("yyyyMMdd"),
                            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
                            "@PaymodeId", this.PaymodeId,
                            "@DocumentNo", this.DocumentNo,
                            "@BankId", this.BankId,
                            "@Description", this.Description,
                            "@Comment", this.Comment,
                            "@AmountPaid", this.AmountPaid,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ForeignCurrencyId", this.ForeignCurrencyId,
                            "@ExchangeRate", this.ExchangeRate,
                            "@FCAmount", this.FCAmount,
                            "@IsActive", this.IsActive,
                            "@MachineName", "USER-PC",
                             "@delete",delete);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            error = err;
            return id;
        }
        public int transaferFixedDepositPayment(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_transferFixedDepositPayment", "@FixedDepositPaymentId", this.FixedDepositPaymentId,
                            "@FixedDepositId", this.FixedDepositId,
                            "@MemberId", this.MemberId,
                            "@ShareTypeId", this.ShareTypeId,
                            "@BookingDate", this.BookingDate.ToString("yyyyMMdd"),
                            "@Amount", this.Amount,
                            "@NoOfDays", this.NoOfDays,
                            "@InterestRate", this.InterestRate,
                            "@CreatedBy", "Admin",
                            "@ActionOnClosure", this.ActionOnClosure,
                            "@MaturityDate", this.MaturityDate.ToString("yyyyMMdd"),
                            "@MaturityAC", this.MaturityAC,
                            "@WithHoldingTaxRate", this.WithHoldingTaxRate,
                            "@BranchId", this.BranchId,
                            "@DimensionSetId", this.DimensionSetId,
                            "@Remarks", this.Remarks,
                            "@MatureAtEveryEndOfMonth", this.MatureAtEveryEndOfMonth,
                            "@TransactionDate", this.TransactionDate.ToString("yyyyMMdd"),
                            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
                            "@PaymodeId", this.PaymodeId,
                            "@DocumentNo", this.DocumentNo,
                            "@BankId", this.BankId,
                            "@Description", this.Description,
                            "@Comment", this.Comment,
                            "@AmountPaid", this.AmountPaid,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ForeignCurrencyId", this.ForeignCurrencyId,
                            "@ExchangeRate", this.ExchangeRate,
                            "@FCAmount", this.FCAmount,
                            "@IsActive", this.IsActive,
                            "@MachineName", "USER-PC",
                            "@ACTransactionId", this.ACTransactionId,
                            "@MemberShareId", this.MemberShareId,
                            "@SerialId", this.SerialId,
                            "@SourceACId", this.SourceACId,
                            "@IsReversal", "0",
                            "@IsReversed", "0",
                            "@ReversalId", "0",
                             "@IsFeeTransaction", this.IsFeeTransaction,
                             "@delete", delete);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            error = err;
            return id;
        }

    }
}
