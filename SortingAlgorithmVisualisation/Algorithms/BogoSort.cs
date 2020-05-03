using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class BogoSort : AlgorithmBase
    {
        public override int elementCount { get; set; }

        private Graphics graphics;
        private int maxWidth;
        private int maxHeight;
        private int threadDelay;
        private int[] elementsCopy;
        public override void BeginAlgorithm(Graphics _graphics, int _maxWidth, int _maxHeight, int[] elements, int _threadDelay)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            threadDelay = _threadDelay;
            elementsCopy = elements;

            StartBogoSort(elements);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }
        private void StartBogoSort(int[] elements)
        {
            while(!CheckIfSorted(elements))
            {

                
            }
        }

        private bool CheckIfSorted(int[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                if(elements[i] > elements[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
