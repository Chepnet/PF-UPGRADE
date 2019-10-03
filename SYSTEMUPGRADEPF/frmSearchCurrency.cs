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
    public partial class frmSearchCurrency : Form
    {
        public frmSearchCurrency()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        Classes.Currency oCurrency = new Classes.Currency();
        Classes.Currency onewCurrency = null;
        private  bool _pickingValues = false;
        public bool PickingValues
        {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }
        private void frmSearchCurrency_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            ArrayList myList = new ArrayList();
            myList = oCurrency.GetCurrencies();
            objList.SetObjects(myList);
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewCurrency = (Classes.Currency)objList.SelectedObject;
            if(onewCurrency !=null)
            {
                this.selInt = onewCurrency.CurrencyId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCurrency frm = new SYSTEMUPGRADEPF.frmCurrency();
            frm.ShowDialog();
            LoadCurrencies();
        }
    }
}
