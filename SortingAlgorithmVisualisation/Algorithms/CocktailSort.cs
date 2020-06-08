using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class CocktailSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            elementCount = elements.Length;

            StartCocktailSort(elements);

            DisplaySort.SortComplete = true;

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        private void StartCocktailSort(int[] elements)
        {
            for(int i = 0; i < elementCount; i++)
            {
                for(int j = 0; j < elementCount - 1; j++) //Bubble sort up to max
                {
                    if(elements[j] > elements[j + 1])
                    {
                        SwapElements(j, j + 1, elements, 0);
                    }
                }

                for (int k = elementCount - 1; k > 0; k--) //Bubble sort reversed to sort minimums
                {
                    if (elements[k] < elements[k - 1])
                    {
                        SwapElements(k, k - 1, elements, 0);
                    }
                }
            }    
        }
    }
}
