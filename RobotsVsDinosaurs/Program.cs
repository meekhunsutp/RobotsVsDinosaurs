using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Battlefield battlefield = new Battlefield();
            //battlefield.RunGame();

            Herd herd = new Herd();
            herd.PrintDinoInList();

            Fleet fleet = new Fleet();
            fleet.PrintBotsInList();
        }
    }
}
