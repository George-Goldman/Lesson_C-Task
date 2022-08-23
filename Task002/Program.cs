// Написать программу, которая на вход принимает число и выдаёт его квадрад.
// (число умноженное на само себя).

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
System.Console.Write("Квадрат числа равен ");
Console.WriteLine(result);