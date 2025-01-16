using System;

namespace HomeworkSimulator.Simulations
{
    public class Homework10Simulation
    {
        private const double StepSize = 0.01; // Step size for numerical integration

        // Standard normal PDF (Probability Density Function)
        public double Pdf(double x)
        {
            return Math.Exp(-0.5 * x * x) / Math.Sqrt(2 * Math.PI);
        }

        // Standard normal CDF (Cumulative Distribution Function)
        public double Cdf(double x)
        {
            double sum = 0;
            double step = StepSize;
            for (double i = -10; i <= x; i += step)
            {
                sum += Pdf(i) * step;
            }
            return sum;
        }

        // Riemann Integral for Mean
        public double ComputeRiemannIntegral(double lowerBound, double upperBound)
        {
            double sum = 0;
            double step = StepSize;
            for (double x = lowerBound; x <= upperBound; x += step)
            {
                sum += x * Pdf(x) * step;
            }
            return sum;
        }

        // Lebesgue Integral for Mean
        public double ComputeLebesgueIntegral(double lowerBound, double upperBound)
        {
            double sum = 0;
            double step = StepSize;
            for (double x = lowerBound; x <= upperBound; x += step)
            {
                double fx = Pdf(x);
                sum += fx * step * x;
            }
            return sum;
        }
    }
}
