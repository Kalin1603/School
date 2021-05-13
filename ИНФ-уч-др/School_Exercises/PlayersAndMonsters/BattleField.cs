namespace PlayersAndMonsters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BattleField
    {
        public void Fight(Player attacker, Player enemy)
        {
            if (attacker.IsDead == true || enemy.IsDead == true)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attacker is Beginner)
            {
                attacker.Health += 40;
                
            }
        }
    }
}
