using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobits
{
    public class Program
    {
        static void Main(string[] args)
        {
            BattleField battleField = new BattleField();
            battleField.RunGame();
            battleField.Winners();
            Console.ReadLine();
        }
    }
}
