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
    public partial class frmSearchModeOfPayment : Form
    {
        public frmSearchModeOfPayment()
        {
            InitializeComponent();
        }
        Classes.ModeOfPayment oModeOfPayment = new Classes.ModeOfPayment();
        Classes.ModeOfPayment onewModeOfPayment=null;
        public int selInt = 0;
        public bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        private void frmSearchModeOfPayment_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            loadModeOfPayment();
        }

        private void loadModeOfPayment()
        {
            ArrayList myList = new ArrayList();
            myList = oModeOfPayment.GetModeOfPayments();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewModeOfPayment = (Classes.ModeOfPayment)objList.SelectedObject;
            if (onewModeOfPayment != null)
                this.selInt = onewModeOfPayment.ModeOfPaymentId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmModeOfPayment frm = new SYSTEMUPGRADEPF.frmModeOfPayment();
            frm.ShowDialog();
            loadModeOfPayment();
        }
    }
}
