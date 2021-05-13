namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CardRepository
    {
        private readonly List<Card> cards;

        public int Count { get=>cards.Count;}
    }
}
