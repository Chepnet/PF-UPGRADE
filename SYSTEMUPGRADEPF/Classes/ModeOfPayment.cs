using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;
namespace SYSTEMUPGRADEPF.Classes
{
    class ModeOfPayment
    {
        private int _modeOfPaymentId = 0;
        private string _description = "";
        private bool _isLinkedToUser = false;
        private bool _allowBackdatedTransaction = false;
        private bool _isInHouseClearing = false;
        private bool _isTransfer = false;
        private bool _isActive = false;

        public int ModeOfPaymentId { get { return _modeOfPaymentId; } set { _modeOfPaymentId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool IsLinkedToUser { get { return _isLinkedToUser; } set { _isLinkedToUser = value; } }
        public bool AllowBackdatedTransaction { get { return _allowBackdatedTransaction; } set { _allowBackdatedTransaction = value; } }
        public bool IsInHouseClearing { get { return _isInHouseClearing; } set { _isInHouseClearing = value; } }
        public bool IsTransfer { get { return _isTransfer; } set { _isTransfer = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        string err = "";
        public ArrayList GetModeOfPayments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllModeOfPayments");
            if(err=="")
            {
                while(rd.Read())
                {
                    ModeOfPayment obj = new Classes.ModeOfPayment();
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsLinkedToUser"].ToString())) obj.IsLinkedToUser = bool.Parse(rd["IsLinkedToUser"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowBackdatedTransaction"].ToString())) obj.AllowBackdatedTransaction = bool.Parse(rd["AllowBackdatedTransaction"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsInHouseClearing"].ToString())) obj.IsInHouseClearing = bool.Parse(rd["IsInHouseClearing"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTransfer"].ToString())) obj.IsTransfer = bool.Parse(rd["IsTransfer"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }
        public ModeOfPayment  GetModeOfPayment(int ModeOfPaymentId)
        {
            ModeOfPayment obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getModeOfPayment", "@ModeOfPaymentId", ModeOfPaymentId );
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.ModeOfPayment();
                    if (!String.IsNullOrEmpty(rd["ModeOfPaymentId"].ToString())) obj.ModeOfPaymentId = int.Parse(rd["ModeOfPaymentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsLinkedToUser"].ToString())) obj.IsLinkedToUser = bool.Parse(rd["IsLinkedToUser"].ToString());
                    if (!String.IsNullOrEmpty(rd["AllowBackdatedTransaction"].ToString())) obj.AllowBackdatedTransaction = bool.Parse(rd["AllowBackdatedTransaction"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsInHouseClearing"].ToString())) obj.IsInHouseClearing = bool.Parse(rd["IsInHouseClearing"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsTransfer"].ToString())) obj.IsTransfer = bool.Parse(rd["IsTransfer"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                   
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditModeOfPayment(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditModeOfPayment", "@ModeOfPaymentId", this.ModeOfPaymentId,
            "@Description", this.Description,
            "@IsLinkedToUser", this.IsLinkedToUser,
            "@AllowBackdatedTransaction", this.AllowBackdatedTransaction,
            "@IsInHouseClearing", this.IsInHouseClearing,
            "@IsTransfer", this.IsTransfer,
            "@IsActive", this.IsActive,
            "@delete",delete ,
            "@MachineName", "User-pc",
            "@CreatedBy", "ADMIN");
            if(err=="")
            {
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            error = err;
            return id;
        }


    }
}
