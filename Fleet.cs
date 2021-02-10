using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Fleet
    {
        public List<Robits> robits;
        public Fleet()
        {
            Weapon weapon1 = new Weapon(60, "particle lance");
            Robits robit1 = new Robits("XIIVV122", 60, 200, weapon1);
            Robits robit2 = new Robits("XIIVV834", 60, 200, weapon1);
            Robits robit3 = new Robits("XIIVV578", 60, 200, weapon1);

            robits = new List<Robits>();
            
            robits.Add(robit1);
            robits.Add(robit2);
            robits.Add(robit3);
        }

        
    }
}
