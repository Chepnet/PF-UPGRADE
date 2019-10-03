using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class AssetTransaction
    {

        private int _assetTransactionId = 0;
        private int _assetId = 0;
        private int _modeOfPaymentId = 0;
        private int _bankId = 0;
        private DateTime _transDate = DateTime.Today;
        private double _amount = 0;
        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private double _fCAmount = 0;
        private string _assetname = "";
        private string _modeofpaymentname = "";
        private string _bankname = "";
        private string _documentno = "";
        public int AssetTransactionId { get { return _assetTransactionId; } set { _assetTransactionId = value; } }
        public int AssetId { get { return _assetId; } set { _assetId = value; } }
        public int ModeOfPaymentId { get { return _modeOfPaymentId; } set { _modeOfPaymentId = value; } }
        public int BankId { get { return _bankId; } set { _bankId = value; } }
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRate { get { return _exchangeRate; } set { _exchangeRate = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }

        public string  AssetName { get { return _assetname ; } set { _assetname  = value; } }
        public string ModeOfPayment { get { return _modeofpaymentname ; } set { _modeofpaymentname  = value; } }
        public string BankName { get { return _bankname ; } set { _bankname  = value; } }
        public string DocumentNo { get { return _documentno ; } set { _documentno  = value; } }
        AssetRegister oassetregister = new AssetRegister();

        Bank oBank = new Bank();
        ModeOfPayment omodeofpayment = new ModeOfPayment();

        string err = "";

        public ArrayList GetAssetTransactions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllAssetTransactions");
            if(err =="")
            {
                while(rd.Read ())
                {
                    AssetTransaction obj = new Classes.AssetTransaction();
                    if (!String.IsNullOrEmpty(rd["AssetTransactionId"].ToString())) obj.AssetTransactionId = int.Parse(rd["AssetTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AssetId"].ToString())) obj.AssetId = int.Parse(rd["AssetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo  = rd["DocumentNo"].ToString();
                    if (obj.AssetId >0)
                    {
                        AssetRegister myAssetRegister = oassetregister.GetAssetRegister(obj.AssetId);
                        if(myAssetRegister !=null)
                        {
                            obj.AssetName = myAssetRegister.Name;
                        }
                    }
                    if(obj.BankId >0)
                    {
                        Bank myBank = oBank.GetBank(obj.BankId);
                        if(myBank !=null)
                        {
                            obj.BankName = myBank.BankName;
                        }
                    }
                    if(obj.ModeOfPaymentId >0)
                    {
                        ModeOfPayment myModeofPayment = omodeofpayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if(myModeofPayment !=null)
                        {
                            obj.ModeOfPayment = myModeofPayment.Description;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }

        public AssetTransaction  GetAssetTransaction(int AssetTransactionId)
        {
            AssetTransaction obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAssetTransaction", "@AssetTransactionId",AssetTransactionId );
            if (err == "")
            {
                if  (rd.Read())
                {
                  obj  = new Classes.AssetTransaction();
                    if (!String.IsNullOrEmpty(rd["AssetTransactionId"].ToString())) obj.AssetTransactionId = int.Parse(rd["AssetTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["AssetId"].ToString())) obj.AssetId = int.Parse(rd["AssetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (obj.AssetId > 0)
                    {
                        AssetRegister myAssetRegister = oassetregister.GetAssetRegister(obj.AssetId);
                        if (myAssetRegister != null)
                        {
                            obj.AssetName = myAssetRegister.Name;
                        }
                    }
                    if (obj.BankId > 0)
                    {
                        Bank myBank = oBank.GetBank(obj.BankId);
                        if (myBank != null)
                        {
                            obj.BankName = myBank.BankName;
                        }
                    }
                    if (obj.ModeOfPaymentId > 0)
                    {
                        ModeOfPayment myModeofPayment = omodeofpayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if (myModeofPayment != null)
                        {
                            obj.ModeOfPayment = myModeofPayment.Description;
                        }
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }

        public int AddEditAssetTransaction(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditAssetTransaction", "@AssetTransactionId", this.AssetTransactionId,
                    "@AssetId", this.AssetId,
                    "@ModeOfPaymentId", this.ModeOfPaymentId,
                    "@BankId", this.BankId,
                    "@TransDate", this.TransDate,
                    "@Amount", this.Amount,
                    "@DefaultCurrencyId", this.DefaultCurrencyId,
                    "@ForeignCurrencyId", this.ForeignCurrencyId,
                    "@ExchangeRate", this.ExchangeRate,
                    "@FCAmount", this.FCAmount,
                    "@MachineName", Environment.MachineName ,
                    "@DocumentNo",this.DocumentNo ,
                    "@CreatedBy", "Admin",
                    "@delete",delete);
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
