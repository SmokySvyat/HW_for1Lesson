//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine());

int max = 0;


if (number1 > number2)
{
    max = number1;
}
else if (number1 < number2)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}


Console.WriteLine("Число " + max + " больше.");