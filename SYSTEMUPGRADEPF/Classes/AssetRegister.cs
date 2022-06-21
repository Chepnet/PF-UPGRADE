using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class AssetRegister
    {
        private int _assetId = 0;
        private int _gLAccountId = 0;
        private int _categoryId = 0;
        private int _subCategoryId = 0;
        private string _name = "";
        private string _serialNo = "";
        private int _creditOfficer = 0;
        private int _depreciationMethod = 0;
        private DateTime _depStartDate = DateTime.Today;
        private double _years = 0;
        private DateTime _depEndDate = DateTime.Today;
        private string _remarks = "";
        private string _accountname = "";
        private string _categoryname = "";
        private string _subcategoryname = "";
        public int AssetId { get { return _assetId; } set { _assetId = value; } }
        public int CategoryId { get { return _categoryId; } set { _categoryId = value; } }
        public int SubCategoryId { get { return _subCategoryId; } set { _subCategoryId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string SerialNo { get { return _serialNo; } set { _serialNo = value; } }
        public int CreditOfficer { get { return _creditOfficer; } set { _creditOfficer = value; } }
        public int DepreciationMethod { get { return _depreciationMethod; } set { _depreciationMethod = value; } }
        public DateTime DepStartDate { get { return _depStartDate; } set { _depStartDate = value; } }
        public double Years { get { return _years; } set { _years = value; } }
        public DateTime DepEndDate { get { return _depEndDate; } set { _depEndDate = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string AccountName { get { return _accountname ; } set { _accountname  = value; } }
        public int GLAccountId { get { return _gLAccountId ; } set { _gLAccountId  = value; } }

        public string CategoryName { get { return _categoryname ; } set { _categoryname  = value; } }
        public string SubCategoryName { get { return _subcategoryname ; } set { _subcategoryname  = value; } }
        AssetCategory oAssetcategory = new AssetCategory();
        AssetSubCategory oSaubassetcategory = new AssetSubCategory();
        Bank oBank = new Bank();



        string err = "";
        public ArrayList GetAssetRegisters()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllAssetRegisters");
            if(err=="")
            {
                while(rd.Read ())
                {
                    AssetRegister obj = new Classes.AssetRegister();
                    if (!String.IsNullOrEmpty(rd["AssetId"].ToString())) obj.AssetId = int.Parse(rd["AssetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SubCategoryId"].ToString())) obj.SubCategoryId = int.Parse(rd["SubCategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["SerialNo"].ToString())) obj.SerialNo = rd["SerialNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["CreditOfficer"].ToString())) obj.CreditOfficer = int.Parse(rd["CreditOfficer"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationMethod"].ToString())) obj.DepreciationMethod = int.Parse(rd["DepreciationMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepStartDate"].ToString())) obj.DepStartDate = DateTime.Parse(rd["DepStartDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Years"].ToString())) obj.Years = double.Parse(rd["Years"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepEndDate"].ToString())) obj.DepEndDate = DateTime.Parse(rd["DepEndDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLAccountId"].ToString())) obj.GLAccountId  = int.Parse(rd["GLAccountId"].ToString());
                    if(obj.GLAccountId >0)
                    {
                        Bank myBank = oBank.GetBank(obj.GLAccountId);
                        if(myBank !=null)
                        {
                            obj.AccountName = myBank.BankName;
                        }
                    }
                    if(obj.CategoryId >0)
                    {
                        AssetCategory myAssetCategory = oAssetcategory.GetAllAssetCategory(obj.CategoryId);
                        if(myAssetCategory !=null)
                        {
                            obj.CategoryName = myAssetCategory.CategoryName;
                        }
                    }
                    if (obj.SubCategoryId  > 0)
                    {
                        AssetSubCategory  myAssetSubCategory = oSaubassetcategory.GetAssetSubCategory (obj.SubCategoryId );
                        if (myAssetSubCategory  != null)
                        {
                            obj.SubCategoryName  = myAssetSubCategory.SubCategoryName ;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public AssetRegister  GetAssetRegister(int AssetRegisterId)
        {
            AssetRegister obj = null; 
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAssetRegister", "@AssetId", AssetRegisterId );
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.AssetRegister();
                    if (!String.IsNullOrEmpty(rd["AssetId"].ToString())) obj.AssetId = int.Parse(rd["AssetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SubCategoryId"].ToString())) obj.SubCategoryId = int.Parse(rd["SubCategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["SerialNo"].ToString())) obj.SerialNo = rd["SerialNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["CreditOfficer"].ToString())) obj.CreditOfficer = int.Parse(rd["CreditOfficer"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationMethod"].ToString())) obj.DepreciationMethod = int.Parse(rd["DepreciationMethod"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepStartDate"].ToString())) obj.DepStartDate = DateTime.Parse(rd["DepStartDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Years"].ToString())) obj.Years = double.Parse(rd["Years"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepEndDate"].ToString())) obj.DepEndDate = DateTime.Parse(rd["DepEndDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["GLAccountId"].ToString())) obj.GLAccountId = int.Parse(rd["GLAccountId"].ToString());
                    if (obj.GLAccountId > 0)
                    {
                        Bank myBank = oBank.GetBank(obj.GLAccountId);
                        if (myBank != null)
                        {
                            obj.AccountName = myBank.BankName;
                        }
                    }

                    if (obj.CategoryId > 0)
                    {
                        AssetCategory myAssetCategory = oAssetcategory.GetAllAssetCategory(obj.CategoryId);
                        if (myAssetCategory != null)
                        {
                            obj.CategoryName = myAssetCategory.CategoryName;
                        }
                    }
                    if (obj.SubCategoryId > 0)
                    {
                        AssetSubCategory myAssetSubCategory = oSaubassetcategory.GetAssetSubCategory(obj.SubCategoryId);
                        if (myAssetSubCategory != null)
                        {
                            obj.SubCategoryName = myAssetSubCategory.SubCategoryName;
                        }
                    }
                }

                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditAssetRegister (bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditAssetRegister", "@AssetId", this.AssetId,
                    "@CategoryId", this.CategoryId,
                    "@SubCategoryId", this.SubCategoryId,
                    "@Name", this.Name,
                    "@SerialNo", this.SerialNo,
                    "@CreditOfficer", this.CreditOfficer,
                    "@DepreciationMethod", this.DepreciationMethod,
                    "@DepStartDate", this.DepStartDate,
                    "@Years", this.Years,
                    "@DepEndDate", this.DepEndDate,
                    "@Remarks", this.Remarks,
                     "@GLAccountId", this.GLAccountId ,
                    "@IsActive", "0",
                    "@MachineName", "USER-PC",
                    "@CreatedBy", "ADMIN",
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
