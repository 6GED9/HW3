namespace Inter
{
    class Program
    {
        static void Main(string[] args)
        {
            Printable[] printable = new Printable[] {new Book("Репититор", "Чехов"), new Magazine("Forbes", "New York")};
            for (int i = 0; i < printable.Length; i++)
            {
                printable[i].print();
            }
            Magazine.printMagazines(printable);
            Book.printBooks(printable);
            Console.ReadLine();
        }
    }
}
