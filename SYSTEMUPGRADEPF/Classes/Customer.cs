using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Customer
    {

        private int _customerId = 0;
        private string _customerNo = "";
        private string _customerName = "";
        private int _salesPersonId = 0;
        private bool _isVendor = false;
        private bool _isActive = false;
        private string _address = "";
        private string _address2 = "";
        private string _mobileNo = "";
        private string _telephone1 = "";
        private string _telephone2 = "";
        private string _postalCode = "";
        private string _city = "";
        private string _county = "";
        private int _defaultCurrencyId = 0;
        private string _contactPersonName = "";
        private string _email = "";
        private string _homePage = "";
        private string _machinename = "";

        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string CustomerNo { get { return _customerNo; } set { _customerNo = value; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }
        public int SalesPersonId { get { return _salesPersonId; } set { _salesPersonId = value; } }
        public bool IsVendor { get { return _isVendor; } set { _isVendor = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Address2 { get { return _address2; } set { _address2 = value; } }
        public string MobileNo { get { return _mobileNo; } set { _mobileNo = value; } }
        public string Telephone1 { get { return _telephone1; } set { _telephone1 = value; } }
        public string Telephone2 { get { return _telephone2; } set { _telephone2 = value; } }
        public string PostalCode { get { return _postalCode; } set { _postalCode = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string County { get { return _county; } set { _county = value; } }
        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public string ContactPersonName { get { return _contactPersonName; } set { _contactPersonName = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string HomePage { get { return _homePage; } set { _homePage = value; } }
        public string MachineName { get { return _machinename ; } set { _machinename  = value; } }


        string error = "";
        public ArrayList GetCustomers()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_getAllCustomers");
            if (error == "")
            {
                while (rd.Read())
                {
                    Customer obj = new Classes.Customer();
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerNo"].ToString())) obj.CustomerNo = rd["CustomerNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["CustomerName"].ToString())) obj.CustomerName = rd["CustomerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["SalesPersonId"].ToString())) obj.SalesPersonId = int.Parse(rd["SalesPersonId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsVendor"].ToString())) obj.IsVendor = bool.Parse(rd["IsVendor"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["Address"].ToString())) obj.Address = rd["Address"].ToString();
                    if (!String.IsNullOrEmpty(rd["Address2"].ToString())) obj.Address2 = rd["Address2"].ToString();
                    if (!String.IsNullOrEmpty(rd["MobileNo"].ToString())) obj.MobileNo = rd["MobileNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["Telephone1"].ToString())) obj.Telephone1 = rd["Telephone1"].ToString();
                    if (!String.IsNullOrEmpty(rd["Telephone2"].ToString())) obj.Telephone2 = rd["Telephone2"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalCode"].ToString())) obj.PostalCode = rd["PostalCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["City"].ToString())) obj.City = rd["City"].ToString();
                    if (!String.IsNullOrEmpty(rd["County"].ToString())) obj.County = rd["County"].ToString();
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContactPersonName"].ToString())) obj.ContactPersonName = rd["ContactPersonName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Email"].ToString())) obj.Email = rd["Email"].ToString();
                    if (!String.IsNullOrEmpty(rd["HomePage"].ToString())) obj.HomePage = rd["HomePage"].ToString();

                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }

            return myList;

        }
        public Customer  GetCustomer(int CustomerId)
        {
            Customer obj = null;  
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_getCustomer", "@CustomerId",CustomerId );
            if (error == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Customer();
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerNo"].ToString())) obj.CustomerNo = rd["CustomerNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["CustomerName"].ToString())) obj.CustomerName = rd["CustomerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["SalesPersonId"].ToString())) obj.SalesPersonId = int.Parse(rd["SalesPersonId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsVendor"].ToString())) obj.IsVendor = bool.Parse(rd["IsVendor"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["Address"].ToString())) obj.Address = rd["Address"].ToString();
                    if (!String.IsNullOrEmpty(rd["Address2"].ToString())) obj.Address2 = rd["Address2"].ToString();
                    if (!String.IsNullOrEmpty(rd["MobileNo"].ToString())) obj.MobileNo = rd["MobileNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["Telephone1"].ToString())) obj.Telephone1 = rd["Telephone1"].ToString();
                    if (!String.IsNullOrEmpty(rd["Telephone2"].ToString())) obj.Telephone2 = rd["Telephone2"].ToString();
                    if (!String.IsNullOrEmpty(rd["PostalCode"].ToString())) obj.PostalCode = rd["PostalCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["City"].ToString())) obj.City = rd["City"].ToString();
                    if (!String.IsNullOrEmpty(rd["County"].ToString())) obj.County = rd["County"].ToString();
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ContactPersonName"].ToString())) obj.ContactPersonName = rd["ContactPersonName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Email"].ToString())) obj.Email = rd["Email"].ToString();
                    if (!String.IsNullOrEmpty(rd["HomePage"].ToString())) obj.HomePage = rd["HomePage"].ToString();

                   
                }
                try { rd.Close(); }
                catch {; }
            }

            return obj;

        }
        public int AddEditCustomer(bool delete,ref string err)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditCustomer", "@CustomerId", this.CustomerId,
                            "@CustomerNo", this.CustomerNo,
                            "@CustomerName", this.CustomerName,
                            "@SalesPersonId", this.SalesPersonId,
                            "@IsVendor", this.IsVendor,
                            "@IsActive", this.IsActive,
                            "@Address", this.Address,
                            "@Address2", this.Address2,
                            "@MobileNo", this.MobileNo,
                            "@Telephone1", this.Telephone1,
                            "@Telephone2", this.Telephone2,
                            "@PostalCode", this.PostalCode,
                            "@City", this.City,
                            "@County", this.County,
                            "@DefaultCurrencyId", this.DefaultCurrencyId,
                            "@ContactPersonName", this.ContactPersonName,
                            "@Email", this.Email,
                            "@HomePage", this.HomePage,
                            "@CreatedBy", "ADMIN",
                            "@MachineName", "USER-PC",
                            "@delete", delete);
                 if(error =="")
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
    }
}

