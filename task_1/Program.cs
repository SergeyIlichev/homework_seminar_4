/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

double GetNumber(string message)
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

double firstNumber = GetNumber("Введите первое число");
double secondNumber = GetNumber("Введите второе число");
double product = Math.Pow(firstNumber, secondNumber);
Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно {product}");