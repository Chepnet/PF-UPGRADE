using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanGuarantor
    {

        private int _loanGuarantorId = 0;
        private int _loanApplicationId = 0;
        private int _memberShareId = 0;
        private string _guarantorName = "";
        private double _guaranteedAmount = 0;
        private double _loanAmount = 0;
        private bool _isActive = false;
        private double _loanApplicationAmount = 0;
        private double _totalshares = 0;
        private double _freeshares = 0;
        private string _memberName = "";
        private string _memberloanName = "";

        public int LoanGuarantorId { get { return _loanGuarantorId; } set { _loanGuarantorId = value; } }
        public int LoanApplicationId { get { return _loanApplicationId; } set { _loanApplicationId = value; } }
        public int MemberShareId { get { return _memberShareId; } set { _memberShareId = value; } }
        public string GuarantorName { get { return _guarantorName; } set { _guarantorName = value; } }
        public double GuaranteedAmount { get { return _guaranteedAmount; } set { _guaranteedAmount = value; } }
        public double LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }

        public double TotalShares { get { return _totalshares; } set { _totalshares = value; } }
        public double FreeShares { get { return _freeshares; } set { _freeshares = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string MemberName { get { return _memberName; } set { _memberName = value; } }

        public string MemberLoanName { get { return _memberloanName; } set { _memberloanName = value; } }

        public double LoanApplicationAmount { get { return _loanApplicationAmount; } set { _loanApplicationAmount = value; } }
            

        LoanApplication oLoanApplication = new LoanApplication();
        MemberShare oMemberShare = new MemberShare();


        string err = "";
        public ArrayList GetLoanGuarantors()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanGuarantors");
            if (err == "")
            {
                while (rd.Read())

                {
                    LoanGuarantor obj = new Classes.LoanGuarantor();
                    if (!String.IsNullOrEmpty(rd["LoanGuarantorId"].ToString())) obj.LoanGuarantorId = int.Parse(rd["LoanGuarantorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["GuarantorName"].ToString())) obj.GuarantorName = rd["GuarantorName"].ToString();
                    if (!String.IsNullOrEmpty(rd["GuaranteedAmount"].ToString())) obj.GuaranteedAmount = double.Parse(rd["GuaranteedAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["TotalShares"].ToString())) obj.TotalShares = double.Parse(rd["TotalShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["FreeShares"].ToString())) obj.FreeShares = double.Parse(rd["FreeShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.LoanAmount > 0)
                    {
                        LoanApplication myLoanApplication = oLoanApplication.GetLoanApplication(obj.LoanApplicationId);
                        {
                            if (myLoanApplication != null)
                            {
                                obj.LoanApplicationAmount = myLoanApplication.LoanAmount;
                            }
                        }
                    }


                        if (obj.LoanApplicationId > 0)
                        {
                            LoanApplication myLoannApplication = oLoanApplication.GetLoanApplication(obj.LoanApplicationId);
                            {
                                if (myLoannApplication != null)
                                {
                                    obj.MemberLoanName = myLoannApplication.MemberName;
                                }
                            }

                        }
                        if (obj.MemberShareId > 0)
                        {
                            MemberShare myMemberShare = oMemberShare.GetMemberShare(obj.MemberShareId);
                            {
                                if (myMemberShare != null)
                                {
                                    obj.MemberName = myMemberShare.MemberName;
                                }
                            }

                        }
                        myList.Add(obj);
                    }
                    try { rd.Close(); }
                    catch {; }

                }
                return myList;
            }
        
        public LoanGuarantor  GetLoanGuarantor(int LoanGuarantorId)
        {
            LoanGuarantor obj = null;

          Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoanGuarantor", "@LoanGuarantorId", LoanGuarantorId );
            if (err == "")
            {
                while (rd.Read())

                {
                    obj = new Classes.LoanGuarantor();
                    if (!String.IsNullOrEmpty(rd["LoanGuarantorId"].ToString())) obj.LoanGuarantorId = int.Parse(rd["LoanGuarantorId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["GuarantorName"].ToString())) obj.GuarantorName = rd["GuarantorName"].ToString();
                    if (!String.IsNullOrEmpty(rd["GuaranteedAmount"].ToString())) obj.GuaranteedAmount = double.Parse(rd["GuaranteedAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["TotalShares"].ToString())) obj.TotalShares = double.Parse(rd["TotalShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["FreeShares"].ToString())) obj.FreeShares = double.Parse(rd["FreeShares"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanAmount"].ToString())) obj.LoanAmount = double.Parse(rd["LoanAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.LoanAmount > 0)
                    {
                        LoanApplication myLoanApplication = oLoanApplication.GetLoanApplication(obj.LoanApplicationId);
                        {
                            if (myLoanApplication != null)
                            {
                                obj.LoanApplicationAmount = myLoanApplication.LoanAmount;
                            }
                        }

                    }
                    if (obj.MemberShareId > 0)
                    {
                        MemberShare myMemberShare = oMemberShare.GetMemberShare(obj.MemberShareId);
                        {
                            if (myMemberShare != null)
                            {
                                obj.MemberName = myMemberShare.MemberName;
                            }
                        }

                    }
                    if (obj.LoanApplicationId > 0)
                    {
                        LoanApplication myLoannApplication = oLoanApplication.GetLoanApplication(obj.LoanApplicationId);
                        {
                            if (myLoannApplication != null)
                            {
                                obj.MemberLoanName = myLoannApplication.MemberName;
                            }
                        }

                    }

                }
                try { rd.Close(); }
                catch {; }

            }
            return obj;
        }
        public int AddEditLoanGuarantor(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanGuarantor", "@LoanGuarantorId", this.LoanGuarantorId,
                "@LoanApplicationId", this.LoanApplicationId,
"@MemberShareId", this.MemberShareId,
"@GuarantorName", this.GuarantorName,
"@GuaranteedAmount", this.GuaranteedAmount,
"@TotalShares", this.TotalShares ,
"@FreeShares", this.FreeShares ,
"@LoanAmount", this.LoanAmount,
"@IsActive", this.IsActive,
"@MachineName", "USER-PC",
"@CreatedBy", "ADMIN",
"@delete", delete
);
            if(err=="")
            {
                if(rd.Read ())
                {
                    id = int.Parse(rd["Id"].ToString());

                }
                try { rd.Close(); }
                catch {; }
                
            }
            err = error;
            return id;
        }

    }
}
