using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Station
    {
        private int _stationId = 0;
        private string _stationCode = "";
        private string _stationName = "";
        private int _employerId = 0;
        private string _stationAddress = "";
        private bool _isActive = false;
        private string _employerName = "";

        public int StationId { get { return _stationId; } set { _stationId = value; } }
        public string StationCode { get { return _stationCode; } set { _stationCode = value; } }
        public string StationName { get { return _stationName; } set { _stationName = value; } }
        public int EmployerId { get { return _employerId; } set { _employerId = value; } }
        public string StationAddress { get { return _stationAddress; } set { _stationAddress = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string EmployerName { get { return _employerName; } set { _employerName = value; } }


        Employer oEmployer = new Employer();

        string err = "";

        public ArrayList GetStations()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllStations");
            if (err == "")
                while (rd.Read())
                {
                    Station obj = new Classes.Station();
                    if (!String.IsNullOrEmpty(rd["StationId"].ToString())) obj.StationId = int.Parse(rd["StationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationCode"].ToString())) obj.StationCode = rd["StationCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["StationName"].ToString())) obj.StationName = rd["StationName"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationAddress"].ToString())) obj.StationAddress = rd["StationAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.EmployerId > 0)
                    {
                        Employer myEmployer = oEmployer.GetEmployer(obj.EmployerId);
                        if (myEmployer != null)

                            obj.EmployerName = myEmployer.EmployerName;
                    }
                    
                    

                    myList.Add(obj);
                }
            try
            {
                rd.Close();
            }
            catch
            {
                ;
            }

            return myList;
        }
        public Station GetStation(int StationId)
        {
            Station obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getStation", "@StationId", StationId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Station();
                    if (!String.IsNullOrEmpty(rd["StationId"].ToString())) obj.StationId = int.Parse(rd["StationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationCode"].ToString())) obj.StationCode = rd["StationCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["StationName"].ToString())) obj.StationName = rd["StationName"].ToString();
                    if (!String.IsNullOrEmpty(rd["EmployerId"].ToString())) obj.EmployerId = int.Parse(rd["EmployerId"].ToString());
                    if (!String.IsNullOrEmpty(rd["StationAddress"].ToString())) obj.StationAddress = rd["StationAddress"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if(obj.EmployerId >0)
                    {
                        Employer myEmployer = oEmployer.GetEmployer(obj.EmployerId);
                        if (myEmployer != null)
                            obj.EmployerName = myEmployer.EmployerName;
                            }
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditStation(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditStation",
                "@StationId", this.StationId,
                "@StationCode", this.StationCode,
                "@StationName", this.StationName,
                "@EmployerId", this.EmployerId,
                "@StationAddress", this.StationAddress,
                 "@IsActive", this.IsActive,
                 "@CreatedBy", "Admin",
                  "@MachineName", "USER-PC",
                 "@delete", delete);
            if (err == "")
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            try { rd.Close(); }
            catch {; }
            error = err;

            return id;
        }

    }
}
