// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;


Console.Write("Even numbers are: ");

while (count <= number)
{
    if (count % 2 == 0) 
    {
        Console.Write(count + " ");
    }
    count++;
}
if (number == 0 || number == 1)
{
    Console.Write("none");
}