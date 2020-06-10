using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class ShellSort : AlgorithmBase
    {
        public override int elementCount { get; set; }
        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartShellSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartShellSort(int[] elements)
        {
            bool loopBack = false;
            int gap = elementCount / 2;

            for (int i = 0; i < elementCount; i++)
            {
                gap = gap / 2;
                
                for (int j = 0; j < elementCount; j++)
                {
                    if(gap < elementCount / 2 && loopBack)
                    {
                        j = j - gap - 1;
                        loopBack = false;
                    }

                    if ((j + gap) < elementCount && j >= 0 && elements[j] > elements[j + gap])
                    {
                        SwapElements(j, j + gap, elements, 1);
                        
                        if(gap < elementCount / 2)
                        {
                            loopBack = true;
                        }
                    }
                }
            }
        }
    }
}
