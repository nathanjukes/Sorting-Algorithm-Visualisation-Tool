using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class OddEvenSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartOddEvenSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartOddEvenSort(int[] elements)
        {
            for(int i = 0; i < (elementCount / 2) + 1; i++)
            {
                SortOddOrEven(elements, 1);

                SortOddOrEven(elements, 0);
            }
        }

        private void SortOddOrEven(int[] elements, int modOffset)
        {
            for(int i = 0; i < elementCount; i++)
            {
                if(i % 2 == modOffset)
                {
                    if(i + 1 < elementCount && elements[i] > elements[i + 1])
                    {
                        SwapElements(i, i + 1, elements, 0);
                    }
                }
            }
        }
    }
}
