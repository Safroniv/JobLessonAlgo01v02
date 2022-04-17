using System;

namespace JobLessonAlgo01v02Part03
{
    class TestFibonacci : ProgramBase
    {
        public int Number { get; set; }
        public int Expected { get; set; }
        public Exception ExpectedException { get; set; }
        public void Test(TestFibonacci testFibonacci)
        {
            try
            {
                Console.WriteLine($"===========================Новый тест ===============================");

                if (Number < 0)
                {
                    Console.WriteLine("Тест провален, число не может быть отрицательным!");

                }
                else if (GetFibonacciRecurce(Number) == testFibonacci.Expected)
                {
                    Console.WriteLine("Вычисление числа Фибоначчи через рекурсию.");
                    Console.WriteLine("Тест успешен");
                    Console.WriteLine($"Значение числа Фибоначчи F({Number}) = {GetFibonacciRecurce(Number)}");
                }
                else
                {
                    Console.WriteLine("Вычисление числа Фибоначчи через рекурсию.");
                    Console.WriteLine("Тест провален");
                    Console.WriteLine($"Значение числа Фибоначчи F({Number}) = {GetFibonacciRecurce(Number)}");
                }

                if (Number < 0)
                {
                    Console.WriteLine("Тест провален, число не может быть отрицательным!");

                }
                else if (GetFibonacciWithoutRecurce(Number)==testFibonacci.Expected)
                {
                    Console.WriteLine("Вычисление числа Фибоначчи без рекурсии.");
                    Console.WriteLine("Тест успешен");
                    Console.WriteLine($"Значение числа Фибоначчи F({Number}) = {GetFibonacciWithoutRecurce(Number)}");
                }
                else
                {
                    Console.WriteLine("Вычисление числа Фибоначчи без рекурсии.");
                    Console.WriteLine("Тест провален");
                    Console.WriteLine($"Значение числа Фибоначчи F({Number}) = {GetFibonacciWithoutRecurce(Number)}");
                }

            }
            catch (Exception)
            {
                if (ExpectedException != null)
                {
                    Console.WriteLine("Тест успешен");
                }
                else
                {
                    Console.WriteLine("Тест провален");
                }
            }

        }


    }
}
