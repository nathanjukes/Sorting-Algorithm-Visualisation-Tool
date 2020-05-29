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
    class CocktailSort : AlgorithmBase
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

            StartCocktailSort(elements);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartCocktailSort(int[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                for(int j = 0; j < elements.Length - 1; j++) //Bubble sort up to max
                {
                    if(elements[j] > elements[j + 1])
                    {
                        SwapElements(elements, j, j + 1);
                    }
                }

                for (int k = elements.Length - 1; k > 0; k--) //Bubble sort reversed to sort minimums
                {
                    if (elements[k] < elements[k - 1])
                    {
                        SwapElements(elements, k, k - 1);
                    }
                }
            }    
        }

        private void SwapElements(int[] elements, int index1, int index2)
        {
            graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);

            Thread.Sleep(threadDelay);

            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            int tempValue = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = tempValue;

            graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
        }
    }
}
