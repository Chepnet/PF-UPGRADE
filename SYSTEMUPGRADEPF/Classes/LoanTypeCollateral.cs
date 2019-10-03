using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanTypeCollateral
    {
        private int _loanTypeCollateralId = 0;
        private int _loanTypeId = 0;
        private int _collateralId = 0;
        private bool _isActive = false;
        private string _description = "";
        private string _loandescription = "";

        public int LoanTypeCollateralId { get { return _loanTypeCollateralId; } set { _loanTypeCollateralId = value; } }
        public int LoanTypeId { get { return _loanTypeId; } set { _loanTypeId = value; } }
        public int CollateralId { get { return _collateralId; } set { _collateralId = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string Description { get { return _description; } set { _description = value; } }

        public string LoanName { get { return _loandescription; } set { _loandescription = value; } }

        Collateral oCollateral = new Collateral();
        LoanType oLoanType = new LoanType();

        string err = "";

        public ArrayList GetLTCollaterals()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllLoanTypeCollaterals");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanTypeCollateral obj = new Classes.LoanTypeCollateral();
                    if (!String.IsNullOrEmpty(rd["LoanTypeCollateralId"].ToString())) obj.LoanTypeCollateralId = int.Parse(rd["LoanTypeCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CollateralId"].ToString())) obj.CollateralId = int.Parse(rd["CollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.CollateralId > 0)
                    {
                        Collateral myCollateral = oCollateral.GetCollateral(obj.CollateralId);
                        if (myCollateral != null)
                            obj.Description = myCollateral.Description;
                    }

                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoantype = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoantype != null)
                            obj.LoanName  = myLoantype.LoanTypeName;
                    }
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

        public LoanTypeCollateral GetLTCollateral(int LoanTypeCollateralId)
        {
            LoanTypeCollateral obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getLoanTypeCollateral", "@LoanTypeCollateralId", LoanTypeCollateralId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanTypeCollateral();
                    if (!String.IsNullOrEmpty(rd["LoanTypeCollateralId"].ToString())) obj.LoanTypeCollateralId = int.Parse(rd["LoanTypeCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanTypeId"].ToString())) obj.LoanTypeId = int.Parse(rd["LoanTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CollateralId"].ToString())) obj.CollateralId = int.Parse(rd["CollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.CollateralId > 0)
                    {
                        Collateral myCollateral = oCollateral.GetCollateral(obj.CollateralId);
                        if (myCollateral != null)
                            obj.Description = myCollateral.Description;
                    }
                    if (obj.LoanTypeId > 0)
                    {
                        LoanType myLoantype = oLoanType.GetLoanType(obj.LoanTypeId);
                        if (myLoantype != null)
                            obj.LoanName = myLoantype.LoanTypeName;
                    }

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
        public int AddEditLTCollaterals(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditLoanTypeCollateral",
         "@LoanTypeCollateralId", this.LoanTypeCollateralId,
"@LoanTypeId", this.LoanTypeId,
"@CollateralId", this.CollateralId,
"@IsActive", this.IsActive,
"@MachineName", "NAOMI-PC",
"@CreatedBy", "ADMIN",
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
