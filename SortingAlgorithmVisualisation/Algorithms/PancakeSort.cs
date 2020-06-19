using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class PancakeSort : AlgorithmBase
    {
        public override int elementCount { get; set; }
        private int sortedIndex;

        public override void BeginAlgorithm(int[] elements)
        {
            StartPancakeSort(elements);
        }

        private void StartPancakeSort(int[] elements)
        {
            for(int i = elementCount; i > 1; i--)
            {
                int maxIndex = FindMaxIndex(elements, i); //Returns the index of the highest value within a range
                sortedIndex = i;

                if(maxIndex != i)
                {
                    FlipArray(elements, maxIndex); //Flips to the highest index so that [0] is the highest value
                    FlipArray(elements, i - 1); //Flips to make the highest value that was [0] to [i - 1]
                }
            }
        }

        private int FindMaxIndex(int[] elements, int upperLimit)
        {
            int maxIndex = 0;
            int highestValue = 0;

            for(int i = 0; i < upperLimit; i++)
            {
                if(elements[i] > highestValue)
                {
                    maxIndex = i;
                    highestValue = elements[i];
                }
            }

            return maxIndex;
        }

        private void FlipArray(int[] elements, int upperLimit)
        {
            int upperIndex = upperLimit;
            
            for(int i = 0; i < upperLimit; i++)
            {
                int temp = elements[upperIndex];
                elements[upperIndex] = elements[i];
                elements[i] = temp;
                upperIndex--;
            }

            ReDrawDisplay(elements);
        }

        private void ClearDisplay()
        {
            for (int i = 0; i < sortedIndex; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, 0, maxWidth, maxHeight);
            }
        }

        private void ReDrawDisplay(int[] elements)
        {
            ClearDisplay();

            if (threadDelay == 200)
            {
                threadDelay = 80;
            }
            else if (threadDelay == 0)
            {
                threadDelay = 1;
            }

            for (int i = 0; i < sortedIndex; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }

            Thread.Sleep(threadDelay + 20);
        }
    }
}
