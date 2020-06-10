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
            elementCount = elements.Length;

            Sort(elements, graphics, maxWidth, maxHeight);

            DisplaySort.SortComplete = true;
        }

        private void Sort(int[] elements, Graphics graphics, int maxWidth, int maxHeight)
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

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }
    }
}
