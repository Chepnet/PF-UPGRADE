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
    public partial class frmSearchFixedDeposit : Form
    {
        public frmSearchFixedDeposit()
        {
            InitializeComponent();
        }
        Classes.FixedDeposit oFixedDeposit = new Classes.FixedDeposit();
        Classes.FixedDeposit onewFixedDeposit = null;
        public int selInt = 0;
        public bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        private void frmSearchFixedDeposit_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oFixedDeposit.GetFixedDeposits();
            objListFixedDeposit.SetObjects(myList);
            panel1.Visible = this.PickingValues;

        }

        private void objListFixedDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListFixedDeposit.SelectedObject != null)

                onewFixedDeposit = (Classes.FixedDeposit)objListFixedDeposit.SelectedObject;
            if(onewFixedDeposit !=null)
            {
                this.selInt = onewFixedDeposit.FixedDepositId;
            }
    }

        private void objListFixedDeposit_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
