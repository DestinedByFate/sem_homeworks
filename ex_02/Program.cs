// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Input first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());
max = 0;

if (num1 > num2 > num3)
{
    max = num1;
}