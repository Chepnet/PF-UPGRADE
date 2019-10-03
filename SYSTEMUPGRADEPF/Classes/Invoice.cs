using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Invoice
    {


        private int _invoiceId = 0;
        private int _customerId = 0;
        private string _invoiceNo = "";
        private string _invoiceTo = "";
        private DateTime _invoiceDate = DateTime.Today;
        private int _item = 0;
        private int _itemDescription = 0;
        private int _rate = 0;
        private int _amount = 0;
        private int _vAT = 0;
        private double _subtotal = 0;
        private double _vATTotal = 0;
        private double _total = 0;
        private int _payMode = 0;
        private int _bankId = 0;
        private int _defaultCurrencyId = 0;
        private int _foreignCurrencyId = 0;
        private double _exchangeRate = 0;
        private double _fCAmount = 0;
        private string _terms = "";
        private string _modeofpayment = "";
        private string _customername = "";

        public int InvoiceId { get {return  _invoiceId;} set{_invoiceId =value;}}
public int CustomerId { get {return  _customerId;} set{_customerId =value;}}
public string InvoiceNo { get {return  _invoiceNo;} set{_invoiceNo =value;}}
public string InvoiceTo { get {return  _invoiceTo;} set{_invoiceTo =value;}}
public DateTime InvoiceDate { get {return  _invoiceDate;} set{_invoiceDate =value;}}
public int Item { get {return  _item;} set{_item =value;}}
public int ItemDescription { get {return  _itemDescription;} set{_itemDescription =value;}}
public int Rate { get {return  _rate;} set{_rate =value;}}
public int Amount { get {return  _amount;} set{_amount =value;}}
public int VAT { get {return  _vAT;} set{_vAT =value;}}
public double Subtotal { get {return  _subtotal;} set{_subtotal =value;}}
public double VATTotal { get {return  _vATTotal;} set{_vATTotal =value;}}
public double Total { get {return  _total;} set{_total =value;}}
public int PayMode { get {return  _payMode;} set{_payMode =value;}}
public int BankId { get {return  _bankId;} set{_bankId =value;}}
public int DefaultCurrencyId { get {return  _defaultCurrencyId;} set{_defaultCurrencyId =value;}}
public int ForeignCurrencyId { get {return  _foreignCurrencyId;} set{_foreignCurrencyId =value;}}
public double ExchangeRate { get {return  _exchangeRate;} set{_exchangeRate =value;}}
public double FCAmount { get {return  _fCAmount;} set{_fCAmount =value;}}
public string Terms { get {return  _terms;} set{_terms =value;}}
        public string CustomerName { get { return _customername ; } set { _customername  = value; } }
        public string ModeOfPayment { get { return _modeofpayment ; } set { _modeofpayment  = value; } }
        ModeOfPayment oModeOfPayment = new ModeOfPayment();
        Customer oCustomer = new Customer();


        string err = "";

        public double InvoiceBalance
        {
            get { return this.getInvoiceBalance (); }
        }
        public ArrayList GetInvoices()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllInvoices");
            if(err=="")
            {
                while (rd.Read ())
                {
                    Invoice obj = new Classes.Invoice();
                    if (!String.IsNullOrEmpty(rd["InvoiceId"].ToString())) obj.InvoiceId = int.Parse(rd["InvoiceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["InvoiceNo"].ToString())) obj.InvoiceNo = rd["InvoiceNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["InvoiceTo"].ToString())) obj.InvoiceTo = rd["InvoiceTo"].ToString();
                    if (!String.IsNullOrEmpty(rd["InvoiceDate"].ToString())) obj.InvoiceDate = DateTime.Parse(rd["InvoiceDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Subtotal"].ToString())) obj.Subtotal = double.Parse(rd["Subtotal"].ToString());
                    if (!String.IsNullOrEmpty(rd["VATTotal"].ToString())) obj.VATTotal = double.Parse(rd["VATTotal"].ToString());
                    if (!String.IsNullOrEmpty(rd["Total"].ToString())) obj.Total = double.Parse(rd["Total"].ToString());
                    if (!String.IsNullOrEmpty(rd["PayMode"].ToString())) obj.PayMode = int.Parse(rd["PayMode"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["Terms"].ToString())) obj.Terms = rd["Terms"].ToString();
                    if(obj.CustomerId>0)
                    {
                        Customer myCustomer = oCustomer.GetCustomer(obj.CustomerId);
                        if (myCustomer != null)
                            obj.CustomerName = myCustomer.CustomerName;
                    }
                    if(obj.PayMode >0)
                    {
                        ModeOfPayment myModeofPayment = oModeOfPayment.GetModeOfPayment(obj.PayMode);
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
        public Invoice  GetInvoice(int InvoiceId)
        {
            Invoice obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getInvoice", "@InvoiceId",InvoiceId);
            if (err == "")
            {
                if (rd.Read())
                {
                     obj = new Classes.Invoice();
                    if (!String.IsNullOrEmpty(rd["InvoiceId"].ToString())) obj.InvoiceId = int.Parse(rd["InvoiceId"].ToString());
                    if (!String.IsNullOrEmpty(rd["CustomerId"].ToString())) obj.CustomerId = int.Parse(rd["CustomerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["InvoiceNo"].ToString())) obj.InvoiceNo = rd["InvoiceNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["InvoiceTo"].ToString())) obj.InvoiceTo = rd["InvoiceTo"].ToString();
                    if (!String.IsNullOrEmpty(rd["InvoiceDate"].ToString())) obj.InvoiceDate = DateTime.Parse(rd["InvoiceDate"].ToString());
                    if (!String.IsNullOrEmpty(rd["Subtotal"].ToString())) obj.Subtotal = double.Parse(rd["Subtotal"].ToString());
                    if (!String.IsNullOrEmpty(rd["VATTotal"].ToString())) obj.VATTotal = double.Parse(rd["VATTotal"].ToString());
                    if (!String.IsNullOrEmpty(rd["Total"].ToString())) obj.Total = double.Parse(rd["Total"].ToString());
                    if (!String.IsNullOrEmpty(rd["PayMode"].ToString())) obj.PayMode = int.Parse(rd["PayMode"].ToString());
                    if (!String.IsNullOrEmpty(rd["BankId"].ToString())) obj.BankId = int.Parse(rd["BankId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCurrencyId"].ToString())) obj.DefaultCurrencyId = int.Parse(rd["DefaultCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ForeignCurrencyId"].ToString())) obj.ForeignCurrencyId = int.Parse(rd["ForeignCurrencyId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ExchangeRate"].ToString())) obj.ExchangeRate = double.Parse(rd["ExchangeRate"].ToString());
                    if (!String.IsNullOrEmpty(rd["FCAmount"].ToString())) obj.FCAmount = double.Parse(rd["FCAmount"].ToString());
                    if (!String.IsNullOrEmpty(rd["Terms"].ToString())) obj.Terms = rd["Terms"].ToString();
                    if (obj.CustomerId > 0)
                    {
                        Customer myCustomer = oCustomer.GetCustomer(obj.CustomerId);
                        if (myCustomer != null)
                            obj.CustomerName = myCustomer.CustomerName;
                    }
                    if (obj.PayMode > 0)
                    {
                        ModeOfPayment myModeofPayment = oModeOfPayment.GetModeOfPayment(obj.PayMode);
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
        public int AddEditInvoice(bool delete,string Item,string ItemDescription,string Rate,string Amount,string VAT,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditInvoice", "@InvoiceId", this.InvoiceId ,
                "@CustomerId", this.CustomerId,
                    "@InvoiceNo", this.InvoiceNo,
                    "@InvoiceTo", this.InvoiceTo,
                    "@InvoiceDate", this.InvoiceDate,
                    "@Item", Item,
                    "@ItemDescription", ItemDescription,
                    "@Rate", Rate,
                    "@Amount", Amount,
                    "@VAT", VAT,
                    "@Subtotal", this.Subtotal,
                    "@VATTotal", this.VATTotal,
                    "@Total", this.Total,
                    "@PayMode", this.PayMode,
                    "@BankId", this.BankId,
                     "@DefaultCurrencyId", this.DefaultCurrencyId,
                     "@ForeignCurrencyId", this.ForeignCurrencyId,
                     "@ExchangeRateId", this.ExchangeRate,
                     "@FCAmount", this.FCAmount,
                    "@Terms", this.Terms,
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
        public double getInvoiceBalance()
        {
            double val = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "sp_getInvoiceBalance", "@InvoiceId", this.InvoiceId );
            if (err == "")
            {
                if (rd.Read())
                {
                    val = double.Parse(rd["InvoiceBalance"].ToString());
                }
                try { rd.Close(); }
                catch {; }

            }
            return val;
        }
    }
}
