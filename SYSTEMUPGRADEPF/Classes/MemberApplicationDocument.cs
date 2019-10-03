using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Collections;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SYSTEMUPGRADEPF.Classes
{
    class MemberApplicationDocument
    {
        private int _memberApplicationDocumentId = 0;
        private int _memberApplicationId = 0;
        private int _documentTypeId = 0;
        private string _description = "";
        private Image  _photo = null;
        private bool _isActive = false;
        private string _memberName = "";
        private string _documentdescription = "";

        public int MemberApplicationDocumentId { get { return _memberApplicationDocumentId; } set { _memberApplicationDocumentId = value; } }
        public int MemberApplicationId { get { return _memberApplicationId; } set { _memberApplicationId = value; } }
        public int DocumentTypeId { get { return _documentTypeId; } set { _documentTypeId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string DocumentDescription { get { return _documentdescription; } set { _documentdescription = value; } }

        public string MemberName { get { return _memberName; } set { _memberName = value; } }
        MemberApplication oMemberApplication = new MemberApplication();
        DocumentType oDocumentType = new DocumentType();



        string err = "";
        public ArrayList GetMemberApplicationDocuments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllMemberApplicationDocuments");
            if(err=="")
            {
                while (rd.Read ())
                {
                    MemberApplicationDocument obj = new MemberApplicationDocument();
                    if(!String.IsNullOrEmpty(rd["MemberApplicationDocumentId"].ToString())) obj.MemberApplicationDocumentId=int.Parse(rd["MemberApplicationDocumentId"].ToString());
                    if(!String.IsNullOrEmpty(rd["MemberApplicationId"].ToString())) obj.MemberApplicationId=int.Parse(rd["MemberApplicationId"].ToString());
                    if(!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId=int.Parse(rd["DocumentTypeId"].ToString());
                    if(!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description=rd["Description"].ToString();
                  //  if(!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo=int.Parse(rd["Photo"].ToString());
                    if(!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive=bool.Parse(rd["IsActive"].ToString());
                    if(obj.MemberApplicationId >0)
                    {
                        MemberApplication myMemberApplication = oMemberApplication.GetMemberApplication(obj.MemberApplicationId);
                        if (myMemberApplication != null)
                            obj.MemberName  = myMemberApplication.MemberName;
                    }
                    if(obj.DocumentTypeId >0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.DocumentDescription = myDocumentType.Description;
                    }
                    myList.Add(obj);

                }
                try { rd.Close(); }
                catch {; }
            }
            return myList;

        }
        public MemberApplicationDocument  GetMemberApplicationDocument(int MemberApplicationDocumentId)
        {
            MemberApplicationDocument obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getMemberApplicationDocument", "@MemberApplicationDocumentId", MemberApplicationDocumentId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new MemberApplicationDocument();
                    if (!String.IsNullOrEmpty(rd["MemberApplicationDocumentId"].ToString())) obj.MemberApplicationDocumentId = int.Parse(rd["MemberApplicationDocumentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["MemberApplicationId"].ToString())) obj.MemberApplicationId = int.Parse(rd["MemberApplicationId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                   // if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = int.Parse(rd["Photo"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.MemberApplicationId > 0)
                    {
                        MemberApplication myMemberApplication = oMemberApplication.GetMemberApplication(obj.MemberApplicationId);
                        if (myMemberApplication != null)
                            obj.MemberName = myMemberApplication.MemberName;
                    }
                    if (obj.DocumentTypeId > 0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.DocumentDescription = myDocumentType.Description;
                    }

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;

        }
        public int AddEditMemberApplicationDocument(bool delete,ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_AddEditMemberApplicationDocument", 
                "@MemberApplicationDocumentId", this.MemberApplicationDocumentId,
"@MemberApplicationId", this.MemberApplicationId,
"@DocumentTypeId", this.DocumentTypeId,
"@Description", this.Description,
"@Photo","",
"@IsActive", this.IsActive,
"@MachineName", "USER-PC",
"@CreatedBy", "Admin",
"@delete",delete );

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
        public int saveMemberApplicationPhoto(Image Photo)
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
            SqlCommand cmd = new SqlCommand("proc_SaveMemberApplicationPhoto ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MemberApplicationDocumentId", this.MemberApplicationDocumentId );
            cmd.Parameters.AddWithValue("@Photo", img);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public Image getMemberApplicationPhoto(int MemberApplicationDocumentId)
        {

            Image myPhoto = null;

            Link MyLink = new Link();
            if (GlobalVariable.readPhotosFromPhotoDb)
            {
                DbDataReader rd = MyLink.GetDBResults(ref err, "proc_getMemberApplicationPhoto",
                "@MemberApplicationDocumentId", MemberApplicationDocumentId);
                if (err == "")
                {
                    if (rd.Read())
                    {
                        try
                        {
                            myPhoto = ByteToImage((Byte[])rd["Photo"]);
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
                DbDataReader rd = MyLink.GetDBResults(ref err, "proc_getMemberApplicationPhoto",
                "@MemberApplicationDocumentId", MemberApplicationDocumentId);
                if (err == "")
                {
                    if (rd.Read())
                    {
                        try
                        {
                            myPhoto = ByteToImage((Byte[])rd["Photo"]);
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
