using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Journal
    {

        private int _transId = 0;
        private DateTime _transDate = DateTime.Today;
        private DateTime _actualdate = DateTime.Today;
        private int _serialId = 0;
        private string _sourceDescription = "";
        private string _targetDescription = "";
        private string _referenceNumber = "";
        private int _gLId = 0;
        private string _gLName = "";
        private int _contraGLId = 0;
        private string _contraGLIdName = "";
        private double _amount = 0;
        private bool _isReconciled = false;
        private string _transType = "";
        private string _modeOfPayment = "";
        private bool _affectsDR = false;
        private int _memberId = 0;
        private string _memberName = "";
        private int _productId = 0;
        private string _productName = "";
        private int _accountId = 0;
        private string _accountName = "";
        private double _accountBalance = 0;
        private int _creditOfficerId = 0;
        private int _sourceBranchId = 0;
        private int _targetBranchid = 0;
        private string _machineName = "";
        private bool _isReversal = false;
        private bool _isReversed = false;
        private int _reversalReferenceId = 0;
        private bool _isGuarantorPayment = false;
        private bool _isActive = false;
        private string  _remarks = "";
        private int _refId1 = 0;
        private int _refId2 = 0;
        private int _refId3 = 0;
        private int _refId4 = 0;
        private int _refId5 = 0;
        private int _refId6 = 0;
        private int _refId7 = 0;
        private int _refId8 = 0;
        private int _refId9 = 0;
        private string _createdBy = "";
        private DateTime _createdOn = DateTime.Today;
        private string _modifiedBy = "";
        private DateTime _modifiedOn = DateTime.Today;

        public int TransId { get { return _transId; } set { _transId = value; } }
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public DateTime Actualdate { get { return _actualdate; } set { _actualdate = value; } }
        public int SerialId { get { return _serialId; } set { _serialId = value; } }
        public string SourceDescription { get { return _sourceDescription; } set { _sourceDescription = value; } }
        public string TargetDescription { get { return _targetDescription; } set { _targetDescription = value; } }
        public string ReferenceNumber { get { return _referenceNumber; } set { _referenceNumber = value; } }
        public int GLId { get { return _gLId; } set { _gLId = value; } }
        public string GLName { get { return _gLName; } set { _gLName = value; } }
        public int ContraGLId { get { return _contraGLId; } set { _contraGLId = value; } }
        public string ContraGLIdName { get { return _contraGLIdName; } set { _contraGLIdName = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public bool IsReconciled { get { return _isReconciled; } set { _isReconciled = value; } }
        public string TransType { get { return _transType; } set { _transType = value; } }
        public string ModeOfPayment { get { return _modeOfPayment; } set { _modeOfPayment = value; } }
        public bool AffectsDR { get { return _affectsDR; } set { _affectsDR = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string ProductName { get { return _productName; } set { _productName = value; } }
        public int AccountId { get { return _accountId; } set { _accountId = value; } }
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        public double AccountBalance { get { return _accountBalance; } set { _accountBalance = value; } }
        public int CreditOfficerId { get { return _creditOfficerId; } set { _creditOfficerId = value; } }
        public int SourceBranchId { get { return _sourceBranchId; } set { _sourceBranchId = value; } }
        public int TargetBranchid { get { return _targetBranchid; } set { _targetBranchid = value; } }
        public string MachineName { get { return _machineName; } set { _machineName = value; } }
        public bool IsReversal { get { return _isReversal; } set { _isReversal = value; } }
        public bool IsReversed { get { return _isReversed; } set { _isReversed = value; } }
        public int ReversalReferenceId { get { return _reversalReferenceId; } set { _reversalReferenceId = value; } }
        public bool IsGuarantorPayment { get { return _isGuarantorPayment; } set { _isGuarantorPayment = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string  Remarks { get { return _remarks; } set { _remarks = value; } }
        public int RefId1 { get { return _refId1; } set { _refId1 = value; } }
        public int RefId2 { get { return _refId2; } set { _refId2 = value; } }
        public int RefId3 { get { return _refId3; } set { _refId3 = value; } }
        public int RefId4 { get { return _refId4; } set { _refId4 = value; } }
        public int RefId5 { get { return _refId5; } set { _refId5 = value; } }
        public int RefId6 { get { return _refId6; } set { _refId6 = value; } }
        public int RefId7 { get { return _refId7; } set { _refId7 = value; } }
        public int RefId8 { get { return _refId8; } set { _refId8 = value; } }
        public int RefId9 { get { return _refId9; } set { _refId9 = value; } }
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime CreatedOn { get { return _createdOn; } set { _createdOn = value; } }
        public string ModifiedBy { get { return _modifiedBy; } set { _modifiedBy = value; } }
        public DateTime ModifiedOn { get { return _modifiedOn; } set { _modifiedOn = value; } }

        string err = "";
        public ArrayList GetTransactions()
        {

            ArrayList myList = new ArrayList();
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllTransactions");
            if(err=="")
            {
                while(rd.Read ())
                {
                    Journal obj = new Classes.Journal();
                    if (!string.IsNullOrEmpty(rd["TransId"].ToString())) obj.TransId = int.Parse(rd["TransId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Actualdate"].ToString())) obj.Actualdate = DateTime.Parse(rd["Actualdate"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceDescription"].ToString())) obj.SourceDescription = rd["SourceDescription"].ToString();
                    if (!String.IsNullOrEmpty(rd["TargetDescription"].ToString())) obj.TargetDescription = rd["TargetDescription"].ToString();
                    if (!String.IsNullOrEmpty(rd["ReferenceNumber"].ToString())) obj.ReferenceNumber = rd["ReferenceNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId = int.Parse(rd["GLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["GLName"].ToString())) obj.GLName = rd["GLName"].ToString();
                    if (!String.IsNullOrEmpty(rd["ContraGLId"].ToString())) obj.ContraGLId = int.Parse(rd["ContraGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContraGLIdName"].ToString())) obj.ContraGLIdName = rd["ContraGLIdName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReconciled"].ToString())) obj.IsReconciled = bool.Parse(rd["IsReconciled"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransType"].ToString())) obj.TransType = rd["TransType"].ToString();
                    if (!String.IsNullOrEmpty(rd["ModeOfPayment"].ToString())) obj.ModeOfPayment = rd["ModeOfPayment"].ToString();
                    if (!String.IsNullOrEmpty(rd["AffectsDR"].ToString())) obj.AffectsDR = bool.Parse(rd["AffectsDR"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductName"].ToString())) obj.ProductName = rd["ProductName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountId"].ToString())) obj.AccountId = int.Parse(rd["AccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountName"].ToString())) obj.AccountName = rd["AccountName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountBalance"].ToString())) obj.AccountBalance = double.Parse(rd["AccountBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceBranchId"].ToString())) obj.SourceBranchId = int.Parse(rd["SourceBranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TargetBranchid"].ToString())) obj.TargetBranchid = int.Parse(rd["TargetBranchid"].ToString());
                    if (!String.IsNullOrEmpty(rd["MachineName"].ToString())) obj.MachineName = rd["MachineName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversalReferenceId"].ToString())) obj.ReversalReferenceId = int.Parse(rd["ReversalReferenceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsGuarantorPayment"].ToString())) obj.IsGuarantorPayment = bool.Parse(rd["IsGuarantorPayment"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["RefId1"].ToString())) obj.RefId1 = int.Parse(rd["RefId1"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId2"].ToString())) obj.RefId2 = int.Parse(rd["RefId2"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId3"].ToString())) obj.RefId3 = int.Parse(rd["RefId3"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId4"].ToString())) obj.RefId4 = int.Parse(rd["RefId4"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId5"].ToString())) obj.RefId5 = int.Parse(rd["RefId5"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId6"].ToString())) obj.RefId6 = int.Parse(rd["RefId6"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId7"].ToString())) obj.RefId7 = int.Parse(rd["RefId7"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId8"].ToString())) obj.RefId8 = int.Parse(rd["RefId8"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId9"].ToString())) obj.RefId9 = int.Parse(rd["RefId9"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreatedBy"].ToString())) obj.CreatedBy = rd["CreatedBy"].ToString();
                    if (!String.IsNullOrEmpty(rd["CreatedOn"].ToString())) obj.CreatedOn = DateTime.Parse(rd["CreatedOn"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModifiedBy"].ToString())) obj.ModifiedBy = rd["ModifiedBy"].ToString();
                    if (!string.IsNullOrEmpty(rd["ModifiedOn"].ToString())) obj.ModifiedOn = DateTime.Parse(rd["ModifiedOn"].ToString());
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
            return myList ;

        } 
        public Journal GetTransaction( int TransId)
        {
            Journal obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getTransaction", "@TransId", TransId);
                if(err=="")
            {
                if(rd.Read())
                {
                    obj = new Classes.Journal();                    
                    if (!string.IsNullOrEmpty(rd["TransId"].ToString())) obj.TransId = int.Parse(rd["TransId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Actualdate"].ToString())) obj.Actualdate = DateTime.Parse(rd["Actualdate"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceDescription"].ToString())) obj.SourceDescription = rd["SourceDescription"].ToString();
                    if (!String.IsNullOrEmpty(rd["TargetDescription"].ToString())) obj.TargetDescription = rd["TargetDescription"].ToString();
                    if (!String.IsNullOrEmpty(rd["ReferenceNumber"].ToString())) obj.ReferenceNumber = rd["ReferenceNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId = int.Parse(rd["GLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["GLName"].ToString())) obj.GLName = rd["GLName"].ToString();
                    if (!String.IsNullOrEmpty(rd["ContraGLId"].ToString())) obj.ContraGLId = int.Parse(rd["ContraGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContraGLIdName"].ToString())) obj.ContraGLIdName = rd["ContraGLIdName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReconciled"].ToString())) obj.IsReconciled = bool.Parse(rd["IsReconciled"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransType"].ToString())) obj.TransType = rd["TransType"].ToString();
                    if (!String.IsNullOrEmpty(rd["ModeOfPayment"].ToString())) obj.ModeOfPayment = rd["ModeOfPayment"].ToString();
                    if (!String.IsNullOrEmpty(rd["AffectsDR"].ToString())) obj.AffectsDR = bool.Parse(rd["AffectsDR"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductName"].ToString())) obj.ProductName = rd["ProductName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountId"].ToString())) obj.AccountId = int.Parse(rd["AccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountName"].ToString())) obj.AccountName = rd["AccountName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountBalance"].ToString())) obj.AccountBalance = double.Parse(rd["AccountBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SourceBranchId"].ToString())) obj.SourceBranchId = int.Parse(rd["SourceBranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TargetBranchid"].ToString())) obj.TargetBranchid = int.Parse(rd["TargetBranchid"].ToString());
                    if (!String.IsNullOrEmpty(rd["MachineName"].ToString())) obj.MachineName = rd["MachineName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversalReferenceId"].ToString())) obj.ReversalReferenceId = int.Parse(rd["ReversalReferenceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsGuarantorPayment"].ToString())) obj.IsGuarantorPayment = bool.Parse(rd["IsGuarantorPayment"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["RefId1"].ToString())) obj.RefId1 = int.Parse(rd["RefId1"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId2"].ToString())) obj.RefId2 = int.Parse(rd["RefId2"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId3"].ToString())) obj.RefId3 = int.Parse(rd["RefId3"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId4"].ToString())) obj.RefId4 = int.Parse(rd["RefId4"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId5"].ToString())) obj.RefId5 = int.Parse(rd["RefId5"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId6"].ToString())) obj.RefId6 = int.Parse(rd["RefId6"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId7"].ToString())) obj.RefId7 = int.Parse(rd["RefId7"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId8"].ToString())) obj.RefId8 = int.Parse(rd["RefId8"].ToString());
                    if (!String.IsNullOrEmpty(rd["RefId9"].ToString())) obj.RefId9 = int.Parse(rd["RefId9"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreatedBy"].ToString())) obj.CreatedBy = rd["CreatedBy"].ToString();
                    if (!String.IsNullOrEmpty(rd["CreatedOn"].ToString())) obj.CreatedOn = DateTime.Parse(rd["CreatedOn"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModifiedBy"].ToString())) obj.ModifiedBy = rd["ModifiedBy"].ToString();
                    if (!string.IsNullOrEmpty(rd["ModifiedOn"].ToString())) obj.ModifiedOn = DateTime.Parse(rd["ModifiedOn"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditTransaction(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditTransaction",
               "@TransId", this.TransId,
                "@TransDate", "09/09/2016",
                 "@Actualdate", "09/09/2016",
                "@SerialId", this.SerialId,
                "@SourceDescription", this.SourceDescription,
                "@TargetDescription", this.SourceDescription,
                "@ReferenceNumber", this.ReferenceNumber,
                "@GLId", this.GLId ,
                "@GLName", "CASH",
               "@ContraGLId", 100 ,
"@ContraGLIdName",  "EXPENSES" ,
"@Amount", this.Amount,
"@IsReconciled", true ,
"@TransType", "Local",
"@ModeOfPayment", "Mpesa",
"@AffectsDR", false ,
"@MemberId", "100",
"@MemberName", "ZIpporah and Naomy",
"@ProductId"," 100",
"@ProductName", "Loan",
"@AccountId", this.GLId ,
"@AccountName", "No name",
"@AccountBalance", "100",
"@CreditOfficerId", "100",
"@SourceBranchId", "100",
"@TargetBranchid", "100",
"@MachineName", "USER-PC",
"@IsReversal", true,
"@IsReversed", true ,
"@ReversalReferenceId", "100",
"@IsGuarantorPayment", false,
"@IsActive", true,
"@Remarks", "Testing and Debuging",
"@RefId1", "100",
"@RefId2", "100",
"@RefId3", "100",
"@RefId4", "100",
"@RefId5", "100",
"@RefId6", "100",
"@RefId7", "100",
"@RefId8", "0",
"@RefId9", "0",
 "@MachineName", "USER-PC",
"@CreatedBy", "Admin",

"@delete", delete);
            if(err=="")
            {
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            error = err;
            return id;
        }
    }
}
