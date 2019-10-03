using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Bank
    {

        private int _bankId = 0;
        private string _bankName = "";
        private string _bankAccountNo = "";
        private string _branchName = "";
        private string _accountName = "";
        private int _gLId = 0;
        private bool _isDefaultMobileAc = false;
        private string _swiftCode = "";
        private string _iBAN = "";
        private string _contactPerson = "";
        private string _address = "";
        private string _email = "";
        private string _remarks = "";
        private string _machineName = "";
        private bool _isActive = false;
        private DateTime _createdOn = DateTime.Today;
        private string _createdBy = "";
        private DateTime _modifiedOn = DateTime.Today;
        private string _modifiedBy = "";



        public int BankId { get { return _bankId; } set { _bankId = value; } }
        public string BankName { get { return _bankName; } set { _bankName = value; } }
        public string BankAccountNo { get { return _bankAccountNo; } set { _bankAccountNo = value; } }
        public string BranchName { get { return _branchName; } set { _branchName = value; } }
        public string AccountName { get { return _accountName; } set { _accountName = value; } }
        public int GLId { get { return _gLId; } set { _gLId = value; } }
        public bool IsDefaultMobileAc { get { return _isDefaultMobileAc; } set { _isDefaultMobileAc = value; } }
        public string SwiftCode { get { return _swiftCode; } set { _swiftCode = value; } }
        public string IBAN { get { return _iBAN; } set { _iBAN = value; } }
        public string ContactPerson { get { return _contactPerson; } set { _contactPerson = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string MachineName { get { return _machineName; } set { _machineName = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public DateTime CreatedOn { get { return _createdOn; } set { _createdOn = value; } }
        public string CreatedBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime ModifiedOn { get { return _modifiedOn; } set { _modifiedOn = value; } }
        public string ModifiedBy { get { return _modifiedBy; } set { _modifiedBy = value; } }

        ChartOfAccount oChartOfAccount = new ChartOfAccount();

        string err = "";

        public ArrayList GetBanks()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllBanks");
            if(err=="")
            {
                while(rd.Read ())
                {
                    Bank obj = new Classes.Bank();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankName"].ToString())) obj.BankName = rd["BankName"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankAccountNo"].ToString())) obj.BankAccountNo = rd["BankAccountNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BranchName"].ToString())) obj.BranchName = rd["BranchName"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId = int.Parse(rd["GLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsDefaultMobileAc"].ToString())) obj.IsDefaultMobileAc = bool.Parse(rd["IsDefaultMobileAc"].ToString());
                    if (!String.IsNullOrEmpty(rd["SwiftCode"].ToString())) obj.SwiftCode = rd["SwiftCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["IBAN"].ToString())) obj.IBAN = rd["IBAN"].ToString();
                    if (!String.IsNullOrEmpty(rd["ContactPerson"].ToString())) obj.ContactPerson = rd["ContactPerson"].ToString();
                    if (!String.IsNullOrEmpty(rd["Address"].ToString())) obj.Address = rd["Address"].ToString();
                    if (!String.IsNullOrEmpty(rd["Email"].ToString())) obj.Email = rd["Email"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.GLId>0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.GLId);
                            if(myChartOfAccount!=null)
                        {
                            obj.AccountName = myChartOfAccount.AccountName;
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


        public Bank  GetBank(int BankId)
        {
            Bank obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getBank", "@BankId", BankId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Bank();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankName"].ToString())) obj.BankName = rd["BankName"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankAccountNo"].ToString())) obj.BankAccountNo = rd["BankAccountNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BranchName"].ToString())) obj.BranchName = rd["BranchName"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId = int.Parse(rd["GLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsDefaultMobileAc"].ToString())) obj.IsDefaultMobileAc = bool.Parse(rd["IsDefaultMobileAc"].ToString());
                    if (!String.IsNullOrEmpty(rd["SwiftCode"].ToString())) obj.SwiftCode = rd["SwiftCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["IBAN"].ToString())) obj.IBAN = rd["IBAN"].ToString();
                    if (!String.IsNullOrEmpty(rd["ContactPerson"].ToString())) obj.ContactPerson = rd["ContactPerson"].ToString();
                    if (!String.IsNullOrEmpty(rd["Address"].ToString())) obj.Address = rd["Address"].ToString();
                    if (!String.IsNullOrEmpty(rd["Email"].ToString())) obj.Email = rd["Email"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.GLId > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.GLId);
                        if (myChartOfAccount != null)
                        {
                            obj.AccountName = myChartOfAccount.AccountName;
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

public int AddEditBank(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditBank", "@BankId", this.BankId,
            "@BankName", this.BankName,
             "@BankAccountNo", this.BankAccountNo,
            "@BranchName", this.BranchName,
            "@GLId", this.GLId  ,
            "@IsDefaultMobileAc", this.IsDefaultMobileAc,
            "@SwiftCode", this.SwiftCode,
            "@IBAN", this.IBAN,
            "@ContactPerson", this.ContactPerson,
            "@Address", this.Address,
            "@Email", this.Email,
            "@Remarks", this.Remarks,
            "@MachineName", "USER-PC",
            "@IsActive", this.IsActive,
                        "@CreatedBy", "Admin",
            "@delete", delete);
            if(err=="")
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
