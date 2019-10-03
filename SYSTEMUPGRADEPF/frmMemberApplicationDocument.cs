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
    public partial class frmMemberApplicationDocument : Form
    {
        public frmMemberApplicationDocument()
        {
            InitializeComponent();
        }

        private int _memberApplicationId = 0;
        public int MemberApplicationId { get { return _memberApplicationId; } set { _memberApplicationId = value; } }
        Classes.MemberApplicationDocument oMemberApplicationDocument = new Classes.MemberApplicationDocument();
        Classes.MemberApplicationDocument onewMemberApplicationDocument = null;

        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();
        Classes.MemberApplication onewMemberApplication = null;

        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;

        private void btnSearchMemberApplicationId_Click(object sender, EventArgs e)
        {
            frmSearchMemberApplication frm = new frmSearchMemberApplication();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMemberApplication = oMemberApplication.GetMemberApplication(frm.selInt);
            if(onewMemberApplication !=null)
            {
                txtMemberApplicationId.Text = onewMemberApplication.MemberName ;
            }
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewMemberApplicationDocument = null;
            txtMemberApplicationId.Focus();
            
        }

        private void ClearText()
        {
            txtDescription.Text = "";
            txtDocumentType.Text = "";
            //txtMemberApplicationId.Text = "";
            chkIsActive.Checked = true;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchMemberApplicationDocument frm = new frmSearchMemberApplicationDocument();

            frm.MemberApplicationId = onewMemberApplication.MemberApplicationId;
            frm.ShowDialog();
            onewMemberApplicationDocument = oMemberApplicationDocument.GetMemberApplicationDocument(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewMemberApplicationDocument != null)
            {
                txtDescription.Text = onewMemberApplicationDocument.Description;
                onewDocumentType = oDocumentType.GetDocumentType(onewMemberApplicationDocument.DocumentTypeId);
                if (onewDocumentType != null)

                    txtDocumentType.Text = onewDocumentType.Description;
                onewMemberApplication = oMemberApplication.GetMemberApplication(onewMemberApplicationDocument.MemberApplicationId);
                if (onewMemberApplication != null)
                    txtMemberApplicationId.Text = onewMemberApplication.MemberName;
                ptbPhoto.Image = onewMemberApplicationDocument.getMemberApplicationPhoto(onewMemberApplicationDocument.MemberApplicationDocumentId);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtMemberApplicationId.Text.Trim() == "")
            {
                MessageBox.Show("Member Application is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberApplicationId.Focus();

                return;
            }
            if (txtDocumentType.Text.Trim() == "")
            {
                MessageBox.Show("Document Type is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentType.Focus();
                return;
            }
            if (onewMemberApplicationDocument == null)
                onewMemberApplicationDocument = new Classes.MemberApplicationDocument();
            if (onewMemberApplication != null)
                onewMemberApplicationDocument.MemberApplicationId = onewMemberApplication.MemberApplicationId;
            if (onewDocumentType != null)
                onewMemberApplicationDocument.DocumentTypeId = onewDocumentType.DocumentTypeId;
            onewMemberApplicationDocument.Description = txtDescription.Text;
            onewMemberApplicationDocument.IsActive = chkIsActive.Checked;
            string err = "";
            onewMemberApplicationDocument.MemberApplicationDocumentId = onewMemberApplicationDocument.AddEditMemberApplicationDocument(false, ref err);
            if(err=="")
            {
                if (ptbPhoto.Image != null)
                    onewMemberApplicationDocument .saveMemberApplicationPhoto (ptbPhoto.Image);
               
                MessageBox.Show("Process sucedded ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                MessageBox.Show(err , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnSearchDocumentTypeid_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new SYSTEMUPGRADEPF.frmSearchDocumentType();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            if (onewDocumentType != null)
            {
                txtDocumentType.Text = onewDocumentType.Description;
            }

        }

        private void ptbPhoto_Click(object sender, EventArgs e)
        {
           


            try
            {
                OpenFileDialog OpenDialog = new OpenFileDialog();
                OpenDialog.Filter = "Images files|*.jpg";
                if (OpenDialog.ShowDialog() == DialogResult.OK)
                {
                    ptbPhoto.Image = Image.FromFile(OpenDialog.FileName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void DeleteToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewMemberApplicationDocument ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewMemberApplicationDocument.AddEditMemberApplicationDocument(true, ref err);
                if(err =="")
                {
                    MessageBox.Show("Process sucedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }
            }

        }

        private void frmMemberApplicationDocument_Load(object sender, EventArgs e)
        {
            frmMemberApplication frm = new frmMemberApplication();
            onewMemberApplication = oMemberApplication.GetMemberApplication(MemberApplicationId  );
           

            if (this.MemberApplicationId !=0)
            { 
            
                txtMemberApplicationId.Text =onewMemberApplication.MemberName ;
            }

        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            //ArrayList newList = new ArrayList();

            ArrayList mylist = new ArrayList();
            mylist = oMemberApplicationDocument.GetMemberApplicationDocuments();
            ArrayList newList = new ArrayList();
            foreach (Classes.MemberApplicationDocument omedec in mylist)
                {


                    if (this.MemberApplicationId == omedec.MemberApplicationId)


                    {
                        newList.Add(omedec);
                    }


                }

               // objList.SetObjects(newList);
            int counter = 0;

            if (onewMemberApplicationDocument  != null)
            {
                foreach (Classes.MemberApplicationDocument  omemdoc in newList)
                {
                    if (omemdoc .MemberApplicationDocumentId  == onewMemberApplicationDocument .MemberApplicationDocumentId )
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (movingNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = newList .Count;
                }
            }

            if (movingNext)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= newList .Count) counter = newList .Count - 1;


            onewMemberApplicationDocument  = (Classes.MemberApplicationDocument )newList [counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
    }
}
