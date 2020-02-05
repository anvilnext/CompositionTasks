using CompositionTasks.Task1;
using CompositionTasks.Task2;
using CompositionTasks.Task2.Processors;
using System;

namespace CompositionTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //-------------------------------------------------------------------
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
            //-------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine();

            //Task2
            //-------------------------------------------------------------------
            Mouse M1 = new Mouse("mouse");
            ExternalDisplay E1 = new ExternalDisplay("ext");
            ArmProcessor Arm1 = new ArmProcessor("arm");

            Computer Comp1 = new Computer(M1, E1, Arm1);

            Console.WriteLine(Comp1.Work());
            //-------------------------------------------------------------------
        }
    }
}
