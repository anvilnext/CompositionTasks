using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionTasks.Task2.Processors
{
    class Amd64Processor : IProcessor
    {
        private string Name { get; set; }

        public Amd64Processor(string name)
        {
            Name = name;
        }

        public string Process()
        {
            return "AMD64 Processor " + Name;
        }
    }
}
