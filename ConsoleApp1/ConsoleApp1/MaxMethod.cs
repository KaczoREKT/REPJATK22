namespace DefaultNamespace;

public class AverageMethod
{ 
    public static double calculateMax(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double max = 0;
            foreach (int number in numbers)
            {
                if number > max
                {
                    max = number
                }
            }

            return max;
        }
    