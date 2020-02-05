using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task1
{
    class Library
    {
        private List<Book> LibraryCollection = new List<Book>();

        public void AddBook(Book B)
        {
            LibraryCollection.Add(B);
        }

        public void RemoveBook(Book B)
        {
            LibraryCollection.Remove(B);
        }

        public int GetNum()
        {
            return LibraryCollection.Count;
        }

        private void Print(Book obj)
        {
            Console.WriteLine(obj.ToString());
        }

        public void ShowList()
        {
            LibraryCollection.ForEach(Print);    
        }
    }
}
