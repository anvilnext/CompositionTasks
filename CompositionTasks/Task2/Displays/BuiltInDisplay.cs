using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class BuiltInDisplay : IDisplay
    {
        private string Name { get; set; }

        public BuiltInDisplay(string name)
        {
            Name = name;
        }

        public string Display()
        {
            return "Built-In Display " + Name;
        }
    }
}
