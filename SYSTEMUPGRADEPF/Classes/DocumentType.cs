using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class DocumentType
    {
        private int _documentTypeId = 0;
        private string _description = "";
        private bool _isActive = false;

        public int DocumentTypeId { get { return _documentTypeId; } set { _documentTypeId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }


        public string err = "";
        public ArrayList GetDocumentTypes()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllDocumentTypes");
            if(err=="")
            {
                while(rd.Read())
                {
                    DocumentType obj = new Classes.DocumentType();
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);

                }
            }
            return myList;


        }

        public DocumentType GetDocumentType(int DocumentTypeId)
        {
            DocumentType obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getDocumentType", "@DocumentTypeId", DocumentTypeId);
            if(err=="")
            {
                if(rd.Read())
                {
                     obj = new Classes.DocumentType();
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }
        public int AddEditDocumentType(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditDocumentType",
                "@DocumentTypeId", this.DocumentTypeId,
                "@Description", this.Description,
                "@IsActive", this.IsActive,
                "@CreatedBy", "Admin",
                 "@MachineName", "USER-PC",
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
