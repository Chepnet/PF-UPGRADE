using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class AssetCategory
    {
        private int _categoryId = 0;
        private string _categoryName = "";
        private string _categoryPrefix = "";
        private int _originalCostGLId = 0;
        private int _accumulatedDepreciationGLId = 0;
        private int _annualDepreciationGLId = 0;
        private int _depreciationMethodId = 0;
        private double _depreciationPercentage = 0;
        private string _remarks = "";
        private double _rounding = 0;
        private string _accountName = "";
        private string _accountNamedepreciation = "";
        public int CategoryId { get { return _categoryId; } set { _categoryId = value; } }
        public string CategoryName { get { return _categoryName; } set { _categoryName = value; } }
        public string CategoryPrefix { get { return _categoryPrefix; } set { _categoryPrefix = value; } }
        public int OriginalCostGLId { get { return _originalCostGLId; } set { _originalCostGLId = value; } }
        public int AccumulatedDepreciationGLId { get { return _accumulatedDepreciationGLId; } set { _accumulatedDepreciationGLId = value; } }
        public int AnnualDepreciationGLId { get { return _annualDepreciationGLId; } set { _annualDepreciationGLId = value; } }
        public int DepreciationMethodId { get { return _depreciationMethodId; } set { _depreciationMethodId = value; } }
        public double DepreciationPercentage { get { return _depreciationPercentage; } set { _depreciationPercentage = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string AccountName { get { return _accountName ; } set { _accountName  = value; } }
        public string AccountNameDepre { get { return _accountNamedepreciation ; } set { _accountNamedepreciation  = value; } }
        public double Rounding { get { return _rounding; } set { _rounding = value; } }
        ChartOfAccount oChartOfAccount = new ChartOfAccount();

        string err = "";
        public ArrayList GetAllAssetCategories()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllAssetCategories");
            if(err=="")
            {
                while(rd.Read ())
                {
                    AssetCategory obj = new Classes.AssetCategory();
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryName"].ToString())) obj.CategoryName = rd["CategoryName"].ToString();
                    if (!String.IsNullOrEmpty(rd["CategoryPrefix"].ToString())) obj.CategoryPrefix = rd["CategoryPrefix"].ToString();
                    if (!String.IsNullOrEmpty(rd["OriginalCostGLId"].ToString())) obj.OriginalCostGLId = int.Parse(rd["OriginalCostGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccumulatedDepreciationGLId"].ToString())) obj.AccumulatedDepreciationGLId = int.Parse(rd["AccumulatedDepreciationGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AnnualDepreciationGLId"].ToString())) obj.AnnualDepreciationGLId = int.Parse(rd["AnnualDepreciationGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationMethodId"].ToString())) obj.DepreciationMethodId = int.Parse(rd["DepreciationMethodId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationPercentage"].ToString())) obj.DepreciationPercentage = double.Parse(rd["DepreciationPercentage"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["Rounding"].ToString())) obj.Rounding = double.Parse(rd["Rounding"].ToString());
                    if(obj.OriginalCostGLId >0)
                    {
                        ChartOfAccount myChartofAccount = oChartOfAccount.GetChartOfAccount(obj.OriginalCostGLId);
                        if (myChartofAccount != null)
                            obj.AccountName = myChartofAccount.AccountName;
                    }
                    if (obj.AnnualDepreciationGLId  > 0)
                    {
                        ChartOfAccount myChartofAccount = oChartOfAccount.GetChartOfAccount(obj.AnnualDepreciationGLId );
                        if (myChartofAccount != null)
                            obj.AccountNameDepre  = myChartofAccount.AccountName;
                    }

                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public AssetCategory  GetAllAssetCategory(int CategoryId )
        {
            AssetCategory obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAssetCategory", "@CategoryId", CategoryId);
            if (err == "")
            {
                if  (rd.Read())
                {
                    obj = new Classes.AssetCategory();
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryName"].ToString())) obj.CategoryName = rd["CategoryName"].ToString();
                    if (!String.IsNullOrEmpty(rd["CategoryPrefix"].ToString())) obj.CategoryPrefix = rd["CategoryPrefix"].ToString();
                    if (!String.IsNullOrEmpty(rd["OriginalCostGLId"].ToString())) obj.OriginalCostGLId = int.Parse(rd["OriginalCostGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AccumulatedDepreciationGLId"].ToString())) obj.AccumulatedDepreciationGLId = int.Parse(rd["AccumulatedDepreciationGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AnnualDepreciationGLId"].ToString())) obj.AnnualDepreciationGLId = int.Parse(rd["AnnualDepreciationGLId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationMethodId"].ToString())) obj.DepreciationMethodId = int.Parse(rd["DepreciationMethodId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DepreciationPercentage"].ToString())) obj.DepreciationPercentage = double.Parse(rd["DepreciationPercentage"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["Rounding"].ToString())) obj.Rounding = double.Parse(rd["Rounding"].ToString());
                    if (obj.OriginalCostGLId > 0)
                    {
                        ChartOfAccount myChartofAccount = oChartOfAccount.GetChartOfAccount(obj.OriginalCostGLId);
                        if (myChartofAccount != null)
                            obj.AccountName = myChartofAccount.AccountName;
                    }
                    if (obj.AnnualDepreciationGLId > 0)
                    {
                        ChartOfAccount myChartofAccount = oChartOfAccount.GetChartOfAccount(obj.AnnualDepreciationGLId);
                        if (myChartofAccount != null)
                            obj.AccountNameDepre = myChartofAccount.AccountName;
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj ;
        }
        public int AddEditAssetCategory(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditAssetCategory", "@CategoryId", this.CategoryId,
                "@CategoryName", this.CategoryName,
                "@CategoryPrefix", this.CategoryPrefix,
                "@OriginalCostGLId", this.OriginalCostGLId,
                "@AccumulatedDepreciationGLId", this.AccumulatedDepreciationGLId,
                "@AnnualDepreciationGLId", this.AnnualDepreciationGLId,
                "@DepreciationMethodId", this.DepreciationMethodId,
                "@DepreciationPercentage", this.DepreciationPercentage,
                "@Remarks", this.Remarks,
                "@Rounding", this.Rounding,
                "@delete", delete,
                "@CreatedBy", "ADMIN");
            if(err=="")
            {
                if(rd.Read())
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
