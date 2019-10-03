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
    public partial class frmBank : Form
    {
        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        public frmBank()
        {
            InitializeComponent();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewBank = null;
            txtBankName.Focus();
            ClearText();

        }

        private void ClearText()
        {
            txtBankBranch.Text = "";
            txtBankName.Text = "";
            txtContactPerson.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            txtIBAN.Text = "";
            txtRemarks.Text = "";
            txtSwiftCode.Text = "";
            chkIsActive.Checked = true;
            chkIsDefaultMoileAccount.Checked = false;
            txtAccountNo.Text = "";
            txtGLAccount.Text = "";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchBank frm = new SYSTEMUPGRADEPF.frmSearchBank();
            frm.ShowDialog();
            onewBank = oBank.GetBank(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewBank != null)
            {
                txtAccountNo.Text = onewBank.BankAccountNo;
                txtBankName.Text = onewBank.BankName;
                txtBankBranch.Text = onewBank.BranchName;
                txtContactPerson.Text = onewBank.ContactPerson;
                txtEmail.Text = onewBank.Email;

                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank.GLId);
                if (onewChartOfAccount != null)
                
                    txtGLAccount.Text = onewChartOfAccount.AccountName;
                
                txtRemarks.Text = onewBank.Remarks;
                txtSwiftCode.Text = onewBank.SwiftCode;
                txtAddress.Text = onewBank.Address;
                chkIsActive.Checked = onewBank.IsActive;
                chkIsDefaultMoileAccount.Checked = onewBank.IsDefaultMobileAc;
                txtIBAN.Text = onewBank.IBAN;

            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtBankName.Text.Trim() == "")
            {
                MessageBox.Show("Bank Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBankName.Focus();
                return;
            }
            if (txtBankBranch.Text.Trim() == "")
            {
                MessageBox.Show("Bank Branch is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBankBranch.Focus();
                return;
            }
            if (txtGLAccount.Text.Trim() == "")
            {
                MessageBox.Show("GL Account  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGLAccount.Focus();
                return;
            }

            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtEmail.Text.Length > 0 && txtEmail.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Incorrect email format");
                    txtEmail.SelectAll();
                    txtEmail.Focus();
                    return;
                }
            }

            if (onewBank == null)
                onewBank = new Classes.Bank();
            bool exist = false;
            ArrayList myList = oBank.GetBanks();
            foreach(Classes.Bank oba in myList )
            {
                if( txtAccountNo.Text.Trim().ToLower()==oba.BankAccountNo.Trim().ToLower())
                {
                    if( onewBank.BankId!=oba.BankId)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if(exist)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccountNo.Focus();
                return;
            }
            else { 

            onewBank.BankName = txtBankName.Text;
            onewBank.BankAccountNo = txtAccountNo.Text;
            onewBank.BranchName = txtBankBranch.Text;
            onewBank.Address = txtAddress.Text;
            onewBank.ContactPerson = txtContactPerson.Text;
            onewBank.Email = txtEmail.Text;
            onewBank.IBAN = txtIBAN.Text;
            onewBank.IsActive = chkIsActive.Checked;
               // onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewBank  .GLId);
             if(onewChartOfAccount !=null)
                {
                    onewBank.GLId = onewChartOfAccount.GLAccountId;
                }

           // onewBank.GLId = int.Parse(txtGLAccount.Text);
            onewBank.IsDefaultMobileAc = chkIsDefaultMoileAccount.Checked;
            onewBank.SwiftCode = txtSwiftCode.Text;
            onewBank.Remarks = txtRemarks.Text;
            }

            string err = "";
            onewBank.BankId = onewBank.AddEditBank(false, ref err);
            if (err == "")
            {
                MessageBox.Show("Process suceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewBank == null)
            {
                MessageBox.Show("The item to be deleted is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewBank.BankId = onewBank.AddEditBank(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    txtBankName.Focus();

                }

                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            MoveToRecord(true);
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            MoveToRecord(false);
        }

        private void MoveToRecord(bool MoveText)
        {
            ArrayList myList = new ArrayList();
            if (myList.Count == 0)
                myList = oBank.GetBanks();
            int counter = 0;
            if (onewBank != null)
            {
                foreach (Classes.Bank oba in myList)
                {
                    if (oba.BankId == onewBank.BankId)
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (MoveText)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }
            if(MoveText)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }
            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;
            onewBank = (Classes.Bank)myList[counter];
            displayInfo();
            
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new frmSearchChartOfAccounts();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccount != null)
                txtGLAccount.Text = onewChartOfAccount.AccountName;
            
        }
    }
}
