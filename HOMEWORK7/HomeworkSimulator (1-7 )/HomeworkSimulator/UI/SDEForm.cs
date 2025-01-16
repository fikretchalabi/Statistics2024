using HomeworkSimulator.Simulations;
using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;

namespace HomeworkSimulator.UI
{
    public partial class SDEForm : Form
    {
        public SDEForm()
        {
            InitializeComponent();
            buttonStartSDE.Click += ButtonStartSDE_Click; // Attach the event handler
        }

        private void ButtonStartSDE_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs
                double lambda = double.Parse(textBoxLambda.Text);
                double totalTime = double.Parse(textBoxTime.Text);
                int intervals = int.Parse(textBoxIntervals.Text);

                // Validate inputs
                if (lambda <= 0 || totalTime <= 0 || intervals <= 0)
                {
                    MessageBox.Show("All inputs must be positive.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Run simulation
                SDEAttackSimulation simulation = new SDEAttackSimulation(totalTime, intervals, lambda);
                simulation.Simulate();

                // Get results
                var (timePoints, states) = simulation.GetResults();

                // Update plot
                UpdatePlot(timePoints, states);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlot(double[] timePoints, double[] states)
        {
            var plotModel = new PlotModel { Title = "SDE Simulation" };

            // Create the line series for the plot
            var series = new LineSeries
            {
                Title = "State Over Time",
                StrokeThickness = 2,
            };

            // Add data points to the series
            for (int i = 0; i < timePoints.Length; i++)
            {
                series.Points.Add(new DataPoint(timePoints[i], states[i]));
            }

            plotModel.Series.Add(series);

            // Bind the plot model to the panelGraph
            panelGraph.Model = plotModel;
        }

        private void buttonStartSDE_Click_1(object sender, EventArgs e)
        {

        }
    }
}
