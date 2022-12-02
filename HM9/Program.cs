// Задача №1
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void getNumbers(int n) 
{
    if (n == 1)
    {
        Console.Write($"{n}");
        return;
    } else {
        Console.Write($"{n}, ");
    }
    getNumbers(n-1);
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
getNumbers(number);
*/

// Задача №2
// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int sumNM(int m, int n, int sum = 0)
{
    if (m == n)
    {
        return sum + m;
    } else
    {
        return sumNM(m + 1, n, sum + m);
    }
}

Console.WriteLine("Input m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = Convert.ToInt16(Console.ReadLine());
int resultSum = sumNM(m, n);
Console.WriteLine(resultSum);
*/

// Задача №3
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0) {
        return Akkerman(m - 1, 1);
    }
    return Akkerman(m - 1, Akkerman(m, n-1));
}

Console.WriteLine("Input m: ");
int m = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Input n: ");
int n = Convert.ToInt16(Console.ReadLine());
int resultAkkerman = Akkerman(m, n);
Console.WriteLine(resultAkkerman);
*/