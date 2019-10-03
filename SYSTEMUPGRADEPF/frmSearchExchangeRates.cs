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
    public partial class frmSearchExchangeRates : Form
    {
        public frmSearchExchangeRates()
        {
            InitializeComponent();
        }
        Classes.ExchangeRate oExchangeRate = new Classes.ExchangeRate();
        Classes.ExchangeRate onewExchangeRate = null;
        public int selInt = 0;
        private bool _pickingValues = false;
        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }

        private void frmSearchExchangeRates_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            loadExchangeRates();

        }

        private void loadExchangeRates()
        {
            ArrayList myList = new ArrayList();
            myList = oExchangeRate.GetExchangeRates();
            objList.SetObjects(myList);
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList.SelectedObject !=null)
            {
                onewExchangeRate = (Classes.ExchangeRate)objList.SelectedObject;
                if(onewExchangeRate !=null)
                {
                    this.selInt = onewExchangeRate.ExchangeRateId;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExchangeRate frm = new frmExchangeRate();
            frm.ShowDialog();
            loadExchangeRates();
        }
    }
}
