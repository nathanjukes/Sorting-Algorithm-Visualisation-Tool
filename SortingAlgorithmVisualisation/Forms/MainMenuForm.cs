using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithmVisualisation
{
    public partial class MainMenuForm : Form
    {
        private string selectedAlgorithm;
        private int elementCount;
        private int threadDelay;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            getDisplayParameters();

            showDisplayForm();
        }

        private void getDisplayParameters()
        {
            int userDefinedSize = sizeTrackBar.Value;

            switch(userDefinedSize)
            {
                case 0:
                    elementCount = 10;
                    threadDelay = 2000;
                    break;
                case 1:
                    elementCount = 57;
                    threadDelay = 350;
                    break;
                case 2:
                    elementCount = 190;
                    threadDelay = 100;
                    break;
                case 3:
                    elementCount = 380;
                    break;
                case 4:
                    elementCount = 570;
                    break;
                case 5:
                    elementCount = 1140; //Max size of display 
                    break;
            }
        }

        private void showDisplayForm()
        {
            DisplaySort d = new DisplaySort(elementCount, threadDelay);

            d.Text = ($"Showing {selectedAlgorithm} on {elementCount} elements");
            d.Visible = true;
        }
    }
}
