int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
            array [i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая покажет 
//количество чётных чисел в массиве.
/*
int EvenNumber(int[] array)
{
	int current = 0;
	
	for(int i = 0; i < array.Length; i++)
	{
		if(array[i] % 2 == 0)
		{
			Console.Write(array[i] + " ");
			current++;
		}
	}
	return current;	
}

int result = EvenNumber(myArray);
Console.WriteLine("Even number in is array " + result);
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumOdd(int[] array)
{
	int sum = 0;
	
	for(int i = 0; i < array.Length; i++)
	{		
		if(i % 2 == 1)
		sum += array[i];
	}
	return sum;
}
		
int result = SumOdd(myArray);
Console.WriteLine("Sum of odd elements " + result);
*/

//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
int DefferenceMinMax(int[] array)
{
	int def = 0;
	int min = array[0];
    int max = array[0];
	for(int i = 0; i < array.Length; i++)
	{
		if(min > array[i])
            min = array[i];
        if(max < array[i])
            max = array[i];
	}
    def = max - min;
	return def;
}

int result = DefferenceMinMax(myArray);
Console.WriteLine("Defference min and max is " + result);
*/