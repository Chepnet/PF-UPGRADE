using Microsoft.VisualBasic;
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
    public partial class frmStartAndEndOfDay : Form
    {
        public frmStartAndEndOfDay()
        {
            InitializeComponent();
        }
        Classes.MainInfo oMainInfo = new Classes.MainInfo();
        Classes.MainInfo onewMainInfo = null;
        private DateTime WorkingDate = DateTime.Now ;
        private bool dayclosed = false;
        Classes.Loan oLoan = new Classes.Loan();
        Classes.Loan onewLoan = null;
        Classes.LoanType oloantype = new Classes.LoanType();
        Classes.LoanType onewloantype = null;
        Classes.RepaymentPeriod oRepayperiod = new Classes.RepaymentPeriod();
        Classes.RepaymentPeriod onewRepayperiod = null;

        private void button3_Click(object sender, EventArgs e)
        {
            if (onewMainInfo == null)
                onewMainInfo = new Classes.MainInfo();
           
            if(!dayclosed )
            {
                MessageBox.Show("Close the current day ", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

            
            onewMainInfo.PrevSODDate = dtpWorkingDate.Value;
                
            onewMainInfo.PrevEODDate = WorkingDate;
            string error = "";
            onewMainInfo.AddEditMainInfo( ref error);
               
            onewMainInfo.AddEditLoanDues(ref error);
               onewMainInfo.GetLoanArrears(ref error);
                onewMainInfo.CalculatePenalty(ref error);
                onewMainInfo.AddEditLoanInterest(ref error );
                LoanAmortizationInterest();
                ChangeNextDueDate();


                if (error=="")
            {
                MessageBox.Show("Process Succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MdiParent.Close();
                   

            }
            else
            {

                MessageBox.Show(error , this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }
        }
        private void ChangeNextDueDate()
        {
            ArrayList myList = oLoan.GetLoans();
            foreach (Classes.Loan oLon in myList )
            {
                if (oLon.NextDueDate == dtpWorkingDate.Value)
                {
                    onewloantype = oloantype.GetLoanType(oLon.LoanTypeId);
                    if(onewloantype !=null)
                    {
                        onewRepayperiod = oRepayperiod.GetRepaymentPeriod(onewloantype.RepaymentFrequency);
                        {
                            if(onewRepayperiod !=null)
                            {
                                 if(onewRepayperiod .PeriodReference  =="Days")
                                {
                                    oLon.NextDueDate = oLon.NextDueDate.AddDays(onewRepayperiod.FrequencyRange * onewloantype.GracePeriod);
                                }

                                else if (onewRepayperiod.PeriodReference == "Months")
                                {
                                    oLon.NextDueDate = oLon.NextDueDate.AddMonths (onewRepayperiod.FrequencyRange * onewloantype.GracePeriod);
                                }
                                else  if (onewRepayperiod.PeriodReference == "Weeks")
                                {
                                    oLon.NextDueDate = oLon.NextDueDate.AddDays(onewRepayperiod.FrequencyRange * onewloantype.GracePeriod*7);
                                }

                                else if (onewRepayperiod.PeriodReference == "Year")
                                {
                                    oLon.NextDueDate = oLon.NextDueDate.AddDays(onewRepayperiod.FrequencyRange * onewloantype.GracePeriod);
                                }
                            }
                        }
                    }
                    string err = "";
                    onewLoan = oLoan.GetLoan(oLon.LoanId);
                    if(onewLoan  !=null)
                    {
                        onewLoan.NextDueDate = oLon.NextDueDate;
                        if(onewLoan.MemberShareId >0)
                        {
                            onewLoan.transferLoan(false, ref err);
                        }
                        else
                        {
                            onewLoan.AddEditLoan(false, ref err);
                        }
                       
                    }
                }
            }
        }
        private bool IsEomDate(DateTime value)
        {
            bool found = false;

            switch (value.Month)
             {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (value.Day == 31)
                        found = true;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (value.Day == 30)
                        found = true;
                    break;
                default:
                    if (value.Year % 4 == 0)
                    {
                        if (value.Day == 29)
                            found = true;
                    }
                    else
                    {
                        if (value.Day == 28)
                            found = true;
                    }
                    break;


            }

            return found;
        }
        private void LoanAmortizationInterest()
        {


            ArrayList myList  = oLoan.GetLoans();
            string err = "";
            double IntAmount = 0,  monthCount = 1, repayPeriod = 1, /*origAmount = 0,*/ monthlyRepayment = 0;
            bool skip = false;
            foreach (Classes.Loan olo in myList )
            {
                skip = false;
                onewloantype = oloantype.GetLoanType(olo.LoanTypeId);
                if (dtpWorkingDate.Value !=olo.NextDueDate  ) 
                {
                    skip = true;
                }
                if(onewloantype.InterestPayMethod != 3)
                {
                    skip = true;
                }
                if (IsEomDate(dtpWorkingDate.Value))
                {
                    //if end of month
                }
                if (!skip)
                {
                    if (dtpWorkingDate.Value.Day != olo.LoanEffectDate.Day)//if working on anniversary
                        skip = true;
                }


                if (!skip)
                    {
                    if(onewloantype.InterestPostingFrequency ==1)
                    {
                        if(onewloantype.DailyRateSpecification ==0)//use no of days in a month
                        {
                            int numberOfDays = DateTime.DaysInMonth(olo.LoanEffectDate .Year, olo.LoanEffectDate .Month);
                            IntAmount = Math.Abs(Financial .IPmt(olo.InterestRate / (100 * numberOfDays), repayPeriod = 1, monthCount = 1, olo.LoanAmount));

                        }
                        if(onewloantype.DailyRateSpecification ==1)// use 30 days in a month
                        {
                            IntAmount = Math.Abs(Financial .IPmt(olo.InterestRate / (100 *30), repayPeriod = 1, monthCount = 1, olo.LoanAmount));
                        }
                        if (onewloantype.DailyRateSpecification == 2)//annual rate/360
                        {
                            IntAmount = Math.Abs(Financial.IPmt((olo.InterestRate*12) / (100 * 360), repayPeriod = 1, monthCount = 1, olo.LoanAmount));
                        }
                        if (onewloantype.DailyRateSpecification == 4)//annual rate/366
                        {
                            IntAmount = Math.Abs(Financial.IPmt((olo.InterestRate * 12) / (100 * 366), repayPeriod = 1, monthCount = 1, olo.LoanAmount));
                        }
                        else// annual rate/365
                        {
                            IntAmount = Math.Abs(Financial.IPmt((olo.InterestRate * 12) / (100 * 365), repayPeriod = 1, monthCount = 1, olo.LoanAmount));
                        }
                    }
                    else// use anniversary  or end of the month
                    {

                        IntAmount = Math.Abs(Financial.IPmt(olo.InterestRate / 100, repayPeriod, monthCount, olo.LoanAmount));
                        monthlyRepayment = Math.Abs(Financial.PPmt(olo.InterestRate / 100, repayPeriod, monthCount, olo.LoanAmount));
                    }
                   

                   
                    onewMainInfo.LoanId = olo.LoanId;
                    onewMainInfo.InterestRate = olo.InterestRate;
                    onewMainInfo.InterestAmount = IntAmount;
                    onewMainInfo.InterestPayMethod = onewloantype.InterestPayMethod;
                    onewMainInfo.InterestPostingFrequency = onewloantype.InterestPostingFrequency;
                    onewMainInfo.DailyRateSpecification = onewloantype.DailyRateSpecification;
                    onewMainInfo.CalculationFormula = onewloantype.InterestCalculationFormula;
                    onewMainInfo.LoanBalance = olo.LoanBalance;
                    onewMainInfo.TransDate = WorkingDate;
                    onewMainInfo.AddEditLoanAmortizationInterest(ref err);
                    }
                
            }
           
           


        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            if (onewMainInfo == null)
                onewMainInfo = new Classes.MainInfo();
            onewMainInfo.PrevEODDate  = dtpWorkingDate.Value ;
            onewMainInfo.PrevSODDate = dtpWorkingDate.Value;
            string error = "";
           
           
           
            onewMainInfo.AddEditMainInfo(ref error);

            
          
          
            if (error == "")
            {
                MessageBox.Show("Process Succeeded", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                MdiParent.Close();

            }
            else
            {

                MessageBox.Show(error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmStartAndEndOfDay_Load(object sender, EventArgs e)
        {
            ArrayList myList = oMainInfo.GetMainInfos();
            foreach (Classes.MainInfo omainfo in myList)
            {
                WorkingDate  = omainfo.PrevSODDate;
                dtpWorkingDate.Value = WorkingDate;
                if(omainfo.PrevEODDate ==omainfo.PrevSODDate )
                {
                    dayclosed = true;
                   
                }

            }
            if(dayclosed )
            {
                dtpWorkingDate.Enabled = true ;
                btnEndOfDate.Enabled = false;
                btnLoans.Enabled = false;
              
               
                
            }
            else
            {
                dtpWorkingDate.Enabled = false;
                btnEndOfDate.Enabled = true;
                btnLoans.Enabled = true;
                btnStartOfDay.Enabled = false;
            }
        }
    }
}
