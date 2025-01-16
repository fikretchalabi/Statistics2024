using System;

namespace HomeworkSimulator.Simulations
{
    public class SDEAttackSimulation
    {
        private double totalTime; // Total simulation time (T)
        private int intervals;    // Number of intervals (n)
        private double lambda;    // Rate of attack (Lambda)
        private double dt;        // Time step size (1/n)
        private double[] timePoints; // Array to store time points
        private double[] states;     // Array to store the states

        public SDEAttackSimulation(double totalTime, int intervals, double lambda)
        {
            this.totalTime = totalTime;
            this.intervals = intervals;
            this.lambda = lambda;
            this.dt = totalTime / intervals;
            this.timePoints = new double[intervals];
            this.states = new double[intervals];
        }

        public void Simulate()
        {
            Random random = new Random();
            states[0] = 0; // Initial state
            timePoints[0] = 0; // Initial time

            for (int i = 1; i < intervals; i++)
            {
                timePoints[i] = i * dt;
                // Check for a jump with probability Lambda * dt
                if (random.NextDouble() < lambda * dt)
                {
                    states[i] = states[i - 1] + 1; // Jump occurs
                }
                else
                {
                    states[i] = states[i - 1]; // No jump
                }
            }
        }

        public (double[] timePoints, double[] states) GetResults()
        {
            return (timePoints, states);
        }
    }
}
