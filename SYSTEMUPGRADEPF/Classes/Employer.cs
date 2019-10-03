using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Employer
    {
        private int _employerId = 0;
        private string _employerCode = "";
        private string _employerName = "";
        private string _employerTel1 = "";
        private string _employerTel2 = "";
        private string _employerCellNo = "";
        private string _employerFaxNo = "";
        private string _employerEmailAddress = "";
        private string _employerAddress = "";
        private string _postalAddress = "";
        private string _employerRetirement = "";
        private int _noOfWeek = 0;
        private int _everyDayOfWeek = 0;
        private int _dateOfMonth = 0;
        private bool _useRefDate = false;
        private int _maximumMembership = 0;
        private double _serviceCharge = 0;
        private int _creditOfficerId = 0;
        private bool _limitSavings = false;
        private bool _limitLoans = false;
        private string _groupPrefix = "";
        private int _prevNo = 0;
        private bool _isActive = false;

        public int EmployerId { get { return _employerId; } set { _employerId = value; } }
        public string EmployerCode { get { return _employerCode; } set { _employerCode = value; } }
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }
        public string EmployerTel1 { get { return _employerTel1; } set { _employerTel1 = value; } }
        public string EmployerTel2 { get { return _employerTel2; } set { _employerTel2 = value; } }
        public string EmployerCellNo { get { return _employerCellNo; } set { _employerCellNo = value; } }
        public string EmployerFaxNo { get { return _employerFaxNo; } set { _employerFaxNo = value; } }
        public string EmployerEmailAddress { get { return _employerEmailAddress; } set { _employerEmailAddress = value; } }
        public string EmployerAddress { get { return _employerAddress; } set { _employerAddress = value; } }
        public string PostalAddress { get { return _postalAddress; } set { _postalAddress = value; } }
        public string EmployerRetirement { get { return _employerRetirement; } set { _employerRetirement = value; } }
        public int NoOfWeek { get { return _noOfWeek; } set { _noOfWeek = value; } }
        public int EveryDayOfWeek { get { return _everyDayOfWeek; } set { _everyDayOfWeek = value; } }
        public int DateOfMonth { get { return _dateOfMonth; } set { _dateOfMonth = value; } }
        public bool UseRefDate { get { return _useRefDate; } set { _useRefDate = value; } }
        public int MaximumMembership { get { return _maximumMembership; } set { _maximumMembership = value; } }
        public double ServiceCharge { get { return _serviceCharge; } set { _serviceCharge = value; } }
        public int CreditOfficerId { get { return _creditOfficerId; } set { _creditOfficerId = value; } }
        public bool LimitSavings { get { return _limitSavings; } set { _limitSavings = value; } }
        public bool LimitLoans { get { return _limitLoans; } set { _limitLoans = value; } }
        public string GroupPrefix { get { return _groupPrefix; } set { _groupPrefix = value; } }
        public int PrevNo { get { return _prevNo; } set { _prevNo = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string err = "";

        public ArrayList GetEmployers()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllEmployers");
            if (err == "")
            {

           
                while(rd.Read())
                {
                    Employer obj = new Classes.Employer();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["EmployerCode"].ToString())) obj.EmployerCode = rd["EmployerCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerName"].ToString())) obj.EmployerName = rd["EmployerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerTel1"].ToString())) obj.EmployerTel1 = rd["EmployerTel1"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerTel2"].ToString())) obj.EmployerTel2 = rd["EmployerTel2"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerCellNo"].ToString())) obj.EmployerCellNo = rd["EmployerCellNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerFaxNo"].ToString())) obj.EmployerFaxNo = rd["EmployerFaxNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerEmailAddress"].ToString())) obj.EmployerEmailAddress = rd["EmployerEmailAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerAddress"].ToString())) obj.EmployerAddress = rd["EmployerAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalAddress"].ToString())) obj.PostalAddress = rd["PostalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerRetirement"].ToString())) obj.EmployerRetirement = rd["EmployerRetirement"].ToString();
                    if (!String.IsNullOrEmpty(rd["NoOfWeek"].ToString())) obj.NoOfWeek = int.Parse(rd["NoOfWeek"].ToString());
                    if (!String.IsNullOrEmpty(rd["EveryDayOfWeek"].ToString())) obj.EveryDayOfWeek = int.Parse(rd["EveryDayOfWeek"].ToString());
                    if (!String.IsNullOrEmpty(rd["DateOfMonth"].ToString())) obj.DateOfMonth = int.Parse(rd["DateOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["UseRefDate"].ToString())) obj.UseRefDate = bool.Parse(rd["UseRefDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaximumMembership"].ToString())) obj.MaximumMembership = int.Parse(rd["MaximumMembership"].ToString());
                    if (!String.IsNullOrEmpty(rd["ServiceCharge"].ToString())) obj.ServiceCharge = double.Parse(rd["ServiceCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LimitSavings"].ToString())) obj.LimitSavings = bool.Parse(rd["LimitSavings"].ToString());
                    if (!String.IsNullOrEmpty(rd["LimitLoans"].ToString())) obj.LimitLoans = bool.Parse(rd["LimitLoans"].ToString());
                    if (!String.IsNullOrEmpty(rd["GroupPrefix"].ToString())) obj.GroupPrefix = rd["GroupPrefix"].ToString();
                    if (!String.IsNullOrEmpty(rd["PrevNo"].ToString())) obj.PrevNo = int.Parse(rd["PrevNo"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);

                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;


        }
        public Employer GetEmployer(int EmployerId)
        {
            Employer obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getEmployer", "@EmployerId", EmployerId);
            if(err=="")
            {
                if(rd.Read())
                {
                     obj = new Classes.Employer();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["EmployerCode"].ToString())) obj.EmployerCode = rd["EmployerCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerName"].ToString())) obj.EmployerName = rd["EmployerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerTel1"].ToString())) obj.EmployerTel1 = rd["EmployerTel1"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerTel2"].ToString())) obj.EmployerTel2 = rd["EmployerTel2"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerCellNo"].ToString())) obj.EmployerCellNo = rd["EmployerCellNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerFaxNo"].ToString())) obj.EmployerFaxNo = rd["EmployerFaxNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerEmailAddress"].ToString())) obj.EmployerEmailAddress = rd["EmployerEmailAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerAddress"].ToString())) obj.EmployerAddress = rd["EmployerAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalAddress"].ToString())) obj.PostalAddress = rd["PostalAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerRetirement"].ToString())) obj.EmployerRetirement = rd["EmployerRetirement"].ToString();
                    if (!String.IsNullOrEmpty(rd["NoOfWeek"].ToString())) obj.NoOfWeek = int.Parse(rd["NoOfWeek"].ToString());
                    if (!String.IsNullOrEmpty(rd["EveryDayOfWeek"].ToString())) obj.EveryDayOfWeek = int.Parse(rd["EveryDayOfWeek"].ToString());
                    if (!String.IsNullOrEmpty(rd["DateOfMonth"].ToString())) obj.DateOfMonth = int.Parse(rd["DateOfMonth"].ToString());
                    if (!String.IsNullOrEmpty(rd["UseRefDate"].ToString())) obj.UseRefDate = bool.Parse(rd["UseRefDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["MaximumMembership"].ToString())) obj.MaximumMembership = int.Parse(rd["MaximumMembership"].ToString());
                    if (!String.IsNullOrEmpty(rd["ServiceCharge"].ToString())) obj.ServiceCharge = double.Parse(rd["ServiceCharge"].ToString());
                    if (!String.IsNullOrEmpty(rd["CreditOfficerId"].ToString())) obj.CreditOfficerId = int.Parse(rd["CreditOfficerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LimitSavings"].ToString())) obj.LimitSavings = bool.Parse(rd["LimitSavings"].ToString());
                    if (!String.IsNullOrEmpty(rd["LimitLoans"].ToString())) obj.LimitLoans = bool.Parse(rd["LimitLoans"].ToString());
                    if (!String.IsNullOrEmpty(rd["GroupPrefix"].ToString())) obj.GroupPrefix = rd["GroupPrefix"].ToString();
                    if (!String.IsNullOrEmpty(rd["PrevNo"].ToString())) obj.PrevNo = int.Parse(rd["PrevNo"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                  
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditEmployer(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditEmployer",
                "@EmployerId", this.EmployerId,
                "@EmployerCode", this.EmployerCode,
                "@EmployerName", this.EmployerName,
                "@EmployerTel1", this.EmployerTel1,
                "@EmployerTel2", this.EmployerTel2,
                "@EmployerCellNo", this.EmployerCellNo,
                "@EmployerFaxNo", this.EmployerFaxNo,
                "@EmployerEmailAddress", this.EmployerEmailAddress,
                "@EmployerAddress", this.EmployerAddress,
                "@PostalAddress", this.PostalAddress,
                "@EmployerRetirement", this.EmployerRetirement,
                "@NoOfWeek", this.NoOfWeek,
                "@EveryDayOfWeek", this.EveryDayOfWeek,
                "@DateOfMonth", this.DateOfMonth,
                "@UseRefDate", this.UseRefDate,
                "@MaximumMembership", this.MaximumMembership,
                "@ServiceCharge", this.ServiceCharge,
                "@CreditOfficerId", this.CreditOfficerId,
                "@LimitSavings", this.LimitSavings,
                "@LimitLoans", this.LimitLoans,
                "@GroupPrefix", this.GroupPrefix,
                "@PrevNo", this.PrevNo,
                "@IsActive", this.IsActive,
                "@CreatedBy", "Admin",
                 "@MachineName", "USER-PC",
                "@delete", delete);
            if(err=="")
              {
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            return id;
        }


    }
}
