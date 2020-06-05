using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Formatting
{
    class DataGeneration
    {
        private static int elementCount;
        private static Random rnd = new Random();

        public static int[] GetData(int maxHeight, int _elementCount, string setModifier)
        {
            elementCount = _elementCount;

            int[] elements = new int[elementCount];

            switch (setModifier)
            {
                case "standard":
                    return StandardGeneration(elements, 1, maxHeight);
                case "smallonly":
                    return StandardGeneration(elements, 1, maxHeight / 3);
                case "mediumonly":
                    return StandardGeneration(elements, (maxHeight * 3) / 8, (maxHeight * 5) / 8);
                case "largeonly":
                    return StandardGeneration(elements, (maxHeight * 2) / 3, maxHeight);
                case "fewunique":
                    return FewUniqueGeneration(elements, maxHeight);
                case "reversed":
                    elements = StandardGeneration(elements, 1, maxHeight);
                    Array.Sort(elements); //Would have used my Quick Sort method but it would display the sort (May fix later)
                    elements = elements.Reverse().ToArray();
                    return elements;
                case "smallrange":
                    int lowerLimit = rnd.Next(1, maxHeight - 50);
                    return StandardGeneration(elements, lowerLimit, lowerLimit + 50);
                case "mirroredhalves":
                    return MirroredGeneration(elements, maxHeight);
            }

            return elements;
        }

        private static int[] StandardGeneration(int[] elements, int lowerLimit, int upperLimit)
        {
            for (int i = 0; i < elementCount; i++)
            {
                int currentHeight = rnd.Next(lowerLimit, upperLimit); //Current Height is the value or weight of the rectangle
                elements[i] = currentHeight;
            }

            return elements;
        }

        private static int[] FewUniqueGeneration(int[] elements, int upperLimit)
        {
            int uniqueCount = 4;

            switch (elementCount) //Determines how many unique elements so that it looks good on the display
            {
                case 57:
                    uniqueCount = 6;
                    break;
                case 190:
                    uniqueCount = 8;
                    break;
                case 380:
                    uniqueCount = 12;
                    break;
                case 570:
                    uniqueCount = 16;
                    break;
                case 1140:
                    uniqueCount = 22;
                    break;
            }

            //Generate X amount of unique elements 
            int[] uniqueElements = new int[uniqueCount];

            for (int i = 0; i < uniqueCount; i++)
            {
                uniqueElements[i] = rnd.Next(1, upperLimit);
            }

            //Randomly assign them throughout the array, results in the same element being present multiple times, resulting in few unique elements
            for (int i = 0; i < elementCount; i++)
            {
                elements[i] = uniqueElements[rnd.Next(0, uniqueCount)];
            }

            return elements;
        }

        private static int[] MirroredGeneration(int[] elements, int upperLimit)
        {
            for(int i = 0; i < elementCount; i++)
            {
                if (i != elementCount - i)
                {
                    int value = rnd.Next(1, upperLimit);
                    elements[i] = value;
                    elements[elementCount - i - 1] = value;
                }
                else
                {
                    return elements;
                }
            }

            return elements;
        }
    }
}
