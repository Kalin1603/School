namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Beginner : Player
    {
        public Beginner(string username, CardRepository cardRepository) : base(username, 50, cardRepository)
        {
            
        }
    }
}
