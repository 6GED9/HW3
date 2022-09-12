using System;
namespace Inter
{
    public class Magazine : Printable
    {
        string author;
        string name;
        public Magazine(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public void print()
        {
            Console.WriteLine("{0}, {1}", author, name);
        }

        public static void printMagazines(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Book)
                {
                    printable[i].print();
                }
            }
        }
    }
}

