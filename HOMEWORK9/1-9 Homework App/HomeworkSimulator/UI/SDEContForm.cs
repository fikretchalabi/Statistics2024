using System;
using System.Windows.Forms;
using HomeworkSimulator.Simulations;

namespace HomeworkSimulator.UI
{
    public partial class SDEContForm : Form
    {
        public SDEContForm()
        {
            InitializeComponent();
            buttonStartSimulation.Click += ButtonStartSimulation_Click; // Bind the button click event
        }

        private void ButtonStartSimulation_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse inputs
                double totalTime = double.Parse(textBoxTotalTime.Text);
                int intervals = int.Parse(textBoxIntervals.Text);
                double initialPosition = double.Parse(textBoxInitialPosition.Text);

                if (totalTime <= 0 || intervals <= 0)
                {
                    MessageBox.Show("Total time and intervals must be positive.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Run the SDE simulation
                SDECont simulation = new SDECont(totalTime, intervals, initialPosition);
                var (timePoints, trajectory) = simulation.Simulate();

                // Update the plot
                UpdatePlot(timePoints, trajectory);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlot(double[] timePoints, double[] trajectory)
        {
            // Configure the OxyPlot chart
            var plotModel = new OxyPlot.PlotModel { Title = "Continuous SDE Simulation (Scaling Limit of Random Walk)" };
            var series = new OxyPlot.Series.LineSeries { Title = "Trajectory", StrokeThickness = 2 };

            for (int i = 0; i < timePoints.Length; i++)
            {
                series.Points.Add(new OxyPlot.DataPoint(timePoints[i], trajectory[i]));
            }

            plotModel.Series.Add(series);
            panelGraph.Model = plotModel; // Bind the plot model to the panelGraph
        }
    }
}
