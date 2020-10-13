using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //HAS A
        List<Dinosaur> dinosaurs;



        //SPAWNS
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            Dinosaur tRex = new Dinosaur("TRex", 100, 50, "Chomp", 100);
            Dinosaur raptor = new Dinosaur("Raptor", 50, 50, "Claw", 50);
            Dinosaur ankylo = new Dinosaur("Ankylo", 100, 50, "Tailspin", 100);

            dinosaurs.Add(tRex);
            dinosaurs.Add(raptor);
            dinosaurs.Add(ankylo);

            //int[] dinoAttacks = new int[3] { 100, 50, 25 };
            //int[] dinoAttacks = new int[3];
            //dinoAttacks[0] = 100; //chomp
            //dinoAttacks[1] = 50; //tailspin
            //dinoAttacks[2] = 25; //claw

        }



        //CAN DO




    }
}
