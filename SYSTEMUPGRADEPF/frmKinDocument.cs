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

    public partial class frmKinDocument : Form
    {
        Classes.KinDocument oKinDocument = new Classes.KinDocument();
        Classes.KinDocument onewKinDocument = null;

        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;
        Classes.Kin oKin = new Classes.Kin();
        Classes.Kin onewKin = null;

        public frmKinDocument()
        {
            InitializeComponent();
        }

        private void frmKinDocument_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chkIsActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewKinDocument = null;
            onewDocumentType = null;
            ClearTexts();
            txtDocumentTypeId.Focus();

        }
        private void ClearTexts()
        {

            txtDocumentTypeId.Clear();
            txtDescription.Clear();
            chkIsActive.Checked = true;
            ptbPhoto.Image = null;

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchKinDocument frm = new frmSearchKinDocument();
            frm.ShowDialog();
            onewKinDocument = oKinDocument.GetKinDocument(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewKinDocument != null)
            {
                onewDocumentType = oDocumentType.GetDocumentType(onewKinDocument.DocumentTypeId);
                if (onewDocumentType != null)
                {

                    txtDocumentTypeId.Text = onewDocumentType.Description;
                }
                
                onewKin = oKin.GetKin(onewKinDocument.KinId);
                if(onewKin !=null)
                {
                    txtKin.Text = onewKin.KinName;
                }

                txtDescription.Text = onewKinDocument.Description;
                    chkIsActive.Checked = onewKinDocument.IsActive;
                    ptbPhoto.Image = onewKinDocument.getKinPhoto(onewKinDocument.KinDocumentId);
                    //ptbPhoto. = onewKinDocument.Photo.ToString();
                
            }
            else
            {
                ClearTexts();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtDocumentTypeId.Text.Trim() == "")
            {
                MessageBox.Show("Document Type Is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumentTypeId.Focus();
                return;
            }
            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;

            }
            if (onewKinDocument == null)
                onewKinDocument = new Classes.KinDocument();
            if (onewDocumentType != null)
                onewKinDocument.DocumentTypeId = onewDocumentType.DocumentTypeId;
            if(onewKin !=null)
            {
                onewKinDocument.KinId = onewKin.KinId;
            }
            onewKinDocument.Description = txtDescription.Text;
            onewKinDocument.IsActive = chkIsActive.Checked;
            string error = "";

            onewKinDocument.KinDocumentId = onewKinDocument.AddEdit(false, ref error);

            if (error == "")
            {
                if (ptbPhoto.Image != null)
                    onewKinDocument.saveKinPhoto(ptbPhoto.Image);
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewKinDocument == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewKinDocument.AddEdit(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewKinDocument = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSearchDocumentType_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new SYSTEMUPGRADEPF.frmSearchDocumentType();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            if (onewDocumentType != null)
            {


                if (onewDocumentType.IsActive == true)
                {
                    txtDocumentTypeId.Text = onewDocumentType.Description;
                }

                else
                {
                    MessageBox.Show("Inactive Document Type", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oKinDocument .GetKinDocuments ();

            int counter = 0;

            if (onewKinDocument   != null)
            {
                foreach (Classes.KinDocument  okidoc in myList)
                {
                    if (okidoc.KinDocumentId  == onewKinDocument .KinDocumentId )
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


            onewKinDocument  = (Classes.KinDocument )myList[counter];
            displayInfo();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void btnSearchKin_Click(object sender, EventArgs e)
        {
            frmSearchKin frm = new SYSTEMUPGRADEPF.frmSearchKin();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewKin = oKin.GetKin(frm.selInt);
            if (onewKin != null)
                if(onewKin.IsActive ==true)
                {

                
                txtKin.Text = onewKin.KinName;
                }
            else
                {
                    MessageBox.Show("Kin is Inactive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }
    }
}

