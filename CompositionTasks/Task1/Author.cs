using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task1
{
    class Author
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }

        public Author(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }

        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }
}
