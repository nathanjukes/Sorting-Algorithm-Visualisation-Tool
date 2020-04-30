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
    class MergeSort : AlgorithmBase
    {
        public override int elementCount { get; set; }
        private Graphics graphics;
        private int maxWidth;
        private int maxHeight;
        private int threadDelay;
        private int graphicCount;

        public override void BeginAlgorithm(Graphics _graphics, int _maxWidth, int _maxHeight, int[] elements, int _threadDelay)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            threadDelay = _threadDelay;
            elementCount = elements.Length;
            
            int[] sortedElements = SplitArray(elements);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, sortedElements, threadDelay);
        }

        private int[] SplitArray(int[] unsortedElements)
        {
            if (unsortedElements.Length == 1)
            {
                return unsortedElements;
            }

            int[] leftSideArray = unsortedElements.Take(unsortedElements.Length / 2).ToArray();
            int[] rightSideArray = unsortedElements.Skip(unsortedElements.Length / 2).ToArray();

            leftSideArray = SplitArray(leftSideArray);
            rightSideArray = SplitArray(rightSideArray);
            
            return SortElements(leftSideArray, rightSideArray);
        }

        private int[] SortElements(int[] leftSide, int[] rightSide)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int count = 0;

            int[] sortedElements = new int[leftSide.Length + rightSide.Length];
            
            while (leftIndex < leftSide.Length || rightIndex < rightSide.Length)
            {

                if(leftIndex != leftSide.Length && rightIndex != rightSide.Length)
                {
                    if (leftSide[leftIndex] <= rightSide[rightIndex])
                    {
                        sortedElements[count] = leftSide[leftIndex];

                        //graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (count) * maxWidth, maxHeight - leftSide[leftIndex], maxWidth, leftSide[leftIndex]);
                        //graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (count) * maxWidth, maxHeight - rightSide[rightIndex], maxWidth, rightSide[rightIndex]);

                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count) * maxWidth, maxHeight - leftSide[leftIndex], maxWidth, leftSide[leftIndex]);
                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count +1) * maxWidth, maxHeight - rightSide[rightIndex], maxWidth, rightSide[rightIndex]);

                        leftIndex++;
                        count++;
                        graphicCount++;
                    }
                    else
                    {
                        sortedElements[count] = rightSide[rightIndex];

                        //graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (graphicCount + count) * maxWidth, maxHeight - leftSide[leftIndex], maxWidth, leftSide[leftIndex]);
                        //graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (graphicCount + count) * maxWidth, maxHeight - rightSide[rightIndex], maxWidth, rightSide[rightIndex]);

                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count +1) * maxWidth, maxHeight - leftSide[leftIndex], maxWidth, leftSide[leftIndex]);
                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count) * maxWidth, maxHeight - rightSide[rightIndex], maxWidth, rightSide[rightIndex]);

                        rightIndex++;
                        count++;
                        graphicCount++;
                    }
                }
                else
                {
                    if (leftIndex == leftSide.Length)
                    {
                        sortedElements[count] = rightSide[rightIndex];

                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count) * maxWidth, maxHeight - rightSide[rightIndex], maxWidth, rightSide[rightIndex]);
                        rightIndex++;
                        count++;
                        graphicCount++;
                    }
                    else if (rightIndex == rightSide.Length)
                    {
                        sortedElements[count] = leftSide[leftIndex];
                        //graphics.FillRectangle(new SolidBrush(Color.Black), (graphicCount + count) * maxWidth, maxHeight - leftSide[leftIndex], maxWidth, leftSide[leftIndex]);
                        leftIndex++;
                        count++;
                    } 
                }
                
            }

            return sortedElements;
        }
    }
}
