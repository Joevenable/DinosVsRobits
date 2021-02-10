using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Herd
    {
        public List<Dinos> dinos;
        public Herd()
        {
            Dinos dino1 = new Dinos(120, 30, 100, "Carno1");
            Dinos dino2 = new Dinos(120, 30, 100, "Carno2");
            Dinos dino3 = new Dinos(120, 30, 100, "Carno3");

            dinos = new List<Dinos>();
            
            dinos.Add(dino1);
            dinos.Add(dino2);
            dinos.Add(dino3);
        }
    }
}
