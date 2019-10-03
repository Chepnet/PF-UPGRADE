using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
namespace SYSTEMUPGRADEPF.Classes
{
    class Serial
    {
        private int _serialId = 0;
        private string _serialCode = "";
        private string _description = "";
        private string _documentNo = "";
        


        public int SerialId { get { return _serialId; } set { _serialId = value; } }
        public string SerialCode { get { return _serialCode; } set { _serialCode = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string DocumentNo { get { return _documentNo; } set { _documentNo = value; } }
       

        string err="";
        public ArrayList GetSerials()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getAllSerials");
            if(err=="")
            {
                while(rd.Read ())
                {
                    Serial obj = new Classes.Serial();
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialCode"].ToString())) obj.SerialCode = rd["SerialCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    
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
        public Serial  GetSerial( int SerialId)
        {
            Serial obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_getSerial", "",SerialId );
            if (err == "")
            {
                while (rd.Read())
                {
                    obj = new Classes.Serial();
                    if (!String.IsNullOrEmpty(rd["SerialId"].ToString())) obj.SerialId = int.Parse(rd["SerialId"].ToString());
                    if (!String.IsNullOrEmpty(rd["SerialCode"].ToString())) obj.SerialCode = rd["SerialCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentNo"].ToString())) obj.DocumentNo = rd["DocumentNo"].ToString();
                    
                   
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;

        }
        public int AddEditSerial(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditSerial",
                "@SerialId", this.SerialId,
"@SerialCode", this.SerialCode,
"@Description", this.Description,
 "@MachineName", "USER-PC",
"@DocumentNo", this.DocumentNo,
"@CreatedBy", "Admin",
"@delete",delete
);
            if(err=="")
            {
                if(rd.Read ())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            return id;
        }
    }
}
