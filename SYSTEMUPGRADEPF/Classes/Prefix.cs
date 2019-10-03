using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class Prefix
    {

        private int _prefixId = 0;
        private string _tableName = "";
        private string _description = "";
        private string _prefix = "";
        private int _lengthOfCode = 0;
        private bool _checkforMaximum = false;
        private int _userBranch = 0;

        public int PrefixId { get { return _prefixId; } set { _prefixId = value; } }
        public string TableName { get { return _tableName; } set { _tableName = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string PrefixCode{ get { return _prefix; } set { _prefix = value; } }
        public int LengthOfCode { get { return _lengthOfCode; } set { _lengthOfCode = value; } }
        public bool CheckforMaximum { get { return _checkforMaximum; } set { _checkforMaximum = value; } }
        public int UserBranch { get { return _userBranch; } set { _userBranch = value; } }

        string err = "";
        public ArrayList GetPrefices()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "Proc_getAllPrefix");
                if(err=="")
            {
                while (rd.Read())
                {
                    Prefix obj = new Classes.Prefix();
                    if (!String.IsNullOrEmpty(rd["PrefixId"].ToString())) obj.PrefixId = int.Parse(rd["PrefixId"].ToString());
                    if (!String.IsNullOrEmpty(rd["TableName"].ToString())) obj.TableName = rd["TableName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["PrefixCode"].ToString())) obj.PrefixCode = rd["PrefixCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["LengthOfCode"].ToString())) obj.LengthOfCode = int.Parse(rd["LengthOfCode"].ToString());
                    if (!String.IsNullOrEmpty(rd["CheckforMaximum"].ToString())) obj.CheckforMaximum = bool.Parse(rd["CheckforMaximum"].ToString());
                    if (!String.IsNullOrEmpty(rd["UserBranch"].ToString())) obj.UserBranch = int.Parse(rd["UserBranch"].ToString());
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
            }
            return myList;
        }
        public int EditPrefix(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "Proc_EditPrefix",
           "@PrefixId", this.PrefixId,
           "@TableName", this.TableName,
           "@Description", this.Description,
           "@Prefix", this.PrefixCode,
           "@LengthOfCode", this.LengthOfCode,
           "@CheckforMaximum", this.CheckforMaximum,
           "@UserBranch", this.UserBranch);
            if( err=="")
            {
                if(rd.Read ())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            try { rd.Close(); }
            catch {; }

            error = err;

            return id;
        }
    }
}
