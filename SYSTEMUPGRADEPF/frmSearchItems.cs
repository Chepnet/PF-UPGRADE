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
using System.Data.Common;

namespace SYSTEMUPGRADEPF
{
    public partial class frmSearchItems : Form
    {
        public frmSearchItems()
        {
            InitializeComponent();
        }
        Classes.Item oitem = new Classes.Item();
        Classes.Item onewItem = null;
        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }
        public int selInt = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmSearchItems_Load(object sender, EventArgs e)
        {
            loadItems();
            panel1.Visible = this.PickingValues;

        }

        private void loadItems()
        {
            ArrayList myList = oitem.GetItems();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(objList.SelectedObject !=null)
            {
                onewItem = (Classes.Item)objList.SelectedObject;
                if(onewItem !=null)
                {
                    this.selInt = onewItem.ItemId;
                }
            }
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmItem frm = new SYSTEMUPGRADEPF.frmItem();
            frm.ShowDialog();
            loadItems();
        }
    }
}
