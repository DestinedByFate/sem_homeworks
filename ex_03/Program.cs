// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input number: ");
double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine($"{number} - number is even");
}
else
{
    Console.WriteLine($"{number} - number is uneven");
}