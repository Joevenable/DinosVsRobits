using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Robits
    {
        public string name;
        public int health;
        public int power;
        public Weapon weapon;

        public Robits(string name, int health, int power, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.power = power;
            this.weapon = weapon;

            
        }
        
        public void attack(Dinos dinos)
        {
            dinos.health = dinos.health - weapon.DMG;
              
            
        }
    }
}
