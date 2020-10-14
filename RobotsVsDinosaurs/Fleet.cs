using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //HAS A
        public List<Robot> robotList;



        //SPAWNS
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



        //CAN DO

        public void PrintBotsInList()
        {
            foreach (Robot robot in robotList)
            {
                Console.WriteLine(robot);
            }
        }



    }
}
