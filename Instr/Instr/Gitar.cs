using System;

namespace Instr
{
    public class Gitar:Instrument
    {
        int stryns;
        public Gitar(int stryns)
        {
            this.stryns = stryns;
        }

        public void play()
        {
            Console.WriteLine("Играет Гитара, количество струн {0}.", stryns);
        }
    }
}

