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
    public partial class frmSearchRepaymentPeriod : Form
    {
        public frmSearchRepaymentPeriod()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        ArrayList mylist = new ArrayList();
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
           set { _pickingvalues = value; }
        }

        Classes.RepaymentPeriod oRepaymentPeriod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepaymentPeriod = null;

        private void frmSearchRepaymentPeriod_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadValue();
        }

        private void LoadValue()
        {
            ArrayList myList = new ArrayList();
            objectListView1.Items.Clear();
            myList = oRepaymentPeriod.GetRepaymentPeriods();
            objectListView1.SetObjects(myList);
        }

        private void objectListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView1.SelectedObject != null)
                onewRepaymentPeriod = (Classes.RepaymentPeriod)objectListView1.SelectedObject;
            if (onewRepaymentPeriod != null)
                this.selInt = onewRepaymentPeriod.RepaymentPeriodId;
        }

        private void objectListView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCreatNew_Click(object sender, EventArgs e)
        {
            frmRepaymentPeriods frm = new frmRepaymentPeriods();
            frm.ShowDialog();
            LoadValue();
        }
    }
}
