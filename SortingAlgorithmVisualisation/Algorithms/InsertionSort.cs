using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class InsertionSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartInsertionSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartInsertionSort(int[] elements)
        {
            for(int i = 1; i < elementCount; i++)
            {
                int compareIndex = i;

                while(elements[compareIndex] < elements[compareIndex - 1])
                {
                    SwapElements(compareIndex - 1, compareIndex, elements, 1);

                    compareIndex--;

                    if(compareIndex == 0)
                    {
                        break;
                    }
                }
            }
        }
    }
}
