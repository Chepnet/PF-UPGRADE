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
using BrightIdeasSoftware;
using System.Xml;
using System.Xml.Linq;

namespace SYSTEMUPGRADEPF
{
    public partial class frmSearchShareTypeCharge : Form
    {
        public frmSearchShareTypeCharge()
        {
            InitializeComponent();
        }
        public int selInt = 0;
        Classes.ShareTypeCharge oShareCharge = new Classes.ShareTypeCharge();
        Classes.ShareTypeCharge onewShareCharge = null;

        public double amount = 0;
        public string xmlChargeIds = "";
        public string xmlAmounts = "";
        

        private void frmSearchShareCharge_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oShareCharge.GetShareTypeCharges();
            objList.SetObjects(myList);

        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewShareCharge = (Classes.ShareTypeCharge )objList .SelectedObject ;
            if (onewShareCharge != null)
                this.selInt = onewShareCharge.ShareTypeChargeId;

        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {

            int totalCount = 0;
            totalCount = objList.CheckedItems.Count;

            string[] valuesId = new string[totalCount];
            string[] valuesAmt = new string[totalCount];
     
            int cntr = 0;

           


            for (int i = 0; i < objList.Items.Count; i++)
            {

                Classes.ShareTypeCharge oshatycharge = (Classes.ShareTypeCharge)objList.GetModelObject(i);
                if (objList.Items[i].Checked)
                {

                    valuesId[cntr] = oshatycharge.ShareTypeChargeId .ToString ();
                    valuesAmt[cntr] = oshatycharge.Amount.ToString();
                   
                    cntr++;
                    amount = amount + oshatycharge.Amount;


                                   }
                
            }
            xmlChargeIds = GlobalVariable.BuildXmlString("ValueId", valuesId);
            xmlAmounts  = GlobalVariable.BuildXmlString("Amount", valuesAmt);
            
            this.Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (OLVListItem olv in  objList.Items)
            {

                olv.Checked = chkAll.Checked ;
                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oShareCharge.GetShareTypeChargexml ();
            DataSet ds = new DataSet();
            ds.WriteXml("Commision.xml");
            MessageBox.Show("process suceded");
           
        }
    }
}
