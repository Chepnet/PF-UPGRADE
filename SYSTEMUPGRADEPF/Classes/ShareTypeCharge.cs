using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Xml;
using System.Net.Mime;

namespace SYSTEMUPGRADEPF.Classes
{
    class ShareTypeCharge
    {

        private int _shareTypeChargeId = 0;
        private int _sharetypeId = 0;
        private int _productId = 0;
        private int _chargetypeId = 0;
        private string _shareCode = "";
        private string _description = "";
        private int _gLCode = 0;
        private double _amount = 0;
        private double _lowerLimit = 0;
        private double _upperLimit = 0;
        private bool _isPercentageOfTransactionAmount = false;
        private bool _deductedAtImportReg = false;
        private bool _isActive = false;

        private string _shareTypeDescription = "";
        private string _accountName = "";
        private string _productdescrption = "";
        //public ContactPerson(string in_Name, ContactNo in_No);
        
       
        public int ShareTypeChargeId { get { return _shareTypeChargeId; } set { _shareTypeChargeId = value; } }
        public int ShareTypeId { get { return _sharetypeId; } set { _sharetypeId = value; } }
        public int ProductId { get { return _productId; } set { _productId = value; } }
        public int ChargeTypeId { get { return _chargetypeId; } set { _chargetypeId = value; } }
        public string ShareCode { get { return _shareCode; } set { _shareCode = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int GLCode { get { return _gLCode; } set { _gLCode = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public double LowerLimit { get { return _lowerLimit; } set { _lowerLimit = value; } }
        public double UpperLimit { get { return _upperLimit; } set { _upperLimit = value; } }
        public bool IsPercentageOfTransactionAmount { get { return _isPercentageOfTransactionAmount; } set { _isPercentageOfTransactionAmount = value; } }
        public bool DeductedAtImportReg { get { return _deductedAtImportReg; } set { _deductedAtImportReg = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string ShareTypeDescription { get { return _shareTypeDescription; } set { _shareTypeDescription = value; } }
        public string ProductDescription { get { return _productdescrption; } set { _productdescrption = value; } }

        ShareType oShareType = new ShareType();
        public string AccountName { get { return _accountName; } set { _accountName = value; } }

        ChartOfAccount oChartOfAccount = new ChartOfAccount();
        Product oProduct = new Product();
        public string ChargeTypeName { get
            {
                string name = "";
                switch (this.ChargeTypeId )
                {
                    case 0:
                        name = "Overdraft";
                        break;
                    case 1:
                        name = "Defaulter Settings";
                        break;
                    case 2:
                        name = " Standing Order";
                        break;
                    case 3:
                        name = "STO Penalty";
                        break;
                    case 4:
                        name = " Un - Cleared Effects";
                        break;
                    case 5:
                        name = "Mobile Tax";
                        break;
                    case 6:
                        name = "Notifications";
                        break;





                       
  
  
                }
                return name;

            } }

         

        string err="";
        public ArrayList GetShareTypeCharges()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllShareTypeCharges");
            if(err=="")
            {
                while(rd.Read ())
                {
                    ShareTypeCharge obj = new Classes.ShareTypeCharge();
                    if (!String.IsNullOrEmpty(rd["ShareTypeChargeId"].ToString())) obj.ShareTypeChargeId = int.Parse(rd["ShareTypeChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeTypeId"].ToString())) obj.ChargeTypeId  = int.Parse(rd["ChargeTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareCode"].ToString())) obj.ShareCode = rd["ShareCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLCode"].ToString())) obj.GLCode = int.Parse(rd["GLCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPercentageOfTransactionAmount"].ToString())) obj.IsPercentageOfTransactionAmount = bool.Parse(rd["IsPercentageOfTransactionAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DeductedAtImportReg"].ToString())) obj.DeductedAtImportReg = bool.Parse(rd["DeductedAtImportReg"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.ShareTypeId >0)
                    {
                        ShareType myShareType = oShareType.GetShareType(obj.ShareTypeId);
                        if (myShareType != null)
                        { 
                            obj.ShareTypeDescription = myShareType.Description;
                        }
                    }
                    if(obj.GLCode >0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.GLCode);
                        if(myChartOfAccount !=null )
                        {
                            obj.AccountName = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.ProductId  > 0)
                    {
                        Product  myProduct = oProduct .GetProduct (obj.ProductId );
                        if (myProduct != null)
                        {
                            obj.ProductDescription  = myProduct.Description ;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }

        public ArrayList GetShareTypeChargexml()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllShareTypeCharges");
            if (err == "")
            {
                while (rd.Read())
                {
                    ShareTypeCharge obj = new Classes.ShareTypeCharge();
                    if (!String.IsNullOrEmpty(rd["ShareTypeChargeId"].ToString())) obj.ShareTypeChargeId = int.Parse(rd["ShareTypeChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeTypeId"].ToString())) obj.ChargeTypeId = int.Parse(rd["ChargeTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareCode"].ToString())) obj.ShareCode = rd["ShareCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLCode"].ToString())) obj.GLCode = int.Parse(rd["GLCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPercentageOfTransactionAmount"].ToString())) obj.IsPercentageOfTransactionAmount = bool.Parse(rd["IsPercentageOfTransactionAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DeductedAtImportReg"].ToString())) obj.DeductedAtImportReg = bool.Parse(rd["DeductedAtImportReg"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.ShareTypeId > 0)
                    {
                        ShareType myShareType = oShareType.GetShareType(obj.ShareTypeId);
                        if (myShareType != null)
                        {
                            obj.ShareTypeDescription = myShareType.Description;
                        }
                    }
                    if (obj.GLCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.GLCode);
                        if (myChartOfAccount != null)
                        {
                            obj.AccountName = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }
                    }
                   
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ShareTypeCharge  GetShareCharge(int ShareTypeChargeId)
        {
            ShareTypeCharge obj = null;
           Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getShareTypeCharge", "@ShareTypeChargeId",ShareTypeChargeId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.ShareTypeCharge();
                    if (!String.IsNullOrEmpty(rd["ShareTypeChargeId"].ToString())) obj.ShareTypeChargeId = int.Parse(rd["ShareTypeChargeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareTypeId"].ToString())) obj.ShareTypeId = int.Parse(rd["ShareTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ChargeTypeId"].ToString())) obj.ChargeTypeId = int.Parse(rd["ChargeTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ProductId"].ToString())) obj.ProductId = int.Parse(rd["ProductId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ShareCode"].ToString())) obj.ShareCode = rd["ShareCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLCode"].ToString())) obj.GLCode = int.Parse(rd["GLCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["LowerLimit"].ToString())) obj.LowerLimit = double.Parse(rd["LowerLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["UpperLimit"].ToString())) obj.UpperLimit = double.Parse(rd["UpperLimit"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsPercentageOfTransactionAmount"].ToString())) obj.IsPercentageOfTransactionAmount = bool.Parse(rd["IsPercentageOfTransactionAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DeductedAtImportReg"].ToString())) obj.DeductedAtImportReg = bool.Parse(rd["DeductedAtImportReg"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.ShareTypeId > 0)
                    {
                        ShareType myShareType = oShareType.GetShareType(obj.ShareTypeId);
                        if (myShareType != null)
                        {

                        
                            obj.ShareTypeDescription = myShareType.Description;
                        }
                    }
                    if (obj.GLCode > 0)
                    {
                        ChartOfAccount myChartOfAccount = oChartOfAccount.GetChartOfAccount(obj.GLCode);
                        if (myChartOfAccount != null)
                        {
                            obj.AccountName = myChartOfAccount.AccountName;
                        }
                    }
                    if (obj.ProductId > 0)
                    {
                        Product myProduct = oProduct.GetProduct(obj.ProductId);
                        if (myProduct != null)
                        {
                            obj.ProductDescription = myProduct.Description;
                        }
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditShareCharge(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditShareTypeCharge",
                "@ShareTypeChargeId", this.ShareTypeChargeId,
                "@ShareTypeId", this.ShareTypeId,
                "@ChargeTypeId", this.ChargeTypeId ,
                "@ProductId", this.ProductId,
                "@ShareTypeCode", this.ShareCode,
                "@Description", this.Description,
                "@GLCode", this.GLCode,
                "@Amount", this.Amount,
                "@LowerLimit", this.LowerLimit,
                "@UpperLimit", this.UpperLimit,
                "@IsPercentageOfTransactionAmount", this.IsPercentageOfTransactionAmount,
                "@DeductedAtImportReg", this.DeductedAtImportReg,
                "@IsActive", this.IsActive,
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
    }
}
