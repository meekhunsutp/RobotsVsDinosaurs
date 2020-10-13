using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //HAS A
        public string name;
        public int health;
        public int energyLevel;
        Weapon weapon;


        //SPAWNS
        public Robot(string name)
        {          
            this.name = name;
            health = 100;
            energyLevel = 50;
            weapon = new Weapon();
        }




        //CAN DO
        public void RobotAttack()
        {
            int damage = this.weapon.attackPower;
            int energyUsed = this.weapon.energyCost;
        }


    }
}
