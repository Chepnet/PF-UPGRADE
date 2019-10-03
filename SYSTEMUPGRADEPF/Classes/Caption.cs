using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF.Classes
{
    class Caption
    {
        private int _captionId = 0;
        private string _defaultCaptionName = "";
        private string _captionName = "";

        public int CaptionId { get { return _captionId; } set { _captionId = value; } }
        public string DefaultCaptionName { get { return _defaultCaptionName; } set { _defaultCaptionName = value; } }
        public string CaptionName { get { return _captionName; } set { _captionName = value; } }

        public string err = "";

        public ArrayList GetCaptions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllCaptions");
            if (err == "")
            {
                while (rd.Read())
                {
                    Caption obj = new Classes.Caption();
                    if (!String.IsNullOrEmpty(rd["CaptionId"].ToString())) obj.CaptionId = int.Parse(rd["CaptionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCaptionName"].ToString())) obj.DefaultCaptionName = rd["DefaultCaptionName"].ToString();
                    if (!String.IsNullOrEmpty(rd["CaptionName"].ToString())) obj.CaptionName = rd["CaptionName"].ToString();
                    myList.Add(obj);
                }
                try { rd.Close(); }
                catch {; }
            }

            return myList;
        }

        public Caption GetCaption(int CaptionId)
        {
            Caption obj = null;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getCaption", "@CaptionId", CaptionId);
            if (err == "")
            {
                if (rd.Read())
                {
                    obj = new Classes.Caption();
                    if (!String.IsNullOrEmpty(rd["CaptionId"].ToString())) obj.CaptionId = int.Parse(rd["CaptionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["DefaultCaptionName"].ToString())) obj.DefaultCaptionName = rd["DefaultCaptionName"].ToString();
                    if (!String.IsNullOrEmpty(rd["CaptionName"].ToString())) obj.CaptionName = rd["CaptionName"].ToString();

                }
                try { rd.Close(); }
                catch {; }
            }
            return obj;
        }

        public int EditCaption(ref string error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_EditCaption",
               "@CaptionId", this.CaptionId,
               "@DefaultCaptionName", this.DefaultCaptionName,
               "@CaptionName", this.CaptionName,
               "@CreatedBy", "Admin");

            error = err;
            if (err == "")
            {


                if (rd.Read())
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
