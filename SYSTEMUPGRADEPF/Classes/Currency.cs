using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Currency
    {



        private int _currencyId = 0;
        private string _code = "";
        private string _name = "";
        private string _symbol = "";
        private bool _isDefaultCurrency = false;
        private int _unRealisedGainGLs = 0;
        private int _realisedGainGLs = 0;
        private int _unRealisedLossGLs = 0;
        private int _realisedLossGLs = 0;
        private double _roundingPrecision = 0;
        private int _roundingType = 0;
        private bool _isActive = false;


        public int CurrencyId { get { return _currencyId; } set { _currencyId = value; } }
        public string Code { get { return _code; } set { _code = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Symbol { get { return _symbol; } set { _symbol = value; } }
        public bool IsDefaultCurrency { get { return _isDefaultCurrency; } set { _isDefaultCurrency = value; } }
        public int UnRealisedGainGLs { get { return _unRealisedGainGLs; } set { _unRealisedGainGLs = value; } }
        public int RealisedGainGLs { get { return _realisedGainGLs; } set { _realisedGainGLs = value; } }
        public int UnRealisedLossGLs { get { return _unRealisedLossGLs; } set { _unRealisedLossGLs = value; } }
        public int RealisedLossGLs { get { return _realisedLossGLs; } set { _realisedLossGLs = value; } }
        public double RoundingPrecision { get { return _roundingPrecision; } set { _roundingPrecision = value; } }
        public int RoundingType { get { return _roundingType; } set { _roundingType = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        string err = "";
        public ArrayList GetCurrencies()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllCurrencies");
              if(err=="")
            {
                while(rd.Read())
                {
                    Currency obj = new Classes.Currency();
                    if (!String.IsNullOrEmpty(rd["CurrencyId"].ToString())) obj.CurrencyId = int.Parse(rd["CurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Code"].ToString())) obj.Code = rd["Code"].ToString();
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["Symbol"].ToString())) obj.Symbol = rd["Symbol"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsDefaultCurrency"].ToString())) obj.IsDefaultCurrency = bool.Parse(rd["IsDefaultCurrency"].ToString());
                    if (!String.IsNullOrEmpty(rd["UnRealisedGainGLs"].ToString())) obj.UnRealisedGainGLs = int.Parse(rd["UnRealisedGainGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RealisedGainGLs"].ToString())) obj.RealisedGainGLs = int.Parse(rd["RealisedGainGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["UnRealisedLossGLs"].ToString())) obj.UnRealisedLossGLs = int.Parse(rd["UnRealisedLossGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RealisedLossGLs"].ToString())) obj.RealisedLossGLs = int.Parse(rd["RealisedLossGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingPrecision"].ToString())) obj.RoundingPrecision = double.Parse(rd["RoundingPrecision"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingType"].ToString())) obj.RoundingType = int.Parse(rd["RoundingType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }  

            
            return myList;
        }

        public Currency  GetCurrency(int CurrencyId)
        {
           Currency obj=null;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getCurrency", "@CurrencyId",CurrencyId );
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.Currency();
                    if (!String.IsNullOrEmpty(rd["CurrencyId"].ToString())) obj.CurrencyId = int.Parse(rd["CurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Code"].ToString())) obj.Code = rd["Code"].ToString();
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["Symbol"].ToString())) obj.Symbol = rd["Symbol"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsDefaultCurrency"].ToString())) obj.IsDefaultCurrency = bool.Parse(rd["IsDefaultCurrency"].ToString());
                    if (!String.IsNullOrEmpty(rd["UnRealisedGainGLs"].ToString())) obj.UnRealisedGainGLs = int.Parse(rd["UnRealisedGainGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RealisedGainGLs"].ToString())) obj.RealisedGainGLs = int.Parse(rd["RealisedGainGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["UnRealisedLossGLs"].ToString())) obj.UnRealisedLossGLs = int.Parse(rd["UnRealisedLossGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RealisedLossGLs"].ToString())) obj.RealisedLossGLs = int.Parse(rd["RealisedLossGLs"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingPrecision"].ToString())) obj.RoundingPrecision = double.Parse(rd["RoundingPrecision"].ToString());
                    if (!String.IsNullOrEmpty(rd["RoundingType"].ToString())) obj.RoundingType = int.Parse(rd["RoundingType"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    
                }
                try { rd.Close(); }
                catch {; }
            }


            return obj;
        }

        public int AddEditCurrency(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditCurrency", "@CurrencyId", this.CurrencyId,
"@Code", this.Code,
"@Name", this.Name,
"@Symbol", this.Symbol,
"@IsDefaultCurrency", this.IsDefaultCurrency,
"@UnRealisedGainGLs", this.UnRealisedGainGLs,
"@RealisedGainGLs", this.RealisedGainGLs,
"@UnRealisedLossGLs", this.UnRealisedLossGLs,
"@RealisedLossGLs", this.RealisedLossGLs,
"@RoundingPrecision", this.RoundingPrecision,
"@RoundingType", this.RoundingType,
"@IsActive", this.IsActive,
"@MachineName", "USER-PC",
"@CreatedBy", "Admin",
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

        public int ResetDefaultCurrency(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "prco_ResetDefaultCurrency");
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
    }
}
