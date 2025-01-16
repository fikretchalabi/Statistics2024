using System.Collections.Generic;
using System.Linq;
using System;

public class Homework6Simulation
{
    public int[] Outcomes { get; private set; }
    public double[] Probabilities { get; private set; }

    public Homework6Simulation(int[] outcomes, double[] probabilities)
    {
        if (outcomes.Length != probabilities.Length)
            throw new ArgumentException("Outcomes and probabilities must have the same length.");

        if (Math.Abs(probabilities.Sum() - 1.0) > 1e-6)
            throw new ArgumentException("Probabilities must sum to 1.");

        Outcomes = outcomes;
        Probabilities = probabilities;
    }

    public (double mean, double variance) TheoreticalStatistics()
    {
        double mean = Outcomes.Zip(Probabilities, (o, p) => o * p).Sum();
        double variance = Outcomes.Zip(Probabilities, (o, p) => p * Math.Pow(o - mean, 2)).Sum();
        return (mean, variance);
    }

    public (Dictionary<int, double> empiricalDistribution, double mean, double variance) Simulate(int sampleSize)
    {
        Random random = new Random();
        Dictionary<int, int> counts = Outcomes.ToDictionary(o => o, o => 0);

        double mean = 0;
        double variance = 0;
        int count = 0;

        for (int i = 0; i < sampleSize; i++)
        {
            double r = random.NextDouble();
            double cumulative = 0;
            for (int j = 0; j < Outcomes.Length; j++)
            {
                cumulative += Probabilities[j];
                if (r <= cumulative)
                {
                    counts[Outcomes[j]]++;
                    // Welford's method for mean and variance
                    count++;
                    double delta = Outcomes[j] - mean;
                    mean += delta / count;
                    variance += delta * (Outcomes[j] - mean);
                    break;
                }
            }
        }

        variance /= count;

        var empiricalDistribution = counts.ToDictionary(kvp => kvp.Key, kvp => (double)kvp.Value / sampleSize);
        return (empiricalDistribution, mean, variance);
    }
}
