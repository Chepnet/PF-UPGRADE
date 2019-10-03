using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEMUPGRADEPF
{

    public partial class frmSearchKinDocument : Form
    {
        public frmSearchKinDocument()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        ArrayList mylist = new ArrayList();

        Classes.KinDocument oKinDocument = new Classes.KinDocument();
        Classes.KinDocument onewKinDocument = null;


        private void frmSearchKinDocument_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oKinDocument.GetKinDocuments();
            objList.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList!=null)
            {
                onewKinDocument = (Classes.KinDocument)objList.SelectedObject;
                if (onewKinDocument != null)
                    this.selInt = onewKinDocument.KinDocumentId;
            }
        }
        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
