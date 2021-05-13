namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Animals
    {
        public string AnimalType { get; set; }
        public string Name { get; set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }

        public Animals( string name, int age, string gender)
        {
            
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract string ProduceSound();
        


        public virtual string PrintOut()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine($"{ProduceSound()}");
            return sb.ToString();
        }
        
    }
}
