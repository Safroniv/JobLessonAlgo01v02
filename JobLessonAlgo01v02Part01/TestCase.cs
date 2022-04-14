using System;

namespace JobLessonAlgo01v02Part01
{
    partial class Program
    {
        public class TestCase
        {
            public int Number { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }
            public void Test()
            {
                try
                {
                    var actual = PrimeNumberOrNot(Number);
                    if (actual == Number && Number > 0)
                    {
                        Console.WriteLine("Тест успешен");
                    }
                    else
                    {
                        Console.WriteLine("Тест провален");
                        Console.WriteLine("Должно быть: Число - Не простое число");
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
}

