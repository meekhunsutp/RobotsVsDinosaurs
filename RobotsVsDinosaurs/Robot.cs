namespace RobotsVsDinosaurs
{
    public class Robot
    {
        //HAS A
        public string name;
        public int health;
        public int energyLevel;
        public string weaponType;
        public int attackPower;
        public int baseAttackPower;
        Weapon weapon;

        //SPAWNS
        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            attackPower = weapon.attackPower;
            health = 100;
            energyLevel = 50;

        }




        //CAN DO




    }
}
