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

        private int leftOffset = 1;
        private int rightOffset = 2;
        private int sortedLength;

        public override void BeginAlgorithm(int[] elements)
        {
            sortedLength = elementCount;

            if (elementCount % 2 == 0)
            {
                leftOffset--;
                rightOffset--;
            }

            Heapify(elements);

            DeleteElements(elements);
        }

        private void Heapify(int[] elements)
        {
            for(int i = 0; i < 2; i++)
            {
                for (int j = (elementCount / 2) - 1; j >= 0; j--)
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

                    if (highestIndex.HasValue)
                    {
                        if (elements[Convert.ToInt32(highestIndex)] > elements[j])
                        {
                            SwapElements(j, Convert.ToInt32(highestIndex), elements, 2);
                        }
                    }
                }
            }
        }

        private void DeleteElements(int[] elements)
        {
            for (int i = elementCount - 1; i >= 0; i--)
            {
                SwapElements(0, i, elements, 2);

                sortedLength--;

                Heapify(elements);
            }

            if (elements[0] > elements[1])
            {
                SwapElements(0, 1, elements, 2);
            }
        }
    }
}
