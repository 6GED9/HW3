using System;
using Microsoft.VisualBasic;

namespace Instr
{
    public class Baraban:Instrument
    {
        int size;
        public Baraban(int size)
        {
            this.size = size;
        }

        public void play()
        {
            Console.WriteLine("Играет Барабан, размером {0}.", size);
        }
    }
}

