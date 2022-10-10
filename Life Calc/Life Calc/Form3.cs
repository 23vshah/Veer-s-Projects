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
    public partial class Form3 : Form
    {
        
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SpendLimitLB.Text = "Your monthly spending limit is $200-500: You will be able to spend this much money per month, while saving enough to reach your financial future goals";
            EarningLB.Text = "You will be estimated to earn $" + Form2.salary + " after college (based on major): You can predict that your starting pay may be in the range provided, based on if you take a job in your major. " +
            "However this is just an estimate based on your selected major, and doesn't include moving up the ranks. Plan to earn in a range around this salary, as it is a good measure of your future pay.";

            int years = (int)Math.Round(Form2.loans / (Form2.salary * 0.08));
            //int years = Form2.shape;

            if (years <= 10)
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

            if(years > 0)
            FinShapeLB.Text = FinShapeLB.Text + " You will be able to pay off your loans in an estimated " + 
                years.ToString() + " years.";
            else
                FinShapeLB.Text = FinShapeLB.Text + " Congrats you don't need to pay back your loans"; 


           

            if (Form2.extra <= 0)
            {
                SpendLimitLB.Text = "You are spending more money than you are earning in the short term." + 
                    " Although these costs can be covered by loans, you should try to cut down on your monthly spending right now. " +
                     "Try to focus on just necessities, so that you can make sure you are saving enough to reach your future financial goals.";
            }
            else
            {
                SpendLimitLB.Text = "Your Monthly Spending Limit is $" + ((int)(Form2.extra*.8)).ToString() + " to $" + ((int)(Form2.extra*1.2)).ToString() + "." +
                " This means that you are within a range to buy luxuries that you desire. However, don't forget that this extra cash could also be invested into your future. " +
                "Another suggestion is to save this money for the future, as it could be useful then.";
            }

        }
 
         private void FinTimesBN_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            Hide();
        }

        private void HomeBN_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void RecalcBN_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            Hide();
        }
    }
}
