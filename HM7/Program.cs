//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
/*
double [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().NextDouble() * new Random().Next(minVal, maxVal);

    return array;
}

void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
            Console.Write(Math.Round(array[i,j], 2) + " ");
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции(индексы i и j) 
//элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> числа с такими индексами в массиве нет

int [,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal, maxVal + 1);

    return array;
}

void Show2dArray (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
/*
void ElementPosition(int[,] array)
{
    Console.Write("Input a row index: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a column index: ");
    int column = Convert.ToInt32(Console.ReadLine());

    if(row < array.GetLength(0) && column < array.GetLength(1))
        Console.WriteLine($"{array[row, column]} - number in array");
    else
        Console.WriteLine($"{row} {column} - no number in array");
}


ElementPosition(myArray);
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(Math.Round(array[i], 2) + " ");
    
    Console.WriteLine();
}

double [] Average(int[,] array)
{
    double[] retArray = new double [array.GetLength(1)];
    
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        retArray[i] = (double)sum / array.GetLength(0);
    }
    return retArray;
}

Console.WriteLine();
double [] srArifm = Average(myArray);

ShowArray(srArifm);
*/





