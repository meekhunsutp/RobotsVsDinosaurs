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
            while (herd.dinosaursList[0].health >= 0 && fleet.robotList[0].health >= 0)
            {
                if (herd.dinosaursList[0].health > fleet.robotList[0].health)
                    RobotAttack();
                else
                {
                    DinosaurAttack();
                }
                if (herd.dinosaursList[0].health <= 0 || fleet.robotList[0].health <= 0)
                {

                }
            }

        }

        // Make array of dinosaurs in herd
        //find target in robot array
        //subtract dino attack power from robot health
        //subtract energyused from dino energy level
        //if robot still alive, move on to next, if dead, remove from array
        public void DinosaurAttack()
        {
            
            
            
            //int damage = dinosaur.attackPower;
            //robot health -= damage;
            //energyLevel -= 10;


        }



        // Make array of robot in herd
        //find target in dino array
        //subtract robot attack power from dino health
        //subtract energyused from robot energy level
        //if dino still alive, move on to next, if dead, remove from array
        public void RobotAttack()
        {


            //int damage = robot.attackPower;
            //dinosaur health -= damage;
            //energyLevel -= 10;

        }

    }
}
            //keep methods seperated

            //rungame method in correect order

            //dress it up