using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калкулатор_за_сериали_form
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
            int broiSezoni = int.Parse(textBox2.Text);
            int broiEpizodi = int.Parse(textBox3.Text);
            double vremetraene = double.Parse(textBox4.Text);

            double produljitelnostNaReklami = 0.2 * vremetraene;
            label9.Text = $"{produljitelnostNaReklami:f2}";
            
            double produljitelnostNaEpizod = vremetraene + produljitelnostNaReklami;
            label10.Text = $"{produljitelnostNaEpizod:f2}";
            
            double dopulnitelnoVreme = broiSezoni * 10;
            label11.Text = $"{dopulnitelnoVreme:f2}";
            

            double total = produljitelnostNaEpizod * broiEpizodi * broiSezoni + dopulnitelnoVreme;
            label12.Text = $"{total:f2}";
        }
    }
}
