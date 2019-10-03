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
    public partial class frmSearchSetupRule : Form
    {
        Classes.SetupRule oSetupRule = new Classes.SetupRule();
        Classes.SetupRule onewSetupRule = null;
        public int selInt = 0;

        public frmSearchSetupRule()
        {
            InitializeComponent();
        }

        private void frmSearchSetupRule_Load(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();
            myList = oSetupRule.GetSetupRules();
            objList.SetObjects(myList);
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewSetupRule = (Classes.SetupRule)objList.SelectedObject;
            if (onewSetupRule != null)
                this.selInt = onewSetupRule.FieldId;
        }
    }
}
