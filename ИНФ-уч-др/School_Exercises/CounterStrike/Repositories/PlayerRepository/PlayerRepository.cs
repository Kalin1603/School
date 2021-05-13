namespace CounterStrike.Repositories.PlayerRepository
{
    using CounterStrike.Models.Players.Contracts;
    using CounterStrike.Repositories.Contracts;
    using CounterStrike.Utilities.Messages;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PlayerRepository : IRepository<IPlayer>
    {
        private readonly List<IPlayer> players;

        public IReadOnlyCollection<IPlayer> Models => this.players;

        public List<IPlayer> GamePlayers
        {
            get => this.players;
        }

        public void Add(IPlayer model)
        {
            if (model == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidGunRepository));
            }
            this.players.Add(model);
        }

        public IPlayer FindByName(string name)
        {
            return this.players.FirstOrDefault(x => x.Username == name);
        }

        public bool Remove(IPlayer model)
        {
            return this.players.Remove(model);
        }
    }
}
