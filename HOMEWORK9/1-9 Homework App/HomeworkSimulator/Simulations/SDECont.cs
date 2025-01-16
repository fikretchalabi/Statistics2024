using System;

namespace HomeworkSimulator.Simulations
{
    public class SDECont
    {
        private readonly double totalTime;
        private readonly int intervals;
        private readonly double initialPosition;
        private readonly double deltaT;
        private readonly Random random;

        public SDECont(double totalTime, int intervals, double initialPosition)
        {
            this.totalTime = totalTime;
            this.intervals = intervals;
            this.initialPosition = initialPosition;
            this.deltaT = totalTime / intervals;
            this.random = new Random();
        }

        public (double[] TimePoints, double[] Trajectory) Simulate()
        {
            double[] timePoints = new double[intervals + 1];
            double[] trajectory = new double[intervals + 1];
            trajectory[0] = initialPosition;

            for (int i = 1; i <= intervals; i++)
            {
                timePoints[i] = i * deltaT;
                double jump = random.NextDouble() < 0.5 ? -Math.Sqrt(deltaT) : Math.Sqrt(deltaT);
                trajectory[i] = trajectory[i - 1] + jump;
            }

            return (timePoints, trajectory);
        }
    }
}
