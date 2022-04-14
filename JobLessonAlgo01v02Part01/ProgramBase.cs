using System;

namespace JobLessonAlgo01v02Part01
{
    internal class ProgramBase
    {
        public static int PrimeNumberOrNot(int number)
        {
            int d = 0;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;

            }

            string expected;
            if (d == 0)
            {
                expected = $"Число {number} - Простое число";
            }
            else
            {
                expected = $"Число {number} - Не простое число";
            }
            Console.WriteLine(expected);
            return number;
        }


    }
}