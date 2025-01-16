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
            comboSimulationSelection.Items.Add("Homework 3 - SDE Simulation");
            comboSimulationSelection.Items.Add("Homework 4 - Continuous SDE Simulation");
            comboSimulationSelection.Items.Add("Homework 5 - Euler-Maruyama Simulation");
            comboSimulationSelection.Items.Add("Homework 6 - Probability Simulation");
            comboSimulationSelection.Items.Add("Homework 7 - Sampling Distribution Simulation");
            comboSimulationSelection.Items.Add("Homework 8 - Caesar Cipher Simulation");
            comboSimulationSelection.Items.Add("Homework 9 - Sampling Variance Simulation"); // Added Homework 9
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
            else if (selectedSimulation == "Homework 4 - Continuous SDE Simulation")
            {
                // Open Homework 4 form
                SDEContForm sdeContForm = new SDEContForm();
                sdeContForm.Show();
            }
            else if (selectedSimulation == "Homework 5 - Euler-Maruyama Simulation")
            {
                // Open Homework 5 form
                EMForm emForm = new EMForm();
                emForm.Show();
            }
            else if (selectedSimulation == "Homework 6 - Probability Simulation")
            {
                // Open Homework 6 form
                Homework6Form homework6Form = new Homework6Form();
                homework6Form.Show();
            }
            else if (selectedSimulation == "Homework 7 - Sampling Distribution Simulation")
            {
                // Open Homework 7 form
                Homework7Form homework7Form = new Homework7Form();
                homework7Form.Show();
            }
            else if (selectedSimulation == "Homework 8 - Caesar Cipher Simulation")
            {
                // Open Homework 8 form
                Homework8Form homework8Form = new Homework8Form();
                homework8Form.Show();
            }
            else if (selectedSimulation == "Homework 9 - Sampling Variance Simulation")
            {
                // Open Homework 9 form
                Homework9Form homework9Form = new Homework9Form();
                homework9Form.Show();
            }
            else
            {
                MessageBox.Show("Please select a simulation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
