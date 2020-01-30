using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task1
{
    class Book
    {
        public Author Author { get; private set; }
        public string Name { get; private set; }
        public string Text { get; private set; }

        public Book(Author author, string name, string text) 
        {
            Author = author;
            Name = name;
            Text = text;
        }

        public override string ToString()
        {
            return Author.ToString() + " " + Name;
        }
    }
}
