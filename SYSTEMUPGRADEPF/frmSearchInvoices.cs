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
    public partial class frmSearchInvoices : Form
    {
        public frmSearchInvoices()
        {
            InitializeComponent();
        }
        Classes.Invoice oInvoice = new Classes.Invoice();
        Classes.Invoice onewInvoices = null;
        public int selInt = 0;
        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
            {
                onewInvoices = (Classes.Invoice)objList.SelectedObject;
                if (onewInvoices != null)
                    this.selInt = onewInvoices.InvoiceId;

            }
        }

        private void frmSearchInvoices_Load(object sender, EventArgs e)
        {
            ArrayList myList = oInvoice .GetInvoices();
            objList.SetObjects(myList );
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
