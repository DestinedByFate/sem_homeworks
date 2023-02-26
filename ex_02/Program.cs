// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the third number: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double max = 0;

if (num1 >= num2 && num1 >= num3) 
{
    max = num1;
    Console.WriteLine($"Max number is {max}");
}
else if (max < num2 && num2 > num3)
{
    max = num2;
    Console.WriteLine($"Max number is {max}");
}
else 
{
    max = num3;
    Console.WriteLine($"Max number is {max}");
}