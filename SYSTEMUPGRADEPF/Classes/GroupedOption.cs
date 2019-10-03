using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Common;

namespace SYSTEMUPGRADEPF.Classes
{
    class GroupedOption
    {

        private int _optionId = 0;
        private string _groupOption = "";
        private string _subOption = "";
        private string _optionCode = "";
        private string _optionName = "";
        private bool _isBoolean = false;
        private bool _isNumber = false;
        private bool _booleanValue = false;
        private string _textValue = "";
        private int _numberValue = 0;
       

        public int OptionId { get { return _optionId; } set { _optionId = value; } }
        public string GroupOption { get { return _groupOption; } set { _groupOption = value; } }
        public string SubOption { get { return _subOption; } set { _subOption = value; } }
        public string OptionCode { get { return _optionCode; } set { _optionCode = value; } }
        public string OptionName { get { return _optionName; } set { _optionName = value; } }
        public bool IsBoolean { get { return _isBoolean; } set { _isBoolean = value; } }
        public bool IsNumber { get { return _isNumber; } set { _isNumber = value; } }
        public bool BooleanValue { get { return _booleanValue; } set { _booleanValue = value; } }
        public string TextValue { get { return _textValue; } set { _textValue = value; } }
        public int NumberValue { get { return _numberValue; } set { _numberValue = value; } }
        

        string err = "";
        public ArrayList GetGroupedOptions()
        {
            ArrayList myList = new ArrayList();
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref err, "proc_getAllGroupedOptions");
            if(err=="")
            { 
                while(rd.Read())
                {
                    GroupedOption obj = new GroupedOption();
                    if (!String.IsNullOrEmpty(rd["OptionId"].ToString())) obj.OptionId = int.Parse(rd["OptionId"].ToString());
                    if (!String.IsNullOrEmpty(rd["GroupOption"].ToString())) obj.GroupOption = rd["GroupOption"].ToString();
                    if (!String.IsNullOrEmpty(rd["SubOption"].ToString())) obj.SubOption = rd["SubOption"].ToString();
                    if (!String.IsNullOrEmpty(rd["OptionCode"].ToString())) obj.OptionCode =rd["OptionCode"].ToString();
                    if (!String.IsNullOrEmpty(rd["OptionName"].ToString())) obj.OptionName = rd["OptionName"].ToString();
                    if (!String.IsNullOrEmpty(rd["IsBoolean"].ToString())) obj.IsBoolean = bool.Parse(rd["IsBoolean"].ToString());
                    if (!String.IsNullOrEmpty(rd["IsNumber"].ToString())) obj.IsNumber = bool.Parse(rd["IsNumber"].ToString());
                    if (!String.IsNullOrEmpty(rd["BooleanValue"].ToString())) obj.BooleanValue = bool.Parse(rd["BooleanValue"].ToString());
                    if (!String.IsNullOrEmpty(rd["TextValue"].ToString())) obj.TextValue = rd["TextValue"].ToString();
                    if (!String.IsNullOrEmpty(rd["NumberValue"].ToString())) obj.NumberValue = int.Parse(rd["NumberValue"].ToString());
                  

                    myList.Add(obj);
                }
            try { rd.Close(); }
            catch {; }
            }
            return myList;
        }
        public int EditGroupOption(ref string  error)
        {
            int id = 0;
            Link myLink = new Classes.Link();
            DbDataReader rd = myLink.GetDBResults(ref error, "proc_EditGroupOption",
                "@OptionId", this.OptionId,
                 "@GroupOption", this.GroupOption,
                 "@SubOption", this.SubOption,
                 "@OptionCode", this.OptionCode,
                 "@OptionName", this.OptionName,
                 "@IsBoolean", this.IsBoolean,
                 "@IsNumber", this.IsNumber,
                 "@BooleanValue", this.BooleanValue,
                 "@TextValue", this.TextValue,
                 "@NumberValue", this.NumberValue,
                 "@MachineName", "USER-PC",
                  "@ModifiedBy", "ZIPPY");
            if(err =="")
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


    }
}
