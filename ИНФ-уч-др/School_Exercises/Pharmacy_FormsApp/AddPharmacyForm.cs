using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_FormsApp
{
    public partial class AddPharmacyForm : Form
    {
        public AddPharmacyForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string path = @"E:\Kalin_Informatika\School-Repository\ИНФ-уч-др\School_Exercises\Pharmacy_FormsApp\Pharmacy.txt";

            try
            {
                Pharmacy pharmacy = new Pharmacy(textBox1.Text);
                using (StreamWriter writer = new StreamWriter(path,true))
                {
                    writer.WriteLine($"@{textBox1.Text}");
                }
                textBox1.Clear();

                MessageBox.Show("Pharmacy is added!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
