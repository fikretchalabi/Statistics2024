using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeworkSimulator.UI
{
    public partial class RandomWalkForm : Form
    {
        public RandomWalkForm()
        {
            InitializeComponent();
            buttonStartSim.Click += ButtonStartSim_Click; // Bind the button click event
        }

        private void ButtonStartSim_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse user inputs
                int numberOfServers = int.Parse(textBoxServers.Text);
                int numberOfHackers = int.Parse(textBoxHacker.Text);
                double probability = double.Parse(textBoxP.Text);
                int timeSteps = int.Parse(textBoxTime.Text);

                // Validate inputs
                if (numberOfServers <= 0 || numberOfHackers <= 0 || timeSteps <= 0 || probability < 0 || probability > 1)
                {
                    MessageBox.Show("Please enter valid positive values. Probability should be between 0 and 1.",
                                    "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Run the random walk simulation
                RandomWalkSimulation simulation = new RandomWalkSimulation(numberOfServers, numberOfHackers, probability, timeSteps);
                double[][] steps = simulation.Simulate();

                // Display the mean and variance
                labelMean.Text = $"Mean: {simulation.GetMean():0.00}";
                labelVariance.Text = $"Variance: {simulation.GetVariance():0.00}";

                // Update the plot with the simulation data
                UpdatePlot(steps);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all inputs are valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePlot(double[][] steps)
        {
            var plotModel = new PlotModel { Title = "Random Walk Simulation" };

            // Configure the legend
            plotModel.Legends.Add(new Legend
            {
                LegendTitle = "Hackers",
                LegendPosition = LegendPosition.TopRight,
                LegendPlacement = LegendPlacement.Outside,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendBorderThickness = 0
            });

            // Define colors for hackers
            Color[] hackerColors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Purple };

            // Add random walk series for each hacker
            for (int hacker = 0; hacker < steps.Length; hacker++)
            {
                var lineSeries = new LineSeries
                {
                    Title = $"Hacker {hacker + 1}",
                    Color = OxyColor.FromRgb(hackerColors[hacker % hackerColors.Length].R,
                                             hackerColors[hacker % hackerColors.Length].G,
                                             hackerColors[hacker % hackerColors.Length].B),
                    StrokeThickness = 2,
                    LineStyle = (hacker % 2 == 0) ? LineStyle.Solid : LineStyle.Dash
                };

                for (int i = 0; i < steps[hacker].Length; i++)
                {
                    lineSeries.Points.Add(new DataPoint(i, steps[hacker][i]));
                }

                plotModel.Series.Add(lineSeries);
            }

            // Update the panelGraph with the new plot model
            panelGraph.Model = plotModel;
        }
    }

    // Welford class for running mean and variance calculation
    public class Welford
    {
        private double mean = 0.0;
        private double M2 = 0.0;
        private int count = 0;

        public void Update(double newValue)
        {
            count++;
            double delta = newValue - mean;
            mean += delta / count;
            M2 += delta * (newValue - mean);
        }

        public double Mean()
        {
            return mean;
        }

        public double Variance()
        {
            return (count > 1) ? M2 / (count - 1) : 0.0;
        }
    }

    // RandomWalkSimulation class for simulating the random walk
    public class RandomWalkSimulation
    {
        private Random random = new Random();
        private int numberOfServers;
        private int numberOfHackers;
        private double p;
        private double[][] steps;
        private Welford welford;

        public RandomWalkSimulation(int numberOfServers, int numberOfHackers, double p, int timeSteps)
        {
            this.numberOfServers = numberOfServers;
            this.numberOfHackers = numberOfHackers;
            this.p = p;
            steps = new double[numberOfHackers][];
            welford = new Welford();

            // Initialize steps for each hacker
            for (int i = 0; i < numberOfHackers; i++)
            {
                steps[i] = new double[timeSteps];
                steps[i][0] = 0; // Start position
            }
        }

        public double[][] Simulate()
        {
            for (int hacker = 0; hacker < numberOfHackers; hacker++)
            {
                for (int i = 1; i < steps[hacker].Length; i++)
                {
                    int jump = (random.NextDouble() < p) ? 1 : -1;
                    steps[hacker][i] = steps[hacker][i - 1] + jump;

                    // Update running statistics
                    welford.Update(steps[hacker][i]);
                }
            }

            return steps;
        }

        public double GetMean()
        {
            return welford.Mean();
        }

        public double GetVariance()
        {
            return welford.Variance();
        }
    }
}
