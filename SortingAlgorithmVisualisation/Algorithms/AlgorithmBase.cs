using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SortingAlgorithmVisualisation.Formatting;

namespace SortingAlgorithmVisualisation.Algorithms
{
    public abstract class AlgorithmBase
    {
        public abstract int elementCount { get; set; }

        public abstract void BeginAlgorithm(Graphics graphics, int maxWidth, int maxHeight, int[] elements, int threadDelay);

        protected void ShowCompletedDisplay(Graphics graphics, int maxWidth, int maxHeight, int[] elements, int threadDelay)
        {
            FormattingDisplay formatDisplay = new FormattingDisplay();
            formatDisplay.ShowAllGreen(graphics, maxWidth, maxHeight, elements, threadDelay);
        }
    }
}
