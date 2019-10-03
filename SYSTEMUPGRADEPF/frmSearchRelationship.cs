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
    public partial class frmSearchRelationship : Form
    {
        Classes.Relationship oRelationship = new Classes.Relationship();
        Classes.Relationship onewRelationship = null;

        public int selInt = 0;

        private bool _pickingValues;

        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }

        public frmSearchRelationship()
        {
            InitializeComponent();
        }

        private void frmSearchRelationship_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;

            LoadValues();
        }

        private void LoadValues()
        {
            ArrayList myList = new ArrayList();
            objList.Items.Clear();
            myList = oRelationship.GetRelationships();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewRelationship = (Classes.Relationship)objList.SelectedObject;
            if (onewRelationship != null)

                this.selInt = onewRelationship.RelationshipId;


        }


        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmRelationship frm = new SYSTEMUPGRADEPF.frmRelationship();
            frm.ShowDialog();
            LoadValues();
        }
    }
}
