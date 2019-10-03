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
    public partial class frmSearchMemberApplication : Form
    {
        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();
        Classes.MemberApplication onewMemberApplication = null;

        Classes.Caption Ocaption = new Classes.Caption();

        public int selInt = 0;
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        public frmSearchMemberApplication()
        {
            InitializeComponent();
        }

        private void frmSearchMemberApplication_Load(object sender, EventArgs e)
        {
            LoadMemberApplication();
            ReadCaption();
            
        }

        private void LoadMemberApplication()
        {
            ArrayList myList = new ArrayList();
            myList = oMemberApplication.GetUnpostedMemberApplications();
            objList.Items.Clear();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewMemberApplication = (Classes.MemberApplication)objList.SelectedObject;
            if (onewMemberApplication != null)
                this.selInt = onewMemberApplication.MemberApplicationId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReadCaption()
        {
            ArrayList myList = Ocaption.GetCaptions();
            foreach (Classes .Caption ocap in myList )
            {
                switch (ocap.DefaultCaptionName )
                {

                    case "Employer":
                        string stremployer = ocap.CaptionName;
                        string newemployername = stremployer.Replace(":", string.Empty);
                        olvColumnEmployer.Text = newemployername ;
                        break;
                    case "Station":
                        string strstation = ocap.CaptionName;
                        string newstation = strstation.Replace(":", string.Empty);
                        olvColumnStation.Text = newstation ;
                        break;
                    case "Client Classification":
                        string str = ocap.CaptionName;
                        string newclient = str.Replace(":", string.Empty);
                        olvColumnClientclassifaction.Text = newclient ;
                        break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberApplication frm = new SYSTEMUPGRADEPF.frmMemberApplication();
            frm.ShowDialog();
            
        }
    }
}
