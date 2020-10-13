using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    public class Fleet
    {
        //HAS A
        List<Robot> robotlist;
        List<Weapon> weapons;
        public string weaponChoice;
        public string sword;
        public string gun;


        //SPAWNS
        public Fleet()
        {


            weapons = new List<Weapon>();
            Weapon sword = new Weapon("Sword", 100, 50);
            Weapon gun = new Weapon("Gun", 50, 25);

            weapons.Add(sword);
            weapons.Add(gun);



            robotlist = new List<Robot>();
            Robot alpha = new Robot("Alpha", sword);
            Robot beta = new Robot("Beta", sword);
            Robot charlie = new Robot("Charlie", gun);

            robotlist.Add(alpha);
            robotlist.Add(beta);
            robotlist.Add(charlie);

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
