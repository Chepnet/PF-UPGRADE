using System;
using System.Windows.Forms;
using System.Collections;
namespace SYSTEMUPGRADEPF
{
    public partial class frmSearchCustomers : Form
    {
        public frmSearchCustomers()
        {
            InitializeComponent();
        }
        Classes.Customer oCustomer = new Classes.Customer();
        Classes.Customer onewCustomer = null;
        public int selInt = 0;
        public bool _pickingValues = false;
        public bool PickingValues {
            get { return _pickingValues; }
            set { _pickingValues = value; }
        }
        private void frmSearchCustomers_Load(object sender, EventArgs e)
        {
            loadCustomers();
            panel1.Visible = this.PickingValues ;
        }

        private void loadCustomers()
        {
            ArrayList myList = new ArrayList();
           myList = oCustomer.GetCustomers();
            objListCustomers.SetObjects(myList);
        }

        private void objListCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objListCustomers.SelectedObject != null)
                onewCustomer = (Classes.Customer)objListCustomers.SelectedObject;
            if(onewCustomer !=null)
            {
                this.selInt = onewCustomer.CustomerId;
            }
        }

        private void objListCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPickingValues_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new SYSTEMUPGRADEPF.frmCustomer();
            frm.ShowDialog();
            loadCustomers();
        }
    }
}
