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
    public partial class frmSearchMemberDocument : Form
    {
        
       
        
        public frmSearchMemberDocument()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        private bool _pickingvalues = false;

        public bool PickingValues { get { return _pickingvalues; }set { _pickingvalues = value; } }
        private int _memberId=0;
        public int MemberId { get { return _memberId; } set { _memberId = value; } }


        //ArrayList mylist = new ArrayList();
        

        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;
        private void objListDocuments_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchMemberDocument_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadValues();

        }

        private void LoadValues()
        {
            ArrayList mylist = new ArrayList();
            ArrayList newList = new ArrayList();
            objListDocuments.Items.Clear();
            mylist = oMemberDocument.GetMemberDocuments();

            if (this.MemberId == 0)
            {

                objListDocuments.SetObjects(mylist);
            }
            else
            {

                foreach (Classes.MemberDocument omedec in mylist)
                {


                    if (this.MemberId == omedec.MemberId)


                    {
                        newList.Add(omedec);
                    }


                }

                objListDocuments.SetObjects(newList);

            }
        }



        private void objListDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objListDocuments!=null)
            { 
            onewMemberDocument = (Classes.MemberDocument)objListDocuments.SelectedObject;
            if (onewMemberDocument != null)
               
                this.selInt = onewMemberDocument.MemberDocumentId;
                

            frmMemberDocument frm = new frmMemberDocument();
            frm.SelectedDocuments = true;

            frm.MemberId = onewMemberDocument.MemberId;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDocument frm = new SYSTEMUPGRADEPF.frmMemberDocument();
            frm.ShowDialog();
            LoadValues();
        }
    }
}
