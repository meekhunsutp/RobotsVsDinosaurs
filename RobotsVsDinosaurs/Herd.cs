using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Herd
    {
        public List<Dinosaur> dinosaursList;
        public Herd()
        {
            dinosaursList = new List<Dinosaur>();
            Dinosaur tRex = new Dinosaur("TRex", 100, 100);
            Dinosaur raptor = new Dinosaur("Raptor", 50, 100);
            Dinosaur ankylo = new Dinosaur("Ankylo", 100, 100);

            dinosaursList.Add(tRex);
            dinosaursList.Add(raptor);
            dinosaursList.Add(ankylo);
        }

        public void PrintDinoInList()
        {
            foreach (Dinosaur dino in dinosaursList)
            {
                Console.WriteLine(dino);
            }
        }

    }
}
