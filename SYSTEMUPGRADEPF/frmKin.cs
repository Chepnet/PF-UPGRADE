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
    public partial class frmKin : Form
    {
        Classes.Kin oKin = new Classes.Kin();
        Classes.Kin onewKin = null;

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;


        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;

        Classes.Relationship oRelationship = new Classes.Relationship();
        Classes.Relationship onewRelationship = null;

        Classes.Caption oCaption = new Classes.Caption();

        public frmKin()
        {
            InitializeComponent();
        }

        private void txtPercentageValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtKinCode.Text.Trim() == "")
            {
                MessageBox.Show("Kin Code is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKinCode.Focus();
                return;
            }
            if (txtKinName.Text.Trim() == "")
            {
                MessageBox.Show("Kin Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtKinName.Focus();
                return;
            }
            if (txtRelationship .Text.Trim() == "")
            {
                MessageBox.Show("Relationship of Kin to the member is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRelationship .Focus();
                return;
            }
            if (txtMemberId .Text.Trim() == "")
            {
                MessageBox.Show("Member Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberId.Focus();
                return;
            }
            if(txtMobileNo .Text.Trim() == "")
            {
                MessageBox.Show(lblMobileNo .Text+" is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txtMobileNo.Focus();
                return;
            }


            if (onewKin == null)
                onewKin = new Classes.Kin();
            //onewKin.MemberId = int.Parse(txtMemberId.Text);
            if (onewMember != null)
                onewKin.MemberId = onewMember.MemberId;
            onewKin.KinCode = txtKinCode.Text;
            onewKin.KinName = txtKinName.Text;

            if(onewRelationship !=null)
                 onewKin.RelationshipId = onewRelationship.RelationshipId ;

            onewKin.DateOfBirth = DateTime.Parse(dtpDateOfbirth.Text);
            onewKin.MobileNumber = txtMobileNo.Text;
            onewKin.Remarks = txtRemarks.Text;

            if(onewDocumentType !=null)
                onewKin.DocumentTypeId =onewDocumentType.DocumentTypeId ;

            onewKin.IsActive = chkIsActive.Checked;
            //onewKin.CreatedBy = txtCreatedBy.Text;
            string error = "";

            onewKin.KinId = onewKin.AddEdit(false, ref error);

            if (error == "")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchKin frm = new frmSearchKin();
            frm.ShowDialog();
            onewKin = oKin.GetKin(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewKin != null)
            {
                //txtMemberId.Text = onewKin.MemberId.ToString();
                onewMember = oMember.GetMember(onewKin.MemberId);
                if (onewMember != null)
                    txtMemberId.Text = onewMember.MemberName;
                txtKinCode.Text = onewKin.KinCode.ToString();
                txtKinName.Text = onewKin.KinName.ToString();

                onewRelationship = oRelationship.GetRelationship(onewKin.RelationshipId);
                if (onewRelationship != null)
                    txtRelationship.Text = onewRelationship.RelationshipName;
                dtpDateOfbirth.Text = onewKin.DateOfBirth.ToString();
                txtMobileNo.Text = onewKin.MobileNumber.ToString();
                txtRemarks.Text = onewKin.Remarks.ToString();

                onewDocumentType = oDocumentType.GetDocumentType(onewKin.DocumentTypeId);
                if (onewDocumentType != null)

                    txtDocumentNo.Text = onewDocumentType.Description;
                chkIsActive.Checked = onewKin.IsActive;

            }
            else
            {
                ClearTexts();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewKin == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewKin.AddEdit(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewKin = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewDocumentType = null;
            onewMember = null;
            onewRelationship = null;
            onewKin = null;
            ClearTexts();
            txtKinCode.Focus();
        }
        private void ClearTexts()
        {
            txtMemberId.Text = "";
            txtKinCode.Clear();
            txtKinName.Text = "";
            txtRelationship.Text = "";
            dtpDateOfbirth.Text = "";
            txtRemarks.Text = "";
            txtMobileNo.Text = "";
            txtDocumentNo.Text = "";
            chkIsActive.Checked = true ;
           

        }

        private void frmKin_Load(object sender, EventArgs e)
        {
            ReadCaption();
            CompulsoryFields();

        }

        private void CompulsoryFields()
        {
            lblKinCode.ForeColor = System.Drawing.Color.Blue;
            lblKinName.ForeColor = System.Drawing.Color.Blue;
            lblRelationship.ForeColor = System.Drawing.Color.Blue;
            lblMobileNo.ForeColor = System.Drawing.Color.Blue;
            lblMember.ForeColor = System.Drawing.Color.Blue;
        }

        private void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList)
            {
                switch (ocap.DefaultCaptionName)
                {
                    case "Mobile Number":
                        lblMobileNo.Text = ocap.CaptionName + ":";
                        break;
                }
            }

        }

        private void btnSearchMemberId_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember = oMember.GetMember(frm.selInt);
            if (onewMember != null)
            {
                if(onewMember .IsActive==true)
                {
                    txtMemberId.Text = onewMember.MemberName;
                }
               
                else
                {
                    MessageBox.Show("Inactive Member", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btnSearchDocumentType_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new frmSearchDocumentType();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            if (onewDocumentType != null)
            {
                if(onewDocumentType.IsActive ==true)
                {
                    txtDocumentNo.Text = onewDocumentType.Description;
                }
                else
                {
                    MessageBox.Show("Inactive document Type", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
               
           
            
        }

        private void btnRelationship_Click(object sender, EventArgs e)
        {
            frmSearchRelationship frm = new  frmSearchRelationship();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewRelationship = oRelationship.GetRelationship(frm.selInt);
            if (onewRelationship != null)
            {
                if(onewRelationship.IsActive==true)
                {
                    txtRelationship.Text = onewRelationship.RelationshipName;
                }
                else
                {
                    MessageBox.Show("The relationship is inactive", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                myList = oKin .GetKins();

            int counter = 0;

            if (onewKin  != null)
            {
                foreach (Classes.Kin  oki in myList)
                {
                    if (oki.KinId  == onewKin .KinId )
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


            onewKin  = (Classes.Kin )myList[counter];
            displayInfo();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
    }
}
