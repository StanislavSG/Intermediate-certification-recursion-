// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void Main()
    {
        int M = 0; // Начальное значение M
        int N = 10; // Конечное значение N

        Console.WriteLine("Вывод чисел от " + M + " до " + N);
        RecursivePrintNumbers(M, N);
    }

    static void RecursivePrintNumbers(int currentNumber, int end)
    {
        if (currentNumber <= end)
        {
            Console.Write(currentNumber + " ");
            RecursivePrintNumbers(currentNumber + 1, end);
        }
    }
}

