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
    public partial class frmSearchMemberApplicationDocument : Form
    {

        private int _memberApplicationId = 0;
        public int MemberApplicationId { get { return _memberApplicationId; } set { _memberApplicationId = value; } }
        public frmSearchMemberApplicationDocument()
        {
            InitializeComponent();
        }
        Classes.MemberApplicationDocument oMemberApplicationDocument = new Classes.MemberApplicationDocument();
        Classes.MemberApplicationDocument onewMemberApplicationDocument = null;
        public int selInt = 0;

        private void frmSearchMemberApplicationDocument_Load(object sender, EventArgs e)
        {
            LoadValues();
        }
        private void LoadValues()
        {
            ArrayList mylist = new ArrayList();
            ArrayList newList = new ArrayList();
            objList.Items.Clear();
            mylist = oMemberApplicationDocument.GetMemberApplicationDocuments();

            if (this.MemberApplicationId == 0)
            {

                objList.SetObjects(mylist);
            }
            else
            {

                foreach (Classes.MemberApplicationDocument omedec in mylist)
                {

                    if (this.MemberApplicationId == omedec.MemberApplicationId)

                    {
                        newList.Add(omedec);
                    }


                }

                objList.SetObjects(newList);

            }
        }

        private void objList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objList.SelectedObject != null)
                onewMemberApplicationDocument = (Classes.MemberApplicationDocument)objList.SelectedObject;
            if (onewMemberApplicationDocument != null)
                this.selInt = onewMemberApplicationDocument.MemberApplicationDocumentId;
        }

        private void objList_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
