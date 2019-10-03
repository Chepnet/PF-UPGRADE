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
    public partial class frmShareTypeCharge : Form
    {
        public frmShareTypeCharge()
        {
            InitializeComponent();
        }

        Classes.ShareTypeCharge oShareTypeCharge = new Classes.ShareTypeCharge();
        Classes.ShareTypeCharge onewShareTypeCharge = null;

        Classes.ChartOfAccount oChartOfAccount = new Classes.ChartOfAccount();
        Classes.ChartOfAccount onewChartOfAccount = null;

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;

        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;

        private int _sharetypeId = 0;
        public int ShareTypeId { get { return _sharetypeId; }set { _sharetypeId = value; } }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            txtDescription.Focus();
            ClearText();

        }

        private void ClearText()
        {
            onewChartOfAccount = null;
            onewShareTypeCharge = null;
            txtDescription.Text = "";
            txtGLCode.Text = "";
            txtAmount.Text = "";
            txtShareChargeCode.Text = "";
            txtLowerLimit.Text = "";
            txtUpperLimit.Text = "";
            chkDeductedAtImport.Checked = false;
            chkIsPercentageOfTransAmount.Checked = false;
            chkIsActive.Checked = true;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Trim ()=="")
            {
                MessageBox.Show("Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtGLCode .Text.Trim() == "")
            {
                MessageBox.Show("GL Code is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAmount .Text.Trim() == "")
            {
                MessageBox.Show("Amount is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            double amount = 0;
            double Lowerlimit = 0;
            double  UpperLimit = 0;
            if (onewShareTypeCharge == null)
                onewShareTypeCharge = new Classes.ShareTypeCharge();
            onewShareTypeCharge.Description = txtDescription.Text;
            onewShareTypeCharge.ShareCode = txtShareChargeCode.Text;
            double.TryParse(txtAmount.Text, out amount);
            onewShareTypeCharge.Amount = amount;
            double.TryParse(txtLowerLimit.Text, out Lowerlimit);
            onewShareTypeCharge.LowerLimit = Lowerlimit;
            double.TryParse(txtUpperLimit.Text, out UpperLimit);
            onewShareTypeCharge.UpperLimit = UpperLimit;
            onewShareTypeCharge.IsActive = chkIsActive.Checked;
            onewShareTypeCharge.IsPercentageOfTransactionAmount = chkIsPercentageOfTransAmount.Checked;
            onewShareTypeCharge.DeductedAtImportReg = chkDeductedAtImport.Checked;
            onewShareTypeCharge .ChargeTypeId = comboBox1.SelectedIndex;
            if(onewProduct !=null)
            onewShareTypeCharge.ProductId = onewProduct.ProductId;
            if (onewShareType != null)
                onewShareTypeCharge.ShareTypeId = onewShareType.ShareTypeId;
            
            if (onewChartOfAccount != null)
                onewShareTypeCharge.GLCode = onewChartOfAccount.GLAccountId ;
            string err = "";
            onewShareTypeCharge.ShareTypeChargeId = onewShareTypeCharge.AddEditShareCharge(false, ref err);
            if(err=="")
            {
                MessageBox.Show("Process succedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            }
           


        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchShareTypeCharge frm = new frmSearchShareTypeCharge();
            frm.ShowDialog();
            onewShareTypeCharge = oShareTypeCharge.GetShareCharge(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewShareTypeCharge != null)
            {
                txtAmount.Text = onewShareTypeCharge.Amount.ToString();
                txtShareChargeCode.Text = onewShareTypeCharge.ShareCode;
                onewShareType = oShareType.GetShareType(onewShareTypeCharge.ShareTypeId);
                if (onewShareType != null)
                    txtShareTypeId.Text = onewShareType.Description;
                txtLowerLimit.Text = onewShareTypeCharge.LowerLimit.ToString();
                txtUpperLimit.Text = onewShareTypeCharge.UpperLimit.ToString();
                chkDeductedAtImport.Checked = onewShareTypeCharge.DeductedAtImportReg;
                chkIsActive.Checked = onewShareTypeCharge.IsActive;
                chkIsPercentageOfTransAmount.Checked = onewShareTypeCharge.IsPercentageOfTransactionAmount;
                onewProduct = oProduct.GetProduct(onewShareTypeCharge.ProductId);
                if (onewProduct != null)
                    txtProduct.Text = onewProduct.Description;
                onewChartOfAccount = oChartOfAccount.GetChartOfAccount(onewShareTypeCharge.GLCode);
                if (onewChartOfAccount != null)
                    txtGLCode.Text = onewChartOfAccount.AccountName;
            }
        }

        private void btnGLCode_Click(object sender, EventArgs e)
        {
            frmSearchChartOfAccounts frm = new SYSTEMUPGRADEPF.frmSearchChartOfAccounts();
            frm.PostingAccount = true;
            frm.ShowDialog();
            onewChartOfAccount = oChartOfAccount.GetChartOfAccount(frm.sellInt);
            if (onewChartOfAccount != null)
                txtGLCode.Text = onewChartOfAccount.AccountName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new SYSTEMUPGRADEPF.frmSearchProduct();
            frm.IsChargeProduct = true;
            frm.PickingValues = true;
            frm.ShowDialog();
            onewProduct = oProduct.GetProduct(frm.selInt);
            if (onewProduct != null)
                txtProduct.Text = onewProduct.Description;
            txtDescription.Text = txtProduct.Text;
        }

        private void frmShareTypeCharge_Load(object sender, EventArgs e)
        {
            onewShareType = oShareType.GetShareType(ShareTypeId);
            if (onewShareType != null)
                txtShareTypeId.Text = onewShareType.Description;

            comboBox1.SelectedIndex = 0;
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewShareTypeCharge == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewShareTypeCharge.AddEditShareCharge(true, ref err);
                if(err=="")
                {
                    MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    ClearText();
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
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
                myList = oShareTypeCharge .GetShareTypeCharges ();

            int counter = 0;

            if (onewShareTypeCharge  != null)
            {
                foreach (Classes.ShareTypeCharge osharecharge in myList)
                {
                    if (osharecharge .ShareTypeId == onewShareTypeCharge .ShareTypeChargeId )
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


            onewShareTypeCharge  = (Classes.ShareTypeCharge )myList[counter];
            displayInfo();
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtShareChargeCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
