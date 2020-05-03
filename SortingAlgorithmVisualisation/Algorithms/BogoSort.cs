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
            elementsCopy = (int[])elements.Clone();

            StartBogoSort(elements);
        }
        private void StartBogoSort(int[] elements)
        {
            Random rnd = new Random();
            Thread.Sleep(500);
   
            while (!CheckIfSorted(elements))
            {
                HashSet<int> newIndex = new HashSet<int>();
                int indexCount = 0;

                while (newIndex.Count != elements.Length)
                {
                    newIndex.Add(rnd.Next(0, elements.Length));
                }

                foreach (var i in newIndex)
                {
                    elements[i] = elementsCopy[indexCount];

                    indexCount++;
                }

                for (int i = 0; i < elements.Length; i++)
                {
                    graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, maxHeight - elementsCopy[i], maxWidth, elementsCopy[i]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
                }

                Thread.Sleep(700);

                if (CheckIfSorted(elements))
                {
                    ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
                    break;
                }
                else
                {
                    ShowIncorrectSort(elements);
                    Thread.Sleep(1000);
                    ClearDisplay(elementsCopy, elements);
                    Thread.Sleep(800);
                }
            }
        }

        private void ClearDisplay(int[] originalElements, int[] elements)
        {
            for(int i = 0; i < elements.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);;
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(83, 153, 182)), i * maxWidth, maxHeight - elementsCopy[i], maxWidth, elementsCopy[i]);
            }
        }
        private void ShowIncorrectSort(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.DarkRed), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }
        }

        private bool CheckIfSorted(int[] elements)
        {
            for(int i = 0; i < elements.Length - 1; i++)
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
