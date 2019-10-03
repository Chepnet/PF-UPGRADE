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
    public partial class frmLoanApplicationCollateralImages : Form
    {
        public frmLoanApplicationCollateralImages()
        {
            InitializeComponent();
        }
        Classes.LoanApplicationCollateral oLoanApplicationCollateral = new Classes.LoanApplicationCollateral();
        Classes.LoanApplicationCollateral onewLoanApplicationCollateral = null;

        Classes.LoanCollateralImage oLoanCollateralImage = new Classes.LoanCollateralImage();
        Classes.LoanCollateralImage onewLoanCollateralImage = null;

        private int _loanCollateralImageId = 0;
        public int LoanCollateralImageId { get { return _loanCollateralImageId; } set { _loanCollateralImageId = value; } }


        private void ptbImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Image files | *.jpg";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = openFileDialog1.FileName;
                    ptbImage.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

            if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Image Description is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (onewLoanCollateralImage == null)
                onewLoanCollateralImage = new Classes.LoanCollateralImage();
            if (onewLoanApplicationCollateral != null)
                onewLoanCollateralImage.LoanApplicationCollateralId = onewLoanApplicationCollateral.LoanApplicationCollateralId;
            onewLoanCollateralImage.Description = txtDescription.Text;
            onewLoanCollateralImage.IsActive = chkIsActive.Checked;
            string err = "";
            onewLoanCollateralImage.LoanCollateralImageId = onewLoanCollateralImage.AddEditCollateralsImage(false, ref err);
            if (err == "")
            {
                if (ptbImage.Image != null)
                    onewLoanCollateralImage.saveLoanCollateralDoc(ptbImage.Image);
                MessageBox.Show("Process succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmLoanApplicationCollateralImages_Load(object sender, EventArgs e)
        {

            onewLoanApplicationCollateral = oLoanApplicationCollateral.GetLoanApplicationCollateral(LoanCollateralImageId);
            if (this.LoanCollateralImageId != 0)
            {

                txtLoanApplicationCollateral.Text = onewLoanApplicationCollateral.CollateralName;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {

            txtDescription.Focus();
            ClearTexts();

        }

        private void ClearTexts()
        {
            onewLoanCollateralImage = null;
            ptbImage.Image = null;
            txtDescription.Text = "";
            chkIsActive.Checked = true;
        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {

            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();
            //  objListDocuments.Items.Clear();
            if (myList.Count == 0)
                myList = oLoanCollateralImage.GetLoanCollateralImages();
            // mylist = oMemberDocument.GetMemberDocuments();

            foreach (Classes.LoanCollateralImage omedec in myList)
            {


                if (onewLoanCollateralImage.LoanApplicationCollateralId == omedec.LoanApplicationCollateralId)


                {
                    newList.Add(omedec);
                }


            }

            int counter = 0;

            if (onewLoanCollateralImage != null)
            {
                foreach (Classes.LoanCollateralImage omemdoc in newList)
                {
                    if (omemdoc.LoanApplicationCollateralId == onewLoanCollateralImage.LoanApplicationCollateralId)
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
                    counter = newList.Count;
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
            if (counter >= newList.Count) counter = newList.Count - 1;


            onewLoanCollateralImage = (Classes.LoanCollateralImage)newList[counter];
            displayInfo();


        }


        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchLoanCollateralImages frm = new SYSTEMUPGRADEPF.frmSearchLoanCollateralImages();
            frm.LoanCollateralImageId = onewLoanApplicationCollateral.LoanApplicationCollateralId;
            frm.ShowDialog();
            onewLoanCollateralImage = oLoanCollateralImage.GetLoanCollateralImage(frm.selInt);
            displayInfo();
        }

        private void displayInfo()
        {
            if (onewLoanCollateralImage != null)
            {
                txtDescription.Text = onewLoanCollateralImage.Description;
                chkIsActive.Checked = onewLoanCollateralImage.IsActive;
                onewLoanApplicationCollateral = oLoanApplicationCollateral.GetLoanApplicationCollateral(onewLoanCollateralImage.LoanApplicationCollateralId);
                if (onewLoanApplicationCollateral != null)

                    txtLoanApplicationCollateral.Text = onewLoanApplicationCollateral.CollateralName;
                ptbImage.Image = onewLoanCollateralImage.getLoanCollateralPhoto(onewLoanCollateralImage.LoanCollateralImageId);
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (onewLoanCollateralImage == null)
            {
                MessageBox.Show("Item to delete is required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string err = "";
                onewLoanCollateralImage.AddEditCollateralsImage(true, ref err);
                if (err == "")
                {
                    MessageBox.Show("Process sucedded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTexts();
                }
                else
                {
                    MessageBox.Show(err, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}

