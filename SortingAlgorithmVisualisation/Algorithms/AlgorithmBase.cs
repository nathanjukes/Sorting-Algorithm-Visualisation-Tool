using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using SortingAlgorithmVisualisation.Formatting;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    public abstract class AlgorithmBase
    {
        public string timeComplexity;
        public string spaceComplexity;
        public Graphics graphics;
        public int maxWidth;
        public int maxHeight;
        public int threadDelay;

        public abstract int elementCount { get; set; }
        public abstract void BeginAlgorithm(int[] elements);

        public async void ShowCompletedDisplay(int[] elements)
        {
            await Task.Run(() => ShowAllElementsBlue(elements));
        }

        private void ShowAllElementsBlue(int[] elements)
        {
            if (threadDelay == 200)
            {
                threadDelay = 80;
            }
            else if (threadDelay == 0)
            {
                threadDelay = 1;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(83, 153, 182)), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
                Thread.Sleep(threadDelay);
            }
        }

        public void SetComplexity(int complexityRangeValue)
        {
            switch (complexityRangeValue)
            {
                case 0:
                    timeComplexity = "O(nLog(n))";
                    spaceComplexity = "O(1)";
                    break;
                case 1:
                    timeComplexity = "O(nLog(n))";
                    spaceComplexity = "O(Log(n))";
                    break;
                case 2:
                    timeComplexity = "O(nLog(n))";
                    spaceComplexity = "O(n)";
                    break;
                case 3:
                    timeComplexity = "O(nk)";
                    spaceComplexity = "O(n+k)";
                    break;
                case 4:
                    timeComplexity = "O(n²)";
                    spaceComplexity = "O(1)";
                    break;
            }
        }

        protected void SwapElements(int index1, int index2, int[] elements, int sortType)
        {
            switch (sortType)
            {
                case 0:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    break;
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 2:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 3:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
            }

            Thread.Sleep(threadDelay);

            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            int tempValue = elements[index1]; //Swaps the elements
            elements[index1] = elements[index2];
            elements[index2] = tempValue;

            switch (sortType)
            {
                default:
                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

                    if (GetType().Name.Contains("Selection"))
                    {
                        Thread.Sleep(threadDelay);
                    }

                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    break;
                case 2:
                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

                    Thread.Sleep(threadDelay);

                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
            }
        }
    }
}
