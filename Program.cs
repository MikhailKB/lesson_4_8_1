using System;
using static System.Console;

namespace lesson_4_8_1
{
    internal class Program
    {
        static void Main(string[] args)  // точка входа
        {

            Write("Введите количество строк и нажмите \"Enter\": ");
            int lines = int.Parse(ReadLine());
            Write("Введите количество столбцов и нажмите \"Enter\": ");
            int colums = int.Parse(ReadLine());

            var A = new int[lines, colums];

            Random r = new Random();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                int sum = 0;

                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = r.Next(1, 5);
                    sum += A[i, j];
                    Write($"{A[i, j],2}");
                }
                WriteLine($" : {sum}  {"Сумма"}");
            }
            ReadKey();
        }
    }
}