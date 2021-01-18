namespace Животинско_царство
{
    using System;
    using System.Collections.Generic;
    using System.Text;

   public abstract class Animal : IMakeNoise,IMakeTrick
    {
        private string name;
        private int age;

        protected Animal(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual string MakeNoise()
        {
            return $"My name is {this.Name}. I am {this.Age} years old.";
        }

        public virtual string MakeTrick()
        {
            return $"Look at my trick!";
        }
    }
}
