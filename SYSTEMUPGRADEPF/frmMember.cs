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
    public partial class frmMember : Form
    {
        Classes.Member OMember = new Classes.Member();
        Classes.Member onewMember = null;
        public int Memberid = 0;

        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();
        Classes.MemberApplication onewMemberApplication = null;

        Classes.Station oStation = new Classes.Station();
        Classes.Station onewStation = null;

        Classes.ClientClassification oClientClassification = new Classes.ClientClassification();
        Classes.ClientClassification onewClientClassification = null;

        Classes.Employer oEmployer = new Classes.Employer();
        Classes.Employer onewEmployer = null;

        Classes.Ben oBen = new Classes.Ben();
        Classes.Kin oKin = new Classes.Kin();
        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;
        Classes.Caption oCaption = new Classes.Caption();
        Classes.CompulsoryField oCompulsoryFields = new Classes.CompulsoryField();
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        


        public frmMember()
        {
            InitializeComponent();
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            ReadCaption();
            CompulsoryFields();
        }
        private void CompulsoryFields()
        {

            ArrayList myList = new ArrayList();
            myList = oCompulsoryFields.GetCompulsoryFields();
            foreach (Classes.CompulsoryField oca in myList)
            {

                switch (oca.FieldName)
                {
                    case "MemberName":
                        if (oca.IsRequired == true)
                            lblName.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "IdNumber":
                        if (oca.IsRequired == true)
                            lblIdNo.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Station":
                        if (oca.IsRequired == true)
                            lblStation.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Department":
                        if (oca.IsRequired == true)
                            lblDepartment.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "RegDate":
                        if (oca.IsRequired == true)
                            lblRegistrationDate .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "DateOfBirth":
                        if (oca.IsRequired == true)
                            lblDoB.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Gender":
                        if (oca.IsRequired == true)
                            lblGender.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "MaritalStatus":
                        if (oca.IsRequired == true)
                            lblMaritalStatus.ForeColor = System.Drawing.Color.Blue;
                        break;

                    case "KraPin":
                        if (oca.IsRequired == true)
                            lblKraPin.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "CustomerBankAccount":
                        if (oca.IsRequired == true)
                            lblAccountNo .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "CustomerBank":
                        if (oca.IsRequired == true)
                            lblBank.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "EmailAddress":
                        if (oca.IsRequired == true)
                            lblEmail .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Tel1":
                        if (oca.IsRequired == true)
                            lblTel1.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Tel2":
                        if (oca.IsRequired == true)
                            lblTel2.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "PostalAddress":
                        if (oca.IsRequired == true)
                            lblPostalAddress.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "PhysicalAddress":
                        if (oca.IsRequired == true)
                            lblPhysicalAddress.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Employer":
                        if (oca.IsRequired == true)
                            lblEmployer.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "WithdrawalId":
                        if (oca.IsRequired == true)
                            lblWithdrawal.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "GrossSalary":
                        if (oca.IsRequired == true)
                            lblGrossSalary.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "NetSalary":
                        if (oca.IsRequired == true)
                            lblNetSalary.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Client Classification":
                        if (oca.IsRequired == true)
                            lblClassification .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Company":
                        if (oca.IsRequired == true)
                            lblCompany.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Process":
                        if (oca.IsRequired == true)
                            lblProcess.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Branch":
                        if (oca.IsRequired == true)
                            lblBranch.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Title":
                        if (oca.IsRequired == true)
                            lblTitle.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Mobile Number":
                        if (oca.IsRequired == true)
                            lblPhone .ForeColor = System.Drawing.Color.Blue;
                        break;







                }
            }
        }
        private void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList)
            {
                switch (ocap.DefaultCaptionName)
                {
                    case "Member No":
                        lblMemberNo.Text = ocap.CaptionName + ":";
                        break;
                    case "Station":
                        lblStation.Text = ocap.CaptionName + ":";
                        break;
                    case "Employer":
                        lblEmployer.Text = ocap.CaptionName + ":";
                        break;
                    case "Title":
                        lblTitle.Text = ocap.CaptionName + ":";
                        break;
                    case "Telephone 1":
                        lblTel1.Text = ocap.CaptionName + ":";
                        break;
                    case "Telephone 2":
                        lblTel2.Text = ocap.CaptionName + ":";
                        break;
                    case "Mobile Number":
                        lblPhone.Text = ocap.CaptionName + ":";
                        break;
                    case "Bank":
                        lblBank.Text = ocap.CaptionName + ":";
                        break;
                    case "Bank Branch":
                        lblBankBranch.Text = ocap.CaptionName + ":";
                        break;
                    case "Cert No":
                        lblCertificate.Text = ocap.CaptionName + ":";
                        break;
                    case "Client Classification":
                        lblClassification.Text = ocap.CaptionName + ":";
                        break;
                }
            }
            lblEmail.Text = lblEmail.Text + ":";
        }

        private void chkIsCompany_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }



        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new frmSearchMember();
            frm.ShowDialog();
            onewMember = OMember.GetMember(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {

            ClearTexts();

            if (onewMember != null)
            {



                txtIdNumber.Text = onewMember.IdNumber.ToString();
                txtMemberNo.Text = onewMember.MemberNo.ToString();
                txtmembername.Text = onewMember.MemberName.ToString();
                dtpRegDate.Text = onewMember.RegDate.ToString();
                txtphoneno.Text = onewMember.PhoneNumber.ToString();
                dtpdateofbirth.Text = onewMember.DateOfBirth.ToString();
                cmbGender.SelectedItem = onewMember.Gender.ToString();
                cmbMaritalStatus.SelectedItem = onewMember.MaritalStatus.ToString();
                txtkrapin.Text = onewMember.KraPin.ToString();
                txtcertificateno.Text = onewMember.RegCertNo;
                onewBank = oBank.GetBank(onewMember.CustomerBankId);
                if(onewBank !=null)
                txtbankid.Text = onewBank.BankName ;
                txtbankbranchid.Text = onewMember.CustomerBankBranchId.ToString();
                txtaccountno.Text = onewMember.CustomerBankAccount.ToString();
                txttel1.Text = onewMember.Tel1.ToString();
                txttel2.Text = onewMember.Tel2.ToString();
                txtemail.Text = onewMember.EmailAddress.ToString();
                txtpostaladdress.Text = onewMember.PostalAddress.ToString();
                txtphysicaladdress.Text = onewMember.PhysicalAddress.ToString();

                onewEmployer = oEmployer.GetEmployer(onewMember.EmployerId);
                if (onewEmployer != null)//check if employer exist in the employer list
                    txtemployerid.Text = onewEmployer.EmployerName;// to display the name of the employer for the corresponding employerid when one select an item in the objectlist

                onewStation = oStation.GetStation(onewMember.StationId);
                if (onewStation != null)
                    txtstationid.Text = onewStation.StationName;

                txtdepartmentid.Text = onewMember.DepartmentId.ToString();
                txtwithdrawalid.Text = onewMember.WithdrawalId.ToString();
                chkIsActive.Checked = onewMember.IsActive;
                txtgrosssalary.Text = onewMember.GrossSalary.ToString();
                txtnetsalary.Text = onewMember.Netsalary.ToString();

                onewClientClassification = oClientClassification.GetClientClassification(onewMember.ClientClassificationId);
                if (onewClientClassification != null)
                    txtclassificationid.Text = onewClientClassification.ClientClassificationName;

                txtcompanyid.Text = onewMember.CompanyId.ToString();
                chkIsCompany.Checked = onewMember.IsCompany;
                txtprocessid.Text = onewMember.ProcessId.ToString();
                txtbranchid.Text = onewMember.BranchId.ToString();
                cmbTitle.SelectedText = onewMember.Title.ToString();




            }
            
               
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtemail.Text.Length > 0 && txtemail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(txtemail.Text.Trim()))
                {
                    MessageBox.Show("Incorrect email format");
                    txtemail.SelectAll();
                    txtemail.Focus();
                    return;
                }
            }
            if (txtMemberNo.Text.Trim() == "")
            {
                MessageBox.Show("Member No is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberNo.Focus();
                return;


            }

            if (onewMember == null)
                onewMember = new Classes.Member();
            onewMember.IdNumber = txtIdNumber.Text;
            onewMember.MemberNo = txtMemberNo.Text;

            if (onewMemberApplication != null)
                onewMember.MemberApplicationId = onewMemberApplication.MemberApplicationId;

            onewMember.MemberName = txtmembername.Text;
            onewMember.RegDate = dtpRegDate.Value;
            onewMember.PhoneNumber = txtphoneno.Text;
            onewMember.DateOfBirth = dtpdateofbirth.Value;
            if (cmbGender.SelectedItem == null)
            {
                cmbGender.SelectedItem = onewMember.Gender;
                onewMember.Gender = cmbGender.SelectedItem.ToString();
            }
            else
            {
                onewMember.Gender = cmbGender.SelectedItem.ToString();
            }

            if (cmbMaritalStatus.SelectedItem == null)
            {
                cmbMaritalStatus.SelectedItem = onewMember.MaritalStatus;
                onewMember.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            }
            else
            {
                onewMember.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            }
            onewMember.KraPin = txtkrapin.Text;
            onewMember.CustomerBankId = int.Parse(txtbankid.Text);
            onewMember.CustomerBankBranchId = int.Parse(txtbankbranchid.Text);
            onewMember.CustomerBankAccount = txtaccountno.Text;
            onewMember.Tel1 = txttel1.Text;
            onewMember.Tel2 = txttel2.Text;
            onewMember.EmailAddress = txtemail.Text;
            onewMember.PostalAddress = txtpostaladdress.Text;
            onewMember.PhysicalAddress = txtphysicaladdress.Text;

            if (onewEmployer != null)
                onewMember.EmployerId = onewEmployer.EmployerId;

            if (onewStation != null)
                onewMember.StationId = onewStation.StationId;

            onewMember.DepartmentId = int.Parse(txtdepartmentid.Text);
            onewMember.WithdrawalId = int.Parse(txtwithdrawalid.Text);
            onewMember.IsActive = chkIsActive.Checked;
            onewMember.GrossSalary = double.Parse(txtgrosssalary.Text);
            onewMember.Netsalary = double.Parse(txtnetsalary.Text);

            if (onewClientClassification != null)
                onewMember.ClientClassificationId = onewClientClassification.ClientClassificationId;

            onewMember.CompanyId = int.Parse(txtcompanyid.Text);
            onewMember.RegCertNo = txtcertificateno.Text;
            onewMember.IsCompany = chkIsCompany.Checked;
            onewMember.ProcessId = int.Parse(txtprocessid.Text);
            onewMember.BranchId = int.Parse(txtbranchid.Text);

            // onewMember.Title = cmbTitle.SelectedItem.ToString ();
            if (cmbTitle.SelectedItem == null)
            {
                cmbTitle.SelectedItem = onewMember.Title;
                onewMember.Title = cmbTitle.SelectedItem.ToString();
            }
            else
            {
                onewMember.Gender = cmbGender.SelectedItem.ToString();
            }


            string error = "";

            onewMember.MemberId = onewMember.AddEdit(false, ref error);

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
            if (onewMember == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;

            bool Linked = false;
            ArrayList myBenList = oBen.GetBens();
            foreach (Classes.Ben obe in myBenList)
            {
                if (obe.MemberId == onewMember.MemberId)
                {
                    Linked = true;
                    break;

                }
            }
            if (Linked)
            {
                MessageBox.Show("Member has been linked to Beneficiary", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }



            ArrayList myKinList = oKin.GetKins();
            foreach (Classes.Kin oki in myKinList)
            {
                if (oki.MemberId == onewMember.MemberId)
                {
                    Linked = true;
                    break;

                }
            }
            if (Linked)
            {
                MessageBox.Show("Member has been linked to Next of kin", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            ArrayList myMemberDocumentList = oMemberDocument.GetMemberDocuments();
            foreach (Classes.MemberDocument omemdoc in myMemberDocumentList)
            {
                if (omemdoc.MemberId == onewMember.MemberId)
                {
                    Linked = true;
                    break;

                }
            }
            if (Linked)
            {
                MessageBox.Show("Member has been linked to Member Document", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string error = "";

            onewMember.AddEdit(true, ref error);

            if (error == "")
            {
                ClearTexts();
                MessageBox.Show("Process succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                onewMember = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewClientClassification = null;
            onewStation = null;
            onewEmployer = null;
            onewMemberApplication = null;
            onewMember = null;
            ClearTexts();


        }
        private void ClearTexts()
        {

            txtIdNumber.Text = "";
            txtMemberNo.Text = "";
            txtmembername.Text = "";
            dtpRegDate.Text = "";
            txtphoneno.Text = "";
            dtpdateofbirth.Text = "";
            cmbGender.SelectedItem = "";
            cmbMaritalStatus.SelectedItem = "";
            txtkrapin.Text = "";
            txtbankid.Text = "";
            txtbankbranchid.Text = "";
            chkIsActive.Checked = true;
            txtaccountno.Text = "";
            txttel1.Text = "";
            txttel2.Text = "";
            txtemail.Text = "";
            txtpostaladdress.Text = "";
            txtphysicaladdress.Text = "";
            txtemployerid.Text = "";
            txtstationid.Text = "";
            txtdepartmentid.Text = "";
            txtwithdrawalid.Text = "";
            txtgrosssalary.Text = "";
            txtnetsalary.Text = "";
            txtclassificationid.Text = "";
            txtcompanyid.Text = "";
            txtcertificateno.Text = "";
            txtprocessid.Text = "";
            chkIsCompany.Checked = false;
            txtbranchid.Text = "";
            cmbTitle.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            frmSearchKin frm = new frmSearchKin();
            frm.ShowDialog();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnsearchEmployer_Click(object sender, EventArgs e)
        {
            frmSearchEmployer frm = new frmSearchEmployer();
            frm.ShowDialog();
            onewEmployer = oEmployer.GetEmployer(frm.selInt);
            if (onewEmployer != null)
                txtemployerid.Text = onewEmployer.EmployerName;
        }

        private void btnsearchClientClassificationId_Click(object sender, EventArgs e)
        {
            frmSearchClientClassification frm = new frmSearchClientClassification();
            frm.ShowDialog();
            onewClientClassification = oClientClassification.GetClientClassification(frm.selInt);
            if (onewClientClassification != null)
                txtclassificationid.Text = onewClientClassification.ClientClassificationName;
        }

        private void btnsearchstationNo_Click(object sender, EventArgs e)
        {
            frmSearchStation frm = new frmSearchStation();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewStation = oStation.GetStation(frm.selInt);
            if (onewStation != null)
            {
                if (onewStation.IsActive == true)
                {
                    txtstationid.Text = onewStation.StationName;
                }
                else
                {
                    string str = lblStation .Text;
                    string newname = str.Replace(":", string.Empty);
                    MessageBox.Show("Use Active "+newname , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            frmMembersReport frm = new frmMembersReport();
            frm.ShowDialog();


        }

        private void btnsearchEmployer_Click_1(object sender, EventArgs e)
        {
            frmSearchEmployer frm = new frmSearchEmployer();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewEmployer = oEmployer.GetEmployer(frm.selInt);
            if (onewEmployer != null)
            {
                if (onewEmployer.IsActive == true)
                {
                    txtemployerid.Text = onewEmployer.EmployerName;
                }
                else
                {
                    string str = lblEmployer.Text;
                    string newname = str.Replace(":", String.Empty);
                    MessageBox.Show("In Active "+newname  , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

        }

        private void btnsearchClientClassificationId_Click_1(object sender, EventArgs e)
        {
            frmSearchClientClassification frm = new frmSearchClientClassification();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewClientClassification = oClientClassification.GetClientClassification(frm.selInt);
            if (onewClientClassification != null)
            {
                if (onewClientClassification.IsActive == true)

                    txtclassificationid.Text = onewClientClassification.ClientClassificationName;
            }
            else
            {
                string str = lblClassification .Text;
                string newname = str.Replace(":", string.Empty);
               MessageBox.Show("In Active "+newname, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
                myList = OMember.GetMembers();

            int counter = 0;

            if (onewMember != null)
            {
                foreach (Classes.Member omem in myList)
                {
                    if (omem.MemberId == onewMember.MemberId)
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


            onewMember = (Classes.Member)myList[counter];
            displayInfo();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (onewMember == null)
            {
                MessageBox.Show("Member required ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmSearchMemberDocument frm = new frmSearchMemberDocument();
            frm.PickingValues = true;
            frm.MemberId = onewMember.MemberId;
             frm.ShowDialog();
           
            onewMemberDocument = oMemberDocument.GetMemberDocument(frm.selInt );
           
            if(onewMemberDocument  !=null)
            {

                frmMemberDocument frm1 = new frmMemberDocument();
                
                frm1.displayInfo(frm.selInt);
                
                frm.MemberId = onewMember.MemberId;
                frm1.SelectedDocuments = true;
                frm1.ShowDialog();
                

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if(onewBank !=null)
            {
                txtbankid.Text = onewBank.BankName;
            }
        }

        private void txtMemberNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMemberNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = OMember.GetMembers();
                foreach (Classes.Member omen in myList)
                {
                    if (txtMemberNo.Text == omen.MemberNo)
                    {
                        onewMember = omen;
                        displayInfo();
                        found = true;
                    }

                }
                if(!found)
                {
                    onewMember = null;
                    displayInfo();
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberNo.Focus();
                }
            }



        }

        private void txtbankid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbankid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool found = false;
                ArrayList myList = OMember.GetMembers();
                foreach (Classes.Member omen in myList)
                {
                    if (txtIdNumber.Text == omen.IdNumber)
                    {
                        onewMember = omen;
                        displayInfo();
                        found = true;
                    }
                }
                if(!found)
                {
                    onewMember = null;
                    ClearTexts();
                    displayInfo();
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdNumber.Focus();
                }
            }
        }
    }
}


