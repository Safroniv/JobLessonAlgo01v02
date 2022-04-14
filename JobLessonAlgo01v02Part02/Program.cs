namespace JobLessonAlgo01v02Part02
{

    class Program
    {
        static void Main()
        {
            //Вычислить асимптотическую сложность функции StrangeSum.
            
        }
        static int StrangeSum(int[] inputArray)
        {
            //Вычисление сложности
            int sum = 0; //O(1)
            for (int i = 0; i < inputArray.Length; i++)//O(N)
            {
                for (int j = 0; j < inputArray.Length; j++)//O(N)
                {
                    for (int k = 0; k < inputArray.Length; k++) // O(N)
                    {
                        int y = 0;//O(1)
                        if (j != 0)
                        {
                            y = k / j;//O(1)
                        }
                        sum += inputArray[i] + i + k + j + y;//O(1)
                    }
                }
            }
            return sum;
            //Так как наш алгоритм содержит три вложенных цикла
            //Общая производительность алгоритма составит: O(1+N*N*(N+3))
            //Выполним упрощение асимптотической сложности по Правилу 3 и получим, что:
            //асимптотическая сложность равна O(N^3) (кубическая функция N).

        }
    }

}
