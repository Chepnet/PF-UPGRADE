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
    public partial class frmRelationship : Form
    {
        Classes.Relationship oRelationship = new Classes.Relationship();
        Classes.Relationship onewRelationship = null;

        Classes.Kin oKin = new Classes.Kin();
        Classes.Ben oBen = new Classes.Ben();//instantiated so that it can be used to check if it has been linked to relationshipid

        public frmRelationship()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewRelationship = null;
            txtRelationshipName.Focus();
        }
        public void ClearText()
        {
            txtRelationshipName.Clear();
            chkIsActive.Checked = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtRelationshipName.Text.Trim() == "")
            {
                MessageBox.Show("Relationship Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRelationshipName.Focus();
                return;
            }

            if (onewRelationship == null)
                onewRelationship = new Classes.Relationship();

            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oRelationship.GetRelationships();
            foreach (Classes.Relationship orel in myList)
            {

                if (txtRelationshipName.Text.Trim().ToLower() == orel.RelationshipName.Trim().ToLower())
                {
                    if (onewRelationship.RelationshipId != orel.RelationshipId)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if (exist)
            {
                MessageBox.Show("The record will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRelationshipName.Focus();
                return;
            }
            else
            {
                onewRelationship.RelationshipName = txtRelationshipName.Text;
                onewRelationship.IsActive = chkIsActive.Checked;
            }

            string error = "";
            onewRelationship.RelationshipId = onewRelationship.AddEditRelationship(false, ref error);
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
            frmSearchRelationship frm = new SYSTEMUPGRADEPF.frmSearchRelationship();
            frm.ShowDialog();

            onewRelationship = oRelationship.GetRelationship(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewRelationship != null)
            {
                txtRelationshipName.Text = onewRelationship.RelationshipName;

                chkIsActive.Checked = onewRelationship.IsActive;

            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewRelationship == null)
            {
                MessageBox.Show("Select an item to delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;


            bool linked = false;
            ArrayList myList = oKin.GetKins();
            foreach (Classes.Kin mykin in myList)
            {
                if (mykin.RelationshipId == onewRelationship.RelationshipId)
                {
                    linked = true;
                    break;
                }
            }

            if (linked)
            {
                MessageBox.Show("Relationship has already been linked to next of kin", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ArrayList myBenList = oBen.GetBens();
            foreach (Classes.Ben obe in myBenList)
            {
                if (obe.RelationshipId == onewRelationship.RelationshipId)
                {
                    linked = true;
                    break;
                }
            }
            if (linked)
            {

                MessageBox.Show("Relationship has already been linked to next of beneficiary", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string error = "";
            onewRelationship.AddEditRelationship(true, ref error);
            if (error == "")
            {
                ClearText();
                onewRelationship = null;
                MessageBox.Show("Process suceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oRelationship.GetRelationships();

            int counter = 0;

            if (onewRelationship != null)
            {
                foreach (Classes.Relationship orel in myList)
                {
                    if (orel.RelationshipId == onewRelationship.RelationshipId)
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


            onewRelationship = (Classes.Relationship)myList[counter];
            displayInfo();
        }

        private void frmRelationship_Load(object sender, EventArgs e)
        {
            label1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}
