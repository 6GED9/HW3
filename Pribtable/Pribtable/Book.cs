using System;
namespace Inter
{
    public class Book:Printable
    {
        string author;
        string name;
        public Book(string name, string author)
        {
            this.name = name;
            this.author = author;
        }

        public void print()
        {
            Console.WriteLine("{0}, {1}", author, name);
        }
        public static void printBooks(Printable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Magazine)
                {
                    printable[i].print();
                }
            }
        }
    }
}

