﻿using System;
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
        private int offset;
        private int qCount = 0;
        public override void BeginAlgorithm(Graphics _graphics, int _maxWidth, int _maxHeight, int[] elements, int _threadDelay)
        {
            graphics = _graphics;
            maxWidth = _maxWidth;
            maxHeight = _maxHeight;
            threadDelay = _threadDelay;
            elementCount = elements.Length;
            
            SplitArray(elements);

            Thread.Sleep(600);

            ShowCompletedDisplay(graphics, maxWidth, maxHeight, elements, threadDelay);
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

            return SortElements(leftSideArray, rightSideArray, unsortedElements);
        }

        private int[] SortElements(int[] leftSide, int[] rightSide, int[] elements)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int count = 0;

            while (leftIndex < leftSide.Length || rightIndex < rightSide.Length)
            {
                if (leftIndex != leftSide.Length && rightIndex != rightSide.Length)
                {
                    if (leftSide[leftIndex] <= rightSide[rightIndex])
                    {
                        elements[count] = leftSide[leftIndex];
                        leftIndex++;
                        count++;
                    }
                    else
                    {
                        elements[count] = rightSide[rightIndex];
                        rightIndex++;
                        count++;
                    }
                }
                else
                {
                    if (leftIndex == leftSide.Length)
                    {
                        elements[count] = rightSide[rightIndex];
                        rightIndex++;
                        count++;
                    }
                    else if (rightIndex == rightSide.Length)
                    {
                        elements[count] = leftSide[leftIndex];
                        leftIndex++;
                        count++;
                    }
                }
            }
            ReDrawGraphics(elements);

            if ((elements.Length % (elementCount / 4)) == 0 || (elements.Length % (elementCount / 4)) == 1 && qCount >= 1)
            {
                offset = elements.Length;
                qCount++;

                switch(qCount)
                {
                    case 2:
                        offset = 0;
                        break;
                    case 3:
                        offset = elementCount / 2;
                        Thread.Sleep(300);
                        break;
                    case 4:
                        offset = (elementCount / 2) + elements.Length;
                        Thread.Sleep(300);
                        break;
                    case 5:
                        offset = elementCount / 2;
                        Thread.Sleep(300);
                        break;
                    case 6:
                        offset = 0;
                        Thread.Sleep(300);
                        break;
                }
            }

            Thread.Sleep(threadDelay);
            return elements;
        }

        private void ReDrawGraphics(int[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), (i + offset) * maxWidth, 0, maxWidth, maxHeight);
                graphics.FillRectangle(new SolidBrush(Color.Black), (i + offset) * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }
        }
    }
}
