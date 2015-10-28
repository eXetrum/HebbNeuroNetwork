using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HebbNeuralNetwork
{
    public partial class mainForm : Form
    {
        static int rows = 5;
        static int cols = 4;
        static int inputCount = 4;
        InputGUI []gui = new InputGUI[inputCount];
        public mainForm()
        {
            InitializeComponent();

            for (int i = 0; i < inputCount; ++i)
            {
                gui[i] = new InputGUI(rows, cols);
                gui[i].SetFreeLocation();
                gui[i].attachTo(inputPanel);
            }
            

            //gui.attachTo(this);
        }

    }
}
