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
            Console.WriteLine("Welcome to Whose Fight is it Anyways?");
            Console.WriteLine("The game where everything's made up and the points don't matter");
            Console.WriteLine("Staring under powered ROBOTS Versus suped up DINOSAURS");
            Battlefield battlefield = new Battlefield();
            battlefield.RunGame();
            Console.ReadLine();

        }
    }
}
