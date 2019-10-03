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
    public partial class frmSearchStation : Form
    {
        Classes.Station oStation = new Classes.Station();
        Classes.Station onewStation = null;
        Classes.Caption oCaption = new Classes.Caption();

        private bool _pickingvalues = false;
        public bool PickingValues
        {
            get { return _pickingvalues; }
            set { _pickingvalues = value; }
        }

        public int selInt = 0;

        public frmSearchStation()
        {
            InitializeComponent();
        }

        private void frmSearchStation_Load(object sender, EventArgs e)
        {
            panel1.Visible = this.PickingValues;
            LoadStations();
            ReadCaption();
        }

        private void LoadStations()
        {
            ArrayList myList = new ArrayList();
            objList.Items.Clear();
            myList = oStation.GetStations();
            objList.SetObjects(myList);
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewStation = (Classes.Station)objList.SelectedObject;
            if (onewStation != null)
                this.selInt = onewStation.StationId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ReadCaption()
        {
            ArrayList myList = oCaption.GetCaptions();
            foreach (Classes .Caption ocap in myList )
            {
                switch (ocap.DefaultCaptionName)
                    {

                    case "Station":
                        string str = ocap.CaptionName;
                        string newname = str.Replace(":", string.Empty);

                        this.Text = "Search " +newname;
                       //changing the aspect name to read as per the changed captions
                        olvColumn1.Text = newname  +" Code";
                        olvColumn2.Text = newname + " Name";
                        olvColumn4.Text = newname + " Address";
                        break;
                    case "Employer":
                        string str1 = ocap.CaptionName;
                        string newempl = str1.Replace(":", string.Empty);
                        this.Text =newempl  ;
                        olvColumn3.Text = newempl  + " Name";
                        
                        break;
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmStation frm = new frmStation();
            frm.ShowDialog();
            LoadStations();
        }
    }
}
