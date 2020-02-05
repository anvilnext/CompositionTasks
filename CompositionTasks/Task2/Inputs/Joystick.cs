using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class Joystick : IInput
    {
        private string Name { get; set; }

        public Joystick(string name)
        {
            Name = name;
        }

        public string GetInput()
        {
            return "Joystick " + Name;
        }
    }
}
