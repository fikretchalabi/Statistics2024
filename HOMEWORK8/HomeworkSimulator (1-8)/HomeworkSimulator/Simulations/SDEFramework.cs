using System;

namespace HomeworkSimulator.Simulations
{
    /// <summary>
    /// Base class for the SDE simulation framework.
    /// </summary>
    public abstract class SDEFramework
    {
        protected double initialPosition; // Initial state of the process
        protected double totalTime; // Total simulation time
        protected int intervals; // Number of intervals
        protected double dt; // Time step size
        protected double[] timePoints; // Array to store time points
        protected double[] states; // Array to store process values

        public SDEFramework(double initialPosition, double totalTime, int intervals)
        {
            if (totalTime <= 0)
                throw new ArgumentException("Total time must be positive.");
            if (intervals <= 0)
                throw new ArgumentException("Intervals must be positive.");

            this.initialPosition = initialPosition;
            this.totalTime = totalTime;
            this.intervals = intervals;
            this.dt = totalTime / intervals;

            timePoints = new double[intervals + 1];
            states = new double[intervals + 1];

            InitializeTimePoints();
        }

        /// <summary>
        /// Initializes the time points array.
        /// </summary>
        private void InitializeTimePoints()
        {
            for (int i = 0; i <= intervals; i++)
            {
                timePoints[i] = i * dt;
            }
        }

        /// <summary>
        /// Abstract method to compute the drift term (f(x, t)).
        /// </summary>
        protected abstract double Drift(double x, double t);

        /// <summary>
        /// Abstract method to compute the diffusion term (g(x, t)).
        /// </summary>
        protected abstract double Diffusion(double x, double t);

        /// <summary>
        /// Simulates the process using the Euler-Maruyama method.
        /// </summary>
        public void Simulate()
        {
            Random random = new Random();
            states[0] = initialPosition;

            for (int i = 0; i < intervals; i++)
            {
                double t = timePoints[i];
                double x = states[i];
                double dW = Math.Sqrt(dt) * GenerateNormalRandom(random);

                // Euler-Maruyama update
                states[i + 1] = x + Drift(x, t) * dt + Diffusion(x, t) * dW;
            }
        }

        /// <summary>
        /// Generates a standard normal random variable using the Box-Muller transform.
        /// </summary>
        /// <param name="random">Random number generator.</param>
        /// <returns>Standard normal random value.</returns>
        private double GenerateNormalRandom(Random random)
        {
            double u1 = random.NextDouble();
            double u2 = random.NextDouble();
            return Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);
        }

        /// <summary>
        /// Gets the simulation results.
        /// </summary>
        /// <returns>A tuple containing time points and states.</returns>
        public (double[] timePoints, double[] states) GetResults()
        {
            return (timePoints, states);
        }
    }

    /// <summary>
    /// Implementation of Geometric Brownian Motion (GBM).
    /// </summary>
    public class GeometricBrownianMotion : SDEFramework
    {
        private double mu; // Drift coefficient
        private double sigma; // Diffusion coefficient

        public GeometricBrownianMotion(double initialPosition, double totalTime, int intervals, double mu, double sigma)
            : base(initialPosition, totalTime, intervals)
        {
            if (sigma < 0)
                throw new ArgumentException("Sigma (diffusion coefficient) must be non-negative.");

            this.mu = mu;
            this.sigma = sigma;
        }

        /// <summary>
        /// Drift term for Geometric Brownian Motion.
        /// </summary>
        protected override double Drift(double x, double t)
        {
            return mu * x;
        }

        /// <summary>
        /// Diffusion term for Geometric Brownian Motion.
        /// </summary>
        protected override double Diffusion(double x, double t)
        {
            return sigma * x;
        }
    }
}
