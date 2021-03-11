using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            textBox1.Text = string.Empty;
            if (number != 0)
            {
                listBox1.Items.Add(number);
            }
            else
            {
                textBox1.Enabled = false;
                buttonEnter.Enabled = false;
                int[] numbers = new int[listBox1.Items.Count];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = (int)listBox1.Items[i];
                }
                label2.Text += $"\n{numbers.Where(x => x < 0).Sum()}";
            }
        }

        private void buttonEnter2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox2.Text);
            listBox2.Items.Add(number);
            textBox2.Text = string.Empty;
            if (listBox2.Items.Count == 13)
            {
                textBox2.Enabled = false;
                buttonEnter2.Enabled = false;
                int[] numbers = new int[listBox2.Items.Count];

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = (int)listBox2.Items[i];
                }
                label5.Text += $"\n{numbers.Where(x => x > 0 || x < -100).Average():f2}";
            }
        }

        private static int Product(int k)
        {
            Random random = new Random();
            int[] numbers = new int[k];

            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-1000, 1000);

                bool isTrue = numbers[i] >= -10 && numbers[i] <= 10;
                if (isTrue)
                {
                    product *= numbers[i];
                }
            }
            return product;
        }

        private void buttonEnter3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);

            int result = Product(Math.Abs(c - b)) * Product(a);
            labelResult.Text = $"{result}";
        }
    }
}
