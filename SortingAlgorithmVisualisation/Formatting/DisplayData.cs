using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SortingAlgorithmVisualisation.Formatting
{
    class DisplayData
    {
        public Graphics graphics { get; set; }
        public int maxWidth;
        public int maxHeight { get; set; } = 0;
        public int[] elements { get; set; } = null;

        public DisplayData(Graphics _graphics, int _maxWidth, int _maxHeight, int[] _elements)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            elements = _elements;
        }
    }
}
