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
    public partial class frmSearchOtherCharges : Form
    {
        public frmSearchOtherCharges()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        Classes.OtherCharge oOtherCharges = new Classes.OtherCharge();
        Classes.OtherCharge onewOthercharge = null;
        

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewOthercharge = (Classes.OtherCharge)objList.SelectedObject;
            if (onewOthercharge != null)
                this.selInt = onewOthercharge.ChargeId;
        }

        private void frmSearchOtherCharges_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
                           
            myList = oOtherCharges.GetOtherCharges();
            objList.SetObjects(myList);
        }
    }
}
