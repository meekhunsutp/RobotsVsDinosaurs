using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //HAS A
        public string name;
        public int health;
        public int powerLevel;
        public string weaponType;
        public int attackPower;

        //SPAWNS
        public Robot(string name, string weaponType, int attackPower)
        {
            this.name = name;
            this.weaponType = weaponType;
            health = 100;
            powerLevel = 50;

        }




        //CAN DO
        public void Attack()
        {
            powerLevel -= 10;
        }



    }
}
