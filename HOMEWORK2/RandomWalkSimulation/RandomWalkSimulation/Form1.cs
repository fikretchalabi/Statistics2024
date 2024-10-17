using OxyPlot;
using OxyPlot.Legends;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot.Axes; 

namespace RandomWalkSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonStartSim.Click += ButtonStartSim_Click; // Bind the button click event
        }

        private void ButtonStartSim_Click(object sender, EventArgs e)
        {
            int numberOfServers = int.Parse(textBoxServers.Text);  // Number of servers (steps)
            int numberOfHackers = int.Parse(textBoxHacker.Text);   // Number of hackers (attackers)
            double probability = double.Parse(textBoxP.Text);      // Probability of +1
            int timeSteps = int.Parse(textBoxTime.Text);           // Time or iterations

            // Run the random walk simulation for multiple hackers
            RandomWalkSimulation simulation = new RandomWalkSimulation(numberOfServers, numberOfHackers, probability, timeSteps);
            double[][] steps = simulation.Simulate();

            // Display the mean and variance
            labelMean.Text = $"Mean: {simulation.GetMean():0.00}";
            labelVariance.Text = $"Variance: {simulation.GetVariance():0.00}";

            // Update the plot with the new simulation data
            UpdatePlot(steps);
        }

        private void UpdatePlot(double[][] steps)
        {
            var plotModel = new PlotModel { Title = "Random Walk Simulation" };

            // Add legend configuration for OxyPlot 2.2.0
            plotModel.Legends.Add(new Legend
            {
                LegendTitle = "Hackers",
                LegendPosition = LegendPosition.TopRight,
                LegendPlacement = LegendPlacement.Outside,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendBorderThickness = 0
            });

            Color[] hackerColors = { Color.Red, Color.Green, Color.Blue, Color.Orange, Color.Purple };

            // Plot the random walk for each hacker
            for (int hacker = 0; hacker < steps.Length; hacker++)
            {
                var lineSeries = new LineSeries
                {
                    Title = $"Hacker {hacker + 1}",
                    Color = OxyColor.FromRgb(hackerColors[hacker % hackerColors.Length].R,
                                             hackerColors[hacker % hackerColors.Length].G,
                                             hackerColors[hacker % hackerColors.Length].B),
                    StrokeThickness = 2,  // Thicker lines for visibility
                    LineStyle = (hacker % 2 == 0) ? LineStyle.Solid : LineStyle.Dash  // Alternate solid and dashed lines
                };

                for (int i = 0; i < steps[hacker].Length; i++)
                {
                    lineSeries.Points.Add(new DataPoint(i, steps[hacker][i]));
                }

                plotModel.Series.Add(lineSeries);
            }

            panelGraph.Model = plotModel; // Bind the plot to the PlotView
        }
    }

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

    public class RandomWalkSimulation
    {
        private Random random = new Random();
        private int numberOfServers;  // Number of servers (steps)
        private int numberOfHackers;  // Number of hackers
        private double p;  // Probability of +1 jump
        private double[][] steps;  // To store the random walk steps for each hacker
        private Welford welford;  // For calculating mean and variance

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
                steps[i][0] = 0;  // Start at 0 for each hacker
            }
        }

        public double[][] Simulate()
        {
            // Simulate random walk for each hacker
            for (int hacker = 0; hacker < numberOfHackers; hacker++)
            {
                for (int i = 1; i < steps[hacker].Length; i++)
                {
                    int jump = (random.NextDouble() < p) ? 1 : -1;
                    steps[hacker][i] = steps[hacker][i - 1] + jump;

                    // Update mean and variance with the new step
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
