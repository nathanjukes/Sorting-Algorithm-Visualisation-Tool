using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class BubbleSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            StartBubbleSort(elements);
        }

        private void StartBubbleSort(int[] elements)
        {
            for (int i = 0; i < elementCount; i++)
            {
                for (int j = 0; j < elementCount - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        SwapElements(j, j + 1, elements, 0);
                    }
                }
            }
        }
    }
}
