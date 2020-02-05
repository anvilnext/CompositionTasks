using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class Keyboard : IInput
    {
        private string Name { get; set; }

        public Keyboard(string name)
        {
            Name = name;
        }

        public string GetInput()
        {
            return "Keyboard " + Name;
        }
    }
}
