using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HomeworkSimulator.Simulations;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace HomeworkSimulator.UI
{
    public partial class Homework7Form : Form
    {
        private Homework7Simulation simulation;

        public Homework7Form()
        {
            InitializeComponent();

            // Default outcomes and probabilities
            int[] outcomes = { 1, 2, 3, 4, 5 };
            double[] probabilities = { 0.1, 0.2, 0.3, 0.25, 0.15 };

            simulation = new Homework7Simulation(outcomes, probabilities);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(textBoxNumSamples.Text); // Number of samples
                int n = int.Parse(textBoxSampleSize.Text); // Size of each sample

                // Simulate sampling distribution
                var (samplingDistribution, mean, variance) = simulation.SimulateSamplingDistribution(m, n);

                // Update statistics labels
                lblSamplingMean.Text = $"Mean of Sampling Averages: {mean:F2}";
                lblSamplingVariance.Text = $"Variance of Sampling Averages: {variance:F2}";

                // Convert and plot
                var convertedDistribution = samplingDistribution.ToDictionary(
      kvp => (int)Math.Round((double)kvp.Key),
      kvp => kvp.Value
  );


                UpdatePlot(convertedDistribution);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\n{ex.StackTrace}", "Simulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdatePlot(Dictionary<int, double> samplingDistribution)
        {
            var plotModel = new PlotModel { Title = "Sampling Averages Distribution" };

            // Y-Axis (Categories)
            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left, // Categories go on the Y-axis for BarSeries
                Title = "Sampling Averages",
                ItemsSource = samplingDistribution.Keys.Select(k => k.ToString()).ToList()
            });

            // X-Axis (Values/Frequencies)
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom, // Frequencies go on the X-axis
                Title = "Frequency",
                Minimum = 0
            });

            // Sampling distribution series
            var barSeries = new BarSeries
            {
                Title = "Sampling Distribution",
                FillColor = OxyColors.CornflowerBlue,
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1
            };

            foreach (var kvp in samplingDistribution)
            {
                barSeries.Items.Add(new BarItem { Value = kvp.Value });
            }

            plotModel.Series.Add(barSeries);

            plotView.Model = plotModel;
        }







    }
}
