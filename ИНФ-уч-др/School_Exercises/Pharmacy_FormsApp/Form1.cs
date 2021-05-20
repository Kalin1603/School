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
    public partial class Form1 : Form
    {
        private Dictionary<string, Medicine> medicines;

        public Form1()
        {
            InitializeComponent();
            medicines = new Dictionary<string, Medicine>();
            LoadMedicines();
        }

        private void addMedicine_Click(object sender, EventArgs e)
        {
            AddMedicine medicine = new AddMedicine();
            medicine.Show();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            LoadMedicines();
        }

        private void LoadMedicines()
        {
            string path = @"E:\Kalin_Informatika\School-Repository\ИНФ-уч-др\School_Exercises\Pharmacy_FormsApp\Medicine.txt";

            medicines.Clear();

            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.ReadLine() != null)
                {
                    string[] result = reader.ReadLine().Split('-');
                    Medicine medicine = new Medicine(result[0], double.Parse(result[1]));
                    medicines.Add(result[0], medicine);
                }
            }

            listBox1.Items.Clear();

            foreach (var m in medicines)
            {
                listBox1.Items.Add(m.Value.ToString());
            }
        }
    }
}
