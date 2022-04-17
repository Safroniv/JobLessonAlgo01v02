using System;

namespace JobLessonAlgo01v02Part01
{
    partial class Program : ProgramBase
    {
        static void Main()
        {
            NewMethod();
        }

        private static void NewMethod()
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
                Number = -7,
                Expected = "Число 0 - Не простое число",
                ExpectedException = null
            };
            var testCase5 = new TestCase()
            {
                Number = -50,
                Expected = "Число -50 - Не простое число",

                ExpectedException = null
            };
            testCase1.Test();
            testCase2.Test();
            testCase3.Test();
            testCase4.Test();
            testCase5.Test();
            var testCase6 = new TestCase();
            UserPrimeNumberOrNot(testCase6.Number);

            Console.ReadLine();
        }
    }
}

