using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class SelectionSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        private Graphics graphics;
        private int maxWidth;
        private int maxHeight;
        private int threadDelay;
        public override void BeginAlgorithm(Graphics _graphics, int _maxWidth, int _maxHeight, int[] elements, int _threadDelay)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            threadDelay = _threadDelay;

            StartSelectionSort(elements);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartSelectionSort(int[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                int currentMin = elements[i];
                int currentIndex = i;

                for(int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[j] < currentMin)
                    {
                        currentMin = elements[j];
                        currentIndex = j;
                    }

                    if (j == elements.Length - 1)
                    {
                        SwapElements(elements, i, currentIndex);
                    }
                }
            }
        }

        private void SwapElements(int[] elements, int index1, int index2)
        {
            graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            Thread.Sleep(threadDelay);

            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
          
            int tempValue = elements[index1]; //Swaps the elements
            elements[index1] = elements[index2];
            elements[index2] = tempValue;

            graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
        }
    }
}
