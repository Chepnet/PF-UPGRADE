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
    public partial class frmSearchBen : Form
    {
        public frmSearchBen()
        {
            InitializeComponent();
        }

        public int selInt = 0;
        ArrayList mylist = new ArrayList();


        Classes.Ben oBen = new Classes.Ben();
        Classes.Ben onewBen = null;

        private void frmSearchBen_Load(object sender, EventArgs e)
        {
            ArrayList mylist = new ArrayList();
            mylist = oBen.GetBens();
            objListBen.SetObjects(mylist);
        }

        private void objListBen_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objListBen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListBen.SelectedObject != null)
            {
                onewBen = (Classes.Ben)objListBen.SelectedObject;
                if (onewBen != null)
                    this.selInt = onewBen.BenId;
            }
        }
    }
}
