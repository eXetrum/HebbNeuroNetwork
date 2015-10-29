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

        // Данные входного изображения
        public int[] X { get; set; }
        // Веса связей нейрона
        public int[] W { get; set; }
    }
}
