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
        InputGUI[] inputGUI = new InputGUI[standartInputCount + 1];

        string[] CHARS = { "P", "O", "K", "E" };

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
        NeuroNetwork nn = new NeuroNetwork();
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

        private void btnTrain_Click(object sender, EventArgs e)
        {
            btnRecognize.Enabled = true;
            NeuroNetwork.log = log;
            
            List<NeuroNetwork.PairSet> m = new List<NeuroNetwork.PairSet>();

            
            
            for(int i = 0; i < standartInputCount; ++i) 
            {
                m.Add(new NeuroNetwork.PairSet()
                {
                    image = inputGUI[i].GetImage(),
                    t = new int[standartInputCount]
                });

                for (int ti = 0; ti < standartInputCount; ++ti)
                    m[i].t[ti] = -1;
                m[i].t[i] = 1;
            }
            nn.Train(rows * cols, standartInputCount, m);

            
            

        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            int[] userImage = inputGUI[inputGUI.Length - 1].GetImage();
            int[] o = nn.Recognize(userImage);

            
            int maxid = 0;
            int max = o[0];
            for (int i = 1; i < o.Length; ++i)
                if (o[maxid] < o[i]) 
                {
                    maxid = i;
                    max = o[i];
                }

            
            List<string> result = new List<string>();
            for (int i = 0; i < o.Length; ++i)
                if (o[i] == max) result.Add(CHARS[i]);

            string resultSTR = "";
            for (int i = 0; i < result.Count; ++i)
                resultSTR += result[i] + (i + 1 < result.Count ? ", " : "");

            for (int i = 0; i < o.Length; ++i)
                log.AppendText(o[i] + " ");
            log.AppendText(Environment.NewLine);

            log.AppendText("Вероятный символ: " + resultSTR + Environment.NewLine);
        }

    }
}
