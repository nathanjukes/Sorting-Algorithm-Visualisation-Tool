using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class GnomeSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartGnomeSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartGnomeSort(int[] elements)
        {
            for(int i = 0; i < elementCount; i++)
            {

                if(i + 1 < elementCount && i >= 0 && elements[i] > elements[i + 1])
                {
                    SwapElements(i, i + 1, elements, 1);
                    i--;
                    i--;
                }
            }
        }
    }
}
