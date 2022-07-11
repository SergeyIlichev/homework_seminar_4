/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

int GetNumber(string message)
{
    int result = 0;
    Console.WriteLine(message);
    while (true)
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine("Вы ввели не число, введите число");
        }
    return result;
}

void GetSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        int numberDigit = number % 10;
        result = result + numberDigit;
        number = number / 10;
    }
    Console.WriteLine(result);
}

int number = GetNumber("Введите число");
GetSum(number);
