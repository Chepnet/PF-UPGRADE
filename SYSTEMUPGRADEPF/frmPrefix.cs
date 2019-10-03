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
    public partial class frmPrefix : Form
    {
        Classes.Prefix oPrefix = new Classes.Prefix();
        Classes.Prefix onewPrefix = null;

        public frmPrefix()
        {
            InitializeComponent();
        }

        private void frmPrefix_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oPrefix.GetPrefices();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewPrefix = (Classes.Prefix)objList.SelectedObject;

        }

        private void objList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            string err = "";
            if (onewPrefix != null)
            {
                if (e.Column.AspectName == "PrefixCode")
                {
                    if (e.NewValue.ToString() != onewPrefix.ToString())
                    {
                        onewPrefix.PrefixCode = e.NewValue.ToString();
                        onewPrefix.EditPrefix(ref err);

                    }
                }
                if (e.Column.AspectName == "LengthOfCode")
                {
                    if (e.NewValue.ToString() != onewPrefix.ToString())
                    {
                        onewPrefix.LengthOfCode = int.Parse(e.NewValue.ToString());
                        onewPrefix.EditPrefix(ref err);

                    }
                }
            }
        }
    }
}
