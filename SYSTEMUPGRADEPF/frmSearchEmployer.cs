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
    public partial class frmSearchEmployer : Form
    {
        Classes.Employer oEmployer = new Classes.Employer();
        Classes.Employer onewEmployer = null;

        Classes.Caption oCaption = new Classes.Caption();
        Classes.Caption onewCaption = null;

        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        public int selInt = 0;

        public frmSearchEmployer()
        {
            InitializeComponent();
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList .SelectedObject  != null)
                onewEmployer = (Classes.Employer)objList.SelectedObject;
            if (onewEmployer != null)
                this.selInt = onewEmployer.EmployerId;
        }

        private void frmSearchEmployer_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadEmployers();
            ReadCaption();



        }

        private void LoadEmployers()
        {
            ArrayList myList = new ArrayList();
            myList = oEmployer.GetEmployers();
            objList.SetObjects(myList);
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes.Caption ocap in myList )
            {
                switch (ocap.DefaultCaptionName)
                {
                    case "Employer":
                        string str = ocap.CaptionName;
                        string newname = str.Replace(":", string.Empty);
                        this.Text ="Search " + newname;
                        olvColumn1.Text = newname + " Code";
                        olvColumn2.Text = newname + " Name";
                        olvColumn7.Text = newname + " Email ";
                        olvColumn5.Text = newname + " Cell No" ;
                        olvColumn8.Text = newname + " Address";

                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployer frm = new SYSTEMUPGRADEPF.frmEmployer();

            frm.ShowDialog();
            LoadEmployers();

        }
    }
}
