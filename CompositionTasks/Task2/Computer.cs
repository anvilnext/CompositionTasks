using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    class Computer
    {
        private IInput Input;
        private IDisplay Display;
        private IProcessor Processor;

        public Computer(IInput input, IDisplay display, IProcessor processor)
        {
            Input = input;
            Display = display;
            Processor = processor;
        }

        public string Work()
        {
            return "Computer consists of: " + Input.GetInput() + ", " + Display.Display() + ", " + Processor.Process(); ;
        }
    }
}
