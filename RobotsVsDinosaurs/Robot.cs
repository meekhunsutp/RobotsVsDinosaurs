using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Robot
    {
        public string name;
        public int health;
        public int energyLevel;
        public Weapon weapon;
        public Robot(string name)
        {          
            this.name = name;
            health = 100;
            energyLevel = 50;
            weapon = new Weapon();
        }

    }
}
