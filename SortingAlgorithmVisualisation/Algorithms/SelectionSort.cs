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

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartSelectionSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartSelectionSort(int[] elements)
        {
            for(int i = 0; i < elementCount; i++)
            {
                int currentMin = elements[i];
                int currentIndex = i;

                for(int j = i + 1; j < elementCount; j++)
                {
                    if (elements[j] < currentMin)
                    {
                        currentMin = elements[j];
                        currentIndex = j;
                    }

                    if (j == elementCount - 1)
                    {
                        SwapElements(i, currentIndex, elements, 1);
                    }
                }
            }
        }
    }
}
