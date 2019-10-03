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
    public partial class frmSearchPayment : Form
    {
        public frmSearchPayment()
        {
            InitializeComponent();
        }
        Classes.Payment oPayment = new Classes.Payment();
        Classes.Payment onewPayment = null;
        public int selInt = 0;

        private void frmSearchPayment_Load(object sender, EventArgs e)
        {
            ArrayList myList = oPayment.GetPayments();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
            {
                onewPayment  = (Classes.Payment )objList.SelectedObject;
                if (onewPayment  != null)
                    this.selInt = onewPayment .PaymentId ;

            }
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
