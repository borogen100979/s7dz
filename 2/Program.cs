﻿﻿// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 

// m = 2, n = 3 -> A(m,n) = 29


int AkkermanFunction (int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0) 
    {
        return AkkermanFunction(m - 1, 1);
    }
    else 
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({m}, {n}) = {AkkermanFunction(m, n)}");

