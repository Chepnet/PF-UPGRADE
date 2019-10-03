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
    public partial class frmDocumentType : Form
    {
        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;

        Classes.Ben oBen = new Classes.Ben();
        Classes.Kin oKin = new Classes.Kin();
        Classes.KinDocument oKinDocument = new Classes.KinDocument();
        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();

        int curval = 0;

        public frmDocumentType()
        {
            InitializeComponent();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewDocumentType = null;
            ClearText();
            txtDescription.Focus();
        }
        public void ClearText()
        {
            txtDescription.Clear();
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Document description is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (onewDocumentType == null)
                onewDocumentType = new Classes.DocumentType();
            bool exist = false;

            ArrayList myList = oDocumentType.GetDocumentTypes();
            foreach (Classes.DocumentType odoc in myList)
            {
                if(txtDescription.Text.Trim().ToLower()==odoc.Description.Trim().ToLower())
                {
                    if (onewDocumentType.DocumentTypeId != odoc.DocumentTypeId)
                    {
                    exist = true;
                    break;
                    }
                }                
            }


            if (exist)
            {
                MessageBox.Show("The record will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus(); 
                return;
            }
            else
            {
                onewDocumentType.Description = txtDescription.Text;
                onewDocumentType.IsActive = chkIsActive.Checked;
            }



            string error = "";
            onewDocumentType.DocumentTypeId = onewDocumentType.AddEditDocumentType(false, ref error);
            if (error == "")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new frmSearchDocumentType();
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewDocumentType != null)
            {
                txtDescription.Text = onewDocumentType.Description;
                chkIsActive.Checked = onewDocumentType.IsActive;
            }
            else
                ClearText();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewDocumentType == null)
            {
                MessageBox.Show("Select an item to delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;

            
            {

                bool linked = false;

                ArrayList benList = oBen.GetBens();
            foreach (Classes.Ben Obe in benList)
            {
                if (Obe.DocumentTypeId == onewDocumentType.DocumentTypeId)
                {
                    linked = true;
                    break;
                }
            }
            if (linked)
            {
                MessageBox.Show("Document Type  has already been linked to Ben", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ArrayList myKinList = oKin.GetKins();
            foreach (Classes.Kin oKi in myKinList)
            {
                if (oKi.DocumentTypeId == onewDocumentType.DocumentTypeId)
                {
                    linked = true;
                   break;
                }
            }
            if (linked)
            {
                MessageBox.Show("Document Type has already been linked to Kin ", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ArrayList myKinDocumentList = oKinDocument.GetKinDocuments();
            foreach (Classes.KinDocument okindoc in myKinDocumentList)
            {
                if (okindoc.DocumentTypeId == onewDocumentType.DocumentTypeId)
                {
                    linked = true;
                   break;
                }
            }
            if (linked)
            {
                MessageBox.Show("Document Type  has already been linked to Kin Document Type", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ArrayList myMemberDocumentList = oMemberDocument.GetMemberDocuments();
            foreach (Classes.MemberDocument oMemdoc in myMemberDocumentList)
            {
                if (oMemdoc.DocumentTypeId == onewDocumentType.DocumentTypeId)
                {
                    linked = true;
                   break;
                }
            }
            if (linked)
            {
                MessageBox.Show("Document Type  has already been linked to Member Document", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            }


            string error = "";
            onewDocumentType.AddEditDocumentType(true, ref error);
            if (error == "")
            {
                ClearText();
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewDocumentType = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void frmDocumentType_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Blue;
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList() ;
              
            if(myList.Count==0)
                myList=oDocumentType.GetDocumentTypes();

            int counter = 0;

            if (onewDocumentType != null)
            {
                foreach (Classes.DocumentType odoc in myList)
                {
                    if (odoc.DocumentTypeId == onewDocumentType.DocumentTypeId)
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

            if(movingNext)
            { 
            counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;


             onewDocumentType = (Classes.DocumentType)myList[counter];
            displayInfo();
        }


    }
}
