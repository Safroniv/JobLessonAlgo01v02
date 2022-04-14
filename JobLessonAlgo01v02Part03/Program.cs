using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobLessonAlgo01v02Part03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, вычисляющую число Фибоначчи для заданного значения рекурсивным способом. 
            int number01 = 5;
            Console.WriteLine(GetFibonacci(number01));
            int number02 = 10;
            Console.WriteLine(GetFibonacci(number02));
            int number03 = 20;
            Console.WriteLine(GetFibonacci(number03));
            int number04 = 0;
            Console.WriteLine(GetFibonacci(number04));
            int number05 = -1;
            Console.WriteLine(GetFibonacci(number05));
        }
        //Вычисление числа Фибоначчи рекурсивным способом
        static int GetFibonacci(int number)
        {
            if (number == 0 || number == 1)
            {
                return number;
            }
            return GetFibonacci(number - 1) + GetFibonacci(number - 2);
        }
    }
}
