using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;

namespace SortingAlgorithmVisualisation.Formatting
{
    class FormattingDisplay
    {
        public void ShowAllGreen(Graphics graphics, int maxWidth, int maxHeight, int[] elements, int threadDelay)
        {
            if(threadDelay == 200)
            {
                threadDelay = 80;
            }
            else if(threadDelay == 0)
            {
                threadDelay = 1;
            }
            

            for(int i = 0; i < elements.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.ForestGreen), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
                Thread.Sleep(threadDelay);
            }
        }
    }
}
