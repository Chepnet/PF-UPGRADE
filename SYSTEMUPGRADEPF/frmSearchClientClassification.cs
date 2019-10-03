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
    public partial class frmSearchClientClassification : Form
    {
        Classes.ClientClassification oClientClassification = new Classes.ClientClassification();
        Classes.ClientClassification onewClientClassification = null;

        public int selInt = 0;

        private bool _pickingvalues = false;//creating so as to be used in creating new on the objectlistview if the name does not exist

        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        public frmSearchClientClassification()
        {
            InitializeComponent();
        }

        private void frmSearchClientClassification_Load(object sender, EventArgs e)
        {
            LoadValues();
            panel1.Visible = this.PickingValues;

        }

        private void LoadValues()
        {
            ArrayList myList = new ArrayList();
            objList.Items.Clear();
            myList = oClientClassification.GetClientClassifications();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList.SelectedObject !=null)
            {
                onewClientClassification = (Classes.ClientClassification)objList.SelectedObject;
                if(onewClientClassification !=null)
                
                    this.selInt = onewClientClassification.ClientClassificationId;
                
            }

        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            frmClientClassification frm = new frmClientClassification();
            frm.ShowDialog();
            LoadValues();
        }
    }
}
