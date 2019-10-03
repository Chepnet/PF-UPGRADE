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
    class KinDocument
    {
        private int _kinDocumentId = 0;
        private int _kinId = 0;
        private int _documentTypeId = 0;
        private string _description = "";
        private Image _photo = null;
        private bool _isActive = false;
        private string _kinName = "";

        private string _documenttypedescription = "";

        public int KinDocumentId { get { return _kinDocumentId; } set { _kinDocumentId = value; } }
        public int KinId { get { return _kinId; } set { _kinId = value; } }
        public int DocumentTypeId { get { return _documentTypeId; } set { _documentTypeId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }

        public string DocumentTypeDescription { get { return _documenttypedescription; } set { _documenttypedescription = value; } }
        public string KinName { get { return _kinName ; } set { _kinName = value; } }
        DocumentType oDocumentType = new DocumentType();
        Kin oKin = new Kin();

        string err="";

        public ArrayList GetKinDocuments()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllKinDocuments");
            if (err == "")
            {
                while(rd.Read())
                {
                    KinDocument obj = new KinDocument();
                    if (!String.IsNullOrEmpty(rd["KinDocumentId"].ToString())) obj.KinDocumentId = int.Parse(rd["KinDocumentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["KinId"].ToString())) obj.KinId = int.Parse(rd["KinId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());

                    if(obj.DocumentTypeId>0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.DocumentTypeDescription = myDocumentType.Description;
                    }
                    if (obj.KinId > 0)
                    {
                        Kin myKin = oKin .GetKin (obj.KinId );
                        if (myKin != null)
                            obj.KinName = myKin .KinName;
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

        public KinDocument GetKinDocument(int KinDocumentId)
        {
            KinDocument obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getKinDocument", "@KinDocumentId", KinDocumentId);
            if(err=="")
            {
                if(rd.Read())
                {
                    obj = new Classes.KinDocument();
                    if (!String.IsNullOrEmpty(rd["KinDocumentId"].ToString())) obj.KinDocumentId = int.Parse(rd["KinDocumentId"].ToString());
                    if (!String.IsNullOrEmpty(rd["KinId"].ToString())) obj.KinId = int.Parse(rd["KinId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DocumentTypeId"].ToString())) obj.DocumentTypeId = int.Parse(rd["DocumentTypeId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.DocumentTypeId > 0)
                    {
                        DocumentType myDocumentType = oDocumentType.GetDocumentType(obj.DocumentTypeId);
                        if (myDocumentType != null)
                            obj.DocumentTypeDescription = myDocumentType.Description;
                    }
                    if (obj.KinId > 0)
                    {
                        Kin myKin = oKin.GetKin(obj.KinId);
                        if (myKin != null)
                            obj.KinName = myKin.KinName;
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
        
        public int AddEdit(bool delete, ref string  error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditKinDocument",
                "@KinDocumentId", this.KinDocumentId,
                "@KinId", this.KinId,
                "@DocumentTypeId", this.DocumentTypeId,
                "@Description", this.Description,
                "@Photo", "",
                "@IsActive", this.IsActive,
                "@CreatedBy","Admin",
                 "@MachineName", "USER-PC",
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
        public int saveKinPhoto(Image Photo)
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
            SqlCommand cmd = new SqlCommand("proc_SaveKinImage ", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@KinDocumentId", this.KinDocumentId);
            cmd.Parameters.AddWithValue("@Photo", img);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        public Image getKinPhoto(int KinDocumentId)
        {

            Image myPhoto = null;

            Link MyLink = new Link();
            if (GlobalVariable.readPhotosFromPhotoDb)
            {
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getKinPhoto",
                "@KinDocumentId", KinDocumentId);
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
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getKinPhoto",
                "@KinDocumentId", KinDocumentId);
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
