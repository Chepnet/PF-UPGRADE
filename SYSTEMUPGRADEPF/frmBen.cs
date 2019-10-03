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

    public partial class frmBen : Form
    {
        Classes.Ben oBen = new Classes.Ben();
        Classes.Ben onewBen = null;

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;

        Classes.Relationship oRelationship = new Classes.Relationship();
        Classes.Relationship onewRelationship = null;

        Classes.DocumentType oDocumentType = new Classes.DocumentType();
        Classes.DocumentType onewDocumentType = null;
        Classes.Caption oCaption = new Classes.Caption();


        public frmBen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchBen frm = new frmSearchBen();
            frm.ShowDialog();
            onewBen = oBen.GetBen(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewBen != null)
            {
                //txtMemberId.Text = onewBen.MemberId.ToString();
                onewMember = oMember.GetMember(onewBen.MemberId);
                if (onewMember != null)
                    txtMemberId.Text = onewMember.MemberName;
                txtBenCode.Text = onewBen.BenCode.ToString();
                txtBenName.Text = onewBen.BenName.ToString();
                if (onewRelationship != null)

                    txtRelationship.Text = onewRelationship.RelationshipName;

                dtpDateOfBirth.Text = onewBen.DateOfBirth.ToString();
                txtMobileNo.Text = onewBen.MobileNumber.ToString();
                txtRemarks.Text = onewBen.Remarks.ToString();
                TxtPercentageValue.Text = onewBen.PercentageValue.ToString();
                if(onewDocumentType !=null)

                txtDocumentNo.Text = onewDocumentType .Description ;
                chkIsActive.Checked = onewBen.IsActive;

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            

            if (txtBenCode.Text.Trim() == "")
            {
                MessageBox.Show("Ben Code is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBenCode.Focus();
                return;
            }
            if (txtBenName.Text.Trim() == "")
            {
                MessageBox.Show("Ben Name is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBenName.Focus();
                return;
            }
            if(txtMemberId .Text.Trim() =="")
            {
                MessageBox.Show("Member associated to Beneficiary is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberId .Focus();
                return;
            }
            if(txtRelationship.Text.Trim ()=="")
            {
                MessageBox.Show("Relationship  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRelationship .Focus();
                return;
            }
            if(TxtPercentageValue.Text.Trim()=="")
            {
                MessageBox.Show("Percentage value to the beneficiary  is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPercentageValue.Focus();
                return;
            }
            if (txtMobileNo .Text.Trim() == "")
            {
                MessageBox.Show(lblMobileNo .Text+" is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMobileNo .Focus();
                return;
            }


            Double Percentagevalue = 0;

            if (onewBen == null)
                onewBen = new Classes.Ben();
            // onewBen.MemberId = int.Parse(txtMemberId.Text);
            if (onewMember != null)
                onewBen.MemberId = onewMember.MemberId;
            onewBen.BenCode = txtBenCode.Text;
            onewBen.BenName = txtBenName.Text;
            if (onewRelationship != null)
                onewBen.RelationshipId = onewRelationship.RelationshipId;
            onewBen.DateOfBirth = DateTime.Parse(dtpDateOfBirth.Text);
            onewBen.MobileNumber = txtMobileNo.Text;
            onewBen.Remarks = txtRemarks.Text;
            Double .TryParse(TxtPercentageValue.Text, out Percentagevalue);
             
            if(Percentagevalue >0 && Percentagevalue<=100)
            {
                onewBen.PercentageValue = Percentagevalue;
            }
            else
            {
                MessageBox.Show("Percentage Value is out of range", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewDocumentType != null)
                   onewBen.DocumentTypeId  = onewDocumentType.DocumentTypeId;
            onewBen.IsActive = chkIsActive.Checked;
            string error = "";

            onewBen.BenId = onewBen.AddEdit(false, ref error);

            if (error == "")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewBen == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";

            onewBen.AddEdit(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewBen = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewBen = null;
            onewDocumentType = null;
            onewMember = null;
            onewRelationship = null;
            ClearTexts();
            txtBenCode.Focus();
        }
        private void ClearTexts()
        {
            txtMemberId.Text = "";
            txtBenCode.Clear();
            txtBenName.Text = "";
            txtRelationship.Text = "";
            dtpDateOfBirth.Text = "";
            txtRemarks.Text = "";
            txtMobileNo.Text = "";
            TxtPercentageValue.Text = "";
            txtDocumentNo.Text = "";
            chkIsActive.Checked = true ;

        }

        private void btnSearchMemberId_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember = oMember.GetMember(frm.selInt);
            if (onewMember != null)
            {
                if(onewMember .IsActive ==true)
                {
                    txtMemberId.Text = onewMember.MemberName;
                }
                else
                {
                    MessageBox.Show("Member is inactive",this.Text ,MessageBoxButtons.OK ,MessageBoxIcon.Exclamation);
                    return;
                }
                
            }
        }

        private void frmBen_Load(object sender, EventArgs e)
        {
            ReadCaption();
            RequiredFields();

        }

        private void RequiredFields()
        {
            lblBenCode.ForeColor = System.Drawing.Color.Blue;
            lblBenName.ForeColor = System.Drawing.Color.Blue;
            lblMember.ForeColor = System.Drawing.Color.Blue;
            lblMobileNo.ForeColor = System.Drawing.Color.Blue;
            LBLPercentageValue.ForeColor = System.Drawing.Color.Blue;
            lblRelationShip.ForeColor = System.Drawing.Color.Blue;
        }

        private void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes .Caption ocap in myList )
            {
                switch (ocap.DefaultCaptionName )
                {
                    case "Mobile Number":
                        lblMobileNo.Text = ocap.CaptionName + ":";
                        break;
                        


                }
                    
            }
        }

        private void btnSearchRelationship_Click(object sender, EventArgs e)
        {
            frmSearchRelationship frm = new SYSTEMUPGRADEPF.frmSearchRelationship();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewRelationship = oRelationship.GetRelationship(frm.selInt);
            if(onewRelationship != null)
            {
                if(onewRelationship.IsActive==true)
                {
                    txtRelationship.Text = onewRelationship.RelationshipName;
                }
                else
                {
                    MessageBox.Show("Inactive relationship", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
            }

        }

        private void btnSearchDocumentTypeId_Click(object sender, EventArgs e)
        {
            frmSearchDocumentType frm = new SYSTEMUPGRADEPF.frmSearchDocumentType();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewDocumentType = oDocumentType.GetDocumentType(frm.selInt);
            if (onewDocumentType != null)
            {
                if(onewDocumentType .IsActive==true )
                {
                    txtDocumentNo.Text = onewDocumentType.Description;
                }
                else
                {
                    MessageBox.Show("Inactive Document Type", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
                
        }

        private void TxtPercentageValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oBen .GetBens ();

            int counter = 0;

            if (onewBen  != null)
            {
                foreach (Classes.Ben  obe in myList)
                {
                    if (obe.BenId  == onewBen .BenId )
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


            onewBen  = (Classes.Ben )myList[counter];
            displayInfo();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
