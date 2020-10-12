namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //HAS A
        public string type;
        public int health;
        public int energy;
        public string attackType;
        public int attackPower;




        //SPAWNS
        public Dinosaur(string type, int health, int energy, string attackType, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackType = attackType;
            this.attackPower = attackPower;
        }



        //CAN DO




    }
}
