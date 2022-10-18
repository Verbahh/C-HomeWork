//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int a, int b)
{
    int s = b;
    for(int current = 1; current < a; current++)
        // s *= b; 
        s = s * b;
return s;
}

Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int number = Degree(b, a);
Console.WriteLine($"Number {a} in degree {b} is {number}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNumber(int a)
{
    int sum = 0;
    while(a > 0)
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
    }
return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = SumNumber(number);
Console.WriteLine($"Sum number {number} is {num}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int [] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
            array [i] = new Random().Next(1,50);  //Немного не поняла сути задачи. По идее код, который разбирали на 4 семинаре по массиву, подходит и к этой задаче. Поэтому решила убрать max и min и поставила свой интвервал чисел для массива.
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
ShowArray(myArray);
*/

//Дополнительная задача. Сгенерировать метод, который будет у пользователя запрашивать элементы массива.
/*
int[] CreateArray (int size) //, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input number of elements: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Size array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/
