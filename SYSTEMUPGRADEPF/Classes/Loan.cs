using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Loan
    {
        private int _loanId = 0;
        private int _loanApplicationId = 0;
        private int _memberId = 0;
        private int _loanTypeId = 0;
        private string _loanCode = "";
        private string _manualRefNo = "";
        private DateTime _applicationDate = DateTime.Today;
        private DateTime _loanEffectDate = DateTime.Today;
        private int _loanPurposeId = 0;
        private int _branchId = 0;
        private int _creditOfficerId = 0;
        private int _donorId = 0;
        private int _repaymentPeriod = 0;
        private double _loanAmount = 0;
        private double _interestRate = 0;
        private int _loanStatusId = 0;
        private double _loanRepaymentAmount = 0;
        private bool _isActive = false;
        private int _transactionId = 0;
        private int _serialId = 0;
        //private int _loanId = 0;
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

        private string _memberName = "";
        private string _Loanpurpose = "";
        private string _loantype = "";

        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _fCAmount = 0;
        private double _exchangeRate = 0;

        private int _aCTransactionId = 0;
        private int _memberShareId = 0;
       
        private int _sourceACId = 0;
       
        private int _reversalId = 0;
        private int _dimensionsetId = 0;
        private bool _isFeeTransaction = false;

        private int _interestId = 0;
        private DateTime _transDate = DateTime.Today;
        private double _interestAmount = 0;
       private double _loanBalance = 0;
        private DateTime _nextDueDate = DateTime.Today;


        public int InterestId { get { return _interestId; } set { _interestId = value; } }
       
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public DateTime NextDueDate { get { return _nextDueDate; } set { _nextDueDate = value; } }
        public double InterestAmount { get { return _interestAmount; } set { _interestAmount = value; } }
       
        public double LoanBalance { get { return _loanBalance; } set { _loanBalance = value; } }


        public int LoanId { get { return _loanId; } set { _loanId = value; } }
        public int LoanApplicationId { get { return _loanApplicationId; } set { _loanApplicationId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int LoanTypeId { get { return _loanTypeId; } set { _loanTypeId = value; } }
        public string LoanCode { get { return _loanCode; } set { _loanCode = value; } }
        public string ManualRefNo { get { return _manualRefNo; } set { _manualRefNo = value; } }
        public DateTime ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        public DateTime LoanEffectDate { get { return _loanEffectDate; } set { _loanEffectDate = value; } }
        public int LoanPurposeId { get { return _loanPurposeId; } set { _loanPurposeId = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public int CreditOfficerId { get { return _creditOfficerId; } set { _creditOfficerId = value; } }
        public int DonorId { get { return _donorId; } set { _donorId = value; } }
        public int RepaymentPeriod { get { return _repaymentPeriod; } set { _repaymentPeriod = value; } }
        public double LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        public int LoanStatusId { get { return _loanStatusId; } set { _loanStatusId = value; } }
        public double LoanRepaymentAmount { get { return _loanRepaymentAmount; } set { _loanRepaymentAmount = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }



        public int TransactionId { get { return _transactionId; } set { _transactionId = value; } }
        public int SerialId { get { return _serialId; } set { _serialId = value; } }
        //public int LoanId { get { return _loanId; } set { _loanId = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public DateTime TransactionDate { get { return _transactionDate; } set { _transactionDate = value; } }
        public DateTime ValueDate { get { return _valueDate; } set { _valueDate = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int TransactionType { get { return _transactionType; } set { _transactionType = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
        public int ModeOfPaymentId { get { return _modeOfPaymentId; } set { _modeOfPaymentId = value; } }
        //public double Principal { get { return _loanAmount ; } set { _loanAmount  = value; } }
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
        public double CurrentPrincipalBalance { get { return _principalBalance; } set { _principalBalance = value; } }
        public double InterestBalanceValue { get { return _interestBalance; } set { _interestBalance = value; } }
        public double PenaltyBalance { get { return _penaltyBalance; } set { _penaltyBalance = value; } }

        public string MemberName { get { return _memberName ; } set { _memberName = value; } }
        public string LoanTypeDescription { get { return _loantype; } set { _loantype = value; } }
        public string LoanPurposeDescription { get { return _Loanpurpose ; } set { _Loanpurpose  = value; } }

        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }

        public int ACTransactionId { get { return _aCTransactionId; } set { _aCTransactionId = value; } }
        public int MemberShareId { get { return _memberShareId; } set { _memberShareId = value; } }
              
        public int ReversalId { get { return _reversalId; } set { _reversalId = value; } }
        public int DimensionsetId { get { return _dimensionsetId; } set { _dimensionsetId = value; } }
        public bool IsFeeTransaction { get { return _isFeeTransaction; } set { _isFeeTransaction = value; } }


        Member oMember = new Member();
        LoanType oLoanType = new LoanType();
        LoanPurpose oLoanPurpose = new LoanPurpose();
        RepaymentPeriod oRepaymentPeriod = new RepaymentPeriod();


        public double PrincipalBalance
        {

            get { return this.getPrincipalBalance(); }
        }
        public double InterestBalance
        {

            get { return this.getInterestBalance(); }
        }
        
        

        public string err = "";
        public ArrayList GetLoans()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoans");
            if(err=="")
            {
                while (rd.Read())
                {
                    Loan obj = new Classes.Loan();
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["NextDueDate"].ToString())) obj.NextDueDate  = DateTime.Parse(rd["NextDueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double .Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                    //if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());




                    //if (!String.IsNullOrEmpty(rd["TransactionId"].ToString())) obj.TransactionId = int.Parse(rd["TransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    ////if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    //if (!String.IsNullOrEmpty(rd["TransactionType"].ToString())) obj.TransactionType = int.Parse(rd["TransactionType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    //if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.LoanAmount  = double.Parse(rd["Principal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Penalty"].ToString())) obj.Penalty = double.Parse(rd["Penalty"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PaidByName"].ToString())) obj.PaidByName = rd["PaidByName"].ToString();
                    //if (!String.IsNullOrEmpty(rd["DebitGL"].ToString())) obj.DebitGL = int.Parse(rd["DebitGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["CreditGL"].ToString())) obj.CreditGL = int.Parse(rd["CreditGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["RunningBalance"].ToString())) obj.RunningBalance = double.Parse(rd["RunningBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversedByTransactionId"].ToString())) obj.ReversedByTransactionId = int.Parse(rd["ReversedByTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversingTransactionId"].ToString())) obj.ReversingTransactionId = int.Parse(rd["ReversingTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceType"].ToString())) obj.SourceType = int.Parse(rd["SourceType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceId"].ToString())) obj.SourceId = int.Parse(rd["SourceId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.CurrentPrincipalBalance  = double.Parse(rd["PrincipalBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PenaltyBalance"].ToString())) obj.PenaltyBalance = double.Parse(rd["PenaltyBalance"].ToString());


                    if (obj.MemberId >0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                       if(myMember !=null)
                        {
                            obj.MemberName = myMember.MemberName;
                        }
                    }
                    if(obj.LoanTypeId >0)
                    {
                        LoanType myLoanType = oLoanType.GetLoanType(obj.LoanTypeId);
                        if(myLoanType !=null)
                        {
                            obj.LoanTypeDescription = myLoanType.LoanTypeName;
                        }
                    }
                    if(obj.LoanPurposeId >0)
                    {
                        LoanPurpose myLoanPurpose = oLoanPurpose.GetLoanPurpose(obj.LoanPurposeId);
                        if(myLoanPurpose !=null)
                        {
                            obj.LoanPurposeDescription = myLoanPurpose.Description;
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
        public ArrayList GetActiveLoans()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllActiveLoans");
            if (err == "")
            {
                while (rd.Read())
                {
                    Loan obj = new Classes.Loan();
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                   //if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                   // if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                   // if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                   // if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                   // if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                   // //if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                   // //if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                   // //if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                   // //if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    //if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());




                    //if (!String.IsNullOrEmpty(rd["TransactionId"].ToString())) obj.TransactionId = int.Parse(rd["TransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    ////if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    //if (!String.IsNullOrEmpty(rd["TransactionType"].ToString())) obj.TransactionType = int.Parse(rd["TransactionType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    //if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.LoanAmount  = double.Parse(rd["Principal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Penalty"].ToString())) obj.Penalty = double.Parse(rd["Penalty"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PaidByName"].ToString())) obj.PaidByName = rd["PaidByName"].ToString();
                    //if (!String.IsNullOrEmpty(rd["DebitGL"].ToString())) obj.DebitGL = int.Parse(rd["DebitGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["CreditGL"].ToString())) obj.CreditGL = int.Parse(rd["CreditGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["RunningBalance"].ToString())) obj.RunningBalance = double.Parse(rd["RunningBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversedByTransactionId"].ToString())) obj.ReversedByTransactionId = int.Parse(rd["ReversedByTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversingTransactionId"].ToString())) obj.ReversingTransactionId = int.Parse(rd["ReversingTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceType"].ToString())) obj.SourceType = int.Parse(rd["SourceType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceId"].ToString())) obj.SourceId = int.Parse(rd["SourceId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.CurrentPrincipalBalance  = double.Parse(rd["PrincipalBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PenaltyBalance"].ToString())) obj.PenaltyBalance = double.Parse(rd["PenaltyBalance"].ToString());


                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                        {
                            obj.MemberName = myMember.MemberName;
                        }
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoanType = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoanType != null)
                        {
                            obj.LoanTypeDescription = myLoanType.LoanTypeName;
                        }
                    }
                    if (obj.LoanPurposeId > 0)
                    {
                        LoanPurpose myLoanPurpose = oLoanPurpose.GetLoanPurpose(obj.LoanPurposeId);
                        if (myLoanPurpose != null)
                        {
                            obj.LoanPurposeDescription = myLoanPurpose.Description;
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


        public Loan GetLoan(int LoanId)
        {
            Loan obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoan", "@LoanId", LoanId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.Loan();
                    if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["NextDueDate"].ToString())) obj.NextDueDate = DateTime.Parse(rd["NextDueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                    //if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());


                    //if (!String.IsNullOrEmpty(rd["TransactionId"].ToString())) obj.TransactionId = int.Parse(rd["TransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["TransactionDate"].ToString())) obj.TransactionDate = DateTime.Parse(rd["TransactionDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    //if (!String.IsNullOrEmpty(rd["TransactionType"].ToString())) obj.TransactionType = int.Parse(rd["TransactionType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    //if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Principal"].ToString())) obj.LoanAmount  = double.Parse(rd["Principal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Interest"].ToString())) obj.Interest = double.Parse(rd["Interest"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Penalty"].ToString())) obj.Penalty = double.Parse(rd["Penalty"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PaidByName"].ToString())) obj.PaidByName = rd["PaidByName"].ToString();
                    //if (!String.IsNullOrEmpty(rd["DebitGL"].ToString())) obj.DebitGL = int.Parse(rd["DebitGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["CreditGL"].ToString())) obj.CreditGL = int.Parse(rd["CreditGL"].ToString());
                    //if (!String.IsNullOrEmpty(rd["RunningBalance"].ToString())) obj.RunningBalance = double.Parse(rd["RunningBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    //if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversedByTransactionId"].ToString())) obj.ReversedByTransactionId = int.Parse(rd["ReversedByTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["ReversingTransactionId"].ToString())) obj.ReversingTransactionId = int.Parse(rd["ReversingTransactionId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceType"].ToString())) obj.SourceType = int.Parse(rd["SourceType"].ToString());
                    //if (!String.IsNullOrEmpty(rd["SourceId"].ToString())) obj.SourceId = int.Parse(rd["SourceId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["Arrears"].ToString())) obj.Arrears = double.Parse(rd["Arrears"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PrincipalBalance"].ToString())) obj.CurrentPrincipalBalance  = double.Parse(rd["PrincipalBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["InterestBalance"].ToString())) obj.InterestBalance = double.Parse(rd["InterestBalance"].ToString());
                    //if (!String.IsNullOrEmpty(rd["PenaltyBalance"].ToString())) obj.PenaltyBalance = double.Parse(rd["PenaltyBalance"].ToString());
                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                        {
                            obj.MemberName = myMember.MemberName;
                        }
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoanType = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoanType != null)
                        {
                            obj.LoanTypeDescription = myLoanType.LoanTypeName;
                        }
                    }
                    if (obj.LoanPurposeId > 0)
                    {
                        LoanPurpose myLoanPurpose = oLoanPurpose.GetLoanPurpose(obj.LoanPurposeId);
                        if (myLoanPurpose != null)
                        {
                            obj.LoanPurposeDescription = myLoanPurpose.Description;
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
        public int transferLoan(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "TransferLoan", "@LoanId", this.LoanId,
                            "@LoanApplicationId", this.LoanApplicationId,
                            "@MemberId", this.MemberId,
                            "@LoanTypeId", this.LoanTypeId,
                            "@LoanCode", this.LoanCode,
                            "@ManualRefNo", this.ManualRefNo,
                            "@ApplicationDate", this.ApplicationDate.ToString ("yyyyMMdd"),
                            "@LoanEffectDate", this.LoanEffectDate.ToString("yyyyMMdd"),
                            "@LoanPurposeId", this.LoanPurposeId,
                            "@BranchId", this.BranchId,
                            "@CreditOfficerId", this.CreditOfficerId,
                            "@DonorId", this.DonorId,
                            "@RepaymentPeriod", this.RepaymentPeriod,
                            "@LoanAmount", this.LoanAmount,
                            "@InterestRate", this.InterestRate,
                            "@LoanStatusId", this.LoanStatusId,
                            "@LoanRepaymentAmount", this.LoanRepaymentAmount,
                            "@NextDueDate",this.NextDueDate,
                            "@TransactionId", this.TransactionId,
                            "@SerialId", 1,
                            //"@LoanId", this.LoanId,
                            "@ProductId", this.ProductId,
                            "@TransactionDate", this.TransactionDate.ToString("yyyyMMdd"),
                            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
                            "@Description", this.Description,
                            "@TransactionType", 1,
                            "@DocumentNo", this.DocumentNo,
                            "@ModeOfPaymentId", this.ModeOfPaymentId,
                            "@Interest", 0,
                            "@Penalty", 0,
                            "@PaidByName", this.PaidByName,
                            "@DebitGL", this.DebitGL,
                            "@CreditGL", 0,
                            "@RunningBalance", 0,
                            "@IsReversed", this.IsReversed,
                            "@IsReversal", this.IsReversal,
                            "@ReversedByTransactionId", 1,
                            "@ReversingTransactionId", 2,
                             "@SourceId",this.SourceId ,
                            "@SourceType", "1",
                            "@Arrears", 0,
                            "@PrincipalBalance", this.CurrentPrincipalBalance    ,
                            "@InterestBalance", 0,
                            "@PenaltyBalance", 0,
                            "@Principal", this.LoanAmount ,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ForeignCurrencyId", this.ForeignCurrencyId,
                            "@FCAmount", this.FCAmount,
                            "@ExchangeRate", this.ExchangeRate,
                            "@IsActive", this.IsActive,
                            "@delete", delete,
                            "@MachineName", "USER-PC",
                            "@CreatedBy", "Admin",
                            "@MembershareId ", this.MemberShareId,
                            "@ReversalId ",0,
                           "@DimensionsetId", "0",
                           "@IsFeeTransaction","0",
                            "@ACTransactionId", this.ACTransactionId 

                            );
                if (err == "")
                {
                    if(rd.Read ())
                    {
                        id = int.Parse(rd["Id"].ToString());
                    }
                    try { rd.Close(); }
                    catch {; }
                }
                error = err;
                return id;
           
        }
        

        public double getBalance()
        {
            double Bal = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "sp_getACPrincipalBalance", "@LoanId", this.LoanId);
            if (err == "")
            {
                if (rd.Read())
                {
                    Bal = double.Parse(rd["PrincipalBalance"].ToString());
                }
                try { rd.Close(); }
                catch {; }

            }
            return Bal;
        }
        public double getInterestBalance()
        {
            double Bal = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_spInterestBalance", "@LoanId", this.LoanId);
            if (err == "")
            {
                if (rd.Read())
                {
                    Bal = double.Parse(rd["InterestBalance"].ToString());
                }
                try { rd.Close(); }
                catch {; }

            }
            return Bal;
        }
        public int AddEditLoan(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_AddEditLoan", "@LoanId", this.LoanId,
                            "@LoanApplicationId", this.LoanApplicationId,
                            "@MemberId", this.MemberId,
                            "@LoanTypeId", this.LoanTypeId,
                            "@LoanCode", this.LoanCode,
                            "@ManualRefNo", this.ManualRefNo,
                            "@ApplicationDate", this.ApplicationDate.ToString("yyyyMMdd"),
                            "@LoanEffectDate", this.LoanEffectDate.ToString("yyyyMMdd"),
                            "@LoanPurposeId", this.LoanPurposeId,
                            "@BranchId", this.BranchId,
                            "@CreditOfficerId", this.CreditOfficerId,
                            "@DonorId", this.DonorId,
                            "@RepaymentPeriod", this.RepaymentPeriod,
                            "@LoanAmount", this.LoanAmount,
                            "@InterestRate", this.InterestRate,
                            "@LoanStatusId", this.LoanStatusId,
                            "@LoanRepaymentAmount", this.LoanRepaymentAmount,
                            "@NextDueDate", this.NextDueDate,
                            "@TransactionId", this.TransactionId,
                            "@SerialId", 1,
                            //"@LoanId", this.LoanId,
                            "@ProductId", this.ProductId,
                            "@TransactionDate", this.TransactionDate.ToString("yyyyMMdd"),
                            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
                            "@Description", this.Description,
                            "@TransactionType", 1,
                            "@DocumentNo", this.DocumentNo,
                            "@ModeOfPaymentId", this.ModeOfPaymentId,
                            "@Interest", 0,
                            "@Penalty", 0,
                            "@PaidByName", this.PaidByName,
                            "@DebitGL", this.DebitGL,
                            "@CreditGL", 0,
                            "@RunningBalance", 0,
                            "@IsReversed", this.IsReversed,
                            "@IsReversal", this.IsReversal,
                            "@ReversedByTransactionId", 1,
                            "@ReversingTransactionId", 2,
                             "@SourceId", 0,
                            "@SourceType", "1",
                            "@Arrears", 0,
                            "@PrincipalBalance", this.CurrentPrincipalBalance,
                            "@InterestBalance", 0,
                            "@PenaltyBalance", 0,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ForeignCurrencyId", this.ForeignCurrencyId,
                            "@FCAmount", this.FCAmount,
                            "@ExchangeRate", this.ExchangeRate,
                            "@delete", delete,
                            "@MachineName", "USER-PC",
                             "@CreatedBy", "Admin" );
                            
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
            error = err;
            return id;
        }

        internal int AddEditLoan(bool v, int paymethod, int postingfrequency, double interestAmount, int dailyratespecification, object transDate, ref object error)
        {
            throw new NotImplementedException();
        }
    }
}
