using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Payment
    {
        private int _payModeId = 0;
        private DateTime _transDate = DateTime.Today;
        private string _documentNo = "";
        private int _bankId = 0;
        private string _description = "";
        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRateId = 0;
        private double _fCAmount = 0;
        private double _amountPaid = 0;
        private int _paymentId = 0;
        private int _customerId = 0;
        private string  _modeofpayment = "";
        private int _invoiceId = 0;
        private string _invoiceno = "";
        private string _customername = "";

        public int PaymentId { get { return _paymentId; } set { _paymentId = value; } }
        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public int InvoiceId { get { return _invoiceId; } set { _invoiceId = value; } }

        public int ModeOfPaymentId { get { return _payModeId; } set { _payModeId = value; } }
        public DateTime TransDate { get { return _transDate; } set { _transDate = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
        public int BankId { get { return _bankId; } set { _bankId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int DefaultCurrencyId { get { return _defaultCurrencyId; } set { _defaultCurrencyId = value; } }
        public int ForeignCurrencyId { get { return _foreignCurrencyId; } set { _foreignCurrencyId = value; } }
        public double ExchangeRateId { get { return _exchangeRateId; } set { _exchangeRateId = value; } }
        public double FCAmount { get { return _fCAmount; } set { _fCAmount = value; } }
        public double AmountPaid { get { return _amountPaid; } set { _amountPaid = value; } }
        public string ModeOfPayment { get { return _modeofpayment ; } set { _modeofpayment  = value; } }
        public string CustomerName { get { return _customername ; } set { _customername  = value; } }
        public string InvoiceNo { get { return _invoiceno ; } set { _invoiceno  = value; } }

        Customer oCustomer = new Customer();
        Invoice oInvoice = new Invoice();
        ModeOfPayment omodeofpayment = new ModeOfPayment();
        string err = "";
        public ArrayList GetPayments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllPayments");
            if(err=="")
            {
                while (rd.Read())
                {
                    Payment obj = new Classes.Payment();
                    if (!String.IsNullOrEmpty(rd["PaymentId"].ToString())) obj.PaymentId = int.Parse(rd["PaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PayModeId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["PayModeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRateId"].ToString())) obj.ExchangeRateId = double.Parse(rd["ExchangeRateId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["AmountPaid"].ToString())) obj.AmountPaid = double.Parse(rd["AmountPaid"].ToString());
                    if(obj.PaymentId >0)
                    {
                        ModeOfPayment myModeofpayment = omodeofpayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if(myModeofpayment !=null)
                        {
                            obj.ModeOfPayment = myModeofpayment.Description;
                        }
                    }
                    if(obj.CustomerId >0)
                    {
                        Customer myCustomer = oCustomer.GetCustomer(obj.CustomerId);
                        if(myCustomer !=null)
                        {
                            obj.CustomerName = myCustomer.CustomerName;
                        }
                    }
                    if(InvoiceId >0)
                    {
                        Invoice myInvoice = oInvoice.GetInvoice(obj.InvoiceId);
                        if(myInvoice !=null)
                        {
                            obj.InvoiceNo = myInvoice.InvoiceNo;
                        }
                    }
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public Payment  GetPayment(int PaymentId)
        {
            Payment obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getPayment", "@PaymentId", PaymentId );
            if (err == "")
            {
                while (rd.Read())
                {
                     obj = new Classes.Payment();
                    if (!String.IsNullOrEmpty(rd["PaymentId"].ToString())) obj.PaymentId = int.Parse(rd["PaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PayModeId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["PayModeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TransDate"].ToString())) obj.TransDate = DateTime.Parse(rd["TransDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRateId"].ToString())) obj.ExchangeRateId = double.Parse(rd["ExchangeRateId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["AmountPaid"].ToString())) obj.AmountPaid = double.Parse(rd["AmountPaid"].ToString());
                    if (obj.PaymentId > 0)
                    {
                        ModeOfPayment myModeofpayment = omodeofpayment.GetModeOfPayment(obj.ModeOfPaymentId);
                        if (myModeofpayment != null)
                        {
                            obj.ModeOfPayment = myModeofpayment.Description;
                        }
                    }
                    if (obj.CustomerId > 0)
                    {
                        Customer myCustomer = oCustomer.GetCustomer(obj.CustomerId);
                        if (myCustomer != null)
                        {
                            obj.CustomerName = myCustomer.CustomerName;
                        }
                    }
                    if (InvoiceId > 0)
                    {
                        Invoice myInvoice = oInvoice.GetInvoice(obj.InvoiceId);
                        if (myInvoice != null)
                        {
                            obj.InvoiceNo = myInvoice.InvoiceNo;
                        }
                    }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj ;
        }
        public int AddEditPayment(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditPayment", "@PaymentId", this.PaymentId,
                    "@CustomerId", this.CustomerId,
                     "@InvoiceId", this.InvoiceId ,
                    "@PayModeId", this.ModeOfPaymentId,
                    "@TransDate", this.TransDate,
                    "@DocumentNo", this.DocumentNo,
                    "@BankId", this.BankId,
                    "@Description", this.Description,
                    "@DefaultCurrencyId", this.DefaultCurrencyId ,
                    "@ForeignCurrencyId", this.ForeignCurrencyId ,
                    "@ExchangeRateId", this.ExchangeRateId ,
                    "@FCAmount", this.FCAmount  ,
                    "@AmountPaid", this.AmountPaid,
                    "@IsActive", "0",
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
