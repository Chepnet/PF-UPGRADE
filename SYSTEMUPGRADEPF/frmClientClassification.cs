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
    public partial class frmClientClassification : Form
    {
        Classes.ClientClassification oClientClassification = new Classes.ClientClassification();
        Classes.ClientClassification onewClientClassification = null;

        Classes.Member oMember = new Classes.Member();
        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();

        public int selInt = 0;
        
        public frmClientClassification()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtClientClassificationName.Focus();
            ClearText();

        }
        public void ClearText()
        {
            txtClientClassificationName.Clear();
            onewClientClassification = null;
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtClientClassificationName.Text.Trim()=="")
            {
                MessageBox.Show("Client Classification Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClientClassificationName.Focus();
                return;
            }

            if (onewClientClassification == null)
                onewClientClassification = new Classes.ClientClassification();
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oClientClassification.GetClientClassifications();
            foreach(Classes .ClientClassification oclient in myList )
            {
                if(txtClientClassificationName .Text.Trim().ToLower()==oclient.ClientClassificationName .Trim ().ToLower ())
                {
                    if(onewClientClassification.ClientClassificationId !=oclient.ClientClassificationId )
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if(exist)
            {
                MessageBox.Show("The record will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClientClassificationName .Focus();
                return;
            }
            else
            {

            
                onewClientClassification.ClientClassificationName = txtClientClassificationName.Text;
                onewClientClassification.IsActive = chkIsActive.Checked;
            }

            string error = "";
                onewClientClassification.ClientClassificationId = onewClientClassification.AddEditClientClassification(false, ref error);
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
            frmSearchClientClassification frm = new frmSearchClientClassification();
            frm.ShowDialog();
            onewClientClassification = oClientClassification.GetClientClassification(frm.selInt);

            displayInfo();
        }

        private void displayInfo()
        {
            if (onewClientClassification != null)

            {
                txtClientClassificationName.Text = onewClientClassification.ClientClassificationName;
                chkIsActive.Checked = onewClientClassification.IsActive;
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {

            if(onewClientClassification ==null)
            {
                MessageBox.Show("Select an item to delete", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selecte item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(result==DialogResult.No)
            return;

            bool Linked = false;
            ArrayList myMemberList = oMember.GetMembers();
            foreach(Classes.Member omem in myMemberList )
            {
                if(omem.ClientClassificationId ==onewClientClassification.ClientClassificationId )
                {
                    Linked = true;
                    break;
                }
            }
            if(Linked )
            {
                MessageBox.Show("Client classification has been  linked to Member", "Delete fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ArrayList myMemberApplicationList = oMemberApplication .GetMemberApplications ();
            foreach (Classes.MemberApplication  omemapp in myMemberApplicationList)
            {
                if (omemapp.ClientClassificationId == onewClientClassification.ClientClassificationId)
                {
                    Linked = true;
                    break;
                }
            }
            if (Linked)
            {
                MessageBox.Show("Client classification is linked to Member Application", "Delete fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string err="";
            onewClientClassification.AddEditClientClassification(true, ref err);
            if (err=="")
            {
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();

            }
            else
            {

                MessageBox.Show(err , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchClientClassification frm = new frmSearchClientClassification();
            int index = frm.selInt;

            int prev = index - 1;
        }

        private void frmClientClassification_Load(object sender, EventArgs e)
        {
           
            string str = lblClient.Text;
            string newvalu = str.Replace  (":",string.Empty );
          lblClient .Text = newvalu + ":";
            lblClient.ForeColor = System.Drawing.Color.Blue;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oClientClassification .GetClientClassifications ();

            int counter = 0;

            if (onewClientClassification  != null)
            {
                foreach (Classes.ClientClassification  oclient in myList)
                {
                    if (oclient.ClientClassificationId  == onewClientClassification .ClientClassificationId )
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


            onewClientClassification  = (Classes.ClientClassification )myList[counter];
            displayInfo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
    }
}
