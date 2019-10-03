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
    public partial class frmStation : Form
    {
        Classes.Station oStation = new Classes.Station();
        Classes.Station onewStation = null;

        Classes.Employer oEmployer = new Classes.Employer();
        Classes.Employer onewEmployer = null;

        Classes.Member oMember = new Classes.Member();
        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();

        Classes.Caption oCaption = new Classes.Caption();


        public frmStation()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewStation = null;
            onewEmployer = null;
            txtEmployerId .Focus();
            ClearText();

        }
        public void ClearText()
        {
            txtStationCode.Clear();
            txtStationName.Clear();
            txtEmployerId.Clear();
            txtStationAddress.Clear();
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtStationCode.Text.Trim() == "")
            {
                MessageBox.Show("Station Code is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStationCode.Focus();
                return;
            }
            if (txtStationName.Text.Trim() == "")
            {
                MessageBox.Show("Station Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStationName.Focus();
                return;
            }
            if (txtStationAddress.Text.Trim() == "")
            {
                MessageBox.Show("Station Address is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStationAddress.Focus();
                return;
            }
            if (txtEmployerId.Text.Trim() == "")
            {
                MessageBox.Show("Employer  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmployerId.Focus();
                return;
            }
            if (onewStation == null)
                onewStation = new Classes.Station();
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oStation.GetStations();
            foreach(Classes.Station oste in myList )
            {
                if(txtStationName .Text.Trim().ToLower()==oste.StationName .Trim().ToLower())
                {
                    if(onewStation .StationId !=oste.StationId )
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if(exist)
            {
                MessageBox.Show("The record will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStationName .Focus();
                return;
            }
            else {
            onewStation.StationCode = txtStationCode.Text;
            onewStation.StationName = txtStationName.Text;
            onewStation.StationAddress = txtStationAddress.Text;
            onewStation.IsActive = chkIsActive.Checked;
            if (onewEmployer != null)

                onewStation.EmployerId = onewEmployer.EmployerId;
            }

            string error = "";
            onewStation.StationId = onewStation.AddEditStation(false, ref error);
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
            frmSearchStation frm = new SYSTEMUPGRADEPF.frmSearchStation();
            frm.ShowDialog();
            onewStation = oStation.GetStation(frm.selInt);
            displayinfo();

        }

        private void displayinfo()
        {
            if (onewStation != null)
            {
                txtStationAddress.Text = onewStation.StationAddress;
                txtStationCode.Text = onewStation.StationCode;
                txtStationName.Text = onewStation.StationName;
                chkIsActive.Checked = onewStation.IsActive;

                onewEmployer = oEmployer.GetEmployer(onewStation.EmployerId);
                if (onewEmployer != null)

                    txtEmployerId.Text = onewEmployer.EmployerName;
            }
            else
            {
                ClearText();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewStation == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
                return;

            //checking if station has been linked to member
            bool Linked = false;
            ArrayList myMemberList = oMember.GetMembers();
            foreach (Classes.Member oMem in myMemberList)
            {
                if (oMem.StationId == onewStation.StationId)
                {
                    Linked = true;
                    break;

                }

            }
            if (Linked)
            {
                MessageBox.Show("Station has been linked to Member", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }
            ArrayList myMemberApplication = oMemberApplication .GetMemberApplications ();
            foreach (Classes.MemberApplication  oMem in myMemberApplication)
            {
                if (oMem.StationId == onewStation.StationId)
                {
                    Linked = true;
                    break;

                }

            }
            if (Linked)
            {
                MessageBox.Show("Station has been linked to Member Application", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }




            string error = "";
            onewStation.AddEditStation(true, ref error);
            if (error == "")
            {
                onewStation = null;
                ClearText();
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchEmployer_Click(object sender, EventArgs e)
        {
            frmSearchEmployer frm = new frmSearchEmployer();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewEmployer = oEmployer.GetEmployer(frm.selInt);
            if (onewEmployer != null)
            {
                if(onewEmployer .IsActive==true)
                {
                    txtEmployerId.Text = onewEmployer.EmployerName;
                }
                else
                {
                    string str = lblEmployer .Text;
                    string newname = str.Replace(":", string.Empty);
                   MessageBox.Show("Inactive "+newname , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    onewEmployer = null;
                    txtEmployerId.Text = "";
                    return;
                }
                
            }
        }

        private void frmStation_Load(object sender, EventArgs e)
        {
            ReadCaption();
            lblStationCode.ForeColor = System.Drawing.Color.Blue;
            lblStationName.ForeColor = System.Drawing.Color.Blue;
        }
        private void ReadCaption()
        {

            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes .Caption ocap in myList )
            {
                switch (ocap.DefaultCaptionName )
                {
                    case "Employer":
                        string str1 = ocap.CaptionName;
                        string newemployername = str1.Replace(":", string.Empty);
                        lblEmployer.Text = newemployername + ":";
                        txtEmployerId.Focus();
                        break;
                    case "Station":
                        //string str1 = ocap.CaptionName;
                        //string newname = str1.Replace(":", string.Empty);
                        //lblEmployerCode.Text = newname + " Code";
                        string str = ocap.CaptionName;
                        string newname = str.Replace(":", string.Empty);
                        this.Text = newname;
                        lblStationCode.Text = newname +" Code:";
                        lblStationName.Text = newname + " Name:";
                        lblStationAddress.Text = newname + " Address:";
                        
                        
                       // lblEmployer.Text = ocap.CaptionName;
                        break;


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
                myList = oStation .GetStations();

            int counter = 0;

            if (onewStation  != null)
            {
                foreach (Classes.Station  oste in myList)
                {
                    if (oste.StationId  == onewStation .StationId )
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


            onewStation   = (Classes.Station )myList[counter];
            displayinfo();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void txtStationName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = oStation.GetStations();
                foreach (Classes.Station oste in myList )
                {
                    if(txtStationName.Text .Trim ().ToLower() ==oste.StationName .Trim ().ToLower ())
                    {
                        onewStation = oste;
                        displayinfo();
                        found = true;

                    }
                }
                if (!found)
                {
                    onewStation  = null;
                    ClearText ();
                    displayinfo();
                    MessageBox.Show("Station  Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName .Focus();
                }
            }
    }

        private void txtStationCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = oStation.GetStations();
                foreach (Classes.Station oste in myList)
                {
                    if (txtStationCode .Text.Trim().ToLower() == oste.StationCode .Trim().ToLower())
                    {
                        onewStation = oste;
                        displayinfo();
                        found = true;

                    }
                }
                if (!found)
                {
                    onewStation = null;
                    ClearText();
                    displayinfo();
                    MessageBox.Show("Station  Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtStationName.Focus();
                }
            }
        }
    }
}
