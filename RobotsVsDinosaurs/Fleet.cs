using System.Collections.Generic;

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




        //public void ChooseRoboWeapon()
        //{
        //    Console.WriteLine("Choose your weapon!\nInput SWORD or GUN");
        //    weaponChoice = Console.ReadLine().ToLower();

        //    if (weaponChoice == sword)
        //    {
        //       weapons sword;
        //    }
        //    else
        //    {

        //    }
        //}
        //public int TotalAttackPower()
        //{

        //}

    }
}
