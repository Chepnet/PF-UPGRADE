using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Collateral
    {
        private int _collateralId = 0;
        private string _description = "";
        private bool _hasExpiry = false;
        private DateTime _expiryDate = DateTime.Today;
        private bool _isActive = false;
        private double _percentageForcedValue = 0;


        public int CollateralId { get { return _collateralId; } set { _collateralId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool HasExpiry { get { return _hasExpiry; } set { _hasExpiry = value; } }
        public DateTime ExpiryDate { get { return _expiryDate; } set { _expiryDate = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public double PercentageForcedValue { get { return _percentageForcedValue; } set { _percentageForcedValue = value; } }

        string err = "";

        public ArrayList GetCollaterals()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllCollaterals");
            if (err == "")
            {
                while (rd.Read())
                {
                    Collateral obj = new Classes.Collateral();
                    if (!String.IsNullOrEmpty(rd["CollateralId"].ToString())) obj.CollateralId = int.Parse(rd["CollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PercentageForcedValue"].ToString())) obj.PercentageForcedValue = double.Parse(rd["PercentageForcedValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["HasExpiry"].ToString())) obj.HasExpiry = bool.Parse(rd["HasExpiry"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExpiryDate"].ToString())) obj.ExpiryDate = DateTime.Parse(rd["ExpiryDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
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

        public Collateral GetCollateral(int CollateralId)
        {
            Collateral obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getCollateral", "@CollateralId", CollateralId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Collateral();
                    if (!String.IsNullOrEmpty(rd["CollateralId"].ToString())) obj.CollateralId = int.Parse(rd["CollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PercentageForcedValue"].ToString())) obj.PercentageForcedValue = double.Parse(rd["PercentageForcedValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["HasExpiry"].ToString())) obj.HasExpiry = bool.Parse(rd["HasExpiry"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExpiryDate"].ToString())) obj.ExpiryDate = DateTime.Parse(rd["ExpiryDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());



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
        public int AddEditCollaterals(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditCollateral",
            "@CollateralId", this.CollateralId,
             "@PercentageForcedValue",this.PercentageForcedValue, 
            "@Description", this.Description,
            "@HasExpiry", this.HasExpiry,
            "@ExpiryDate",DateTime.Now ,
            "@MachineName", "USER-PC",
            "@IsActive", this.IsActive,
            "@CreatedBy", "Admin",
            "@delete", delete);
            if (err == "")
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