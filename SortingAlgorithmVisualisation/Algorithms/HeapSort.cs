using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class HeapSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        private Graphics graphics;
        private int maxWidth;
        private int maxHeight;
        private int threadDelay;

        private int leftOffset = 1;
        private int rightOffset = 2;
        private int sortedLength;

        public override void BeginAlgorithm(Graphics _graphics, int _maxWidth, int _maxHeight, int[] elements, int _threadDelay)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            threadDelay = _threadDelay;

            sortedLength = elements.Length;

            if(elements.Length % 2 == 0)
            {
                leftOffset--;
                rightOffset--;
            }

            Heapify(elements);

            DeleteElements(elements);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void Heapify(int[] elements)
        {
            for(int i = 0; i < elements.Length / 3; i++)
            {
                for(int j = (elements.Length / 2) - 1; j >= 0; j--)
                {
                    int? highestIndex = null;
                    int leftIndex = (j * 2) + leftOffset;
                    int rightIndex = (j * 2) + rightOffset;

                    if (elements[leftIndex] >= elements[rightIndex] && leftIndex < sortedLength)
                    {
                        highestIndex = leftIndex;
                    }

                    if (elements[leftIndex] <= elements[rightIndex] && rightIndex < sortedLength)
                    {
                        highestIndex = rightIndex;
                    }

                    if(highestIndex.HasValue)
                    {
                        if (elements[Convert.ToInt32(highestIndex)] > elements[j])
                        {
                            SwapElements(j, Convert.ToInt32(highestIndex), elements);
                        }
                    }
                }
            }
        }

        private void DeleteElements(int[] elements)
        {
            for(int i = elements.Length - 1; i >= 0; i--)
            {
                SwapElements(0, i, elements);

                sortedLength--;

                Heapify(elements);
            }

            if(elements[0] > elements[1])
            {
                SwapElements(0, 1, elements);
            }
        }

        private void SwapElements(int index1, int index2, int[] elements)
        {
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            int tempValue = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = tempValue;

            graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            Thread.Sleep(threadDelay);

            graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
        }
    }
}
