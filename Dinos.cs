using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Dinos
    {
        public int health;
        public int attackDmg;
        public int energy;
        public string type;

        public Dinos(int health, int attack, int energy, string type)
        {
            this.health = health;
            this.attackDmg = attack;
            this.energy = energy;
            this.type = type;
        }
        public void attack(Robits robits)
        {
            robits.health = robits.health - attackDmg;


        }

    }
}
