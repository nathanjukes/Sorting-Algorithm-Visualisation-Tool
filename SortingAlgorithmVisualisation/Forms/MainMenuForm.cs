using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SortingAlgorithmVisualisation.Algorithms;

namespace SortingAlgorithmVisualisation
{
    public partial class MainMenuForm : Form
    {
        private string selectedAlgorithm;
        private int elementCount;
        private int threadDelay;
        private AlgorithmBase algorithm;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if(SetAlgorithmParameters()) //Sets parameters needed, validates that algorithm is selected
            {
                SetDisplayParameters();

                ShowDisplayForm();
            }
        }

        private bool SetAlgorithmParameters()
        {
            foreach(RadioButton rb in ActiveForm.Controls.OfType<RadioButton>())
            {
                if(rb.Checked)
                {
                    selectedAlgorithm = rb.AccessibleName;
                    break;
                }
            }

            switch(selectedAlgorithm)
            {
                case "Bubble Sort":
                    algorithm = new BubbleSort();
                    break;
                case "Merge Sort":
                    algorithm = new MergeSort();
                    break;
                case "Insertion Sort":
                    algorithm = new InsertionSort();
                    break;
                case "Heap Sort":
                    algorithm = new HeapSort();
                    break;
                case "Bogo Sort":
                    algorithm = new BogoSort();
                    break;
                case "Selection Sort":
                    algorithm = new SelectionSort();
                    break;
                case "Quick Sort":
                    algorithm = new QuickSort();
                    break;
                case "Cocktail Sort":
                    algorithm = new CocktailSort();
                    break;
                case "Radix Sort":
                    algorithm = new RadixSort();
                    break;
                case null:
                    MessageBox.Show("Please select an algorithm","Error");
                    return false;
            }
            return true;
        }

        private void SetDisplayParameters()
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

        private void ShowDisplayForm()
        {
            DisplaySort display = new DisplaySort(elementCount, threadDelay, algorithm)
            {
                Text = ($"Showing {selectedAlgorithm} on {elementCount} elements"),
                Visible = true
            };
        }
    }
}
