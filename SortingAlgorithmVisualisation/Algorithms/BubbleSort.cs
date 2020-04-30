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
        private int[] elements;
        private int threadDelay;

        public async override void BeginAlgorithm(Graphics graphics, int maxWidth, int maxHeight, int[] _elements, int _threadDelay)
        {
            elements = _elements;
            elementCount = elements.Length;
            threadDelay = _threadDelay;

            await Task.Run(() => Sort(elements, graphics, maxWidth, maxHeight));
        }

        private async void Sort(int[] elements, Graphics graphics, int maxWidth, int maxHeight)
        {
            for (int i = 0; i < elementCount; i++)
            {
                for (int j = 0; j < elementCount - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        int tempValue = elements[j];

                        //If two elements are switching, clear the two current rectangles
                        graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), j * maxWidth, maxHeight - elements[j], maxWidth, elements[j]);
                        graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (j + 1) * maxWidth, maxHeight - elements[j + 1], maxWidth, elements[j + 1]);
           
                        elements[j] = elements[j + 1];
                        elements[j + 1] = tempValue;
                      
                        //Replace the rectangles with the new values
                        graphics.FillRectangle(new SolidBrush(Color.Black), (j) * maxWidth, maxHeight - elements[j], maxWidth, elements[j]);
                        graphics.FillRectangle(new SolidBrush(Color.DarkRed), (j + 1) * maxWidth, maxHeight - elements[j + 1], maxWidth, elements[j + 1]);
                        
                        await Task.Delay(threadDelay);

                        //Replace the sorted rectangle back to black
                        graphics.FillRectangle(new SolidBrush(Color.Black), (j + 1) * maxWidth, maxHeight - elements[j + 1], maxWidth, elements[j + 1]);
                    }
                }
            }

            DisplaySort.SortComplete = true;
            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
        }
    }
}
