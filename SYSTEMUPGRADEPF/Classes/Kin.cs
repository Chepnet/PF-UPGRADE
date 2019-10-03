using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Kin
    {
        private int _kinId = 0;
        private int _memberId = 0;
        private string _kinCode = "";
        private string _kinName = "";
        private int _relationshipId = 0;
        private DateTime _dateOfBirth = DateTime.Today;
        private string _mobileNumber = "";
        private string _remarks = "";
        private string _MemberName = "";
        private int _documentTypeId = 0;
        private bool _isActive = false;

        private string _relationshipName = "";

        private string _description = "";


        public int KinId { get { return _kinId; } set { _kinId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string KinCode { get { return _kinCode; } set { _kinCode = value; } }
        public string KinName { get { return _kinName; } set { _kinName = value; } }
        public int RelationshipId { get { return _relationshipId; } set { _relationshipId = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public string MobileNumber { get { return _mobileNumber; } set { _mobileNumber = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string MemberName { get { return _MemberName; } set { _MemberName = value; } }
        public int DocumentTypeId { get { return _documentTypeId; } set { _documentTypeId = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string Description { get { return _description; } set { _description = value; } }
        DocumentType oDocumentType = new DocumentType();

        public string RelationshipName { get { return _relationshipName; } set { _relationshipName = value; } }
        Relationship oRelationship = new Relationship();

        Member oMember = new Member();
        string err = "";
        public ArrayList GetKins()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllKins");
            if (err == "")
            {
                while (rd.Read())
                {
                    Kin obj = new Classes.Kin();
                    if (!String.IsNullOrEmpty(rd["KinId"].ToString())) obj.KinId = int.Parse(rd["KinId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["KinCode"].ToString())) obj.KinCode = rd["KinCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["KinName"].ToString())) obj.KinName = rd["KinName"].ToString();
                    if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                    if (!String.IsNullOrEmpty(rd["MobileNumber"].ToString())) obj.MobileNumber = rd["MobileNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                   
                   
                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }

                    if (obj.DocumentTypeId > 0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.Description = myDocumentType.Description;
                    }
                    if (obj.RelationshipId > 0)
                    {
                        Relationship myRelationship = oRelationship.GetRelationship(obj.RelationshipId);
                        if (myRelationship != null)
                            obj.RelationshipName = myRelationship.RelationshipName;
                    }

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

   
    public Kin GetKin(int KinId)
    {
        Kin obj = null;
        Link myLink = new Classes.Link();
        DbDataReader rd = myLink.GetDBResults(ref err, "proc_getKin", "@KinId", KinId);
        if (err == "")
        {
            if (rd.Read())
            {
                obj = new Classes.Kin();
                if (!String.IsNullOrEmpty(rd["KinId"].ToString())) obj.KinId = int.Parse(rd["KinId"].ToString());
                if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                if (!String.IsNullOrEmpty(rd["KinCode"].ToString())) obj.KinCode = rd["KinCode"].ToString();
                if (!String.IsNullOrEmpty(rd["KinName"].ToString())) obj.KinName = rd["KinName"].ToString();
                if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                if (!String.IsNullOrEmpty(rd["MobileNumber"].ToString())) obj.MobileNumber = rd["MobileNumber"].ToString();
                if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                if (obj.MemberId > 0)
                {
                    Member myMember = oMember.GetMember(obj.MemberId);
                    if (myMember != null)
                        obj.MemberName = myMember.MemberName;
                }
                if (obj.DocumentTypeId > 0)
                {
                    DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                    if (myDocumentType != null)
                        obj.Description = myDocumentType.Description;
                }
                if (obj.RelationshipId > 0)
                {
                    Relationship myRelationship = oRelationship.GetRelationship(obj.RelationshipId);
                    if (myRelationship != null)
                        obj.RelationshipName = myRelationship.RelationshipName;
                }

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
        DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditKin",
            "@KinId", this.KinId,
            "@MemberId", this.MemberId,
            "@KinCode", this.KinCode,
            "@KinName", this.KinName,
            "@RelationshipId", this.RelationshipId,
            "@DateOfBirth", this.DateOfBirth,
            "@MobileNumber", this.MobileNumber,
            "@Remarks", this.Remarks,
            "@DocumentTypeId", this.DocumentTypeId,
            "@IsActive", this.IsActive,
            "@CreatedBy", "Admin",
             "@MachineName", "USER-PC",
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
