using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class MemberDocument
    {
        private int _memberDocumentId = 0;
        private int _memberId = 0;
        private int _documentTypeId = 0;
        private string _description = "";
        private Image _photo = null;
        private string _membername = "";
        private bool _isActive = false;

        private string _documenttypedescription = "";

        public int MemberDocumentId { get { return _memberDocumentId; } set { _memberDocumentId = value; } }
        public int MemberId { get { return _memberId; } set { _memberId = value; } }
        public int DocumentTypeId { get { return _documentTypeId; } set { _documentTypeId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public string MemberName { get { return _membername; } set { _membername = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string DocumentTypeDescription { get { return _documenttypedescription; } set { _documenttypedescription = value; } }

        DocumentType oDocumentType = new DocumentType();

        Member oMember = new Member();

        string err = "";

        public ArrayList GetMemberDocuments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllMemberDocuments");
            
            if (err == "")
            {
                while (rd.Read( ))
                {
                    MemberDocument obj = new Classes.MemberDocument();
                    if (!String.IsNullOrEmpty(rd["MemberDocumentId"].ToString())) obj.MemberDocumentId = int.Parse(rd["MemberDocumentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                   // if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = rd["Photo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if (obj.MemberId > 0)
                    {
                        Member myMember = oMember.GetMember(obj.MemberId);
                        if (myMember != null)
                            obj.MemberName = myMember.MemberName;
                    }
                    if(obj.DocumentTypeId >0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.DocumentTypeDescription = myDocumentType.Description;
                    }

                    myList.Add(obj );
                }
                try
                {
                    rd.Close();
                }
                catch {; }
            }

            return myList ;
        }
        public ArrayList GetMatchedMemberDocuments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMatchedMemberDocuments");
            
            if (err == "")
            {
                while (rd.Read())
                {
                    MemberDocument obj = new Classes.MemberDocument();
                    if (!String.IsNullOrEmpty(rd["MemberDocumentId"].ToString())) obj.MemberDocumentId = int.Parse(rd["MemberDocumentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    // if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = rd["Photo"].ToString();
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
                            obj.DocumentTypeDescription = myDocumentType.Description;
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
        public MemberDocument GetMemberDocument(int MemberDocumentId)
        {
            MemberDocument obj = null;
            Link mylink = new Classes.Link();
            DbDataReader rd = mylink.GetDBResults(ref err, "proc_getMemberDocument", "@MemberDocumentId", MemberDocumentId);
            if (err == "")
            {
                if (rd.Read())
                { 
            obj = new Classes.MemberDocument();
            if (!String.IsNullOrEmpty(rd["MemberDocumentId"].ToString())) obj.MemberDocumentId = int.Parse(rd["MemberDocumentId"].ToString());
            if (!String.IsNullOrEmpty(rd["MemberId"].ToString())) obj.MemberId = int.Parse(rd["MemberId"].ToString());
            if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
            if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
            //if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = rd["Photo"].ToString();
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
                            obj.DocumentTypeDescription = myDocumentType.Description;
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
            Link mylink = new Classes.Link();
            DbDataReader rd = mylink.GetDBResults(ref err, "proc_AddEditMemberDocument",
               "@MemberDocumentId",this.MemberDocumentId,
               "@MemberId", this.MemberId,
               "@DocumentTypeId", this.DocumentTypeId,
               "@Description", this.Description,
               "@Photo","",
               "@IsActive", this.IsActive,
               "@createdBy","Admin",
                "@MachineName", "USER-PC",
               "@delete",delete );
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
        private Image ByteToImage(Byte[] byt)
        {
            MemoryStream ms = new MemoryStream(byt);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private byte[] imageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public int saveMemberPhoto(Image Photo)
        {
            Byte[] img = imageToByte(Photo);

            if (GlobalVariable.connectionstring == "")
            {
                Configuration oconfig = new Configuration();
                oconfig = Configuration.Deserialize("config.xml");

                string svrname = oconfig.ServerName;
                string dbname = oconfig.DbName;
                string username = oconfig.UserName;
                string pwd = oconfig.Password; // decript if twas encrypted


                GlobalVariable.connectionstring = "Data Source=" + svrname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + pwd + ";Integrated Security=false; Connect Timeout=3000";
            }

            if (GlobalVariable.connectionstring == "") return 0;

            SqlConnection conn = new SqlConnection(GlobalVariable.connectionstring); //"Data Source=USER-030C791BB9;Initial Catalog=Version2;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("proc_SaveImage ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MemberDocumentId", this.MemberDocumentId);
            cmd.Parameters.AddWithValue("@Photo", img);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public Image getMemberPhoto(int MemberDocumentId)
        {

            Image myPhoto = null;

            Link MyLink = new Link();
            if (GlobalVariable.readPhotosFromPhotoDb)
            {
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getMemberPhoto",
                "@MemberDocumentId", MemberDocumentId);
                if (err == "")
                {
                    if (rd.Read())
                    {
                        try
                        {
                            myPhoto = ByteToImage((Byte[])rd["photo"]);
                        }
                        catch
                        {
                            myPhoto = null;
                        }
                    }
                    try
                    {
                        rd.Close(); rd.Dispose();
                    }
                    catch {; }
                }
            }
            else
            {
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getMemberPhoto",
                "@MemberDocumentId", MemberDocumentId );
                if (err == "")
                {
                    if (rd.Read())
                    {
                        try
                        {
                            myPhoto = ByteToImage((Byte[])rd["photo"]);
                        }
                        catch
                        {
                            myPhoto = null;
                        }
                    }
                    try
                    {
                        rd.Close(); rd.Dispose();
                    }
                    catch {; }
                }
            }

            return myPhoto;
        }
    }
}
