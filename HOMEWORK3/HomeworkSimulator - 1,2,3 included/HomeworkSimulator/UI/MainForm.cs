using HomeworkSimulator.UI; // Ensure you are referencing the UI namespace
using HomeWorkSimulator.UI;
using System;
using System.Windows.Forms;

namespace HomeworkSimulator.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Add options for simulations
            comboSimulationSelection.Items.Add("Homework 1 - Basic Simulation");
            comboSimulationSelection.Items.Add("Homework 2 - Random Walk Simulation");
            comboSimulationSelection.Items.Add("Homework 3 - SDE Simulation"); // Add Homework 3 option
        }

        private void btnStartSimulation_Click(object sender, EventArgs e)
        {
            // Check selected simulation
            string selectedSimulation = comboSimulationSelection.SelectedItem?.ToString();

            if (selectedSimulation == "Homework 1 - Basic Simulation")
            {
                // Open Homework 1 form
                Form1 form1 = new Form1();
                form1.Show();
            }
            else if (selectedSimulation == "Homework 2 - Random Walk Simulation")
            {
                // Open Homework 2 form
                RandomWalkForm randomWalkForm = new RandomWalkForm();
                randomWalkForm.Show();
            }
            else if (selectedSimulation == "Homework 3 - SDE Simulation")
            {
                // Open Homework 3 form
                SDEForm sdeForm = new SDEForm();
                sdeForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a simulation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
