using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SYSTEMUPGRADEPF.Classes
{
    class LoanTransaction
    {

        private int _transactionId = 0;
        private int _serialId = 0;
        private int _loanId = 0;
        private int _productId = 0;
        private DateTime _transactionDate = DateTime.Today;
        private DateTime _valueDate = DateTime.Today;
        private string _description = "";
        private int _transactionType = 0;
        private string _documentNo = "";
        private int _modeOfPaymentId = 0;
        private double _principal = 0;
        private double _interest = 0;
        private double _penalty = 0;
        private string _paidByName = "";
        private int _debitGL = 0;
        private int _creditGL = 0;
        private double _runningBalance = 0;
        private bool _isReversed = false;
        private bool _isReversal = false;
        private int _reversedByTransactionId = 0;
        private int _reversingTransactionId = 0;
        private int _sourceType = 0;
        private int _sourceId = 0;
        private double _arrears = 0;
       private double _principalBalance = 0;
        private double _interestBalance = 0;
        private double _penaltyBalance = 0;
        private double _loanAmount = 0;
        private int _memberShareId = 0;
        private bool _isfeeTransaction = false;


        private string _modeofpayment = "";
        private string _productname = "";
        private string _loanName = "";

        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _fCAmount = 0;
        private double _exchangeRate = 0;



        public int TransactionId { get { return _transactionId; } set { _transactionId = value; } }
        public int SerialId { get { return _serialId; } set { _serialId = value; } }
        public int LoanId { get { return _loanId; } set { _loanId = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public DateTime TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        public DateTime ValueDate { get { return _valueDate; } set { _valueDate = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int TransactionType { get { return _transactionType; } set { _transactionType = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
        public int ModeOfPaymentId { get { return _modeOfPaymentId; } set { _modeOfPaymentId = value; } }
        public double Principal { get { return _principal; } set { _principal = value; } }
        public double Interest { get { return _interest; } set { _interest = value; } }
        public double Penalty { get { return _penalty; } set { _penalty = value; } }
        public string PaidByName { get { return _paidByName; } set { _paidByName = value; } }
        public int DebitGL { get { return _debitGL; } set { _debitGL = value; } }
        public int CreditGL { get { return _creditGL; } set { _creditGL = value; } }
        public double RunningBalance { get { return _runningBalance; } set { _runningBalance = value; } }
        public bool IsReversed { get { return _isReversed; } set { _isReversed = value; } }
        public bool IsReversal { get { return _isReversal; } set { _isReversal = value; } }
        public int ReversedByTransactionId { get { return _reversedByTransactionId; } set { _reversedByTransactionId = value; } }
        public int ReversingTransactionId { get { return _reversingTransactionId; } set { _reversingTransactionId = value; } }
        public int SourceType { get { return _sourceType; } set { _sourceType = value; } }
        public int SourceId { get { return _sourceId; } set { _sourceId = value; } }
        public double Arrears { get { return _arrears; } set { _arrears = value; } }
        public double PrincipalBalanceValue { get { return _principalBalance; } set { _principalBalance = value; } }
        public double InterestBalance { get { return _interestBalance; } set { _interestBalance = value; } }
        public double PenaltyBalance { get { return _penaltyBalance; } set { _penaltyBalance = value; } }
        public double LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }



        public string ProductName { get { return _productname ; } set { _productname  = value; } }
        public string ModeOfPaymentDescription { get { return _modeofpayment ; } set { _modeofpayment  = value; } }
        public string LoanName { get { return _loanName ; } set { _loanName  = value; } }


        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }

        public int MemberShareId { get { return _memberShareId ; } set { _memberShareId  = value; } }
        public bool  IsFeeTransaction { get { return _isfeeTransaction ; } set { _isfeeTransaction = value; } }


        ModeOfPayment oModeOfPayment = new  ModeOfPayment();
        Product oProduct = new  Product();
        Loan oLoan = new  Loan();

        public double LoanPrincipalBalance
        {

            get { return this.getPrincipalBalance(); }
        }


        string err = "";
        public ArrayList GetLoanTransactions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanTransactions");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanTransaction  obj = new Classes.LoanTransaction ();
                    if (!String.IsNullOrEmpty(rd["TransactionId"].ToString())) obj.TransactionId = int.Parse(rd["TransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["TransactionType"].ToString())) obj.TransactionType = int.Parse(rd["TransactionType"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.Principal = double.Parse(rd["Principal"].ToString());
                    if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    if (!String.IsNullOrEmpty(rd["Penalty"].ToString())) obj.Penalty = double.Parse(rd["Penalty"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaidByName"].ToString())) obj.PaidByName = rd["PaidByName"].ToString();
                    if (!String.IsNullOrEmpty(rd["DebitGL"].ToString())) obj.DebitGL = int.Parse(rd["DebitGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditGL"].ToString())) obj.CreditGL = int.Parse(rd["CreditGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["RunningBalance"].ToString())) obj.RunningBalance = double.Parse(rd["RunningBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversedByTransactionId"].ToString())) obj.ReversedByTransactionId = int.Parse(rd["ReversedByTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversingTransactionId"].ToString())) obj.ReversingTransactionId = int.Parse(rd["ReversingTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceType"].ToString())) obj.SourceType = int.Parse(rd["SourceType"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceId"].ToString())) obj.SourceId = int.Parse(rd["SourceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.PrincipalBalanceValue  = double.Parse(rd["PrincipalBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyBalance"].ToString())) obj.PenaltyBalance = double.Parse(rd["PenaltyBalance"].ToString());

                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());


                    if (obj.ModeOfPaymentId >0)
                    {
                        ModeOfPayment myModeofPayment = oModeOfPayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if(myModeofPayment !=null)
                        {
                            obj.ModeOfPaymentDescription = myModeofPayment.Description; 
                        }
                    }
                    if(obj.ProductId >0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if(myProduct !=null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
                    }
                    if(obj.LoanId >0)
                    {
                        Loan myLoan = oLoan.GetLoan(obj.LoanId);
                        if(myLoan !=null)
                        {
                            obj.LoanName = myLoan.LoanTypeDescription ;
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
        public ArrayList GetLoanInterestTransactions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanTransactions");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanTransaction obj = new Classes.LoanTransaction();
                  
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.Principal = double.Parse(rd["Principal"].ToString());
                    if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.PrincipalBalanceValue = double.Parse(rd["PrincipalBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                   


                    if (obj.ModeOfPaymentId > 0)
                    {
                        ModeOfPayment myModeofPayment = oModeOfPayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if (myModeofPayment != null)
                        {
                            obj.ModeOfPaymentDescription = myModeofPayment.Description;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
                    }
                    if (obj.LoanId > 0)
                    {
                        Loan myLoan = oLoan.GetLoan(obj.LoanId);
                        if (myLoan != null)
                        {
                            obj.LoanName = myLoan.LoanTypeDescription;
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

        public LoanTransaction  GetLoanTransaction(int LoanTransactionId)
        {
            LoanTransaction obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoanTransaction", "@LoanTransactionId",LoanTransactionId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.LoanTransaction();
                    if (!String.IsNullOrEmpty(rd["TransactionId"].ToString())) obj.TransactionId = int.Parse(rd["TransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["TransactionType"].ToString())) obj.TransactionType = int.Parse(rd["TransactionType"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.Principal = double.Parse(rd["Principal"].ToString());
                    if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    if (!String.IsNullOrEmpty(rd["Penalty"].ToString())) obj.Penalty = double.Parse(rd["Penalty"].ToString());
                    if (!String.IsNullOrEmpty(rd["PaidByName"].ToString())) obj.PaidByName = rd["PaidByName"].ToString();
                    if (!String.IsNullOrEmpty(rd["DebitGL"].ToString())) obj.DebitGL = int.Parse(rd["DebitGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditGL"].ToString())) obj.CreditGL = int.Parse(rd["CreditGL"].ToString());
                    if (!String.IsNullOrEmpty(rd["RunningBalance"].ToString())) obj.RunningBalance = double.Parse(rd["RunningBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversedByTransactionId"].ToString())) obj.ReversedByTransactionId = int.Parse(rd["ReversedByTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversingTransactionId"].ToString())) obj.ReversingTransactionId = int.Parse(rd["ReversingTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceType"].ToString())) obj.SourceType = int.Parse(rd["SourceType"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceId"].ToString())) obj.SourceId = int.Parse(rd["SourceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.PrincipalBalanceValue = double.Parse(rd["PrincipalBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["PenaltyBalance"].ToString())) obj.PenaltyBalance = double.Parse(rd["PenaltyBalance"].ToString());

                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());


                    if (obj.ModeOfPaymentId > 0)
                    {
                        ModeOfPayment myModeofPayment = oModeOfPayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if (myModeofPayment != null)
                        {
                            obj.ModeOfPaymentDescription = myModeofPayment.Description;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductName = myProduct.Description;
                        }
                    }
                    if (obj.LoanId > 0)
                    {
                        Loan myLoan = oLoan.GetLoan(obj.LoanId);
                        if (myLoan != null)
                        {
                            obj.LoanName = myLoan.LoanTypeDescription;
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

        public int AddEditLoanTransaction(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            //DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanTransaction", "@LoanId", this.LoanId,

            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanInterestTransaction", "@LoanId", this.LoanId,
"@TransactionId", this.TransactionId,
"@SerialId", 1,
//"@LoanId", this.LoanId,
"@ProductId", this.ProductId,
"@TransactionDate", this.TransactionDate,
"@ValueDate", this.ValueDate,
"@Description", this.Description,
"@TransactionType", 2,
"@DocumentNo", this.DocumentNo,
"@ModeOfPaymentId", this.ModeOfPaymentId,
"@Principal", this.Principal,
"@Interest", this.Interest ,
"@Penalty", 0,
"@PaidByName", this.PaidByName,
"@DebitGL", this.DebitGL,
"@CreditGL", 0,
"@RunningBalance", 0,
"@IsReversed", this.IsReversed,
"@IsReversal", this.IsReversal,
"@ReversedByTransactionId", 1,
"@ReversingTransactionId", 2,
"@SourceType", "1",
"@SourceId", 1,
"@Arrears", this.PrincipalBalanceValue ,
"@PrincipalBalance", this.PrincipalBalanceValue    ,
"@InterestBalance", this.InterestBalance  ,
"@PenaltyBalance", 0,
"@DefaultCurrencyId", this.DefaultCurrencyId,
"@ForeignCurrencyId", this.ForeignCurrencyId,
"@FCAmount", this.FCAmount,
"@ExchangeRate", this.ExchangeRate,
"@delete", delete,
"@MachineName", "USER-PC",
"@CreatedBy", "Admin"

);
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
        public double getPrincipalBalance()
        {
            double Bal = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "sp_getLoanTransactionACBalance", "@TransactionId", this.TransactionId );
            if (err == "")
            {
                if (rd.Read())
                {
                    Bal = double.Parse(rd["LoanTransactionACBalance"].ToString());
                }
                try { rd.Close(); }
                catch {; }

            }
            return Bal;
        }
        public int transferLoanTransaction( bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_transferLoanTransaction", "@LoanId", this.LoanId,
                        "@TransactionId", this.TransactionId,
                        "@SerialId", 1,
                        "@ProductId", this.ProductId,
                        "@TransactionDate", this.TransactionDate.ToString("yyyyMMdd"),
                        "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
                        "@Description", this.Description,
                        "@TransactionType", 2,
                        "@DocumentNo", this.DocumentNo,
                        "@ModeOfPaymentId", this.ModeOfPaymentId,
                        "@Principal", this.Principal,
                        "@Interest", this.Interest ,
                        "@Penalty", 0,
                        "@PaidByName", this.PaidByName,
                        "@DebitGL", this.DebitGL,
                        "@CreditGL", 0,
                        "@RunningBalance", 0,
                        "@IsReversed", this.IsReversed,
                        "@IsReversal", this.IsReversal,
                        "@ReversedByTransactionId", 1,
                        "@ReversingTransactionId", 2,
                        "@SourceType", "1",
                        "@SourceId", this.SourceId ,
                        "@Arrears", 0,
                        "@PrincipalBalance", this.PrincipalBalanceValue,
                        "@InterestBalance", this.InterestBalance ,
                        "@PenaltyBalance", 0,
                        "@DefaultCurrencyId", this.DefaultCurrencyId,
                        "@ForeignCurrencyId", this.ForeignCurrencyId,
                        "@FCAmount", this.FCAmount,
                        "@ExchangeRate", this.ExchangeRate,
                        "@delete", delete,
                        "@MachineName", "USER-PC",
                        "@CreatedBy", "Admin",

                        "@MemberShareId", MemberShareId,
                        "@BranchId", "1",
                        "@ReversalId", "0",
                        "@DimensionsetId", "1",
                        "@IsFeeTransaction", "0"   ,
                        "@IsActive", "0");
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
