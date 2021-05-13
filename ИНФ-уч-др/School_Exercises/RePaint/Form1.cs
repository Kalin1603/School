using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal nailonPrice = 1.50m;
            const decimal pricePaint = 14.50m;
            const decimal paintThinnerPrice = 5m;

            int nailon = int.Parse(textBox1.Text);
            int paint = int.Parse(textBox2.Text);
            int PaintThinner = int.Parse(textBox3.Text);
            int hours = int.Parse(textBox4.Text);

            nailon += 2;

            decimal nailonExpenses = nailon * nailonPrice;
            double nPaint = paint * 1.1;

            decimal paintExpenses = (decimal)nPaint * pricePaint;
            decimal thinnerExpenses = PaintThinner * paintThinnerPrice;
            decimal totalExpenses = nailonExpenses + paintExpenses + thinnerExpenses + 0.40m;

            decimal workerExpenses = totalExpenses * 0.3m * hours;
            totalExpenses += workerExpenses;

            label6.Text = $"{totalExpenses:f2}";
        }
    }
}
