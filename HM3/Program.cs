//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool ResultPolen(int number)
{
    string temp = "";
    int num = number;
    
    while(num > 0)
    {
        temp = temp + (num % 10);
        num = num / 10;
    }
    return Convert.ToInt32(temp) == number;
}
Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = ResultPolen(number);
if(result) 
    Console.Write("Palindrome");
else
    Console.Write("Not a palindrome");
*/
//Задача 21.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double x, double y, double z, 
double x1, double y1, double z1)
{
    double num = 0;
    num = Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2);
    num = Math.Sqrt(num);
    return num;
}

Console.Write("Input x-coordinate: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinate: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z-coordinate: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x1-coordinate: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1-coordinate: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z1-coordinate: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistance = FindDistance(x, y, z, x1, y1, z1);
Console.WriteLine($"The point distance ({x}, {y}, {z}) and ({x1}, {y1}, {z1}) is {findDistance}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNumbers(number);
Console.WriteLine($"{number}");
*/