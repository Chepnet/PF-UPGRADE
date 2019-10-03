using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class CompulsoryField
    {
        private int _fieldNameId = 0;
        private string _fieldName = "";
        private bool _isRequired = false;

        public int FieldNameId { get { return _fieldNameId; } set { _fieldNameId = value; } }
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        public bool IsRequired { get { return _isRequired; } set { _isRequired = value; } }


        string err = "";

        public ArrayList GetCompulsoryFields()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllCompulsoryFields");
            if(err=="")
            {
                while(rd.Read())
                {
                    CompulsoryField obj = new Classes.CompulsoryField();
                    if (!String.IsNullOrEmpty(rd["FieldNameId"].ToString())) obj.FieldNameId = int.Parse(rd["FieldNameId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FieldName"].ToString())) obj.FieldName = rd["FieldName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsRequired"].ToString())) obj.IsRequired = bool.Parse(rd["IsRequired"].ToString());

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

        public CompulsoryField GetCompulsoryField (int FieldNameId)
        {
            CompulsoryField obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getCompulsoryField", "@FieldNameId", FieldNameId);
            if(err=="")
            {
                if(rd.Read())
                {
                    obj = new Classes.CompulsoryField();
                    if (!String.IsNullOrEmpty(rd["FieldNameId"].ToString())) obj.FieldNameId = int.Parse(rd["FieldNameId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FieldName"].ToString())) obj.FieldName = rd["FieldName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsRequired"].ToString())) obj.IsRequired = bool.Parse(rd["IsRequired"].ToString());

                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }
            return obj;
        }

        public int EditCompulsoryField(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_EditCompulsoryField",
                "@FieldNameId", this.FieldNameId,
                //"@FieldName", this.FieldName,
                "@IsRequired", this.IsRequired,
                // "@MachineName", "USER-PC",
                "@CreatedBy", "Admin");
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
