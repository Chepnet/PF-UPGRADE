using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class ChartOfAccount
    {
        private int _gLAccountId = 0;
        private string _accountCode = "";
        private string _accountName = "";
        private string _accountType = "";
        private int _accountLevel = 0;
        private int _parent = 0;
        private double _openingBalance = 0;
        private double _currentBalance = 0;
        private bool _isReconcialable = false;
        private bool _allowDirectPosting = false;
        private bool _isActive = false;
        private bool _cannotGoToDebit = false;
        private bool _cannotGoToCredit = false;
        private string _debitCreditFlag = "";
        private string _accountCategory = "";
        private string _remarks = "";
        private string _searchname = "";


        public int GLAccountId { get { return _gLAccountId; } set { _gLAccountId = value; } }
        public string AccountCode { get { return _accountCode; } set { _accountCode = value; } }
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        public string SearchName { get { return _searchname; } set { _searchname = value; } }
        public string AccountType { get { return _accountType; } set { _accountType = value; } }
        public int AccountLevel { get { return _accountLevel; } set { _accountLevel = value; } }
        public int Parent { get { return _parent; } set { _parent = value; } }
        public double OpeningBalance { get { return _openingBalance; } set { _openingBalance = value; } }
        public double CurrentBalance { get { return _currentBalance; } set { _currentBalance = value; } }
        public bool IsReconcialable { get { return _isReconcialable; } set { _isReconcialable = value; } }
        public bool AllowDirectPosting { get { return _allowDirectPosting; } set { _allowDirectPosting = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public bool CannotGoToDebit { get { return _cannotGoToDebit; } set { _cannotGoToDebit = value; } }
        public bool CannotGoToCredit { get { return _cannotGoToCredit; } set { _cannotGoToCredit = value; } }
        public string DebitCreditFlag { get { return _debitCreditFlag; } set { _debitCreditFlag = value; } }
        public string AccountCategory { get { return _accountCategory; } set { _accountCategory = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }


        string err = "";

        public ArrayList GetChartOfAccounts()
        {
            ArrayList myList = new ArrayList();
            SYSTEMUPGRADEPF.Classes.Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllGLAccounts");
            if (err == "")
            {
                while (rd.Read())
                {
                    ChartOfAccount obj = new Classes.ChartOfAccount();
                    if (!String.IsNullOrEmpty(rd["GLAccountId"].ToString())) obj.GLAccountId = int.Parse(rd["GLAccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountCode"].ToString())) obj.AccountCode = rd["AccountCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountName"].ToString())) obj.AccountName = rd["AccountName"].ToString();
                    if (!String.IsNullOrEmpty(rd["SearchName"].ToString())) obj.SearchName  = rd["SearchName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountType"].ToString())) obj.AccountType = rd["AccountType"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountLevel"].ToString())) obj.AccountLevel = int.Parse(rd["AccountLevel"].ToString());
                    if (!String.IsNullOrEmpty(rd["Parent"].ToString())) obj.Parent = int.Parse(rd["Parent"].ToString());
                    if (!String.IsNullOrEmpty(rd["OpeningBalance"].ToString())) obj.OpeningBalance = double.Parse(rd["OpeningBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["CurrentBalance"].ToString())) obj.CurrentBalance = double.Parse(rd["CurrentBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReconcialable"].ToString())) obj.IsReconcialable = bool.Parse(rd["IsReconcialable"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowDirectPosting"].ToString())) obj.AllowDirectPosting = bool.Parse(rd["AllowDirectPosting"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToDebit"].ToString())) obj.CannotGoToDebit = bool.Parse(rd["CannotGoToDebit"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToCredit"].ToString())) obj.CannotGoToCredit = bool.Parse(rd["CannotGoToCredit"].ToString());
                    if (!String.IsNullOrEmpty(rd["DebitCreditFlag"].ToString())) obj.DebitCreditFlag = rd["DebitCreditFlag"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountCategory"].ToString())) obj.AccountCategory = rd["AccountCategory"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
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

        public ChartOfAccount GetChartOfAccount(int GLAccountId)
        {
            ChartOfAccount obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getGLAccount", "@GLAccountId", GLAccountId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.ChartOfAccount();
                    if (!String.IsNullOrEmpty(rd["GLAccountId"].ToString())) obj.GLAccountId = int.Parse(rd["GLAccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountCode"].ToString())) obj.AccountCode = rd["AccountCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountName"].ToString())) obj.AccountName = rd["AccountName"].ToString();
                    if (!String.IsNullOrEmpty(rd["SearchName"].ToString())) obj.SearchName = rd["SearchName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountType"].ToString())) obj.AccountType = rd["AccountType"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountLevel"].ToString())) obj.AccountLevel = int.Parse(rd["AccountLevel"].ToString());
                    if (!String.IsNullOrEmpty(rd["Parent"].ToString())) obj.Parent = int.Parse(rd["Parent"].ToString());
                    if (!String.IsNullOrEmpty(rd["OpeningBalance"].ToString())) obj.OpeningBalance = double.Parse(rd["OpeningBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["CurrentBalance"].ToString())) obj.CurrentBalance = double.Parse(rd["CurrentBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReconcialable"].ToString())) obj.IsReconcialable = bool.Parse(rd["IsReconcialable"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowDirectPosting"].ToString())) obj.AllowDirectPosting = bool.Parse(rd["AllowDirectPosting"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToDebit"].ToString())) obj.CannotGoToDebit = bool.Parse(rd["CannotGoToDebit"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToCredit"].ToString())) obj.CannotGoToCredit = bool.Parse(rd["CannotGoToCredit"].ToString());
                    if (!String.IsNullOrEmpty(rd["DebitCreditFlag"].ToString())) obj.DebitCreditFlag = rd["DebitCreditFlag"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountCategory"].ToString())) obj.AccountCategory = rd["AccountCategory"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks =rd["Remarks"].ToString();
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }

            return obj;
        }

        public int AddEdit(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditGLAccount",
                "@GLAccountId", this.GLAccountId,
                "@AccountCode", this.AccountCode,
                "@AccountName", this.AccountName,
                "@SearchName", this.SearchName ,
                "@AccountType", this.AccountType,
                "@AccountLevel", this.AccountLevel,
                "@Parent", this.Parent,
                "@OpeningBalance", this.OpeningBalance,
                "@CurrentBalance", this.CurrentBalance,
                "@IsReconcialable", this.IsReconcialable,
                "@AllowDirectPosting", this.AllowDirectPosting,
                "@IsActive", this.IsActive,
                "@CannotGoToDebit", this.CannotGoToDebit,
                "@CannotGoToCredit", this.CannotGoToCredit,
                "@DebitCreditFlag", this.DebitCreditFlag,
                "@AccountCategory", this.AccountCategory,
                "@Remarks", this.Remarks,
                 "@MachineName", "USER-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);


                if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); } catch {; }
            }
            error = err;
            return id;

        }
        public string InitializeChartOfAccounts()
        {
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_InitializeGLAccountsTypes");
            try { rd.Close(); } catch {; }
            return err;
        }

        public ArrayList GetPostinhChartOfAccounts()
        {
            ArrayList myList = new ArrayList();
            SYSTEMUPGRADEPF.Classes.Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_GetPostingGls");
            if (err == "")
            {
                while (rd.Read())
                {
                    ChartOfAccount obj = new Classes.ChartOfAccount();
                    if (!String.IsNullOrEmpty(rd["GLAccountId"].ToString())) obj.GLAccountId = int.Parse(rd["GLAccountId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccountCode"].ToString())) obj.AccountCode = rd["AccountCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountName"].ToString())) obj.AccountName = rd["AccountName"].ToString();
                    if (!String.IsNullOrEmpty(rd["SearchName"].ToString())) obj.SearchName = rd["SearchName"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountType"].ToString())) obj.AccountType = rd["AccountType"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountLevel"].ToString())) obj.AccountLevel = int.Parse(rd["AccountLevel"].ToString());
                    if (!String.IsNullOrEmpty(rd["Parent"].ToString())) obj.Parent = int.Parse(rd["Parent"].ToString());
                    if (!String.IsNullOrEmpty(rd["OpeningBalance"].ToString())) obj.OpeningBalance = double.Parse(rd["OpeningBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["CurrentBalance"].ToString())) obj.CurrentBalance = double.Parse(rd["CurrentBalance"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReconcialable"].ToString())) obj.IsReconcialable = bool.Parse(rd["IsReconcialable"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowDirectPosting"].ToString())) obj.AllowDirectPosting = bool.Parse(rd["AllowDirectPosting"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToDebit"].ToString())) obj.CannotGoToDebit = bool.Parse(rd["CannotGoToDebit"].ToString());
                    if (!String.IsNullOrEmpty(rd["CannotGoToCredit"].ToString())) obj.CannotGoToCredit = bool.Parse(rd["CannotGoToCredit"].ToString());
                    if (!String.IsNullOrEmpty(rd["DebitCreditFlag"].ToString())) obj.DebitCreditFlag = rd["DebitCreditFlag"].ToString();
                    if (!String.IsNullOrEmpty(rd["AccountCategory"].ToString())) obj.AccountCategory = rd["AccountCategory"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
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
    }
}
            
        

