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
    public partial class frmSearchACTrasaction : Form
    {
        public frmSearchACTrasaction()
        {
            InitializeComponent();
        }
        Classes.ACTransactions oACtransaction = new Classes.ACTransactions();
        Classes.ACTransactions onewAcTransactions = null;
        public int selInt = 0;
        private void frmSearchACTrasaction_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oACtransaction.GetACTransactions();
            objTransactions.SetObjects(myList);
        }

        private void objTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objTransactions.SelectedObject != null)
                onewAcTransactions = (Classes.ACTransactions)objTransactions.SelectedObject;
            if (onewAcTransactions != null)
                this.selInt = onewAcTransactions.ACTransactionId;
        }

        private void objTransactions_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
