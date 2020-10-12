using System.Collections.Generic;
using System;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //HAS A
        List<Robot> robots = new List<Robot>();

        Robot alpha = new Robot("Alpha", "Sword", 50);
        Robot beta = new Robot("Beta", "Sword", 50);
        Robot charlie = new Robot("Charlie", "Gun", 25);


        //SPAWNS
        public Fleet()
        {
            robots.Add(alpha);
            robots.Add(beta);
            robots.Add(charlie);

        }


        
        //CAN DO




    }
}
