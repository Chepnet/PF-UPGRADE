
       using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Reflection;

namespace SYSTEMUPGRADEPF.Classes
    {
        class Link
        {
            DbDataReader rs = null;
            DbDataReader ResultSet = null;

            string msg = "";



            public int executeString(string sql)
            {
                int x = 1;
                SqlConnection conn = new SqlConnection(GlobalVariable.connectionstring);
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                try
                {
                    x = cmd.ExecuteNonQuery();
                }
                catch
                {
                    x = 0;
                }
                finally
                {
                    conn.Close();
                }
                return x;
            }

            //public int NEWSERIALID()
            //{
            //    int newserialid = 0;
            //    string errmsg = "";
            //    Classes.MainInfo.fetchAllInfo(true); //am not sure if this will slow the system but it will make sure that the date is always correct and that is the one from the db
            //    Classes.Link myLink = new PowerFinancials.Classes.Link();
            //    DbDataReader rd = myLink.GetDBResults(ref errmsg, "sp_NewSerial",
            //    "@CreatedBy", GlobalVariable.LOGGEDINUSER_NAME);
            //    if (errmsg == "")
            //    {
            //        if (rd.Read())
            //        {
            //            newserialid = int.Parse(rd["SerialId"].ToString());
            //        }
            //        try { rd.Close(); rd.Dispose(); }
            //        catch {; }
            //    }
            //    return newserialid;
            //}


            

            public DbDataReader GetDBResults(ref String errMsg, string StoredProcedure, params object[] ProcedureParameters)
            {

                int i = 0;
                errMsg = "";

                if (GlobalVariable.connectionstring == "")
                {
                    Configuration oconfig = new Configuration();
                    oconfig = Configuration.Deserialize("config.xml");

                    string svrname = oconfig.ServerName;
                    string dbname = oconfig.DbName;
                    string username = oconfig.UserName;
                    string sActive = oconfig.Active;

                    string pwd = "";// oconfig.Password; // decript if twas encrypted string pwd =GlobalVariable.Decrypt(oconfig.Password); // decript if twas encrypted
                    //if (sActive == "1")
                    //{
                    //    pwd = GlobalVariable.Decrypt(oconfig.Password);
                    //}
                    //else
                        pwd = oconfig.Password; // decript if twas encrypted string pwd =GlobalVariable.Decrypt(oconfig.Password); // decript if twas encrypted


                    GlobalVariable.dbname = dbname;
                    GlobalVariable.password = pwd;
                    GlobalVariable.servername = svrname;
                    GlobalVariable.username = username;

                    string strpwd = "";
                    //if (oconfig.SMSPassword != "")
                    //    strpwd = GlobalVariable.Decrypt(oconfig.SMSPassword);

                    //GlobalVariable.SMSPassword = strpwd;// oconfig.SMSPassword;
                    //GlobalVariable.SMSSenderId = oconfig.SMSSenderId;
                    //GlobalVariable.SMSUserName = oconfig.SMSUserName;


                    GlobalVariable.connectionstring = "Data Source=" + svrname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + pwd + ";Integrated Security=false; Connect Timeout=3000";
                }

                if (GlobalVariable.connectionstring == "") return null;
                //string ParameterName = "";
                string SQLStatement = "";
                string DataProviderName = "System.Data.SqlClient";
                DbProviderFactory dpf = DbProviderFactories.GetFactory(DataProviderName);
                DbConnection objconnection = dpf.CreateConnection();
                objconnection.ConnectionString = GlobalVariable.connectionstring; // "Data Source=USER-030C791BB9;Initial Catalog=Version2;Integrated Security=True";
                try
                {
                    objconnection.Open();
                }
                catch (System.InvalidOperationException ex)
                {
                    errMsg = ex.Message.ToString();
                    return rs;
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    errMsg = ex.Message.ToString();
                    return rs;
                }
                catch (System.Exception ex)
                {
                    errMsg = ex.Message.ToString();
                    return rs;
                }

                DbCommand Command = dpf.CreateCommand();
                Command.Connection = objconnection;

                string mystring = "";

                //if (HttpContext.Current.Session["DBType"].ToString() == "MSSQL")
                //{
                foreach (object o in ProcedureParameters)
                {
                    if (i % 2 == 0)
                        SQLStatement = SQLStatement + (string)o + "=";
                    else
                    {
                        if (o.GetType() == typeof(string))
                        {
                            mystring = (string)o;
                            mystring = mystring.Replace("'", "''");
                            SQLStatement = SQLStatement + " '" + mystring + "',";
                        }
                        else if (o.GetType() == typeof(DateTime))
                            SQLStatement = SQLStatement + " '" + o.ToString() + "',";
                        else if (o.GetType() == typeof(Int32))
                            SQLStatement = SQLStatement + o.ToString() + ",";
                        else if (o.GetType() == typeof(Double))
                            SQLStatement = SQLStatement + o.ToString() + ",";
                        else if (o.GetType() == typeof(Int32))
                            SQLStatement = SQLStatement + o.ToString() + ",";
                        else if (o.GetType() == typeof(Byte[]))
                            SQLStatement = SQLStatement + o.ToString() + ",";
                        else if (o.GetType() == typeof(Boolean))
                        {
                            if ((bool)o == true)
                                SQLStatement = SQLStatement + " 1" + ",";
                            else
                                SQLStatement = SQLStatement + " 0" + ",";
                        }
                        else
                            SQLStatement = SQLStatement + " '" + (string)o + "',";

                    }
                    i = i + 1;
                }
                if (SQLStatement.Length > 1)
                    SQLStatement = SQLStatement.Substring(0, SQLStatement.Length - 1);

                StoredProcedure = "EXEC " + StoredProcedure + " " + SQLStatement;

                //if (GlobalVariable.TurnOnLogInfo)
                //{
                //    LogWriter myWriter = new LogWriter(StoredProcedure);
                //}
                Command.CommandTimeout = 3600;
                Command.CommandType = CommandType.Text;
                Command.CommandText = StoredProcedure;
                try
                {
                    ResultSet = Command.ExecuteReader(CommandBehavior.CloseConnection);
                }
                catch (SqlException ex)
                {
                    errMsg = ex.Message.ToString();
                    return rs;
                }
                return ResultSet;
                //}

            }

        }

       

        #region -- Configuration Class --
        /// <summary>
        /// This Configuration class is basically just a set of 
        /// properties with a couple of static methods to manage
        /// the serialization to and deserialization from a
        /// simple XML file.
        /// </summary>
        [Serializable]
        public class Configuration
        {
            string _servername;
            string _dbname;
            string _userid;
            string _pwd;

            string _smsUserName = "";
            string _smsPassword = "";
            string _smsSenderId = "";
            string _active = "";

            public Configuration()
            {
                _servername = "";
                _dbname = "";
                _userid = "";
                _pwd = "";
                _active = "";
            }
            public static void Serialize(string file, Configuration c)
            {
                System.Xml.Serialization.XmlSerializer xs
                   = new System.Xml.Serialization.XmlSerializer(c.GetType());
                StreamWriter writer = File.CreateText(file);
                xs.Serialize(writer, c);
                writer.Flush();
                writer.Close();
            }
            public static Configuration Deserialize(string file)
            {
                System.Xml.Serialization.XmlSerializer xs
                   = new System.Xml.Serialization.XmlSerializer(
                      typeof(Configuration));
                StreamReader reader = File.OpenText(file);
                Configuration c = (Configuration)xs.Deserialize(reader);
                reader.Close();
                return c;
            }

            public string ServerName
            {
                get { return _servername; }
                set { _servername = value; }
            }
            public string DbName
            {
                get { return _dbname; }
                set { _dbname = value; }
            }

            public string UserName
            {
                get { return _userid; }
                set { _userid = value; }
            }
            public string Password
            {
                get { return _pwd; }
                set { _pwd = value; }
            }
            public string SMSUserName
            {
                get { return _smsUserName; }
                set { _smsUserName = value; }
            }
            public string SMSPassword
            {
                get { return _smsPassword; }
                set { _smsPassword = value; }
            }
            public string SMSSenderId
            {
                get { return _smsSenderId; }
                set { _smsSenderId = value; }
            }
            public string Active
            {
                get { return _active; }
                set { _active = value; }
            }
        }
        #endregion
    }

