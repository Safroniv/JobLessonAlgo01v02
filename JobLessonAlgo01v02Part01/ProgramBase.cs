using System;

namespace JobLessonAlgo01v02Part01
{
    internal class ProgramBase
    {
        /// <summary>
        /// Метод определения простого числа
        /// </summary>
        /// <param name="number">Объект исследования простое число или нет</param>
        /// <returns>Результат</returns>
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

        public static int UserPrimeNumberOrNot(int number)
        {
            int d = 0;
            int i = 2;
            Console.WriteLine("Введите число");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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