using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Item
    {
        private int _itemId = 0;
        private int _itemType = 0;
        private string _itemName = "";
        private string _description = "";
        private string _itemcode = "";
        private double _rate = 0;
        private int _taxCode = 0;
        private int _GlId = 0;

        public int ItemId { get { return _itemId; } set { _itemId = value; } }
        public int ItemType { get { return _itemType; } set { _itemType = value; } }
        public string ItemName { get { return _itemName; } set { _itemName = value; } }
        public string ItemCode { get { return _itemcode ; } set { _itemcode  = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public double Rate { get { return _rate; } set { _rate = value; } }
        public int TaxCode { get { return _taxCode; } set { _taxCode = value; } }
        public int GLId { get { return _GlId; } set { _GlId = value; } }
        string err = "";
        public ArrayList GetItems()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllItems");
            if(err=="")
            {
                while (rd.Read ())
                {
                    Item obj = new Classes.Item();
                    if (!String.IsNullOrEmpty(rd["ItemId"].ToString())) obj.ItemId = int.Parse(rd["ItemId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ItemType"].ToString())) obj.ItemType = int.Parse(rd["ItemType"].ToString());
                    if (!String.IsNullOrEmpty(rd["ItemCode"].ToString())) obj.ItemCode = rd["ItemCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ItemName"].ToString())) obj.ItemName = rd["ItemName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["Rate"].ToString())) obj.Rate = double.Parse(rd["Rate"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxCode"].ToString())) obj.TaxCode = int.Parse(rd["TaxCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId  = int.Parse(rd["GLId"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public Item  GetItem(int ItemId)
        {
            Item obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getItem", "@ItemId", ItemId );
            if (err == "")
            {
                if  (rd.Read())
                {
                     obj = new Classes.Item();
                    
                    if (!String.IsNullOrEmpty(rd["ItemId"].ToString())) obj.ItemId = int.Parse(rd["ItemId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ItemType"].ToString())) obj.ItemType = int.Parse(rd["ItemType"].ToString());
                    if (!String.IsNullOrEmpty(rd["ItemCode"].ToString())) obj.ItemCode = rd["ItemCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["ItemName"].ToString())) obj.ItemName = rd["ItemName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["Rate"].ToString())) obj.Rate = double.Parse(rd["Rate"].ToString());
                    if (!String.IsNullOrEmpty(rd["TaxCode"].ToString())) obj.TaxCode = int.Parse(rd["TaxCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["GLId"].ToString())) obj.GLId = int.Parse(rd["GLId"].ToString());

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj ;
        }
        public int AddEditItem(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditItem", "@ItemId", this.ItemId,
                "@ItemType", this.ItemType,
                "@ItemName", this.ItemName,
                "@ItemCode", this.ItemCode,
                "@Description", this.Description,
                "@Rate", this.Rate,
                "@TaxCode", this.TaxCode,
                "@GLId", this.GLId,
                "@IsActive", "0",
                "@MachineName", "USER-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);
            if(err=="")
            {
                if (rd.Read())
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
