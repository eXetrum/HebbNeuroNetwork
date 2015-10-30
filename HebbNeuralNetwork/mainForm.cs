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
        // Интерфейс ввода символов
        InputGUI[] inputGUI = new InputGUI[standartInputCount + 1];
        // Символы
        string[] CHARS = { "P", "O", "K", "E" };
        // Биполярное представление букв
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
        // Создаем нейронную сеть
        NeuroNetwork nn = new NeuroNetwork();

        public mainForm()
        {
            InitializeComponent();
            // Создаем интерфейс ввода
            for (int i = 0; i < standartInputCount; ++i)
            {
                // Интерфейс сетка rows X cols
                inputGUI[i] = new InputGUI(rows, cols);
                // Добавляем новый gui в коллекцию элементов панели
                inputGUI[i].attachTo(standartInputPanel);
                // Задаем изображение
                inputGUI[i].SetImage(M[i]);
            }
            // Последний gui оставим для ввода пользовательского изображения
            inputGUI[inputGUI.Length - 1] = new InputGUI(rows, cols);
            // Прикрепляем gui
            inputGUI[inputGUI.Length - 1].attachTo(userInputPanel, true);
            // Изображение пользователя
            int[] userX = new int[rows * cols];
            // 
            Random rnd = new Random(DateTime.Now.Millisecond);
            // Заполним вектор изображения случ. данными
            for (int i = 0; i < rows * cols; ++i) userX[i] = (rnd.Next(0, 2) == 0 ? 1 : -1);
            // Заносим изображение
            inputGUI[inputGUI.Length - 1].SetImage(userX);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            // Задаем логгер для вывода промежуточных шагов состояний сети
            NeuroNetwork.log = log;
            // Множество пар: изображение - ожидаемый выходной вектор сети (Тренировочная выборка)
            List<NeuroNetwork.PairSet> m = new List<NeuroNetwork.PairSet>();           
            // Считываем данные о всех изображениях
            for(int i = 0; i < standartInputCount; ++i) 
            {
                m.Add(new NeuroNetwork.PairSet()
                {
                    image = inputGUI[i].GetImage(),
                    t = new int[standartInputCount]
                });
                // Ожидаемый выходной вектор сети для текущего изображения
                for (int ti = 0; ti < standartInputCount; ++ti)
                    m[i].t[ti] = -1;
                m[i].t[i] = 1;
            }
            // Обучаем сеть
            nn.Train(rows * cols, standartInputCount, m);
            // Включаем возможность распознования только после обучения сети
            btnRecognize.Enabled = true;
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            // Получаем пользовательское изображение для распознавания
            int[] userImage = inputGUI[inputGUI.Length - 1].GetImage();
            // Отдаем изображение для распознавания - получаем выходной вектор
            int[] userImageResult = nn.Recognize(userImage);
            // Находим максимум среди выходных значений сети
            int maxid = 0;
            int max = userImageResult[0];
            for (int i = 1; i < userImageResult.Length; ++i)
                if (userImageResult[maxid] < userImageResult[i]) 
                {
                    maxid = i;
                    max = userImageResult[i];
                }
            
            List<string> result = new List<string>();
            for (int i = 0; i < userImageResult.Length; ++i)
                // Добавляем все вероятные символы (если таковых множество)
                if (userImageResult[i] == max) result.Add(CHARS[i]);
            // Формируем результат - строку
            string resultSTR = "";
            for (int i = 0; i < result.Count; ++i)
                resultSTR += result[i] + (i + 1 < result.Count ? ", " : "");
            // Отладочная информация
            for (int i = 0; i < userImageResult.Length; ++i)
                log.AppendText(userImageResult[i] + " ");
            log.AppendText(Environment.NewLine);
            // Вывод результата
            log.AppendText("Вероятный символ: " + resultSTR + Environment.NewLine);
        }

    }
}
