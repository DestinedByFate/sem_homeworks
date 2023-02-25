// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double max = 0;
double min = 0;

if (num1 > num2) 
{
    max = num1;
    min = num2;
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Минимальное число: " + min);
}
else 
{
    max = num2;
    min = num1;
    Console.WriteLine("Максимальное число: " + max);
    Console.WriteLine("Минимальное число: " + min);
}