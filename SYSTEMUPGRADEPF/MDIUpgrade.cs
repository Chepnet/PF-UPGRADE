using System;
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
    public partial class MDIUpgrade : Form
    {
        private int childFormNumber = 0;

        public MDIUpgrade()
        {
            InitializeComponent();
        }

        public static string MachineName { get; }
        public static string DatabaseName { get; }
        private void ShowNewForm(object sender, EventArgs e)
        {
            
        }

        private void OpenFile(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank frm = new frmBank();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        
       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIUpgrade_Load(object sender, EventArgs e)
        {
            this.Text = this.Text +  Environment.MachineName+"  " + "The Current Date:  " +  DateTime.Now.ToString("yyyy MMM dd");
            toolStripStatusLabel.Text = "Login Name: " + "   Machine Name: " + Environment.MachineName + "   Login Time: " + DateTime.Now;
        }

        private void memberApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberApplication frm = new SYSTEMUPGRADEPF.frmMemberApplication();
            frm.MdiParent = this;
            frm.ShowDialog();
        }

        private void employerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void setupRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientClassificaionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void relationShipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void documentTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolsMenu_Click(object sender, EventArgs e)
        {

        }

        

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMember frm = new frmMember();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompulsoryField frm = new SYSTEMUPGRADEPF.frmCompulsoryField();
            frm.MdiParent = this;
            frm.Show();

        }

        private void kinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKin frm = new SYSTEMUPGRADEPF.frmKin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void benToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBen frm = new SYSTEMUPGRADEPF.frmBen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kinDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKinDocument frm = new frmKinDocument();
            frm.MdiParent = this;
            frm.Show();
        }

        private void memberDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberDocument frm = new SYSTEMUPGRADEPF.frmMemberDocument();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void memberToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kinToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void beneficiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void memberDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void kinDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void compusoryFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void setupRulesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSetupRule frm = new SYSTEMUPGRADEPF.frmSetupRule();
            frm.MdiParent = this;
            frm.Show();
        }

        private void compulsoryFieldsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompulsoryField frm = new SYSTEMUPGRADEPF.frmCompulsoryField();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kinDocumentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            frmKinDocument frm = new SYSTEMUPGRADEPF.frmKinDocument();
            frm.MdiParent = this;
            frm.Show();
        }

        private void memberDocumentToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            frmMemberDocument frm = new SYSTEMUPGRADEPF.frmMemberDocument();
            frm.MdiParent = this;
            frm.Show();
        }

        private void stationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStation frm = new SYSTEMUPGRADEPF.frmStation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employerToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmEmployer frm = new SYSTEMUPGRADEPF.frmEmployer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientClassification frm = new SYSTEMUPGRADEPF.frmClientClassification();
            frm.MdiParent = this;
            frm.Show();
        }

        private void relationshipToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelationship frm = new SYSTEMUPGRADEPF.frmRelationship();
            frm.MdiParent = this;
            frm.Show();
        }

        private void memberApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMemberApplication frm = new SYSTEMUPGRADEPF.frmMemberApplication();
            frm.MdiParent = this;
            frm.Show();
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void beneficiaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBen frm = new SYSTEMUPGRADEPF.frmBen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kinToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmKin frm = new SYSTEMUPGRADEPF.frmKin();
            frm.MdiParent = this;
            frm.Show();
        }

        private void documentTypeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmDocumentType frm = new SYSTEMUPGRADEPF.frmDocumentType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void captionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tezttezToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void groupedOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupedOption frm = new SYSTEMUPGRADEPF.frmGroupedOption();
            frm.Show();
        }

        private void prefixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrefix frm = new SYSTEMUPGRADEPF.frmPrefix();
            frm.Show();
        }

        private void memberToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMember frm = new SYSTEMUPGRADEPF.frmMember();
            frm.MdiParent = this;
            frm.Show();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMembersReport  frm = new frmMembersReport ();
            frm.MdiParent = this;
            frm.Show();

        }

        private void memeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void memberDocumentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void captionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCaption frm = new SYSTEMUPGRADEPF.frmCaption();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prefixToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrefix frm = new SYSTEMUPGRADEPF.frmPrefix();
            frm.MdiParent = this;
            frm.Show();
        }

        private void moreOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupedOption frm = new frmGroupedOption();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChartsOfAccounts frm = new SYSTEMUPGRADEPF.frmChartsOfAccounts();
            frm.MdiParent = this;
            frm.Show();
        }

        private void journalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJournal frm = new SYSTEMUPGRADEPF.frmJournal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank frm = new frmBank();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modeOfPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModeOfPayment frm = new frmModeOfPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void journalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmJournal frm = new frmJournal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void memberKinToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loanTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanTypes frm = new SYSTEMUPGRADEPF.frmLoanTypes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void repaymentPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepaymentPeriods frm = new SYSTEMUPGRADEPF.frmRepaymentPeriods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanCategory frm = new SYSTEMUPGRADEPF.frmLoanCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void repaymentPeriodToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRepaymentPeriods frm = new SYSTEMUPGRADEPF.frmRepaymentPeriods();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoanTypes frm = new SYSTEMUPGRADEPF.frmLoanTypes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new SYSTEMUPGRADEPF.frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chargesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherCharge frm = new SYSTEMUPGRADEPF.frmOtherCharge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void collateralsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollaterals frm = new SYSTEMUPGRADEPF.frmCollaterals();
            frm.MdiParent = this;
            frm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void shareChargesCommisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShareTypeCharge frm = new SYSTEMUPGRADEPF.frmShareTypeCharge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fixedDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShareType frm = new SYSTEMUPGRADEPF.frmShareType();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberShares frm = new SYSTEMUPGRADEPF.frmMemberShares();
            frm.MdiParent = this;
            frm.Show();
        }

        private void memberApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMemberApplication frm = new frmMemberApplication();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanApplication frm = new SYSTEMUPGRADEPF.frmLoanApplication();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanPurposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanPurpose frm = new SYSTEMUPGRADEPF.frmLoanPurpose();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanTypesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLoanTypes frm = new frmLoanTypes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new SYSTEMUPGRADEPF.frmProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void otherChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherCharge frm = new SYSTEMUPGRADEPF.frmOtherCharge();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoanCategory frm = new SYSTEMUPGRADEPF.frmLoanCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanTypeCollateralsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCollaterals frm = new frmCollaterals();
            frm.MdiParent = this;
            frm.Show();
        }

        private void repaymentPeriodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRepaymentPeriods frm = new frmRepaymentPeriods();
            frm.MdiParent = this;
            frm.Show();

        }

        private void prefixToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPrefix frm = new SYSTEMUPGRADEPF.frmPrefix();
            frm.MdiParent = this;
            frm.Show();

        }

        private void memberSharesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberShares frm = new frmMemberShares();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void memberRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void globalOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupedOption frm = new SYSTEMUPGRADEPF.frmGroupedOption();
            frm.MdiParent = this;
            frm.Show();
        }

        private void setupRulesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSetupRule frm = new SYSTEMUPGRADEPF.frmSetupRule();
            frm.MdiParent = this;
            frm.Show();

        }

        private void relationshipToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmRelationship frm = new SYSTEMUPGRADEPF.frmRelationship();
            frm.MdiParent = this;
            frm.Show();
        }

        private void modeOfPaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmModeOfPayment frm = new frmModeOfPayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void compulsoryFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompulsoryField frm = new SYSTEMUPGRADEPF.frmCompulsoryField();
            frm.MdiParent = this;
            frm.Show();
        }

        private void membersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMember frm = new SYSTEMUPGRADEPF.frmMember();
            frm.MdiParent = this;
            frm.Show();
        }

        private void stationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmStation frm = new SYSTEMUPGRADEPF.frmStation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void employerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmEmployer frm = new SYSTEMUPGRADEPF.frmEmployer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fixedDepositToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFixedDeposit frm = new SYSTEMUPGRADEPF.frmFixedDeposit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void shareRemittanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmACTransaction frm = new SYSTEMUPGRADEPF.frmACTransaction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cashWithdrawalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCashWithdrawal frm = new SYSTEMUPGRADEPF.frmCashWithdrawal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanDisbursementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void loanApplicationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLoanApplication frm = new SYSTEMUPGRADEPF.frmLoanApplication();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loanRepaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanRepayment frm = new SYSTEMUPGRADEPF.frmLoanRepayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void currencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurrency frm = new SYSTEMUPGRADEPF.frmCurrency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exchangeRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchangeRate frm = new SYSTEMUPGRADEPF.frmExchangeRate();
            frm.MdiParent = this;
            frm.Show();

        }

        private void currencyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCurrency frm = new SYSTEMUPGRADEPF.frmCurrency();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loansReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloanreport frm = new SYSTEMUPGRADEPF.frmloanreport();
            frm.ShowDialog();
        }

        private void machineNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void connectivityStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnectivityStatus frm = new SYSTEMUPGRADEPF.frmConnectivityStatus();
            frm.MdiParent = this;
            frm.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice frm = new SYSTEMUPGRADEPF.frmInvoice();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frm = new SYSTEMUPGRADEPF.frmItem();
            frm.MdiParent = this;
            frm.Show();

        }

        private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment frm = new SYSTEMUPGRADEPF.frmPayment();
            frm.MdiParent = this;
            frm.Show();

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new SYSTEMUPGRADEPF.frmCustomer();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fixedAssetsRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssetRegistration frm = new SYSTEMUPGRADEPF.frmAssetRegistration();
            frm.MdiParent = this;
            frm.Show();

        }

        private void fixedAssetTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssetTransaction frm = new SYSTEMUPGRADEPF.frmAssetTransaction();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assetCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssetCategory frm = new SYSTEMUPGRADEPF.frmAssetCategory();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assetSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssetSubCategory frm = new SYSTEMUPGRADEPF.frmAssetSubCategory();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
