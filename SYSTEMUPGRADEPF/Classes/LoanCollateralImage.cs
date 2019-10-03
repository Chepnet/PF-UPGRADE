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
    class LoanCollateralImage
    {
        private int _loanCollateralImageId = 0;
        private int _loanApplicationCollateralId = 0;
        private string _description = "";
        private Image _photo = null;
        private bool _isActive = false;
        private string _collateralName = "";


        public int LoanCollateralImageId { get { return _loanCollateralImageId; } set { _loanCollateralImageId = value; } }
        public int LoanApplicationCollateralId { get { return _loanApplicationCollateralId; } set { _loanApplicationCollateralId = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Image Photo { get { return _photo; } set { _photo = value; } }
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public string CollateralName { get { return _collateralName; } set { _collateralName = value; } }


        LoanApplicationCollateral oLoanApplicationCollateral = new LoanApplicationCollateral();
        string err = "";

        public ArrayList GetLoanCollateralImages()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllLoanCollateralImages");
            if (err == "")
            {
                while (rd.Read())
                {
                    LoanCollateralImage obj = new Classes.LoanCollateralImage();
                    if (!String.IsNullOrEmpty(rd["LoanCollateralImageId"].ToString())) obj.LoanCollateralImageId = int.Parse(rd["LoanCollateralImageId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationCollateralId"].ToString())) obj.LoanApplicationCollateralId = int.Parse(rd["LoanApplicationCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                   // if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = rd["Photo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if(obj.LoanApplicationCollateralId >0)
                    {
                        LoanApplicationCollateral myLoanCollateral = oLoanApplicationCollateral.GetLoanApplicationCollateral(obj.LoanApplicationCollateralId);
                        if (myLoanCollateral != null)
                            obj.CollateralName = myLoanCollateral.CollateralName;
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

        public LoanCollateralImage GetLoanCollateralImage(int LoanCollateralImageId)
        {
            LoanCollateralImage obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getLoanCollateralImage", "@LoanCollateralImageId", LoanCollateralImageId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.LoanCollateralImage();
                    if (!String.IsNullOrEmpty(rd["LoanCollateralImageId"].ToString())) obj.LoanCollateralImageId = int.Parse(rd["LoanCollateralImageId"].ToString());
                    if (!String.IsNullOrEmpty(rd["LoanApplicationCollateralId"].ToString())) obj.LoanApplicationCollateralId = int.Parse(rd["LoanApplicationCollateralId"].ToString());
                    if (!String.IsNullOrEmpty(rd["Description"].ToString())) obj.Description = rd["Description"].ToString();
                    //if (!String.IsNullOrEmpty(rd["Photo"].ToString())) obj.Photo = rd["Photo"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsActive"].ToString())) obj.IsActive = bool.Parse(rd["IsActive"].ToString());
                    if (obj.LoanApplicationCollateralId > 0)
                    {
                        LoanApplicationCollateral myLoanCollateral = oLoanApplicationCollateral.GetLoanApplicationCollateral(obj.LoanApplicationCollateralId);
                        if (myLoanCollateral != null)
                            obj.CollateralName = myLoanCollateral.CollateralName;
                    }
                }
                try
                {
                    rd.Close();
                }
                catch
                {
                    ;
                }
            }

            return obj;
        }

        public int saveLoanCollateralDoc(Image Photo)
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
            SqlCommand cmd = new SqlCommand("proc_SaveLoanCollateralImage", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@LoanCollateralImageId", this.LoanCollateralImageId);
            cmd.Parameters.AddWithValue("@Photo", img);

            if (conn.State == ConnectionState.Closed)
                conn.Open();

            int x = cmd.ExecuteNonQuery();
            conn.Close();
            return x;

        }
        private byte[] imageToByte(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public Image getLoanCollateralPhoto(int LoanCollateralImageId)
        {

            Image myPhoto = null;

            Link MyLink = new Link();
            if (GlobalVariable.readPhotosFromPhotoDb)
            {
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getLoanCollateralPhoto",
                "@LoanCollateralImageId", LoanCollateralImageId);
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
                DbDataReader rd = MyLink.GetDBResults(ref err, "sp_getLoanCollateralPhoto",
                "@LoanCollateralImageId", LoanCollateralImageId );
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
        private Image ByteToImage(Byte[] byt)
        {
            MemoryStream ms = new MemoryStream(byt);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        public int AddEditCollateralsImage(bool delete, ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_AddEditLoanCollateralImage",
                "@LoanCollateralImageId", this.LoanCollateralImageId,
"@LoanApplicationCollateralId", this.LoanApplicationCollateralId,
"@Description", this.Description,
"@Photo", "",
"@IsActive", this.IsActive,
"@MachineName", "Zippy-PC",
"@CreatedBy", "Admin",
"@delete", delete
);
            if (err == "")
            {
                if (rd.Read())
                {
                    id = int.Parse(rd["Id"].ToString());
                }
            }
            error = err;
            return id;
        }

    }
}
