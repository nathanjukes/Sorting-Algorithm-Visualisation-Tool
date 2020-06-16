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

        private int[] elementsCopy;
        public override void BeginAlgorithm(int[] elements)
        {
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

                while (newIndex.Count != elementCount)
                {
                    newIndex.Add(rnd.Next(0, elementCount));
                }

                foreach (var i in newIndex)
                {
                    elements[i] = elementsCopy[indexCount];

                    indexCount++;
                }

                for (int i = 0; i < elementCount; i++)
                {
                    graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, maxHeight - elementsCopy[i], maxWidth, elementsCopy[i]);
                    graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
                }

                Thread.Sleep(700);

                if (CheckIfSorted(elements))
                {
                    DisplaySort.SortComplete = true;
                    ShowCompletedDisplay(elements);
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
            for(int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);;
                graphics.FillRectangle(new SolidBrush(Color.FromArgb(83, 153, 182)), i * maxWidth, maxHeight - elementsCopy[i], maxWidth, elementsCopy[i]);
            }
        }
        private void ShowIncorrectSort(int[] elements)
        {
            for (int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.DarkRed), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }
        }

        private bool CheckIfSorted(int[] elements)
        {
            for(int i = 0; i < elementCount - 1; i++)
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
