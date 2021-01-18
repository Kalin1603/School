namespace Project.Roles_and_Champions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Character
    {      
        private string role;

        public Character(string role)
        {
            this.Role = role;

        }

        public string Role
        {
            get { return role; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid role");
                }
                role = value;
            }
        }
        

        public override string ToString()
        {
            return $"{this.Role}";
        }
    }
}
