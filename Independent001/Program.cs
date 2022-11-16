/*Задача №1 напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
int a = 2;
int b = 4;
if (a == b * b)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
if (b == a * a);
    {
        Console.WriteLine("Второе число является квадратом первого");
    }*/
    Console.WriteLine("Введите 2 числа");
    int firstnumber = Convert.ToInt32(Console.ReadLine());
    int secondnumber = Convert.ToInt32(Console.ReadLine());
        if (firstnumber == secondnumber * secondnumber)
     {
        Console.WriteLine("Первое число является квадратом второго");
    }
        if (secondnumber == firstnumber * firstnumber)
    {
        Console.WriteLine("Второе число является квадратом первого");
    }
        if (firstnumber != secondnumber * secondnumber)
        {
        Console.WriteLine("Первое число не является квадратом второго");
        }
        if (secondnumber != firstnumber * firstnumber)
        Console.WriteLine("Второе число не является квадратом первого");
