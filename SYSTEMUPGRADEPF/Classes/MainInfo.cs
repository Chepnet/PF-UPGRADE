using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace SYSTEMUPGRADEPF.Classes
{
    class MainInfo
    {
        private int _companyId = 0;
        private string _companyName = "";
        private DateTime _prevSODDate =DateTime.Today ;
        private DateTime _prevEODDate = DateTime.Today;
        private int _interestId = 0;
        private int _loanId = 0;
        private DateTime _transDate = DateTime.Today;
        private double _interestAmount = 0;
        private double _interestRate = 0;
        private int _interestPayMethod = 0;
        private int _interestPostingFrequency = 0;
        private int _calculationFormula = 0;
        private int _dailyRateSpecification = 0;
        private double _loanBalance = 0;



        public int CompanyId { get { return _companyId; } set { _companyId = value; } }
        public string CompanyName { get { return _companyName; } set { _companyName = value; } }
        public DateTime PrevSODDate { get { return _prevSODDate; } set { _prevSODDate = value; } }
        public DateTime PrevEODDate { get { return _prevEODDate; } set { _prevEODDate = value; } }
        public int InterestId { get { return _interestId; } set { _interestId = value; } }
        public int LoanId { get { return _loanId; } set { _loanId = value; } }
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public double InterestAmount { get { return _interestAmount; } set { _interestAmount = value; } }
        public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        public int InterestPayMethod { get { return _interestPayMethod; } set { _interestPayMethod = value; } }
        public int InterestPostingFrequency { get { return _interestPostingFrequency; } set { _interestPostingFrequency = value; } }
        public int CalculationFormula { get { return _calculationFormula; } set { _calculationFormula = value; } }
        public int DailyRateSpecification { get { return _dailyRateSpecification; } set { _dailyRateSpecification = value; } }
        public double LoanBalance { get { return _loanBalance; } set { _loanBalance = value; } }


        string err = "";
        public MainInfo  GetMainInfo(int CompanyId)
        {
            MainInfo obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMainInfo", "@CompanyId", CompanyId);
            if(err=="")
            {
                if(rd.Read ())
                {
                    obj = new Classes.MainInfo();
                    if (!String.IsNullOrEmpty(rd["CompanyId"].ToString())) obj.CompanyId = int.Parse(rd["CompanyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CompanyName"].ToString())) obj.CompanyName = rd["CompanyName"].ToString();
                    if (!String.IsNullOrEmpty(rd["PrevSODDate"].ToString())) obj.PrevSODDate = DateTime.Parse(rd["PrevSODDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrevEODDate"].ToString())) obj.PrevEODDate = DateTime.Parse(rd["PrevEODDate"].ToString());

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;

        }
        public ArrayList  GetMainInfos()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllMainInfos");
            if (err == "")
            {
                while (rd.Read())
                {
                   MainInfo  obj = new Classes.MainInfo();
                    if (!String.IsNullOrEmpty(rd["CompanyId"].ToString())) obj.CompanyId = int.Parse(rd["CompanyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CompanyName"].ToString())) obj.CompanyName = rd["CompanyName"].ToString();
                    if (!String.IsNullOrEmpty(rd["PrevSODDate"].ToString())) obj.PrevSODDate = DateTime.Parse(rd["PrevSODDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["PrevEODDate"].ToString())) obj.PrevEODDate = DateTime.Parse(rd["PrevEODDate"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList ;

        }
        public int AddEditMainInfo(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditMainInfo", "@CompanyId", this.CompanyId,
             "@PrevSODDate", this.PrevSODDate,
             "@CompanyName", this.CompanyName ,
            "@PrevEODDate", this.PrevEODDate,
            "@CreatedBy", "Admin");

            if (err == "")
            {
                if (rd.Read())
                {

                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            return id;

        }

      

             public int AddEditLoanInterest(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanInterestTest", "@transDate", this.PrevSODDate    );
            
            if (err == "")
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
        public int CalculatePenalty(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_CalculatePenalty", "@transDate", this.PrevSODDate );

            if (err == "")
            {
                if (rd.Read())
                {

                    //id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }

            err = error;
            return id;

        }
        public int AddEditLoanDues(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoansDue", "@TransDate", this.PrevSODDate   );

            if (err == "")
            {
                if (rd.Read())
                {
                   // id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }

            err = error;
            return id;

        }
        public int GetLoanArrears(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_LoadLoanArrears", "@TransDate", this.PrevSODDate );

            if (err == "")
            {
                if (rd.Read())
                {
                  // id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }

            err = error;
            return id;

        }
        public int AddEditLoanAmortizationInterest(  ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            ArrayList mylist = new ArrayList();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_CalculateInterestAmortization", "@transDate", this.PrevEODDate ,
                "@interestid", this.InterestId ,
                "@LoanId", this.LoanId,
                "@InterestAmount", this.InterestAmount,
                "@InterestRate", this.InterestRate,
                "@InterestPayMethod", this.InterestPayMethod,
                "@InterestPostingFrequency", this.InterestPostingFrequency,
                "@CalculationFormula", this.CalculationFormula,
                "@DailyRateSpecification", this.DailyRateSpecification,
                "@LoanBalance", this.LoanBalance ,
                "@CreatedBy", "Zippy"
                );
            
            if (err == "")
            {
                try
                {

                }
                catch (SqlException ex) when (ex.Number == 547)
                {
                    if (rd.Read())
                    {
                        id = int.Parse(rd["Id"].ToString());
                    }
                    try { rd.Close(); }
                    catch {; }

                }
            }
            error = err;
            return id;

        }
      


    }
}
