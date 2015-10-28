using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebbNeuralNetwork
{
    class Neuron
    {
        public Neuron() { }

        public int[] Input { private get; set; }
        public int[] Output { get; private set; }
    }
}
