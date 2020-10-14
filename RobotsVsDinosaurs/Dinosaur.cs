using System.Collections.Generic;
using System;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //HAS A
        public string type;
        public int health;
        public int energyLevel;
        public string attackType;
        public int attackPower;




        //SPAWNS
        public Dinosaur(string type, int health, int energyLevel, string attackType, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energyLevel = energyLevel;
            this.attackType = attackType;
            this.attackPower = attackPower;
        }



        //CAN DO
        public void DinosaurAttack()
        {
            //int[] dinoAttacks = new int[3] { 100, 50, 25 };
            int[] dinoAttacks = new int[3];
            dinoAttacks[0] = 100; //chomp
            dinoAttacks[1] = 50; //tailspin
            dinoAttacks[2] = 25; //claw

        }



    }
}
