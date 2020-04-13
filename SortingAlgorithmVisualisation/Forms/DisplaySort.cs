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

        public DisplaySort(int _elementCount)
        {
            InitializeComponent();

            elementCount = 1145;


            //Add sounds
        }

        private void algorithmPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = algorithmPanel.CreateGraphics();
            Random rand = new Random();

            int maxWidth = algorithmPanel.Width / elementCount;  //Width of each line

            if (maxWidth % elementCount != 0)
            {
                double extra = algorithmPanel.Width % elementCount;

    
                MessageBox.Show(extra.ToString());
            }


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
