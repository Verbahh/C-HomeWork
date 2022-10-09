/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindSecondDigit (int num)
{
	int result;
	if(num < 100 || num >= 1000)
		return 0;
	int dec = num / 10;
	int ed = dec % 10;
	result = ed;
	return result;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Second Digit of {number} is {secondDigit}");
*/

/*
//Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindThirdDigit(int num)
{
	int result = 0;
    int temp;
	if(num <= 99)
        Console.Write("Not number");
    else 
    {
        temp = num;
        while(temp > 99)
        {
            result = temp % 10;
            temp = temp / 10;
        }
    }
    return result;
}

Console.Write("Input a two-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num = FindThirdDigit(number);
Console.Write("Number: " + num);
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string DayWeek(int num)
{
    if(num > 5 && num <= 7)
        return "day off";
    else 
        return "working day";
}

Console.Write("Input a week day number: ");
int number = Convert.ToInt32(Console.ReadLine());

string dayWeek = DayWeek(number);
Console.WriteLine($"Day week of {number} is {dayWeek}");
*/