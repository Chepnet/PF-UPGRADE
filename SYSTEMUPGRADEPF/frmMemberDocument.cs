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
    public partial class frmMemberDocument : Form
    {
        public frmMemberDocument()
        {
            InitializeComponent();
        }
        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;

        private bool _selecteddocuments = false;

        public bool SelectedDocuments { get { return _selecteddocuments; } set { _selecteddocuments = value; } }

        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;
        private int _memberid = 0;
        public int MemberId { get { return _memberid; } set { _memberid = value; } }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewMemberDocument = null;
            onewMember = null;
            onewDocumentType = null;

            ClearTexts();
            txtMemberId.Focus();

        }
        private void ClearTexts()
        {
            txtMemberId.Clear();
            txtDocumentType.Text = "";
            txtDescription.Clear();
            chkIsActive.Checked = true;
            ptbPhoto.Image = null;

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchMemberDocument frm = new frmSearchMemberDocument();

            frm.ShowDialog();
            onewMemberDocument = oMemberDocument.GetMemberDocument(frm.selInt);
            displayInfo();
        }

        public void displayInfo()
        {
            if (onewMemberDocument != null)
            {
                //txtMemberId.Text = onewMemberDocument.MemberId.ToString();
                onewMember = oMember.GetMember(onewMemberDocument.MemberId);
                if (onewMember != null)
                    txtMemberId.Text = onewMember.MemberName;

                onewDocumentType = oDocumentType.GetDocumentType(onewMemberDocument.DocumentTypeId);
                if (onewDocumentType != null)

                    txtDocumentType.Text = onewDocumentType.Description;

                txtDescription.Text = onewMemberDocument.Description;
                chkIsActive.Checked = onewMemberDocument.IsActive;
                ptbPhoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
            }
        }
        public void displayInfo(int memberDocumentId)
        {
            onewMemberDocument = oMemberDocument.GetMemberDocument(memberDocumentId);
            if (onewMemberDocument != null)
            {
                //txtMemberId.Text = onewMemberDocument.MemberId.ToString();
                onewMember = oMember.GetMember(onewMemberDocument.MemberId);
                if (onewMember != null)
                    txtMemberId.Text = onewMember.MemberName;

                onewDocumentType = oDocumentType.GetDocumentType(onewMemberDocument.DocumentTypeId);
                if (onewDocumentType != null)

                    txtDocumentType.Text = onewDocumentType.Description;

                txtDescription.Text = onewMemberDocument.Description;
                chkIsActive.Checked = onewMemberDocument.IsActive;
                ptbPhoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtMemberId.Text.Trim() == "")
            {
                MessageBox.Show("Member ID is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberId.Focus();

                return;
            }
            if (txtDocumentType.Text.Trim() == "")
            {
                MessageBox.Show("Document Type is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentType.Focus();
                return;
            }
            if (onewMemberDocument == null)
                onewMemberDocument = new Classes.MemberDocument();

            //onewMemberDocument.MemberId = int.Parse(txtMemberId.Text);
            if (onewMember != null)
                onewMemberDocument.MemberId = onewMember.MemberId;
            if (onewDocumentType != null)
                onewMemberDocument.DocumentTypeId = onewDocumentType.DocumentTypeId;

            onewMemberDocument.Description = txtDescription.Text;
            onewMemberDocument.IsActive = chkIsActive.Checked;
            string error = "";

            onewMemberDocument.MemberDocumentId = onewMemberDocument.AddEdit(false, ref error);

            if (error == "")
            {
                if (ptbPhoto.Image != null)
                    onewMemberDocument.saveMemberPhoto(ptbPhoto.Image);

                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewMemberDocument == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewMemberDocument.AddEdit(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewMemberDocument = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearchMemberid_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember = oMember.GetMember(frm.selInt);
            if (onewMember != null)
            {
                if (onewMember.IsActive == true)
                {


                    txtMemberId.Text = onewMember.MemberName;
                }
                else
                {
                    MessageBox.Show("In Active Member", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSearchDocumentTypeid_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new frmSearchDocumentType();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            if (onewDocumentType != null)
            {
                if (onewDocumentType.IsActive == true)
                {

                    txtDocumentType.Text = onewDocumentType.Description;
                }
                else
                {

                    MessageBox.Show("InActive Document Type", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


        }

        private void ptbPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog1.FileName;
                    ptbPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            //  objListDocuments.Items.Clear();
            if (myList.Count == 0)
                myList = oMemberDocument.GetMemberDocuments();
            // mylist = oMemberDocument.GetMemberDocuments();


            if (SelectedDocuments)

            {


                foreach (Classes.MemberDocument omedec in myList)
                {


                    if (onewMemberDocument.MemberId == omedec.MemberId)


                    {
                        newList.Add(omedec);
                    }


                }

                int counter = 0;

                if (onewMemberDocument != null)
                {
                    foreach (Classes.MemberDocument omemdoc in newList)
                    {
                        if (omemdoc.MemberDocumentId == onewMemberDocument.MemberDocumentId)
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
                        counter = newList.Count;
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
                if (counter >= newList.Count) counter = newList.Count - 1;


                onewMemberDocument = (Classes.MemberDocument)newList[counter];
                displayInfo();


            }


            else
            {

                int counter = 0;

                if (onewMemberDocument != null)
                {
                    foreach (Classes.MemberDocument omemdocs in myList)
                    {
                        if (omemdocs.MemberDocumentId == onewMemberDocument.MemberDocumentId)
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
                        counter = myList.Count;
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
                if (counter >= myList.Count) counter = myList.Count - 1;


                onewMemberDocument = (Classes.MemberDocument)myList[counter];
                displayInfo();

            }
        }






        private void toolStripNext_Click(object sender, EventArgs e)
        {



            moveToRecord(true);
        }

        private void frmMemberDocument_Load(object sender, EventArgs e)
        {
            //this.SelectedDocuments = false;
            lblDescription.ForeColor = System.Drawing.Color.Blue;
            lblDocumentType.ForeColor = System.Drawing.Color.Blue;
            lblMember.ForeColor = System.Drawing.Color.Blue;
            lblPhoto.ForeColor = System.Drawing.Color.Blue;

        }
    }
}

