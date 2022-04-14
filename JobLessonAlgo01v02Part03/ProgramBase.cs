namespace JobLessonAlgo01v02Part03
{
    internal class ProgramBase
    {
        //Вычисление числа Фибоначчи рекурсивным способом:
        public static int GetFibonacciRecurce(int number)
        {
            
            if (number == 0 || number == 1)
            {
                return number;
            }
            return GetFibonacciRecurce(number - 1) + GetFibonacciRecurce(number - 2);
        }
        //Вычисление числа Фибоначчи способом без рекурсии:
        public static int GetFibonacciWithoutRecurce(int number)
        {
            if (number == 0)
            {
                return number;
            }
            else
            {
                int n = number;
                int[] fiboncciSumm = new int[n + 1];
                fiboncciSumm[0] = 0;
                fiboncciSumm[1] = 1;
                for (int i = 2; i <= n; i++)
                {

                    fiboncciSumm[i] = fiboncciSumm[i - 2] + fiboncciSumm[i - 1];

                }

                return fiboncciSumm[n];
            }
        }
    }
}