using System;

namespace JobLessonAlgo01v02Part01
{
    class Program
    {
        public class TestCase
        {
            public int Number { get; set; }
            public string Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
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

        static void Test(TestCase testCase)
        {
            try
            {
                var actual = PrimeNumberOrNot(testCase.Number);
                if (actual == testCase.Number && testCase.Number > 0)
                {
                    Console.WriteLine("Тест успешен");
                }
                else
                {
                    Console.WriteLine("Тест провален");
                }
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("Тест успешен");
                }
                else
                {
                    Console.WriteLine("Тест провален");
                }
            }
        }
        static void Main()
        {
            var testCase1 = new TestCase()
            {
                Number = 6,
                Expected = "Число 6 - Не простое число",
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                Number = 7,
                Expected = "Число 7 - Простое число",
                ExpectedException = null
            };
            var testCase3 = new TestCase()
            {
                Number = 9,
                Expected = "Число 9 - Не простое число",
                ExpectedException = null
            };
            var testCase4 = new TestCase()
            {
                Number = 0,
                Expected = "Число 0 - Не простое число",
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                Number = -50,
                Expected = "Число -50 - Не простое число",
                ExpectedException = null
            };
            Test(testCase1);
            Test(testCase2);
            Test(testCase3);
            Test(testCase4);
            Test(testCase5);
            Console.ReadLine();
        }
    }
}

