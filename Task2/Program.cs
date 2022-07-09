// Напишите программу, которая на вход принимает два числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("Максимальное число = " + a);
}
else
{
    Console.WriteLine("Максимальное число = " + b);
}