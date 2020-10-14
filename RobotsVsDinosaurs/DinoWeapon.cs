using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class DinoWeapon
    {
        public string attackType;
        public int attackPower;
        public int energyCost;

        public DinoWeapon()
        {
            attackType = RandomAttack();
            if (attackType == "Chomp")
            {
                attackPower = 100;
                energyCost = 50;
            }
            else if (attackType == "Tailspin")
            {
                attackPower = 75;
                energyCost = 35;
            }
            else
            {
                attackPower = 50;
                energyCost = 25;
            }
        }

        public string RandomAttack()
        {
            Random rng = new Random();
            string[] dinoAttacks = new string[3] { "Chomp", "Tailspin", "Claw" };
            int randomAttack = rng.Next(0, dinoAttacks.Length);
            return attackType = dinoAttacks[randomAttack]

        }
    }
}
