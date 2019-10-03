using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;

namespace SYSTEMUPGRADEPF.Classes
{
    class Relationship
    {
        private int _relationshipId = 0;
        private string _relationshipName = "";
        private bool _isActive = false;


        public int RelationshipId { get { return _relationshipId; } set { _relationshipId = value; } }
        public string RelationshipName { get { return _relationshipName; } set { _relationshipName = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string err="";

        public ArrayList GetRelationships()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllRelationships");
            if(err=="")
            {
                while(rd.Read())
                {
                    Relationship obj = new Classes.Relationship();
                    if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RelationshipName"].ToString())) obj.RelationshipName = rd["RelationshipName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    myList.Add(obj);

                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;
        }

        public Relationship GetRelationship(int RelationshipId)
        {
            Relationship obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getRelationship", "@RelationshipId", RelationshipId);
            if(err=="")
            {

            
                if(rd.Read())
                {
                    obj = new Classes.Relationship();
                    if (!String.IsNullOrEmpty(rd["RelationshipId"].ToString())) obj.RelationshipId = int.Parse(rd["RelationshipId"].ToString());
                    if (!String.IsNullOrEmpty(rd["RelationshipName"].ToString())) obj.RelationshipName = rd["RelationshipName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                   

                }
            try { rd.Close(); }
            catch {; }
            }
            return obj;
        }
        public int AddEditRelationship(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditRelationship",
                "@RelationshipId", this.RelationshipId,
                "@RelationshipName", this.RelationshipName,
                "@IsActive", this.IsActive,
                "@CreatedBy", "Admin",
                 "@MachineName", "USER-PC",
                 "@delete", delete ) ;
            if(err=="")
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
