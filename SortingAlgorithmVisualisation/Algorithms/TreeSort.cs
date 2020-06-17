using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation.Algorithms
{
    class TreeSort : AlgorithmBase
    {
        public override int elementCount { get; set; }
        public Node root;
        public static int index = 0;

        public override void BeginAlgorithm(int[] elements)
        {
            ReDrawClass.maxWidth = maxWidth; 
            ReDrawClass.maxHeight = maxHeight;
            ReDrawClass.threadDelay = threadDelay;
            ReDrawClass.graphics = graphics;
       
            CreateTree(elements);

            ReDrawClass.ScanThroughAllElements(elements);

            root.PreOrderTraversal(elements);

            Thread.Sleep(220);
        }

        private void CreateTree(int[] elements)
        {
            for(int i = 0; i < elementCount; i++)
            {
                if(root == null)
                {
                    root = new Node(elements[i]);
                }
                else if(elements[i] < root.value)
                {
                    root.AddNode(new Node(elements[i]));
                }
                else
                {
                    root.AddNode(new Node(elements[i]));
                }
            }
        }
    }

    class Node
    {
        public int value;
        private Node leftNode;
        private Node rightNode;
        private int count = 1;

        public Node(int _value)
        {
            value = _value;
        }

        public void AddNode(Node nodeToAdd)
        {
            if(nodeToAdd.value == value)
            {
                count++;
            }

            if(nodeToAdd.value < value)
            {
                if(leftNode == null)
                {
                    leftNode = nodeToAdd;
                }
                else
                {
                    leftNode.AddNode(nodeToAdd);
                }
            }
            else if(nodeToAdd.value > value)
            {
                if (rightNode == null)
                {
                    rightNode = nodeToAdd;
                }
                else
                {
                    rightNode.AddNode(nodeToAdd);
                }
            }
        }

        public void PreOrderTraversal(int[] elements)
        {
            if(leftNode != null)
            {
                leftNode.PreOrderTraversal(elements);
            }

            for(int i = 0; i < count; i++)
            {
                elements[TreeSort.index] = value;
                TreeSort.index++;

                ReDrawClass.ReDrawDisplay(elements, TreeSort.index);
            }

            if(rightNode != null)
            {
                rightNode.PreOrderTraversal(elements);
            }
        }
    }

    static class ReDrawClass
    {
        private static int elementCount;

        public static int maxWidth;
        public static int maxHeight;
        public static int threadDelay;
        public static Graphics graphics;

        public static void ReDrawDisplay(int[] elements, int currentIndex)
        {
            elementCount = elements.Length;

            ClearDisplay(currentIndex - 1);

            ReDrawElements(elements, currentIndex - 1);
        }

        public static void ScanThroughAllElements(int[] elements) //Shows a demonstration of the Tree creation (Sifting through all elements and building a binary tree)
        {
            elementCount = elements.Length;

            for (int i = 0; i < elementCount; i++)
            {
                graphics.FillRectangle(new SolidBrush(Color.DarkRed), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);

                Thread.Sleep(threadDelay);

                graphics.FillRectangle(new SolidBrush(Color.Black), i * maxWidth, maxHeight - elements[i], maxWidth, elements[i]);
            }
        }

        private static void ClearDisplay(int currentIndex)
        {
            graphics.FillRectangle(new SolidBrush(SystemColors.ActiveBorder), currentIndex * maxWidth, 0, maxWidth, maxHeight);
        }

        private static void ReDrawElements(int[] elements, int currentIndex)
        {
            graphics.FillRectangle(new SolidBrush(Color.Black), currentIndex * maxWidth, maxHeight - elements[currentIndex], maxWidth, elements[currentIndex]);
            Thread.Sleep(threadDelay);
        }
    }

}
