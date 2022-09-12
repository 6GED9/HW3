namespace Instr
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] instruments = new Instrument[] { new Gitar(6), new Baraban(5), new Tryba(3) };
            for(int i = 0; i<instruments.Length; i++)
            {
                instruments[i].play();
            }
            Console.ReadLine();
        }
    }
}