using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test.function
{
    public class Statistics
    {
        public static float Median(int[] array)
        {
            if (array.Length % 2 == 1)
            {
                return array[array.Length / 2];
            }
            else
            {
                return ((float)(0.5 * (array[array.Length / 2 - 1] + array[array.Length / 2])));
            }
        }

        public static double AverageFunction(int[] array)
        {
            double sum = 0;
            foreach (int number in array)
            {
                sum += number;
            }

            return sum / array.Length;
        }
    }
}
