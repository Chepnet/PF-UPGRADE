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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        Classes.Customer oCustomer = new Classes.Customer();
        Classes.Customer onewCustomer = null;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency odefCurrency = null;
        Classes.Currency otrxCurrency = null;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadCurrencies();
           
        }
        private void loadCurrencies()
        {
            cmbCurrency.Items.Clear();
            int defIndex = 0, counter = 0;
            ArrayList myList = oCurrency.GetCurrencies();
            foreach (Classes.Currency ocurr in myList)
            {
                cmbCurrency.Items.Add(new Classes.ItemData.itemData(ocurr.Code, ocurr));
                if (ocurr.IsDefaultCurrency)
                {
                    odefCurrency = ocurr;
                    defIndex = counter;
                }
                counter++;
            }
            cmbCurrency.SelectedIndex = defIndex;
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewCustomer = null;
            txtCustomerNo.Focus();
            ClearTexts();

        }

        private void ClearTexts()
        {
            txtCustomerNo.Text = "";
            txtCustomerName.Text = "";
            txtMobileNumber.Text = "";
            txtHomePage.Text = "";
            txtEmail.Text = "";
            txtPostalAddress.Text = "";
            txtSalesPerson.Text = "";
            txtTel2.Text = "";
            txtTelephone1.Text = "";
            txtCounty.Text = "";
            txtCity.Text = "";
            chkIsActive.Checked = true;
            chkIsVendor.Checked = false;
            txtContactPerson.Text = "";
            txtPostalCode.Text = "";
            txtAddress1.Text = "";
            cmbCurrency.SelectedIndex = odefCurrency.CurrencyId;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtCustomerNo.Text .Trim ()=="")
            {
                MessageBox.Show("Customer number is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerNo.Focus();
                return;
            }
            if (txtCustomerName .Text.Trim() == "")
            {
                MessageBox.Show("Customer Name is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCustomerName .Focus();
                return;
            }
            if (txtEmail .Text.Trim() == "")
            {
                MessageBox.Show("Eamil Address is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail .Focus();
                return;
            }
            if (txtSalesPerson .Text.Trim() == "")
            {
                MessageBox.Show("Sales person  is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSalesPerson .Focus();
                return;
            }
            if (onewCustomer == null)
                onewCustomer = new Classes.Customer();
            onewCustomer.CustomerNo = txtCustomerNo.Text;
            onewCustomer.CustomerName = txtCustomerName.Text;
            onewCustomer.Email = txtEmail.Text;
            onewCustomer.ContactPersonName = txtContactPerson.Text;
            onewCustomer.Address = txtAddress1.Text;
            onewCustomer.Address2 = txtPostalAddress.Text;
            onewCustomer.IsActive = chkIsActive.Checked;
            onewCustomer.IsVendor = chkIsVendor.Checked;
            onewCustomer.PostalCode = txtPostalCode.Text;
            onewCustomer.Telephone2 = txtTel2.Text;
            onewCustomer.Telephone1 = txtTelephone1.Text;
            onewCustomer.SalesPersonId = int.Parse(txtSalesPerson.Text);
            onewCustomer.MobileNo = txtMobileNumber.Text;
            onewCustomer.HomePage = txtHomePage.Text;
            onewCustomer.City = txtCity.Text;
            onewCustomer.County = txtCounty.Text;
            onewCustomer.DefaultCurrencyId = cmbCurrency.SelectedIndex;
            string error = "";
            onewCustomer.CustomerId = onewCustomer.AddEditCustomer(false, ref error);
            if(error=="")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

            }

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewCustomer ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;

            }
            DialogResult result= MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo , MessageBoxIcon.Question ,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewCustomer.AddEditCustomer(true, ref err);
                if(err=="")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(err , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );

                }
            }

        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchCustomers frm = new SYSTEMUPGRADEPF.frmSearchCustomers();
            frm.ShowDialog();
            onewCustomer = oCustomer.GetCustomer(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewCustomer != null)
            {
                txtCustomerNo.Text = onewCustomer.CustomerNo;
                txtCustomerName.Text = onewCustomer.CustomerName;
                txtEmail.Text = onewCustomer.Email;
                txtHomePage.Text = onewCustomer.HomePage;
                txtMobileNumber.Text = onewCustomer.MobileNo;
                txtPostalAddress.Text = onewCustomer.Address ;
                txtPostalCode.Text = onewCustomer.PostalCode;
                txtSalesPerson.Text = onewCustomer.SalesPersonId.ToString();
                txtTel2.Text = onewCustomer.Telephone2;
                txtTelephone1.Text = onewCustomer.Telephone1;
                txtCounty.Text = onewCustomer.County;
                txtCity.Text = onewCustomer.City;
                chkIsActive.Checked = onewCustomer.IsActive;
                chkIsVendor.Checked = onewCustomer.IsVendor;
                txtContactPerson.Text = onewCustomer.ContactPersonName;
                cmbCurrency.SelectedIndex = onewCustomer.DefaultCurrencyId;
                txtAddress1.Text = onewCustomer.Address2 ;

            }
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oCustomer .GetCustomers ();

            int counter = 0;

            if (onewCustomer  != null)
            {
                foreach (Classes.Customer  cust in myList)
                {
                    if (cust .CustomerId  == onewCustomer .CustomerId )
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


            onewCustomer  = (Classes.Customer )myList[counter];
            displayInfo();
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void cmbCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            otrxCurrency = null;
            if (cmbCurrency.Items.Count <= 0) return;
            if (cmbCurrency.SelectedIndex < 0) return;

            object obj = ((Classes.ItemData.itemData)(cmbCurrency.SelectedItem))._itemData;
            Classes.Currency myCurrency = (Classes.Currency)obj;
            if (myCurrency != null)
            {
                otrxCurrency = myCurrency;
            }
        }
    }
}
