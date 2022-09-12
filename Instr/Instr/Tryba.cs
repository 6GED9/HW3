using System;
using Microsoft.VisualBasic;

namespace Instr
{
    public class Tryba:Instrument
    {
        int deam;
        public Tryba(int deam)
        {
            this.deam = deam;
        }

        public void play()
        {
            Console.WriteLine("Играет {1} Труба, диаметром {0}.", deam);
        }
    }
}

