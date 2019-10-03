using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace SYSTEMUPGRADEPF.Classes
{
    class MemberShare
    {
        private int _memberShareId = 0;
        private int _memberId = 0;
        private int _shareTypeId = 0;
        private double _defaultAmount = 0;
        private double _minimumBalance = 0;
        private bool _hideBalanceOnReceipt = false;
        private bool _exemptMobileCharges = false;
        private string _accountCode = "";
        private bool _isActive = false;
        private int _branchId = 0;
        private string _memberName = "";
        private string _sharetypedescription = "";
        private double  _transferAmount = 0;
       


        public int MemberShareId { get { return _memberShareId; } set { _memberShareId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int ShareTypeId { get { return _shareTypeId; } set { _shareTypeId = value; } }
        public double DefaultAmount { get { return _defaultAmount; } set { _defaultAmount = value; } }
        public double MinimumBalance { get { return _minimumBalance; } set { _minimumBalance = value; } }
        public bool HideBalanceOnReceipt { get { return _hideBalanceOnReceipt; } set { _hideBalanceOnReceipt = value; } }
        public bool ExemptMobileCharges { get { return _exemptMobileCharges; } set { _exemptMobileCharges = value; } }
        public string AccountCode { get { return _accountCode; } set { _accountCode = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public string ShareTypeDescription { get { return _sharetypedescription; } set { _sharetypedescription = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
       

        public double TransferAmmount { get { return _transferAmount ; } set { _transferAmount  = value; } }
        public double Balance
        {
            get { return this.getMemberACBalance(); }
        }

        Member oMember = new Member();
        Product Oproduct = new Product();
        ShareType oShareType = new ShareType();

        string err = "";
        public ArrayList GetMemberShares()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllMemberShares");
            if(err=="")
            {
                while(rd.Read ())
                {
                    MemberShare obj = new Classes.MemberShare();
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultAmount"].ToString())) obj.DefaultAmount = double.Parse(rd["DefaultAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinimumBalance"].ToString())) obj.MinimumBalance = double.Parse(rd["MinimumBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["HideBalanceOnReceipt"].ToString())) obj.HideBalanceOnReceipt = bool.Parse(rd["HideBalanceOnReceipt"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExemptMobileCharges"].ToString())) obj.ExemptMobileCharges = bool.Parse(rd["ExemptMobileCharges"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountCode"].ToString())) obj.AccountCode = rd["AccountCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if(obj.MemberId >0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if(obj.ShareTypeId >0)
                    {
                        ShareType  myShareType = oShareType .GetShareType (obj.ShareTypeId);
                        if (myShareType  != null)
                            obj.ShareTypeDescription  = myShareType .Description ;
                    }
                    myList.Add(obj);
                }
            }

            return myList;
        }

        public MemberShare GetMemberShare(int MemberShareId)
        {
            MemberShare obj = null;
           Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMemberShare", "@MemberShareId",MemberShareId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.MemberShare();
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultAmount"].ToString())) obj.DefaultAmount = double.Parse(rd["DefaultAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["MinimumBalance"].ToString())) obj.MinimumBalance = double.Parse(rd["MinimumBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["HideBalanceOnReceipt"].ToString())) obj.HideBalanceOnReceipt = bool.Parse(rd["HideBalanceOnReceipt"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExemptMobileCharges"].ToString())) obj.ExemptMobileCharges = bool.Parse(rd["ExemptMobileCharges"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountCode"].ToString())) obj.AccountCode = rd["AccountCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if (obj.ShareTypeId > 0)
                    {
                        ShareType myShareType = oShareType.GetShareType(obj.ShareTypeId);
                        if (myShareType != null)
                            obj.ShareTypeDescription = myShareType.Description;
                    }
                }
            }

            return obj;
        }

        public int AddEditMemberShare(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditMemberShare", "@MemberShareId", this.MemberShareId,
            "@MemberId", this.MemberId,
            "@ShareTypeId", this.ShareTypeId,
            "@DefaultAmount", this.DefaultAmount,
            "@MinimumBalance", this.MinimumBalance,
            "@HideBalanceOnReceipt", this.HideBalanceOnReceipt,
            "@ExemptMobileCharges", this.ExemptMobileCharges,
            "@AccountCode", this.AccountCode,
            "@IsActive", this.IsActive,
            "@BranchId", "0",
            "@MachineName", "Zippy-PC",
            "@CreatedBy", "Admin",
            "@delete", delete);
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

        public double getMemberACBalance()
        {
            double val = 0; 
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMemberACBalance", "@MemberShareId", this.MemberShareId);
            if (err == "")
            {
                if (rd.Read())
                {
                    val = double.Parse(rd["Balance"].ToString());
                }
                try { rd.Close(); }
                catch {; }

            }            
            return val;
        }

    }
}
