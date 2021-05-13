using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Приход_от_филм_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = (textBox1.Text);
            int dni = int.Parse(textBox2.Text);
            int broiBileti = int.Parse(textBox3.Text);
            double cenaBilet = double.Parse(textBox4.Text);
            int procentKino = int.Parse(textBox5.Text);

            double cenaBiletZaDen = broiBileti * cenaBilet;
            
            double cqlPeriod = dni * cenaBiletZaDen;

            double procentPrihod = cqlPeriod * procentKino / 100;

            double total = cqlPeriod - procentPrihod;

            label6.Text = $"The profit from the movie {name} is {total} lv.";
        }
    }
}
