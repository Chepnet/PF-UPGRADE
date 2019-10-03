using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class ExchangeRate
    {
        private int _exchangeRateId = 0;
        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private string _defaultCurrency = "";
        private string _foreignCurrency = "";
        public int ExchangeRateId { get { return _exchangeRateId; } set { _exchangeRateId = value; } }
        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRates { get { return _exchangeRate; } set { _exchangeRate = value; } }
        public string DefaultCurrency { get { return _defaultCurrency; } set { _defaultCurrency = value; } }
        public string ForeignCurrency { get { return _foreignCurrency; } set { _foreignCurrency = value; } }
        Currency oCurrency = new Currency();

        string err = "";
        public ArrayList GetExchangeRates()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllExchangeRates");
                
                if(err=="")
                {
                    while(rd.Read ())
                    {
                        ExchangeRate obj = new Classes.ExchangeRate();
                        if (!String.IsNullOrEmpty(rd["ExchangeRateId"].ToString())) obj.ExchangeRateId = int.Parse(rd["ExchangeRateId"].ToString());
                        if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                        if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                        if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRates = double.Parse(rd["ExchangeRate"].ToString());
                        if(obj.DefaultCurrencyId >0)
                    {
                        Currency myCurrency = oCurrency.GetCurrency(obj.DefaultCurrencyId);
                        if(myCurrency !=null)
                        {
                            obj.DefaultCurrency = myCurrency.Name;
                        }
                    }
                    if (obj.ForeignCurrencyId  > 0)
                    {
                        Currency myCurrency = oCurrency.GetCurrency(obj.ForeignCurrencyId );
                        if (myCurrency != null)
                        {
                            obj.ForeignCurrency  = myCurrency.Name;
                        }
                    }
                    myList.Add(obj);
                    }
                    try { rd.Close(); }
                    catch {; }
                }
            return myList;

            }
        
    public ExchangeRate  GetExchangeRate(int ExchangeRateId)
    {
            ExchangeRate obj = null;
        Link myLink = new Classes.Link();
        DbDataReader rd = myLink.GetDBResults(ref err, "proc_getExchangeRate", "@ExchangeRateId",ExchangeRateId );

        if (err == "")
        {
            if (rd.Read())
            {
                 obj = new Classes.ExchangeRate();
                if (!String.IsNullOrEmpty(rd["ExchangeRateId"].ToString())) obj.ExchangeRateId = int.Parse(rd["ExchangeRateId"].ToString());
                if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRates = double.Parse(rd["ExchangeRate"].ToString());
                    if (obj.DefaultCurrencyId > 0)
                    {
                        Currency myCurrency = oCurrency.GetCurrency(obj.DefaultCurrencyId);
                        if (myCurrency != null)
                        {
                            obj.DefaultCurrency = myCurrency.Name;
                        }
                    }
                    if (obj.ForeignCurrencyId > 0)
                    {
                        Currency myCurrency = oCurrency.GetCurrency(obj.ForeignCurrencyId);
                        if (myCurrency != null)
                        {
                            obj.ForeignCurrency = myCurrency.Name;
                        }
                    }
                }
            try { rd.Close(); }
            catch {; }
        }
        return obj;

    }
        public int AddEditExchangeRate(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditExchangeRate", "@ExchangeRateId", this.ExchangeRateId,
"@DefaultCurrencyId", this.DefaultCurrencyId,
"@ForeignCurrencyId", this.ForeignCurrencyId,
"@ExchangeRate", this.ExchangeRates,
"@MachineName", "USER-PC",
"@CreatedBy", "ADMIN",
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
}

    }

