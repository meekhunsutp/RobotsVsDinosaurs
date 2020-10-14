using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        public Fleet fleet;
        public Herd herd;
        public DinoWeapon dinoAttack;
        public Battlefield()
        {

            herd = new Herd();
            fleet = new Fleet();
            dinoAttack = new DinoWeapon();
        }
 
        public void RunGame()
        {
            while (herd.dinosaursList.Count !=0 && fleet.robotList.Count !=0)
            {
                Fight();
            }
        }

        public void Fight()
        {
            while (herd.dinosaursList[0].health >= 0 && fleet.robotList[0].health >= 0)
            {
                if (herd.dinosaursList[0].health > fleet.robotList[0].health)
                    RobotAttack();
                else
                {
                    DinosaurAttack();
                }
                if (herd.dinosaursList[0].health <= 0)
                {
                    herd.dinosaursList.RemoveAt(0);
                    Console.WriteLine("Robots have killed a dinosaur!\n");
                    if (herd.dinosaursList.Count == 0)
                    {
                        Console.WriteLine("All Dinosaurs are dead!");
                        Console.WriteLine("\n\nRobots Win");
                        break;
                    }
                }
                else if (fleet.robotList[0].health <= 0)
                {
                    fleet.robotList.RemoveAt(0);
                    Console.WriteLine("Dinosaurs have killed a robot!\n");
                    if (fleet.robotList.Count == 0)
                    {
                        Console.WriteLine("All Robots are dead!");
                        Console.WriteLine("\n\nDinosaurs Win");
                        break;
                    }
                }
            }

        }
        public void DinosaurAttack()
        {
            if (herd.dinosaursList[0].attack.energyCost <= herd.dinosaursList[0].energyLevel)
            {
                fleet.robotList[0].health -= herd.dinosaursList[0].attack.attackPower;
                herd.dinosaursList[0].energyLevel -= herd.dinosaursList[0].attack.energyCost;
            }
            else
            {
                while (herd.dinosaursList[0].health > 0)
                {
                    RobotAttack();
                }
            }
        }

        public void RobotAttack()
        {
            if(fleet.robotList[0].weapon.energyCost <= fleet.robotList[0].energyLevel)
            {
                herd.dinosaursList[0].health -= fleet.robotList[0].weapon.attackPower;
                fleet.robotList[0].energyLevel -= fleet.robotList[0].weapon.energyCost;
            }
            else
            {
                while (fleet.robotList[0].health > 0)
                {
                    DinosaurAttack();
                }
            }

        }

    }
}
