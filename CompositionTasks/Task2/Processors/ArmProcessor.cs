using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2.Processors
{
    class ArmProcessor : IProcessor
    {
        private string Name { get; set; }

        public ArmProcessor(string name)
        {
            Name = name;
        }

        public string Process()
        {
            return "ARM Processor " + Name;
        }
    }
}
