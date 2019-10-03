using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Collections;
using System.Web.UI.WebControls;

namespace SYSTEMUPGRADEPF
{
    public partial class frmChartsOfAccounts : Form
    {
        Classes.ChartOfAccount ochartofAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;
        string err = "";
        bool loadingInfo = false;

        public frmChartsOfAccounts()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
            cmbAccountType.SelectedIndex = -1;
            cmbParent.SelectedIndex = -1;

            frmSearchChartOfAccounts frm = new frmSearchChartOfAccounts();
            frm.ShowDialog();
            onewChartOfAccount = ochartofAccount.GetChartOfAccount(frm.sellInt);
            DisplayInfo();
            
            //txtSearchName.ReadOnly = true;
        }

        private void DisplayInfo()
        {
            if (onewChartOfAccount != null)
            {
                loadingInfo = true;
                // cmbParent.Items.Add(onewChartOfAccount.Parent);
                ArrayList myList = ochartofAccount.GetChartOfAccounts();
                foreach (Classes.ChartOfAccount ocha in myList)

                {

                    if (onewChartOfAccount.Parent == ocha.GLAccountId)
                    {
                        cmbParent.Items.Add(ocha.AccountName);
                        cmbParent.SelectedItem = ocha.AccountName;
                    }


                }


                cmbAccountType.Items.Add(onewChartOfAccount.AccountType);


                txtAccountCode.Text = onewChartOfAccount.AccountCode;
                txtCurrentBalance.Text = onewChartOfAccount.CurrentBalance.ToString();
                txtDescription.Text = onewChartOfAccount.AccountName;
                cmbAccountType.SelectedItem = onewChartOfAccount.AccountType;
                cmbLevel.SelectedItem = onewChartOfAccount.AccountLevel.ToString();
                cmbDCFlag.SelectedItem = onewChartOfAccount.DebitCreditFlag.ToString();
                cmbParent.SelectedItem = onewChartOfAccount.Parent;
                txtOpeningBalance.Text = onewChartOfAccount.OpeningBalance.ToString();
                txtRemarks.Text = onewChartOfAccount.Remarks.ToString();
                chKAllowDirectPosting.Checked = onewChartOfAccount.AllowDirectPosting;
                chkCannotGoToCredit.Checked = onewChartOfAccount.CannotGoToCredit;
                chkCannotGoToDebit.Checked = onewChartOfAccount.CannotGoToDebit;
                chkIsActive.Checked = onewChartOfAccount.IsActive;
                chkReconciable.Checked = onewChartOfAccount.IsReconcialable;
                cmbCategory.SelectedItem = onewChartOfAccount.AccountCategory;
                txtSearchName .Text = onewChartOfAccount.SearchName;

            }
        }

        private void frmChartsOfAccounts_Load(object sender, EventArgs e)
        {
            ochartofAccount.InitializeChartOfAccounts();
            CompulsoryFields();

        }

        private void CompulsoryFields()
        {
            lblAccountCode.ForeColor = System.Drawing.Color.Blue;
            lblDescription.ForeColor = System.Drawing.Color.Blue;
            lblType.ForeColor = System.Drawing.Color.Blue;
            lblLevel.ForeColor = System.Drawing.Color.Blue;
            lblParent.ForeColor = System.Drawing.Color.Blue;
            lblFlag.ForeColor = System.Drawing.Color.Blue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void cmbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //FilterCombobox();
        }

