namespace RobotsVsDinosaurs
{
    public class Weapon
    {
        //HAS A
        public string weaponType;
        public int attackPower;
        public int energyCost;
        public string sword;
        public string gun;
        Weapon weapons;



        //SPAWNS
        public Weapon(string weaponType, int attackPower, int energyCost)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;
            this.energyCost = energyCost;
        }




        //CAN DO
        public CreateWeapons()
        {
              weapons = new List<Weapon>();
            Weapon sword = new Weapon("Sword", 100, 50);
           Weapon gun = new Weapon("Gun", 50, 25);

              weapons.Add(sword);
             weapons.Add(gun);

        }




    }
}
