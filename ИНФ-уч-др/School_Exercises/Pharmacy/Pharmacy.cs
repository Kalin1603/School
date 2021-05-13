namespace Pharmacy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Pharmacy
    {
        private string name;
        private List<Medicine> medicines;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

        public void Order(Medicine medicine)
        {
            this.medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            return this.medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            return this.medicines.Sum(x => x.Price);
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return this.medicines.OrderBy(x => x.Price).First();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return this.medicines.OrderByDescending(x => x.Price).First();
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            this.medicines.Clear();
        }

        public override string ToString()
        {
            if (medicines.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Pharmacy {this.Name} has {this.medicines.Count} medicines and they are:");

                foreach (var medicine in this.medicines)
                {
                    sb.AppendLine(this.medicines.ToString());
                }
                return sb.ToString().TrimEnd();
            }
            else
            {
                return $"Pharmacy {this.Name} has 0 medicines and they are: N/A";
            }

        }


    }
}
