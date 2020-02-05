using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class Mouse : IInput
    {
        private string Name { get; set; }

        public Mouse(string name)
        {
            Name = name;
        }

        public string GetInput()
        {
            return "Mouse " + Name;
        }
    }
}
