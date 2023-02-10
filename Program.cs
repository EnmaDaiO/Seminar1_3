/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16 
-3 -> 9 
-7 -> 49*/
// Console.Write("Введите числоа для которого мы ищем квадрат: ");
// тип_данных имя переменной = значение

// int number = Convert.ToInt32(Console.ReadLine());

// //математика :)

// int result = number * number; // namber * namber = (number)^2

// Console.WriteLine("Квадрат от числа " + number + " равен " + result);
//=========================
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// 
// Console.Write("Введите первое число: ");
// int firstValue = Convert.ToInt32(Console.ReadLine()); 
// // CamelCase => firstValue, secondValue, firstNamber

// Console.Write("Введите второе число: ");
// int secondValue = Convert.ToInt32(Console.ReadLine()); 
// // firstValue = 25, secondValue = 5
// // Точка с запятой не ставится перед "{"
// if (firstValue == Math.Pow(secondValue, 2)) // Matp.Pow(число, степень)
// {
//     Console.WriteLine("Число " + firstValue + " является квадратом от " + secondValue);// true
// }
// else
// {
//     Console.WriteLine("Число " + firstValue + " НЕ является квадратом от " + secondValue);// true
// }
//===========================
// 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());
int negativeN = N * (-1);
while (negativeN <= N)
{
    Console.WriteLine(negativeN);
    negativeN++; // increment: negativeN = negativeN + 1
}