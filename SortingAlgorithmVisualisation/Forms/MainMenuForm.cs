using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using SortingAlgorithmVisualisation.Algorithms;
using System.Reflection;
using SortingAlgorithmVisualisation.Forms;

namespace SortingAlgorithmVisualisation
{
    public partial class MainMenuForm : Form
    {
        private string selectedAlgorithm;
        private int elementCount;
        private int threadDelay;
        private AlgorithmBase algorithm;
        private ComplexityPopUpForm infoPopUp = new ComplexityPopUpForm();

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if (SetAlgorithmData()) //Sets parameters needed, validates that algorithm is selected
            {
                SetDisplayData();

                if(originalTimeBox.Checked)
                {
                    if(threadDelay == 200)
                    {
                        threadDelay = 13;
                    }
                    else
                    {
                        threadDelay = 0;
                    }
                }

                algorithm.threadDelay = threadDelay;

                string setModifier = GetModifier();
                ShowDisplayForm(setModifier);
            }
        }

        private string GetModifier()
        {
            foreach(CheckBox ckBox in Controls.OfType<CheckBox>())
            {
                if(ckBox.AccessibleDescription == "SortSetting" && ckBox.Checked == true)
                {
                    return ckBox.Text;
                }
            }
            return "standard";
        }

        private bool SetAlgorithmData()
        {
            foreach(RadioButton rb in AlgorithmGroupBox.Controls.OfType<RadioButton>())
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
                    algorithm.SetComplexity(4);
                    break;
                case "Merge Sort":
                    algorithm = new MergeSort();
                    algorithm.SetComplexity(2);
                    break;
                case "Insertion Sort":
                    algorithm = new InsertionSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Heap Sort":
                    algorithm = new HeapSort();
                    algorithm.SetComplexity(0);
                    break;
                case "Bogo Sort":
                    algorithm = new BogoSort();
                    algorithm.timeComplexity = "O(n*n!)";
                    algorithm.spaceComplexity = "O(1)";
                    MessageBox.Show("Please Note: Within the 'Bogo Sort', the light blue colouring is used for displaying the original set of elements before the new iteration of sort is shown in black.", "Notice");
                    break;
                case "Selection Sort":
                    algorithm = new SelectionSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Quick Sort":
                    algorithm = new QuickSort();
                    algorithm.SetComplexity(1);
                    break;
                case "Cocktail Sort":
                    algorithm = new CocktailSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Radix Sort LSD":
                    algorithm = new RadixSort();
                    algorithm.SetComplexity(3);
                    break;
                case "Shell Sort":
                    algorithm = new ShellSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Comb Sort":
                    algorithm = new CombSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Gnome Sort":
                    algorithm = new GnomeSort();
                    algorithm.SetComplexity(4);
                    break;
                case "OddEven Sort":
                    algorithm = new OddEvenSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Cycle Sort":
                    algorithm = new CycleSort();
                    algorithm.SetComplexity(4);
                    break;
                case "Tree Sort":
                    algorithm = new TreeSort();
                    algorithm.SetComplexity(2);
                    break;
                case null:
                    MessageBox.Show("Please select an algorithm","Error");
                    return false;
            }
            return true;
        }

        private void SetDisplayData()
        {
            int userDefinedSize = sizeTrackBar.Value;

            switch(userDefinedSize)
            {
                case 0:
                    if(selectedAlgorithm == "Merge Sort")
                    {
                        MessageBox.Show("The smallest size is not available for Merge Sort, it has been switched to next level","Unavailable size");
                        elementCount = 57;
                        threadDelay = 30;
                    }
                    else
                    {
                        elementCount = 10;
                        threadDelay = 200;
                    }
                    break;
                case 1:
                    elementCount = 57;
                    threadDelay = 30;
                    break;
                case 2:
                    elementCount = 190;
                    threadDelay = 2;
                    break;
                case 3:
                    elementCount = 380;
                    threadDelay = 1;
                    break;
                case 4:
                    elementCount = 570;
                    break;
                case 5:
                    elementCount = 1140; //Max size of display 
                    break;
            }
        }

        private void ShowDisplayForm(string setModifier)
        {
            DisplaySort display = new DisplaySort(elementCount, threadDelay, algorithm, setModifier)
            {
                Text = ($"Showing {selectedAlgorithm} on {elementCount} elements"),
                Visible = true,
            };
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedAlgorithmLabel.Text = ($"{(sender as RadioButton).AccessibleName} Selected");
        }

        private void GithubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/nathanjukes/Sorting-Algorithm-Visualisation");
        }

        private void infoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            infoPopUp.Visible = true;
        }

        private void infoPictureBox_MouseLeave(object sender, EventArgs e)
        {
            infoPopUp.Visible = false;
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        { 
            if((sender as CheckBox).Checked == true)
            {
                foreach (CheckBox i in Controls.OfType<CheckBox>())
                {
                    if (i.AccessibleDescription == "SortSetting" && i.Name != (sender as CheckBox).Name)
                    {
                        i.Checked = false;
                    }
                }
            }
        }
    }
}
