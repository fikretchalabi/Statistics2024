using System;
using System.Collections.Generic;

namespace HomeworkSimulator.Simulations
{
    public class Homework9Simulation
    {
        private int[] outcomes;
        private double[] probabilities;
        private Random random;

        public Homework9Simulation(int[] outcomes, double[] probabilities)
        {
            if (outcomes.Length != probabilities.Length)
                throw new ArgumentException("Outcomes and probabilities must have the same length.");

            this.outcomes = outcomes;
            this.probabilities = probabilities;
            this.random = new Random();
        }

        public (Dictionary<int, double> correctedDistribution, Dictionary<int, double> uncorrectedDistribution, double mean, double variance) SimulateSamplingVarianceDistribution(int m, int n)
        {
            var correctedVariances = new List<double>();
            var uncorrectedVariances = new List<double>();
            double totalMean = 0, totalVariance = 0;

            for (int i = 0; i < m; i++)
            {
                var sample = GenerateSample(n);

                // Compute mean of the sample
                double sampleMean = 0;
                foreach (var value in sample)
                    sampleMean += value;
                sampleMean /= n;

                // Compute variances
                double uncorrectedVariance = 0;
                double correctedVariance = 0;
                foreach (var value in sample)
                {
                    uncorrectedVariance += Math.Pow(value - sampleMean, 2);
                }
                correctedVariance = uncorrectedVariance / (n - 1);
                uncorrectedVariance /= n;

                correctedVariances.Add(correctedVariance);
                uncorrectedVariances.Add(uncorrectedVariance);

                totalMean += correctedVariance;
            }

            // Compute mean and variance of sampling variances
            totalMean /= m;
            foreach (var variance in correctedVariances)
                totalVariance += Math.Pow(variance - totalMean, 2);
            totalVariance /= m;

            // Build distributions
            var correctedDistribution = BuildDistribution(correctedVariances);
            var uncorrectedDistribution = BuildDistribution(uncorrectedVariances);

            return (correctedDistribution, uncorrectedDistribution, totalMean, totalVariance);
        }

        private List<int> GenerateSample(int n)
        {
            var sample = new List<int>();
            for (int i = 0; i < n; i++)
            {
                double r = random.NextDouble();
                double cumulative = 0;
                for (int j = 0; j < probabilities.Length; j++)
                {
                    cumulative += probabilities[j];
                    if (r <= cumulative)
                    {
                        sample.Add(outcomes[j]);
                        break;
                    }
                }
            }
            return sample;
        }

        private Dictionary<int, double> BuildDistribution(List<double> variances)
        {
            var distribution = new Dictionary<int, double>();
            foreach (var variance in variances)
            {
                int key = (int)Math.Round(variance);
                if (distribution.ContainsKey(key))
                {
                    distribution[key]++;
                }
                else
                {
                    distribution[key] = 1;
                }
            }

            // Normalize frequencies
            foreach (var key in new List<int>(distribution.Keys))
            {
                distribution[key] /= variances.Count;
            }

            return distribution;
        }
    }
}
