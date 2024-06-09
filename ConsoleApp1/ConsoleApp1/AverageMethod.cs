namespace DefaultNamespace;

public class AverageMethod
{
    public class AverageMethod
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            foreach (int numberr in numbers)
            {
                sum += numberr;
            }

            return sum / numbers.Length;
        }
    }