using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class Projector : IDisplay
    {
        private string Name { get; set; }

        public Projector(string name)
        {
            Name = name;
        }

        public string Display()
        {
            return "Projector " + Name;
        }

    }
}
