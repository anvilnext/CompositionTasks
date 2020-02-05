using CompositionTasks.Task1;
using System;

namespace CompositionTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Author A1 = new Author("Oleksii", "Cherevatenko");
            Author A2 = new Author("Taras", "Shevchenko");

            Book B1 = new Book(A1, "C#", "some text");
            Book B2 = new Book(A2, "Zapovit", "sample");
            Book B3 = new Book(A2, "Kobzar", "sample text");

            Library L1 = new Library();
            L1.AddBook(B1);
            L1.AddBook(B2);
            L1.AddBook(B3);

            Console.WriteLine(L1.GetNum());
            L1.ShowList();
        }
    }
}
