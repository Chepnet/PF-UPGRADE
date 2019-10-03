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
    public partial class frmMemberApplication : Form
    {
        Classes.MemberApplication oMemberApplication = new Classes.MemberApplication();
        Classes.MemberApplication onewMemberApplication = null;
        //bool posting = false;

        Classes.Station oStation = new Classes.Station();
        Classes.Station onewStation = null;

        Classes.Employer oEmployer = new Classes.Employer();
        Classes.Employer onewEmployer = null;

        Classes.ClientClassification oClientClassification = new Classes.ClientClassification();
        Classes.ClientClassification onewClientClassification = null;

        Classes.Caption oCaption = new Classes.Caption();
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        private bool posting = false;
        private bool saving = false;

        Classes.CompulsoryField oCompulsoryField = new Classes.CompulsoryField();
        Classes.CompulsoryField onewCompulsoryField = null;



        Classes.Prefix oPrefix = new Classes.Prefix();
        Classes.Prefix onewPrefix = null;

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;

        Classes.MemberDocument oMemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;

        Classes.GroupedOption oGrouped = new Classes.GroupedOption();


        public int memberno = 0;
        public int selInt = 0;
        //public string Code = "";
        //ublic  int memberno = 0;
        //ublic string Code = "MM0";



        public frmMemberApplication()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
            txtMemberName.Focus();



        }
        public void ClearText()
        {
            onewMemberApplication = null;
            onewEmployer = null;
            onewClientClassification = null;
            onewStation = null;
            onewMember = null;

            txtMemberNo.Clear();
            txtIdNumber.Clear();
            txtMemberName.Clear();
            dtpRegDate.Value = DateTime.Now;
            txtPhoneNo.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            cmbGender.SelectedIndex = -1;
            cmbMaritalStatus.SelectedIndex = -1;
            txtKraPin.Clear();
            //txtCustomerBankAccount.Clear();
            txtBankId.Clear();
            txtEmailAddress.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtPostalAddress.Clear();
            txtPhysicalAddress.Clear();
            txtEmployerId.Clear();
            txtStationId.Clear();
            txtDepartmentId.Clear();
            txtWithdrawalId.Clear();
            txtGrossSalary.Clear();
            txtNetSalary.Clear();
            txtClientClassificationId.Clear();
            txtCompanyId.Clear();
            txtRegCertNo.Clear();
            chkIsCompany.Checked = false;
            txtProcessId.Clear();

            txtBankBranchId.Clear();
            cmbTitle.SelectedIndex = -1;
            chkIsActive.Checked = true;
            txtBranchId.Clear();
            txtCustomerBankAccount.Clear();

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchMemberApplication frm = new frmSearchMemberApplication();
            frm.ShowDialog();
            onewMemberApplication = oMemberApplication.GetMemberApplication(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewMemberApplication != null)
            {

                txtIdNumber.Text = onewMemberApplication.IdNumber;
                txtMemberName.Text = onewMemberApplication.MemberName;
                dtpRegDate.Value = onewMemberApplication.RegDate;
                txtPhoneNo.Text = onewMemberApplication.PhoneNo;
                dtpDateOfBirth.Value = onewMemberApplication.DateOfBirth;
                cmbGender.SelectedItem = onewMemberApplication.Gender;
                cmbMaritalStatus.SelectedItem = onewMemberApplication.MaritalStatus;
                txtKraPin.Text = onewMemberApplication.KraPin;
                txtCustomerBankAccount.Text = onewMemberApplication.CustomerBankAccount;
                txtEmailAddress.Text = onewMemberApplication.EmailAddress;
                txtTel1.Text = onewMemberApplication.Tel1;
                txtTel2.Text = onewMemberApplication.Tel2;
                txtPostalAddress.Text = onewMemberApplication.PostalAddress;
                txtPhysicalAddress.Text = onewMemberApplication.PhysicalAddress;

                onewEmployer = oEmployer.GetEmployer(onewMemberApplication.EmployerId);
                if (onewEmployer != null)
                    txtEmployerId.Text = onewEmployer.EmployerName;

                // onewMemberApplication.EmployerId = int.Parse(txtEmployerId.Text) ;
                onewStation = oStation.GetStation(onewMemberApplication.StationId);
                if (onewStation != null)
                    txtStationId.Text = onewStation.StationName;

                // onewMemberApplication.StationId = int.Parse(txtStationId.Text );
                txtDepartmentId.Text = onewMemberApplication.DepartmentId.ToString();
                txtWithdrawalId.Text = onewMemberApplication.WithdrawalId.ToString();
                txtGrossSalary.Text = onewMemberApplication.GrossSalary.ToString();
                txtNetSalary.Text = onewMemberApplication.NetSalary.ToString();
                //onewMemberApplication.ClientClassificationId = int.Parse(txtClientClassificationId.Text) ;
                onewClientClassification = oClientClassification.GetClientClassification(onewMemberApplication.ClientClassificationId);
                if (onewClientClassification != null)
                    txtClientClassificationId.Text = onewClientClassification.ClientClassificationName;
                txtCompanyId.Text = onewMemberApplication.CompanyId.ToString();
                txtRegCertNo.Text = onewMemberApplication.RegCertNo;
                chkIsActive.Checked = onewMemberApplication.IsActive;
                chkIsCompany.Checked = onewMemberApplication.IsCompany;
                txtProcessId.Text = onewMemberApplication.ProcessId.ToString();
                txtBankBranchId.Text = onewMemberApplication.CustomerBankBranchId.ToString();
                txtBranchId.Text = onewMemberApplication.BranchId.ToString();
                onewBank = oBank.GetBank(onewMemberApplication.CustomerBankId);
                if (onewBank != null)
                    txtBankId.Text = onewBank.BankName;
                cmbTitle.SelectedItem = onewMemberApplication.Title.ToString();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saving = true;
            posting = false;
            SaveRecord();
        }
        private void SaveRecord()
        {

            bool required = false;

            //Validating if a user has entered the name before saving
            if (txtMemberName.Text.Trim() == "")
            {
                required = true;
                
                
            }
            if(required )
            {
                if (saving)
                {


                    MessageBox.Show("Name   is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberName.Focus();
                    return;


                }
               
                else
                {

                }
                
            }
            if(txtBankId.Text.Trim () =="")
            {
                MessageBox.Show("Bank is Required", this.Text , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBankId.Focus();
                return;
            }
            if (txtEmployerId .Text.Trim() == "")
            {
                MessageBox.Show("Employer is Required", this.Text , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmployerId .Focus();
                return;
            }
            if (txtClientClassificationId .Text.Trim() == "")
            {
                MessageBox.Show("Client Classification is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtClientClassificationId .Focus();
                return;
            }
            if (txtStationId.Text .Trim() == "")
            {
                MessageBox.Show("Station is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStationId .Focus();
                return;
            }


            {

                System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                if (txtEmailAddress.Text.Length > 0 && txtEmailAddress.Text.Trim().Length != 0)
                {
                    if (!rEmail.IsMatch(txtEmailAddress.Text.Trim()))
                    {
                        MessageBox.Show("Incorrect email format");
                        txtEmailAddress.SelectAll();
                        txtEmailAddress.Focus();
                        return;
                    }
                }

            }
            {
                DateTime dob = (dtpDateOfBirth.Value.Date);
                //  DateTime regdate = (dtpRegDate.Value.Date);

                textBox1.Text = dob.ToString();
                TimeSpan tm = (DateTime.Now - dob);
                int age = (tm.Days / 365);
                if (age < 18)
                {
                    if(saving )
                    {

                    
                    MessageBox.Show("Invalid Date Of Birth", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    dtpDateOfBirth.Focus();
                    return;
                    }
                    else
                    {

                    }

                }
            }




            int Customerbankid = 0;

            int Departmentid = 0;
            int withdrawalid = 0;
            int Processid = 0;
            int BranchId = 0;
            int CustomerBankBranchId = 0;
            int CompanyId = 0;
            Double GrossSalary = 0;
            Double NetSalary = 0;






            if (onewMemberApplication == null)
                onewMemberApplication = new Classes.MemberApplication();



            onewMemberApplication.IdNumber = txtIdNumber.Text;
            onewMemberApplication.MemberName = txtMemberName.Text;
            int.TryParse(txtBankBranchId.Text, out CustomerBankBranchId);
            onewMemberApplication.CustomerBankBranchId = CustomerBankBranchId;
            onewMemberApplication.RegDate = dtpRegDate.Value;
            onewMemberApplication.PhoneNo = txtPhoneNo.Text;
            onewMemberApplication.DateOfBirth = dtpDateOfBirth.Value;
            if (cmbGender.SelectedItem == null)
            {
                cmbGender.SelectedText = "";
                onewMemberApplication.Gender = cmbGender.SelectedText;
            }
            else if (cmbGender.SelectedItem != null)
            {
                onewMemberApplication.Gender = cmbGender.SelectedItem.ToString();
            }

            if (cmbMaritalStatus.SelectedItem == null)
            {
                cmbMaritalStatus.SelectedText = "";
                onewMemberApplication.MaritalStatus = cmbMaritalStatus.SelectedText;
            }
            else if (cmbMaritalStatus.SelectedItem != null)
            {
                onewMemberApplication.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            }
            onewMemberApplication.KraPin = txtKraPin.Text;
            onewMemberApplication.CustomerBankAccount = txtCustomerBankAccount.Text;

            // int.TryParse(txtBankId.Text, out Customerbankid);
            if (onewBank != null)

                onewMemberApplication.CustomerBankId = onewBank.BankId;

            onewMemberApplication.EmailAddress = txtEmailAddress.Text;
            onewMemberApplication.Tel1 = txtTel1.Text;
            onewMemberApplication.Tel2 = txtTel2.Text;
            onewMemberApplication.PostalAddress = txtPostalAddress.Text;
            onewMemberApplication.PhysicalAddress = txtPhysicalAddress.Text;

            if (onewEmployer != null)
                onewMemberApplication.EmployerId = onewEmployer.EmployerId;

            if (onewStation != null)
                onewMemberApplication.StationId = onewStation.StationId;


            int.TryParse(txtDepartmentId.Text, out Departmentid);
            onewMemberApplication.DepartmentId = Departmentid;

            int.TryParse(txtWithdrawalId.Text, out withdrawalid);

            onewMemberApplication.WithdrawalId = withdrawalid;

            Double.TryParse(txtGrossSalary.Text, out GrossSalary);
            onewMemberApplication.GrossSalary = GrossSalary;

            Double.TryParse(txtNetSalary.Text, out NetSalary);
            onewMemberApplication.NetSalary = NetSalary;

            if (onewClientClassification != null)
                onewMemberApplication.ClientClassificationId = onewClientClassification.ClientClassificationId;

            // onewMemberApplication.ClientClassificationId = int.Parse(txtClientClassificationId.Text);

            int.TryParse(txtCompanyId.Text, out CompanyId);
            onewMemberApplication.CompanyId = CompanyId;


            onewMemberApplication.RegCertNo = txtRegCertNo.Text;
            onewMemberApplication.IsCompany = chkIsCompany.Checked;

            int.TryParse(txtProcessId.Text, out Processid);
            onewMemberApplication.ProcessId = Processid;
            int.TryParse(txtBranchId.Text, out BranchId);
            onewMemberApplication.BranchId = BranchId;
            if (cmbTitle.SelectedItem == null)
            {
                cmbTitle.SelectedText = "";
                onewMemberApplication.Title = cmbTitle.SelectedText;
            }
            else if (cmbTitle.SelectedItem != null)
            {
                onewMemberApplication.Title = cmbTitle.SelectedItem.ToString();
            }


            onewMemberApplication.IsActive = chkIsActive.Checked;

            string error = "";
            onewMemberApplication.MemberApplicationId = onewMemberApplication.AddEditMemberApplication(false, ref error);
            if (error == "")


                if (posting)
                {

                }
                else
                {

                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
            {

                if (posting)
                {

                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewMemberApplication == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            string error = "";
            onewMemberApplication.MemberApplicationId = onewMemberApplication.AddEditMemberApplication(true, ref error);
            if (error == "")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                onewMemberApplication = null;
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            frmSearchStation frm = new SYSTEMUPGRADEPF.frmSearchStation();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewStation = oStation.GetStation(frm.selInt);
            if (onewStation != null)
            {
                if (onewStation.IsActive == true)
                {
                    txtStationId.Text = onewStation.StationName;
                }
                else
                {
                    string str = lblStation.Text;
                    string newname = str.Replace(":", string.Empty);
                   MessageBox.Show("InActive " + newname, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btnSearchEmployer_Click(object sender, EventArgs e)
        {
            frmSearchEmployer frm = new SYSTEMUPGRADEPF.frmSearchEmployer();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewEmployer = oEmployer.GetEmployer(frm.selInt);
            if (onewEmployer != null)
            {
                if (onewEmployer.IsActive == true)
                {
                    txtEmployerId.Text = onewEmployer.EmployerName;
                }
                else
                {
                    string str = lblEmployer.Text;
                    string newname = str.Replace(":", string.Empty);

                    MessageBox.Show("In Active " + newname, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void frmMemberApplication_Load(object sender, EventArgs e)
        {
            if (IsAutoGenerate())
            {
                txtMemberNo.Visible = false;
                lblMemberNo.Visible = false;
            }
            ReadCaption();
            //CompulsoryFields();
            lblName.ForeColor = System.Drawing.Color.Blue;

        }
        private void CompulsoryFields()
        {
          
            ArrayList myList = new ArrayList();
            myList = oCompulsoryField.GetCompulsoryFields();
            foreach (Classes.CompulsoryField oca in myList )
            {
               
          switch (oca.FieldName)
                {
                    case "MemberName":
                        if (oca.IsRequired == true)
                            lblName.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "IdNumber":
                        if (oca.IsRequired == true)
                            lblIdNo .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Station":
                        if (oca.IsRequired == true)
                            lblStation .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Department":
                        if (oca.IsRequired == true)
                            lblDepartment .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "RegDate":
                        if (oca.IsRequired == true)
                            lblRegDate .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "DateOfBirth":
                        if (oca.IsRequired == true)
                            lblDoB .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Gender":
                        if (oca.IsRequired == true)
                            lblGender .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "MaritalStatus":
                        if (oca.IsRequired == true)
                            lblMaritalStatus .ForeColor = System.Drawing.Color.Blue;
                        break;

                    case "KraPin":
                        if (oca.IsRequired == true)
                            lblKraPin.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "CustomerBankAccount":
                        if (oca.IsRequired == true)
                            lblCustomerBankAccount .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "CustomerBank":
                        if (oca.IsRequired == true)
                            lblBank .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "EmailAddress":
                        if (oca.IsRequired == true)
                            lblEmailAddress .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Tel1":
                        if (oca.IsRequired == true)
                            lblTel1 .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Tel2":
                        if (oca.IsRequired == true)
                            lblTel2 .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "PostalAddress":
                        if (oca.IsRequired == true)
                            lblPostalAddress .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "PhysicalAddress":
                        if (oca.IsRequired == true)
                            lblPhysicalAddress .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Employer":
                        if (oca.IsRequired == true)
                            lblEmployer .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "WithdrawalId":
                        if (oca.IsRequired == true)
                            lblWithdrawal .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "GrossSalary":
                        if (oca.IsRequired == true)
                            lblGrossSalary .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "NetSalary":
                        if (oca.IsRequired == true)
                            lblNetSalary .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Client Classification":
                        if (oca.IsRequired == true)
                            lblClientClassification .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Company":
                        if (oca.IsRequired == true)
                            lblCompany.ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Process":
                        if (oca.IsRequired == true)
                            lblProcess .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Branch":
                        if (oca.IsRequired == true)
                            lblBranch .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Title":
                        if (oca.IsRequired == true)
                            lblTitle .ForeColor = System.Drawing.Color.Blue;
                        break;
                    case "Mobile Number":
                        if(oca.IsRequired == true)
                        lblPhoneNo .ForeColor = System.Drawing.Color.Blue;
                        break;
                   






                }



                //lblTitle.ForeColor = System.Drawing.Color.Red;

                //dtpRegDate.ForeColor = System.Drawing.Color.Red;
                //lblPhoneNo.ForeColor = System.Drawing.Color.Red;
                //lblGender.ForeColor = System.Drawing.Color.Red;
                //cmbMaritalStatus.SelectedIndex = -1;
                //lblKraPin.ForeColor = System.Drawing.Color.Red;
                ////lblCustomerBankAccount.Forecolor=System.Drawing.Color.Red;
                //lblBank.ForeColor = System.Drawing.Color.Red;
                //lblEmailAddress.ForeColor = System.Drawing.Color.Red;
                //lblTel1.ForeColor = System.Drawing.Color.Red;
                //lblTel2.ForeColor = System.Drawing.Color.Red;
                //lblPostalAddress.ForeColor = System.Drawing.Color.Red;
                //lblPhysicalAddress.ForeColor = System.Drawing.Color.Red;
                //lblEmployer.ForeColor = System.Drawing.Color.Red;
                //lblStation.ForeColor = System.Drawing.Color.Red;
                //lblDepartment.ForeColor = System.Drawing.Color.Red;
                //lblWithdrawal.ForeColor = System.Drawing.Color.Red;
                //lblGrossSalary.ForeColor = System.Drawing.Color.Red;
                //lblNetSalary.ForeColor = System.Drawing.Color.Red;
                //lblClientClassification.ForeColor = System.Drawing.Color.Red;
                //lblCompany.ForeColor = System.Drawing.Color.Red;
                //lblRegCertNo.ForeColor = System.Drawing.Color.Red;
                //chkIsCompany.Checked = false;
                //lblProcess.ForeColor = System.Drawing.Color.Red;

                //lblBranch.ForeColor = System.Drawing.Color.Red;
                //lblMaritalStatus.ForeColor = System.Drawing.Color.Red;
                //lblCustomerBankAccount.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList)
            {
                switch (ocap.DefaultCaptionName)
                {
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
                        lblPhoneNo.Text = ocap.CaptionName + ":";
                        break;
                    case "Bank":
                        lblBank.Text = ocap.CaptionName + ":";
                        break;
                    case "Bank Branch":
                        lblBranch.Text = ocap.CaptionName + ":";
                        break;
                    case "Cert No":
                        lblRegCertNo.Text = ocap.CaptionName + ":";
                        break;
                    case "Client Classification":
                        lblClientClassification.Text = ocap.CaptionName + ":";
                        break;
                }
            }
        }

        private void toolStripPost_Click(object sender, EventArgs e)
        {
            CompulsoryFields();
           
            posting = true;
           
            SaveRecord();
            saving = false;
            {


                bool IsRequired = false;
                ArrayList newList = oCompulsoryField.GetCompulsoryFields();
                foreach (Classes.CompulsoryField ocompul in newList)
                {
                    switch (ocompul.FieldName)
                    {
                        case "MemberName":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {

                                if (txtMemberName.Text.Trim() == "")
                                {
                                    string strname = lblName.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtMemberName.Focus();
                                    return;
                                }
                            }

                            break;
                        case "IdNumber":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtIdNumber.Text.Trim() == "")
                                {
                                    string strname = lblIdNo.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtIdNumber.Focus();
                                    return;
                                }
                            }
                            break;
                        case "RegDate":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {

                                if (dtpRegDate.Value.Date == null)
                                {
                                    string strname = lblRegDate.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    dtpRegDate.Focus();

                                    return;
                                }


                            }


                            break;
                        case "DateOfBirth":
                            // Agefactor();
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (dtpDateOfBirth.Value.Date == null)
                                {
                                    string strname = lblDoB.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Show();
                                    tabPage2.Hide();

                                    dtpDateOfBirth.Focus();

                                    return;


                                }
                            }
                            break;



                        case "Gender":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {

                                if (cmbGender.SelectedItem == null)
                                {
                                    string strname = lblGender.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    //tabPage2.Hide();
                                    tabPage1.Show();
                                    cmbGender.Focus();

                                    return;
                                }
                            }

                            break;
                        case "MaritalStatus":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (cmbMaritalStatus.SelectedItem == null)
                                {
                                    string strname = lblMaritalStatus.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Show();
                                    tabPage2.Hide();
                                    cmbMaritalStatus.Focus();
                                    return;
                                }
                            }
                            break;
                        case "KraPin":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtKraPin.Text.Trim() == "")
                                {
                                    string strname = lblKraPin.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtKraPin.Focus();
                                    return;
                                }
                            }
                            break;
                        case "CustomerBankAccount":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtCustomerBankAccount.Text.Trim() == "")
                                {
                                    string strname = lblCustomerBankAccount.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtCustomerBankAccount.Focus();
                                    return;
                                }
                            }
                            break;
                        case "CustomerBank":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtBankId.Text.Trim() == "")
                                {
                                    string strname = lblBank.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtBankId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "EmailAddress":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtEmailAddress.Text.Trim() == "")
                                {
                                    string strname = lblEmailAddress.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Show();
                                    tabPage2.Hide();
                                    txtEmailAddress.Focus();
                                    return;
                                }

                                {

                                    System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

                                    if (txtEmailAddress.Text.Length > 0 && txtEmailAddress.Text.Trim().Length != 0)
                                    {
                                        if (!rEmail.IsMatch(txtEmailAddress.Text.Trim()))
                                        {
                                            MessageBox.Show("Incorrect email format");
                                            txtEmailAddress.SelectAll();
                                            txtEmailAddress.Focus();
                                            return;
                                        }
                                    }
                                }



                            }
                            break;
                        case "Tel1":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtTel1.Text.Trim() == "")
                                {
                                    string strname = lblTel1.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtTel1.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Mobile Number":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtPhoneNo.Text.Trim() == "")
                                {
                                    string strname = lblPhoneNo.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtPhoneNo.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Tel2":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtTel2.Text.Trim() == "")
                                {
                                    string strname = lblTel2.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtTel2.Focus();
                                    return;
                                }
                            }
                            break;
                        case "PostalAddress":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtPostalAddress.Text.Trim() == "")
                                {
                                    string strname = lblPostalAddress.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtPostalAddress.Focus();
                                    return;
                                }
                            }
                            break;
                        case "PhysicalAddress":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtPhysicalAddress.Text.Trim() == "")
                                {
                                    string strname = lblPhysicalAddress.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtPhysicalAddress.Focus();
                                    return;
                                }
                            }
                            break;

                        case "Employer":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtEmployerId.Text.Trim() == "")
                                {
                                    string strname = lblEmployer.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtEmployerId.Focus();
                                    return;
                                }
                            }
                            break;

                        case "Station":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtStationId.Text.Trim() == "")
                                {
                                    // changing  the messagebox text to match the caption changed by the user using this code
                                    // MessageBox.Show(lblStation.Text + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    //To remove colon on the caption from being displayed we use this code down here

                                    string strname = lblStation.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage2.Hide();
                                    tabPage1.Show();
                                    txtStationId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Department":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtDepartmentId.Text.Trim() == "")
                                {
                                    string strname = lblDepartment.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtDepartmentId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "WithdrawalId":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtWithdrawalId.Text.Trim() == "")
                                {
                                    string strname = lblWithdrawal.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtWithdrawalId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "GrossSalary":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtGrossSalary.Text.Trim() == "")
                                {
                                    string strname = lblGrossSalary.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtGrossSalary.Focus();
                                    return;
                                }
                            }
                            break;
                        case "NetSalary":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtNetSalary.Text.Trim() == "")
                                {
                                    string strname = lblNetSalary.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtNetSalary.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Client Classification":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtClientClassificationId.Text.Trim() == "")
                                {
                                    string strname = lblClientClassification.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Show();
                                    tabPage2.Hide();
                                    txtClientClassificationId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Company":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtCompanyId.Text.Trim() == "")
                                {
                                    string strname = lblCompany.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtCompanyId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "RegCertNo":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtRegCertNo.Text.Trim() == "")
                                {
                                    string strname = lblRegCertNo.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtRegCertNo.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Process":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtProcessId.Text.Trim() == "")
                                {
                                    string strname = lblProcess.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtProcessId.Focus();
                                    return;
                                }
                            }
                            break;

                        case "Branch":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (txtBankBranchId.Text.Trim() == "")
                                {
                                    string strname = lblBranch.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    tabPage1.Hide();
                                    tabPage2.Show();
                                    txtBankBranchId.Focus();
                                    return;
                                }
                            }
                            break;
                        case "Title":
                            IsRequired = ocompul.IsRequired;
                            if (IsRequired)
                            {
                                if (cmbTitle.SelectedItem == null)
                                {
                                    string strname = lblTitle.Text;
                                    string newname = strname.Replace(":", string.Empty);
                                    MessageBox.Show(newname + " is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    cmbTitle.Focus();//To take the cursor to where the combobox of the title is
                                    return;//to stop from doing anything
                                }
                            }
                            break;






                    }


                }

                if (IsBelow18())
                    return;






            }
            if (!IsAutoGenerate())
            {


                MemberNo();
            }
            else
            {
                AutoGenerateMemberNo();
            }
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oMember.GetMembers();
            foreach (Classes.Member omem in myList)
            {
                if (txtMemberNo.Text.Trim().ToLower() == omem.MemberNo.Trim().ToLower())
                {
                    if (onewMember.MemberId != omem.MemberId)
                    {
                        exist = true;
                        break;
                    }
                }

            }
            if (exist)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {



                int bankid = 0;
                int Departmentid = 0;
                int withdrawalid = 0;
                int Processid = 0;
                int CustomerBankBranchid = 0;
                int BrachId = 0;
                int CompanyId = 0;
                Double GrossSalary = 0;
                Double NetSalary = 0;
                //String   Gender= null;


                if (onewMember == null)
                    onewMember = new Classes.Member();


                // onewMemberApplication = oMemberApplication.GetMemberApplication(onewMember.MemberApplicationId);
                if (onewMemberApplication != null)
                {
                    onewMember.MemberApplicationId = onewMemberApplication.MemberApplicationId;
                }
  
                onewMember.MemberNo = txtMemberNo.Text;
                onewMember.IdNumber = txtIdNumber.Text;
                onewMember.MemberName = txtMemberName.Text;
                onewMember.RegDate = dtpRegDate.Value;
                onewMember.PhoneNumber = txtPhoneNo.Text;
                onewMember.DateOfBirth = dtpDateOfBirth.Value;
                // cmbGender.SelectedItem = Gender;

                if (cmbGender.SelectedItem == null)
                {
                    cmbGender.SelectedText = "";
                    onewMember.Gender = cmbGender.SelectedText;
                }
                else if (cmbGender.SelectedItem != null)
                {
                    onewMember.Gender = cmbGender.SelectedItem.ToString();
                }

                if (cmbMaritalStatus.SelectedItem == null)
                {
                    cmbMaritalStatus.SelectedText = "";
                    onewMember.MaritalStatus = cmbMaritalStatus.SelectedText;
                }
                else if (cmbMaritalStatus.SelectedItem != null)
                {
                    onewMember.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
                }



                // onewMember.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
                onewMember.KraPin = txtKraPin.Text;
                onewMember.CustomerBankAccount = txtCustomerBankAccount.Text;

              if(onewBank !=null)
                {
                    onewMember.CustomerBankId = onewBank.BankId;
                }

                int.TryParse(txtBankBranchId.Text, out CustomerBankBranchid);
                onewMember.CustomerBankBranchId = CustomerBankBranchid;

                int.TryParse(txtBranchId.Text, out BrachId);
                onewMember.BranchId = BrachId;

                onewMember.EmailAddress = txtEmailAddress.Text;
                onewMember.Tel1 = txtTel1.Text;
                onewMember.Tel2 = txtTel2.Text;
                onewMember.PostalAddress = txtPostalAddress.Text;
                onewMember.PhysicalAddress = txtPhysicalAddress.Text;

                if (onewEmployer != null)
                    onewMember.EmployerId = onewEmployer.EmployerId;

                if (onewStation != null)
                    onewMember.StationId = onewStation.StationId;


                int.TryParse(txtDepartmentId.Text, out Departmentid);
                onewMember.DepartmentId = Departmentid;

                int.TryParse(txtWithdrawalId.Text, out withdrawalid);

                onewMember.WithdrawalId = withdrawalid;

                Double.TryParse(txtGrossSalary.Text, out GrossSalary);
                onewMember.GrossSalary = GrossSalary;

                Double.TryParse(txtNetSalary.Text, out NetSalary);
                onewMember.Netsalary = NetSalary;

                if (onewClientClassification != null)
                    onewMember.ClientClassificationId = onewClientClassification.ClientClassificationId;

                // onewMember.ClientClassificationId = int.Parse(txtClientClassificationId.Text);

                int.TryParse(txtCompanyId.Text, out CompanyId);
                onewMember.CompanyId = CompanyId;


                onewMember.RegCertNo = txtRegCertNo.Text;
                onewMember.IsCompany = chkIsCompany.Checked;

                int.TryParse(txtProcessId.Text, out Processid);
                onewMember.ProcessId = Processid;
                // onewMember.Credentials = txtCredentials.Text;




                if (cmbTitle.SelectedItem == null)
                {
                    cmbTitle.SelectedText = "";
                    onewMember.Title = cmbTitle.SelectedText;
                }
                else if (cmbTitle.SelectedItem != null)
                {
                    onewMember.Title = cmbTitle.SelectedItem.ToString();
                }


                // onewMember.Title = cmbTitle.SelectedItem.ToString ();
                onewMember.IsActive = chkIsActive.Checked;
            }


            string error = "";
            onewMember.MemberId = onewMember.AddEdit(false, ref error);

            if (txtMemberNo.Text.Trim() == "")
            {
                MessageBox.Show("Member No is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberNo.Visible = true;
                lblMemberNo.Visible = true;
                txtMemberNo.Focus();
                return;

            }

            posting = true;
            UpdateMemberApplication();
            if (error == "")
            {

                MessageBox.Show(" Posted successfully", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          







        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        public void AutoGenerateMemberNo()
        {


            if (onewMember == null)
                onewMember = new Classes.Member();

            string error = "";
            int prefixcodeLength = 0, memberIdLength = 0, balLength = 0;

            onewMember.MemberId = onewMember.AddEdit(false, ref error);
            ArrayList myList = oPrefix.GetPrefices();
            foreach (Classes.Prefix opre in myList)
            {
                switch (opre.TableName)
                {
                    case "tblMembers":
                        // onewMember.MemberId = onewMember.MemberId + 1;

                        // memberno = memberno + 1;
                        //txtMemberNo.Text = "" + opre.PrefixCode + memberno.ToString();
                        prefixcodeLength = opre.PrefixCode.Length;
                        memberIdLength = onewMember.MemberId.ToString().Length;
                        balLength = opre.LengthOfCode - (prefixcodeLength + memberIdLength);
                        if (balLength < 0) balLength = 0;

                        balLength++;
                        char zero = '0';
                        txtMemberNo.Text = opre.PrefixCode + (onewMember.MemberId.ToString().PadLeft(balLength, zero));
                        break;
                }

            }




        }

        private void txtRegCertNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrossSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            frmSearchClientClassification frm = new frmSearchClientClassification();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewClientClassification = oClientClassification.GetClientClassification(frm.selInt);
            if (onewClientClassification != null)
            {
                if (onewClientClassification.IsActive == true)
                {
                    txtClientClassificationId.Text = onewClientClassification.ClientClassificationName;
                }
                else
                {
                    string str = lblClientClassification.Text;
                    string newname = str.Replace(":", string.Empty);
                    MessageBox.Show("InActive " + newname, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
        public bool IsBelow18()
        {
            bool isbelow = false;
            DateTime dob = (dtpDateOfBirth.Value.Date);
            //  DateTime regdate = (dtpRegDate.Value.Date);

            textBox1.Text = dob.ToString();
            TimeSpan tm = (DateTime.Now - dob);
            int age = (tm.Days / 365);
            if (age < 18)
            {
                MessageBox.Show("Invalid Date Of Birth", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabPage1.Show();
                tabPage2.Hide();
                dtpDateOfBirth.Focus();

                isbelow = true;
            }
            return isbelow;

        }
        public void UpdateMemberApplication()
        {



            int Customerbankid = 0;

            int Departmentid = 0;
            int withdrawalid = 0;
            int Processid = 0;
            int BranchId = 0;
            int CustomerBankBranchId = 0;
            int CompanyId = 0;
            Double GrossSalary = 0;
            Double NetSalary = 0;






            if (onewMemberApplication == null)

                onewMemberApplication = new Classes.MemberApplication();

            // onewMember = oMember.GetMember(onewMemberApplication.MemberId );
            if (onewMember != null)
                onewMemberApplication.MemberId = onewMember.MemberId;


            onewMemberApplication.IdNumber = txtIdNumber.Text;
            onewMemberApplication.MemberName = txtMemberName.Text;
            int.TryParse(txtBankBranchId.Text, out CustomerBankBranchId);
            onewMemberApplication.CustomerBankBranchId = CustomerBankBranchId;
            onewMemberApplication.RegDate = dtpRegDate.Value;
            onewMemberApplication.PhoneNo = txtPhoneNo.Text;
            onewMemberApplication.DateOfBirth = dtpDateOfBirth.Value;
            if (cmbGender.SelectedItem == null)
            {
                cmbGender.SelectedText = "";
                onewMemberApplication.Gender = cmbGender.SelectedText;
            }
            else if (cmbGender.SelectedItem != null)
            {
                onewMemberApplication.Gender = cmbGender.SelectedItem.ToString();
            }

            if (cmbMaritalStatus.SelectedItem == null)
            {
                cmbMaritalStatus.SelectedText = "";
                onewMemberApplication.MaritalStatus = cmbMaritalStatus.SelectedText;
            }
            else if (cmbMaritalStatus.SelectedItem != null)
            {
                onewMemberApplication.MaritalStatus = cmbMaritalStatus.SelectedItem.ToString();
            }
            onewMemberApplication.KraPin = txtKraPin.Text;
            onewMemberApplication.CustomerBankAccount = txtCustomerBankAccount.Text;

            int.TryParse(txtBankId.Text, out Customerbankid);
            onewMemberApplication.CustomerBankId = Customerbankid;

            onewMemberApplication.EmailAddress = txtEmailAddress.Text;
            onewMemberApplication.Tel1 = txtTel1.Text;
            onewMemberApplication.Tel2 = txtTel2.Text;
            onewMemberApplication.PostalAddress = txtPostalAddress.Text;
            onewMemberApplication.PhysicalAddress = txtPhysicalAddress.Text;

            if (onewEmployer != null)
                onewMemberApplication.EmployerId = onewEmployer.EmployerId;

            if (onewStation != null)
                onewMemberApplication.StationId = onewStation.StationId;


            int.TryParse(txtDepartmentId.Text, out Departmentid);
            onewMemberApplication.DepartmentId = Departmentid;

            int.TryParse(txtWithdrawalId.Text, out withdrawalid);

            onewMemberApplication.WithdrawalId = withdrawalid;

            Double.TryParse(txtGrossSalary.Text, out GrossSalary);
            onewMemberApplication.GrossSalary = GrossSalary;

            Double.TryParse(txtNetSalary.Text, out NetSalary);
            onewMemberApplication.NetSalary = NetSalary;

            if (onewClientClassification != null)
                onewMemberApplication.ClientClassificationId = onewClientClassification.ClientClassificationId;

            // onewMemberApplication.ClientClassificationId = int.Parse(txtClientClassificationId.Text);

            int.TryParse(txtCompanyId.Text, out CompanyId);
            onewMemberApplication.CompanyId = CompanyId;


            onewMemberApplication.RegCertNo = txtRegCertNo.Text;
            onewMemberApplication.IsCompany = chkIsCompany.Checked;

            int.TryParse(txtProcessId.Text, out Processid);
            onewMemberApplication.ProcessId = Processid;
            int.TryParse(txtBranchId.Text, out BranchId);
            onewMemberApplication.BranchId = BranchId;
            if (cmbTitle.SelectedItem == null)
            {
                cmbTitle.SelectedText = "";
                onewMemberApplication.Title = cmbTitle.SelectedText;
            }
            else if (cmbTitle.SelectedItem != null)
            {
                onewMemberApplication.Title = cmbTitle.SelectedItem.ToString();
            }


            onewMemberApplication.IsActive = chkIsActive.Checked;


            string error = "";
            onewMemberApplication.MemberApplicationId = onewMemberApplication.AddEditMemberApplication(false, ref error);


            if (error == "")
            {
                if (posting == true)
                { }
                else
                {
                    MessageBox.Show("Update succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (posting == true)
                {
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public bool IsAutoGenerate()
        {


            bool Auto = false;
            ArrayList myList = oGrouped.GetGroupedOptions();
            foreach (Classes.GroupedOption ogr in myList)
            {
                switch (ogr.OptionName)
                {
                    case "Auto Generate Member Number":
                        Auto = ogr.BooleanValue;
                        if (Auto)
                        {
                            // AutoGenerateMemberNo();
                            txtMemberNo.Visible = false;

                            Auto = true;
                        }
                        //else
                        //    {
                        //        MemberNo();

                        //    }


                        break;

                }

            }
            return Auto;

        }

        public void MemberNo()
        {

            if (onewMember == null)
                onewMember = new Classes.Member();
            onewMember.MemberNo = txtMemberNo.Text;

            string error = "";

            onewMember.MemberId = onewMember.AddEdit(false, ref error);


        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oMemberApplication.GetUnpostedMemberApplications();

            int counter = 0;

            if (onewMemberApplication != null)
            {
                foreach (Classes.MemberApplication omem in myList)
                {
                    if (omem.MemberApplicationId == onewMemberApplication.MemberApplicationId)
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


            onewMemberApplication = (Classes.MemberApplication)myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            if (onewBank != null)
            {
                txtBankId.Text = onewBank.BankName;

            }
                
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMemberDocument_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMemberDocument_Click_1(object sender, EventArgs e)
        {
            if(onewMemberApplication ==null)
            {
                MessageBox.Show("Member Application is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmMemberApplicationDocument frm = new frmMemberApplicationDocument();
            frm.MemberApplicationId = onewMemberApplication.MemberApplicationId;
           // frmSearchMemberApplicationDocument frm1 = new frmSearchMemberApplicationDocument();
           // frm1.MemberApplicationId = onewMemberApplication.MemberApplicationId;


            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }

}





