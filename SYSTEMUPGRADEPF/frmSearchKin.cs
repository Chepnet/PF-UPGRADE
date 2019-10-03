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
    public partial class frmSearchKin : Form
    {
        public frmSearchKin()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        ArrayList mylist = new ArrayList();


        Classes.Kin oKin = new Classes.Kin();
        Classes.Kin onewKin = null;
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        private void objListKin_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSearchKin_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadKin();
        }

        private void LoadKin()
        {
            ArrayList mylist = new ArrayList();
            mylist = oKin.GetKins();
            objListKin.Items.Clear();
            objListKin.SetObjects(mylist);
        }

        private void objListKin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListKin.SelectedObject != null)
            {
                onewKin = (Classes.Kin)objListKin.SelectedObject;
                if (onewKin != null)
                    this.selInt = onewKin.KinId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKin frm = new SYSTEMUPGRADEPF.frmKin();
            frm.ShowDialog();
            LoadKin();
        }
    }
}
