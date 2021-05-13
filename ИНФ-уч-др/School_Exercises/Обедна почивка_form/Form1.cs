using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Обедна_почивка_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int produljitelnostEpizod = int.Parse(textBox2.Text);
            int produljitelnostPochivka = int.Parse(textBox3.Text);

            double vremeObqd = produljitelnostPochivka * 1 / 8.0;
   
            double vremeOtdih = produljitelnostPochivka * 1 / 4.0;

            double ostanaloVreme = produljitelnostPochivka - vremeObqd - vremeOtdih;

            if (ostanaloVreme >= produljitelnostEpizod)
            {
               label4.Text = $"You have enough time to watch {name} and left with {ostanaloVreme - produljitelnostEpizod} minutes free time.";
            }
            else
            {
                label4.Text = $"You don't have enough time to watch {name}, you need {Math.Ceiling(produljitelnostEpizod - ostanaloVreme)} more minutes.";
            }

        }
    }
}
