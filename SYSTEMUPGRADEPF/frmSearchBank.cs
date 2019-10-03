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
    public partial class frmSearchBank : Form
    {
        public int selInt = 0;

        Classes.Bank oBank = new Classes.Bank();
        Classes.Bank onewBank = null;
        private bool _pickingvalues = false;
        public bool PickingValues { get { return _pickingvalues; }set { _pickingvalues = value; } }

        public frmSearchBank()
        {
            InitializeComponent();
        }

        private void frmSearchBank_Load(object sender, EventArgs e)
        {
            loadBanks();
            panel1.Visible = this.PickingValues;
        }

        private void loadBanks()
        {
            ArrayList myList = new ArrayList();
            myList = oBank.GetBanks();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewBank = (Classes.Bank)objList.SelectedObject;
            if (onewBank != null)
                this.selInt = onewBank.BankId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBank frm = new frmBank();

            frm.ShowDialog();
            loadBanks();
        }
    }
}
