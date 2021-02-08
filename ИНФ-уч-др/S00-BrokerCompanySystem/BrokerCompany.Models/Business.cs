namespace BrokerCompany.Models
{
    using System;
    using BrokerCompany.Common;

    public class Business : Building
    {
        public Business(string name, string city, int stars, double rentAmount)
            : base(name, city, stars, rentAmount)
        {

        }

        public override string Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
                if (value.Substring(value.Length - 5, 5) == "Business")
                {
                    throw new ArgumentException(StaticMessages.BusinessInvalidNameValue);
                }
            }
        }
    }
}
