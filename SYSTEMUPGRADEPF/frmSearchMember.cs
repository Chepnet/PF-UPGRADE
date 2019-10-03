using System;
using System.Collections;
using System.Windows.Forms;

namespace SYSTEMUPGRADEPF
{
    public partial class frmSearchMember : Form
    {
        Classes.Caption oCaption = new Classes.Caption();



        public frmSearchMember()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        ArrayList mylist = new ArrayList();


        Classes.Member OMember = new Classes.Member();
        Classes.Member onewMember = null;
        private void frmSearchMember_Load(object sender, EventArgs e)
        {
            LoadMembers();
            ReadCaption();
            panel1.Visible = this.PickingValues;
        }

        private void LoadMembers()
        {
            ArrayList mylist = new ArrayList();
            mylist = OMember.GetMembers();
            objListMember.SetObjects(mylist);
            //objListMember.Items.Clear();
        }

        private void objListMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListMember.SelectedObject != null)
            {
                onewMember = (Classes.Member)objListMember.SelectedObject;
                if (onewMember != null)
                    this.selInt = onewMember.MemberId;
            }
        }

        private void objListMembers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList)
            {
                switch (ocap.DefaultCaptionName)
                {
                    //case "Employer":
                    //   olvColumnEmployerName .Text = ocap.CaptionName;
                    //    break;
                    //case "Station":
                    //    olvColumnStationName .Text = ocap.CaptionName;
                    //    break;
                    //case "Client Classification":
                    //    olvColumnClientClassification .Text = ocap.CaptionName;
                    //    break;

                    //changed to this new value since the label had column
                    //how to remove the character like : in the label from being displayed 
                    // string stremployer = ocap.CaptionName;
                    //string newemployername = stremployer.Replace(":", string.Empty);
                    //olvColumnEmployerName.Text = newemployername;
                    //before it was like this
                    // olvColumnEmployerName .Text = ocap.CaptionName;
                    //olvcolumnemployername.text=ocap.captionname is the code that is used to change the name of the aspectname of the objectlistview


                    case "Employer":
                        string stremployer = ocap.CaptionName;
                        string newemployername = stremployer.Replace(":", string.Empty);
                        //olvColumnEmployerName.Text = newemployername;
                        break;
                    case "Station":
                        string strstation = ocap.CaptionName;
                        string newstation = strstation.Replace(":", string.Empty);
                        olvColumnStationName.Text = newstation;
                        break;
                    case "Client Classification":
                        string str = ocap.CaptionName;
                        string newclient = str.Replace(":", string.Empty);
                        olvColumnClientClassification.Text = newclient;
                        break;


                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberApplication frm = new SYSTEMUPGRADEPF.frmMemberApplication();
            frm.ShowDialog();
            LoadMembers();
        }
    }
}
