using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Weapon
    {
        public int DMG;
        public string name;

        public Weapon(int DMG, string name)
        {
            this.DMG = DMG;
            this.name = name;
        }
    }
}
