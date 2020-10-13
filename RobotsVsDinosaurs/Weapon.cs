using System;

namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //HAS A
        public string weaponType;
        public int attackPower;
        public int energyCost;
        Random random;



        //SPAWNS
        public Weapon()
        {
            weaponType = RandomWeapon();
            if (weaponType == "Sword")
            {
                attackPower = 100;
                energyCost = 50;
            }
            else
            {
                attackPower = 50;
                energyCost = 25;
            }

        }




        //CAN DO
        public string RandomWeapon()
        {
            var weapons = new string[2] { "Sword", "Gun" };
            int randomWeapon = random.Next(0, 1);
            return weaponType = weapons[randomWeapon];
        }
        //public string ChooseAWeapon()
        //{
        //    Console.WriteLine("Choose Sword or Gun");

        //}
  

    }
}
