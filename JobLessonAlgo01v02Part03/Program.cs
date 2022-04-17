using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonAlgo01v02Part03
{
    internal class Program : ProgramBase
    {
        static void Main()
        {
            //Программа, вычисляющая число Фибоначчи для заданного значения
            //рекурсивным способом и без рекурстии. 
            var testFibonacciRecurse01 = new TestFibonacci()
            {
                Number = 3,
                Expected = 2,
                ExpectedException = null
            };
            testFibonacciRecurse01.Test(testFibonacciRecurse01);
            var testFibonacciRecurse02 = new TestFibonacci()
            {
                Number = 12,
                Expected = 144,
                ExpectedException = null
            };
            testFibonacciRecurse02.Test(testFibonacciRecurse02);
            var testFibonacciRecurse03 = new TestFibonacci()
            {
                Number = 0,
                Expected = 0,
                ExpectedException = null,
            };
            testFibonacciRecurse03.Test(testFibonacciRecurse03);
            var testFibonacciRecurse04 = new TestFibonacci()
            {
                Number = -1,
                //Должен Выдать: Тест провален, число не может быть отрицательным!
                ExpectedException = null
            };
            testFibonacciRecurse04.Test(testFibonacciRecurse04);
            var testFibonacciRecurse05 = new TestFibonacci()
            {
                Number = -150,
                //Должен Выдать: Тест провален, число не может быть отрицательным!
                ExpectedException = null
            };
            testFibonacciRecurse05.Test(testFibonacciRecurse05);
            Console.ReadLine();
        }
    }
}
