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
    class CycleSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        public override void BeginAlgorithm(int[] elements)
        {
            StartCycleSort(elements);
        }

        private void StartCycleSort(int[] elements)
        {
            for(int i = 0; i < elementCount - 1; i++)
            {
                int currentValue = elements[i];
                int index = i + GetLargerThanCount(elements, currentValue, i);

                if(index == i)
                {
                    continue;
                }

                if(currentValue == elements[index])
                {
                    index++;
                }

                int temp = elements[index];
                elements[index] = currentValue;
                currentValue = temp; //Moves to next element
                ReDraw(elements, index);

                while (index != i) //Keeps looping until the next line is i + 0, meaning that the cycle is over
                {
                    index = i + GetLargerThanCount(elements, currentValue, i);

                    while(currentValue == elements[index])
                    {
                        index++;
                    }

                    temp = elements[index];
                    elements[index] = currentValue;
                    currentValue = temp;
                    ReDraw(elements, index);
                }
            }
        }

        private int GetLargerThanCount(int[] elements, int currentValue, int lowerLimit)
        {
            int count = 0;

            for (int j = lowerLimit + 1; j < elementCount; j++)
            {
                if (elements[j] < currentValue)
                {
                    count++;
                }
            }

            return count;
        }

        private void ReDraw(int[] elements, int index)
        {
            for (int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, 0, maxWidth, maxHeight);
                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }

            graphics.FillRectangle(new SolidBrush(Color.DarkRed), index * maxWidth, maxHeight - elements[index], maxWidth, elements[index]);
            Thread.Sleep(threadDelay);
        }
    }
}
