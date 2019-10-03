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
    public partial class frmCompulsoryField : Form
    {
        Classes.CompulsoryField oCompulsory = new Classes.CompulsoryField();
        Classes.CompulsoryField onewCompulsory = null;

        public frmCompulsoryField()
        {
            InitializeComponent();
        }

        private void frmCompulsoryField_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList  = oCompulsory.GetCompulsoryFields();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCompulsory = (Classes.CompulsoryField)objList.SelectedObject;
                
        }

        private void objList_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            string err = "";
            if(onewCompulsory !=null)
            {
                if(e.Column .AspectName =="IsRequired")
                {
                    if(e.NewValue.ToString ()!=onewCompulsory.IsRequired .ToString ())
                    {
                        onewCompulsory.IsRequired = bool.Parse (e.NewValue.ToString() );
                        onewCompulsory.EditCompulsoryField (ref err);
                    }
                }
            }
        }
    }
}
