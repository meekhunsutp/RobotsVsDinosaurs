using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //HAS A
        public string weaponType;
        public int attackPower;
        public int energyCost;



        //SPAWNS
        public Weapon()
        {
            weaponType = RandomWeapon();
            if (weaponType == "Sword")
            {
                attackPower = 100;
                energyCost = 50;
            }
            else if (weaponType == "Gun")
            {
                attackPower = 75;
                energyCost = 35;
            }
            else
            {
                attackPower = 50;
                energyCost = 25;
            }

        }




        //CAN DO

        //THIS IS WORKING
        //public string RandomWeapon()
        //{
        //    Random rng = new Random();
        //    var weapons = new string[2] { "Sword", "Gun" };
        //    int randomWeapon = rng.Next(0, 2);
        //    return weaponType = weapons[randomWeapon];
        //}
        
        public string RandomWeapon()
        {
            Random rng = new Random();
            List<string> weapons = new List<string>() { "Sword", "Gun" , "Punch"};
            int randomWeapon = rng.Next(0, weapons.Count);
            return weaponType = weapons[randomWeapon];
        }
        
        


    }
}
