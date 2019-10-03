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
    public partial class frmSearchAssetTransaction : Form
    {
        public frmSearchAssetTransaction()
        {
            InitializeComponent();
        }
        Classes.AssetTransaction oAssetTransaction = new Classes.AssetTransaction();
        Classes.AssetTransaction onewAssetTransaction = null;
        public int selInt = 0;
        

        private void frmSearchAssetTransaction_Load(object sender, EventArgs e)
        {
            ArrayList myList = oAssetTransaction.GetAssetTransactions();
            objList.SetObjects(myList);

        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewAssetTransaction = (Classes.AssetTransaction)objList.SelectedObject;
            if (onewAssetTransaction != null)
                this.selInt = onewAssetTransaction.AssetTransactionId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
