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
    public partial class frmTransferFunds : Form
    {
        public frmTransferFunds()
        {
            InitializeComponent();
        }
        Classes.MemberShare oMembershare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;
        private int _memberId = 0;
        public  double _transferamount = 0;

        public double TransferAmount
        {
            get { return _transferamount; }
            set { _transferamount = value; }
        }
        public int MemberId
        {
            get { return _memberId; }
            set { _memberId = value; }
        }

        private int _membershareId = 0;
        public int MemberShareId
        {
            get { return _membershareId; }
            set { _membershareId = value; }
        }
        private int _selmembershareId = 0;
        public int SelMemberShareId
        {
            get { return _selmembershareId; }
            set { _selmembershareId = value; }
        }


        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember   frm = new SYSTEMUPGRADEPF.frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember  = oMember .GetMember (frm.selInt);
            if(onewMember !=null)
            {
                txtMemberNo.Text = onewMember.MemberNo;
                txtName.Text = onewMember.MemberName;
                loadMemberAccounts();
            }

        }

        private void loadMemberAccounts()
        {
            ArrayList myList = oMembershare.GetMemberShares();
            ArrayList newList = new ArrayList();
            foreach (Classes.MemberShare omeshare in myList)
            {
                if (onewMember.MemberId == omeshare.MemberId)
                {
                    onewShareType = oShareType.GetShareType(omeshare.ShareTypeId);


                    if (onewShareType.CanBeTransferred)
                    {
                        newList.Add(omeshare);
                    }
                }
            }
            objListMemberAccounts.SetObjects(newList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Visible  = true ;
            btnApply.Visible  = true  ;
        }

        private void frmTransferFunds_Load(object sender, EventArgs e)
        {
            if (MemberId > 0)
            {
                onewMember = oMember.GetMember(MemberId);
                if (onewMember != null)
                {


                    txtName.Text = onewMember.MemberName;
                    txtMemberNo.Text = onewMember.MemberNo;
                    txtMemberNo.Enabled = false;
                    txtName.Enabled = false;
                    btnSearchMember.Enabled = false;

                }
                ArrayList newList = new ArrayList();
                ArrayList myList = oMembershare.GetMemberShares();
                foreach (Classes.MemberShare omemshare in myList)
                {
                    if (onewMember.MemberId == omemshare.MemberId)
                    {
                        if (omemshare.MemberShareId != MemberShareId)
                        {
                            onewShareType = oShareType.GetShareType(omemshare .ShareTypeId);
                            
                            if (onewShareType.CanBeTransferred)
                            {
                                newList.Add(omemshare );
                            }
                           
                        }

                    }
                }


                objListMemberAccounts.SetObjects(newList);
            }
            
        }

        private void chkFromOther_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFromOther .Checked)
            {
                txtMemberNo.Enabled = true;
                txtName.Enabled = true;
                btnSearchMember.Enabled = true;
            }
            else
            {
                txtMemberNo.Enabled = false;
                txtName.Enabled = false;
                btnSearchMember.Enabled = false;
            }
        }

        private void txtMemberNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMemberNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter )
            {
                bool found = false;
                ArrayList MemberList = oMember.GetMembers();
                foreach (Classes.Member omem in MemberList)
                {
                    if (txtMemberNo.Text == omem.MemberNo)
                    {
                        found = true;
                        onewMember = omem;
                        break;
                    }
                }
                if (found)
                {
                    txtMemberNo.Text = onewMember.MemberNo;
                    txtName.Text = onewMember.MemberName;
                    loadMemberAccounts();
                }
            }
        }

        private void objListMemberAccount_CellEditFinished(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (onewMemberShare  == null)
                return;

            if (objListMemberAccounts.SelectedObject != null)
            {
                onewMemberShare = (Classes.MemberShare)objListMemberAccounts.SelectedObject;
            }

            if (onewMemberShare != null)
            {
                if (onewMemberShare.TransferAmmount > onewMemberShare.Balance)
                {
                    MessageBox.Show("Can not Transfer more than what you have", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                this.SelMemberShareId = onewMemberShare.MemberShareId ;
                this.TransferAmount = onewMemberShare.TransferAmmount;
                this.Hide();
            }

        }

        private void objListMemberAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
           if( objListMemberAccounts.SelectedObject !=null)
            {
                onewMemberShare = (Classes.MemberShare)objListMemberAccounts.SelectedObject;
                
            }
        }

        private void objListMemberAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (objListMemberAccounts.SelectedObject != null)
            {
                onewMemberShare = (Classes.MemberShare)objListMemberAccounts.SelectedObject;

            }
        }
    }
}
