using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace SYSTEMUPGRADEPF.Classes
{
    class Product
    {

        private int _productId = 0;
        private string _description = "";
        private int _productType = 0;
        private bool _isActive = false;

        public int ProductId { get { return _productId; } set { _productId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int ProductType { get { return _productType; } set { _productType = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }



        public string ProductTypeName
        {
            get
            {
                string name = "";
                switch (this.ProductType)
                {
                    case 0:
                        name = "Loan";
                        break;
                    case 1:
                        name = "Savings";
                        break;
                    case 2:
                        name = "Fixed Deposit";
                        break;
                    case 3:
                        name = "Charges";
                        break;
                    case 4:
                        name = "Trade Finance";
                        break;
                }
                return name;
            }
        }


        string err = "";
        public ArrayList GetProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllProduct");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ArrayList GetChargeProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getChargeProduct");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }

        public ArrayList GetSavingsProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllSavingProducts");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ArrayList GetGuaranteeLoanProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getGuaranteeProduct");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ArrayList GetFixedDepositProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_GetOnlyFixedDepositTypes");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ArrayList GetLoanProducts()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanProducts");
            if (err == "")
            {
                while (rd.Read())
                {
                    Product obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public Product GetProduct(int ProductId)
        {
            Product obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getProduct", "@ProductId", ProductId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Product();
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["ProductType"].ToString())) obj.ProductType = int.Parse(rd["ProductType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditProduct(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, " pro_AddEditProduct", "@ProductId", this.ProductId,
                "@Description", this.Description,
                "@ProductType", this.ProductType,
                "@IsActive", this.IsActive,
                "@MachineName", "USER-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);
            if (err == "")
            {

                try
                {

                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    if (rd.Read())
                    {
                        id = int.Parse(rd["Id"].ToString());
                    }
                    try { rd.Close(); }
                    catch {; }

                }

            }
            err = error;
            return id;
        }
    }
}
