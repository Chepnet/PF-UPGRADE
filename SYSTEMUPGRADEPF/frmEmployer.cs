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
    public partial class frmEmployer : Form
    {
        Classes.Employer oEmployer = new Classes.Employer();
        Classes.Employer onewEmployer = null;

        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();
        Classes.Member oMember = new Classes.Member();
        Classes.Station oStation = new Classes.Station();
        Classes.Caption oCaption = new Classes.Caption();


        public frmEmployer()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchEmployer frm = new SYSTEMUPGRADEPF.frmSearchEmployer();
            frm.ShowDialog();
            onewEmployer = oEmployer.GetEmployer(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewEmployer != null)
            {
                txtEmployerCode.Text = onewEmployer.EmployerCode;
                txtEmployerCode.Text = onewEmployer.EmployerCode;
                txtEmployerName.Text = onewEmployer.EmployerName;
                txtEmployerTel1.Text = onewEmployer.EmployerTel1;
                txtEmployerTel2.Text = onewEmployer.EmployerTel2;
                txtEmployerCellNo.Text = onewEmployer.EmployerCellNo;
                txtEmployerFaxNo.Text = onewEmployer.EmployerFaxNo;
                txtEmployerEmailAddress.Text = onewEmployer.EmployerEmailAddress;
                txtEmployerAddress.Text = onewEmployer.EmployerAddress;
                txtPostalAddress.Text = onewEmployer.PostalAddress;
                txtEmployerRetirement.Text = onewEmployer.EmployerRetirement;
                txtNoOfWeek.Text = onewEmployer.NoOfWeek.ToString();
                txtEveryDayOfWeek.Text = onewEmployer.EveryDayOfWeek.ToString();
                txtDateOfMonth.Text = onewEmployer.DateOfMonth.ToString();
                chkUseRefDate.Checked = onewEmployer.UseRefDate;
                txtMaximumMembership.Text = onewEmployer.MaximumMembership.ToString();
                txtServiceCharge.Text = onewEmployer.ServiceCharge.ToString();
                txtCreditOfficerId.Text = onewEmployer.CreditOfficerId.ToString();
                chkLimitSavings.Checked = onewEmployer.LimitSavings;
                chkLimitLoans.Checked = onewEmployer.LimitLoans;
                txtGroupPrefix.Text = onewEmployer.GroupPrefix;
                txtPrevNo.Text = onewEmployer.PrevNo.ToString();
                chkIsActive.Checked = onewEmployer.IsActive;
            }
            else
            {
                ClearText();
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            onewEmployer = null;
            txtEmployerCode.Focus();
        }
        public void ClearText()
        {
             txtEmployerCode.Clear();
            txtEmployerName.Clear();
            txtEmployerTel1.Clear();
            txtEmployerTel2.Clear();
             txtEmployerCellNo.Clear();
             txtEmployerFaxNo.Clear();
             txtEmployerEmailAddress.Clear();
            txtEmployerAddress.Clear();
             txtPostalAddress.Clear();
             txtEmployerRetirement.Clear();
             txtNoOfWeek.Clear();
            txtEveryDayOfWeek.Clear();
            txtDateOfMonth.Clear();
             chkUseRefDate.Checked=false ;
            txtMaximumMembership.Clear();
         txtServiceCharge.Clear();
            txtCreditOfficerId.Clear();
             chkLimitSavings.Checked=false ;
            chkLimitLoans.Checked=false ;
            txtGroupPrefix.Clear();
             txtPrevNo.Clear();
            chkIsActive.Checked=true  ;

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtEmployerCode.Text.Trim()=="")
            {
                MessageBox.Show(lblEmployerCode .Text+"  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                txtEmployerCode.Focus();
                return;
            }
            if (txtEmployerName.Text.Trim() == "")
            {
                MessageBox.Show(lblEmployerName .Text+"is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                txtEmployerName .Focus();
                return;
            }



            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (txtEmployerEmailAddress.Text.Length > 0 && txtEmployerEmailAddress.Text.Trim().Length != 0)
                {
                    if (!rEmail.IsMatch(txtEmployerEmailAddress.Text.Trim()))
                    {
                        MessageBox.Show("Incorrect email format");
                        txtEmployerEmailAddress.SelectAll();
                        txtEmployerEmailAddress.Focus();
                    return;
                    }
                }
            

            int numweeks = 0;//declare variable of to tryparse
            int EveryDayOfWeek = 0;
            int DateOfMonth = 0;
            int MaxMembers = 0;
            int ServiceCharge = 0;
            int PreviousNo = 0;
            int CreditOfficer = 0;

            if (onewEmployer == null)
                onewEmployer = new Classes.Employer();
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oEmployer.GetEmployers();
            foreach (Classes.Employer oem in myList )
            {
                if(txtEmployerName .Text.Trim().ToLower ()==oem.EmployerName .Trim().ToLower())
                {
                    if(onewEmployer .EmployerId !=oem.EmployerId)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if(exist)
            {
                MessageBox.Show("The record will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmployerName .Focus();
                return;
            }
            else 
            { 
            onewEmployer.EmployerCode = txtEmployerCode.Text;
            onewEmployer.EmployerName = txtEmployerName.Text;
            onewEmployer.EmployerTel1 = txtEmployerTel1.Text;
            onewEmployer.EmployerTel2 = txtEmployerTel2.Text;
            onewEmployer.EmployerCellNo = txtEmployerCellNo.Text;
            onewEmployer.EmployerFaxNo = txtEmployerFaxNo.Text;
            onewEmployer.EmployerEmailAddress = txtEmployerEmailAddress.Text;
            onewEmployer.EmployerAddress = txtEmployerAddress.Text;
            onewEmployer.PostalAddress = txtPostalAddress.Text;
            onewEmployer.EmployerRetirement = txtEmployerRetirement.Text;

                int.TryParse(txtNoOfWeek.Text, out numweeks);//associate the variable to the txtbox
            onewEmployer.NoOfWeek = numweeks;//parsing the variable

                int.TryParse(txtEveryDayOfWeek.Text, out EveryDayOfWeek); 
            onewEmployer.EveryDayOfWeek = EveryDayOfWeek ;

                int.TryParse(txtDateOfMonth.Text, out DateOfMonth);
                onewEmployer.DateOfMonth = DateOfMonth;

          
            onewEmployer.UseRefDate = chkUseRefDate.Checked;

                int.TryParse(txtMaximumMembership.Text, out MaxMembers);
                 onewEmployer.MaximumMembership =MaxMembers ;

                int.TryParse(txtServiceCharge.Text,out ServiceCharge);
            onewEmployer.ServiceCharge =ServiceCharge;

                int.TryParse(txtCreditOfficerId.Text, out CreditOfficer);
                 onewEmployer.CreditOfficerId = CreditOfficer ;

            onewEmployer.LimitSavings = chkLimitSavings.Checked;
            onewEmployer.LimitLoans = chkLimitLoans.Checked;
            onewEmployer.GroupPrefix = txtGroupPrefix.Text;
                int.TryParse(txtPrevNo.Text, out PreviousNo);
                onewEmployer.PrevNo = PreviousNo ;

            onewEmployer.IsActive = chkIsActive.Checked;
            }

            string error = "";
            onewEmployer.EmployerId = onewEmployer.AddEditEmployer(false, ref error);
            if(error =="")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewEmployer == null)
            {
                MessageBox.Show("Item to Delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            //checking if employerid has been linked to member application
            bool linked = false;
            ArrayList memberapplicationList = oMemberApplication.GetMemberApplications();
            foreach (Classes.MemberApplication oapp in memberapplicationList)
            {
                if(oapp.EmployerId == onewEmployer.EmployerId)
                {
                    linked = true;
                    break;
                }
            }

            if (linked)
            {
                MessageBox.Show("Employer has already been linked to member application", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ArrayList memberList = oMember.GetMembers();
            foreach (Classes.Member oMemb in memberList )
            {
                if(oMemb .EmployerId ==onewEmployer.EmployerId)
                {
                    linked = true;
                    break;
                }
            }
            if(linked )
            {
                MessageBox.Show("Employer has already been linked to Member", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            ArrayList stationList = oStation.GetStations();
            foreach (Classes.Station osta in stationList )
            {
                if(osta.EmployerId==onewEmployer.EmployerId )
                {
                    linked = true;
                    break;
                }
            }
            if(linked)
            {
                {
                    MessageBox.Show("Employer has already been linked to Station", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            string error = "";
             onewEmployer.AddEditEmployer(true, ref error);
            if(error=="")
            {

                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                ClearText();
                onewEmployer = null;
            }
            else
            {

                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEmployerEmailAddress_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmEmployer_Load(object sender, EventArgs e)
        {
            CompulsoryFields();

            ReadCaption();
        }

        private void CompulsoryFields()
        {
            lblEmployerCode.ForeColor = System.Drawing.Color.Blue;
            lblEmployerName.ForeColor = System.Drawing.Color.Blue;
        }

        private void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList)
            {
                switch(ocap.DefaultCaptionName )
                {
                    case "Mobile Number":
                        lblMobileNo.Text = ocap.CaptionName + ":";
                       
                        break;
                    case "Fax Number":
                        lblFaxNumber .Text = ocap.CaptionName + ":";
                        
                        break;
                    case "Telephone 1":
                        lblTel1 .Text = ocap.CaptionName + ":";
                         break;
                    case "Telephone 2":
                       
                        
                        lblTel2.Text = ocap.CaptionName+":";
                                      
                      
                        
                        break;
                    case "Employer":
                        string str1 = ocap.CaptionName ;
                        string newname = str1.Replace(":", string.Empty);
                        lblEmployerCode .Text = newname +" Code:";

                        lblEmployerName.Text = newname + " Name:";
                        groupBox3.Text = newname + " Details";
                        groupBox1.Text = newname + " Contacts";
                        groupBox2.Text = newname + "Settings";
                        this.Text= newname;
                        
                        


                        break;




                }
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oEmployer .GetEmployers();

            int counter = 0;

            if (onewEmployer != null)
            {
                foreach (Classes.Employer oem in myList)
                {
                    if (oem.EmployerId  == onewEmployer .EmployerId )
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


            onewEmployer  = (Classes.Employer )myList[counter];
            displayInfo();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
    }
}
