using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life_Calc
{
    
    public partial class Form2 : Form
    {
        public string college = string.Empty;
        public string major = string.Empty;
        public int monthRev = 0;
        public int monthSpend = 0;
        public static int loans = 0;
        public static int shape;
        public static int salary;
        public static int extra;
        public int[,] costC = new int[502,3];
        public int[] rev = new int[255];
        

        public Form2()
        {
            InitializeComponent();
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            CollegeCB.SelectedIndex = 501;
            MajorCB.SelectedItem = "Undecided";
            CollegeCB.Text = "Potential College";
            MajorCB.Text = "Select Your Major";
            AmountPaidTB.Visible = false;
            AllLoansRB.Checked = true;

            
            costC[183,0] = 72000;
            costC[183,1] = 120000;
            costC[183, 2] = 142000;

            costC[500,0] = 40000;
            costC[500,1] = 80000;
            costC[500,2] = 100000;

            costC[0,0] = 42000;
            costC[0,1] = 82000;
            costC[0,2] = 150000;

            rev[0] = 105000;
            rev[1] = 72000;
            rev[2] = 72000;
            rev[3] = 51000;

            rev[56] = 67000; // "Business/Management Quantitative Methods, General",

            rev[74] = 77000; // "Finance, General",

            rev[80] = 68000; // real estate

            rev[111] = 49800; // teacher

            rev[253] = 87000; // Mechanical Engineering

        }

        private void ParentsPayRB_CheckedChanged(object sender, EventArgs e)
        {
            AmountPaidTB.Visible = false;
        }

        private void AllLoansRB_CheckedChanged(object sender, EventArgs e)
        {
            AmountPaidTB.Visible = false;

        }

        private void PartialPaymentsRB_CheckedChanged(object sender, EventArgs e)
        {
            AmountPaidTB.Visible = true;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            

            //if(isFinished()) 
            //{              


                loans = 0;
                
                college = CollegeCB.SelectedItem.ToString();

                major = MajorCB.SelectedItem.ToString();
                
            
                string s = MonthlyRevTB.Text;  
                bool result = int.TryParse(s, out monthRev);

                string spending = MonthlySpendingTB.Text;  
                bool result1 = int.TryParse(spending, out monthSpend);

                short indexC= (short)CollegeCB.SelectedIndex;
                short indexM = (short)MajorCB.SelectedIndex;

                loans = costC[indexC,1];
                int downB = costC[indexC, 0];
                int upB = costC[indexC, 2];

                if (ParentsPayRB.Checked == true)
                {
                loans = 0;
                upB = 0;
                downB = 0;
                }
                else if(PartialPaymentsRB.Checked == true)
                {
                    string s2 = AmountPaidTB.Text;
                    int sub = 0;
                    bool result2 = int.TryParse(s2, out sub);
                    loans -= sub;
                    upB -= sub;
                    downB-=sub;
                }

                shape = loans;
                salary = rev[indexM];

                shape -= (int)(salary*.08) * 10; // US Department of Education recommends this 8

                int years = (int)Math.Round(loans / (salary * 0.08));


                if (years <= 0)
                {
                    FinShapeLB.ForeColor = Color.Lime;
                    FinShapeLB.Text = "You are in good financial shape:";
                }
                else if (years <= 15)
                {
                    FinShapeLB.ForeColor = Color.Orange;
                    FinShapeLB.Text = "You should watch your financial shape:";
                }
                else
                {
                    FinShapeLB.ForeColor = Color.FromArgb(255, 220, 0, 0);
                    FinShapeLB.Text = "You are not in financial shape:";
                }
                
                EstimatedEarnLB.Text = "You are estimated to earn $" + salary.ToString() + " after college."; // based on major

                if (downB <= 0)
                    downB = 0;

                if (upB <= 0)
                    ColCostLB.Text = "Great shape, loan not necessary!";
                else    
                    ColCostLB.Text = "Your expected college loans could range from $" + downB.ToString() + " to $" + upB.ToString();


                extra = monthRev - monthSpend;

                if (extra <= 0)
                {
                    SpendLimLB.Text = "You do not have the means to buy luxuries.";
                }
                else
                {
                    SpendLimLB.Text = "Your Monthly Spending Limit is $" + ((int)(extra*.8)).ToString() + " to $" + ((int)(extra*1.2)).ToString() + ".";
                }
            //}
            //else
            //   MessageBox.Show("Not all variables are filled in, try again");

        }

        private void LearnMoreLB_Click(object sender, EventArgs e)
        {
           // if (!isFinished())
           //     MessageBox.Show("Not all variables are filled in, try again");
            //else
           // {
            Form3 f = new Form3();
            f.Show();
            Hide();
           // }
        }

        private void HomeBN_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        /*private bool isFinished()
        {
            college = CollegeCB.SelectedItem.ToString();

            major = MajorCB.SelectedItem.ToString();
            
            if (String.IsNullOrEmpty(CollegeCB.SelectedItem.ToString()) || String.IsNullOrEmpty(MajorCB.SelectedItem.ToString()) || 
            (!PartialPaymentsRB.Checked && !ParentsPayRB.Checked && !AllLoansRB.Checked))
                return false;
            else 
                return true;
        }*/
        
    }
}
