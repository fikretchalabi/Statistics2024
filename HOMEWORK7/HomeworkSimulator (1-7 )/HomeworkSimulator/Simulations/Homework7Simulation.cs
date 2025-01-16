using System;
using System.Collections.Generic;

namespace HomeworkSimulator.Simulations
{
    public class Homework7Simulation
    {
        private int[] outcomes;
        private double[] probabilities;
        private Random random;

        public Homework7Simulation(int[] outcomes, double[] probabilities)
        {
            if (outcomes.Length != probabilities.Length)
                throw new ArgumentException("Outcomes and probabilities must have the same length.");

            this.outcomes = outcomes;
            this.probabilities = probabilities;
            this.random = new Random();
        }

        public (Dictionary<int, double> distribution, double mean, double variance) SimulateSamplingDistribution(int m, int n)
        {
            var samplingAverages = new List<double>();
            double totalMean = 0, totalVariance = 0;

            for (int i = 0; i < m; i++)
            {
                double sampleMean = 0;
                for (int j = 0; j < n; j++)
                {
                    sampleMean += GenerateSample();
                }
                sampleMean /= n;
                samplingAverages.Add(sampleMean);
                totalMean += sampleMean;
            }

            totalMean /= m;

            foreach (var avg in samplingAverages)
            {
                totalVariance += Math.Pow(avg - totalMean, 2);
            }

            totalVariance /= m;

            var distribution = BuildSamplingDistribution(samplingAverages);

            return (distribution, totalMean, totalVariance);
        }

        private double GenerateSample()
        {
            double cumulative = 0;
            double r = random.NextDouble();
            for (int i = 0; i < probabilities.Length; i++)
            {
                cumulative += probabilities[i];
                if (r <= cumulative)
                {
                    return outcomes[i];
                }
            }
            return outcomes[outcomes.Length - 1];
        }

        private Dictionary<int, double> BuildSamplingDistribution(List<double> samplingAverages)
        {
            var distribution = new Dictionary<int, double>();
            foreach (var avg in samplingAverages)
            {
                int key = (int)Math.Round(avg);
                if (distribution.ContainsKey(key))
                {
                    distribution[key]++;
                }
                else
                {
                    distribution[key] = 1;
                }
            }

            // Normalize frequencies using a temporary collection
            var normalizedDistribution = new Dictionary<int, double>();
            foreach (var kvp in distribution)
            {
                normalizedDistribution[kvp.Key] = kvp.Value / samplingAverages.Count;
            }

            return normalizedDistribution;
        }
    }
}
