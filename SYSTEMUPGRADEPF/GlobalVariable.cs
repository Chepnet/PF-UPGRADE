using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEMUPGRADEPF
{
    public static class GlobalVariable
    {
        //public static string connectionstring = ("Data Source=user-pc;Initial Catalog=KREP LOAN DATABASE;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //public static string connectionstring1 = ("Data Source=" + servername +  ";User ID=" + username + ";Password=" + password + ";Initial Catalog=" + dbname + ";Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public static string servername = "";//"user-pc";
        public static string dbname = "";//"KREP LOAN DATABASE";
        public static string username = "";// "sa";
        public static string password = "";//"pass123";

        public static string connectionstring = "";//(" Data Source =  "+servername+"; Initial Catalog = " + dbname + "; Persist Security Info=True;User ID = " + username + "; Password=" + password + " ");

        public static bool readPhotosFromPhotoDb { get; internal set; }
        public static string BuildXmlString(string xmlRootName, string[] values)
        {
            StringBuilder xmlString = new StringBuilder();

            xmlString.AppendFormat("<{0}>", xmlRootName);
            for (int i = 0; i < values.Length; i++)
            {
                xmlString.AppendFormat("<value>{0}</value>", values[i]);
            }
            xmlString.AppendFormat("</{0}>", xmlRootName);

            return xmlString.ToString();
        }
    }
}
