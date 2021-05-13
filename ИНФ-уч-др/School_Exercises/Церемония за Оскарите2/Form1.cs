using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Церемония_за_Оскарите2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int naemZaplata = int.Parse(textBox1.Text);

            double cenaZaStatuetki = naemZaplata - naemZaplata * 0.3;
            label6.Text = $"{cenaZaStatuetki:f2}";
            double cenaZaKeturing = cenaZaStatuetki - cenaZaStatuetki * 0.15;
            label7.Text = $"{cenaZaKeturing:f2}";
            double cenaZaOzvuchavane = cenaZaKeturing / 2;
            label8.Text = $"{cenaZaOzvuchavane:f2}";

            double total = cenaZaStatuetki + cenaZaKeturing + cenaZaOzvuchavane + naemZaplata;

            label9.Text = $"{total:f2}";
        }
    }
}
