using System;
using System.Collections.Generic;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        //HAS A
        public List<Dinosaur> dinosaursList;



        //SPAWNS
        public Herd()
        {
            dinosaursList = new List<Dinosaur>();
            Dinosaur tRex = new Dinosaur("TRex", 100, 100, "Chomp", 100);
            Dinosaur raptor = new Dinosaur("Raptor", 50, 100, "Claw", 50);
            Dinosaur ankylo = new Dinosaur("Ankylo", 100, 100, "Tailspin", 100);

            dinosaursList.Add(tRex);
            dinosaursList.Add(raptor);
            dinosaursList.Add(ankylo);

            //int[] dinoAttacks = new int[3] { 100, 50, 25 };
            //int[] dinoAttacks = new int[3];
            //dinoAttacks[0] = 100; //chomp
            //dinoAttacks[1] = 50; //tailspin
            //dinoAttacks[2] = 25; //claw
   
        }

        public void PrintDinoInList()
        {
            foreach (Dinosaur dino in dinosaursList)
            {
                Console.WriteLine(dino);
            }
        }
        
        //CAN DO




    }
}
