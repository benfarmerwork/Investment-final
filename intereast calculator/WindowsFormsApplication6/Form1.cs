using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int years;
        int amount_per_year;
        double final = 0;
        double start = 0;
        double interest = 0;
        double total = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            years = int.Parse(textBox1.Text);
            amount_per_year = int.Parse(textBox2.Text);
            listBox1.Items.Add("year  Start   Paid in   Intereast  Final");
            for (int i = 1; i < years+1; i++)
            {
                interest = (final + amount_per_year) * 0.10;
                final = (final + amount_per_year) * 1.10;
                
                listBox1.Items.Add(i.ToString() + "       " + start +  "         " + amount_per_year + "         " +  interest + "         " + final);
                start = final ;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
