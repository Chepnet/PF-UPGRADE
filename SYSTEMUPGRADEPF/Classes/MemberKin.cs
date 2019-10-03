using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class MemberKin
    {
        private int _memberKinId = 0;
        private string _memberName = "";
        private string _memberNo = "";
        private string _kinName = "";
        private string _relationship = "";


        public int MemberKinId { get { return _memberKinId; } set { _memberKinId = value; } }
        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        public string MemberNo { get { return _memberNo; } set { _memberNo = value; } }
        public string KinName { get { return _kinName; } set { _kinName = value; } }
        public string Relationship { get { return _relationship; } set { _relationship = value; } }


        string err = "";
        public ArrayList GetMemberKins()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, " PROC_getAllMemberKin");
            if (err == "")
            {
                while (rd.Read())
                {

                    MemberKin obj = new Classes.MemberKin();
                    if (!String.IsNullOrEmpty(rd["MemberKinId"].ToString())) obj.MemberKinId = int.Parse(rd["MemberKinId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberNo"].ToString())) obj.MemberNo = rd["MemberNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["KinName"].ToString())) obj.KinName = rd["KinName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Relationship"].ToString())) obj.Relationship = rd["Relationship"].ToString();

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


        public MemberKin GetMemberKin(int MemberKinId)
        {
            MemberKin obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMemberKin", "@MemberKinId", MemberKinId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.MemberKin();
                    if (!String.IsNullOrEmpty(rd["MemberKinId"].ToString())) obj.MemberKinId = int.Parse(rd["MemberKinId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberName"].ToString())) obj.MemberName = rd["MemberName"].ToString();
                    if (!String.IsNullOrEmpty(rd["MemberNo"].ToString())) obj.MemberNo = rd["MemberNo"].ToString();
                    if (!String.IsNullOrEmpty(rd["KinName"].ToString())) obj.KinName = rd["KinName"].ToString();
                    if (!String.IsNullOrEmpty(rd["Relationship"].ToString())) obj.Relationship = rd["Relationship"].ToString();


                   
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;
        }
        public int AddEdit(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "pro_AddEditMemberKin",
               "@MemberKinId", this.MemberKinId,
            "@MemberName", this.MemberName,
            "@MemberNo", this.MemberNo,
            "@KinName", this.KinName,
            "@Relationship", this.Relationship,

                "@delete", delete);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); } catch {; }
            }
            error = err;

            return id;
        }
    }
}
