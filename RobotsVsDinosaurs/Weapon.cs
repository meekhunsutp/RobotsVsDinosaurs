using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        public string weaponType;
        public int attackPower;
        public int energyCost;
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
        public string RandomWeapon()
        {
            Random rng = new Random();
            List<string> weapons = new List<string>() { "Sword", "Gun" , "Punch"};
            int randomWeapon = rng.Next(0, weapons.Count);
            return weaponType = weapons[randomWeapon];
        }
        
        


    }
}
