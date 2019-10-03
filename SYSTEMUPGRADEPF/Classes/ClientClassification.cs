using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;

namespace SYSTEMUPGRADEPF.Classes
{
    class ClientClassification
    {
        private int _clientClassificationId = 0;
        private string _clientClassificationName = "";
        private bool _isActive = false;


        public int ClientClassificationId { get { return _clientClassificationId; } set { _clientClassificationId = value; } }
        public string ClientClassificationName { get { return _clientClassificationName; } set { _clientClassificationName = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string err = "";

        public ArrayList GetClientClassifications()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllClientClassifications");
            if (err == "")
            {

                while(rd.Read())
                {
                    ClientClassification obj = new Classes.ClientClassification();
                    if (!String.IsNullOrEmpty(rd["ClientClassificationId"].ToString())) obj.ClientClassificationId = int.Parse(rd["ClientClassificationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClientClassificationName"].ToString())) obj.ClientClassificationName = rd["ClientClassificationName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }

            }
            return myList;
        }
        public ClientClassification GetClientClassification(int ClientClassificationid)
        {
            ClientClassification obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getClientClassification", "@ClientClassificationId", ClientClassificationid);
            if(err=="")
            
                if(rd.Read())
                {
                    obj = new Classes.ClientClassification();
                    if (!String.IsNullOrEmpty(rd["ClientClassificationId"].ToString())) obj.ClientClassificationId = int.Parse(rd["ClientClassificationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["ClientClassificationName"].ToString())) obj.ClientClassificationName = rd["ClientClassificationName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                  
                }
                try { rd.Close(); }
                catch {; }
            

            return obj;
        }
        public int AddEditClientClassification(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditClientClassification",
                "@ClientClassificationId", this.ClientClassificationId,
                "@ClientClassificationName", this.ClientClassificationName,
                "@IsActive", this.IsActive,
                 "@MachineName", "USER-PC",
                "@CreatedBy", "Admin",
                "@delete", delete);
            if(err=="")
            {
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            error = err;
            return id;
        }
    }
}
