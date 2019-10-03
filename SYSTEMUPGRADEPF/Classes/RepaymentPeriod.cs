using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class RepaymentPeriod
    {
        private int _repaymentPeriodId = 0;
        private string _name = "";
        private string _periodReference = "";
        private int _frequencyRange = 0;
        private bool _isActive = false;
        private string _machineName = "";

        public int RepaymentPeriodId { get { return _repaymentPeriodId; } set { _repaymentPeriodId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string PeriodReference { get { return _periodReference; } set { _periodReference = value; } }
        public int FrequencyRange { get { return _frequencyRange; } set { _frequencyRange = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string MachineName { get { return _machineName; } set { _machineName = value; } }

        string err = "";

        public ArrayList GetRepaymentPeriods()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllRepaymentPeriods");
            if (err == "")
            {
                while (rd.Read())
                {
                    RepaymentPeriod obj = new Classes.RepaymentPeriod();
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriodId"].ToString())) obj.RepaymentPeriodId = int.Parse(rd["RepaymentPeriodId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["PeriodReference"].ToString())) obj.PeriodReference = rd["PeriodReference"].ToString();
                    if (!String.IsNullOrEmpty(rd["FrequencyRange"].ToString())) obj.FrequencyRange = int.Parse(rd["FrequencyRange"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["MachineName"].ToString())) obj.MachineName = rd["MachineName"].ToString();

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

        public RepaymentPeriod GetRepaymentPeriod(int RepaymentPeriodId)
        {
            RepaymentPeriod obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getRepaymentPeriod", "@RepaymentPeriodId", RepaymentPeriodId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.RepaymentPeriod();
                    if (!String.IsNullOrEmpty(rd["RepaymentPeriodId"].ToString())) obj.RepaymentPeriodId = int.Parse(rd["RepaymentPeriodId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Name"].ToString())) obj.Name = rd["Name"].ToString();
                    if (!String.IsNullOrEmpty(rd["PeriodReference"].ToString())) obj.PeriodReference = rd["PeriodReference"].ToString();
                    if (!String.IsNullOrEmpty(rd["FrequencyRange"].ToString())) obj.FrequencyRange = int.Parse(rd["FrequencyRange"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (!String.IsNullOrEmpty(rd["MachineName"].ToString())) obj.MachineName = rd["MachineName"].ToString();
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;
        }

        public int AddEditRepaymentPeriod(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "pro_AddEditRepaymentPeriod",
                "@RepaymentPeriodId", this.RepaymentPeriodId,
                "@Name", this.Name,
                "@PeriodReference", this.PeriodReference,
                "@FrequencyRange", this.FrequencyRange,
                "@IsActive", this.IsActive,
                "@MachineName", this.MachineName,
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
