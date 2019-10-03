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
    public partial class frmSearchLoanCollateralImages : Form
    {
        public frmSearchLoanCollateralImages()
        {
            InitializeComponent();
        }
        private bool _pickingValues = false;
        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }
        private int _loanApplicationcollateralimageId = 0;
        public int LoanCollateralImageId
        {
            get { return _loanApplicationcollateralimageId; }
            set { _loanApplicationcollateralimageId = value; }
        }

        Classes.LoanCollateralImage oLoanCollateralImage = new Classes.LoanCollateralImage();
        Classes.LoanCollateralImage onewLoanCollateralImage = null;

        public int selInt = 0;

        private void frmSearchLoanCollateralImages_Load(object sender, EventArgs e)
        {
            loadValues();

        }

        private void loadValues()
        {
            ArrayList myList = new ArrayList();
            ArrayList newList = new ArrayList();

            myList = oLoanCollateralImage.GetLoanCollateralImages();
            foreach (Classes.LoanCollateralImage ocoimage in myList  )
            {
                if(LoanCollateralImageId   ==ocoimage.LoanCollateralImageId )
                {
                    newList.Add(ocoimage);
                }
            }
            objListImages.SetObjects(newList );
            panel1.Visible = this.PickingValues;
        }

        private void objListImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListImages.SelectedObject != null)
                onewLoanCollateralImage = (Classes.LoanCollateralImage)objListImages.SelectedObject;
            if (onewLoanCollateralImage != null)
                this.selInt = onewLoanCollateralImage.LoanCollateralImageId;
        }

        private void objListImages_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoanApplicationCollateralImages  frm = new SYSTEMUPGRADEPF.frmLoanApplicationCollateralImages ();
            frm.ShowDialog();
            loadValues();
        }
    }
}
