using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SortingAlgorithmVisualisation.Algorithms;

namespace SortingAlgorithmVisualisation
{
    public partial class DisplaySort : Form
    { 
        private int elementCount;
        private int threadDelay;
        private int[] elements;
        private AlgorithmBase algorithm;
        private Random rnd = new Random();

        public DisplaySort(int _elementCount, int _threadDelay, AlgorithmBase _algorithm)
        {
            InitializeComponent();

            elementCount = _elementCount; //Change to _elementCount
            threadDelay = _threadDelay;
            algorithm = _algorithm;
       
            //Add sounds
            algorithmPanel.Location = new Point((this.ClientSize.Width - algorithmPanel.Width)/2, (this.ClientSize.Height - algorithmPanel.Height) / 2);
        }

        private void AlgorithmPanel_Paint(object sender, PaintEventArgs e)
        {
            int[] elements = new int[elementCount];
            Graphics graphics = algorithmPanel.CreateGraphics();

            int maxWidth = algorithmPanel.Width / elementCount;  //Width of each 
            int maxHeight = algorithmPanel.Height; //Max Height of the panel
   
            for (int i = 0; i < elementCount; i++)
            {
                int currentX = i * maxWidth;
                int currentHeight = rnd.Next(1, maxHeight); //Current Height is the value or weight of the rectangle
                elements[i] = currentHeight;

                graphics.FillRectangle(new SolidBrush(Color.Black), currentX, maxHeight - currentHeight, maxWidth, currentHeight);
            }

            BeginSorting(graphics, maxWidth, maxHeight, elements);
        }

        private void BeginSorting(Graphics graphics, int maxWidth, int maxHeight, int[] elements)
        {
            algorithm.BeginAlgorithm(graphics, maxWidth, maxHeight, elements);
        }
    }
}
