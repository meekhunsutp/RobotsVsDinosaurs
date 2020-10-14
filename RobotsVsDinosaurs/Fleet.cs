using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        public List<Robot> robotList;
        public Fleet()
        {
            robotList = new List<Robot>();
            Robot alpha = new Robot("Alpha");
            Robot beta = new Robot("Beta");
            Robot charlie = new Robot("Charlie");

            robotList.Add(alpha);
            robotList.Add(beta);
            robotList.Add(charlie);
        }
        public void PrintBotsInList()
        {
            foreach (Robot robot in robotList)
            {
                Console.WriteLine(robot);
            }
        }

    }
}
