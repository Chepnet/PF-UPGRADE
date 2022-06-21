using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanApplication
    {
        private int _loanApplicationId = 0;
        private int _memberId = 0;
        private int _loanTypeId = 0;
        //private int _loanId = 0;
        private string _loanTypeName = "";
        private string _MemberName = "";
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

        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private double _fCAmount = 0;
        


        public int LoanApplicationId { get { return _loanApplicationId; } set { _loanApplicationId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int LoanTypeId { get { return _loanTypeId; } set { _loanTypeId = value; } }
        //public int LoanId { get { return _loanId; } set { _loanId = value; } }
        public string LoanTypeName { get { return _loanTypeName; } set { _loanTypeName = value; } }
        public string MemberName { get { return _MemberName; } set { _MemberName = value; } }
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

        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }

        LoanType oLoanType = new LoanType();
        Member oMember = new Member();

        string err = "";

        public ArrayList GetLoanApplications()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getAllLoanApplications");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanApplication obj = new Classes.LoanApplication();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoan = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoan != null)
                            obj.LoanTypeName = myLoan.LoanTypeName;
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
        public ArrayList GetUnDisbursedLoanApplications()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getUnProcessedLoanApplications");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanApplication obj = new Classes.LoanApplication();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());

                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoan = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoan != null)
                            obj.LoanTypeName = myLoan.LoanTypeName;
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

        public LoanApplication GetLoanApplication(int LoanApplicationId)
        {
            LoanApplication obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getLoanApplication", "@LoanApplicationId", LoanApplicationId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanApplication();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    //if (!String.IsNullOrEmpty(rd["LoanId"].ToString())) obj.LoanId = int.Parse(rd["LoanId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanCode"].ToString())) obj.LoanCode = rd["LoanCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ManualRefNo"].ToString())) obj.ManualRefNo = rd["ManualRefNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["ApplicationDate"].ToString())) obj.ApplicationDate = DateTime.Parse(rd["ApplicationDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanEffectDate"].ToString())) obj.LoanEffectDate = DateTime.Parse(rd["LoanEffectDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DonorId"].ToString())) obj.DonorId = int.Parse(rd["DonorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriod"].ToString())) obj.RepaymentPeriod = int.Parse(rd["RepaymentPeriod"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["InterestRate"].ToString())) obj.InterestRate = double.Parse(rd["InterestRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanStatusId"].ToString())) obj.LoanStatusId = int.Parse(rd["LoanStatusId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanRepaymentAmount"].ToString())) obj.LoanRepaymentAmount = double.Parse(rd["LoanRepaymentAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId  = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId  = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                   
                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoan = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoan != null)
                            obj.LoanTypeName = myLoan.LoanTypeName;
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

        public int AddEditLoanApp(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "Proc_AddEditLoanApplication",
                            "@LoanApplicationId", this.LoanApplicationId,
                            "@MemberId", this.MemberId,
                            "@LoanTypeId", this.LoanTypeId,
                            "@LoanCode", this.LoanCode,
                            "@ManualRefNo", this.ManualRefNo,
                            "@ApplicationDate", this.ApplicationDate.ToString("yyyyMMdd"),
                            "@LoanEffectDate", this.LoanEffectDate.ToString ("yyyyMMdd"),
                            "@LoanPurposeId", this.LoanPurposeId,
                            "@BranchId", 0,
                            "@CreditOfficerId", this.CreditOfficerId,
                            "@DonorId", 0,
                            "@RepaymentPeriod", this.RepaymentPeriod,
                            "@LoanAmount", this.LoanAmount,
                            "@InterestRate", this.InterestRate,
                            "@LoanStatusId", this.LoanStatusId,
                            "@LoanRepaymentAmount", this.LoanRepaymentAmount,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ForeignCurrencyId", this.ForeignCurrencyId,
                            "@ExchangeRate", this.ExchangeRate,
                            "@FCAmount", this.FCAmount,
                            "@IsActive", this.IsActive,
                            "@MachineName", "Naomi_PC",
                            "@CreatedBy", "Admin",
                            "@delete", delete);
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

        
    }
}

 
