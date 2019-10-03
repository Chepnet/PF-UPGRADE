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
    public partial class frmMemberShares : Form
    {
        public frmMemberShares()
        {
            InitializeComponent();
        }

        Classes.Member oMember = new Classes.Member();
        Classes.Member onewMember = null;
        Classes.Product oProduct = new Classes.Product();
        Classes.Product onewProduct = null;

        Classes.MemberShare oMemberShare = new Classes.MemberShare();
        Classes.MemberShare onewMemberShare = null;
        Classes.MemberDocument omemberDocument = new Classes.MemberDocument();
        Classes.MemberDocument onewMemberDocument = null;
        Classes.ACTransactions oACTransactions = new Classes.ACTransactions();
        Classes.ACTransactions onewACTrsansactions = null;

        Classes.ShareType oShareType = new Classes.ShareType();
        Classes.ShareType onewShareType = null;
      
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearchShareTypes  frm = new SYSTEMUPGRADEPF.frmSearchShareTypes ();
            frm.PickingValues = true;
            frm.SavingProducts  = true;
            frm.ShowDialog();
            onewShareType  = oShareType .GetShareType (frm.selInt);
            if(onewShareType !=null)
            {
                
                txtSharetype.Text = onewShareType .Description ;
                txtDefaultAmount.Text = onewShareType.MinDeposit.ToString ();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewMemberShare ==null)
            {
                MessageBox.Show("Member Account  Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool Linked = false;
            ArrayList myList = oACTransactions.GetACTransactions();
            foreach (Classes.ACTransactions actrans in myList )
            {
                if(onewMemberShare !=null)
                {
                    if(onewMemberShare.MemberShareId ==actrans.MemberShareId )
                    {
                        Linked = true;
                        break;
                    }
                }
            }
            if(Linked )
            {
                MessageBox.Show("Cannot delete Member Share linked to a transaction", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected Item?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                return;
            else
            {
                string error = "";
                onewMemberShare.AddEditMemberShare(true, ref error);
                if(error=="")
                {
                    MessageBox.Show("process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                }

            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            frmSearchMember frm = new SYSTEMUPGRADEPF.frmSearchMember();
            frm.PickingValues = true;
            frm.ShowDialog();
            onewMember = oMember.GetMember(frm.selInt);
            if(onewMember !=null)
            {
                txtMemberName.Text = onewMember.MemberName;
                txtIdNumber.Text = onewMember.IdNumber;
                txtCellNo.Text = onewMember.PhoneNumber;
                txtMemberNo.Text = onewMember.MemberNo;
                onewMemberDocument = omemberDocument.GetMemberDocument(onewMember.MemberId);
                if(onewMemberDocument !=null)
                {
                    pcbphoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
                }

               
                
            }
            
        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter )
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList )
                {
                    if(txtIdNumber.Text .Trim ().ToLower ()==omem.IdNumber  )
                    {
                        txtCellNo .Text = omem.PhoneNumber ;
                        txtMemberName.Text = omem.MemberName;
                        txtMemberNo.Text = omem.MemberNo;
                        memberFound = true;
                        
                    }
                }
                if(!memberFound )
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdNumber.Focus();
                    return;
                }
            }
        }

        private void txtCellNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Enter )
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList )
                {
                    if(txtCellNo.Text ==omem.PhoneNumber )
                    {
                        txtIdNumber.Text = omem.IdNumber;
                        txtMemberName.Text = omem.MemberName;
                        txtMemberNo.Text = omem.MemberNo;
                        memberFound = true;
                        
                    }
                }
                if(!memberFound )
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCellNo .Focus();
                    return;
                }
            }
        }

        private void txtMemberNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool memberFound = false;
                ArrayList myList = new ArrayList();
                myList = oMember.GetMembers();
                foreach (Classes.Member omem in myList)
                {
                    if (txtMemberNo .Text.Trim().ToLower() == omem.MemberNo )
                    {
                        txtIdNumber.Text = omem.IdNumber;
                        txtMemberName.Text = omem.MemberName;
                        txtCellNo .Text = omem.PhoneNumber ;
                        memberFound = true;
                        break;

                    }
                }
                if (!memberFound)
                {
                    MessageBox.Show("Member Not Found", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMemberNo .Focus();
                    return;
                }
            }
        }

        private void txtMemberNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if(onewMember   ==null)
            {
                MessageBox.Show("Member Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMemberName.Focus();
                return;
            }
            if(onewShareType  ==null)
            {
                MessageBox.Show("Share type Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSharetype .Focus();
                return;
            }
            if (txtDefaultAmount.Text.Trim ()=="")
            {
                MessageBox.Show("Default Amount Is Required", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDefaultAmount .Focus();
                return;
            }
            bool Linked = false;
            ArrayList myList = oACTransactions.GetACTransactions();
            foreach (Classes.ACTransactions actrans in myList)
            {
                if (onewMemberShare != null)
                {
                    if (onewMemberShare.MemberShareId == actrans.MemberShareId)
                    {
                        Linked = true;
                        break;
                    }
                }
            }
           
            double minbal = 0;
            
            if (Linked)
            {
                MessageBox.Show("Cannot Edit Member Share linked to a transaction", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (onewMemberShare == null)
                    onewMemberShare = new Classes.MemberShare();

                if (onewMember != null)
                onewMemberShare.MemberId = onewMember.MemberId;
            if (onewShareType  != null)
                onewMemberShare.ShareTypeId = onewShareType .ShareTypeId ;
            onewMemberShare.DefaultAmount = Double.Parse(txtDefaultAmount.Text);
            onewMemberShare.IsActive = ChkIsActive.Checked;

            onewMemberShare.AccountCode = txtAccountCode.Text;
            double.TryParse(txtMinBalance.Text, out minbal);

            onewMemberShare.MinimumBalance = minbal;
            onewMemberShare.HideBalanceOnReceipt = chkHideBalanceReceipt.Checked;
            onewMemberShare.ExemptMobileCharges = chkExemptMobileCharges.Checked;
            string error = "";
            onewMemberShare.MemberShareId = onewMemberShare.AddEditMemberShare(false,ref error);
            if(error =="")
            {
                MessageBox.Show("Process Succeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
            else
            {
                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            }


        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            onewMemberShare = null;
            ClearText();

        }
        private void ClearText()
        {
            txtAccountCode.Text = "";
            txtCellNo.Text = "";
            txtDefaultAmount.Text = "";
            txtIdNumber.Text = "";
            txtMemberName.Text = "";
            txtMemberNo.Text = "";
            txtSharetype.Text = "";
            chkExemptMobileCharges.Checked = false;
            chkHideBalanceReceipt.Checked = false;
            ChkIsActive.Checked = true;
            pcbphoto.Image = null;
            txtMinBalance.Text = "";

        }

        private void toolStripPrevious_Click(object sender, EventArgs e)
        {
            moveToRecord(false);
        }
        private void moveToRecord(bool movingNext)
        {
            ArrayList myList = new ArrayList();

            if (myList.Count == 0)
                myList = oMemberShare .GetMemberShares ();

            int counter = 0;

            if (onewMemberShare  != null)
            {
                foreach (Classes.MemberShare memshar in myList)
                {
                    if (memshar .MemberShareId  == onewMemberShare .MemberShareId )
                    {
                        break;
                    }
                    counter++;
                }
            }
            else
            {
                if (movingNext)
                {
                    counter = -1;
                }
                else
                {
                    counter = myList.Count;
                }
            }

            if (movingNext)
            {
                counter = counter + 1;
            }
            else
            {
                counter = counter - 1;
            }

            if (counter == -1) counter = 0;
            if (counter >= myList.Count) counter = myList.Count - 1;


            onewMemberShare  = (Classes.MemberShare )myList[counter];
            displayInfo();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            frmSearchMemberShares frm = new frmSearchMemberShares();
            frm.ShowDialog();
            onewMemberShare = oMemberShare.GetMemberShare(frm.selInt);
            displayInfo();
        }
        public void displayInfo()
        {
            if(onewMemberShare !=null)
            { 
            txtAccountCode.Text = onewMemberShare.AccountCode;
            //txtCellNo.Text = onewMemberShare.mo;
            txtDefaultAmount.Text = onewMemberShare.DefaultAmount.ToString("###,###.00");
            onewMember = oMember.GetMember(onewMemberShare.MemberId);
            if (onewMember != null)
            {
                txtIdNumber.Text = onewMember.IdNumber;
                txtCellNo.Text = onewMember.PhoneNumber;
                txtMemberNo.Text = onewMember.MemberNo;
                    onewMemberDocument = omemberDocument.GetMemberDocument(onewMember.MemberId);
                    if(onewMemberDocument !=null)
                    {
                        pcbphoto.Image = onewMemberDocument.getMemberPhoto(onewMemberDocument.MemberDocumentId);
                    }
                    txtMemberName.Text = onewMember.MemberName;
            }
            if (onewMember != null)
                txtMemberName.Text = onewMember.MemberName;
            txtMinBalance.Text = onewMemberShare.MinimumBalance.ToString("###,###.00");
            onewShareType  = oShareType .GetShareType (onewMemberShare.ShareTypeId);
            if (onewShareType  != null)
                txtSharetype.Text = onewShareType .Description ;
            chkExemptMobileCharges.Checked = onewMemberShare.ExemptMobileCharges;
            chkHideBalanceReceipt.Checked = onewMemberShare.HideBalanceOnReceipt;
            ChkIsActive.Checked = onewMemberShare.IsActive;
            }
        }

        private void toolStripNext_Click(object sender, EventArgs e)
        {
            moveToRecord(true);
        }

        private void frmMemberShares_Load(object sender, EventArgs e)
        {

        }
    }
}
