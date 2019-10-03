using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class SetupRule
    {
        private int _fieldId = 0;
        private string _fieldCode = "";
        private string _fieldName = "";
        private bool _isActive = false;

        public int FieldId { get { return _fieldId; } set { _fieldId = value; } }
        public string FieldCode { get { return _fieldCode; } set { _fieldCode = value; } }
        public string FieldName { get { return _fieldName; } set { _fieldName = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

      public string err = "";
        public ArrayList GetSetupRules()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllSetupRules");
            if(err=="")
            { 
                while(rd.Read ())
                {
                    SetupRule obj = new Classes.SetupRule();
                    if (!String.IsNullOrEmpty(rd["FieldId"].ToString())) obj.FieldId = int.Parse(rd["FieldId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FieldCode"].ToString())) obj.FieldCode = rd["FieldCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["FieldName"].ToString())) obj.FieldName = rd["FieldName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }

            return myList;
        }
        public SetupRule GetSetupRule(int FieldId)
        {
            SetupRule obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getSetupRule", "@FieldId", FieldId);
            if (err == "")
            { 
                if(rd.Read())
                {
                    obj = new Classes.SetupRule();
                    if (!String.IsNullOrEmpty(rd["FieldId"].ToString())) obj.FieldId = int.Parse(rd["FieldId"].ToString());
                    if (!String.IsNullOrEmpty(rd["FieldCode"].ToString())) obj.FieldCode = rd["FieldCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["FieldName"].ToString())) obj.FieldName = rd["FieldName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                  
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditSetupRule(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditSetupRule",
               "@FieldId", this.FieldId,
               "@FieldCode", this.FieldCode,
               "@FieldName", this.FieldName,
               "@IsActive", this.IsActive,
                "@MachineName", "USER-PC",
               "@CreatedBy", "Admin",
                "@delete", delete);
            if (err == "")
            {

            
                if(rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            return id; 
        }

    }

}
