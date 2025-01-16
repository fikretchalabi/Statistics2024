using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using HomeworkSimulator.Simulations;

namespace HomeworkSimulator.UI
{
    public partial class EMForm : Form
    {
        public EMForm()
        {
            InitializeComponent();
            buttonStartSimulation.Click += ButtonStartSimulation_Click;
        }

        private void ButtonStartSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse input values
                double initialPosition = double.Parse(textBoxInitialPosition.Text);
                double totalTime = double.Parse(textBoxTotalTime.Text);
                int intervals = int.Parse(textBoxIntervals.Text);

                if (totalTime <= 0 || intervals <= 0)
                {
                    MessageBox.Show("Total time and intervals must be positive.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use GeometricBrownianMotion as a concrete SDE example
                double mu = 0.05; // Example drift coefficient
                double sigma = 0.2; // Example diffusion coefficient

                GeometricBrownianMotion gbm = new GeometricBrownianMotion(initialPosition, totalTime, intervals, mu, sigma);

                // Run the simulation
                gbm.Simulate();
                var (times, states) = gbm.GetResults();

                // Update the plot
                UpdatePlot(times, states);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all inputs are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Updates the graph with the simulation results.
        /// </summary>
        /// <param name="times">Array of time points.</param>
        /// <param name="states">Array of states.</param>
        private void UpdatePlot(double[] times, double[] states)
        {
            var plotModel = new PlotModel { Title = "Euler-Maruyama Simulation" };

            var lineSeries = new LineSeries
            {
                Title = "Simulated Path",
                Color = OxyColors.Blue
            };

            for (int i = 0; i < times.Length; i++)
            {
                lineSeries.Points.Add(new DataPoint(times[i], states[i]));
            }

            plotModel.Series.Add(lineSeries);

            // Display the plot in the panelGraph
            var plotView = new PlotView
            {
                Dock = DockStyle.Fill,
                Model = plotModel
            };

            panelGraph.Controls.Clear();
            panelGraph.Controls.Add(plotView);
        }
    }
}
