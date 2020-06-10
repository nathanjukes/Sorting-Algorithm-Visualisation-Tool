using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using SortingAlgorithmVisualisation.Formatting;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    public abstract class AlgorithmBase
    {
        public string timeComplexity;
        public string spaceComplexity;
        public Graphics graphics;
        public int maxWidth;
        public int maxHeight;
        public int threadDelay;

        public abstract int elementCount { get; set; }
        public abstract void BeginAlgorithm(int[] elements);

        protected void ShowCompletedDisplay(Graphics graphics, int maxWidth, int maxHeight, int[] elements, int threadDelay)
        {
            FormattingDisplay formatDisplay = new FormattingDisplay();

            formatDisplay.ShowAllGreen(graphics, maxWidth, maxHeight, elements, threadDelay);
        }

        protected void SwapElements(int index1, int index2, int[] elements, int sortType)
        {
            switch(sortType)
            {
                case 0:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    break;
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 2:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 3:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
            }

            Thread.Sleep(threadDelay);

            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

            int tempValue = elements[index1]; //Swaps the elements
            elements[index1] = elements[index2];
            elements[index2] = tempValue;

            switch(sortType)
            {
                default:
                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
                case 1:
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

                    if(GetType().Name.Contains("Selection"))
                    {
                        Thread.Sleep(threadDelay);
                    }
                    
                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    break;
                case 2:
                    graphics.FillRectangle(new SolidBrush(Color.Black), index1 * maxWidth, maxHeight - elements[index1], maxWidth, elements[index1]);
                    graphics.FillRectangle(new SolidBrush(Color.DarkRed), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);

                    Thread.Sleep(threadDelay);

                    graphics.FillRectangle(new SolidBrush(Color.Black), index2 * maxWidth, maxHeight - elements[index2], maxWidth, elements[index2]);
                    break;
            }
        }
    }
}
