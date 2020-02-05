using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class ExternalDisplay : IDisplay
    {
        private string Name { get; set; }

        public ExternalDisplay(string name)
        {
            Name = name;
        }

        public string Display()
        {
            return "External Display " + Name;
        }
    }
}
