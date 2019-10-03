using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
namespace SYSTEMUPGRADEPF.Classes
{
    class LoanCategory
    {
        private int _loanCategoryId = 0;
        private string _description = "";
        private bool _isActive = false;


        public int LoanCategoryId { get { return _loanCategoryId; } set { _loanCategoryId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        string err = "";
        public ArrayList GetLoanCategories()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanCategories");
            if(err=="")
            {
                while(rd.Read ())
                {
                    LoanCategory obj = new Classes.LoanCategory();
                    if (!String.IsNullOrEmpty(rd["LoanCategoryId"].ToString())) obj.LoanCategoryId = int.Parse(rd["LoanCategoryId"].ToString());
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
        public LoanCategory  GetLoanCategory(int LoanCategoryId)
        {
            LoanCategory  obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoanCategory", "@LoanCategoryId", LoanCategoryId );
            if (err == "")
            {


                if (rd.Read())
                {
                    obj = new Classes.LoanCategory ();
                    if (!String.IsNullOrEmpty(rd["LoanCategoryId"].ToString())) obj.LoanCategoryId  = int.Parse(rd["LoanCategoryId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description  = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());


                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
       
        public int AddEditLoanCategory(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditLoanCategory", "@LoanCategoryId", this.LoanCategoryId,
                "@Description", this.Description,
                "@IsActive", this.IsActive,
                "@MachineName", "USER-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);
            if(err=="")
            {
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            error =err;
            return id;
        }
    }
}
