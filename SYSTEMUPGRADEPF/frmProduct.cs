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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;
       


        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void ClearText()
        {
            txtDescription.Text = "";
            cmbProductType.SelectedIndex = -1;
            chkIsActive.Checked = true;
        }

        private void toolStripBtnNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchProduct frm = new SYSTEMUPGRADEPF.frmSearchProduct();
            frm.ShowDialog();
            onewProduct = oProduct.GetProduct(frm.selInt);
            displayInfo();

        }

        private void displayInfo()
        {
            if (onewProduct != null)
            {
                txtDescription.Text = onewProduct.Description;
                chkIsActive.Checked = onewProduct.IsActive;
                cmbProductType.SelectedIndex = onewProduct.ProductType;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Trim()=="")
            {
                MessageBox.Show("Description required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            if (cmbProductType.SelectedIndex ==-1)
            {
                MessageBox.Show("Product Type is  required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               cmbProductType.Focus();
                return;
            }
            if (onewProduct == null)
                onewProduct = new Classes.Product();
            bool exist = false;
            ArrayList myList = new ArrayList();
            myList = oProduct.GetProducts();
            foreach(Classes.Product opro in myList )
            {
                if(txtDescription.Text.Trim().ToLower ()==opro.Description.Trim().ToLower())
                {
                    if(onewProduct.ProductId!=opro.ProductId)
                    {
                        exist = true;
                        break;
                    }
                }
            }
            if(exist)
            {
                MessageBox.Show("This will cause a duplicate entry", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDescription.Focus();
                return;
            }
            else
            {

            
            onewProduct.Description = txtDescription.Text;
            onewProduct.ProductType = cmbProductType.SelectedIndex;
            onewProduct.IsActive = chkIsActive.Checked;
            }
            string err = "";
            onewProduct.ProductId = onewProduct.AddEditProduct(false, ref err);
            if(err=="")
            {
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                

            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oProduct .GetProducts ();

            int counter = 0;

            if (onewProduct  != null)
            {
                foreach (Classes.Product  ocha in myList)
                {
                    if (ocha.ProductId  == onewProduct .ProductId )
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


            onewProduct  = (Classes.Product )myList[counter];
            displayInfo();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
           

            if (onewProduct ==null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewProduct.AddEditProduct(true, ref error);
                if(error=="")
                {
                    MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
                    ClearText();
                   
                }
                else
                {
                    MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                }
            }
        }
    }
}
