using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HomeworkSimulator.Simulations;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace HomeworkSimulator.UI
{
    public partial class Homework9Form : Form
    {
        private Homework9Simulation simulation;

        public Homework9Form()
        {
            InitializeComponent();

            // Default outcomes and probabilities
            int[] outcomes = { 1, 2, 3, 4, 5 };
            double[] probabilities = { 0.1, 0.2, 0.3, 0.25, 0.15 };

            simulation = new Homework9Simulation(outcomes, probabilities);
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(textBoxNumSamples.Text); // Number of samples
                int n = int.Parse(textBoxSampleSize.Text); // Size of each sample

                // Simulate sampling variance distributions
                var (correctedDistribution, uncorrectedDistribution, mean, variance) = simulation.SimulateSamplingVarianceDistribution(m, n);

                // Update statistics labels
                lblSamplingMean.Text = $"Mean of Sampling Variances: {mean:F2}";
                lblSamplingVariance.Text = $"Variance of Sampling Variances: {variance:F2}";

                // Update the plots
                UpdatePlot(correctedDistribution, "Corrected Sampling Variance Distribution", "Corrected Variance");
                UpdatePlot(uncorrectedDistribution, "Uncorrected Sampling Variance Distribution", "Uncorrected Variance");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Simulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdatePlot(Dictionary<int, double> variancesDistribution, string title, string yAxisTitle)
        {
            var plotModel = new PlotModel { Title = title };

            // X-Axis for frequencies (Linear Axis)
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Frequency",
                Minimum = 0
            });

            // Y-Axis for variances (Category Axis)
            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = yAxisTitle,
                ItemsSource = variancesDistribution.Keys.Select(k => k.ToString()).ToList()
            });

            // BarSeries for variances
            var barSeries = new BarSeries
            {
                Title = "Distribution",
                FillColor = OxyColors.CornflowerBlue
            };

            foreach (var kvp in variancesDistribution)
            {
                barSeries.Items.Add(new BarItem { Value = kvp.Value });
            }

            plotModel.Series.Add(barSeries);

            plotView.Model = plotModel;
        }

    }
}
