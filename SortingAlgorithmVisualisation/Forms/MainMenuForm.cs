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

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void runButton_Click(object sender, EventArgs e)
        {
            showDisplayForm();
        }

        private void showDisplayForm()
        {
            DisplaySort d = new DisplaySort(elementCount);

            d.Text = ($"Showing {selectedAlgorithm} on {elementCount} elements");
            d.Visible = true;
        }
    }
}
