using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class BattleField
    {
        public Herd herd;
        public Fleet fleet;
        public BattleField()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to the DeathBowl place your bets");
            Console.WriteLine("In this corner they aren't man but man made the ROOOOOOOOOOOBBBBBIIIIIIITTTTSS!!!");
            Console.WriteLine("In this corner coming back from extiction the DIIIIIIIIINNNNOOOOOOOOOSSS!!!!!");
            BattleTurn();
            
        }
        public void BattleTurn()
        {
            while (fleet.robits[0].health > 0 && herd.dinos[0].health > 0)
            {
                if (fleet.robits != null && fleet.robits.Count == 0)
                {
                    return;
                }
                if (fleet.robits[0].health > 0)
                {
                    fleet.robits[0].attack(herd.dinos[0]);
                    if (herd.dinos[0].health <= 0)
                    {
                        Console.WriteLine($"{herd.dinos[0].type} has been removed from the battle field");
                        herd.dinos.Remove(herd.dinos[0]);
                    }
                }
                if (herd.dinos != null && herd.dinos.Count == 0)
                {
                    return;
                }
                if (herd.dinos[0].health > 0)
                {
                    herd.dinos[0].attack(fleet.robits[0]);
                    if (fleet.robits[0].health <= 0)
                    {
                        Console.WriteLine($"{fleet.robits[0].name} has been removed from the battle field");
                        fleet.robits.Remove(fleet.robits[0]);

                    }

                }
                 
            }
        }
        public void Winners()
        {
            if (herd.dinos != null && herd.dinos.Count == 0)
            {
                Console.WriteLine("Here are your winners of the Deathbowl THEEEEEEEE RRRRRRRRROOOOOOOOOBBBBIIIITTTTSSSSS!!!!");
            }
            else if (fleet.robits != null && fleet.robits.Count == 0)
            {
                Console.WriteLine("Here are your winners of the Deathbowl THEEEEEEEE DIIIIIIIIIIINNNOOOOOSSSSSSS!!!!!");
            }
        }    
    }
}
