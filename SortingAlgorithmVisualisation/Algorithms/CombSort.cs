using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class CombSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            StartCombSort(elements);
        }

        private void StartCombSort(int[] elements)
        {
            int gap = elementCount;

            for (int i = 0; i < elementCount; i++)
            {
                for (int j = 0; j < elementCount; j++)
                {
                    if ((j + gap) < elementCount && elements[j] > elements[j + gap])
                    {
                        SwapElements(j, j + gap, elements, 1);
                    }
                }

                gap = Convert.ToInt32(Math.Floor(gap / 1.3));

                if (gap == 0)
                {
                    gap = 1;
                }
            }
        }
    }
}
