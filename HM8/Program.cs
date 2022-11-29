//Задача 54:Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//(с помощью сортировки, пузырьковая сортировка)
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateRandom2DArray()
{
    Console.WriteLine("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min possible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max possible value: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minVal, maxVal + 1);
    
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
/*
int [,] SortDescending(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, j] < array[i, k])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
    }
    return array;
}
*/
/*
int [,] mainArray = CreateRandom2DArray();
Show2DArray(mainArray);
*/
/*
int [,] myArray = SortDescending(mainArray);
Show2DArray(myArray);
*/


// Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// (во внутреннем цикле суммируются значения и сравнивается друг с другом поэтапно)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
//с наименьшей суммой элементов: 1 строка
/*
int MinSumRow(int[,] array)
{
    int sumRow = 0;
    int minRow = 0;

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            temp += array[i, j];
        }
        if (i == 0) 
        {
            sumRow = temp;
        } 
        else 
        {
            if (temp < sumRow) {
                sumRow = temp;
                minRow = i;
            }
        }
    }
    Console.WriteLine($"Минимальная сумма в {minRow + 1} строке");
    return minRow;
}

int minRows = MinSumRow(mainArray);
*/
// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int [,] mainArray = CreateRandom2DArray();
// Show2DArray(mainArray);

int [,] twoMainArray = CreateRandom2DArray();
// TwoShow2DArray(twoMainArray);

int [,] ProductTwoMatrices(int[,] array, int[,] twoArray)
{
    int[,] threeArray = new int [array.GetLength(0), twoArray.GetLength(1)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < twoArray.GetLength(1); j++)
        {
            for (int k = 0; k < twoArray.GetLength(0); k++)
            {
                threeArray[i, j] += array[i, k] * twoArray[k, j];
            }
        }
    }
    return threeArray;
}

Show2DArray(mainArray);
Show2DArray(twoMainArray);
int [,] resArray = ProductTwoMatrices(mainArray, twoMainArray);
Show2DArray(resArray);
*/



//Задача 62 Напишите программу, которая заполнит спирально массив 4 на 4.
// (заполненение массива по часов стрелке, решить для массива на сколько угодно, 
//не обязательно квадратный)
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
void Spiral()
{
    Console.Write("Input a number of rows: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int M = Convert.ToInt32(Console.ReadLine());
    // int N = array.GetLength(0);
    // int M = array.GetLength(1);
    int[,] newArray = new int[N, M]; 
    int iBeg = 0;         //точки поворота спирали
    int iFin = 0;
    int jBeg = 0;
    int jFin = 0;
    
    
    int k = 1;
    int i = 0;
    int j = 0;
    while(k <= N * M)
    {
        newArray[i, j] = k;
        if(i == iBeg && j < M - jFin - 1)
            j++;
        else if(j == (M - jFin - 1) && i < (N - iFin - 1))
            i++;
        else if(i == (N - iFin - 1) && j > jBeg)
            j--;
        else
            i--;
        if ((i == iBeg + 1) && (j == jBeg) && (jBeg != M - jFin - 1))
        {
            ++iBeg;
            ++iFin;
            ++jBeg;
            ++jFin;
        }
        ++k;
    }
    int max = Convert.ToString(N * M).Length;
    for (int x = 0; x < N; x++)
    {
        for (int y = 0; y < M; y++)
        {
            string temp = "";
            if (Convert.ToString(newArray[x, y]).Length < max)
            {
                for (int h = Convert.ToString(newArray[x, y]).Length; h < max; h++)
                {
                    temp += "0";
                }
                temp += Convert.ToString(newArray[x, y]);
                // temp = "0" * (max-temp.Length)
            } else
            {
                temp = Convert.ToString(newArray[x, y]);
            }
            temp += " ";
            Console.Write(temp);
        }
        Console.Write("\n");
    }
}

// int [,] mainArray = CreateRandom2DArray();
// Show2DArray(mainArray);

Spiral();
*/

