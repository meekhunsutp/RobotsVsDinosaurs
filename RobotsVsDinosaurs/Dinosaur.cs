using System.Collections.Generic;
using System;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        public string type;
        public int health;
        public int energyLevel;
        public DinoWeapon attack;

        public Dinosaur(string type, int health, int energyLevel)
        {
            this.type = type;
            this.health = health;
            this.energyLevel = energyLevel;
            attack = new DinoWeapon();
          
        }

    }
}
