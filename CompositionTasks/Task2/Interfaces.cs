using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2
{
    interface IInput
    {
        public string GetInput();
    }

    interface IDisplay
    {
        public string Display();
    }

    interface IProcessor
    {
        public string Process();
    }
}