        private void FilterCombobox()
        {
            cmbParent.Items.Clear();
            ArrayList myList = new ArrayList();
            myList = ochartofAccount.GetChartOfAccounts();


            foreach (Classes.ChartOfAccount ocha in myList)
            {
                if (cmbAccountType.SelectedItem.ToString() == ocha.AccountType)
                {
                    int level, Result = 0;
                    int.TryParse(cmbLevel.SelectedItem.ToString(), out level);
                    Result = level - 1;

                    if (ocha.AccountLevel == 0)
                    {
                        cmbParent.Items.Add("");
                    }
                    else
                    {

                        if (Result.ToString() == ocha.AccountLevel.ToString())
                        {

                            cmbParent.Items.Add(ocha.AccountName);

                        }

                    }
                }
            }
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (txtAccountCode.Text.Trim() == "")
            {
                MessageBox.Show("Account Code is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAccountCode.Focus();
                return;
            }
            if (txtDescription .Text.Trim() == "")
            {
                MessageBox.Show("Account Description Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txtDescription .Focus();
                return;
            }
            if (cmbAccountType .SelectedIndex ==-1)
            {
                MessageBox.Show("Account Type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbAccountType.Focus();
                return;
            }
            if (cmbLevel .SelectedIndex == -1)
            {
                MessageBox.Show("Account Level  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbLevel .Focus();
                return;
            }
            if (cmbParent.SelectedIndex == -1)
            {
                MessageBox.Show("Account Parent Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbParent.Focus();
                return;
            }
            if (cmbDCFlag .SelectedIndex == -1)
            {
                MessageBox.Show("Account Flag Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbDCFlag .Focus();
                return;
            }
            int level = 0;
            double currentBalance = 0;
            double OpeningBalance = 0;
            if (onewChartOfAccount == null)
                onewChartOfAccount = new Classes.ChartOfAccount();
            bool exist = false;
            ArrayList newList = new ArrayList();
            newList = ochartofAccount.GetChartOfAccounts();
            foreach(Classes .ChartOfAccount ocha in newList )
            {
                if(txtAccountCode .Text.ToLower ()==ocha.AccountCode .ToLower ())
                {
                    if(onewChartOfAccount .GLAccountId !=ocha.GLAccountId )
                    { 
                    exist = true;
                    break;
                    }
                }
                if(txtDescription .Text.ToLower ()==ocha.AccountName .ToLower())
                {
                    if (onewChartOfAccount.GLAccountId != ocha.GLAccountId)
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

            
           
            


            
            onewChartOfAccount.AccountCode = txtAccountCode.Text;
            onewChartOfAccount.AccountName = txtDescription.Text;
            onewChartOfAccount.AccountType = cmbAccountType.SelectedItem.ToString();

            int.TryParse(cmbLevel.SelectedItem.ToString(), out level);
            onewChartOfAccount.AccountLevel = level;

            double.TryParse(txtOpeningBalance.Text, out OpeningBalance);
            onewChartOfAccount.OpeningBalance = OpeningBalance;

            
            onewChartOfAccount.Remarks = txtRemarks.Text;

            onewChartOfAccount.IsReconcialable = chkReconciable.Checked;
            onewChartOfAccount.CannotGoToCredit = chkCannotGoToCredit.Checked;
            onewChartOfAccount.CannotGoToDebit = chkCannotGoToDebit.Checked;
            onewChartOfAccount.IsActive = chkIsActive.Checked;
            onewChartOfAccount.SearchName = txtSearchName.Text;

            if (cmbParent.SelectedItem != null)
            {
                onewChartOfAccount.Parent = onewChartOfAccount.GLAccountId;
            }
            //int.TryParse(comboBox3.SelectedItem.ToString(), out parent);
            //if(comboBox3 .SelectedItem !=null)
            //{ 
            //parent = onewChartOfAccount.GLAccountId;
            //onewChartOfAccount.Parent = parent ;
            //}
            ArrayList myList = ochartofAccount.GetChartOfAccounts();
            foreach (Classes.ChartOfAccount ocha in myList)
                if (cmbParent.SelectedItem.ToString() == ocha.AccountName)
                {
                    onewChartOfAccount.Parent = ocha.GLAccountId;
                }

            double.TryParse(txtCurrentBalance.Text, out currentBalance);
            onewChartOfAccount.CurrentBalance = currentBalance;

            onewChartOfAccount.AccountCategory = cmbCategory.SelectedItem.ToString();
            onewChartOfAccount.DebitCreditFlag = cmbDCFlag.SelectedItem.ToString();
            }

            string error = "";
            onewChartOfAccount.GLAccountId = onewChartOfAccount.AddEdit(false, ref error);
            if (err == "")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            }



        

        private void cmbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void cmbAccountType_DropDown(object sender, EventArgs e)
        {
            cmbAccountType.Items.Clear();
            ArrayList myList = new ArrayList();
            myList = ochartofAccount.GetChartOfAccounts();

            foreach (Classes.ChartOfAccount och in myList)
            {
                if (och.Parent == 0) { 
                string item = och.AccountType;

                cmbAccountType.Items.Add(item);
                }

            }


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            loadingInfo = false;
            ClearText();
            txtAccountCode.Focus();
            onewChartOfAccount = null;

        }

        private void ClearText()
        {
            
            txtDescription.Text = "";
            txtAccountCode.Clear();
            txtCurrentBalance.Clear();
            txtOpeningBalance.Clear();
            txtRemarks.Clear();
            cmbAccountType.SelectedIndex = -1;
            cmbCategory.SelectedIndex  = -1;
            cmbParent.SelectedIndex  = -1;
            cmbLevel.SelectedIndex  = -1;
            chkIsActive.Checked = true;
            chkReconciable.Checked = false;
            chkCannotGoToDebit.Checked = false;
            chkCannotGoToCredit.Checked = false;
            cmbDCFlag.SelectedIndex  = -1;
        }

        private void cmbLevel_DropDown(object sender, EventArgs e)
        {
           //ilterCombobox();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewChartOfAccount ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected Item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                string error = "";
                onewChartOfAccount.AddEdit(true, ref error);
                if(error =="")
                {
                    MessageBox.Show("Process suceeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                    
                }
                else
                {
                    MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
                
           

        }

        private void cmbParent_DropDown(object sender, EventArgs e)
        {
            FilterCombobox();
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            if(!loadingInfo )
            txtSearchName.Text = txtDescription.Text;
        }

        private void txtAccountCode_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAccountCode_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Enter )
            {
                bool found = false;
                ArrayList myList = new ArrayList();
                myList = ochartofAccount.GetChartOfAccounts();
                foreach (Classes.ChartOfAccount ocha in myList)
                {
                    if (txtAccountCode.Text == ocha.AccountCode)
                    {
                        onewChartOfAccount = ocha;
                        DisplayInfo();
                        found = true;
                    }
                }
                if(!found)
                {
                    ClearText();
                    MessageBox.Show("Account Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAccountCode.Focus();
                    
                }
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode ==Keys.Enter )
            {
                bool found = false;
                ArrayList myList = new ArrayList();
                myList = ochartofAccount.GetChartOfAccounts();
                foreach (Classes .ChartOfAccount ocha in myList )
                {
                    if(txtDescription .Text.ToLower ()==ocha.AccountName .ToLower ())
                    {
                        onewChartOfAccount = ocha;
                        DisplayInfo();
                        found = true;
                    }
                }
                if(!found)
                {
                    ClearText();
                    MessageBox.Show("Account Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDescription.Focus();
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
                myList = ochartofAccount .GetChartOfAccounts ();

            int counter = 0;

            if (onewChartOfAccount  != null)
            {
                foreach (Classes.ChartOfAccount  ocha in myList)
                {
                    if (ocha.GLAccountId  == onewChartOfAccount .GLAccountId )
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


            onewChartOfAccount  = (Classes.ChartOfAccount )myList[counter];
            DisplayInfo ();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
