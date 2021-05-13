namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Advanced : Player
    {
        public Advanced(string username, CardRepository cardRepository) : base(username, 250, cardRepository)
        {
            
        }
    }
}
