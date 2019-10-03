using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Ben
    {
        private int _benId = 0;
        private int _memberId = 0;
        private string _benCode = "";
        private string _BenName = "";
        private int _relationshipId = 0;
        private DateTime _dateOfBirth = DateTime.Today;
        private string _mobileNumber = "";
        private string _remarks = "";
        private string _MemberName = "";
        private int  _documentTypeid = 0;
        private double _percentageValue =0;
        private bool _isActive = false;

        private string _relationshipName = "";
        private string _description = "";


        public int BenId { get { return _benId; } set { _benId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public string BenCode { get { return _benCode; } set { _benCode = value; } }
        public string BenName { get { return _BenName; } set { _BenName = value; } }
        public int RelationshipId { get { return _relationshipId; } set { _relationshipId = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }
        public string MobileNumber { get { return _mobileNumber; } set { _mobileNumber = value; } }
        public string Remarks { get { return _remarks; } set { _remarks = value; } }
        public string MemberName { get { return _MemberName; } set { _MemberName = value; } }
        public int  DocumentTypeId { get { return _documentTypeid; } set { _documentTypeid = value; } }
        public double PercentageValue { get { return _percentageValue; } set { _percentageValue = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string RelationshipName { get { return _relationshipName; } set { _relationshipName = value; } }
        Relationship oRelationship = new Relationship();

        public string Description { get { return _description; } set { _description = value; } }
        DocumentType oDocumentType = new DocumentType();

        Member oMember = new Member();

        string err="";
        public ArrayList GetBens()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllBens");
            if (err == "")
            {
                while (rd.Read())
                {

                    Ben obj = new Classes.Ben();
                    if (!String.IsNullOrEmpty(rd["BenId"].ToString())) obj.BenId = int.Parse(rd["BenId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BenCode"].ToString())) obj.BenCode = rd["BenCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["BenName"].ToString())) obj.BenName = rd["BenName"].ToString();
                    if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                    if (!String.IsNullOrEmpty(rd["MobileNumber"].ToString())) obj.MobileNumber = rd["MobileNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId =int.Parse( rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PercentageValue"].ToString())) obj.PercentageValue = double.Parse(rd["PercentageValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());


                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if(obj.RelationshipId >0)
                    {
                        Relationship myRelationship = oRelationship.GetRelationship(obj.RelationshipId);
                        if (myRelationship != null)
                            obj.RelationshipName = myRelationship.RelationshipName;
                    }
                    if(obj.DocumentTypeId >0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.Description = myDocumentType.Description;
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
        

        public Ben GetBen(int BenId)
        {
            Ben obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getBen", "@BenId",BenId);
            if(err=="")
            {
                if(rd.Read())
                {
                    obj = new Classes.Ben();
                    if (!String.IsNullOrEmpty(rd["BenId"].ToString())) obj.BenId = int.Parse(rd["BenId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["BenCode"].ToString())) obj.BenCode = rd["BenCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["BenName"].ToString())) obj.BenName = rd["BenName"].ToString();
                    if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DateOfBirth"].ToString())) obj.DateOfBirth = DateTime.Parse(rd["DateOfBirth"].ToString());
                    if (!String.IsNullOrEmpty(rd["MobileNumber"].ToString())) obj.MobileNumber = rd["MobileNumber"].ToString();
                    if (!String.IsNullOrEmpty(rd["Remarks"].ToString())) obj.Remarks = rd["Remarks"].ToString();
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["PercentageValue"].ToString())) obj.PercentageValue = double.Parse(rd["PercentageValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());


                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if (obj.RelationshipId > 0)
                    {
                        Relationship myRelationship = oRelationship.GetRelationship(obj.RelationshipId);
                        if (myRelationship != null)
                            obj.RelationshipName = myRelationship.RelationshipName;
                    }
                    if (obj.DocumentTypeId > 0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.Description = myDocumentType.Description;
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
        public int AddEdit(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditBen",
                "@BenId", this.BenId,
                "@MemberId", this.MemberId,
                "@BenCode", this.BenCode,
                "@BenName", this.BenName,
                "@RelationshipId", this.RelationshipId,
                "@DateOfBirth", this.DateOfBirth,
                "@MobileNumber", this.MobileNumber,
                "@Remarks", this.Remarks,
                "@DocumentTypeId", this.DocumentTypeId,
                "@PercentageValue", this.PercentageValue,
                 "@MachineName", "USER-PC",
                "@CreatedBy","Admin",
                "@IsActive", this.IsActive,
                "@delete",delete);
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
