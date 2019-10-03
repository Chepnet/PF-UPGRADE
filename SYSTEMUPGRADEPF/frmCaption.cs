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
    public partial class frmCaption : Form
    {
        Classes.Caption oCaption = new Classes.Caption();
        Classes.Caption onewCaption = null;
        public frmCaption()
        {
            InitializeComponent();
        }

        private void frmCaption_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oCaption.GetCaptions();
            objList.SetObjects(myList);
        }

        private void objList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            string err = "";
            if(onewCaption !=null)
            {
                if(e.Column.AspectName =="CaptionName")
                { 
                if (e.NewValue.ToString() != onewCaption.CaptionName )//change a specific aspectname
                {
                    onewCaption.CaptionName = e.NewValue.ToString();
                    onewCaption.EditCaption(ref err);//call EditCaption Method so as to change the Caption name
                }
                }
            }

        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCaption = (Classes.Caption)objList.SelectedObject;
        }
    }
}
