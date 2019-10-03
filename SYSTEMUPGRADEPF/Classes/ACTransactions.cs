using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class ACTransactions
    {

        private int _aCTransactionId = 0;
        private int _memberShareId = 0;
        private DateTime _transDate = DateTime.Today;
        private DateTime _valueDate = DateTime.Today;
        private int _serialId = 0;
        private int _branchId = 0;
        private double _amount = 0;
        private int _modeOfPaymentId = 0;
        private string _description = "";
        private int _sourceACId = 0;
        private int _bankId = 0;
        private bool _isReversal = false;
        private bool _isReversed = false;
        private int _reversalId = 0;
        private int _dimensionsetId = 0;
        private bool _isFeeTransaction = false;
        private string _remarks = "";
        private string _documentNo = "";
        private bool _isActive = false;
        private string _bankName = "";
        private string _ModeofPaymentDescription = "";
        private double _commision = 0;
        private int _shareTypechargeId = 0;


        private int _foreignCurrencyId = 0;
        private int _defaultCurrencyId = 0;
        private double _fCAmount = 0;
        private double _exchangeRates = 1;




        public int ACTransactionId { get { return _aCTransactionId; } set { _aCTransactionId = value; } }
        public int MemberShareId { get { return _memberShareId; } set { _memberShareId = value; } }
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public DateTime ValueDate { get { return _valueDate; } set { _valueDate = value; } }
        public int SerialId { get { return _serialId; } set { _serialId = value; } }
        public int BranchId { get { return _branchId; } set { _branchId = value; } }
        public double Amount { get { return _amount; } set { _amount = value; } }
        public int ModeOfPaymentId { get { return _modeOfPaymentId; } set { _modeOfPaymentId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int SourceACId { get { return _sourceACId; } set { _sourceACId = value; } }
        public int BankId { get { return _bankId; } set { _bankId = value; } }
        public bool IsReversal { get { return _isReversal; } set { _isReversal = value; } }
        public bool IsReversed { get { return _isReversed; } set { _isReversed = value; } }
        public int ReversalId { get { return _reversalId; } set { _reversalId = value; } }
        public int DimensionsetId { get { return _dimensionsetId; } set { _dimensionsetId = value; } }
        public bool IsFeeTransaction { get { return _isFeeTransaction; } set { _isFeeTransaction = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string BankName { get { return _bankName ; } set { _bankName = value; } }
        public string ModeofPayment { get { return _ModeofPaymentDescription ; } set { _ModeofPaymentDescription = value; } }

        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }
        public double ExchangeRates { get { return _exchangeRates; } set { _exchangeRates = value; } }

        public double Commision { get { return _commision; } set { _commision  = value; } }
        public int ShareTypeChargeId { get { return _shareTypechargeId; } set { _shareTypechargeId = value; } }


        Bank oBank = new Bank();
        ModeOfPayment omodeofpayment = new ModeOfPayment();
        string err = "";
        public ArrayList GetACTransactions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllACTransactions");
            if(err=="")
            {
                while(rd.Read ())
                {
                    ACTransactions obj = new Classes.ACTransactions();
                    if (!String.IsNullOrEmpty(rd["ACTransactionId"].ToString())) obj.ACTransactionId = int.Parse(rd["ACTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["SourceACId"].ToString())) obj.SourceACId = int.Parse(rd["SourceACId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversalId"].ToString())) obj.ReversalId = int.Parse(rd["ReversalId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionsetId"].ToString())) obj.DimensionsetId = int.Parse(rd["DimensionsetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsFeeTransaction"].ToString())) obj.IsFeeTransaction = bool.Parse(rd["IsFeeTransaction"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRates"].ToString())) obj.ExchangeRates = double.Parse(rd["ExchangeRates"].ToString());
                   
                    if (obj.BankId >0)
                    {
                        Bank myBank = oBank.GetBank(obj.BankId);
                        if(myBank !=null)
                        {
                            obj.BankName = myBank.BankName;
                        }
                    }
                    if (obj.ModeOfPaymentId   > 0)
                    {
                        ModeOfPayment  myModeOfPayment = omodeofpayment .GetModeOfPayment (obj.ModeOfPaymentId);
                        if (myModeOfPayment != null)
                        {
                            obj.ModeofPayment  = myModeOfPayment.Description ;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ACTransactions  GetACTransaction(int ACTransactionId)
        {
            ACTransactions obj = null;
           Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getACTransaction", "@ACTransactionId",ACTransactionId );
            if (err == "")
            {
                if (rd.Read())
                {
                   obj= new Classes.ACTransactions();
                    if (!String.IsNullOrEmpty(rd["ACTransactionId"].ToString())) obj.ACTransactionId = int.Parse(rd["ACTransactionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberShareId"].ToString())) obj.MemberShareId = int.Parse(rd["MemberShareId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["ValueDate"].ToString())) obj.ValueDate = DateTime.Parse(rd["ValueDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BranchId"].ToString())) obj.BranchId = int.Parse(rd["BranchId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Amount"].ToString())) obj.Amount = double.Parse(rd["Amount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["SourceACId"].ToString())) obj.SourceACId = int.Parse(rd["SourceACId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversal"].ToString())) obj.IsReversal = bool.Parse(rd["IsReversal"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsReversed"].ToString())) obj.IsReversed = bool.Parse(rd["IsReversed"].ToString());
                    if (!String.IsNullOrEmpty(rd["ReversalId"].ToString())) obj.ReversalId = int.Parse(rd["ReversalId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DimensionsetId"].ToString())) obj.DimensionsetId = int.Parse(rd["DimensionsetId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsFeeTransaction"].ToString())) obj.IsFeeTransaction = bool.Parse(rd["IsFeeTransaction"].ToString());
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRates"].ToString())) obj.ExchangeRates = double.Parse(rd["ExchangeRates"].ToString());
                    if (!String.IsNullOrEmpty(rd["Commission"].ToString())) obj.Commision = double.Parse(rd["Commission"].ToString());


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
                        ModeOfPayment myModeOfPayment = omodeofpayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if (myModeOfPayment != null)
                        {
                            obj.ModeofPayment = myModeOfPayment.Description;
                        }
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditACTransactions(bool delete, string chargeIds, string chargeAmounts, ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditDeleteAcTransaction", "@ACTransactionId", this.ACTransactionId,
            "@MemberShareId", this.MemberShareId,
            "@TransDate", this.TransDate.ToString("yyyyMMdd"),
            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
            "@SerialId", this.SerialId,
            "@BranchId", "1",
            "@Amount", this.Amount,
            "@ModeOfPaymentId", this.ModeOfPaymentId,
            "@Description", this.Description,
            "@SourceACId", this.SourceACId,
             "@BankId", this.BankId,
            "@IsReversal", "0",
            "@IsReversed", "0",
            "@ReversalId", "0",
            "@DimensionsetId", "1",
            "@IsFeeTransaction", this.IsFeeTransaction,
            "@Remarks", this.Remarks,
            "@DocumentNo", this.DocumentNo,
            "@IsActive", this.IsActive,
            "@ForeignCurrencyId", this.ForeignCurrencyId,
            "@DefaultCurrencyId", this.DefaultCurrencyId,
            "@FCAmount", this.FCAmount,
             "@ChargeIds", chargeIds,
             "@ChargeAmounts", chargeAmounts,
             "@ExchangeRates", this.ExchangeRates,
            "@MachineName", "USER-PC",
             "@TransTypeId", "0",
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

        public int transferACTransaction(bool delete,string chargeIds,string chargeAmounts, ref string error)
        {
            int id = 0;
            Link myLink = new Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_TestofAcTransaction", "@ACTransactionId", this.ACTransactionId,
            "@MemberShareId", this.MemberShareId,
            "@TransDate", this.TransDate.ToString("yyyyMMdd"),
            "@ValueDate", this.ValueDate.ToString("yyyyMMdd"),
            "@SerialId", this.SerialId,
            "@BranchId", "1",
            "@Amount", this.Amount,
            "@ModeOfPaymentId", this.ModeOfPaymentId,
            "@Description", this.Description,
            "@SourceACId", this.SourceACId,
             "@BankId", this.BankId,
            "@IsReversal", "0",
            "@IsReversed", "0",
            "@ReversalId", "0",
            "@DimensionsetId", "1",
            "@IsFeeTransaction", this.IsFeeTransaction,
            "@Remarks", this.Remarks,
            "@DocumentNo", this.DocumentNo,
            "@IsActive", this.IsActive,
            "@ForeignCurrencyId", this.ForeignCurrencyId,
            "@DefaultCurrencyId", this.DefaultCurrencyId,
            "@FCAmount", this.FCAmount,
            "@ExchangeRates", this.ExchangeRates,
             "@ChargeIds", chargeIds,
             "@ChargeAmounts", chargeAmounts,
             "@MachineName", "USER-PC",
              "@TransTypeId", "0",
            "@CreatedBy", "Admin",
            "@delete", delete);
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
