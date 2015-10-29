using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HebbNeuralNetwork
{
    class Neuron
    {
        public Neuron(int inputs, int outputs) 
        {
            X = new int[inputs];
            W = new int[inputs];
            W[0] = 1;
        }
        public void FeedNeuron(int[] x)
        {
            for (int i = 0; i < X.Length; ++i)
                X[i] = x[i];
        }
        // Корректировка весов
        public void Correct(int y)
        {
            for (int i = 0; i < W.Length; ++i)
            {
                /*
                int dw = 0;
                if (X[i] * y == 1)
                    dw = 1;
                else if (X[i] == -1)
                    dw = 0;
                else if (y == -1)
                    dw = -1;*/
                W[i] += X[i] * y;
            }
        }
        // Биполярная функция активации
        public int Output()
        {
            int sum = 0;
            for (int i = 0; i < X.Length; ++i)
                sum += W[i] * X[i];
            return sum + 1 > 0 ? 1 : -1;
        }
        // Взвешенная сумма
        public int OutputSum()
        {
            int sum = 0;
            for (int i = 0; i < X.Length; ++i)
                sum += W[i] * X[i];
            return sum + 1;
        }
        // Данные входного изображения
        public int[] X { get; set; }
        // Веса связей нейрона
        public int[] W { get; set; }
    }
}
