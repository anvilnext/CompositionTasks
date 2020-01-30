using CompositionTasks.Task1;
using System;

namespace CompositionTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Author A1 = new Author("Oleksii", "Cherevatenko");
            Console.WriteLine(A1.ToString());
        }
    }
}
