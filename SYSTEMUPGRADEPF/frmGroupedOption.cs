using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SYSTEMUPGRADEPF
{
    public partial class frmGroupedOption : Form
    {
        Classes.GroupedOption oGroupedOption = new Classes.GroupedOption();
        Classes.GroupedOption onewGroupedOption = null;

        public frmGroupedOption()
        {
            InitializeComponent();
        }

        private void frmGroupedOption_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oGroupedOption.GetGroupedOptions();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewGroupedOption = (Classes.GroupedOption)objList.SelectedObject;
        }

        private void objList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            string err = "";
            if(onewGroupedOption !=null)
            {
                if(e.Column.AspectName == "BooleanValue")
                {
                    if(e.NewValue .ToString ()!=onewGroupedOption .BooleanValue .ToString ())
                    {
                        onewGroupedOption.BooleanValue =bool.Parse ( e.NewValue.ToString());
                        onewGroupedOption.EditGroupOption(ref err);
                    }
                }
                if(e.Column.AspectName == "TextValue")
                {
                    if(e.NewValue .ToString ()!=onewGroupedOption.TextValue .ToString ())
                    {
                        onewGroupedOption.TextValue = e.NewValue.ToString();
                        onewGroupedOption.EditGroupOption(ref err);
                    }
                }
                if(e.Column.AspectName == "NumberValue")
                {
                    if(e.NewValue .ToString ()!=onewGroupedOption .NumberValue .ToString ())
                    {
                        onewGroupedOption.NumberValue = int.Parse (e.NewValue.ToString());
                        onewGroupedOption.EditGroupOption(ref err);
                    }
                }
            }
        }
    }
}
