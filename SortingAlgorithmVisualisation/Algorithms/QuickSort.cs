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

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;
            QuickSortStart(elements, 0, elementCount - 1);

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
                    SwapElements(i, pivotIndex, elements, 3);
                    pivotIndex++;
                }
            }
            SwapElements(pivotIndex, endIndex, elements, 3);

            return pivotIndex;
        }
    }
}
