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
    public partial class frmSearchMemberShares : Form
    {

        Classes.MemberShare oMemberShare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;

        private bool _pickingvalues = false;
        public bool PickingValues { get { return _pickingvalues; } set { _pickingvalues = value; } }

        public int selInt;
        public frmSearchMemberShares()
        {
            InitializeComponent();
        }

        private void frmSearchMemberShares_Load(object sender, EventArgs e)
        {
            panel1.Visible = PickingValues;
            LoadMemberShares();
        }

        private void LoadMemberShares()
        {
            ArrayList myList = new ArrayList();
            myList = oMemberShare.GetMemberShares();
            objectListView1.SetObjects(myList);
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
                onewMemberShare = (Classes.MemberShare)objectListView1.SelectedObject;
            if (onewMemberShare != null)
                this.selInt = onewMemberShare.MemberShareId;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmMemberShares frm = new frmMemberShares();
            frm.ShowDialog();
            LoadMemberShares();
            
        }
    }
}
