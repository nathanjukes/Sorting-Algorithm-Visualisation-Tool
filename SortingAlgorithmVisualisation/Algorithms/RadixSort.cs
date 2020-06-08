using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class RadixSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        private string[] elementDuplicates;
        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            DisplaySort.SortComplete = true;

            StartRadixSort(elements);
        }

        private void StartRadixSort(int[] elements)
        {
            for (int i = 1; i < 4; i++)
            {
                Thread.Sleep(700);

                ClearDisplay(elements);
                CountSort(elements, i);

                //Redraw all elements
                ReDrawDisplay(elements);
            }

            Thread.Sleep(220);
            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void CountSort(int[] elements, int LengthToMinus)
        {
            elementDuplicates = new string[10];

            for (int i = 0; i < elementCount; i++)
            {
                string currentElement = elements[i].ToString();

                switch (currentElement.Length)
                {
                    case 2:
                        currentElement = $"0{currentElement}";
                        break;
                    case 1:
                        currentElement = $"00{currentElement}";
                        break;
                }

                int currentIndex = Convert.ToInt32(currentElement[currentElement.Length - LengthToMinus].ToString());
                elementDuplicates[currentIndex] = elementDuplicates[currentIndex] + $"{currentElement},";
            }

            int elementsIndex = 0;

            for (int i = 0; i < 10; i++)
            {
                if (elementDuplicates[i] != null)
                {
                    string[] split = elementDuplicates[i].Split(',');

                    for (int j = 0; j < split.Length - 1; j++)
                    {
                        elements[elementsIndex] = Convert.ToInt32(split[j]);
                        elementsIndex++;
                    }
                }
            }
        }

        private void ClearDisplay(int[] elements)
        {
            for(int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, 0, maxWidth, maxHeight);
            }
        }

        private void ReDrawDisplay(int[] elements)
        {
            if (threadDelay == 200)
            {
                threadDelay = 80;
            }
            else if (threadDelay == 0)
            {
                threadDelay = 1;
            }

            for (int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
                Thread.Sleep(threadDelay);
            }
        }
    }
}
