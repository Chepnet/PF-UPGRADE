using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class AssetSubCategory
    {
        private int _assetSubCategoryId = 0;
        private int _categoryId = 0;
        private string _subCategoryName = "";
        private string _remarks = "";
        private string _categoryname = "";

        public int AssetSubCategoryId { get { return _assetSubCategoryId; } set { _assetSubCategoryId = value; } }
        public int CategoryId { get { return _categoryId; } set { _categoryId = value; } }
        public string SubCategoryName { get { return _subCategoryName; } set { _subCategoryName = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string CategoryName { get { return _categoryname ; } set { _categoryname  = value; } }
        AssetCategory oAssetCategory = new AssetCategory();
        string err = "";

        public ArrayList GetAssetSubCategories()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllAssetSubCategory");
            if(err=="")
            {
                while(rd.Read ())
                {
                    AssetSubCategory obj = new Classes.AssetSubCategory();
                    if (!String.IsNullOrEmpty(rd["AssetSubCategoryId"].ToString())) obj.AssetSubCategoryId = int.Parse(rd["AssetSubCategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SubCategoryName"].ToString())) obj.SubCategoryName = rd["SubCategoryName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();

                    if (obj.CategoryId > 0)
                    {
                        AssetCategory myAssetCategory = oAssetCategory.GetAllAssetCategory(obj.CategoryId);
                        if (myAssetCategory != null)
                            obj.CategoryName = myAssetCategory.CategoryName;
                    }
                       
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }


        public AssetSubCategory  GetAssetSubCategory(int AssetSubCategoryId)
        {
            AssetSubCategory obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAssetSubCategory", "@AssetSubCategoryId", AssetSubCategoryId );
            if (err == "")
            {
                if  (rd.Read())
                {
                    obj = new Classes.AssetSubCategory();
                    if (!String.IsNullOrEmpty(rd["AssetSubCategoryId"].ToString())) obj.AssetSubCategoryId = int.Parse(rd["AssetSubCategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CategoryId"].ToString())) obj.CategoryId = int.Parse(rd["CategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SubCategoryName"].ToString())) obj.SubCategoryName = rd["SubCategoryName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();

                    if (obj.CategoryId > 0)
                    {
                        AssetCategory myAssetCategory = oAssetCategory.GetAllAssetCategory(obj.CategoryId);
                        if (myAssetCategory != null)
                            obj.CategoryName = myAssetCategory.CategoryName;
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj ;
        }
        public int AddEditAssetSubCategory(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditAssetSubCategory", "@AssetSubCategoryId", this.AssetSubCategoryId,
                "@CategoryId", this.CategoryId,
                "@SubCategoryName", this.SubCategoryName,
                "@Remarks", this.Remarks,
                "@CreatedBy", "Admin",
                "@delete ", delete);
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
