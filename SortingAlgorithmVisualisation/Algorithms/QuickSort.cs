using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class QuickSort : AlgorithmBase
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

            QuickSortStart(elements, 0, elements.Length - 1);

            DisplaySort.SortComplete = true;
            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void QuickSortStart(int[] elements, int startIndex, int endIndex)
        {
            if(startIndex >= endIndex)
            {
                return;
            }
            else
            {
                int midIndex = findNextIndex(elements, startIndex, endIndex);

                QuickSortStart(elements, startIndex, midIndex - 1);
                QuickSortStart(elements, midIndex + 1, endIndex);
            }
        }

        private int findNextIndex(int[] elements, int startIndex, int endIndex)
        {
            int pivotValue = elements[endIndex];
            int pivotIndex = startIndex;

            for(int i = pivotIndex; i < endIndex; i++)
            {
                if(elements[i] < pivotValue)
                {
                    SwapElements(elements, i, pivotIndex);
                    pivotIndex++;
                }
            }
            SwapElements(elements, pivotIndex, endIndex);

            return pivotIndex;
        }

        private void SwapElements(int[] elements, int index1, int index2)
        {
            graphics.FillRectangle(new SolidBrush(Color.Red), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(Color.Red), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
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
