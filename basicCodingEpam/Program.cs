using System;

namespace basicCodingEpam
{
    public class Program
    {
        static private int maxValue = 0;
        static private int count = 0;

        static void Main(string[] args)
        {
            int[] a = new int[]{3, 15, 28, 10, 11, 5, 16, 22};
            Console.Write(findMaxValue(a));
        }

        public static int findMaxValue(int[] mass)
        {
            if (mass.Length <= count)
            {
                return maxValue;
            } else if (mass[count] > maxValue)
            {
                maxValue = mass[count];
            }
            count++;
            return findMaxValue(mass);
        }
    }
}
