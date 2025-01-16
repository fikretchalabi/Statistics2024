using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace HomeworkSimulator.UI
{
    public partial class Homework6Form : Form
    {
        private Homework6Simulation simulation;

        public Homework6Form()
        {
            InitializeComponent();

            // Default outcomes and probabilities
            int[] outcomes = { 1, 2, 3, 4, 5 };
            double[] probabilities = { 0.1, 0.2, 0.3, 0.25, 0.15 };

            simulation = new Homework6Simulation(outcomes, probabilities);

            // Update theoretical stats
            UpdateTheoreticalStats();
        }

        private void UpdateTheoreticalStats()
        {
            var (mean, variance) = simulation.TheoreticalStatistics();
            lblTheoreticalMean.Text = $"Theoretical Mean: {mean:F2}";
            lblTheoreticalVariance.Text = $"Theoretical Variance: {variance:F2}";
        }

        private void UpdatePlot(Dictionary<int, double> empiricalDistribution)
        {
            var plotModel = new PlotModel { Title = "Theoretical vs Empirical Distributions" };

            // X-Axis
            plotModel.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Outcomes",
                ItemsSource = simulation.Outcomes.Select(o => o.ToString()).ToList()
            });

            // Y-Axis
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Probability",
                Minimum = 0,
                Maximum = 1
            });

            // Theoretical series
            var theoreticalSeries = new BarSeries
            {
                Title = "Theoretical",
                StrokeColor = OxyColors.Blue,
                FillColor = OxyColors.LightBlue,
                StrokeThickness = 1
            };

            // Empirical series
            var empiricalSeries = new BarSeries
            {
                Title = "Empirical",
                StrokeColor = OxyColors.Red,
                FillColor = OxyColors.LightCoral,
                StrokeThickness = 1
            };

            for (int i = 0; i < simulation.Outcomes.Length; i++)
            {
                theoreticalSeries.Items.Add(new BarItem { Value = simulation.Probabilities[i] });
                empiricalSeries.Items.Add(new BarItem { Value = empiricalDistribution[simulation.Outcomes[i]] });
            }

            plotModel.Series.Add(theoreticalSeries);
            plotModel.Series.Add(empiricalSeries);

            plotView.Model = plotModel;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!int.TryParse(textBoxSampleSize.Text, out int sampleSize) || sampleSize <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for the sample size.",
                                    "Invalid Input",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Simulate and get results
                var (empiricalDistribution, empiricalMean, empiricalVariance) = simulation.Simulate(sampleSize);

                // Update empirical stats
                lblEmpiricalMean.Text = $"Empirical Mean: {empiricalMean:F2}";
                lblEmpiricalVariance.Text = $"Empirical Variance: {empiricalVariance:F2}";

                // Update the plot
                UpdatePlot(empiricalDistribution);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Simulation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
