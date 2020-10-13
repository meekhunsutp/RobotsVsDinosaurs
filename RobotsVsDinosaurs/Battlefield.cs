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



        public void DinoAttack()
        {
            int damage = dinosaur.attackPower;
            robot health -= damage;
            energyLevel -= 10;


        }



        //attack is robots 
        public void RobotAttack()
        {
            int damage = robot.attackPower;
            dinosaur health -= damage;
            energyLevel -= 10;

        }


        public void RunGame()
        {

        }
    }
}
            //keep methods seperated

            //rungame method in correect order

            //dress it up