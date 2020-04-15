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

namespace SortingAlgorithmVisualisation
{
    public partial class DisplaySort : Form
    { 
        private int elementCount;
        private int threadDelay;

        public DisplaySort(int _elementCount, int _threadDelay)
        {
            InitializeComponent();

            elementCount = _elementCount; //Change to _elementCount
            threadDelay = _threadDelay;

            //Add sounds
            algorithmPanel.Location = new Point((this.ClientSize.Width - algorithmPanel.Width)/2, (this.ClientSize.Height - algorithmPanel.Height) / 2);
        }

        private void algorithmPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = algorithmPanel.CreateGraphics();
            Random rand = new Random();

            int maxWidth = algorithmPanel.Width / elementCount;  //Width of each 

            int maxHeight = algorithmPanel.Height;

            for (int i = 0; i < elementCount; i++)
            {
                int currentX = i * maxWidth;
                int currentHeight = rand.Next(1, maxHeight);

                graphics.FillRectangle(new SolidBrush(Color.Black), currentX, maxHeight - currentHeight, maxWidth, currentHeight);
            }

        }
    }
}
