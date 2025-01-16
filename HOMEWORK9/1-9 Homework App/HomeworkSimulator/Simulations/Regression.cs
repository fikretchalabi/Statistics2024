public class Regression
{
    public static (double a, double b) ComputeRegression(double[] x, double[] y)
    {
        double xMean = Mean(x);
        double yMean = Mean(y);

        double numerator = 0.0, denominator = 0.0;

        for (int i = 0; i < x.Length; i++)
        {
            numerator += (x[i] - xMean) * (y[i] - yMean);
            denominator += (x[i] - xMean) * (x[i] - xMean);
        }

        double b = numerator / denominator;
        double a = yMean - b * xMean;

        return (a, b);
    }

    public static double Mean(double[] data)
    {
        double sum = 0.0;
        foreach (double d in data) sum += d;
        return sum / data.Length;
    }
}
