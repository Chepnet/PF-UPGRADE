using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Member
    {
        private int _memberId = 0;
        private string _idNumber = "";
        private string _memberNo = "";
        private int _memberApplicationId = 0;
        private string _memberName = "";
        private DateTime _regDate = DateTime.Today;
        private string _phoneNumber = "";
        private DateTime _dateOfBirth = DateTime.Today;
        private string _gender = "";
        private string _maritalStatus = "";
        private string _kraPin = "";
        private int _customerBankId = 0;
        private int _customerBankBranchId = 0;
        private string _customerBankAccount = "";
        private string _tel1 = "";
        private string _tel2 = "";
        private string _emailAddress = "";
        private string _postalAddress = "";
        private string _physicalAddress = "";
        private int _employerId = 0;
        private int _stationId = 0;
        private int _departmentId = 0;
        private int _withdrawalId = 0;
        private bool _isActive = false;
        private double _grossSalary = 0;
        private double _netsalary = 0;
        private int _clientClassificationId = 0;
        private int _companyId = 0;
        private string _regCertNo = "";
        private bool _isCompany = false;
        private int _processId = 0;
        private int _branchId = 0;
        private string _title = "";

        private string _stationName = "";//from stastion class
        private string _employerName = "";//from employer class
        private string _clientClassificationName = "";//from clientclassification class



        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string IdNumber { get { return _idNumber; } set { _idNumber = value; } }
        public string MemberNo { get { return _memberNo; } set { _memberNo = value; } }
        public int MemberApplicationId { get { return _memberApplicationId; } set { _memberApplicationId = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        public DateTime RegDate { get { return _regDate; } set { _regDate = value; } }
        public string PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public string Gender { get { return _gender; } set { _gender = value; } }
        public string MaritalStatus { get { return _maritalStatus; } set { _maritalStatus = value; } }
        public string KraPin { get { return _kraPin; } set { _kraPin = value; } }
        public int CustomerBankId { get { return _customerBankId; } set { _customerBankId = value; } }
        public int CustomerBankBranchId { get { return _customerBankBranchId; } set { _customerBankBranchId = value; } }
        public string CustomerBankAccount { get { return _customerBankAccount; } set { _customerBankAccount = value; } }
        public string Tel1 { get { return _tel1; } set { _tel1 = value; } }
        public string Tel2 { get { return _tel2; } set { _tel2 = value; } }
        public string EmailAddress { get { return _emailAddress; } set { _emailAddress = value; } }
        public string PostalAddress { get { return _postalAddress; } set { _postalAddress = value; } }
        public string PhysicalAddress { get { return _physicalAddress; } set { _physicalAddress = value; } }
        public int EmployerId { get { return _employerId; } set { _employerId = value; } }
        public int StationId { get { return _stationId; } set { _stationId = value; } }
        public int DepartmentId { get { return _departmentId; } set { _departmentId = value; } }
        public int WithdrawalId { get { return _withdrawalId; } set { _withdrawalId = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public double GrossSalary { get { return _grossSalary; } set { _grossSalary = value; } }
        public double Netsalary { get { return _netsalary; } set { _netsalary = value; } }
        public int ClientClassificationId { get { return _clientClassificationId; } set { _clientClassificationId = value; } }
        public int CompanyId { get { return _companyId; } set { _companyId = value; } }
        public string RegCertNo { get { return _regCertNo; } set { _regCertNo = value; } }
        public bool IsCompany { get { return _isCompany; } set { _isCompany = value; } }
        public int ProcessId { get { return _processId; } set { _processId = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public string Title { get { return _title; } set { _title = value; } }

        public string ClientClassificationName { get { return _clientClassificationName; } set { _clientClassificationName = value; } }
        ClientClassification oClientClassification = new ClientClassification();//instantiating a class

        public string StationName { get { return _stationName; } set { _stationName = value; } }
        Station oStation = new Station();

        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        Employer oEmployer = new Employer();


        string err = "";

        public ArrayList GetMembers()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllMembers");
            if (err == "")
            {
                while (rd.Read())
                {
                    Member obj = new Classes.Member();
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IdNumber"].ToString())) obj.IdNumber = rd["IdNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberNo"].ToString())) obj.MemberNo = rd["MemberNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberApplicationId"].ToString())) obj.MemberApplicationId = int.Parse(rd["MemberApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["RegDate"].ToString())) obj.RegDate = DateTime.Parse(rd["RegDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PhoneNumber"].ToString())) obj.PhoneNumber = rd["PhoneNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                    if (!String.IsNullOrEmpty(rd["Gender"].ToString())) obj.Gender = rd["Gender"].ToString();
                    if (!String.IsNullOrEmpty(rd["MaritalStatus"].ToString())) obj.MaritalStatus = rd["MaritalStatus"].ToString();
                    if (!String.IsNullOrEmpty(rd["KraPin"].ToString())) obj.KraPin = rd["KraPin"].ToString();
                    if (!String.IsNullOrEmpty(rd["CustomerBankId"].ToString())) obj.CustomerBankId = int.Parse(rd["CustomerBankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerBankBranchId"].ToString())) obj.CustomerBankBranchId = int.Parse(rd["CustomerBankBranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerBankAccount"].ToString())) obj.CustomerBankAccount = rd["CustomerBankAccount"].ToString();
                    if (!String.IsNullOrEmpty(rd["Tel1"].ToString())) obj.Tel1 = rd["Tel1"].ToString();
                    if (!String.IsNullOrEmpty(rd["Tel2"].ToString())) obj.Tel2 = rd["Tel2"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmailAddress"].ToString())) obj.EmailAddress = rd["EmailAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalAddress"].ToString())) obj.PostalAddress = rd["PostalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PhysicalAddress"].ToString())) obj.PhysicalAddress = rd["PhysicalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationId"].ToString())) obj.StationId = int.Parse(rd["StationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepartmentId"].ToString())) obj.DepartmentId = int.Parse(rd["DepartmentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalId"].ToString())) obj.WithdrawalId = int.Parse(rd["WithdrawalId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["GrossSalary"].ToString())) obj.GrossSalary = double.Parse(rd["GrossSalary"].ToString());
                    if (!String.IsNullOrEmpty(rd["Netsalary"].ToString())) obj.Netsalary = double.Parse(rd["Netsalary"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClientClassificationId"].ToString())) obj.ClientClassificationId = int.Parse(rd["ClientClassificationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CompanyId"].ToString())) obj.CompanyId = int.Parse(rd["CompanyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RegCertNo"].ToString())) obj.RegCertNo = rd["RegCertNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsCompany"].ToString())) obj.IsCompany = bool.Parse(rd["IsCompany"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProcessId"].ToString())) obj.ProcessId = int.Parse(rd["ProcessId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Title"].ToString())) obj.Title = rd["Title"].ToString();

                    if(obj.StationId >0)
                    {
                        Station myStation = oStation.GetStation(obj.StationId);
                        if (myStation != null)
                            obj.StationName = myStation.StationName;
                    }
                    if(obj.ClientClassificationId>0)
                    {
                        ClientClassification myClientClassification = oClientClassification.GetClientClassification(obj.ClientClassificationId);
                        if (myClientClassification != null)
                            obj.ClientClassificationName = myClientClassification.ClientClassificationName;
                    }
                    if (obj.EmployerId  > 0)
                    {
                        Employer  myEmployer = oEmployer .GetEmployer (obj.EmployerId );
                        if (myEmployer != null)
                            obj.EmployerName  = myEmployer.EmployerName ;
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

        public Member GetMember(int MemberId)
        {
            Member obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMember", "@MemberId", MemberId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Member();
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IdNumber"].ToString())) obj.IdNumber = rd["IdNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberNo"].ToString())) obj.MemberNo = rd["MemberNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberApplicationId"].ToString())) obj.MemberApplicationId = int.Parse(rd["MemberApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["RegDate"].ToString())) obj.RegDate = DateTime.Parse(rd["RegDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PhoneNumber"].ToString())) obj.PhoneNumber = rd["PhoneNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                    if (!String.IsNullOrEmpty(rd["Gender"].ToString())) obj.Gender = rd["Gender"].ToString();
                    if (!String.IsNullOrEmpty(rd["MaritalStatus"].ToString())) obj.MaritalStatus = rd["MaritalStatus"].ToString();
                    if (!String.IsNullOrEmpty(rd["KraPin"].ToString())) obj.KraPin = rd["KraPin"].ToString();
                    if (!String.IsNullOrEmpty(rd["CustomerBankId"].ToString())) obj.CustomerBankId = int.Parse(rd["CustomerBankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerBankBranchId"].ToString())) obj.CustomerBankBranchId = int.Parse(rd["CustomerBankBranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerBankAccount"].ToString())) obj.CustomerBankAccount = rd["CustomerBankAccount"].ToString();
                    if (!String.IsNullOrEmpty(rd["Tel1"].ToString())) obj.Tel1 = rd["Tel1"].ToString();
                    if (!String.IsNullOrEmpty(rd["Tel2"].ToString())) obj.Tel2 = rd["Tel2"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmailAddress"].ToString())) obj.EmailAddress = rd["EmailAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalAddress"].ToString())) obj.PostalAddress = rd["PostalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PhysicalAddress"].ToString())) obj.PhysicalAddress = rd["PhysicalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationId"].ToString())) obj.StationId = int.Parse(rd["StationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepartmentId"].ToString())) obj.DepartmentId = int.Parse(rd["DepartmentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["WithdrawalId"].ToString())) obj.WithdrawalId = int.Parse(rd["WithdrawalId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["GrossSalary"].ToString())) obj.GrossSalary = double.Parse(rd["GrossSalary"].ToString());
                    if (!String.IsNullOrEmpty(rd["Netsalary"].ToString())) obj.Netsalary = double.Parse(rd["Netsalary"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClientClassificationId"].ToString())) obj.ClientClassificationId = int.Parse(rd["ClientClassificationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CompanyId"].ToString())) obj.CompanyId = int.Parse(rd["CompanyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RegCertNo"].ToString())) obj.RegCertNo = rd["RegCertNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsCompany"].ToString())) obj.IsCompany = bool.Parse(rd["IsCompany"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProcessId"].ToString())) obj.ProcessId = int.Parse(rd["ProcessId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Title"].ToString())) obj.Title = rd["Title"].ToString();

                    if (obj.StationId > 0)
                    {
                        Station myStation = oStation.GetStation(obj.StationId);
                        if (myStation != null)
                            obj.StationName = myStation.StationName;
                    }
                    if (obj.ClientClassificationId > 0)
                    {
                        ClientClassification myClientClassification = oClientClassification.GetClientClassification(obj.ClientClassificationId);
                        if (myClientClassification != null)
                            obj.ClientClassificationName = myClientClassification.ClientClassificationName;
                    }
                    if (obj.EmployerId > 0)
                    {
                        Employer myEmployer = oEmployer.GetEmployer(obj.EmployerId);
                        if (myEmployer != null)
                            obj.EmployerName = myEmployer.EmployerName;
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

        public int AddEdit(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditMember",
                "@MemberId", this.MemberId,
"@IdNumber", this.IdNumber,
"@MemberNo", this.MemberNo,
"@MemberApplicationId", this.MemberApplicationId,
"@MemberName", this.MemberName,
"@RegDate", this.RegDate.ToString("yyyyMMdd"),
"@PhoneNumber", this.PhoneNumber,
"@DateOfBirth", this.DateOfBirth.ToString("yyyyMMdd"),
"@Gender", this.Gender,
"@MaritalStatus", this.MaritalStatus,
"@KraPin", this.KraPin,
"@CustomerBankId", this.CustomerBankId,
"@CustomerBankBranchId", this.CustomerBankBranchId,
"@CustomerBankAccount", this.CustomerBankAccount,
"@Tel1", this.Tel1,
"@Tel2", this.Tel2,
"@EmailAddress", this.EmailAddress,
"@PostalAddress", this.PostalAddress,
"@PhysicalAddress", this.PhysicalAddress,
"@EmployerId", this.EmployerId,
"@StationId", this.StationId,
"@DepartmentId", this.DepartmentId,
"@WithdrawalId", this.WithdrawalId,
"@IsActive", this.IsActive,
"@GrossSalary", this.GrossSalary,
"@Netsalary", this.Netsalary,
"@ClientClassificationId", this.ClientClassificationId,
"@CompanyId", this.CompanyId,
"@RegCertNo", this.RegCertNo,
"@IsCompany", this.IsCompany,
"@ProcessId", this.ProcessId,
"@BranchId", this.BranchId,
"@Title", this.Title,
"@CreatedBy", "Admin",
 "@MachineName", "USER-PC",
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

       
    }
}
