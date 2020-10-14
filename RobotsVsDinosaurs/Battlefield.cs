using System.Collections.Generic;
using System;

namespace RobotsVsDinosaurs
{
    public class Battlefield
    {
        //HAS A
        public Fleet fleet;
        public Herd herd;




        //SPAWNS
        public Battlefield()
        {

            //instant heard fleet
            herd = new Herd();
            fleet = new Fleet();

        }
        //CAN DO
        //public void Attack(//robot object)
        //{
        //    //-health
        //    energyLevel -= 10;
        //}



        //Compare herd and fleet
        //if not equal to 0 run attacks until one side = 0
        public void RunGame()
        {
            while (herd.dinosaursList.Count !=0 && fleet.robotList.Count !=0)
            {
                Fight();
            }
            if (herd.dinosaursList.Count == 0)
            {
                Console.WriteLine("Robots Win");
            }
            else
            {
                Console.WriteLine("Dinosaurs Win");
            }

        }

        // Make array of dinosaurs in herd
        //find target in robot array
        //subtract dino attack power from robot health
        //subtract energyused from dino energy level
        //if robot still alive, move on to next, if dead, remove from array
       
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
                }
                else if (fleet.robotList[0].health <= 0)
                {
                    fleet.robotList.RemoveAt(0);
                }
            }
        }
        public void DinosaurAttack()
        {
            //if (herd.dinosaursList[0].)
            //{
            //    herd.dinosaursList[0].health -= fleet.robotList[0].weapon.attackPower;
            //    fleet.robotList[0].energyLevel -= fleet.robotList[0].weapon.energyCost;
            //}
            //else
            //{
            //    while (fleet.robotList[0].health > 0)
            //    {
            //        DinosaurAttack();
            //    }
            //}


        }



        // Make array of robot in herd
        //find target in dino array
        //subtract robot attack power from dino health
        //subtract energyused from robot energy level
        //if dino still alive, move on to next, if dead, remove from array
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
            //keep methods seperated

            //rungame method in correect order

            //dress it up