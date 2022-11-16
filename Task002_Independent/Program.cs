//Напишите программу, которая будет выдавать название дня недели по заданному номеру (среда->3, пятница->5)//
Console.WriteLine("Введите число:");
string input = Console.ReadLine();
int number = Convert.ToInt32 (input);
if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 3)
{
    Console.WriteLine("Cреда");
}
else if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 6)
{
    Console.WriteLine("Суббота");
}
else if (number == 7)
{
    Console.WriteLine("Воскресенье");
}