using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanApplicationCollateral
    {

        private int _loanApplicationCollateralId = 0;
        private int _loanApplicationId = 0;
        private int _loanTypeCollateralId = 0;
        private string _collateralName = "";
        private string _ownerName = "";
        private string _ownerDocument = "";
        private string _collateralRemarks = "";
        private double _collateralValue = 0;
        private double _forcedValue = 0;
        private DateTime _expiryDate = DateTime.Today;
        private bool _isActive = false;

        public int LoanApplicationCollateralId { get { return _loanApplicationCollateralId; } set { _loanApplicationCollateralId = value; } }
        public int LoanApplicationId { get { return _loanApplicationId; } set { _loanApplicationId = value; } }
        public int LoanTypeCollateralId { get { return _loanTypeCollateralId; } set { _loanTypeCollateralId = value; } }
        public string CollateralName { get { return _collateralName; } set { _collateralName = value; } }
        public string OwnerName { get { return _ownerName; } set { _ownerName = value; } }
        public string OwnerDocument { get { return _ownerDocument; } set { _ownerDocument = value; } }
        public string CollateralRemarks { get { return _collateralRemarks; } set { _collateralRemarks = value; } }
        public double CollateralValue { get { return _collateralValue; } set { _collateralValue = value; } }
        public double ForcedValue { get { return _forcedValue; } set { _forcedValue = value; } }
        public DateTime ExpiryDate { get { return _expiryDate; } set { _expiryDate = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        string err = "";
        public ArrayList GetLoanApplicationCollaterals()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanApplicationCollaterals");
            if(err=="")
            {
                while(rd.Read ())
                {
                    LoanApplicationCollateral obj = new Classes.LoanApplicationCollateral();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationCollateralId"].ToString())) obj.LoanApplicationCollateralId = int.Parse(rd["LoanApplicationCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeCollateralId"].ToString())) obj.LoanTypeCollateralId = int.Parse(rd["LoanTypeCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CollateralName"].ToString())) obj.CollateralName = rd["CollateralName"].ToString();
                    if (!String.IsNullOrEmpty(rd["OwnerName"].ToString())) obj.OwnerName = rd["OwnerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["OwnerDocument"].ToString())) obj.OwnerDocument = rd["OwnerDocument"].ToString();
                    if (!String.IsNullOrEmpty(rd["CollateralRemarks"].ToString())) obj.CollateralRemarks = rd["CollateralRemarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["CollateralValue"].ToString())) obj.CollateralValue = double.Parse(rd["CollateralValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForcedValue"].ToString())) obj.ForcedValue = double.Parse(rd["ForcedValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExpiryDate"].ToString())) obj.ExpiryDate = DateTime.Parse(rd["ExpiryDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public LoanApplicationCollateral  GetLoanApplicationCollateral(int LoanApplicationCollateralId)
        {
            LoanApplicationCollateral obj = null;
           Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoanApplicationCollateral", "@LoanAppplicationCollateralId", LoanApplicationCollateralId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.LoanApplicationCollateral();
                    if (!String.IsNullOrEmpty(rd["LoanApplicationCollateralId"].ToString())) obj.LoanApplicationCollateralId = int.Parse(rd["LoanApplicationCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationId"].ToString())) obj.LoanApplicationId = int.Parse(rd["LoanApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeCollateralId"].ToString())) obj.LoanTypeCollateralId = int.Parse(rd["LoanTypeCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CollateralName"].ToString())) obj.CollateralName = rd["CollateralName"].ToString();
                    if (!String.IsNullOrEmpty(rd["OwnerName"].ToString())) obj.OwnerName = rd["OwnerName"].ToString();
                    if (!String.IsNullOrEmpty(rd["OwnerDocument"].ToString())) obj.OwnerDocument = rd["OwnerDocument"].ToString();
                    if (!String.IsNullOrEmpty(rd["CollateralRemarks"].ToString())) obj.CollateralRemarks = rd["CollateralRemarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["CollateralValue"].ToString())) obj.CollateralValue = double.Parse(rd["CollateralValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForcedValue"].ToString())) obj.ForcedValue = double.Parse(rd["ForcedValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExpiryDate"].ToString())) obj.ExpiryDate = DateTime.Parse(rd["ExpiryDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    
                }
                try { rd.Close(); }
                catch {; }
            }

            return obj;
        }
        public int AddEditLoanApplicationCollateral(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanApplicationCollateral", "@LoanApplicationCollateralId", this.LoanApplicationCollateralId,
"@LoanApplicationId", this.LoanApplicationId,
"@LoanTypeCollateralId", this.LoanTypeCollateralId,
"@CollateralName", this.CollateralName,
"@OwnerName", this.OwnerName,
"@OwnerDocument", this.OwnerDocument,
"@CollateralRemarks", this.CollateralRemarks,
"@CollateralValue", this.CollateralValue,
"@ForcedValue", this.ForcedValue,
"@ExpiryDate", this.ExpiryDate.ToString("yyyyMMdd"),
"@IsActive", this.IsActive,
"@MachineName", "USER-PC",
"@CreatedBy", "Admin",
"@delete", delete
);
            if(err=="")
            {
                if (rd.Read())
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

