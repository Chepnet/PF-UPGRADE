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
    public partial class frmSearchDocumentType : Form
    {
        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;
        public int selInt = 0;

        private bool _pickingvalues = false;

        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        public frmSearchDocumentType()
        {
            InitializeComponent();
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchDocumentType_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            ArrayList myList = new ArrayList();
            myList = oDocumentType.GetDocumentTypes();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList.SelectedObject  !=null )
            {
                onewDocumentType = (Classes.DocumentType)objList.SelectedObject;
                if (onewDocumentType != null)
                    this.selInt = onewDocumentType.DocumentTypeId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmDocumentType frm = new frmDocumentType();
            frm.ShowDialog();
            LoadDocuments();
        }
    }
}
