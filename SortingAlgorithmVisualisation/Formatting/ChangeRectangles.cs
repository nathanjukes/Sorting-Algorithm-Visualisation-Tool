using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SortingAlgorithmVisualisation.Formatting
{
    class ChangeRectangles
    {
        private static Graphics graphics;
        private static int maxWidth, maxHeight;
        private static int[] elements;

        public static void SetData(Graphics _graphics, int _maxWidth, int _maxHeight, int[] _elements)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            elements = _elements;
        }

        public static async Task SwapElements()
        {
            int count = 0;

            foreach (var i in elements)
            {
                await Task.Delay(100);
                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - i, maxWidth, i);
                count++;
            }
        }
    }
}
