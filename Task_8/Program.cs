//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

int endOfPositiveNumbers = 0;
int count = number;

while (count > endOfPositiveNumbers)
{
    if (count % 2 == 0)
    {
    Console.WriteLine(count);
    }
    count--;
}