using System;

namespace HomeworkSimulator.Simulations
{
    public class RandomWalkSimulationLogic
    {
        private Random random = new Random();
        private int numberOfServers; // Number of servers (steps)
        private int numberOfHackers; // Number of hackers
        private double p; // Probability of +1 jump
        private double[][] steps; // To store the random walk steps for each hacker

        public RandomWalkSimulationLogic(int numberOfServers, int numberOfHackers, double p, int timeSteps)
        {
            this.numberOfServers = numberOfServers;
            this.numberOfHackers = numberOfHackers;
            this.p = p;
            steps = new double[numberOfHackers][];

            // Initialize steps for each hacker
            for (int i = 0; i < numberOfHackers; i++)
            {
                steps[i] = new double[timeSteps];
                steps[i][0] = 0; // Start at 0 for each hacker
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
                }
            }

            return steps;
        }
    }
}
