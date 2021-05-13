namespace CounterStrike.Repositories.GunRepository
{
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GunRepository : IRepository<IGun>
    {
        private readonly List<IGun> guns;
           
       public IReadOnlyCollection<IGun> Models => this.guns.AsReadOnly();

        public void Add(IGun model)
        {
            if (model == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidGunRepository));
            }
            this.guns.Add(model);
        }

        public IGun FindByName(string name)
        {
           return this.guns.FirstOrDefault(x => x.Name == name);
        }
     
        public bool Remove(IGun model)
        {
             return this.guns.Remove(model);
        }
    }
}
