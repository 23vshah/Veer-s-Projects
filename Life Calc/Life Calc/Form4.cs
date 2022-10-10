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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            TaxesInfoLB.Text = "Ensure that you know of all local, state and federal " +
                "taxes to prevent fines or imprisonment. If you do not pay these taxes, they can build up to hurt you in the future. " +
                "Some basic tips about taxes that you should know are that taxes are progressive, meaning that tax rate increases as the taxable base amount increases. So basically you pay a certain % for your first $10,000 and then another % on your next $20,000 etc. ";
            GFSpendInfoLB.Text = "Good financial spending includes saving all receipts to " +
                "fact check the bank's reports. It is also important to prepare plans for spending limits." +
                " You should budget your spending to be under your monthly revenue; this will help you  " +
                "control your finances and avoid bad, impulsive financial decisions.";
            LNIntInfoLB.Text = "It is always a good financial decision to limit the number of loans you take out." +
                "If you are able, try to only take loans on a house, college, and a car. Taking loans adds a interest rate that can build up" +
                " which can build up debt very quickly. To avoid this you should attempt to take low interest loans for smaller values, and always manage to make the monthly payment.";

            CredScoreInfoLB.Text = "It is vital that you maintain a good credit score. With a low credit score, creditors will " +
                "make you pay higher interest rates. To keep your credit score high, you must pay attention to the dates that credit card " +
                "payments are due. Keep an organized document to aid with this, as missing credit card payments instill a huge amount of interest that will become harder to pay off later.";
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
