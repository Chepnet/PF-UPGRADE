using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class LoanPurpose
    {
        
        private int _loanPurposeId = 0;
        private string _description = "";
        private bool _isActive = false;

        
        public int LoanPurposeId { get { return _loanPurposeId; } set { _loanPurposeId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }


        string err = "";

        public ArrayList GetLoanPurposes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getAllLoanPurpose");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanPurpose obj = new Classes.LoanPurpose();
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
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

        public LoanPurpose GetLoanPurpose(int LoanPurposeId)
        {
            LoanPurpose obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getLoanPurpose", "@LoanPurposeId", LoanPurposeId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanPurpose();
                    if (!String.IsNullOrEmpty(rd["LoanPurposeId"].ToString())) obj.LoanPurposeId = int.Parse(rd["LoanPurposeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;
        }

        public int AddEditLoanPurpose(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "Proc_AddEditLoanPurpose",
             "@LoanPurposeId", this.LoanPurposeId,
             "@Description", this.Description,
             "@IsActive", this.IsActive,
                "@MachineName", "Naomi-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            error = err;
            return id;
        }
    }
}
