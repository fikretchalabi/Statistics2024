using System;
using System.Windows.Forms;
using HomeworkSimulator.Simulations;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace HomeworkSimulator.UI
{
    public partial class Homework10Form : Form
    {
        private Homework10Simulation simulation;

        public Homework10Form()
        {
            InitializeComponent();
            simulation = new Homework10Simulation();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double lowerBound = double.Parse(textBoxLowerBound.Text);
                double upperBound = double.Parse(textBoxUpperBound.Text);

                // Compute integrals
                double riemannResult = simulation.ComputeRiemannIntegral(lowerBound, upperBound);
                double lebesgueResult = simulation.ComputeLebesgueIntegral(lowerBound, upperBound);

                // Update labels
                labelRiemannResult.Text = $"Riemann Integral: {riemannResult:F4}";
                labelLebesgueResult.Text = $"Lebesgue Integral: {lebesgueResult:F4}";

                // Plot the results
                UpdatePlot(lowerBound, upperBound);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlot(double lowerBound, double upperBound)
        {
            var plotModel = new PlotModel { Title = "Standard Normal Distribution" };

            // X-Axis
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "X",
                Minimum = lowerBound,
                Maximum = upperBound
            });

            // Y-Axis
            plotModel.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "f(x)",
                Minimum = 0,
                Maximum = 0.5
            });

            // PDF series
            var pdfSeries = new LineSeries
            {
                Title = "PDF",
                Color = OxyColors.Blue
            };

            for (double x = lowerBound; x <= upperBound; x += 0.01)
            {
                pdfSeries.Points.Add(new DataPoint(x, simulation.Pdf(x)));
            }

            plotModel.Series.Add(pdfSeries);

            plotView.Model = plotModel;
        }
    }
}
