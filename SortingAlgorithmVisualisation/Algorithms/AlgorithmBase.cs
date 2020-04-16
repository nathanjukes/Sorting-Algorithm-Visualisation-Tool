using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SortingAlgorithmVisualisation.Algorithms
{
    public abstract class AlgorithmBase
    {
        public abstract void BeginAlgorithm(Graphics graphics, int maxHeight, int maxWidth, int[] elements);
    }
}
