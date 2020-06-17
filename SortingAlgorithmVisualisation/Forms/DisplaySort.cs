using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using SortingAlgorithmVisualisation.Algorithms;
using SortingAlgorithmVisualisation.Formatting;
using System.CodeDom;

namespace SortingAlgorithmVisualisation
{
    public partial class DisplaySort : Form
    {
        public static bool SortComplete = false;

        private int elementCount;
        private int threadDelay;
        private int[] elements;
        private string setModifier;

        private AlgorithmBase algorithm;

        public DisplaySort(int _elementCount, int _threadDelay, AlgorithmBase _algorithm, string _setModifier)
        {
            InitializeComponent();

            elementCount = _elementCount;
            threadDelay = _threadDelay;
            algorithm = _algorithm;
            setModifier = _setModifier.Replace(" ", "").ToLower();

            SetUpFormData(_setModifier);
        }

        private async void AlgorithmPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = algorithmPanel.CreateGraphics();

            int maxWidth = algorithmPanel.Width / elementCount;  //Width of each 
            int maxHeight = algorithmPanel.Height; //Max Height of the panel

            elements = DataGeneration.GetData(maxHeight, elementCount, setModifier);

            for (int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }

            algorithm.maxWidth = maxWidth;
            algorithm.maxHeight = maxHeight;
            algorithm.graphics = graphics;
            algorithm.elementCount = elements.Length;

            Thread.Sleep(500);

            await Task.Run(() => BeginSorting(graphics, maxWidth, maxHeight, elements));

            SortComplete = true;
            algorithm.ShowCompletedDisplay(elements);
        }

        private void BeginSorting(Graphics graphics, int maxWidth, int maxHeight, int[] elements)
        {
            algorithm.BeginAlgorithm(elements);
        }

        private void DisplaySort_FormClosed(object sender, FormClosedEventArgs e)
        {
            Thread.Sleep(100);
            Application.Restart();
        }

        private void SetUpFormData(string _setModifier)
        {
            //Setting form components to their proper title
            string algorithmName = algorithm.GetType().Name;
            tComplexityLabel.Text += algorithm.timeComplexity;
            sComplexityLabel.Text += algorithm.spaceComplexity;
            algorithmLabel.Text += $"{algorithmName} ({elementCount} values)";
            arraySettingLabel.Text += _setModifier;

            if (algorithmName.Contains("Heap") || algorithmName.Contains("Selection"))
            {
                secondDelay.Text += threadDelay * 2 + "ms";
            }
            else if (algorithmName.Contains("Radix"))
            {
                secondDelay.Text += threadDelay + 700 + "ms";
            }
            else if(algorithmName.Contains("Tree"))
            {
                secondDelay.Text += threadDelay + 220 + "ms";
            }
            else
            {
                secondDelay.Text += threadDelay + "ms";
            }
        }

        protected override void WndProc(ref Message message) //Prevents movement of the display while the algorithm is taking place - fixes GDI crashes
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                    {
                        return;
                    }
                    break;
            }

            base.WndProc(ref message);
        }
    }
}
