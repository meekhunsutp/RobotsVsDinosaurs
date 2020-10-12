using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //HAS A
        public string weaponType;
        public int attackPower;


        Weapon gun = new Weapon("Gun");
        Weapon sword = new Weapon("Sword");
        List<Weapon> weapons = new List<Weapon>();

        //SPAWNS
        public Weapon(string weaponType)
        {
            this.weaponType = weaponType;
            attackPower = 100;
        }




        //CAN DO




    }
}
