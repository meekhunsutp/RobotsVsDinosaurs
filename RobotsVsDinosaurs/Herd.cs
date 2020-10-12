using System.Collections.Generic;
using System.ComponentModel;

namespace RobotsVsDinosaurs
{
    class Herd
    {
        //HAS A
        List<Dinosaur> dinosaurs = new List<Dinosaur>();

        Dinosaur tRex = new Dinosaur("TRex", 100, 50, "Chomp", 100);
        Dinosaur raptor = new Dinosaur("Raptor", 50, 50, "Claw", 50);
        Dinosaur ankylo = new Dinosaur("Ankylo", 100, 50, "Tailspin", 100);

        //SPAWNS
        public Herd()
        {
            dinosaurs.Add(tRex);
            dinosaurs.Add(raptor);
            dinosaurs.Add(ankylo);

        }



        //CAN DO




    }
}
