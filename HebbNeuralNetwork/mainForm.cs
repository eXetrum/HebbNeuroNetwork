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
        static int standartInputCount = 4;
        //static int userInputCount = 1;
        InputGUI[] inputGUI = new InputGUI[standartInputCount + 1];

        List<int[]> M = new List<int[]>() {
            // Буква "Р"
            new int[] {
                1, 1, 1, -1,
                1, -1, -1, 1,
                1, 1, 1, -1,
                1, -1, -1, -1,
                1, -1, -1, -1
            }, 
            // Буква "О"
            new int[] {
                -1, 1, 1, -1, 
                1, -1, -1, 1,
                1, -1, -1, 1,
                1, -1, -1, 1,
                -1, 1, 1, -1
            },
            // Буква "К"
            new int[] {
                1, -1, -1, 1, 
                1, -1, 1, -1,
                1, 1, -1, -1,
                1, -1, 1, -1,
                1, -1, -1, 1
            },
            // Буква "Е"
            new int[] {
                1, 1, 1, 1, 
                1, -1, -1, -1,
                1, 1, 1, -1,
                1, -1, -1, -1,
                1, 1, 1, 1
            }
        };

        public mainForm()
        {
            InitializeComponent();

            for (int i = 0; i < standartInputCount; ++i)
            {
                inputGUI[i] = new InputGUI(rows, cols);
                inputGUI[i].attachTo(standartInputPanel);
                inputGUI[i].SetImage(M[i]);
            }

            inputGUI[inputGUI.Length - 1] = new InputGUI(rows, cols);
            inputGUI[inputGUI.Length - 1].attachTo(userInputPanel, true);

            int[] userX = new int[rows * cols];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < rows * cols; ++i) userX[i] = (rnd.Next(0, 2) == 0 ? 1 : -1);

            inputGUI[inputGUI.Length - 1].SetImage(userX);

        }

    }
}
